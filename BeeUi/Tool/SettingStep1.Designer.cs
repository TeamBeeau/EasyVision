
namespace BeeUi.Tool
{
    partial class SettingStep1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingStep1));
            this.workRead = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pCany = new System.Windows.Forms.Panel();
            this.btnCannyMin = new BeeUi.Common.RJButton();
            this.btnCannyMedium = new BeeUi.Common.RJButton();
            this.btnCannyMax = new BeeUi.Common.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pArea = new System.Windows.Forms.Panel();
            this.rjButton2 = new BeeUi.Common.RJButton();
            this.btnCropRect = new BeeUi.Common.RJButton();
            this.btnSetting = new BeeUi.Common.RJButton();
            this.btnShowArea = new BeeUi.Common.RJButton();
            this.btnShowCenter = new BeeUi.Common.RJButton();
            this.btnShowGrid = new BeeUi.Common.RJButton();
            this.btnLive = new BeeUi.Common.RJButton();
            this.btnCancel = new BeeUi.Common.RJButton();
            this.btnNextStep = new BeeUi.Common.RJButton();
            this.rjButton1 = new BeeUi.Common.RJButton();
            this.trackExposure = new BeeUi.TrackBar2();
            this.btnAutoExposure = new BeeUi.Common.RJButton();
            this.p = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pCany.SuspendLayout();
            this.pArea.SuspendLayout();
            this.p.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // workRead
            // 
            this.workRead.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workRead_DoWork);
            this.workRead.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workRead_RunWorkerCompleted);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(40, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(161, 40);
            this.numericUpDown1.TabIndex = 42;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "ms";
            // 
            // pCany
            // 
            this.pCany.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pCany.Controls.Add(this.btnCannyMin);
            this.pCany.Controls.Add(this.btnCannyMedium);
            this.pCany.Controls.Add(this.btnCannyMax);
            this.pCany.Location = new System.Drawing.Point(16, 158);
            this.pCany.Name = "pCany";
            this.pCany.Size = new System.Drawing.Size(321, 50);
            this.pCany.TabIndex = 47;
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
            this.btnCannyMin.Location = new System.Drawing.Point(3, 3);
            this.btnCannyMin.Name = "btnCannyMin";
            this.btnCannyMin.Size = new System.Drawing.Size(100, 42);
            this.btnCannyMin.TabIndex = 7;
            this.btnCannyMin.Text = "BackLight";
            this.btnCannyMin.TextColor = System.Drawing.Color.Black;
            this.btnCannyMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCannyMin.UseVisualStyleBackColor = false;
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
            this.btnCannyMedium.Location = new System.Drawing.Point(107, 3);
            this.btnCannyMedium.Name = "btnCannyMedium";
            this.btnCannyMedium.Size = new System.Drawing.Size(100, 42);
            this.btnCannyMedium.TabIndex = 8;
            this.btnCannyMedium.Text = "TopLight";
            this.btnCannyMedium.TextColor = System.Drawing.Color.Black;
            this.btnCannyMedium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCannyMedium.UseVisualStyleBackColor = false;
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
            this.btnCannyMax.Location = new System.Drawing.Point(216, 3);
            this.btnCannyMax.Name = "btnCannyMax";
            this.btnCannyMax.Size = new System.Drawing.Size(100, 42);
            this.btnCannyMax.TabIndex = 9;
            this.btnCannyMax.Text = "Both";
            this.btnCannyMax.TextColor = System.Drawing.Color.Black;
            this.btnCannyMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCannyMax.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "ms";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(15, 134);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(111, 20);
            this.name.TabIndex = 49;
            this.name.Text = "Source Light";
            // 
            // pArea
            // 
            this.pArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pArea.Controls.Add(this.rjButton2);
            this.pArea.Controls.Add(this.btnCropRect);
            this.pArea.Location = new System.Drawing.Point(14, 217);
            this.pArea.Name = "pArea";
            this.pArea.Size = new System.Drawing.Size(323, 56);
            this.pArea.TabIndex = 48;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjButton2.BackgroundImage")));
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjButton2.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderRadius = 5;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Image = global::BeeUi.Properties.Resources.Brightness_1;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.IsCLick = false;
            this.rjButton2.IsNotChange = true;
            this.rjButton2.IsRect = true;
            this.rjButton2.IsUnGroup = true;
            this.rjButton2.Location = new System.Drawing.Point(6, 5);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(101, 46);
            this.rjButton2.TabIndex = 50;
            this.rjButton2.Text = "Light";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton2.UseVisualStyleBackColor = false;
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
            this.btnCropRect.Location = new System.Drawing.Point(113, 5);
            this.btnCropRect.Name = "btnCropRect";
            this.btnCropRect.Size = new System.Drawing.Size(207, 46);
            this.btnCropRect.TabIndex = 2;
            this.btnCropRect.Text = "ON Light";
            this.btnCropRect.TextColor = System.Drawing.Color.Black;
            this.btnCropRect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCropRect.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.BorderColor = System.Drawing.Color.Silver;
            this.btnSetting.BorderRadius = 5;
            this.btnSetting.BorderSize = 1;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Image = global::BeeUi.Properties.Resources.setting;
            this.btnSetting.IsCLick = false;
            this.btnSetting.IsNotChange = true;
            this.btnSetting.IsRect = false;
            this.btnSetting.IsUnGroup = true;
            this.btnSetting.Location = new System.Drawing.Point(277, 5);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(61, 55);
            this.btnSetting.TabIndex = 39;
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetting.TextColor = System.Drawing.Color.Black;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnShowArea
            // 
            this.btnShowArea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowArea.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowArea.BackgroundImage")));
            this.btnShowArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowArea.BorderColor = System.Drawing.Color.Silver;
            this.btnShowArea.BorderRadius = 5;
            this.btnShowArea.BorderSize = 1;
            this.btnShowArea.FlatAppearance.BorderSize = 0;
            this.btnShowArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowArea.ForeColor = System.Drawing.Color.Black;
            this.btnShowArea.Image = global::BeeUi.Properties.Resources.Rectangle;
            this.btnShowArea.IsCLick = false;
            this.btnShowArea.IsNotChange = false;
            this.btnShowArea.IsRect = false;
            this.btnShowArea.IsUnGroup = true;
            this.btnShowArea.Location = new System.Drawing.Point(233, 68);
            this.btnShowArea.Name = "btnShowArea";
            this.btnShowArea.Size = new System.Drawing.Size(105, 37);
            this.btnShowArea.TabIndex = 38;
            this.btnShowArea.Text = "Area";
            this.btnShowArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowArea.TextColor = System.Drawing.Color.Black;
            this.btnShowArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowArea.UseVisualStyleBackColor = false;
            this.btnShowArea.Click += new System.EventHandler(this.btnShowArea_Click);
            // 
            // btnShowCenter
            // 
            this.btnShowCenter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowCenter.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowCenter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowCenter.BackgroundImage")));
            this.btnShowCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowCenter.BorderColor = System.Drawing.Color.Silver;
            this.btnShowCenter.BorderRadius = 5;
            this.btnShowCenter.BorderSize = 1;
            this.btnShowCenter.FlatAppearance.BorderSize = 0;
            this.btnShowCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCenter.ForeColor = System.Drawing.Color.Black;
            this.btnShowCenter.Image = global::BeeUi.Properties.Resources.Center_of_Gravity_1;
            this.btnShowCenter.IsCLick = false;
            this.btnShowCenter.IsNotChange = false;
            this.btnShowCenter.IsRect = false;
            this.btnShowCenter.IsUnGroup = true;
            this.btnShowCenter.Location = new System.Drawing.Point(126, 68);
            this.btnShowCenter.Name = "btnShowCenter";
            this.btnShowCenter.Size = new System.Drawing.Size(105, 37);
            this.btnShowCenter.TabIndex = 37;
            this.btnShowCenter.Text = "Center";
            this.btnShowCenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowCenter.TextColor = System.Drawing.Color.Black;
            this.btnShowCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowCenter.UseVisualStyleBackColor = false;
            this.btnShowCenter.Click += new System.EventHandler(this.btnShowCenter_Click);
            // 
            // btnShowGrid
            // 
            this.btnShowGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowGrid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowGrid.BackgroundImage")));
            this.btnShowGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowGrid.BorderColor = System.Drawing.Color.Silver;
            this.btnShowGrid.BorderRadius = 5;
            this.btnShowGrid.BorderSize = 1;
            this.btnShowGrid.FlatAppearance.BorderSize = 0;
            this.btnShowGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowGrid.ForeColor = System.Drawing.Color.Black;
            this.btnShowGrid.Image = global::BeeUi.Properties.Resources.Prison_1;
            this.btnShowGrid.IsCLick = false;
            this.btnShowGrid.IsNotChange = false;
            this.btnShowGrid.IsRect = false;
            this.btnShowGrid.IsUnGroup = true;
            this.btnShowGrid.Location = new System.Drawing.Point(13, 68);
            this.btnShowGrid.Name = "btnShowGrid";
            this.btnShowGrid.Size = new System.Drawing.Size(105, 37);
            this.btnShowGrid.TabIndex = 36;
            this.btnShowGrid.Text = "Grid";
            this.btnShowGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowGrid.TextColor = System.Drawing.Color.Black;
            this.btnShowGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowGrid.UseVisualStyleBackColor = false;
            this.btnShowGrid.Click += new System.EventHandler(this.btnShowGrid_Click);
            // 
            // btnLive
            // 
            this.btnLive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLive.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnLive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLive.BackgroundImage")));
            this.btnLive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLive.BorderColor = System.Drawing.Color.Silver;
            this.btnLive.BorderRadius = 5;
            this.btnLive.BorderSize = 1;
            this.btnLive.FlatAppearance.BorderSize = 0;
            this.btnLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLive.ForeColor = System.Drawing.Color.Black;
            this.btnLive.Image = global::BeeUi.Properties.Resources.Live_Video_On;
            this.btnLive.IsCLick = false;
            this.btnLive.IsNotChange = false;
            this.btnLive.IsRect = false;
            this.btnLive.IsUnGroup = true;
            this.btnLive.Location = new System.Drawing.Point(13, 5);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(258, 55);
            this.btnLive.TabIndex = 35;
            this.btnLive.Text = "Live";
            this.btnLive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLive.TextColor = System.Drawing.Color.Black;
            this.btnLive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLive.UseVisualStyleBackColor = false;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(197, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextStep.BackColor = System.Drawing.Color.Transparent;
            this.btnNextStep.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNextStep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextStep.BackgroundImage")));
            this.btnNextStep.BorderColor = System.Drawing.Color.Transparent;
            this.btnNextStep.BorderRadius = 5;
            this.btnNextStep.BorderSize = 1;
            this.btnNextStep.Enabled = false;
            this.btnNextStep.FlatAppearance.BorderSize = 0;
            this.btnNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextStep.ForeColor = System.Drawing.Color.Black;
            this.btnNextStep.IsCLick = true;
            this.btnNextStep.IsNotChange = true;
            this.btnNextStep.IsRect = false;
            this.btnNextStep.IsUnGroup = false;
            this.btnNextStep.Location = new System.Drawing.Point(16, 501);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(175, 40);
            this.btnNextStep.TabIndex = 12;
            this.btnNextStep.Text = "NextStep";
            this.btnNextStep.TextColor = System.Drawing.Color.Black;
            this.btnNextStep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNextStep.UseVisualStyleBackColor = false;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
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
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Image = global::BeeUi.Properties.Resources.Brightness_1;
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.IsCLick = false;
            this.rjButton1.IsNotChange = true;
            this.rjButton1.IsRect = true;
            this.rjButton1.IsUnGroup = true;
            this.rjButton1.Location = new System.Drawing.Point(15, 76);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(103, 50);
            this.rjButton1.TabIndex = 45;
            this.rjButton1.Text = "   Briness Delay";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // trackExposure
            // 
            this.trackExposure.ColorTrack = System.Drawing.Color.Gray;
            this.trackExposure.Location = new System.Drawing.Point(66, 2);
            this.trackExposure.Max = 20000;
            this.trackExposure.Min = 1;
            this.trackExposure.Name = "trackExposure";
            this.trackExposure.Size = new System.Drawing.Size(161, 46);
            this.trackExposure.Step = 1;
            this.trackExposure.TabIndex = 44;
            this.trackExposure.Value = 1;
            this.trackExposure.ValueScore = 0;
            this.trackExposure.ValueChanged += new System.Action<int>(this.trackExposure_ValueChanged);
            this.trackExposure.Load += new System.EventHandler(this.trackExposure_Load);
            // 
            // btnAutoExposure
            // 
            this.btnAutoExposure.BackColor = System.Drawing.Color.Transparent;
            this.btnAutoExposure.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAutoExposure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoExposure.BackgroundImage")));
            this.btnAutoExposure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutoExposure.BorderColor = System.Drawing.Color.Transparent;
            this.btnAutoExposure.BorderRadius = 5;
            this.btnAutoExposure.BorderSize = 1;
            this.btnAutoExposure.FlatAppearance.BorderSize = 0;
            this.btnAutoExposure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoExposure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoExposure.ForeColor = System.Drawing.Color.Black;
            this.btnAutoExposure.Image = global::BeeUi.Properties.Resources.Aperture;
            this.btnAutoExposure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoExposure.IsCLick = false;
            this.btnAutoExposure.IsNotChange = true;
            this.btnAutoExposure.IsRect = true;
            this.btnAutoExposure.IsUnGroup = true;
            this.btnAutoExposure.Location = new System.Drawing.Point(16, 10);
            this.btnAutoExposure.Name = "btnAutoExposure";
            this.btnAutoExposure.Size = new System.Drawing.Size(103, 50);
            this.btnAutoExposure.TabIndex = 43;
            this.btnAutoExposure.Text = "Exposure";
            this.btnAutoExposure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutoExposure.TextColor = System.Drawing.Color.Black;
            this.btnAutoExposure.UseVisualStyleBackColor = false;
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.DarkGray;
            this.p.Controls.Add(this.name);
            this.p.Controls.Add(this.pArea);
            this.p.Controls.Add(this.btnAutoExposure);
            this.p.Controls.Add(this.pCany);
            this.p.Controls.Add(this.rjButton1);
            this.p.Controls.Add(this.panel1);
            this.p.Controls.Add(this.panel2);
            this.p.Location = new System.Drawing.Point(12, 150);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(354, 284);
            this.p.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(92, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 48);
            this.panel1.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.trackExposure);
            this.panel2.Location = new System.Drawing.Point(66, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 47);
            this.panel2.TabIndex = 51;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.DarkGray;
            this.p2.Controls.Add(this.btnShowGrid);
            this.p2.Controls.Add(this.btnSetting);
            this.p2.Controls.Add(this.btnLive);
            this.p2.Controls.Add(this.btnShowArea);
            this.p2.Controls.Add(this.btnShowCenter);
            this.p2.Location = new System.Drawing.Point(12, 17);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(354, 118);
            this.p2.TabIndex = 49;
            // 
            // SettingStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.p2);
            this.Name = "SettingStep1";
            this.Size = new System.Drawing.Size(371, 560);
            this.Load += new System.EventHandler(this.SettingStep2_Load);
            this.VisibleChanged += new System.EventHandler(this.SettingStep1_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pCany.ResumeLayout(false);
            this.pArea.ResumeLayout(false);
            this.p.ResumeLayout(false);
            this.p.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.p2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Common.RJButton btnCancel;
        private System.ComponentModel.BackgroundWorker workRead;
        public Common.RJButton btnNextStep;
        public Common.RJButton btnLive;
        public Common.RJButton btnShowGrid;
        public Common.RJButton btnShowCenter;
        public Common.RJButton btnShowArea;
        public Common.RJButton btnSetting;
        private Common.RJButton btnAutoExposure;
        private Common.RJButton rjButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pCany;
        private Common.RJButton btnCannyMin;
        private Common.RJButton btnCannyMedium;
        private Common.RJButton btnCannyMax;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel pArea;
        private Common.RJButton btnCropRect;
        private Common.RJButton rjButton2;
        private System.Windows.Forms.Panel p;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel p2;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public TrackBar2 trackExposure;
    }
}
