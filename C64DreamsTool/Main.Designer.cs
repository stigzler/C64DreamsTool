namespace C64DreamsTool
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new stigzler.Winforms.Base.UIElements.Label();
            TopLeftFLP = new stigzler.Winforms.Base.UIElements.FlowLayoutPanel();
            NavBarBT = new stigzler.Winforms.Base.UIElements.Button();
            pictureBox1 = new stigzler.Winforms.Base.UIElements.PictureBox();
            statusStrip1 = new stigzler.Winforms.Base.UIElements.StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            TopPN = new stigzler.Winforms.Base.UIElements.Panel();
            flowLayoutPanel1 = new stigzler.Winforms.Base.UIElements.FlowLayoutPanel();
            DarkLightModeBT = new stigzler.Winforms.Base.UIElements.Button();
            NavBarPN = new stigzler.Winforms.Base.UIElements.Panel();
            NavSettingsBT = new NavButton();
            NavInstallBT = new NavButton();
            MainTC = new stigzler.Winforms.Base.UIElements.TabControl();
            InstallTP = new TabPage();
            InstallPN = new stigzler.Winforms.Base.UIElements.Panel();
            richTextBox1 = new stigzler.Winforms.Base.UIElements.RichTextBox();
            label6 = new stigzler.Winforms.Base.UIElements.Label();
            MainTT = new stigzler.Winforms.Base.UIElements.ToolTip(components);
            InstallTopPN = new stigzler.Winforms.Base.UIElements.Panel();
            PageTitleLB = new stigzler.Winforms.Base.UIElements.Label();
            InstallButtonsFLP = new FlowLayoutPanel();
            Import64DBT = new stigzler.Winforms.Base.UIElements.Button();
            ImportHotfixBT = new stigzler.Winforms.Base.UIElements.Button();
            ImportMagsBT = new stigzler.Winforms.Base.UIElements.Button();
            PathsWarningLB = new stigzler.Winforms.Base.UIElements.Label();
            SettingsTP = new TabPage();
            groupBox1 = new stigzler.Winforms.Base.UIElements.GroupBox();
            label5 = new stigzler.Winforms.Base.UIElements.Label();
            label4 = new stigzler.Winforms.Base.UIElements.Label();
            LaunchboxFBD = new stigzler.Winforms.Base.UserControls.FileObjectTextBox();
            C64DreamsFBD = new stigzler.Winforms.Base.UserControls.FileObjectTextBox();
            label3 = new stigzler.Winforms.Base.UIElements.Label();
            navBarTicker = new System.Windows.Forms.Timer(components);
            TopLeftFLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            TopPN.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            NavBarPN.SuspendLayout();
            MainTC.SuspendLayout();
            InstallTP.SuspendLayout();
            InstallPN.SuspendLayout();
            InstallTopPN.SuspendLayout();
            InstallButtonsFLP.SuspendLayout();
            SettingsTP.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Franklin Gothic Medium Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.FontStyle = FontStyle.Regular;
            label1.ForeColor = Color.FromArgb(220, 220, 220);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(87, 0);
            label1.Name = "label1";
            label1.ScaleFont = 100;
            label1.Size = new Size(211, 37);
            label1.TabIndex = 2;
            label1.Text = "C64Dreams Tool";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.ToolTip = null;
            label1.ToolTipHorizontalAlignment = HorizontalAlignment.Right;
            label1.ToolTipImage = null;
            label1.ToolTipText = null;
            label1.ToolTipTitle = null;
            // 
            // TopLeftFLP
            // 
            TopLeftFLP.AutoSize = true;
            TopLeftFLP.BackColor = Color.FromArgb(35, 35, 35);
            TopLeftFLP.BackgroundShadeFactor = 1D;
            TopLeftFLP.Controls.Add(NavBarBT);
            TopLeftFLP.Controls.Add(pictureBox1);
            TopLeftFLP.Controls.Add(label1);
            TopLeftFLP.ForeColor = Color.FromArgb(220, 220, 220);
            TopLeftFLP.Location = new Point(3, 3);
            TopLeftFLP.Name = "TopLeftFLP";
            TopLeftFLP.Size = new Size(503, 42);
            TopLeftFLP.TabIndex = 2;
            // 
            // NavBarBT
            // 
            NavBarBT.BackColor = Color.Transparent;
            NavBarBT.BackgroundImage = Properties.Resources.Menu;
            NavBarBT.BackgroundImageLayout = ImageLayout.Center;
            NavBarBT.Cursor = Cursors.Hand;
            NavBarBT.DefocusOnClick = true;
            NavBarBT.DisabledBackColor = Color.FromArgb(30, 30, 30);
            NavBarBT.DisabledBorderColor = Color.FromArgb(60, 60, 60);
            NavBarBT.DisabledForeColor = Color.FromArgb(125, 125, 125);
            NavBarBT.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            NavBarBT.FlatAppearance.MouseOverBackColor = Color.Transparent;
            NavBarBT.FlatStyle = FlatStyle.Flat;
            NavBarBT.ForeColor = Color.FromArgb(240, 240, 240);
            NavBarBT.Location = new Point(3, 3);
            NavBarBT.Name = "NavBarBT";
            NavBarBT.OverrideTheme = true;
            NavBarBT.Size = new Size(36, 36);
            NavBarBT.TabIndex = 3;
            NavBarBT.ToolTip = null;
            NavBarBT.ToolTipImage = null;
            NavBarBT.ToolTipText = null;
            NavBarBT.ToolTipTitle = null;
            NavBarBT.UseVisualStyleBackColor = false;
            NavBarBT.Click += NavBarBT_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CommodoreLogo36WhiteOutline;
            pictureBox1.Location = new Point(45, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(25, 25, 25);
            statusStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 445);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.ShowItemToolTips = true;
            statusStrip1.Size = new Size(726, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.ToolTip = null;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Image = Properties.Resources.tooltipOn;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Padding = new Padding(10, 0, 0, 0);
            toolStripStatusLabel1.Size = new Size(169, 17);
            toolStripStatusLabel1.Text = "Tooltips show further info";
            toolStripStatusLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // TopPN
            // 
            TopPN.AutoSize = true;
            TopPN.BackColor = Color.FromArgb(35, 35, 35);
            TopPN.BackgroundShadeFactor = 0.8D;
            TopPN.Controls.Add(flowLayoutPanel1);
            TopPN.Controls.Add(TopLeftFLP);
            TopPN.Dock = DockStyle.Top;
            TopPN.ForeColor = Color.FromArgb(220, 220, 220);
            TopPN.Location = new Point(0, 0);
            TopPN.Name = "TopPN";
            TopPN.Size = new Size(726, 48);
            TopPN.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 35, 35);
            flowLayoutPanel1.BackgroundShadeFactor = 1D;
            flowLayoutPanel1.Controls.Add(DarkLightModeBT);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.ForeColor = Color.FromArgb(220, 220, 220);
            flowLayoutPanel1.Location = new Point(667, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(56, 42);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // DarkLightModeBT
            // 
            DarkLightModeBT.BackColor = Color.Transparent;
            DarkLightModeBT.BackgroundImage = Properties.Resources.LightMode;
            DarkLightModeBT.BackgroundImageLayout = ImageLayout.Center;
            DarkLightModeBT.Cursor = Cursors.Hand;
            DarkLightModeBT.DefocusOnClick = true;
            DarkLightModeBT.DisabledBackColor = Color.FromArgb(30, 30, 30);
            DarkLightModeBT.DisabledBorderColor = Color.FromArgb(60, 60, 60);
            DarkLightModeBT.DisabledForeColor = Color.FromArgb(125, 125, 125);
            DarkLightModeBT.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            DarkLightModeBT.FlatAppearance.MouseOverBackColor = Color.Transparent;
            DarkLightModeBT.FlatStyle = FlatStyle.Flat;
            DarkLightModeBT.ForeColor = Color.FromArgb(240, 240, 240);
            DarkLightModeBT.Location = new Point(17, 3);
            DarkLightModeBT.Name = "DarkLightModeBT";
            DarkLightModeBT.OverrideTheme = true;
            DarkLightModeBT.Size = new Size(36, 36);
            DarkLightModeBT.TabIndex = 0;
            DarkLightModeBT.ToolTip = null;
            DarkLightModeBT.ToolTipImage = null;
            DarkLightModeBT.ToolTipText = null;
            DarkLightModeBT.ToolTipTitle = null;
            DarkLightModeBT.UseVisualStyleBackColor = false;
            DarkLightModeBT.Click += DarkLightModeBT_Click;
            // 
            // NavBarPN
            // 
            NavBarPN.BackColor = Color.FromArgb(35, 35, 35);
            NavBarPN.BackgroundShadeFactor = 1D;
            NavBarPN.Controls.Add(NavSettingsBT);
            NavBarPN.Controls.Add(NavInstallBT);
            NavBarPN.Dock = DockStyle.Left;
            NavBarPN.ForeColor = Color.FromArgb(220, 220, 220);
            NavBarPN.Location = new Point(0, 48);
            NavBarPN.Name = "NavBarPN";
            NavBarPN.Size = new Size(160, 397);
            NavBarPN.TabIndex = 4;
            // 
            // NavSettingsBT
            // 
            NavSettingsBT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NavSettingsBT.BackColor = Color.FromArgb(32, 32, 32);
            NavSettingsBT.BorderStyle = BorderStyle.FixedSingle;
            NavSettingsBT.DarkMode = true;
            NavSettingsBT.Image = Properties.Resources.settings;
            NavSettingsBT.Label = "Settings";
            NavSettingsBT.Location = new Point(3, 52);
            NavSettingsBT.Name = "NavSettingsBT";
            NavSettingsBT.Size = new Size(154, 43);
            NavSettingsBT.TabIndex = 1;
            NavSettingsBT.Click += NavSettingsBT_Click;
            // 
            // NavInstallBT
            // 
            NavInstallBT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NavInstallBT.BackColor = Color.FromArgb(32, 32, 32);
            NavInstallBT.BorderStyle = BorderStyle.FixedSingle;
            NavInstallBT.DarkMode = true;
            NavInstallBT.Image = Properties.Resources.InstallPackage;
            NavInstallBT.Label = "Install C64Dreams";
            NavInstallBT.Location = new Point(3, 3);
            NavInstallBT.Name = "NavInstallBT";
            NavInstallBT.Size = new Size(154, 43);
            NavInstallBT.TabIndex = 0;
            NavInstallBT.Click += NavInstallBT_Click;
            // 
            // MainTC
            // 
            MainTC.Controls.Add(InstallTP);
            MainTC.Controls.Add(SettingsTP);
            MainTC.Dock = DockStyle.Fill;
            MainTC.DrawMode = TabDrawMode.OwnerDrawFixed;
            MainTC.HideBorders = false;
            MainTC.HideTabs = false;
            MainTC.ItemSize = new Size(58, 18);
            MainTC.Location = new Point(160, 48);
            MainTC.Name = "MainTC";
            MainTC.SelectedIndex = 0;
            MainTC.SelectedTabColor = Color.FromArgb(34, 120, 187);
            MainTC.Size = new Size(566, 397);
            MainTC.TabIndex = 5;
            MainTC.TabOutlineColor = Color.FromArgb(125, 125, 125);
            MainTC.UnselectedTabBackColor = Color.FromArgb(20, 20, 20);
            // 
            // InstallTP
            // 
            InstallTP.BackColor = Color.FromArgb(35, 35, 35);
            InstallTP.Controls.Add(InstallPN);
            InstallTP.Controls.Add(InstallTopPN);
            InstallTP.ForeColor = Color.FromArgb(220, 220, 220);
            InstallTP.Location = new Point(4, 22);
            InstallTP.Name = "InstallTP";
            InstallTP.Padding = new Padding(3);
            InstallTP.Size = new Size(558, 371);
            InstallTP.TabIndex = 0;
            InstallTP.Text = "Install";
            // 
            // InstallPN
            // 
            InstallPN.BackColor = Color.FromArgb(35, 35, 35);
            InstallPN.BackgroundShadeFactor = 1D;
            InstallPN.Controls.Add(richTextBox1);
            InstallPN.Controls.Add(label6);
            InstallPN.Dock = DockStyle.Fill;
            InstallPN.ForeColor = Color.FromArgb(220, 220, 220);
            InstallPN.Location = new Point(3, 121);
            InstallPN.Name = "InstallPN";
            InstallPN.Size = new Size(552, 247);
            InstallPN.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.Lime;
            richTextBox1.Location = new Point(6, 20);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.OverrideTheme = true;
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(541, 218);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "Greetings Professor Falkem shall we play a game?\n[opps sorry - wrong meeting]\n> Awaiting operation...\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.FontStyle = FontStyle.Regular;
            label6.ForeColor = Color.FromArgb(220, 220, 220);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 2);
            label6.ScaleFont = 100;
            label6.Size = new Size(65, 17);
            label6.TabIndex = 10;
            label6.Text = "Outcomes:";
            label6.ToolTip = MainTT;
            label6.ToolTipHorizontalAlignment = HorizontalAlignment.Right;
            label6.ToolTipImage = null;
            label6.ToolTipText = null;
            label6.ToolTipTitle = null;
            // 
            // MainTT
            // 
            MainTT.ActiveControl = null;
            MainTT.AutoPopDelay = 5000;
            MainTT.AutoTitleLength = 30;
            MainTT.BackColor = SystemColors.Control;
            MainTT.BorderColor = SystemColors.ActiveBorder;
            MainTT.DefaultImageSize = new Size(16, 16);
            MainTT.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainTT.ForeColor = SystemColors.ControlText;
            MainTT.GrowWidthForHeader = true;
            MainTT.Image = (Image)resources.GetObject("MainTT.Image");
            MainTT.InitialDelay = 1500;
            MainTT.MaxHeight = 500;
            MainTT.Offset = new Point(0, 0);
            MainTT.OwnerDraw = true;
            MainTT.PanelPadding = 4;
            MainTT.ReshowDelay = 100;
            MainTT.ResizeImage = true;
            MainTT.ShowFor = 0;
            MainTT.TitleBackground = SystemColors.ControlLight;
            MainTT.TitleForeground = SystemColors.InfoText;
            MainTT.ToolTipText = "Information here..";
            MainTT.ToolTipTitle = "Info";
            MainTT.Width = 180;
            // 
            // InstallTopPN
            // 
            InstallTopPN.BackColor = Color.FromArgb(35, 35, 35);
            InstallTopPN.BackgroundShadeFactor = 1D;
            InstallTopPN.Controls.Add(PageTitleLB);
            InstallTopPN.Controls.Add(InstallButtonsFLP);
            InstallTopPN.Controls.Add(PathsWarningLB);
            InstallTopPN.Dock = DockStyle.Top;
            InstallTopPN.ForeColor = Color.FromArgb(220, 220, 220);
            InstallTopPN.Location = new Point(3, 3);
            InstallTopPN.Name = "InstallTopPN";
            InstallTopPN.Size = new Size(552, 118);
            InstallTopPN.TabIndex = 12;
            // 
            // PageTitleLB
            // 
            PageTitleLB.AutoSize = true;
            PageTitleLB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageTitleLB.FontStyle = FontStyle.Italic;
            PageTitleLB.ForeColor = Color.FromArgb(220, 220, 220);
            PageTitleLB.ImageAlign = ContentAlignment.MiddleLeft;
            PageTitleLB.Location = new Point(3, 0);
            PageTitleLB.Name = "PageTitleLB";
            PageTitleLB.ScaleFont = 100;
            PageTitleLB.Size = new Size(177, 30);
            PageTitleLB.TabIndex = 3;
            PageTitleLB.Text = "Install C64Dreams";
            PageTitleLB.TextAlign = ContentAlignment.MiddleRight;
            PageTitleLB.ToolTip = null;
            PageTitleLB.ToolTipHorizontalAlignment = HorizontalAlignment.Right;
            PageTitleLB.ToolTipImage = null;
            PageTitleLB.ToolTipText = null;
            PageTitleLB.ToolTipTitle = null;
            // 
            // InstallButtonsFLP
            // 
            InstallButtonsFLP.BackColor = Color.FromArgb(35, 35, 35);
            InstallButtonsFLP.Controls.Add(Import64DBT);
            InstallButtonsFLP.Controls.Add(ImportHotfixBT);
            InstallButtonsFLP.Controls.Add(ImportMagsBT);
            InstallButtonsFLP.Enabled = false;
            InstallButtonsFLP.ForeColor = Color.FromArgb(220, 220, 220);
            InstallButtonsFLP.Location = new Point(3, 34);
            InstallButtonsFLP.Name = "InstallButtonsFLP";
            InstallButtonsFLP.Size = new Size(530, 63);
            InstallButtonsFLP.TabIndex = 7;
            // 
            // Import64DBT
            // 
            Import64DBT.BackColor = Color.FromArgb(55, 55, 55);
            Import64DBT.DefocusOnClick = true;
            Import64DBT.DisabledBackColor = Color.FromArgb(30, 30, 30);
            Import64DBT.DisabledBorderColor = Color.FromArgb(60, 60, 60);
            Import64DBT.DisabledForeColor = Color.FromArgb(125, 125, 125);
            Import64DBT.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            Import64DBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 215);
            Import64DBT.FlatStyle = FlatStyle.Flat;
            Import64DBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Import64DBT.ForeColor = Color.FromArgb(240, 240, 240);
            Import64DBT.Image = Properties.Resources.smiley;
            Import64DBT.ImageAlign = ContentAlignment.MiddleRight;
            Import64DBT.Location = new Point(3, 3);
            Import64DBT.Name = "Import64DBT";
            Import64DBT.Size = new Size(168, 57);
            Import64DBT.TabIndex = 4;
            Import64DBT.Text = "Install C64Dreams";
            Import64DBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            Import64DBT.ToolTip = MainTT;
            Import64DBT.ToolTipImage = null;
            Import64DBT.ToolTipText = null;
            Import64DBT.ToolTipTitle = null;
            Import64DBT.UseVisualStyleBackColor = false;
            // 
            // ImportHotfixBT
            // 
            ImportHotfixBT.BackColor = Color.FromArgb(55, 55, 55);
            ImportHotfixBT.DefocusOnClick = true;
            ImportHotfixBT.DisabledBackColor = Color.FromArgb(30, 30, 30);
            ImportHotfixBT.DisabledBorderColor = Color.FromArgb(60, 60, 60);
            ImportHotfixBT.DisabledForeColor = Color.FromArgb(125, 125, 125);
            ImportHotfixBT.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            ImportHotfixBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 215);
            ImportHotfixBT.FlatStyle = FlatStyle.Flat;
            ImportHotfixBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImportHotfixBT.ForeColor = Color.FromArgb(240, 240, 240);
            ImportHotfixBT.Image = Properties.Resources.keyboard_command;
            ImportHotfixBT.ImageAlign = ContentAlignment.MiddleRight;
            ImportHotfixBT.Location = new Point(177, 3);
            ImportHotfixBT.Name = "ImportHotfixBT";
            ImportHotfixBT.Size = new Size(168, 57);
            ImportHotfixBT.TabIndex = 6;
            ImportHotfixBT.Text = "Install Hotfix";
            ImportHotfixBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            ImportHotfixBT.ToolTip = MainTT;
            ImportHotfixBT.ToolTipImage = null;
            ImportHotfixBT.ToolTipText = null;
            ImportHotfixBT.ToolTipTitle = null;
            ImportHotfixBT.UseVisualStyleBackColor = false;
            // 
            // ImportMagsBT
            // 
            ImportMagsBT.BackColor = Color.FromArgb(55, 55, 55);
            ImportMagsBT.DefocusOnClick = true;
            ImportMagsBT.DisabledBackColor = Color.FromArgb(30, 30, 30);
            ImportMagsBT.DisabledBorderColor = Color.FromArgb(60, 60, 60);
            ImportMagsBT.DisabledForeColor = Color.FromArgb(125, 125, 125);
            ImportMagsBT.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
            ImportMagsBT.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 215);
            ImportMagsBT.FlatStyle = FlatStyle.Flat;
            ImportMagsBT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImportMagsBT.ForeColor = Color.FromArgb(240, 240, 240);
            ImportMagsBT.Image = Properties.Resources.e_book_reader;
            ImportMagsBT.ImageAlign = ContentAlignment.MiddleRight;
            ImportMagsBT.Location = new Point(351, 3);
            ImportMagsBT.Name = "ImportMagsBT";
            ImportMagsBT.Size = new Size(168, 57);
            ImportMagsBT.TabIndex = 5;
            ImportMagsBT.Text = "Install Magazine Pack";
            ImportMagsBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            ImportMagsBT.ToolTip = MainTT;
            ImportMagsBT.ToolTipImage = null;
            ImportMagsBT.ToolTipText = null;
            ImportMagsBT.ToolTipTitle = null;
            ImportMagsBT.UseVisualStyleBackColor = false;
            // 
            // PathsWarningLB
            // 
            PathsWarningLB.AutoSize = true;
            PathsWarningLB.Font = new Font("Segoe UI", 9F);
            PathsWarningLB.FontStyle = FontStyle.Italic;
            PathsWarningLB.ForeColor = Color.Red;
            PathsWarningLB.Location = new Point(3, 100);
            PathsWarningLB.Name = "PathsWarningLB";
            PathsWarningLB.OverrideTheme = true;
            PathsWarningLB.ScaleFont = 100;
            PathsWarningLB.Size = new Size(481, 15);
            PathsWarningLB.TabIndex = 8;
            PathsWarningLB.Text = "Please set valid paths for Launchbox and C64Dreams in Settings to enable these functions.";
            PathsWarningLB.ToolTip = MainTT;
            PathsWarningLB.ToolTipHorizontalAlignment = HorizontalAlignment.Right;
            PathsWarningLB.ToolTipImage = null;
            PathsWarningLB.ToolTipText = null;
            PathsWarningLB.ToolTipTitle = null;
            PathsWarningLB.Visible = false;
            // 
            // SettingsTP
            // 
            SettingsTP.BackColor = Color.FromArgb(35, 35, 35);
            SettingsTP.Controls.Add(groupBox1);
            SettingsTP.Controls.Add(label3);
            SettingsTP.ForeColor = Color.FromArgb(220, 220, 220);
            SettingsTP.Location = new Point(4, 22);
            SettingsTP.Name = "SettingsTP";
            SettingsTP.Padding = new Padding(3);
            SettingsTP.Size = new Size(558, 371);
            SettingsTP.TabIndex = 1;
            SettingsTP.Text = "Settings";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BorderColor = Color.FromArgb(100, 100, 100);
            groupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            groupBox1.BorderThickness = 1;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(LaunchboxFBD);
            groupBox1.Controls.Add(C64DreamsFBD);
            groupBox1.ForeColor = Color.FromArgb(220, 220, 220);
            groupBox1.Location = new Point(17, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 81);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Required";
            groupBox1.TitleColor = Color.FromArgb(220, 220, 220);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.FontStyle = FontStyle.Regular;
            label5.ForeColor = Color.FromArgb(220, 220, 220);
            label5.Location = new Point(14, 50);
            label5.Name = "label5";
            label5.ScaleFont = 100;
            label5.Size = new Size(98, 15);
            label5.TabIndex = 8;
            label5.Text = "C64Dreams Root:";
            label5.ToolTip = null;
            label5.ToolTipHorizontalAlignment = HorizontalAlignment.Right;
            label5.ToolTipImage = Properties.Resources.Commodore;
            label5.ToolTipText = resources.GetString("label5.ToolTipText");
            label5.ToolTipTitle = "C64Dreams Root Directory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.FontStyle = FontStyle.Regular;
            label4.ForeColor = Color.FromArgb(220, 220, 220);
            label4.Location = new Point(16, 23);
            label4.Name = "label4";
            label4.ScaleFont = 100;
            label4.Size = new Size(96, 15);
            label4.TabIndex = 7;
            label4.Text = "Launchbox Root:";
            label4.ToolTip = null;
            label4.ToolTipHorizontalAlignment = HorizontalAlignment.Right;
            label4.ToolTipImage = Properties.Resources.launchbox_32x32;
            label4.ToolTipText = "This should point to the root Launchbox Directory. This is the directory that contains Launchbox.exe and all the main folders such as Logs, Themes etc.";
            label4.ToolTipTitle = "Launchbox Root Directory";
            // 
            // LaunchboxFBD
            // 
            LaunchboxFBD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LaunchboxFBD.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LaunchboxFBD.BackColor = Color.Transparent;
            LaunchboxFBD.BrowserPrompt = "Please choose the Launchbox Root folder";
            LaunchboxFBD.DarkMode = false;
            LaunchboxFBD.EllipsisPosition = stigzler.Winforms.Base.UserControls.FileObjectTextBox.EllipsisPositions.End;
            LaunchboxFBD.FileSystemObjectMode = stigzler.Winforms.Base.UserControls.FileObjectTextBox.FileSystemObjectType.Folder;
            LaunchboxFBD.FontStyle = FontStyle.Regular;
            LaunchboxFBD.Image = (Image)resources.GetObject("LaunchboxFBD.Image");
            LaunchboxFBD.ImageLayout = ImageLayout.Center;
            LaunchboxFBD.Location = new Point(115, 19);
            LaunchboxFBD.Margin = new Padding(0);
            LaunchboxFBD.MultiSelect = false;
            LaunchboxFBD.Name = "LaunchboxFBD";
            LaunchboxFBD.Path = "{Please Set}";
            LaunchboxFBD.ReadOnly = true;
            LaunchboxFBD.ScaleFont = 100;
            LaunchboxFBD.Size = new Size(379, 23);
            LaunchboxFBD.TabIndex = 5;
            LaunchboxFBD.TextFont = new Font("Segoe UI", 9F);
            LaunchboxFBD.PathChanged += LaunchboxRootFB_PathChanged;
            // 
            // C64DreamsFBD
            // 
            C64DreamsFBD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            C64DreamsFBD.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            C64DreamsFBD.BackColor = Color.Transparent;
            C64DreamsFBD.BrowserPrompt = "Please choose the C64Dreams Root folder";
            C64DreamsFBD.DarkMode = false;
            C64DreamsFBD.EllipsisPosition = stigzler.Winforms.Base.UserControls.FileObjectTextBox.EllipsisPositions.End;
            C64DreamsFBD.FileSystemObjectMode = stigzler.Winforms.Base.UserControls.FileObjectTextBox.FileSystemObjectType.Folder;
            C64DreamsFBD.FontStyle = FontStyle.Regular;
            C64DreamsFBD.Image = (Image)resources.GetObject("C64DreamsFBD.Image");
            C64DreamsFBD.ImageLayout = ImageLayout.Center;
            C64DreamsFBD.Location = new Point(115, 46);
            C64DreamsFBD.Margin = new Padding(0);
            C64DreamsFBD.MultiSelect = false;
            C64DreamsFBD.Name = "C64DreamsFBD";
            C64DreamsFBD.Path = "{Please Set}";
            C64DreamsFBD.ReadOnly = true;
            C64DreamsFBD.ScaleFont = 100;
            C64DreamsFBD.Size = new Size(379, 23);
            C64DreamsFBD.TabIndex = 6;
            C64DreamsFBD.TextFont = new Font("Segoe UI", 9F);
            C64DreamsFBD.PathChanged += C64DreamsFBD_PathChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.FontStyle = FontStyle.Italic;
            label3.ForeColor = Color.FromArgb(220, 220, 220);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.ScaleFont = 100;
            label3.Size = new Size(83, 30);
            label3.TabIndex = 4;
            label3.Text = "Settings";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.ToolTip = null;
            label3.ToolTipHorizontalAlignment = HorizontalAlignment.Right;
            label3.ToolTipImage = null;
            label3.ToolTipText = null;
            label3.ToolTipTitle = null;
            // 
            // navBarTicker
            // 
            navBarTicker.Interval = 10;
            navBarTicker.Tick += navBarTicker_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 467);
            Controls.Add(MainTC);
            Controls.Add(NavBarPN);
            Controls.Add(statusStrip1);
            Controls.Add(TopPN);
            DarkMode = true;
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(220, 220, 220);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(720, 477);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C64Dreams Tool";
            ToolTip = MainTT;
            Load += Main_Load;
            TopLeftFLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            TopPN.ResumeLayout(false);
            TopPN.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            NavBarPN.ResumeLayout(false);
            MainTC.ResumeLayout(false);
            InstallTP.ResumeLayout(false);
            InstallPN.ResumeLayout(false);
            InstallPN.PerformLayout();
            InstallTopPN.ResumeLayout(false);
            InstallTopPN.PerformLayout();
            InstallButtonsFLP.ResumeLayout(false);
            SettingsTP.ResumeLayout(false);
            SettingsTP.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private stigzler.Winforms.Base.UIElements.Label label1;
        private stigzler.Winforms.Base.UIElements.FlowLayoutPanel TopLeftFLP;
        private stigzler.Winforms.Base.UIElements.Panel TopPN;
        private stigzler.Winforms.Base.UIElements.FlowLayoutPanel flowLayoutPanel1;
        private stigzler.Winforms.Base.UIElements.Button NavBarBT;
        private stigzler.Winforms.Base.UIElements.Button DarkLightModeBT;
        private stigzler.Winforms.Base.UIElements.Panel NavBarPN;
        private NavButton NavInstallBT;
        private NavButton NavSettingsBT;
        private stigzler.Winforms.Base.UIElements.TabControl MainTC;
        private TabPage InstallTP;
        private stigzler.Winforms.Base.UIElements.Label PageTitleLB;
        private TabPage SettingsTP;
        private System.Windows.Forms.Timer navBarTicker;
        private stigzler.Winforms.Base.UIElements.GroupBox groupBox1;
        private stigzler.Winforms.Base.UIElements.Label label5;
        private stigzler.Winforms.Base.UIElements.Label label4;
        private stigzler.Winforms.Base.UserControls.FileObjectTextBox LaunchboxFBD;
        private stigzler.Winforms.Base.UserControls.FileObjectTextBox C64DreamsFBD;
        private stigzler.Winforms.Base.UIElements.Label label3;
        private stigzler.Winforms.Base.UIElements.PictureBox pictureBox1;
        private stigzler.Winforms.Base.UIElements.StatusStrip statusStrip1;
        private stigzler.Winforms.Base.UIElements.ToolTip MainTT;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private stigzler.Winforms.Base.UIElements.Button Import64DBT;
        private stigzler.Winforms.Base.UIElements.Button ImportMagsBT;
        private stigzler.Winforms.Base.UIElements.Button ImportHotfixBT;
        private FlowLayoutPanel InstallButtonsFLP;
        private stigzler.Winforms.Base.UIElements.Label PathsWarningLB;
        private stigzler.Winforms.Base.UIElements.Label label6;
        private stigzler.Winforms.Base.UIElements.RichTextBox richTextBox1;
        private stigzler.Winforms.Base.UIElements.Panel InstallPN;
        private stigzler.Winforms.Base.UIElements.Panel InstallTopPN;
    }
}
