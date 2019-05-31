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
    delegate void FillHandler(List<Object> x);
    public partial class MainForm : Form
    {
        readonly int REFRESH_COUNTER = 30000;


        List<Object> Containers = new List<Object>();
        List<Object> Images = new List<Object>();
        Container selectedContainerItem = null;
        Image selectedImageItem = null;
        Task<List<object>> listFiller;
        DateTime lastContainerRefresh = DateTime.Now;

        public MainForm()
        {
            InitializeComponent();
            InitializeContainerLst();
            InitializeImageLst();
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
        private void InitializeImageLst()
        {
            lstImages.View = View.Details;
            lstImages.Columns.Add(new ColumnHeader
            {
                Name = (string)GlobalRessources.ImageListColumn1,
                Text = (string)GlobalRessources.ImageListColumn1,
                Width = -2
            });
            lstImages.Columns.Add(new ColumnHeader
            {
                Name = (string)GlobalRessources.ImageListColumn2,
                Text = (string)GlobalRessources.ImageListColumn2,
                Width = -2
            });
            lstImages.Columns.Add(new ColumnHeader
            {
                Name = (string)GlobalRessources.ImageListColumn3,
                Text = (string)GlobalRessources.ImageListColumn3,
                Width = -2
            });
            lstImages.Columns.Add(new ColumnHeader
            {
                Name = (string)GlobalRessources.ImageListColumn4,
                Text = (string)GlobalRessources.ImageListColumn4,
                Width = -2
            });

            lstImages.AutoArrange = true;
            lstImages.FullRowSelect = true;
        }

        #region Control Events

        private void lstContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContainer.SelectedItems.Count > 0)
            {
                string id = lstContainer.SelectedItems[0].Text;
                ContainerSelectionChanged(id);
            }
        }
        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstImages.SelectedItems.Count > 0)
            {
                string id = lstImages.SelectedItems[0].Text;
                ImageSelectionChanged(id);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if ((tabControl1.SelectedTab.Equals(tabPage1) && (lstContainer.Items.Count == 0)) ||
                (tabControl1.SelectedTab.Equals(tabPage2) && (lstImages.Items.Count == 0)) ||
                ((DateTime.Now-lastContainerRefresh).TotalMilliseconds > REFRESH_COUNTER))
                FillActiveListBox();
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
            var result = selectedContainerItem.Restart();
            tf.FromAsync(result, x => { FillContainerListBox(); });   
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TaskFactory tf = new TaskFactory();
            var result = selectedContainerItem.Stop();
            tf.FromAsync(result, x => { FillContainerListBox(); });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TaskFactory tf = new TaskFactory();
            var result = selectedContainerItem.Start();
            tf.FromAsync(result, x => { FillContainerListBox(); });
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            TaskFactory tf = new TaskFactory();
            var result = selectedContainerItem.Remove();
            tf.FromAsync(result, x => { FillContainerListBox(); });
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
            tf.FromAsync(result, x => { FillContainerListBox(); });
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            FillActiveListBox();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillActiveListBox();
            if (tabControl1.SelectedTab.Equals(tabPage1))
            {
                SelectItemInContainerList();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            InitForm.Instance.Hide();
        }
        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            TaskFactory tf = new TaskFactory();
            var result = selectedImageItem.Remove();
            tf.FromAsync(result, x => { FillImagesListBox(); });
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

        private void FillActiveListBox()
        {
            if (tabControl1.SelectedTab.Equals(tabPage1))
            {
                FillContainerListBox();
            }
            else if (tabControl1.SelectedTab.Equals(tabPage2))
            {
                FillImagesListBox();
            }
        }

        private void FillContainerListBox()
        {
            if (listFiller != null)
            {
                if (!listFiller.IsCompleted)
                    return;
            }
            listFiller = new Task<List<Object>>(PowershellHelper.Instance.GetContainers);
            listFiller.ContinueWith((x) =>
            {
                FinishFillContainer(listFiller.Result);
            });
            listFiller.Start();

        }


        private void FillImagesListBox()
        {
            if (listFiller != null)
            {
                if (!listFiller.IsCompleted)
                    return;
            }
            listFiller = new Task<List<Object>>(PowershellHelper.Instance.GetImages);
            listFiller.ContinueWith((x) =>
            {
                FinishFillImages(listFiller.Result);
            });
            listFiller.Start();
        }

        private void FinishFillImages(List<Object> images)
        {
            if (InvokeRequired)
            {
                FillHandler eventHandler = FinishFillImages;
                this.Invoke(eventHandler, images);
            }
            else
            {
                Images = images;
                lstImages.Items.Clear();
                foreach (Image i in Images)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = i.ID;
                    item.SubItems.Add(i.Repository);
                    item.SubItems.Add(i.Tag);
                    item.SubItems.Add(i.Size);
                    lstImages.Items.Add(item);
                }
                foreach (ColumnHeader ch in lstImages.Columns)
                    ch.Width = -2;
                if (Images.Count(x => ((Image)x).ID == ((selectedImageItem == null) ? "-1" : selectedImageItem.ID)) == 0)
                    if (Containers.Count > 0)
                    {
                        ImageSelectionChanged(((Image)Images[0]).ID);
                    }
                    else
                    {
                        ImageSelectionChanged("-1");
                    }

                SelectItemInImageList();
            }
        }
        private void FinishFillContainer(List<Object> containers)
        {
            if (InvokeRequired)
            {
                FillHandler eventHandler = FinishFillContainer;
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
                if (Containers.Count(x => ((Container)x).ID == ((selectedContainerItem == null) ? "-1" : selectedContainerItem.ID)) == 0)
                    if (Containers.Count > 0)
                    {
                        ContainerSelectionChanged(((Container)Containers[0]).ID);
                    }
                    else
                    {
                        ContainerSelectionChanged("-1");
                    }

                SelectItemInContainerList();
            }
        }

        private void SelectItemInContainerList()
        {
            lstContainer.Select();
            if (selectedContainerItem != null)
            {
                for (int i = 0; i < lstContainer.Items.Count; i++)
                {
                    if (lstContainer.Items[i].Text.Equals(selectedContainerItem.ID))
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

        private void SelectItemInImageList()
        {
            lstImages.Select();
            if (selectedImageItem != null)
            {
                for (int i = 0; i < lstImages.Items.Count; i++)
                {
                    if (lstImages.Items[i].Text.Equals(selectedImageItem.ID))
                    {
                        lstImages.Items[i].Selected = true;
                    }
                    else
                    {
                        lstImages.Items[i].Selected = false;
                    }
                }
            }
        }

        private void ContainerSelectionChanged(string ID)
        {
            foreach (Container c in Containers)
            {
                if (c.ID.Equals(ID))
                {
                    selectedContainerItem = c;
                    RefreshButtons();
                    return;
                }
            }
        }
        private void ImageSelectionChanged(string ID)
        {
            foreach (Image i in Images)
            {
                if (i.ID.Equals(ID))
                {
                    selectedImageItem = i;
                    RefreshButtons();
                    return;
                }
            }
        }

        private void RefreshButtons()
        {
            if (selectedContainerItem == null)
            {
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnRestart.Enabled = false;
            }
            else
            {
                switch (selectedContainerItem.ContainerStatus)
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

            if (selectedImageItem == null)
            {
                btnRemoveImage.Enabled = false;
            }
            else
            {
                btnRemoveImage.Enabled = true;
            }
        }

    }
}
