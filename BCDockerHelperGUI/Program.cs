using BCDockerHelper.Resources;
using BCDockerHelper.UI;
using System;
using System.Collections.Generic;
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
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.FirstLaunch)
            {
                if (MessageBox.Show(GlobalRessources.AskForStart, "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    Application.Exit();
                    return;
                }
            }
            Properties.Settings.Default.FirstLaunch = false;
            Properties.Settings.Default.Save();
            InitForm.Instance.Show();
            Application.DoEvents();
            Application.Run(new MainForm());
            PowershellHelper.Instance.StopAllTasks();
        }
    }
}
