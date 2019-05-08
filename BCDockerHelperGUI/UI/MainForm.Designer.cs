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
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.toolFooterBar = new System.Windows.Forms.ToolStrip();
            this.prgScriptRunning = new System.Windows.Forms.ToolStripProgressBar();
            this.txCurrentScript = new System.Windows.Forms.ToolStripLabel();
            this.splContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDockerImage = new System.Windows.Forms.TextBox();
            this.lblDockerImage = new System.Windows.Forms.Label();
            this.lblIncludeCside = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnNewBCContainer = new System.Windows.Forms.Button();
            this.txtContainerName = new System.Windows.Forms.TextBox();
            this.lblContainername = new System.Windows.Forms.Label();
            this.chkIncludeCside = new System.Windows.Forms.CheckBox();
            this.lblAcceptEula = new System.Windows.Forms.Label();
            this.chkAccepEula = new System.Windows.Forms.CheckBox();
            this.splContainer2 = new System.Windows.Forms.SplitContainer();
            this.rtfOutputLog = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlMiddleDock.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlContainerControl.SuspendLayout();
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.tabPage2.Size = new System.Drawing.Size(589, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Images";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtDockerImage, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDockerImage, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblIncludeCside, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNewBCContainer, 1, 20);
            this.tableLayoutPanel1.Controls.Add(this.txtContainerName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblContainername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkIncludeCside, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAcceptEula, 0, 20);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.chkAccepEula, 1, 20);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 23;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 524);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // txtDockerImage
            // 
            this.txtDockerImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDockerImage.Location = new System.Drawing.Point(87, 101);
            this.txtDockerImage.Name = "txtDockerImage";
            this.txtDockerImage.Size = new System.Drawing.Size(208, 20);
            this.txtDockerImage.TabIndex = 14;
            this.txtDockerImage.Text = "microsoft/bcsandbox";
            // 
            // lblDockerImage
            // 
            this.lblDockerImage.AutoSize = true;
            this.lblDockerImage.Location = new System.Drawing.Point(3, 98);
            this.lblDockerImage.Name = "lblDockerImage";
            this.lblDockerImage.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDockerImage.Size = new System.Drawing.Size(70, 18);
            this.lblDockerImage.TabIndex = 13;
            this.lblDockerImage.Text = "Dockerimage";
            // 
            // lblIncludeCside
            // 
            this.lblIncludeCside.AutoSize = true;
            this.lblIncludeCside.Location = new System.Drawing.Point(3, 78);
            this.lblIncludeCside.Name = "lblIncludeCside";
            this.lblIncludeCside.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblIncludeCside.Size = new System.Drawing.Size(73, 18);
            this.lblIncludeCside.TabIndex = 11;
            this.lblIncludeCside.Text = "Include CSide";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(87, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(208, 20);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 52);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPassword.Size = new System.Drawing.Size(53, 18);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(87, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(208, 20);
            this.txtUsername.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 26);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblUsername.Size = new System.Drawing.Size(55, 18);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // btnNewBCContainer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnNewBCContainer, 2);
            this.btnNewBCContainer.Location = new System.Drawing.Point(3, 447);
            this.btnNewBCContainer.Name = "btnNewBCContainer";
            this.btnNewBCContainer.Size = new System.Drawing.Size(136, 24);
            this.btnNewBCContainer.TabIndex = 6;
            this.btnNewBCContainer.Text = "Create BC Container";
            this.btnNewBCContainer.UseVisualStyleBackColor = true;
            this.btnNewBCContainer.Click += new System.EventHandler(this.btnNewBCContainer_Click);
            // 
            // txtContainerName
            // 
            this.txtContainerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContainerName.Location = new System.Drawing.Point(87, 3);
            this.txtContainerName.Name = "txtContainerName";
            this.txtContainerName.Size = new System.Drawing.Size(208, 20);
            this.txtContainerName.TabIndex = 5;
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
            this.chkIncludeCside.Location = new System.Drawing.Point(87, 81);
            this.chkIncludeCside.Name = "chkIncludeCside";
            this.chkIncludeCside.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.chkIncludeCside.Size = new System.Drawing.Size(208, 14);
            this.chkIncludeCside.TabIndex = 12;
            this.chkIncludeCside.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIncludeCside.UseVisualStyleBackColor = true;
            // 
            // lblAcceptEula
            // 
            this.lblAcceptEula.AutoSize = true;
            this.lblAcceptEula.Location = new System.Drawing.Point(3, 424);
            this.lblAcceptEula.Name = "lblAcceptEula";
            this.lblAcceptEula.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblAcceptEula.Size = new System.Drawing.Size(65, 18);
            this.lblAcceptEula.TabIndex = 15;
            this.lblAcceptEula.Text = "Accept Eula";
            // 
            // chkAccepEula
            // 
            this.chkAccepEula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAccepEula.AutoSize = true;
            this.chkAccepEula.Location = new System.Drawing.Point(87, 427);
            this.chkAccepEula.Name = "chkAccepEula";
            this.chkAccepEula.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.chkAccepEula.Size = new System.Drawing.Size(208, 14);
            this.chkAccepEula.TabIndex = 16;
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.linkLabel1, 2);
            this.linkLabel1.Location = new System.Drawing.Point(3, 404);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(232, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://go.microsoft.com/fwlink/?linkid=861843";
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
            this.toolFooterBar.ResumeLayout(false);
            this.toolFooterBar.PerformLayout();
            this.splContainer1.Panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtDockerImage;
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
    }
}

