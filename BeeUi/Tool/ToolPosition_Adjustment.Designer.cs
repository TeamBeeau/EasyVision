﻿namespace BeeUi.Tool
{
    partial class ToolPosition_Adjustment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolPosition_Adjustment));
            this.threadProcess = new System.ComponentModel.BackgroundWorker();
            this.tmClear = new System.Windows.Forms.Timer(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.trackMaxOverLap = new BeeUi.TrackBar2();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMask = new BeeUi.Common.RJButton();
            this.btnClear = new BeeUi.Common.RJButton();
            this.pCany = new System.Windows.Forms.Panel();
            this.btnCannyMin = new BeeUi.Common.RJButton();
            this.btnCannyMedium = new BeeUi.Common.RJButton();
            this.btnCannyMax = new BeeUi.Common.RJButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnHighSpeed = new BeeUi.Common.RJButton();
            this.btnNormal = new BeeUi.Common.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.btnSubAngle = new BeeUi.Common.RJButton();
            this.btnPlusAngle = new BeeUi.Common.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckSubPixel = new BeeUi.Common.RJButton();
            this.ckBitwiseNot = new BeeUi.Common.RJButton();
            this.ckSIMD = new BeeUi.Common.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.trackScore = new BeeUi.TrackBar2();
            this.btnCancel = new BeeUi.Common.RJButton();
            this.btnOK = new BeeUi.Common.RJButton();
            this.rjButton2 = new BeeUi.Common.RJButton();
            this.rjButton5 = new BeeUi.Common.RJButton();
            this.trackBar21 = new BeeUi.TrackBar2();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAutoTrigger = new BeeUi.Common.RJButton();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.numOK = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPattern = new BeeUi.Common.RJButton();
            this.btnOutLine = new BeeUi.Common.RJButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rjButton3 = new BeeUi.Common.RJButton();
            this.rjButton1 = new BeeUi.Common.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pArea = new System.Windows.Forms.Panel();
            this.btnCropArea = new BeeUi.Common.RJButton();
            this.btnCropRect = new BeeUi.Common.RJButton();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pCany.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOK)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // threadProcess
            // 
            this.threadProcess.WorkerReportsProgress = true;
            this.threadProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadProcess_DoWork);
            this.threadProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadProcess_RunWorkerCompleted);
            // 
            // tmClear
            // 
            this.tmClear.Tick += new System.EventHandler(this.tmClear_Tick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.trackMaxOverLap);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.pCany);
            this.tabPage4.Controls.Add(this.panel6);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(392, 492);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Chức năng mở rộng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // trackMaxOverLap
            // 
            this.trackMaxOverLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackMaxOverLap.Location = new System.Drawing.Point(7, 116);
            this.trackMaxOverLap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackMaxOverLap.Max = 100;
            this.trackMaxOverLap.Min = 0;
            this.trackMaxOverLap.Name = "trackMaxOverLap";
            this.trackMaxOverLap.Size = new System.Drawing.Size(378, 45);
            this.trackMaxOverLap.Step = 1;
            this.trackMaxOverLap.TabIndex = 30;
            this.trackMaxOverLap.Value = 0;
            this.trackMaxOverLap.ValueChanged += new System.Action<int>(this.trackMaxOverLap_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Fine tune outline";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMask);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Location = new System.Drawing.Point(10, 434);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 52);
            this.panel4.TabIndex = 17;
            // 
            // btnMask
            // 
            this.btnMask.BackColor = System.Drawing.Color.Transparent;
            this.btnMask.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMask.BackgroundImage")));
            this.btnMask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMask.BorderColor = System.Drawing.Color.Transparent;
            this.btnMask.BorderRadius = 5;
            this.btnMask.BorderSize = 1;
            this.btnMask.FlatAppearance.BorderSize = 0;
            this.btnMask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMask.ForeColor = System.Drawing.Color.Black;
            this.btnMask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMask.IsCLick = false;
            this.btnMask.IsNotChange = false;
            this.btnMask.IsRect = false;
            this.btnMask.IsUnGroup = false;
            this.btnMask.Location = new System.Drawing.Point(111, 6);
            this.btnMask.Name = "btnMask";
            this.btnMask.Size = new System.Drawing.Size(96, 40);
            this.btnMask.TabIndex = 5;
            this.btnMask.Text = "Mask";
            this.btnMask.TextColor = System.Drawing.Color.Black;
            this.btnMask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMask.UseVisualStyleBackColor = false;
            this.btnMask.Click += new System.EventHandler(this.btnMask_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.BorderRadius = 3;
            this.btnClear.BorderSize = 1;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.IsCLick = false;
            this.btnClear.IsNotChange = false;
            this.btnClear.IsRect = false;
            this.btnClear.IsUnGroup = true;
            this.btnClear.Location = new System.Drawing.Point(10, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Erase";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextColor = System.Drawing.Color.Black;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pCany
            // 
            this.pCany.Controls.Add(this.btnCannyMin);
            this.pCany.Controls.Add(this.btnCannyMedium);
            this.pCany.Controls.Add(this.btnCannyMax);
            this.pCany.Location = new System.Drawing.Point(7, 268);
            this.pCany.Name = "pCany";
            this.pCany.Size = new System.Drawing.Size(374, 48);
            this.pCany.TabIndex = 29;
            // 
            // btnCannyMin
            // 
            this.btnCannyMin.BackColor = System.Drawing.Color.Transparent;
            this.btnCannyMin.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCannyMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCannyMin.BackgroundImage")));
            this.btnCannyMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCannyMin.BorderColor = System.Drawing.Color.Transparent;
            this.btnCannyMin.BorderRadius = 5;
            this.btnCannyMin.BorderSize = 1;
            this.btnCannyMin.FlatAppearance.BorderSize = 0;
            this.btnCannyMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCannyMin.ForeColor = System.Drawing.Color.Black;
            this.btnCannyMin.IsCLick = true;
            this.btnCannyMin.IsNotChange = false;
            this.btnCannyMin.IsRect = false;
            this.btnCannyMin.IsUnGroup = false;
            this.btnCannyMin.Location = new System.Drawing.Point(5, 5);
            this.btnCannyMin.Name = "btnCannyMin";
            this.btnCannyMin.Size = new System.Drawing.Size(110, 40);
            this.btnCannyMin.TabIndex = 7;
            this.btnCannyMin.Text = "Thấp";
            this.btnCannyMin.TextColor = System.Drawing.Color.Black;
            this.btnCannyMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCannyMin.UseVisualStyleBackColor = false;
            this.btnCannyMin.Click += new System.EventHandler(this.btnCannyMin_Click);
            // 
            // btnCannyMedium
            // 
            this.btnCannyMedium.BackColor = System.Drawing.SystemColors.Control;
            this.btnCannyMedium.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnCannyMedium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCannyMedium.BackgroundImage")));
            this.btnCannyMedium.BorderColor = System.Drawing.Color.Silver;
            this.btnCannyMedium.BorderRadius = 5;
            this.btnCannyMedium.BorderSize = 1;
            this.btnCannyMedium.FlatAppearance.BorderSize = 0;
            this.btnCannyMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCannyMedium.ForeColor = System.Drawing.Color.Black;
            this.btnCannyMedium.IsCLick = false;
            this.btnCannyMedium.IsNotChange = false;
            this.btnCannyMedium.IsRect = false;
            this.btnCannyMedium.IsUnGroup = false;
            this.btnCannyMedium.Location = new System.Drawing.Point(130, 5);
            this.btnCannyMedium.Name = "btnCannyMedium";
            this.btnCannyMedium.Size = new System.Drawing.Size(110, 40);
            this.btnCannyMedium.TabIndex = 8;
            this.btnCannyMedium.Text = "Trung bình";
            this.btnCannyMedium.TextColor = System.Drawing.Color.Black;
            this.btnCannyMedium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCannyMedium.UseVisualStyleBackColor = false;
            this.btnCannyMedium.Click += new System.EventHandler(this.btnCannyMedium_Click);
            // 
            // btnCannyMax
            // 
            this.btnCannyMax.BackColor = System.Drawing.SystemColors.Control;
            this.btnCannyMax.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnCannyMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCannyMax.BackgroundImage")));
            this.btnCannyMax.BorderColor = System.Drawing.Color.Silver;
            this.btnCannyMax.BorderRadius = 5;
            this.btnCannyMax.BorderSize = 1;
            this.btnCannyMax.FlatAppearance.BorderSize = 0;
            this.btnCannyMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCannyMax.ForeColor = System.Drawing.Color.Black;
            this.btnCannyMax.IsCLick = false;
            this.btnCannyMax.IsNotChange = false;
            this.btnCannyMax.IsRect = false;
            this.btnCannyMax.IsUnGroup = false;
            this.btnCannyMax.Location = new System.Drawing.Point(260, 5);
            this.btnCannyMax.Name = "btnCannyMax";
            this.btnCannyMax.Size = new System.Drawing.Size(110, 40);
            this.btnCannyMax.TabIndex = 9;
            this.btnCannyMax.Text = "Cao";
            this.btnCannyMax.TextColor = System.Drawing.Color.Black;
            this.btnCannyMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCannyMax.UseVisualStyleBackColor = false;
            this.btnCannyMax.Click += new System.EventHandler(this.btnCannyMax_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnHighSpeed);
            this.panel6.Controls.Add(this.btnNormal);
            this.panel6.Location = new System.Drawing.Point(7, 370);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(364, 48);
            this.panel6.TabIndex = 27;
            // 
            // btnHighSpeed
            // 
            this.btnHighSpeed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHighSpeed.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnHighSpeed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHighSpeed.BackgroundImage")));
            this.btnHighSpeed.BorderColor = System.Drawing.Color.Silver;
            this.btnHighSpeed.BorderRadius = 5;
            this.btnHighSpeed.BorderSize = 1;
            this.btnHighSpeed.FlatAppearance.BorderSize = 0;
            this.btnHighSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighSpeed.ForeColor = System.Drawing.Color.Black;
            this.btnHighSpeed.IsCLick = false;
            this.btnHighSpeed.IsNotChange = false;
            this.btnHighSpeed.IsRect = false;
            this.btnHighSpeed.IsUnGroup = false;
            this.btnHighSpeed.Location = new System.Drawing.Point(179, 3);
            this.btnHighSpeed.Name = "btnHighSpeed";
            this.btnHighSpeed.Size = new System.Drawing.Size(175, 40);
            this.btnHighSpeed.TabIndex = 3;
            this.btnHighSpeed.Text = "High Speed";
            this.btnHighSpeed.TextColor = System.Drawing.Color.Black;
            this.btnHighSpeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHighSpeed.UseVisualStyleBackColor = false;
            this.btnHighSpeed.Click += new System.EventHandler(this.btnHighSpeed_Click);
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
            this.btnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.ForeColor = System.Drawing.Color.Black;
            this.btnNormal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNormal.IsCLick = true;
            this.btnNormal.IsNotChange = false;
            this.btnNormal.IsRect = false;
            this.btnNormal.IsUnGroup = false;
            this.btnNormal.Location = new System.Drawing.Point(2, 3);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(175, 40);
            this.btnNormal.TabIndex = 2;
            this.btnNormal.Text = "Normal";
            this.btnNormal.TextColor = System.Drawing.Color.Black;
            this.btnNormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search Algorithm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 48);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtAngle);
            this.panel3.Controls.Add(this.btnSubAngle);
            this.panel3.Controls.Add(this.btnPlusAngle);
            this.panel3.Location = new System.Drawing.Point(173, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 42);
            this.panel3.TabIndex = 23;
            // 
            // txtAngle
            // 
            this.txtAngle.BackColor = System.Drawing.Color.White;
            this.txtAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngle.Location = new System.Drawing.Point(55, 0);
            this.txtAngle.Multiline = true;
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(80, 40);
            this.txtAngle.TabIndex = 10;
            this.txtAngle.Text = "1";
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAngle.TextChanged += new System.EventHandler(this.txtAngle_TextChanged);
            // 
            // btnSubAngle
            // 
            this.btnSubAngle.BackColor = System.Drawing.Color.Transparent;
            this.btnSubAngle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSubAngle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubAngle.BackgroundImage")));
            this.btnSubAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubAngle.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubAngle.BorderRadius = 3;
            this.btnSubAngle.BorderSize = 1;
            this.btnSubAngle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSubAngle.FlatAppearance.BorderSize = 0;
            this.btnSubAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAngle.ForeColor = System.Drawing.Color.Black;
            this.btnSubAngle.Image = ((System.Drawing.Image)(resources.GetObject("btnSubAngle.Image")));
            this.btnSubAngle.IsCLick = false;
            this.btnSubAngle.IsNotChange = true;
            this.btnSubAngle.IsRect = false;
            this.btnSubAngle.IsUnGroup = false;
            this.btnSubAngle.Location = new System.Drawing.Point(0, 0);
            this.btnSubAngle.Name = "btnSubAngle";
            this.btnSubAngle.Size = new System.Drawing.Size(55, 40);
            this.btnSubAngle.TabIndex = 7;
            this.btnSubAngle.TextColor = System.Drawing.Color.Black;
            this.btnSubAngle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubAngle.UseVisualStyleBackColor = false;
            this.btnSubAngle.Click += new System.EventHandler(this.btnSubAngle_Click);
            // 
            // btnPlusAngle
            // 
            this.btnPlusAngle.BackColor = System.Drawing.Color.Transparent;
            this.btnPlusAngle.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlusAngle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlusAngle.BackgroundImage")));
            this.btnPlusAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlusAngle.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlusAngle.BorderRadius = 3;
            this.btnPlusAngle.BorderSize = 1;
            this.btnPlusAngle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlusAngle.FlatAppearance.BorderSize = 0;
            this.btnPlusAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusAngle.ForeColor = System.Drawing.Color.Black;
            this.btnPlusAngle.Image = ((System.Drawing.Image)(resources.GetObject("btnPlusAngle.Image")));
            this.btnPlusAngle.IsCLick = true;
            this.btnPlusAngle.IsNotChange = true;
            this.btnPlusAngle.IsRect = false;
            this.btnPlusAngle.IsUnGroup = false;
            this.btnPlusAngle.Location = new System.Drawing.Point(135, 0);
            this.btnPlusAngle.Name = "btnPlusAngle";
            this.btnPlusAngle.Size = new System.Drawing.Size(69, 40);
            this.btnPlusAngle.TabIndex = 9;
            this.btnPlusAngle.TextColor = System.Drawing.Color.Black;
            this.btnPlusAngle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlusAngle.UseVisualStyleBackColor = false;
            this.btnPlusAngle.Click += new System.EventHandler(this.btnPlusAngle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Góc Xoay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Bộ Loc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckSubPixel);
            this.panel1.Controls.Add(this.ckBitwiseNot);
            this.panel1.Controls.Add(this.ckSIMD);
            this.panel1.Location = new System.Drawing.Point(4, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 53);
            this.panel1.TabIndex = 21;
            // 
            // ckSubPixel
            // 
            this.ckSubPixel.BackColor = System.Drawing.Color.Transparent;
            this.ckSubPixel.BackgroundColor = System.Drawing.Color.Transparent;
            this.ckSubPixel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ckSubPixel.BackgroundImage")));
            this.ckSubPixel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ckSubPixel.BorderColor = System.Drawing.Color.Transparent;
            this.ckSubPixel.BorderRadius = 5;
            this.ckSubPixel.BorderSize = 1;
            this.ckSubPixel.FlatAppearance.BorderSize = 0;
            this.ckSubPixel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckSubPixel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSubPixel.ForeColor = System.Drawing.Color.Black;
            this.ckSubPixel.IsCLick = true;
            this.ckSubPixel.IsNotChange = false;
            this.ckSubPixel.IsRect = false;
            this.ckSubPixel.IsUnGroup = true;
            this.ckSubPixel.Location = new System.Drawing.Point(133, 5);
            this.ckSubPixel.Name = "ckSubPixel";
            this.ckSubPixel.Size = new System.Drawing.Size(115, 40);
            this.ckSubPixel.TabIndex = 4;
            this.ckSubPixel.Text = "SubPixel";
            this.ckSubPixel.TextColor = System.Drawing.Color.Black;
            this.ckSubPixel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ckSubPixel.UseVisualStyleBackColor = false;
            this.ckSubPixel.Click += new System.EventHandler(this.ckSubPixel_Click);
            // 
            // ckBitwiseNot
            // 
            this.ckBitwiseNot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ckBitwiseNot.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ckBitwiseNot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ckBitwiseNot.BackgroundImage")));
            this.ckBitwiseNot.BorderColor = System.Drawing.Color.Silver;
            this.ckBitwiseNot.BorderRadius = 5;
            this.ckBitwiseNot.BorderSize = 1;
            this.ckBitwiseNot.FlatAppearance.BorderSize = 0;
            this.ckBitwiseNot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckBitwiseNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBitwiseNot.ForeColor = System.Drawing.Color.Black;
            this.ckBitwiseNot.IsCLick = false;
            this.ckBitwiseNot.IsNotChange = false;
            this.ckBitwiseNot.IsRect = false;
            this.ckBitwiseNot.IsUnGroup = true;
            this.ckBitwiseNot.Location = new System.Drawing.Point(263, 5);
            this.ckBitwiseNot.Name = "ckBitwiseNot";
            this.ckBitwiseNot.Size = new System.Drawing.Size(115, 40);
            this.ckBitwiseNot.TabIndex = 3;
            this.ckBitwiseNot.Text = "Not";
            this.ckBitwiseNot.TextColor = System.Drawing.Color.Black;
            this.ckBitwiseNot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ckBitwiseNot.UseVisualStyleBackColor = false;
            this.ckBitwiseNot.Click += new System.EventHandler(this.ckBitwiseNot_Click);
            // 
            // ckSIMD
            // 
            this.ckSIMD.BackColor = System.Drawing.Color.Transparent;
            this.ckSIMD.BackgroundColor = System.Drawing.Color.Transparent;
            this.ckSIMD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ckSIMD.BackgroundImage")));
            this.ckSIMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ckSIMD.BorderColor = System.Drawing.Color.Transparent;
            this.ckSIMD.BorderRadius = 5;
            this.ckSIMD.BorderSize = 1;
            this.ckSIMD.FlatAppearance.BorderSize = 0;
            this.ckSIMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckSIMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSIMD.ForeColor = System.Drawing.Color.Black;
            this.ckSIMD.IsCLick = true;
            this.ckSIMD.IsNotChange = false;
            this.ckSIMD.IsRect = false;
            this.ckSIMD.IsUnGroup = true;
            this.ckSIMD.Location = new System.Drawing.Point(3, 5);
            this.ckSIMD.Name = "ckSIMD";
            this.ckSIMD.Size = new System.Drawing.Size(115, 40);
            this.ckSIMD.TabIndex = 2;
            this.ckSIMD.Text = "SIMD";
            this.ckSIMD.TextColor = System.Drawing.Color.Black;
            this.ckSIMD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ckSIMD.UseVisualStyleBackColor = false;
            this.ckSIMD.Click += new System.EventHandler(this.ckSIMD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ngưỡng chồng chéo";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(400, 525);
            this.tabControl2.TabIndex = 17;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.trackScore);
            this.tabPage3.Controls.Add(this.btnCancel);
            this.tabPage3.Controls.Add(this.btnOK);
            this.tabPage3.Controls.Add(this.rjButton2);
            this.tabPage3.Controls.Add(this.rjButton5);
            this.tabPage3.Controls.Add(this.trackBar21);
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.pArea);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(392, 492);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Căn bản";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // trackScore
            // 
            this.trackScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackScore.Location = new System.Drawing.Point(20, 372);
            this.trackScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackScore.Max = 100;
            this.trackScore.Min = 0;
            this.trackScore.Name = "trackScore";
            this.trackScore.Size = new System.Drawing.Size(360, 45);
            this.trackScore.Step = 1;
            this.trackScore.TabIndex = 27;
            this.trackScore.Value = 0;
            this.trackScore.ValueChanged += new System.Action<int>(this.trackScore_ValueChanged);
            this.trackScore.Load += new System.EventHandler(this.trackScore_Load);
            this.trackScore.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackScore_MouseMove);
            this.trackScore.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackScore_MouseUp);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IsCLick = false;
            this.btnCancel.IsNotChange = true;
            this.btnCancel.IsRect = false;
            this.btnCancel.IsUnGroup = false;
            this.btnCancel.Location = new System.Drawing.Point(213, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 40);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BorderColor = System.Drawing.Color.Transparent;
            this.btnOK.BorderRadius = 5;
            this.btnOK.BorderSize = 1;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.IsCLick = true;
            this.btnOK.IsNotChange = true;
            this.btnOK.IsRect = false;
            this.btnOK.IsUnGroup = false;
            this.btnOK.Location = new System.Drawing.Point(6, 446);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 40);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.Black;
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton2.BackgroundImage")));
            this.rjButton2.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderRadius = 5;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.IsCLick = false;
            this.rjButton2.IsNotChange = true;
            this.rjButton2.IsRect = false;
            this.rjButton2.IsUnGroup = false;
            this.rjButton2.Location = new System.Drawing.Point(213, 1910);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(171, 40);
            this.rjButton2.TabIndex = 24;
            this.rjButton2.Text = "Cancel";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton5
            // 
            this.rjButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjButton5.BackColor = System.Drawing.Color.Transparent;
            this.rjButton5.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton5.BackgroundImage")));
            this.rjButton5.BorderColor = System.Drawing.Color.Silver;
            this.rjButton5.BorderRadius = 5;
            this.rjButton5.BorderSize = 1;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.Black;
            this.rjButton5.IsCLick = true;
            this.rjButton5.IsNotChange = true;
            this.rjButton5.IsRect = false;
            this.rjButton5.IsUnGroup = false;
            this.rjButton5.Location = new System.Drawing.Point(6, 1910);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(137, 40);
            this.rjButton5.TabIndex = 23;
            this.rjButton5.Text = "OK";
            this.rjButton5.TextColor = System.Drawing.Color.Black;
            this.rjButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton5.UseVisualStyleBackColor = false;
            // 
            // trackBar21
            // 
            this.trackBar21.Location = new System.Drawing.Point(129, 1934);
            this.trackBar21.Margin = new System.Windows.Forms.Padding(21, 28, 21, 28);
            this.trackBar21.Max = 100;
            this.trackBar21.Min = 0;
            this.trackBar21.Name = "trackBar21";
            this.trackBar21.Size = new System.Drawing.Size(1647, 397);
            this.trackBar21.Step = 0;
            this.trackBar21.TabIndex = 22;
            this.trackBar21.Value = 10;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.btnAutoTrigger);
            this.panel8.Controls.Add(this.numDelay);
            this.panel8.Controls.Add(this.numOK);
            this.panel8.Location = new System.Drawing.Point(20, 254);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(366, 81);
            this.panel8.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(331, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "ms";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(241, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Delay After";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(133, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Count Check";
            // 
            // btnAutoTrigger
            // 
            this.btnAutoTrigger.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutoTrigger.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutoTrigger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoTrigger.BackgroundImage")));
            this.btnAutoTrigger.BorderColor = System.Drawing.Color.Silver;
            this.btnAutoTrigger.BorderRadius = 5;
            this.btnAutoTrigger.BorderSize = 1;
            this.btnAutoTrigger.FlatAppearance.BorderSize = 0;
            this.btnAutoTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoTrigger.ForeColor = System.Drawing.Color.Black;
            this.btnAutoTrigger.IsCLick = false;
            this.btnAutoTrigger.IsNotChange = false;
            this.btnAutoTrigger.IsRect = false;
            this.btnAutoTrigger.IsUnGroup = false;
            this.btnAutoTrigger.Location = new System.Drawing.Point(3, 6);
            this.btnAutoTrigger.Name = "btnAutoTrigger";
            this.btnAutoTrigger.Size = new System.Drawing.Size(124, 63);
            this.btnAutoTrigger.TabIndex = 4;
            this.btnAutoTrigger.Text = "AutoTrigger";
            this.btnAutoTrigger.TextColor = System.Drawing.Color.Black;
            this.btnAutoTrigger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutoTrigger.UseVisualStyleBackColor = false;
            this.btnAutoTrigger.Click += new System.EventHandler(this.btnAutoTrigger_Click);
            // 
            // numDelay
            // 
            this.numDelay.BackColor = System.Drawing.Color.Wheat;
            this.numDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDelay.Location = new System.Drawing.Point(243, 34);
            this.numDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(82, 31);
            this.numDelay.TabIndex = 22;
            this.numDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelay.ValueChanged += new System.EventHandler(this.numDelay_ValueChanged);
            // 
            // numOK
            // 
            this.numOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOK.Location = new System.Drawing.Point(137, 34);
            this.numOK.Name = "numOK";
            this.numOK.Size = new System.Drawing.Size(86, 31);
            this.numOK.TabIndex = 21;
            this.numOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numOK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOK.ValueChanged += new System.EventHandler(this.numOK_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mode Search";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPattern);
            this.panel7.Controls.Add(this.btnOutLine);
            this.panel7.Location = new System.Drawing.Point(20, 200);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(364, 48);
            this.panel7.TabIndex = 19;
            // 
            // btnPattern
            // 
            this.btnPattern.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPattern.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnPattern.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPattern.BackgroundImage")));
            this.btnPattern.BorderColor = System.Drawing.Color.Silver;
            this.btnPattern.BorderRadius = 5;
            this.btnPattern.BorderSize = 1;
            this.btnPattern.FlatAppearance.BorderSize = 0;
            this.btnPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPattern.ForeColor = System.Drawing.Color.Black;
            this.btnPattern.IsCLick = true;
            this.btnPattern.IsNotChange = false;
            this.btnPattern.IsRect = false;
            this.btnPattern.IsUnGroup = false;
            this.btnPattern.Location = new System.Drawing.Point(182, 3);
            this.btnPattern.Name = "btnPattern";
            this.btnPattern.Size = new System.Drawing.Size(175, 40);
            this.btnPattern.TabIndex = 3;
            this.btnPattern.Text = "Pattern";
            this.btnPattern.TextColor = System.Drawing.Color.Black;
            this.btnPattern.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPattern.UseVisualStyleBackColor = false;
            this.btnPattern.Click += new System.EventHandler(this.btnPattern_Click);
            // 
            // btnOutLine
            // 
            this.btnOutLine.BackColor = System.Drawing.Color.Transparent;
            this.btnOutLine.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOutLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOutLine.BackgroundImage")));
            this.btnOutLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutLine.BorderColor = System.Drawing.Color.Transparent;
            this.btnOutLine.BorderRadius = 5;
            this.btnOutLine.BorderSize = 1;
            this.btnOutLine.FlatAppearance.BorderSize = 0;
            this.btnOutLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutLine.ForeColor = System.Drawing.Color.Black;
            this.btnOutLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutLine.IsCLick = false;
            this.btnOutLine.IsNotChange = false;
            this.btnOutLine.IsRect = false;
            this.btnOutLine.IsUnGroup = false;
            this.btnOutLine.Location = new System.Drawing.Point(2, 3);
            this.btnOutLine.Name = "btnOutLine";
            this.btnOutLine.Size = new System.Drawing.Size(176, 40);
            this.btnOutLine.TabIndex = 2;
            this.btnOutLine.Text = "OutLine";
            this.btnOutLine.TextColor = System.Drawing.Color.Black;
            this.btnOutLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOutLine.UseVisualStyleBackColor = false;
            this.btnOutLine.Click += new System.EventHandler(this.btnOutLine_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rjButton3);
            this.panel5.Controls.Add(this.rjButton1);
            this.panel5.Location = new System.Drawing.Point(22, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(363, 53);
            this.panel5.TabIndex = 0;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.SystemColors.Control;
            this.rjButton3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton3.BackgroundImage")));
            this.rjButton3.BorderColor = System.Drawing.Color.Silver;
            this.rjButton3.BorderRadius = 5;
            this.rjButton3.BorderSize = 1;
            this.rjButton3.Enabled = false;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.Black;
            this.rjButton3.Image = global::BeeUi.Properties.Resources.Circle_1;
            this.rjButton3.IsCLick = false;
            this.rjButton3.IsNotChange = false;
            this.rjButton3.IsRect = false;
            this.rjButton3.IsUnGroup = false;
            this.rjButton3.Location = new System.Drawing.Point(184, 4);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(175, 40);
            this.rjButton3.TabIndex = 1;
            this.rjButton3.Text = "Hình tròn";
            this.rjButton3.TextColor = System.Drawing.Color.Black;
            this.rjButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton3.UseVisualStyleBackColor = false;
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
            this.rjButton1.Image = global::BeeUi.Properties.Resources.Rectangle;
            this.rjButton1.IsCLick = true;
            this.rjButton1.IsNotChange = false;
            this.rjButton1.IsRect = false;
            this.rjButton1.IsUnGroup = false;
            this.rjButton1.Location = new System.Drawing.Point(3, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(175, 40);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "Hình Vuông";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search Range";
            // 
            // pArea
            // 
            this.pArea.Controls.Add(this.btnCropArea);
            this.pArea.Controls.Add(this.btnCropRect);
            this.pArea.Location = new System.Drawing.Point(22, 116);
            this.pArea.Name = "pArea";
            this.pArea.Size = new System.Drawing.Size(364, 48);
            this.pArea.TabIndex = 13;
            // 
            // btnCropArea
            // 
            this.btnCropArea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCropArea.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnCropArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCropArea.BackgroundImage")));
            this.btnCropArea.BorderColor = System.Drawing.Color.Silver;
            this.btnCropArea.BorderRadius = 5;
            this.btnCropArea.BorderSize = 1;
            this.btnCropArea.FlatAppearance.BorderSize = 0;
            this.btnCropArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCropArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCropArea.ForeColor = System.Drawing.Color.Black;
            this.btnCropArea.IsCLick = false;
            this.btnCropArea.IsNotChange = false;
            this.btnCropArea.IsRect = false;
            this.btnCropArea.IsUnGroup = false;
            this.btnCropArea.Location = new System.Drawing.Point(179, 3);
            this.btnCropArea.Name = "btnCropArea";
            this.btnCropArea.Size = new System.Drawing.Size(175, 40);
            this.btnCropArea.TabIndex = 3;
            this.btnCropArea.Text = "Partial";
            this.btnCropArea.TextColor = System.Drawing.Color.Black;
            this.btnCropArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCropArea.UseVisualStyleBackColor = false;
            this.btnCropArea.Click += new System.EventHandler(this.btnCropArea_Click);
            // 
            // btnCropRect
            // 
            this.btnCropRect.BackColor = System.Drawing.Color.Transparent;
            this.btnCropRect.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCropRect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCropRect.BackgroundImage")));
            this.btnCropRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCropRect.BorderColor = System.Drawing.Color.Transparent;
            this.btnCropRect.BorderRadius = 5;
            this.btnCropRect.BorderSize = 1;
            this.btnCropRect.FlatAppearance.BorderSize = 0;
            this.btnCropRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCropRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCropRect.ForeColor = System.Drawing.Color.Black;
            this.btnCropRect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCropRect.IsCLick = true;
            this.btnCropRect.IsNotChange = false;
            this.btnCropRect.IsRect = false;
            this.btnCropRect.IsUnGroup = false;
            this.btnCropRect.Location = new System.Drawing.Point(2, 3);
            this.btnCropRect.Name = "btnCropRect";
            this.btnCropRect.Size = new System.Drawing.Size(176, 40);
            this.btnCropRect.TabIndex = 2;
            this.btnCropRect.Text = "Entire";
            this.btnCropRect.TextColor = System.Drawing.Color.Black;
            this.btnCropRect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCropRect.UseVisualStyleBackColor = false;
            this.btnCropRect.Click += new System.EventHandler(this.btnCropRect_Click);
            // 
            // ToolPosition_Adjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl2);
            this.Name = "ToolPosition_Adjustment";
            this.Size = new System.Drawing.Size(400, 525);
            this.Load += new System.EventHandler(this.ToolOutLine_Load);
            this.VisibleChanged += new System.EventHandler(this.ToolOutLine_VisibleChanged);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pCany.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOK)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.ComponentModel.BackgroundWorker threadProcess;
        private System.Windows.Forms.Timer tmClear;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private Common.RJButton btnMask;
        public Common.RJButton btnClear;
        private System.Windows.Forms.Panel pCany;
        private Common.RJButton btnCannyMin;
        private Common.RJButton btnCannyMedium;
        private Common.RJButton btnCannyMax;
        private System.Windows.Forms.Panel panel6;
        private Common.RJButton btnHighSpeed;
        private Common.RJButton btnNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAngle;
        private Common.RJButton btnSubAngle;
        private Common.RJButton btnPlusAngle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Common.RJButton ckSubPixel;
        private Common.RJButton ckBitwiseNot;
        private Common.RJButton ckSIMD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private Common.RJButton rjButton2;
        private Common.RJButton rjButton5;
        private TrackBar2 trackBar21;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.NumericUpDown numOK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private Common.RJButton btnPattern;
        private Common.RJButton btnOutLine;
        private System.Windows.Forms.Panel panel5;
        private Common.RJButton rjButton3;
        private Common.RJButton rjButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pArea;
        private Common.RJButton btnCropArea;
        private Common.RJButton btnCropRect;
        private Common.RJButton btnCancel;
        private Common.RJButton btnOK;
        private TrackBar2 trackMaxOverLap;
        private Common.RJButton btnAutoTrigger;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        public TrackBar2 trackScore;
    }
}
