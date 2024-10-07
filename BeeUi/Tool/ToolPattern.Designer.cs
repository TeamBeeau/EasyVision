namespace BeeUi.Tool
{
    partial class ToolPattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolPattern));
            this.pArea = new System.Windows.Forms.Panel();
            this.btnClear = new BeeUi.Common.RJButton();
            this.btnCropRect = new BeeUi.Common.RJButton();
            this.btnCropArea = new BeeUi.Common.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.threadProcess = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.trackNumObject = new BeeUi.TrackBar2();
            this.label9 = new System.Windows.Forms.Label();
            this.trackScore = new BeeUi.TrackBar2();
            this.rjButton3 = new BeeUi.Common.RJButton();
            this.rjButton1 = new BeeUi.Common.RJButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new BeeUi.Common.RJButton();
            this.pCany = new System.Windows.Forms.Panel();
            this.btnAreaBlack = new BeeUi.Common.RJButton();
            this.btnAreaWhite = new BeeUi.Common.RJButton();
            this.btnOK = new BeeUi.Common.RJButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
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
            this.lbOverLap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackMaxOverLap = new System.Windows.Forms.TrackBar();
            this.pArea.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pCany.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackMaxOverLap)).BeginInit();
            this.SuspendLayout();
            // 
            // pArea
            // 
            this.pArea.Controls.Add(this.btnClear);
            this.pArea.Controls.Add(this.btnCropRect);
            this.pArea.Controls.Add(this.btnCropArea);
            this.pArea.Location = new System.Drawing.Point(3, 108);
            this.pArea.Name = "pArea";
            this.pArea.Size = new System.Drawing.Size(389, 48);
            this.pArea.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.BorderRadius = 3;
            this.btnClear.BorderSize = 1;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.IsCLick = false;
            this.btnClear.IsNotChange = false;
            this.btnClear.IsRect = false;
            this.btnClear.IsUnGroup = false;
            this.btnClear.Location = new System.Drawing.Point(263, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Vùng mặt nạ";
            this.btnClear.TextColor = System.Drawing.Color.Black;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnCropRect.IsCLick = true;
            this.btnCropRect.IsNotChange = false;
            this.btnCropRect.IsRect = false;
            this.btnCropRect.IsUnGroup = false;
            this.btnCropRect.Location = new System.Drawing.Point(3, 4);
            this.btnCropRect.Name = "btnCropRect";
            this.btnCropRect.Size = new System.Drawing.Size(123, 40);
            this.btnCropRect.TabIndex = 2;
            this.btnCropRect.Text = "Vùng lấy mẫu";
            this.btnCropRect.TextColor = System.Drawing.Color.Black;
            this.btnCropRect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCropRect.UseVisualStyleBackColor = false;
            this.btnCropRect.Click += new System.EventHandler(this.btnCropRect_Click);
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
            this.btnCropArea.Location = new System.Drawing.Point(133, 4);
            this.btnCropArea.Name = "btnCropArea";
            this.btnCropArea.Size = new System.Drawing.Size(123, 40);
            this.btnCropArea.TabIndex = 3;
            this.btnCropArea.Text = "Vùng Kiểm tra";
            this.btnCropArea.TextColor = System.Drawing.Color.Black;
            this.btnCropArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCropArea.UseVisualStyleBackColor = false;
            this.btnCropArea.Click += new System.EventHandler(this.btnCropArea_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Score";
            // 
            // threadProcess
            // 
            this.threadProcess.WorkerReportsProgress = true;
            this.threadProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadProcess_DoWork);
            this.threadProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.threadProcess_RunWorkerCompleted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn biên dạng ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chọn vùng";
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
            this.tabPage3.Controls.Add(this.trackNumObject);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.trackScore);
            this.tabPage3.Controls.Add(this.rjButton3);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.rjButton1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.pArea);
            this.tabPage3.Controls.Add(this.btnCancel);
            this.tabPage3.Controls.Add(this.pCany);
            this.tabPage3.Controls.Add(this.btnOK);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(392, 492);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Căn bản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // trackNumObject
            // 
            this.trackNumObject.ColorTrack = System.Drawing.Color.Gray;
            this.trackNumObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackNumObject.Location = new System.Drawing.Point(155, 260);
            this.trackNumObject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackNumObject.Max = 50;
            this.trackNumObject.Min = 1;
            this.trackNumObject.Name = "trackNumObject";
            this.trackNumObject.Size = new System.Drawing.Size(228, 45);
            this.trackNumObject.Step = 1;
            this.trackNumObject.TabIndex = 30;
            this.trackNumObject.Value = 1;
            this.trackNumObject.ValueScore = 0;
            this.trackNumObject.ValueChanged += new System.Action<int>(this.trackNumObject_ValueChanged);
            this.trackNumObject.Load += new System.EventHandler(this.trackBar21_Load);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Maximum Pattern";
            // 
            // trackScore
            // 
            this.trackScore.ColorTrack = System.Drawing.Color.Gray;
            this.trackScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackScore.Location = new System.Drawing.Point(23, 345);
            this.trackScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackScore.Max = 100;
            this.trackScore.Min = 0;
            this.trackScore.Name = "trackScore";
            this.trackScore.Size = new System.Drawing.Size(360, 45);
            this.trackScore.Step = 1;
            this.trackScore.TabIndex = 28;
            this.trackScore.Value = 0;
            this.trackScore.ValueScore = 0;
            this.trackScore.ValueChanged += new System.Action<int>(this.trackScore_ValueChanged);
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
            this.rjButton3.Location = new System.Drawing.Point(201, 34);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(188, 40);
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
            this.rjButton1.Location = new System.Drawing.Point(6, 34);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(188, 40);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "Hình Vuông";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Chọn vùng Mẫu";
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
            this.btnCancel.Location = new System.Drawing.Point(215, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pCany
            // 
            this.pCany.Controls.Add(this.btnAreaBlack);
            this.pCany.Controls.Add(this.btnAreaWhite);
            this.pCany.Enabled = false;
            this.pCany.Location = new System.Drawing.Point(6, 192);
            this.pCany.Name = "pCany";
            this.pCany.Size = new System.Drawing.Size(386, 50);
            this.pCany.TabIndex = 12;
            // 
            // btnAreaBlack
            // 
            this.btnAreaBlack.BackColor = System.Drawing.Color.Transparent;
            this.btnAreaBlack.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAreaBlack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAreaBlack.BackgroundImage")));
            this.btnAreaBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAreaBlack.BorderColor = System.Drawing.Color.Transparent;
            this.btnAreaBlack.BorderRadius = 5;
            this.btnAreaBlack.BorderSize = 1;
            this.btnAreaBlack.FlatAppearance.BorderSize = 0;
            this.btnAreaBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaBlack.ForeColor = System.Drawing.Color.Black;
            this.btnAreaBlack.IsCLick = true;
            this.btnAreaBlack.IsNotChange = false;
            this.btnAreaBlack.IsRect = false;
            this.btnAreaBlack.IsUnGroup = false;
            this.btnAreaBlack.Location = new System.Drawing.Point(3, 5);
            this.btnAreaBlack.Name = "btnAreaBlack";
            this.btnAreaBlack.Size = new System.Drawing.Size(185, 40);
            this.btnAreaBlack.TabIndex = 7;
            this.btnAreaBlack.Text = "Vùng Tối";
            this.btnAreaBlack.TextColor = System.Drawing.Color.Black;
            this.btnAreaBlack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAreaBlack.UseVisualStyleBackColor = false;
            this.btnAreaBlack.Click += new System.EventHandler(this.btnAreaBlack_Click);
            // 
            // btnAreaWhite
            // 
            this.btnAreaWhite.BackColor = System.Drawing.SystemColors.Control;
            this.btnAreaWhite.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnAreaWhite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAreaWhite.BackgroundImage")));
            this.btnAreaWhite.BorderColor = System.Drawing.Color.Silver;
            this.btnAreaWhite.BorderRadius = 5;
            this.btnAreaWhite.BorderSize = 1;
            this.btnAreaWhite.FlatAppearance.BorderSize = 0;
            this.btnAreaWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaWhite.ForeColor = System.Drawing.Color.Black;
            this.btnAreaWhite.IsCLick = false;
            this.btnAreaWhite.IsNotChange = false;
            this.btnAreaWhite.IsRect = false;
            this.btnAreaWhite.IsUnGroup = false;
            this.btnAreaWhite.Location = new System.Drawing.Point(195, 5);
            this.btnAreaWhite.Name = "btnAreaWhite";
            this.btnAreaWhite.Size = new System.Drawing.Size(188, 40);
            this.btnAreaWhite.TabIndex = 9;
            this.btnAreaWhite.Text = "Vùng sáng";
            this.btnAreaWhite.TextColor = System.Drawing.Color.Black;
            this.btnAreaWhite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAreaWhite.UseVisualStyleBackColor = false;
            this.btnAreaWhite.Click += new System.EventHandler(this.btnAreaWhite_Click);
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
            this.btnOK.Location = new System.Drawing.Point(8, 446);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 40);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.Black;
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel6);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.lbOverLap);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.trackMaxOverLap);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(392, 492);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Chức năng mở rộng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnHighSpeed);
            this.panel6.Controls.Add(this.btnNormal);
            this.panel6.Location = new System.Drawing.Point(18, 295);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(364, 48);
            this.panel6.TabIndex = 29;
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
            this.label1.Location = new System.Drawing.Point(17, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 28;
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
            this.txtAngle.Text = "0";
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lbOverLap
            // 
            this.lbOverLap.AutoSize = true;
            this.lbOverLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverLap.Location = new System.Drawing.Point(341, 90);
            this.lbOverLap.Name = "lbOverLap";
            this.lbOverLap.Size = new System.Drawing.Size(41, 20);
            this.lbOverLap.TabIndex = 19;
            this.lbOverLap.Text = "50%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ngưỡng chồng chéo";
            // 
            // trackMaxOverLap
            // 
            this.trackMaxOverLap.AutoSize = false;
            this.trackMaxOverLap.BackColor = System.Drawing.Color.White;
            this.trackMaxOverLap.Location = new System.Drawing.Point(3, 132);
            this.trackMaxOverLap.Maximum = 80;
            this.trackMaxOverLap.Name = "trackMaxOverLap";
            this.trackMaxOverLap.Size = new System.Drawing.Size(379, 31);
            this.trackMaxOverLap.SmallChange = 5;
            this.trackMaxOverLap.TabIndex = 17;
            this.trackMaxOverLap.TickFrequency = 5;
            this.trackMaxOverLap.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackMaxOverLap.Value = 50;
            this.trackMaxOverLap.Scroll += new System.EventHandler(this.trackMaxOverLap_Scroll);
            this.trackMaxOverLap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackMaxOverLap_MouseUp);
            // 
            // ToolPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl2);
            this.Name = "ToolPattern";
            this.Size = new System.Drawing.Size(400, 525);
            this.Load += new System.EventHandler(this.ToolOutLine_Load);
            this.VisibleChanged += new System.EventHandler(this.ToolOutLine_VisibleChanged);
            this.pArea.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pCany.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackMaxOverLap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Common.RJButton btnCropArea;
        private Common.RJButton btnCropRect;
        private Common.RJButton btnCancel;
        private System.Windows.Forms.Panel pArea;
        private System.Windows.Forms.Label label4;
        private Common.RJButton rjButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Common.RJButton rjButton1;
        private Common.RJButton btnOK;
        private System.Windows.Forms.Label lbOverLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackMaxOverLap;
        private System.Windows.Forms.Label label3;
        private Common.RJButton ckSIMD;
        private Common.RJButton ckBitwiseNot;
        private Common.RJButton ckSubPixel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label8;
        private Common.RJButton btnPlusAngle;
        private Common.RJButton btnSubAngle;
        private System.Windows.Forms.Panel panel3;
        private Common.RJButton btnClear;
        private System.Windows.Forms.Panel panel1;
        public System.ComponentModel.BackgroundWorker threadProcess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pCany;
        private Common.RJButton btnAreaBlack;
        private Common.RJButton btnAreaWhite;
        private System.Windows.Forms.Panel panel6;
        private Common.RJButton btnHighSpeed;
        private Common.RJButton btnNormal;
        private System.Windows.Forms.Label label1;
        public TrackBar2 trackScore;
        public TrackBar2 trackNumObject;
        private System.Windows.Forms.Label label9;
    }
}
