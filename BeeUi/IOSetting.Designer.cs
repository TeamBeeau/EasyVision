
namespace BeeUi
{
    partial class IOSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IOSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveRaw = new BeeUi.Common.RJButton();
            this.btnSaveRS = new BeeUi.Common.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveOK = new BeeUi.Common.RJButton();
            this.btnSaveNG = new BeeUi.Common.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pArea = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.trackLimitDay = new BeeUi.TrackBar2();
            this.label6 = new System.Windows.Forms.Label();
            this.pCany = new System.Windows.Forms.Panel();
            this.btnbig = new BeeUi.Common.RJButton();
            this.btnNormal = new BeeUi.Common.RJButton();
            this.btnSmall = new BeeUi.Common.RJButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rjButton1 = new BeeUi.Common.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pArea.SuspendLayout();
            this.pCany.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID Deivce";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Brown;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(90, 61);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(265, 39);
            this.btnConnect.TabIndex = 47;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(400, 525);
            this.tabControl2.TabIndex = 49;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.pArea);
            this.tabPage3.Controls.Add(this.pCany);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(392, 492);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "History Data";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSaveRaw);
            this.panel4.Controls.Add(this.btnSaveRS);
            this.panel4.Location = new System.Drawing.Point(6, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 50);
            this.panel4.TabIndex = 33;
            // 
            // btnSaveRaw
            // 
            this.btnSaveRaw.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveRaw.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSaveRaw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveRaw.BackgroundImage")));
            this.btnSaveRaw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveRaw.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveRaw.BorderRadius = 5;
            this.btnSaveRaw.BorderSize = 1;
            this.btnSaveRaw.FlatAppearance.BorderSize = 0;
            this.btnSaveRaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRaw.ForeColor = System.Drawing.Color.Black;
            this.btnSaveRaw.IsCLick = true;
            this.btnSaveRaw.IsNotChange = false;
            this.btnSaveRaw.IsRect = false;
            this.btnSaveRaw.IsUnGroup = true;
            this.btnSaveRaw.Location = new System.Drawing.Point(3, 5);
            this.btnSaveRaw.Name = "btnSaveRaw";
            this.btnSaveRaw.Size = new System.Drawing.Size(185, 40);
            this.btnSaveRaw.TabIndex = 7;
            this.btnSaveRaw.Text = "Raw Image";
            this.btnSaveRaw.TextColor = System.Drawing.Color.Black;
            this.btnSaveRaw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveRaw.UseVisualStyleBackColor = false;
            this.btnSaveRaw.Click += new System.EventHandler(this.btnSaveRaw_Click);
            // 
            // btnSaveRS
            // 
            this.btnSaveRS.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveRS.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSaveRS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveRS.BackgroundImage")));
            this.btnSaveRS.BorderColor = System.Drawing.Color.Silver;
            this.btnSaveRS.BorderRadius = 5;
            this.btnSaveRS.BorderSize = 1;
            this.btnSaveRS.FlatAppearance.BorderSize = 0;
            this.btnSaveRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRS.ForeColor = System.Drawing.Color.Black;
            this.btnSaveRS.IsCLick = false;
            this.btnSaveRS.IsNotChange = false;
            this.btnSaveRS.IsRect = false;
            this.btnSaveRS.IsUnGroup = true;
            this.btnSaveRS.Location = new System.Drawing.Point(195, 5);
            this.btnSaveRS.Name = "btnSaveRS";
            this.btnSaveRS.Size = new System.Drawing.Size(188, 40);
            this.btnSaveRS.TabIndex = 9;
            this.btnSaveRS.Text = "Result Image";
            this.btnSaveRS.TextColor = System.Drawing.Color.Black;
            this.btnSaveRS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveRS.UseVisualStyleBackColor = false;
            this.btnSaveRS.Click += new System.EventHandler(this.btnSaveRS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Image";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveOK);
            this.panel1.Controls.Add(this.btnSaveNG);
            this.panel1.Location = new System.Drawing.Point(6, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 50);
            this.panel1.TabIndex = 31;
            // 
            // btnSaveOK
            // 
            this.btnSaveOK.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveOK.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSaveOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveOK.BackgroundImage")));
            this.btnSaveOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveOK.BorderColor = System.Drawing.Color.Transparent;
            this.btnSaveOK.BorderRadius = 5;
            this.btnSaveOK.BorderSize = 1;
            this.btnSaveOK.FlatAppearance.BorderSize = 0;
            this.btnSaveOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOK.ForeColor = System.Drawing.Color.Black;
            this.btnSaveOK.IsCLick = true;
            this.btnSaveOK.IsNotChange = false;
            this.btnSaveOK.IsRect = false;
            this.btnSaveOK.IsUnGroup = true;
            this.btnSaveOK.Location = new System.Drawing.Point(3, 5);
            this.btnSaveOK.Name = "btnSaveOK";
            this.btnSaveOK.Size = new System.Drawing.Size(185, 40);
            this.btnSaveOK.TabIndex = 7;
            this.btnSaveOK.Text = "OK";
            this.btnSaveOK.TextColor = System.Drawing.Color.Black;
            this.btnSaveOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveOK.UseVisualStyleBackColor = false;
            this.btnSaveOK.Click += new System.EventHandler(this.btnSaveOK_Click);
            // 
            // btnSaveNG
            // 
            this.btnSaveNG.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveNG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSaveNG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveNG.BackgroundImage")));
            this.btnSaveNG.BorderColor = System.Drawing.Color.Silver;
            this.btnSaveNG.BorderRadius = 5;
            this.btnSaveNG.BorderSize = 1;
            this.btnSaveNG.FlatAppearance.BorderSize = 0;
            this.btnSaveNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNG.ForeColor = System.Drawing.Color.Black;
            this.btnSaveNG.IsCLick = false;
            this.btnSaveNG.IsNotChange = false;
            this.btnSaveNG.IsRect = false;
            this.btnSaveNG.IsUnGroup = true;
            this.btnSaveNG.Location = new System.Drawing.Point(195, 5);
            this.btnSaveNG.Name = "btnSaveNG";
            this.btnSaveNG.Size = new System.Drawing.Size(188, 40);
            this.btnSaveNG.TabIndex = 9;
            this.btnSaveNG.Text = "NG";
            this.btnSaveNG.TextColor = System.Drawing.Color.Black;
            this.btnSaveNG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveNG.UseVisualStyleBackColor = false;
            this.btnSaveNG.Click += new System.EventHandler(this.btnSaveNG_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Conditions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Compression methord";
            // 
            // pArea
            // 
            this.pArea.Controls.Add(this.label3);
            this.pArea.Controls.Add(this.trackLimitDay);
            this.pArea.Controls.Add(this.label6);
            this.pArea.Location = new System.Drawing.Point(3, 228);
            this.pArea.Name = "pArea";
            this.pArea.Size = new System.Drawing.Size(389, 76);
            this.pArea.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Day";
            // 
            // trackLimitDay
            // 
            this.trackLimitDay.ColorTrack = System.Drawing.Color.Gray;
            this.trackLimitDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackLimitDay.Location = new System.Drawing.Point(53, 18);
            this.trackLimitDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackLimitDay.Max = 60;
            this.trackLimitDay.Min = 1;
            this.trackLimitDay.Name = "trackLimitDay";
            this.trackLimitDay.Size = new System.Drawing.Size(289, 47);
            this.trackLimitDay.Step = 1;
            this.trackLimitDay.TabIndex = 28;
            this.trackLimitDay.Value = 1;
            this.trackLimitDay.ValueScore = 0;
            this.trackLimitDay.ValueChanged += new System.Action<int>(this.trackLimitDay_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Limit";
            // 
            // pCany
            // 
            this.pCany.Controls.Add(this.btnbig);
            this.pCany.Controls.Add(this.btnNormal);
            this.pCany.Controls.Add(this.btnSmall);
            this.pCany.Location = new System.Drawing.Point(3, 340);
            this.pCany.Name = "pCany";
            this.pCany.Size = new System.Drawing.Size(389, 57);
            this.pCany.TabIndex = 12;
            // 
            // btnbig
            // 
            this.btnbig.BackColor = System.Drawing.Color.Transparent;
            this.btnbig.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnbig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbig.BackgroundImage")));
            this.btnbig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbig.BorderColor = System.Drawing.Color.Transparent;
            this.btnbig.BorderRadius = 5;
            this.btnbig.BorderSize = 1;
            this.btnbig.FlatAppearance.BorderSize = 0;
            this.btnbig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbig.ForeColor = System.Drawing.Color.Black;
            this.btnbig.IsCLick = false;
            this.btnbig.IsNotChange = false;
            this.btnbig.IsRect = false;
            this.btnbig.IsUnGroup = false;
            this.btnbig.Location = new System.Drawing.Point(257, 8);
            this.btnbig.Name = "btnbig";
            this.btnbig.Size = new System.Drawing.Size(126, 40);
            this.btnbig.TabIndex = 11;
            this.btnbig.Text = "Big Size";
            this.btnbig.TextColor = System.Drawing.Color.Black;
            this.btnbig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbig.UseVisualStyleBackColor = false;
            this.btnbig.Click += new System.EventHandler(this.btnbig_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnNormal.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNormal.BackgroundImage")));
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.BorderColor = System.Drawing.Color.Transparent;
            this.btnNormal.BorderRadius = 5;
            this.btnNormal.BorderSize = 1;
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.ForeColor = System.Drawing.Color.Black;
            this.btnNormal.IsCLick = false;
            this.btnNormal.IsNotChange = false;
            this.btnNormal.IsRect = false;
            this.btnNormal.IsUnGroup = false;
            this.btnNormal.Location = new System.Drawing.Point(127, 8);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(126, 40);
            this.btnNormal.TabIndex = 10;
            this.btnNormal.Text = "Normal Size";
            this.btnNormal.TextColor = System.Drawing.Color.Black;
            this.btnNormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.BackColor = System.Drawing.Color.Transparent;
            this.btnSmall.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSmall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSmall.BackgroundImage")));
            this.btnSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSmall.BorderColor = System.Drawing.Color.Transparent;
            this.btnSmall.BorderRadius = 5;
            this.btnSmall.BorderSize = 1;
            this.btnSmall.FlatAppearance.BorderSize = 0;
            this.btnSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmall.ForeColor = System.Drawing.Color.Black;
            this.btnSmall.IsCLick = true;
            this.btnSmall.IsNotChange = false;
            this.btnSmall.IsRect = false;
            this.btnSmall.IsUnGroup = false;
            this.btnSmall.Location = new System.Drawing.Point(1, 8);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(120, 40);
            this.btnSmall.TabIndex = 7;
            this.btnSmall.Text = "Small Size";
            this.btnSmall.TextColor = System.Drawing.Color.Black;
            this.btnSmall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSmall.UseVisualStyleBackColor = false;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rjButton1);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(392, 492);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Hardware";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton1.BackgroundImage")));
            this.rjButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjButton1.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderRadius = 5;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.IsCLick = true;
            this.rjButton1.IsNotChange = true;
            this.rjButton1.IsRect = false;
            this.rjButton1.IsUnGroup = true;
            this.rjButton1.Location = new System.Drawing.Point(11, 153);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(365, 40);
            this.rjButton1.TabIndex = 56;
            this.rjButton1.Text = "Change Camera";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Camera";
            this.label8.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBox5);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Location = new System.Drawing.Point(11, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 254);
            this.panel3.TabIndex = 54;
            this.panel3.Visible = false;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.Wheat;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Bee"});
            this.comboBox5.Location = new System.Drawing.Point(96, 12);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(97, 32);
            this.comboBox5.TabIndex = 57;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.Wheat;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "CameraIV"});
            this.comboBox4.Location = new System.Drawing.Point(199, 12);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(145, 32);
            this.comboBox4.TabIndex = 56;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Wheat;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "USB 2.0",
            "USB 3.0",
            "Gig E"});
            this.comboBox3.Location = new System.Drawing.Point(12, 12);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(78, 32);
            this.comboBox3.TabIndex = 55;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(282, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 32);
            this.button2.TabIndex = 53;
            this.button2.Text = "Scan";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Wheat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 32);
            this.comboBox1.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "ID Deivce";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(90, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 39);
            this.button1.TabIndex = 52;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Resolution";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Wheat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600"});
            this.comboBox2.Location = new System.Drawing.Point(96, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(248, 32);
            this.comboBox2.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Controller ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbSerialPort);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 111);
            this.panel2.TabIndex = 50;
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.BackColor = System.Drawing.Color.Wheat;
            this.cbSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Items.AddRange(new object[] {
            "Bee"});
            this.cbSerialPort.Location = new System.Drawing.Point(90, 6);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(167, 32);
            this.cbSerialPort.TabIndex = 59;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(277, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 32);
            this.button3.TabIndex = 58;
            this.button3.Text = "Scan";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // IOSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 543);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IOSetting";
            this.Text = "Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IOSetting_FormClosing);
            this.Load += new System.EventHandler(this.IOSetting_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pArea.ResumeLayout(false);
            this.pArea.PerformLayout();
            this.pCany.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private Common.RJButton btnSaveOK;
        private Common.RJButton btnSaveNG;
        public TrackBar2 trackLimitDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pArea;
        private System.Windows.Forms.Panel pCany;
        private Common.RJButton btnSmall;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private Common.RJButton btnbig;
        private Common.RJButton btnNormal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private Common.RJButton btnSaveRaw;
        private Common.RJButton btnSaveRS;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbSerialPort;
        private Common.RJButton rjButton1;
    }
}