namespace BCDockerHelper.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMiddleDock = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.lstContainer = new System.Windows.Forms.ListView();
            this.pnlContainerControl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlImageControl = new System.Windows.Forms.Panel();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.lstImages = new System.Windows.Forms.ListView();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.toolFooterBar = new System.Windows.Forms.ToolStrip();
            this.prgScriptRunning = new System.Windows.Forms.ToolStripProgressBar();
            this.btnStopPowershell = new System.Windows.Forms.ToolStripButton();
            this.txCurrentScript = new System.Windows.Forms.ToolStripLabel();
            this.splContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblShortcuts = new System.Windows.Forms.Label();
            this.txtContainerName = new System.Windows.Forms.TextBox();
            this.lblContainername = new System.Windows.Forms.Label();
            this.chkIncludeCside = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkUseWindowsAuth = new System.Windows.Forms.CheckBox();
            this.lblDockerImage = new System.Windows.Forms.Label();
            this.lblIncludeCside = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWindowsUser = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.cmbDockerImage = new System.Windows.Forms.ComboBox();
            this.cmbShortcuts = new System.Windows.Forms.ComboBox();
            this.btnNewBCContainer = new System.Windows.Forms.Button();
            this.lblAcceptEula = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chkAccepEula = new System.Windows.Forms.CheckBox();
            this.splContainer2 = new System.Windows.Forms.SplitContainer();
            this.rtfOutputLog = new System.Windows.Forms.RichTextBox();
            this.pnlMiddleDock.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlContainerControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlImageControl.SuspendLayout();
            this.toolFooterBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splContainer1)).BeginInit();
            this.splContainer1.Panel1.SuspendLayout();
            this.splContainer1.Panel2.SuspendLayout();
            this.splContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splContainer2)).BeginInit();
            this.splContainer2.Panel1.SuspendLayout();
            this.splContainer2.Panel2.SuspendLayout();
            this.splContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMiddleDock
            // 
            this.pnlMiddleDock.Controls.Add(this.tabControl1);
            this.pnlMiddleDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddleDock.Location = new System.Drawing.Point(0, 0);
            this.pnlMiddleDock.Name = "pnlMiddleDock";
            this.pnlMiddleDock.Size = new System.Drawing.Size(597, 527);
            this.pnlMiddleDock.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 527);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlMiddle);
            this.tabPage1.Controls.Add(this.pnlContainerControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(589, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Containerlist";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.lstContainer);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(3, 3);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(583, 413);
            this.pnlMiddle.TabIndex = 3;
            // 
            // lstContainer
            // 
            this.lstContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstContainer.FullRowSelect = true;
            this.lstContainer.HideSelection = false;
            this.lstContainer.Location = new System.Drawing.Point(0, 0);
            this.lstContainer.Name = "lstContainer";
            this.lstContainer.Size = new System.Drawing.Size(583, 413);
            this.lstContainer.TabIndex = 6;
            this.lstContainer.UseCompatibleStateImageBehavior = false;
            this.lstContainer.View = System.Windows.Forms.View.Details;
            this.lstContainer.SelectedIndexChanged += new System.EventHandler(this.lstContainer_SelectedIndexChanged);
            // 
            // pnlContainerControl
            // 
            this.pnlContainerControl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlContainerControl.Controls.Add(this.btnStart);
            this.pnlContainerControl.Controls.Add(this.btnStop);
            this.pnlContainerControl.Controls.Add(this.btnRestart);
            this.pnlContainerControl.Controls.Add(this.btnRemove);
            this.pnlContainerControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContainerControl.Location = new System.Drawing.Point(3, 416);
            this.pnlContainerControl.Name = "pnlContainerControl";
            this.pnlContainerControl.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContainerControl.Size = new System.Drawing.Size(583, 82);
            this.pnlContainerControl.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Container";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(144, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Container";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(275, 13);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(125, 23);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Restart Container";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(406, 13);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Container";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlImageControl);
            this.tabPage2.Controls.Add(this.lstImages);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(589, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Images";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlImageControl
            // 
            this.pnlImageControl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlImageControl.Controls.Add(this.btnRemoveImage);
            this.pnlImageControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlImageControl.Location = new System.Drawing.Point(0, 428);
            this.pnlImageControl.Name = "pnlImageControl";
            this.pnlImageControl.Size = new System.Drawing.Size(589, 73);
            this.pnlImageControl.TabIndex = 1;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(25, 25);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(125, 23);
            this.btnRemoveImage.TabIndex = 3;
            this.btnRemoveImage.Text = "Remove Image";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // lstImages
            // 
            this.lstImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstImages.Location = new System.Drawing.Point(0, 0);
            this.lstImages.Name = "lstImages";
            this.lstImages.Size = new System.Drawing.Size(589, 433);
            this.lstImages.TabIndex = 0;
            this.lstImages.UseCompatibleStateImageBehavior = false;
            this.lstImages.SelectedIndexChanged += new System.EventHandler(this.lstImages_SelectedIndexChanged);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // toolFooterBar
            // 
            this.toolFooterBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolFooterBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolFooterBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolFooterBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prgScriptRunning,
            this.btnStopPowershell,
            this.txCurrentScript});
            this.toolFooterBar.Location = new System.Drawing.Point(0, 536);
            this.toolFooterBar.Name = "toolFooterBar";
            this.toolFooterBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolFooterBar.Size = new System.Drawing.Size(1181, 25);
            this.toolFooterBar.TabIndex = 11;
            // 
            // prgScriptRunning
            // 
            this.prgScriptRunning.Name = "prgScriptRunning";
            this.prgScriptRunning.Size = new System.Drawing.Size(100, 22);
            this.prgScriptRunning.Step = 2;
            // 
            // btnStopPowershell
            // 
            this.btnStopPowershell.Checked = true;
            this.btnStopPowershell.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnStopPowershell.Image = ((System.Drawing.Image)(resources.GetObject("btnStopPowershell.Image")));
            this.btnStopPowershell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStopPowershell.Name = "btnStopPowershell";
            this.btnStopPowershell.Size = new System.Drawing.Size(51, 22);
            this.btnStopPowershell.Text = "Stop";
            this.btnStopPowershell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopPowershell.Click += new System.EventHandler(this.btnStopPowershell_Click);
            // 
            // txCurrentScript
            // 
            this.txCurrentScript.Name = "txCurrentScript";
            this.txCurrentScript.Size = new System.Drawing.Size(86, 22);
            this.txCurrentScript.Text = "toolStripLabel1";
            // 
            // splContainer1
            // 
            this.splContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splContainer1.Location = new System.Drawing.Point(0, 3);
            this.splContainer1.Name = "splContainer1";
            // 
            // splContainer1.Panel1
            // 
            this.splContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splContainer1.Panel1.Controls.Add(this.btnNewBCContainer);
            this.splContainer1.Panel1.Controls.Add(this.lblAcceptEula);
            this.splContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splContainer1.Panel1.Controls.Add(this.chkAccepEula);
            // 
            // splContainer1.Panel2
            // 
            this.splContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splContainer1.Panel2.Controls.Add(this.splContainer2);
            this.splContainer1.Size = new System.Drawing.Size(1181, 530);
            this.splContainer1.SplitterDistance = 304;
            this.splContainer1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblShortcuts, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtContainerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblContainername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkIncludeCside, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkUseWindowsAuth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDockerImage, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblIncludeCside, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWindowsUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTag, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtTag, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbDockerImage, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbShortcuts, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 23;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 445);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblShortcuts
            // 
            this.lblShortcuts.AutoSize = true;
            this.lblShortcuts.Location = new System.Drawing.Point(3, 171);
            this.lblShortcuts.Name = "lblShortcuts";
            this.lblShortcuts.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblShortcuts.Size = new System.Drawing.Size(76, 18);
            this.lblShortcuts.TabIndex = 21;
            this.lblShortcuts.Text = "Shortcut Icons";
            // 
            // txtContainerName
            // 
            this.txtContainerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContainerName.Location = new System.Drawing.Point(152, 3);
            this.txtContainerName.Name = "txtContainerName";
            this.txtContainerName.Size = new System.Drawing.Size(143, 20);
            this.txtContainerName.TabIndex = 0;
            this.txtContainerName.Text = "BCSandbox";
            // 
            // lblContainername
            // 
            this.lblContainername.AutoSize = true;
            this.lblContainername.Location = new System.Drawing.Point(3, 0);
            this.lblContainername.Name = "lblContainername";
            this.lblContainername.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblContainername.Size = new System.Drawing.Size(78, 18);
            this.lblContainername.TabIndex = 4;
            this.lblContainername.Text = "Containername";
            // 
            // chkIncludeCside
            // 
            this.chkIncludeCside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIncludeCside.AutoSize = true;
            this.chkIncludeCside.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIncludeCside.Location = new System.Drawing.Point(152, 101);
            this.chkIncludeCside.Name = "chkIncludeCside";
            this.chkIncludeCside.Size = new System.Drawing.Size(143, 14);
            this.chkIncludeCside.TabIndex = 4;
            this.chkIncludeCside.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIncludeCside.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(152, 75);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(152, 49);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(143, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // chkUseWindowsAuth
            // 
            this.chkUseWindowsAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUseWindowsAuth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUseWindowsAuth.Location = new System.Drawing.Point(152, 29);
            this.chkUseWindowsAuth.Name = "chkUseWindowsAuth";
            this.chkUseWindowsAuth.Size = new System.Drawing.Size(143, 14);
            this.chkUseWindowsAuth.TabIndex = 1;
            this.chkUseWindowsAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUseWindowsAuth.UseVisualStyleBackColor = true;
            this.chkUseWindowsAuth.CheckedChanged += new System.EventHandler(this.ChkUseWindowsAuth_CheckedChanged);
            // 
            // lblDockerImage
            // 
            this.lblDockerImage.AutoSize = true;
            this.lblDockerImage.Location = new System.Drawing.Point(3, 118);
            this.lblDockerImage.Name = "lblDockerImage";
            this.lblDockerImage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDockerImage.Size = new System.Drawing.Size(70, 18);
            this.lblDockerImage.TabIndex = 13;
            this.lblDockerImage.Text = "Dockerimage";
            // 
            // lblIncludeCside
            // 
            this.lblIncludeCside.AutoSize = true;
            this.lblIncludeCside.Location = new System.Drawing.Point(3, 98);
            this.lblIncludeCside.Name = "lblIncludeCside";
            this.lblIncludeCside.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblIncludeCside.Size = new System.Drawing.Size(73, 18);
            this.lblIncludeCside.TabIndex = 11;
            this.lblIncludeCside.Text = "Include CSide";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPassword.Size = new System.Drawing.Size(53, 18);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 46);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblUsername.Size = new System.Drawing.Size(55, 18);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // lblWindowsUser
            // 
            this.lblWindowsUser.AutoSize = true;
            this.lblWindowsUser.Location = new System.Drawing.Point(3, 26);
            this.lblWindowsUser.Name = "lblWindowsUser";
            this.lblWindowsUser.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblWindowsUser.Size = new System.Drawing.Size(127, 18);
            this.lblWindowsUser.TabIndex = 19;
            this.lblWindowsUser.Text = "Windows Authentification";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(3, 145);
            this.lblTag.Name = "lblTag";
            this.lblTag.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTag.Size = new System.Drawing.Size(26, 18);
            this.lblTag.TabIndex = 20;
            this.lblTag.Text = "Tag";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(152, 148);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(143, 20);
            this.txtTag.TabIndex = 6;
            this.txtTag.Text = "w1";
            // 
            // cmbDockerImage
            // 
            this.cmbDockerImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDockerImage.Location = new System.Drawing.Point(152, 121);
            this.cmbDockerImage.Name = "cmbDockerImage";
            this.cmbDockerImage.Size = new System.Drawing.Size(143, 21);
            this.cmbDockerImage.TabIndex = 5;
            this.cmbDockerImage.Validated += new System.EventHandler(this.TxtDockerImage_Validated);
            // 
            // cmbShortcuts
            // 
            this.cmbShortcuts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShortcuts.FormattingEnabled = true;
            this.cmbShortcuts.Location = new System.Drawing.Point(152, 174);
            this.cmbShortcuts.Name = "cmbShortcuts";
            this.cmbShortcuts.Size = new System.Drawing.Size(143, 21);
            this.cmbShortcuts.TabIndex = 22;
            // 
            // btnNewBCContainer
            // 
            this.btnNewBCContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewBCContainer.Location = new System.Drawing.Point(3, 496);
            this.btnNewBCContainer.Name = "btnNewBCContainer";
            this.btnNewBCContainer.Size = new System.Drawing.Size(136, 24);
            this.btnNewBCContainer.TabIndex = 9;
            this.btnNewBCContainer.Text = "Create BC Container";
            this.btnNewBCContainer.UseVisualStyleBackColor = true;
            this.btnNewBCContainer.Click += new System.EventHandler(this.btnNewBCContainer_Click);
            // 
            // lblAcceptEula
            // 
            this.lblAcceptEula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAcceptEula.AutoSize = true;
            this.lblAcceptEula.Location = new System.Drawing.Point(6, 475);
            this.lblAcceptEula.Name = "lblAcceptEula";
            this.lblAcceptEula.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblAcceptEula.Size = new System.Drawing.Size(65, 18);
            this.lblAcceptEula.TabIndex = 15;
            this.lblAcceptEula.Text = "Accept Eula";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 461);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(232, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://go.microsoft.com/fwlink/?linkid=861843";
            // 
            // chkAccepEula
            // 
            this.chkAccepEula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAccepEula.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAccepEula.Location = new System.Drawing.Point(155, 479);
            this.chkAccepEula.Name = "chkAccepEula";
            this.chkAccepEula.Size = new System.Drawing.Size(143, 14);
            this.chkAccepEula.TabIndex = 8;
            this.chkAccepEula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAccepEula.UseVisualStyleBackColor = true;
            // 
            // splContainer2
            // 
            this.splContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splContainer2.Location = new System.Drawing.Point(3, 0);
            this.splContainer2.Name = "splContainer2";
            // 
            // splContainer2.Panel1
            // 
            this.splContainer2.Panel1.Controls.Add(this.pnlMiddleDock);
            // 
            // splContainer2.Panel2
            // 
            this.splContainer2.Panel2.Controls.Add(this.rtfOutputLog);
            this.splContainer2.Size = new System.Drawing.Size(866, 527);
            this.splContainer2.SplitterDistance = 597;
            this.splContainer2.TabIndex = 0;
            // 
            // rtfOutputLog
            // 
            this.rtfOutputLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfOutputLog.Location = new System.Drawing.Point(2, 0);
            this.rtfOutputLog.Name = "rtfOutputLog";
            this.rtfOutputLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtfOutputLog.Size = new System.Drawing.Size(260, 520);
            this.rtfOutputLog.TabIndex = 2;
            this.rtfOutputLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1181, 561);
            this.Controls.Add(this.splContainer1);
            this.Controls.Add(this.toolFooterBar);
            this.Name = "MainForm";
            this.Text = "BC";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlMiddleDock.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlContainerControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlImageControl.ResumeLayout(false);
            this.toolFooterBar.ResumeLayout(false);
            this.toolFooterBar.PerformLayout();
            this.splContainer1.Panel1.ResumeLayout(false);
            this.splContainer1.Panel1.PerformLayout();
            this.splContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splContainer1)).EndInit();
            this.splContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splContainer2.Panel1.ResumeLayout(false);
            this.splContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splContainer2)).EndInit();
            this.splContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMiddleDock;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.ListView lstContainer;
        private System.Windows.Forms.FlowLayoutPanel pnlContainerControl;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolFooterBar;
        private System.Windows.Forms.ToolStripProgressBar prgScriptRunning;
        private System.Windows.Forms.ToolStripLabel txCurrentScript;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.SplitContainer splContainer1;
        private System.Windows.Forms.SplitContainer splContainer2;
        private System.Windows.Forms.RichTextBox rtfOutputLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNewBCContainer;
        private System.Windows.Forms.ComboBox cmbDockerImage;
        private System.Windows.Forms.Label lblDockerImage;
        private System.Windows.Forms.Label lblIncludeCside;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtContainerName;
        private System.Windows.Forms.Label lblContainername;
        private System.Windows.Forms.CheckBox chkIncludeCside;
        private System.Windows.Forms.Label lblAcceptEula;
        private System.Windows.Forms.CheckBox chkAccepEula;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnlImageControl;
        private System.Windows.Forms.ListView lstImages;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.ToolStripButton btnStopPowershell;
        private System.Windows.Forms.CheckBox chkUseWindowsAuth;
        private System.Windows.Forms.Label lblWindowsUser;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblShortcuts;
        private System.Windows.Forms.ComboBox cmbShortcuts;
    }
}

