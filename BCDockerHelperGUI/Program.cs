using BCDockerHelper.Resources;
using BCDockerHelper.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BCDockerHelper
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CheckLocalAppData();
            if (Properties.Settings.Default.FirstLaunch)
            {
                if (MessageBox.Show(GlobalRessources.AskForStart, "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    Application.Exit();
                    return;
                }
            }
            ParseArguments(args);
            Properties.Settings.Default.FirstLaunch = false;
            Properties.Settings.Default.Save();
            InitForm.Instance.Show();
            Application.DoEvents();
            Application.Run(new MainForm());
            PowershellHelper.Instance.StopAllTasks();
            Classes.GUIBindings.Serialize(GuiSettingsPath);
        }

        public static void CheckLocalAppData()
        {
            string path = ApplicationDataPath;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
        public static string ApplicationDataPath
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                path = Path.Combine(path, Application.ProductName);
                return path;
            }
        }

        public static string GuiSettingsPath
        {
            get
            {
                return Path.Combine(ApplicationDataPath, "GUI.xml");
            }

        }

        public static void ParseArguments(string[] args)
        {
            bool skipContainerHelper = args.AsQueryable().Count(s => s.Equals("-skipContainerHelper")).Equals(1);
            if (skipContainerHelper)
            {
                PowershellHelper.SkipInstallContainerHelper = true;
            }
        }
    }
}
