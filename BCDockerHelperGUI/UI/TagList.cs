using BCDockerHelper.Classes;
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
    public partial class TagList : Form
    {
        string selected;
        public TagList()
        {
            InitializeComponent();
        }

        public void SetTags(List<Tag> tags)
        {
            foreach (Tag t in tags)
            {
                if (string.IsNullOrEmpty(selected)) selected = t.Name;
                lstTags.Items.Add(t.Name);
            }
        }

        public string GetSelected()
        {
            return selected;
        }

        private void LstTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = lstTags.SelectedItem.ToString();
        }
    }
}
