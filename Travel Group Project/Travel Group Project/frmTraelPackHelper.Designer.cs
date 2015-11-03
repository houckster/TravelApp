namespace Travel_Group_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemoveOne = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.lsbSelectionList = new System.Windows.Forms.ListBox();
            this.lsbChosenItems = new System.Windows.Forms.ListBox();
            this.cmbEnviroment = new System.Windows.Forms.ComboBox();
            this.dtpDepature = new System.Windows.Forms.DateTimePicker();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinalizePack = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlUrbanActivities = new System.Windows.Forms.Panel();
            this.checkBoxUrb13 = new System.Windows.Forms.CheckBox();
            this.checkBoxUrb17 = new System.Windows.Forms.CheckBox();
            this.checkBoxUrb11 = new System.Windows.Forms.CheckBox();
            this.checkBoxUrb5 = new System.Windows.Forms.CheckBox();
            this.checkBoxUrb3 = new System.Windows.Forms.CheckBox();
            this.checkBoxUrb1 = new System.Windows.Forms.CheckBox();
            this.pnlCoastalActivities = new System.Windows.Forms.Panel();
            this.checkBoxCst19 = new System.Windows.Forms.CheckBox();
            this.checkBoxCst29 = new System.Windows.Forms.CheckBox();
            this.checkBoxCst33 = new System.Windows.Forms.CheckBox();
            this.checkBoxCst34 = new System.Windows.Forms.CheckBox();
            this.checkBoxCst35 = new System.Windows.Forms.CheckBox();
            this.checkBoxCst36 = new System.Windows.Forms.CheckBox();
            this.pnlMountainActivities = new System.Windows.Forms.Panel();
            this.checkBoxMtn41 = new System.Windows.Forms.CheckBox();
            this.checkBoxMtn43 = new System.Windows.Forms.CheckBox();
            this.checkBoxMtn44 = new System.Windows.Forms.CheckBox();
            this.checkBoxMtn49 = new System.Windows.Forms.CheckBox();
            this.checkBoxMtn52 = new System.Windows.Forms.CheckBox();
            this.checkBoxMtn54 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbActivities = new System.Windows.Forms.GroupBox();
            this.lsbRecommendation = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlUrbanActivities.SuspendLayout();
            this.pnlCoastalActivities.SuspendLayout();
            this.pnlMountainActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbActivities.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddOne
            // 
            this.btnAddOne.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddOne.BackgroundImage")));
            this.btnAddOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddOne.Location = new System.Drawing.Point(189, 45);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(75, 30);
            this.btnAddOne.TabIndex = 0;
            this.btnAddOne.Text = "&Add >";
            this.btnAddOne.UseVisualStyleBackColor = false;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAll.BackgroundImage")));
            this.btnAddAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddAll.Location = new System.Drawing.Point(189, 81);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(75, 30);
            this.btnAddAll.TabIndex = 1;
            this.btnAddAll.Text = "A&dd All >>";
            this.btnAddAll.UseVisualStyleBackColor = false;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRemoveOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveOne.BackgroundImage")));
            this.btnRemoveOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveOne.Location = new System.Drawing.Point(189, 138);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(75, 30);
            this.btnRemoveOne.TabIndex = 2;
            this.btnRemoveOne.Text = "< &Remove";
            this.btnRemoveOne.UseVisualStyleBackColor = false;
            this.btnRemoveOne.Click += new System.EventHandler(this.btnRemoveOne_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRemoveAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveAll.BackgroundImage")));
            this.btnRemoveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveAll.Location = new System.Drawing.Point(189, 174);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 30);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "<< R&emove All";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // lsbSelectionList
            // 
            this.lsbSelectionList.FormattingEnabled = true;
            this.lsbSelectionList.Items.AddRange(new object[] {
            "Art Materials",
            "Boots",
            "Bug Spray",
            "Cap/Hat",
            "Compass",
            "Concert Tickets",
            "Convention Pass Docs",
            "Dance Shoes",
            "Dress Suit/Clothes",
            "Gloves",
            "Hair Gel",
            "Hairbrush",
            "Jacket",
            "Laptop",
            "Pants",
            "Power Cables",
            "Shirts",
            "Shorts",
            "Socks",
            "Spare Book(s)",
            "Spare Change",
            "Spare Contacts",
            "Spare Glasses",
            "Sports Jersey",
            "Sun Screen",
            "Sweater",
            "Swimming Trunks",
            "Toothpaste & Toothbrush",
            "Underwear/Boxers",
            "Water Bottle",
            "Wind Breaker"});
            this.lsbSelectionList.Location = new System.Drawing.Point(15, 31);
            this.lsbSelectionList.Name = "lsbSelectionList";
            this.lsbSelectionList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbSelectionList.Size = new System.Drawing.Size(152, 238);
            this.lsbSelectionList.Sorted = true;
            this.lsbSelectionList.TabIndex = 4;
            this.lsbSelectionList.TabStop = false;
            // 
            // lsbChosenItems
            // 
            this.lsbChosenItems.FormattingEnabled = true;
            this.lsbChosenItems.Location = new System.Drawing.Point(280, 31);
            this.lsbChosenItems.Name = "lsbChosenItems";
            this.lsbChosenItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbChosenItems.Size = new System.Drawing.Size(153, 238);
            this.lsbChosenItems.TabIndex = 5;
            // 
            // cmbEnviroment
            // 
            this.cmbEnviroment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnviroment.FormattingEnabled = true;
            this.cmbEnviroment.Items.AddRange(new object[] {
            "Mountains",
            "Urban",
            "Coastal"});
            this.cmbEnviroment.Location = new System.Drawing.Point(82, 309);
            this.cmbEnviroment.Name = "cmbEnviroment";
            this.cmbEnviroment.Size = new System.Drawing.Size(121, 21);
            this.cmbEnviroment.TabIndex = 6;
            this.cmbEnviroment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbEnviroment.SelectedValueChanged += new System.EventHandler(this.cmbEnviroment_SelectedValueChanged);
            // 
            // dtpDepature
            // 
            this.dtpDepature.Location = new System.Drawing.Point(82, 344);
            this.dtpDepature.Name = "dtpDepature";
            this.dtpDepature.Size = new System.Drawing.Size(200, 20);
            this.dtpDepature.TabIndex = 9;
            // 
            // dtpReturn
            // 
            this.dtpReturn.Location = new System.Drawing.Point(82, 383);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(200, 20);
            this.dtpReturn.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Departure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Return";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Environment";
            // 
            // btnFinalizePack
            // 
            this.btnFinalizePack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizePack.BackgroundImage")));
            this.btnFinalizePack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizePack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalizePack.Location = new System.Drawing.Point(645, 227);
            this.btnFinalizePack.Name = "btnFinalizePack";
            this.btnFinalizePack.Size = new System.Drawing.Size(88, 38);
            this.btnFinalizePack.TabIndex = 15;
            this.btnFinalizePack.Text = "&Finalize Pack";
            this.btnFinalizePack.UseVisualStyleBackColor = true;
            this.btnFinalizePack.Click += new System.EventHandler(this.btnFinalizePack_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnClearForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearForm.BackgroundImage")));
            this.btnClearForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearForm.Location = new System.Drawing.Point(645, 145);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(88, 35);
            this.btnClearForm.TabIndex = 16;
            this.btnClearForm.Text = "&Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = false;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(645, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 35);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(640, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 80);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pnlUrbanActivities
            // 
            this.pnlUrbanActivities.Controls.Add(this.checkBoxUrb13);
            this.pnlUrbanActivities.Controls.Add(this.checkBoxUrb17);
            this.pnlUrbanActivities.Controls.Add(this.checkBoxUrb11);
            this.pnlUrbanActivities.Controls.Add(this.checkBoxUrb5);
            this.pnlUrbanActivities.Controls.Add(this.checkBoxUrb3);
            this.pnlUrbanActivities.Controls.Add(this.checkBoxUrb1);
            this.pnlUrbanActivities.Location = new System.Drawing.Point(16, 24);
            this.pnlUrbanActivities.Name = "pnlUrbanActivities";
            this.pnlUrbanActivities.Size = new System.Drawing.Size(306, 105);
            this.pnlUrbanActivities.TabIndex = 19;
            // 
            // checkBoxUrb13
            // 
            this.checkBoxUrb13.AutoSize = true;
            this.checkBoxUrb13.Location = new System.Drawing.Point(32, 48);
            this.checkBoxUrb13.Name = "checkBoxUrb13";
            this.checkBoxUrb13.Size = new System.Drawing.Size(80, 17);
            this.checkBoxUrb13.TabIndex = 17;
            this.checkBoxUrb13.Text = "Convention";
            this.checkBoxUrb13.UseVisualStyleBackColor = true;
            this.checkBoxUrb13.CheckedChanged += new System.EventHandler(this.checkBoxUrb13_CheckedChanged);
            // 
            // checkBoxUrb17
            // 
            this.checkBoxUrb17.AutoSize = true;
            this.checkBoxUrb17.Location = new System.Drawing.Point(168, 24);
            this.checkBoxUrb17.Name = "checkBoxUrb17";
            this.checkBoxUrb17.Size = new System.Drawing.Size(106, 17);
            this.checkBoxUrb17.TabIndex = 13;
            this.checkBoxUrb17.Text = "Dine Out - Fancy";
            this.checkBoxUrb17.UseVisualStyleBackColor = true;
            this.checkBoxUrb17.CheckedChanged += new System.EventHandler(this.checkBoxUrb17_CheckedChanged);
            // 
            // checkBoxUrb11
            // 
            this.checkBoxUrb11.AutoSize = true;
            this.checkBoxUrb11.Location = new System.Drawing.Point(168, 72);
            this.checkBoxUrb11.Name = "checkBoxUrb11";
            this.checkBoxUrb11.Size = new System.Drawing.Size(87, 17);
            this.checkBoxUrb11.TabIndex = 7;
            this.checkBoxUrb11.Text = "Sports Event";
            this.checkBoxUrb11.UseVisualStyleBackColor = true;
            this.checkBoxUrb11.CheckedChanged += new System.EventHandler(this.checkBoxUrb11_CheckedChanged);
            // 
            // checkBoxUrb5
            // 
            this.checkBoxUrb5.AutoSize = true;
            this.checkBoxUrb5.Location = new System.Drawing.Point(168, 48);
            this.checkBoxUrb5.Name = "checkBoxUrb5";
            this.checkBoxUrb5.Size = new System.Drawing.Size(98, 17);
            this.checkBoxUrb5.TabIndex = 4;
            this.checkBoxUrb5.Text = "Visit A Museum";
            this.checkBoxUrb5.UseVisualStyleBackColor = true;
            this.checkBoxUrb5.CheckedChanged += new System.EventHandler(this.checkBoxUrb5_CheckedChanged);
            // 
            // checkBoxUrb3
            // 
            this.checkBoxUrb3.AutoSize = true;
            this.checkBoxUrb3.Location = new System.Drawing.Point(33, 70);
            this.checkBoxUrb3.Name = "checkBoxUrb3";
            this.checkBoxUrb3.Size = new System.Drawing.Size(100, 17);
            this.checkBoxUrb3.TabIndex = 2;
            this.checkBoxUrb3.Text = "Go To The Zoo";
            this.checkBoxUrb3.UseVisualStyleBackColor = true;
            this.checkBoxUrb3.CheckedChanged += new System.EventHandler(this.checkBoxUrb3_CheckedChanged);
            // 
            // checkBoxUrb1
            // 
            this.checkBoxUrb1.AutoSize = true;
            this.checkBoxUrb1.Location = new System.Drawing.Point(32, 25);
            this.checkBoxUrb1.Name = "checkBoxUrb1";
            this.checkBoxUrb1.Size = new System.Drawing.Size(80, 17);
            this.checkBoxUrb1.TabIndex = 0;
            this.checkBoxUrb1.Text = "Hit The Bar";
            this.checkBoxUrb1.UseVisualStyleBackColor = true;
            this.checkBoxUrb1.CheckedChanged += new System.EventHandler(this.checkBoxUrb1_CheckedChanged);
            // 
            // pnlCoastalActivities
            // 
            this.pnlCoastalActivities.Controls.Add(this.checkBoxCst19);
            this.pnlCoastalActivities.Controls.Add(this.checkBoxCst29);
            this.pnlCoastalActivities.Controls.Add(this.checkBoxCst33);
            this.pnlCoastalActivities.Controls.Add(this.checkBoxCst34);
            this.pnlCoastalActivities.Controls.Add(this.checkBoxCst35);
            this.pnlCoastalActivities.Controls.Add(this.checkBoxCst36);
            this.pnlCoastalActivities.Location = new System.Drawing.Point(16, 24);
            this.pnlCoastalActivities.Name = "pnlCoastalActivities";
            this.pnlCoastalActivities.Size = new System.Drawing.Size(306, 106);
            this.pnlCoastalActivities.TabIndex = 20;
            // 
            // checkBoxCst19
            // 
            this.checkBoxCst19.AutoSize = true;
            this.checkBoxCst19.Location = new System.Drawing.Point(160, 48);
            this.checkBoxCst19.Name = "checkBoxCst19";
            this.checkBoxCst19.Size = new System.Drawing.Size(103, 17);
            this.checkBoxCst19.TabIndex = 17;
            this.checkBoxCst19.Text = "Beach Bumming";
            this.checkBoxCst19.UseVisualStyleBackColor = true;
            this.checkBoxCst19.CheckedChanged += new System.EventHandler(this.checkBoxCst19_CheckedChanged);
            // 
            // checkBoxCst29
            // 
            this.checkBoxCst29.AutoSize = true;
            this.checkBoxCst29.Location = new System.Drawing.Point(160, 24);
            this.checkBoxCst29.Name = "checkBoxCst29";
            this.checkBoxCst29.Size = new System.Drawing.Size(133, 17);
            this.checkBoxCst29.TabIndex = 7;
            this.checkBoxCst29.Text = "Visit Wildlife Sanctuary";
            this.checkBoxCst29.UseVisualStyleBackColor = true;
            this.checkBoxCst29.CheckedChanged += new System.EventHandler(this.checkBoxCst29_CheckedChanged);
            // 
            // checkBoxCst33
            // 
            this.checkBoxCst33.AutoSize = true;
            this.checkBoxCst33.Location = new System.Drawing.Point(160, 72);
            this.checkBoxCst33.Name = "checkBoxCst33";
            this.checkBoxCst33.Size = new System.Drawing.Size(57, 17);
            this.checkBoxCst33.TabIndex = 3;
            this.checkBoxCst33.Text = "Sailing";
            this.checkBoxCst33.UseVisualStyleBackColor = true;
            this.checkBoxCst33.CheckedChanged += new System.EventHandler(this.checkBoxCst33_CheckedChanged);
            // 
            // checkBoxCst34
            // 
            this.checkBoxCst34.AutoSize = true;
            this.checkBoxCst34.Location = new System.Drawing.Point(16, 70);
            this.checkBoxCst34.Name = "checkBoxCst34";
            this.checkBoxCst34.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCst34.TabIndex = 2;
            this.checkBoxCst34.Text = "Surfing";
            this.checkBoxCst34.UseVisualStyleBackColor = true;
            this.checkBoxCst34.CheckedChanged += new System.EventHandler(this.checkBoxCst34_CheckedChanged);
            // 
            // checkBoxCst35
            // 
            this.checkBoxCst35.AutoSize = true;
            this.checkBoxCst35.Location = new System.Drawing.Point(16, 48);
            this.checkBoxCst35.Name = "checkBoxCst35";
            this.checkBoxCst35.Size = new System.Drawing.Size(106, 17);
            this.checkBoxCst35.TabIndex = 1;
            this.checkBoxCst35.Text = "Amusement Park";
            this.checkBoxCst35.UseVisualStyleBackColor = true;
            this.checkBoxCst35.CheckedChanged += new System.EventHandler(this.checkBoxCst35_CheckedChanged);
            // 
            // checkBoxCst36
            // 
            this.checkBoxCst36.AutoSize = true;
            this.checkBoxCst36.Location = new System.Drawing.Point(15, 24);
            this.checkBoxCst36.Name = "checkBoxCst36";
            this.checkBoxCst36.Size = new System.Drawing.Size(81, 17);
            this.checkBoxCst36.TabIndex = 0;
            this.checkBoxCst36.Text = "Resort Stay";
            this.checkBoxCst36.UseVisualStyleBackColor = true;
            this.checkBoxCst36.CheckedChanged += new System.EventHandler(this.checkBoxCst36_CheckedChanged);
            // 
            // pnlMountainActivities
            // 
            this.pnlMountainActivities.BackColor = System.Drawing.Color.Transparent;
            this.pnlMountainActivities.Controls.Add(this.checkBoxMtn41);
            this.pnlMountainActivities.Controls.Add(this.checkBoxMtn43);
            this.pnlMountainActivities.Controls.Add(this.checkBoxMtn44);
            this.pnlMountainActivities.Controls.Add(this.checkBoxMtn49);
            this.pnlMountainActivities.Controls.Add(this.checkBoxMtn52);
            this.pnlMountainActivities.Controls.Add(this.checkBoxMtn54);
            this.pnlMountainActivities.Location = new System.Drawing.Point(16, 24);
            this.pnlMountainActivities.Name = "pnlMountainActivities";
            this.pnlMountainActivities.Size = new System.Drawing.Size(306, 106);
            this.pnlMountainActivities.TabIndex = 21;
            // 
            // checkBoxMtn41
            // 
            this.checkBoxMtn41.AutoSize = true;
            this.checkBoxMtn41.Location = new System.Drawing.Point(168, 24);
            this.checkBoxMtn41.Name = "checkBoxMtn41";
            this.checkBoxMtn41.Size = new System.Drawing.Size(108, 17);
            this.checkBoxMtn41.TabIndex = 13;
            this.checkBoxMtn41.Text = "Treasure Hunting";
            this.checkBoxMtn41.UseVisualStyleBackColor = true;
            this.checkBoxMtn41.CheckedChanged += new System.EventHandler(this.checkBoxMtn41_CheckedChanged);
            // 
            // checkBoxMtn43
            // 
            this.checkBoxMtn43.AutoSize = true;
            this.checkBoxMtn43.Location = new System.Drawing.Point(168, 72);
            this.checkBoxMtn43.Name = "checkBoxMtn43";
            this.checkBoxMtn43.Size = new System.Drawing.Size(112, 17);
            this.checkBoxMtn43.TabIndex = 11;
            this.checkBoxMtn43.Text = "Mountain Climbing";
            this.checkBoxMtn43.UseVisualStyleBackColor = true;
            this.checkBoxMtn43.CheckedChanged += new System.EventHandler(this.checkBoxMtn43_CheckedChanged);
            // 
            // checkBoxMtn44
            // 
            this.checkBoxMtn44.AutoSize = true;
            this.checkBoxMtn44.Location = new System.Drawing.Point(32, 48);
            this.checkBoxMtn44.Name = "checkBoxMtn44";
            this.checkBoxMtn44.Size = new System.Drawing.Size(87, 17);
            this.checkBoxMtn44.TabIndex = 10;
            this.checkBoxMtn44.Text = "Horse Riding";
            this.checkBoxMtn44.UseVisualStyleBackColor = true;
            this.checkBoxMtn44.CheckedChanged += new System.EventHandler(this.checkBoxMtn44_CheckedChanged);
            // 
            // checkBoxMtn49
            // 
            this.checkBoxMtn49.AutoSize = true;
            this.checkBoxMtn49.Location = new System.Drawing.Point(168, 48);
            this.checkBoxMtn49.Name = "checkBoxMtn49";
            this.checkBoxMtn49.Size = new System.Drawing.Size(101, 17);
            this.checkBoxMtn49.TabIndex = 5;
            this.checkBoxMtn49.Text = "Lake Cabin Trip";
            this.checkBoxMtn49.UseVisualStyleBackColor = true;
            this.checkBoxMtn49.CheckedChanged += new System.EventHandler(this.checkBoxMtn49_CheckedChanged);
            // 
            // checkBoxMtn52
            // 
            this.checkBoxMtn52.AutoSize = true;
            this.checkBoxMtn52.Location = new System.Drawing.Point(32, 69);
            this.checkBoxMtn52.Name = "checkBoxMtn52";
            this.checkBoxMtn52.Size = new System.Drawing.Size(67, 17);
            this.checkBoxMtn52.TabIndex = 2;
            this.checkBoxMtn52.Text = "Camping";
            this.checkBoxMtn52.UseVisualStyleBackColor = true;
            this.checkBoxMtn52.CheckedChanged += new System.EventHandler(this.checkBoxMtn52_CheckedChanged);
            // 
            // checkBoxMtn54
            // 
            this.checkBoxMtn54.AutoSize = true;
            this.checkBoxMtn54.Location = new System.Drawing.Point(32, 25);
            this.checkBoxMtn54.Name = "checkBoxMtn54";
            this.checkBoxMtn54.Size = new System.Drawing.Size(56, 17);
            this.checkBoxMtn54.TabIndex = 0;
            this.checkBoxMtn54.Text = "Hiking";
            this.checkBoxMtn54.UseVisualStyleBackColor = true;
            this.checkBoxMtn54.CheckedChanged += new System.EventHandler(this.checkBoxMtn54_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(824, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // grbActivities
            // 
            this.grbActivities.BackColor = System.Drawing.Color.Transparent;
            this.grbActivities.Controls.Add(this.pnlUrbanActivities);
            this.grbActivities.Controls.Add(this.pnlMountainActivities);
            this.grbActivities.Controls.Add(this.pnlCoastalActivities);
            this.grbActivities.Location = new System.Drawing.Point(288, 288);
            this.grbActivities.Name = "grbActivities";
            this.grbActivities.Size = new System.Drawing.Size(336, 152);
            this.grbActivities.TabIndex = 27;
            this.grbActivities.TabStop = false;
            this.grbActivities.Text = "Activities Selection";
            // 
            // lsbRecommendation
            // 
            this.lsbRecommendation.Location = new System.Drawing.Point(472, 64);
            this.lsbRecommendation.Name = "lsbRecommendation";
            this.lsbRecommendation.Size = new System.Drawing.Size(144, 208);
            this.lsbRecommendation.TabIndex = 28;
            this.lsbRecommendation.UseCompatibleStateImageBehavior = false;
            this.lsbRecommendation.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Trip Recommendations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Selection List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Chosen List";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(824, 448);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsbRecommendation);
            this.Controls.Add(this.grbActivities);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnFinalizePack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.dtpDepature);
            this.Controls.Add(this.cmbEnviroment);
            this.Controls.Add(this.lsbChosenItems);
            this.Controls.Add(this.lsbSelectionList);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveOne);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Travel Packing Helper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlUrbanActivities.ResumeLayout(false);
            this.pnlUrbanActivities.PerformLayout();
            this.pnlCoastalActivities.ResumeLayout(false);
            this.pnlCoastalActivities.PerformLayout();
            this.pnlMountainActivities.ResumeLayout(false);
            this.pnlMountainActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbActivities.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemoveOne;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.ListBox lsbSelectionList;
        private System.Windows.Forms.ListBox lsbChosenItems;
        private System.Windows.Forms.ComboBox cmbEnviroment;
        private System.Windows.Forms.DateTimePicker dtpDepature;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinalizePack;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlUrbanActivities;
        private System.Windows.Forms.CheckBox checkBoxUrb13;
        private System.Windows.Forms.CheckBox checkBoxUrb17;
        private System.Windows.Forms.CheckBox checkBoxUrb11;
        private System.Windows.Forms.CheckBox checkBoxUrb5;
        private System.Windows.Forms.CheckBox checkBoxUrb3;
        private System.Windows.Forms.CheckBox checkBoxUrb1;
        private System.Windows.Forms.Panel pnlCoastalActivities;
        private System.Windows.Forms.CheckBox checkBoxCst19;
        private System.Windows.Forms.CheckBox checkBoxCst29;
        private System.Windows.Forms.CheckBox checkBoxCst33;
        private System.Windows.Forms.CheckBox checkBoxCst34;
        private System.Windows.Forms.CheckBox checkBoxCst35;
        private System.Windows.Forms.CheckBox checkBoxCst36;
        private System.Windows.Forms.Panel pnlMountainActivities;
        private System.Windows.Forms.CheckBox checkBoxMtn41;
        private System.Windows.Forms.CheckBox checkBoxMtn43;
        private System.Windows.Forms.CheckBox checkBoxMtn44;
        private System.Windows.Forms.CheckBox checkBoxMtn49;
        private System.Windows.Forms.CheckBox checkBoxMtn52;
        private System.Windows.Forms.CheckBox checkBoxMtn54;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbActivities;
        private System.Windows.Forms.ListView lsbRecommendation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

