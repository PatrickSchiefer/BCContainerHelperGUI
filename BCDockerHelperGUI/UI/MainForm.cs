using BCDockerHelper.Properties;
using BCDockerHelper.Resources;
using BCDockerHelper.UI;
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
    delegate void FillContainerHandler(List<Container> x);
    public partial class MainForm : Form
    {
        readonly int REFRESH_COUNTER = 30000;


        List<Container> Containers = new List<Container>();
        Container selectedItem = null;
        Task<List<Container>>  listBoxFiller;
        DateTime lastContainerRefresh = DateTime.Now;

        public MainForm()
        {
            InitializeComponent();
            InitializeContainerLst();
            RefreshButtons();
            PowershellHelper.Instance.MessageCallback += MessageCallback;
            PowershellHelper.Instance.ErrorCallback += ErrorCallback;
            PowershellHelper.Instance.StartScriptCallback += StartScriptCallback;
            PowershellHelper.Instance.EndScriptCallback += EndScriptCallback;
            refreshTimer.Interval = REFRESH_COUNTER;
            EndScriptCallback(null, null);
        }

        private void InitializeContainerLst()
        {
            lstContainer.View = View.Details;
            lstContainer.Columns.Add(new ColumnHeader
            {
                Name = (string)GlobalRessources.ContainerListColumn1,
                Text = (string)GlobalRessources.ContainerListColumn1,
                Width = -2
            });
            lstContainer.Columns.Add(new ColumnHeader
            {
                Name = (string)GlobalRessources.ContainerListColumn2,
                Text = (string)GlobalRessources.ContainerListColumn2,
                Width = -2
            });
            lstContainer.Columns.Add(new ColumnHeader
            {
                Name = (string)GlobalRessources.ContainerListColumn2,
                Text = (string)GlobalRessources.ContainerListColumn2,
                Width = -2
            });
            lstContainer.AutoArrange = true;
            lstContainer.FullRowSelect = true;
        }

        #region Control Events

        private void lstContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContainer.SelectedItems.Count > 0)
            {
                string id = lstContainer.SelectedItems[0].Text;
                SelectionChanged(id);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if ((lstContainer.Items.Count == 0) || ((DateTime.Now-lastContainerRefresh).TotalMilliseconds > REFRESH_COUNTER))
                FillListBox();
            refreshTimer.Start();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            refreshTimer.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshTimer.Stop();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            TaskFactory tf = new TaskFactory();
            var result = selectedItem.Restart();
            tf.FromAsync(result, x => { FillListBox(); });   
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TaskFactory tf = new TaskFactory();
            var result = selectedItem.Stop();
            tf.FromAsync(result, x => { FillListBox(); });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TaskFactory tf = new TaskFactory();
            var result = selectedItem.Start();
            tf.FromAsync(result, x => { FillListBox(); });
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            TaskFactory tf = new TaskFactory();
            var result = selectedItem.Remove();
            tf.FromAsync(result, x => { FillListBox(); });
        }

        private void btnNewBCContainer_Click(object sender, EventArgs e)
        {
            TaskFactory tf = new TaskFactory();
            
            var result = PowershellHelper.Instance.CreateContainer(txtContainerName.Text,
                                                        txtUsername.Text,
                                                        txtPassword.Text,
                                                        chkIncludeCside.Checked,
                                                        txtDockerImage.Text,
                                                        chkAccepEula.Checked,
                                                        txtDockerImage.Text);
            tf.FromAsync(result, x => { FillListBox(); });
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Equals(tabPage1))
            {
                SelectItemInList();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            InitForm.Instance.Hide();
        }

        #endregion

        #region Powershell Callbacks
        private void MessageCallback(object sender, string e)
        {
            if (InvokeRequired)
            {
                EventHandler<String> eventHandler = MessageCallback;
                Invoke(eventHandler, sender, e);
            }
            else
                rtfOutputLog.AppendLine(e);
        }
        private void ErrorCallback(object sender, string e)
        {
            if (InvokeRequired)
            {
                EventHandler<String> eventHandler = ErrorCallback;
                Invoke(eventHandler, sender, e);
            }
            else
            {
                rtfOutputLog.AppendLine(e,Color.Red);
            }
        }
        private void StartScriptCallback(object sender, string e)
        {
            if (InvokeRequired)
            {
                EventHandler<String> eventHandler = StartScriptCallback;
                Invoke(eventHandler, sender, e);
            }
            else
            {
                rtfOutputLog.AppendLine(e, Color.Blue);
                txCurrentScript.Text = String.Format(GlobalRessources.CurrentRunningScript, e);
                prgScriptRunning.Visible = true;
                prgScriptRunning.Style = ProgressBarStyle.Marquee;
            }
        }
        private void EndScriptCallback(object sender, object e)
        {
            prgScriptRunning.Style = ProgressBarStyle.Blocks;
            prgScriptRunning.Value = 0;
            prgScriptRunning.Visible = false;
            txCurrentScript.Text = GlobalRessources.Idle;
        }
        #endregion

        private void FillListBox()
        {
            if (listBoxFiller != null)
            {
                if (!listBoxFiller.IsCompleted)
                    return;
            }
            listBoxFiller = new Task<List<Container>>(PowershellHelper.Instance.GetContainers);
            listBoxFiller.ContinueWith((x) =>
            {
                FinishFillContainer(listBoxFiller.Result);
            });
            listBoxFiller.Start();

        }

        private void FinishFillContainer(List<Container> containers)
        {
            if (InvokeRequired)
            {
                FillContainerHandler eventHandler = FinishFillContainer;
                this.Invoke(eventHandler, containers);
            }
            else
            {
                Containers = containers;
                lstContainer.Items.Clear();
                foreach (Container c in Containers)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = c.ID;
                    item.SubItems.Add(c.Containername);
                    item.SubItems.Add(c.ContainerStatusText);
                    switch (c.ContainerStatus)
                    {
                        case ContainerStatus.healthy:
                            item.BackColor = Color.LightGreen;
                            break;
                        case ContainerStatus.unhealthy:
                            item.BackColor = Color.Red;
                            break;
                        case ContainerStatus.starting:
                            item.BackColor = Color.LightBlue;
                            break;

                    }
                    lstContainer.Items.Add(item);
                }
                foreach (ColumnHeader ch in lstContainer.Columns)
                    ch.Width = -2;
                if (Containers.Count(x => x.ID == ((selectedItem == null) ? "-1" : selectedItem.ID)) == 0)
                    if (Containers.Count > 0)
                    {
                        SelectionChanged(Containers[0].ID);
                    }
                    else
                    {
                        SelectionChanged("-1");
                    }

                SelectItemInList();
            }
        }

        private void SelectItemInList()
        {
            lstContainer.Select();
            if (selectedItem != null)
            {
                for (int i = 0; i < lstContainer.Items.Count; i++)
                {
                    if (lstContainer.Items[i].Text.Equals(selectedItem.ID))
                    {
                        lstContainer.Items[i].Selected = true;
                    }
                    else
                    {
                        lstContainer.Items[i].Selected = false;
                    }
                }
            }
        }

        private void SelectionChanged(string ID)
        {
            foreach (Container c in Containers)
            {
                if (c.ID.Equals(ID))
                {
                    selectedItem = c;
                    RefreshButtons();
                    return;
                }
            }
        }

        private void RefreshButtons()
        {
            if (selectedItem == null)
            {
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnRestart.Enabled = false;
            }
            else
            {
                switch (selectedItem.ContainerStatus)
                {
                    case ContainerStatus.healthy:
                        btnStart.Enabled = false;
                        btnStop.Enabled = true;
                        btnRestart.Enabled = true;
                        break;
                    case ContainerStatus.unhealthy:
                        btnStart.Enabled = false;
                        btnStop.Enabled = true;
                        btnRestart.Enabled = true;
                        break;
                    case ContainerStatus.stopped:
                        btnStart.Enabled = true;
                        btnStop.Enabled = false;
                        btnRestart.Enabled = false;
                        break;
                    case ContainerStatus.starting:
                        btnStart.Enabled = false;
                        btnStop.Enabled = true;
                        btnRestart.Enabled = false;
                        break;
                    case ContainerStatus.unknown:
                        btnStart.Enabled = false;
                        btnStop.Enabled = false;
                        btnRestart.Enabled = false;
                        break;
                }
            }
        }
    }
}
