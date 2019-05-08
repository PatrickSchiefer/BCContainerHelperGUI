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
    public partial class InitForm : Form
    {
        private static InitForm _instance;
        public static InitForm Instance
        {
            get
            {
                return _instance = _instance == null ? new InitForm() : _instance;
            }
        }
        private InitForm()
        {
            InitializeComponent();
        }

    }
}
