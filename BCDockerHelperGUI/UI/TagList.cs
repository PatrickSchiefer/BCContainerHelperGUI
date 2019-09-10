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
        List<string> listtags = new List<string>();
        public TagList()
        {
            InitializeComponent();
        }

        public void SetTags(List<Tag> tags)
        {
            foreach (Tag t in tags)
            {
                listtags.Add(t.Name);
            }
            FillList();
        }

        public void FillList()
        {
            lstTags.Items.Clear();
            foreach (string t in listtags)
            {
                if (String.IsNullOrEmpty(txtFilter.Text) || (t.Contains(txtFilter.Text)))
                {
                    if (string.IsNullOrEmpty(selected)) selected = t;
                    lstTags.Items.Add(t);
                }
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FillList();
        }
    }
}
