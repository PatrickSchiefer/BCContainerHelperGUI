using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCDockerHelper.UI
{
    public partial class DockerLoginForm : Form
    {
        public DockerLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TaskFactory tf = new TaskFactory();
            var result = PowershellHelper.Instance.RegistryLogin(txtRegistry.Text, txtUsername.Text, txtPassword.Text);
            tf.FromAsync(result, (x) =>(x));
            this.Close();
        }
    }
}
