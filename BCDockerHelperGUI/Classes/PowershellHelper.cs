using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Runtime.Remoting.Messaging;
using BCDockerHelper.Resources;
using System.Text.RegularExpressions;

namespace BCDockerHelper
{
    class PowershellHelper
    {
        private const string PasswordRegexPattern = "(ConvertTo-SecureString -String \")(.*)(\" -AsPlainText)";


        #region Singleton definition
        private static PowershellHelper _instance;
        public static PowershellHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PowershellHelper();
                return _instance;
            }
        }

        private PowershellHelper()
        {
            scriptInstance = PowerShell.Create();
            scriptInstance.Streams.Error.DataAdded += ErrorDataAdded;
            scriptInstance.Streams.Information.DataAdded += MessageDataAdded;
            scriptInstance.Streams.Progress.DataAdded += ProgressDataAdded;
            InstallNavContainerHelper();
            InitializeAsyncScriptInstance();
        }

        private void InstallNavContainerHelper()
        {
            var pipeline = scriptInstance.Runspace.CreatePipeline();
            pipeline.Input.Write("Y");
            StringBuilder command = new StringBuilder();
            command.AppendLine("[System.Threading.Thread]::CurrentThread.CurrentCulture = \"en-US\" ");
            command.AppendLine("if (-not (Get-InstalledModule -Name navcontainerhelper -MinimumVersion \"0.6.2.95\")) {");
            command.AppendLine("Install-Module navcontainerhelper -MinimumVersion \"0.6.2.95\" -Scope AllUsers -Force -SkipPublisherCheck");
            command.AppendLine("}");
            pipeline.Commands.AddScript(command.ToString());
            pipeline.Invoke();
        }



        private void InitializeAsyncScriptInstance()
        {
            asyncScript = PowerShell.Create();
            InitializePSO();
            asyncScript.Streams.Error.DataAdded += ErrorDataAdded;
            asyncScript.Streams.Information.DataAdded += MessageDataAdded;
            asyncScript.Streams.Progress.DataAdded += ProgressDataAdded;
            asyncScript.AddScript("Set-ExecutionPolicy -ExecutionPolicy Unrestricted");
            asyncScript.Invoke();
        }

        private void InitializePSO()
        {
            if (pso != null) pso.DataAdded -= PSODataAdded;
            pso = new PSDataCollection<PSObject>();
            pso.DataAdded += PSODataAdded;
        }

        #endregion

        #region Object variables
        private PowerShell scriptInstance;
        private PowerShell asyncScript;
        private PSDataCollection<PSObject> pso;

        public event EventHandler<string> ErrorCallback;
        public event EventHandler<string> MessageCallback;
        public event EventHandler<string> StartScriptCallback;
        public event EventHandler EndScriptCallback;
        #endregion


        #region Methods
        public List<Object> GetContainers()
        {
            List<Object> containers = new List<Object>();
            scriptInstance.AddScript("docker ps -a --format \"{{.ID}};{{.Names}};{{.Status}}\"");
            var results = scriptInstance.Invoke();
            foreach (var result in results)
            {
                string[] splitLine = result.ToString().Split(';');
                Container container = new Container();
                container.ID = splitLine[0];
                container.Containername = splitLine[1];

                string status = splitLine[2];
                if (status.StartsWith("Exited"))
                {
                    status = "Stopped";
                    container.ContainerStatus = ContainerStatus.stopped;
                }
                if (status.Contains('('))
                {
                    status = status.Substring(status.IndexOf('(') + 1, status.Length - status.IndexOf('(') - 2);
                    if (status.Contains("starting"))
                    {
                        status = "starting";
                    }
                    switch (status)
                    {
                        case "healthy":
                            container.ContainerStatus = ContainerStatus.healthy;
                            break;
                        case "unhealthy":
                            container.ContainerStatus = ContainerStatus.unhealthy;
                            break;
                        case "starting":
                            container.ContainerStatus = ContainerStatus.starting;
                            status = splitLine[2];
                            break;
                        default:
                            container.ContainerStatus = ContainerStatus.unknown;
                            status = splitLine[2];
                            break;

                    }
                }
                container.ContainerStatusText = status;

                containers.Add(container);
            }
            return containers;
        }

        public List<Object> GetImages()
        {
            List<Object> images = new List<Object>();
            scriptInstance.AddScript("docker images --format \"{{.ID}};{{.Repository}};{{.Tag}};{{.Size}}\"");
            var results = scriptInstance.Invoke();
            foreach (var result in results)
            {
                string[] splitLine = result.ToString().Split(';');
                Image image = new Image();
                image.ID = splitLine[0];
                image.Repository = splitLine[1];
                image.Tag = splitLine[2];
                image.Size = splitLine[3];
                images.Add(image);
            }
            return images;
        }



        public async Task<bool> RestartContainer(string containername)
        {
            return await PerformPowershellAsync(String.Format("Restart-BCContainer -containername '{0}'", containername));
        }
        public async Task<bool> StopContainer(string containername)
        {
            return await PerformPowershellAsync(String.Format("Stop-BCContainer -containername '{0}'", containername));
        }
        public async Task<bool> StartContainer(string containername)
        {
            return await PerformPowershellAsync(String.Format("Start-BCContainer -containername '{0}'", containername));
        }
        public async Task<bool> RemoveContainer(string containername)
        {
            return await PerformPowershellAsync(String.Format("Remove-BCContainer -containername '{0}'", containername));
        }

        public async Task<bool> RegistryLogin(string registry, string username, string password)
        {
            return await PerformPowershellAsync(String.Format("docker login \"{0}\" -u \"{1}\" -p \"{2}\"", registry,username,password));
        }

        public async Task<bool> RemoveImage(string ID)
        {
            return await PerformPowershellAsync(String.Format("docker rmi {0}", ID));
        }
        public async Task<bool> CreateContainer(string containername, 
                                                string username, 
                                                string password, 
                                                bool includeCside, 
                                                bool acceptEula, 
                                                string image,
                                                string tag,
                                                bool winAuth)
        {
            username = username.Split('\\').Last();
            StringBuilder command = new StringBuilder();
            command.AppendFormat("$credential = ([PSCredential]::new(\"{0}\", (ConvertTo-SecureString -String \"{1}\" -AsPlainText -Force))) \r\n", username, password);

            command.AppendFormat("New-BCContainer -accept_eula:{0} ", acceptEula ? "$TRUE" : "$FALSE");
            command.AppendFormat("-containername {0} ", containername);
            command.Append("-credential $credential ");
            command.AppendFormat("-auth {0}", winAuth? "Windows " : "NavUserPassword ");
            if (includeCside) command.Append("-includeCSide ");
            command.Append("-doNotExportObjectsToText ");
            command.Append("-usessl:$false ");
            command.Append("-updateHosts ");
            command.Append("-assignPremiumPlan ");
            command.Append("-shortcuts Startmenu ");
            command.Append("-useBestContainerOS ");
            command.AppendFormat("-imageName {0}", image);
            if (!String.IsNullOrEmpty(tag))
            {
                command.AppendFormat(":{0}", tag);
                command.Append(" ");
            }


            return await PerformPowershellAsync(command.ToString());
        }

        private async Task<bool> PerformPowershellAsync(string command)
        {
            return await PerformPowershellAsync(command, true);
        }
        private async Task<bool> PerformPowershellAsync(string command, bool importNavContainerHelper)
        {
            if (asyncScript.InvocationStateInfo.State == PSInvocationState.Running)
            {
                ErrorCallback?.Invoke(this, Resources.GlobalRessources.ErrorWaitForPreviousTask);
                return false;
            }
            StringBuilder sb = new StringBuilder();
            if (importNavContainerHelper)
                sb.AppendLine("import-module navcontainerhelper");
            sb.AppendLine(command);
            asyncScript.Commands.Clear();
            asyncScript.AddScript(sb.ToString());
            SendCommandToLog(command);
            pso.Clear();
            var result = asyncScript.BeginInvoke<PSObject, PSObject>(null, pso);
            await Task.Factory.FromAsync(result, x => { });
            if (asyncScript.HadErrors)
            {
                ErrorCallback?.Invoke(this, GlobalRessources.ErrorScriptCompletedWithError);
            }
            InitializePSO();
            EndScriptCallback?.Invoke(this, null);
            return true;
        }

        private void SendCommandToLog(string command)
        {
            
            command = Regex.Replace(command, PasswordRegexPattern, m=>m.Groups[1] + "****" + m.Groups[3]);
            StartScriptCallback?.Invoke(this, command);
        }

        public void ErrorDataAdded(Object sender, DataAddedEventArgs e)
        {
            PSDataCollection<ErrorRecord> dc = asyncScript.Streams.Error;
            for (int i = 0; i < dc.Count; i++)
            {
                ErrorCallback?.Invoke(this, dc[i].Exception.Message);
            }
            dc.Clear();
        }
        public void MessageDataAdded(Object sender, DataAddedEventArgs e)
        {
            PSDataCollection<InformationRecord> informations = (PSDataCollection<InformationRecord>)sender;
            for (int i = 0; i < informations.Count; i++)
            {
                MessageCallback?.Invoke(this, informations[i].ToString());
            }
            informations.Clear();
        }
        public void PSODataAdded(Object sender, DataAddedEventArgs e)
        {
            PSDataCollection<PSObject> informations = (PSDataCollection<PSObject>)sender;
            for (int i = 0; i < informations.Count; i++)
            {
                MessageCallback?.Invoke(this, informations[i].ToString());
            }
            informations.Clear();
        }
        public void ProgressDataAdded(Object sender, DataAddedEventArgs e)
        {
            PSDataCollection<ProgressRecord> dc = asyncScript.Streams.Progress;
            for (int i = 0; i < dc.Count; i++)
            {
                MessageCallback?.Invoke(this, dc[i].StatusDescription);
            }
            dc.Clear();
        }

        public void StopAllTasks()
        {
            asyncScript.Stop();
            EndScriptCallback?.Invoke(this, null);
        }
        #endregion



    }
}
