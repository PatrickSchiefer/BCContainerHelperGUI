using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BCDockerHelper
{
    public enum ContainerStatus
    {
        stopped,
        unhealthy,
        starting,
        healthy,
        unknown
    }
    public class Container
    {
        #region Properties
        public string ID { get; set; }
        public string Containername { get; set; }
        public ContainerStatus ContainerStatus { get; set; }
        public string ContainerStatusText { get; set; }
        public string Image { get; set; }
        public string Log { get; set;}
        public string WebClientUrl { get; set; }
        
        private const string WebClientPattern = "(Web Client[ ]*: )(http.*)";
        #endregion

        #region Methods
        public async Task Restart()
        {
            await PowershellHelper.Instance.RestartContainer(Containername);
            return;
        }
        public async Task Stop()
        {
            await PowershellHelper.Instance.StopContainer(Containername);
            return;
        }
        public async Task Start()
        {
            await PowershellHelper.Instance.StartContainer(Containername);
            return;
        }

        public async Task Remove()
        {
            await PowershellHelper.Instance.RemoveContainer(Containername);
            return;
        }

        public async Task ImportLicense(string licensePath)
        {
            await PowershellHelper.Instance.ImportLicenseToContainer(Containername, licensePath);
            return;
        }

        public void GetLog()
        {
            Log = PowershellHelper.Instance.GetLog(ID);
        }

        public void GetWebClientUrl()
        {
            GetLog();
            RegexOptions options = RegexOptions.Multiline;
            var matches = Regex.Matches(Log, WebClientPattern, options);
            Match lastMatch = null;
            foreach (Match m in matches)
                lastMatch = m;
            if (lastMatch != null)
            {
                WebClientUrl = lastMatch.Groups.Count >= 2 ? lastMatch.Groups[2].Value : "";
            }
        }

        public override string ToString()
        {
            return Containername;
        }


        #endregion
    }
}
