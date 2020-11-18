using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCDockerHelper.Classes
{
    class PowerShellCommandBuilder
    {
        private string functionName;

        public PowerShellCommandBuilder(string functionName)
        {
            this.functionName = functionName;
            GetParams();
        }


        private void GetParams()
        {
            PowershellHelper.Instance.ExecuteScript(Resources.GlobalRessources.GetParam);
            MessageBox.Show(PowershellHelper.Instance.ExecuteScript(String.Format("Get-FunctionDefaultParameter -FunctionName {0}", functionName)));
        }
    }
}
