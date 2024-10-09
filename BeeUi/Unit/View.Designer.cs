namespace BeeUi
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.pStatus = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCycleTrigger = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSumNG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSumOK = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckProcess = new System.Windows.Forms.CheckBox();
            this.pView = new System.Windows.Forms.Panel();
            this.imgView = new Cyotek.Windows.Forms.ImageBox();
            this.workUndo = new System.ComponentModel.BackgroundWorker();
            this.tmTool = new System.Windows.Forms.Timer(this.components);
            this.workPlay = new System.ComponentModel.BackgroundWorker();
            this.tmPlay = new System.Windows.Forms.Timer(this.components);
            this.workReadCCD = new System.ComponentModel.BackgroundWorker();
            this.workShow = new System.ComponentModel.BackgroundWorker();
            this.tmTrig = new System.Windows.Forms.Timer(this.components);
            this.workGetColor = new System.ComponentModel.BackgroundWorker();
            this.workInsert = new System.ComponentModel.BackgroundWorker();
            this.tmCheckPort = new System.Windows.Forms.Timer(this.components);
            this.tmCheckCCD = new System.Windows.Forms.Timer(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnFull = new BeeUi.Common.RJButton();
            this.btnZoomIn = new BeeUi.Common.RJButton();
            this.btnZoomOut = new BeeUi.Common.RJButton();
            this.btnImg = new BeeUi.Common.RJButton();
            this.btnShowSetting = new BeeUi.Common.RJButton();
            this.btnLive = new BeeUi.Common.RJButton();
            this.btnRecord = new BeeUi.Common.RJButton();
            this.btnCap = new BeeUi.Common.RJButton();
            this.btnCalib = new BeeUi.Common.RJButton();
            this.btnTest = new BeeUi.Common.RJButton();
            this.btnResetQty = new BeeUi.Common.RJButton();
            this.pStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pView.SuspendLayout();
            this.SuspendLayout();
            // 
            // pStatus
            // 
            this.pStatus.BackColor = System.Drawing.Color.Gray;
            this.pStatus.Controls.Add(this.btnCalib);
            this.pStatus.Controls.Add(this.btnTest);
            this.pStatus.Controls.Add(this.btnResetQty);
            this.pStatus.Controls.Add(this.label5);
            this.pStatus.Controls.Add(this.lbCycleTrigger);
            this.pStatus.Controls.Add(this.label3);
            this.pStatus.Controls.Add(this.lbSumNG);
            this.pStatus.Controls.Add(this.label2);
            this.pStatus.Controls.Add(this.lbSumOK);
            this.pStatus.Controls.Add(this.lbStatus);
            this.pStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pStatus.Location = new System.Drawing.Point(0, 0);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(939, 90);
            this.pStatus.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(225, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = " Cyle Time";
            // 
            // lbCycleTrigger
            // 
            this.lbCycleTrigger.AutoSize = true;
            this.lbCycleTrigger.BackColor = System.Drawing.Color.Transparent;
            this.lbCycleTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCycleTrigger.ForeColor = System.Drawing.Color.White;
            this.lbCycleTrigger.Location = new System.Drawing.Point(316, 51);
            this.lbCycleTrigger.Name = "lbCycleTrigger";
            this.lbCycleTrigger.Size = new System.Drawing.Size(31, 24);
            this.lbCycleTrigger.TabIndex = 7;
            this.lbCycleTrigger.Text = "---";
            this.lbCycleTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(415, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total NG";
            // 
            // lbSumNG
            // 
            this.lbSumNG.AutoSize = true;
            this.lbSumNG.BackColor = System.Drawing.Color.Transparent;
            this.lbSumNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumNG.ForeColor = System.Drawing.Color.Red;
            this.lbSumNG.Location = new System.Drawing.Point(493, 8);
            this.lbSumNG.Name = "lbSumNG";
            this.lbSumNG.Size = new System.Drawing.Size(31, 24);
            this.lbSumNG.TabIndex = 5;
            this.lbSumNG.Text = "---";
            this.lbSumNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(230, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total OK";
            // 
            // lbSumOK
            // 
            this.lbSumOK.AutoSize = true;
            this.lbSumOK.BackColor = System.Drawing.Color.Transparent;
            this.lbSumOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(186)))), ((int)(((byte)(98)))));
            this.lbSumOK.Location = new System.Drawing.Point(315, 8);
            this.lbSumOK.Name = "lbSumOK";
            this.lbSumOK.Size = new System.Drawing.Size(31, 24);
            this.lbSumOK.TabIndex = 3;
            this.lbSumOK.Text = "---";
            this.lbSumOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(186)))), ((int)(((byte)(98)))));
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(0, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(219, 90);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "---";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnFull);
            this.panel1.Controls.Add(this.btnZoomIn);
            this.panel1.Controls.Add(this.btnZoomOut);
            this.panel1.Controls.Add(this.btnImg);
            this.panel1.Controls.Add(this.ckProcess);
            this.panel1.Controls.Add(this.btnShowSetting);
            this.panel1.Controls.Add(this.btnLive);
            this.panel1.Controls.Add(this.btnRecord);
            this.panel1.Controls.Add(this.btnCap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 45);
            this.panel1.TabIndex = 5;
            // 
            // ckProcess
            // 
            this.ckProcess.AutoSize = true;
            this.ckProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckProcess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckProcess.Location = new System.Drawing.Point(234, 11);
            this.ckProcess.Name = "ckProcess";
            this.ckProcess.Size = new System.Drawing.Size(129, 24);
            this.ckProcess.TabIndex = 13;
            this.ckProcess.Text = "Show Process";
            this.ckProcess.UseVisualStyleBackColor = true;
            this.ckProcess.CheckedChanged += new System.EventHandler(this.ckProcess_CheckedChanged);
            // 
            // pView
            // 
            this.pView.AutoScroll = true;
            this.pView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pView.Controls.Add(this.imgView);
            this.pView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pView.Location = new System.Drawing.Point(0, 135);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(939, 412);
            this.pView.TabIndex = 6;
            this.pView.MouseLeave += new System.EventHandler(this.pView_MouseLeave);
            this.pView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pView_MouseMove);
            // 
            // imgView
            // 
            this.imgView.AutoCenter = false;
            this.imgView.AutoPan = false;
            this.imgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgView.Location = new System.Drawing.Point(0, 0);
            this.imgView.Name = "imgView";
            this.imgView.PanMode = Cyotek.Windows.Forms.ImageBoxPanMode.Middle;
            this.imgView.Size = new System.Drawing.Size(939, 412);
            this.imgView.TabIndex = 1;
            this.imgView.Paint += new System.Windows.Forms.PaintEventHandler(this.imgView_Paint);
            this.imgView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgView_MouseDown);
            this.imgView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgView_MouseMove);
            this.imgView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgView_MouseUp);
            // 
            // workUndo
            // 
            this.workUndo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workUndo_DoWork);
            this.workUndo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workUndo_RunWorkerCompleted);
            // 
            // tmTool
            // 
            this.tmTool.Interval = 1000;
            this.tmTool.Tick += new System.EventHandler(this.tmTool_Tick);
            // 
            // workPlay
            // 
            this.workPlay.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workPlay_DoWork);
            this.workPlay.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workPlay_RunWorkerCompleted);
            // 
            // tmPlay
            // 
            this.tmPlay.Interval = 200;
            this.tmPlay.Tick += new System.EventHandler(this.tmPlay_Tick);
            // 
            // workReadCCD
            // 
            this.workReadCCD.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workReadCCD_DoWork);
            this.workReadCCD.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workReadCCD_RunWorkerCompleted);
            // 
            // workShow
            // 
            this.workShow.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workShow_DoWork);
            this.workShow.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workShow_RunWorkerCompleted);
            // 
            // tmTrig
            // 
            this.tmTrig.Interval = 1000;
            this.tmTrig.Tick += new System.EventHandler(this.tmTrig_Tick);
            // 
            // workGetColor
            // 
            this.workGetColor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workGetColor_DoWork);
            this.workGetColor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workGetColor_RunWorkerCompleted);
            // 
            // workInsert
            // 
            this.workInsert.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workInsert_DoWork);
            // 
            // tmCheckPort
            // 
            this.tmCheckPort.Interval = 2000;
            this.tmCheckPort.Tick += new System.EventHandler(this.tmCheckPort_Tick);
            // 
            // tmCheckCCD
            // 
            this.tmCheckCCD.Interval = 1000;
            this.tmCheckCCD.Tick += new System.EventHandler(this.tmCheckCCD_Tick);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // btnFull
            // 
            this.btnFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFull.BackColor = System.Drawing.Color.White;
            this.btnFull.BackgroundColor = System.Drawing.Color.White;
            this.btnFull.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFull.BackgroundImage")));
            this.btnFull.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFull.BorderRadius = 5;
            this.btnFull.BorderSize = 1;
            this.btnFull.FlatAppearance.BorderSize = 0;
            this.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFull.ForeColor = System.Drawing.Color.Black;
            this.btnFull.Image = global::BeeUi.Properties.Resources.Full_Screen;
            this.btnFull.IsCLick = false;
            this.btnFull.IsNotChange = true;
            this.btnFull.IsRect = false;
            this.btnFull.IsUnGroup = true;
            this.btnFull.Location = new System.Drawing.Point(619, 6);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(39, 36);
            this.btnFull.TabIndex = 17;
            this.btnFull.TextColor = System.Drawing.Color.Black;
            this.btnFull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFull.UseVisualStyleBackColor = false;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.BackColor = System.Drawing.Color.White;
            this.btnZoomIn.BackgroundColor = System.Drawing.Color.White;
            this.btnZoomIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.BackgroundImage")));
            this.btnZoomIn.BorderColor = System.Drawing.Color.DarkGray;
            this.btnZoomIn.BorderRadius = 5;
            this.btnZoomIn.BorderSize = 1;
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.ForeColor = System.Drawing.Color.Black;
            this.btnZoomIn.Image = global::BeeUi.Properties.Resources.Zoom_In;
            this.btnZoomIn.IsCLick = false;
            this.btnZoomIn.IsNotChange = true;
            this.btnZoomIn.IsRect = false;
            this.btnZoomIn.IsUnGroup = true;
            this.btnZoomIn.Location = new System.Drawing.Point(664, 5);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(39, 36);
            this.btnZoomIn.TabIndex = 16;
            this.btnZoomIn.TextColor = System.Drawing.Color.Black;
            this.btnZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomOut.BackColor = System.Drawing.Color.White;
            this.btnZoomOut.BackgroundColor = System.Drawing.Color.White;
            this.btnZoomOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.BackgroundImage")));
            this.btnZoomOut.BorderColor = System.Drawing.Color.DarkGray;
            this.btnZoomOut.BorderRadius = 5;
            this.btnZoomOut.BorderSize = 1;
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.ForeColor = System.Drawing.Color.Black;
            this.btnZoomOut.Image = global::BeeUi.Properties.Resources.Zoom_Out;
            this.btnZoomOut.IsCLick = false;
            this.btnZoomOut.IsNotChange = true;
            this.btnZoomOut.IsRect = false;
            this.btnZoomOut.IsUnGroup = true;
            this.btnZoomOut.Location = new System.Drawing.Point(714, 5);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(39, 36);
            this.btnZoomOut.TabIndex = 15;
            this.btnZoomOut.TextColor = System.Drawing.Color.Black;
            this.btnZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnImg
            // 
            this.btnImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImg.BackColor = System.Drawing.Color.White;
            this.btnImg.BackgroundColor = System.Drawing.Color.White;
            this.btnImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImg.BackgroundImage")));
            this.btnImg.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImg.BorderRadius = 5;
            this.btnImg.BorderSize = 1;
            this.btnImg.FlatAppearance.BorderSize = 0;
            this.btnImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.ForeColor = System.Drawing.Color.Black;
            this.btnImg.Image = global::BeeUi.Properties.Resources.Folder;
            this.btnImg.IsCLick = false;
            this.btnImg.IsNotChange = true;
            this.btnImg.IsRect = false;
            this.btnImg.IsUnGroup = true;
            this.btnImg.Location = new System.Drawing.Point(763, 5);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(39, 36);
            this.btnImg.TabIndex = 14;
            this.btnImg.TextColor = System.Drawing.Color.Black;
            this.btnImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImg.UseVisualStyleBackColor = false;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnShowSetting
            // 
            this.btnShowSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSetting.BackColor = System.Drawing.Color.White;
            this.btnShowSetting.BackgroundColor = System.Drawing.Color.White;
            this.btnShowSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowSetting.BackgroundImage")));
            this.btnShowSetting.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowSetting.BorderRadius = 5;
            this.btnShowSetting.BorderSize = 1;
            this.btnShowSetting.FlatAppearance.BorderSize = 0;
            this.btnShowSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSetting.ForeColor = System.Drawing.Color.Black;
            this.btnShowSetting.Image = global::BeeUi.Properties.Resources.setting;
            this.btnShowSetting.IsCLick = false;
            this.btnShowSetting.IsNotChange = true;
            this.btnShowSetting.IsRect = false;
            this.btnShowSetting.IsUnGroup = true;
            this.btnShowSetting.Location = new System.Drawing.Point(897, 4);
            this.btnShowSetting.Name = "btnShowSetting";
            this.btnShowSetting.Size = new System.Drawing.Size(39, 36);
            this.btnShowSetting.TabIndex = 12;
            this.btnShowSetting.TextColor = System.Drawing.Color.Black;
            this.btnShowSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowSetting.UseVisualStyleBackColor = false;
            this.btnShowSetting.Click += new System.EventHandler(this.btnShowSetting_Click);
            // 
            // btnLive
            // 
            this.btnLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLive.BackColor = System.Drawing.Color.White;
            this.btnLive.BackgroundColor = System.Drawing.Color.White;
            this.btnLive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLive.BackgroundImage")));
            this.btnLive.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLive.BorderRadius = 5;
            this.btnLive.BorderSize = 1;
            this.btnLive.FlatAppearance.BorderSize = 0;
            this.btnLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLive.ForeColor = System.Drawing.Color.Black;
            this.btnLive.Image = ((System.Drawing.Image)(resources.GetObject("btnLive.Image")));
            this.btnLive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLive.IsCLick = false;
            this.btnLive.IsNotChange = false;
            this.btnLive.IsRect = false;
            this.btnLive.IsUnGroup = true;
            this.btnLive.Location = new System.Drawing.Point(808, 3);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(84, 39);
            this.btnLive.TabIndex = 11;
            this.btnLive.Tag = "";
            this.btnLive.Text = "Live";
            this.btnLive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLive.TextColor = System.Drawing.Color.Black;
            this.btnLive.UseVisualStyleBackColor = false;
            this.btnLive.Click += new System.EventHandler(this.btnSer_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(73)))));
            this.btnRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(73)))));
            this.btnRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecord.BackgroundImage")));
            this.btnRecord.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecord.BorderRadius = 5;
            this.btnRecord.BorderSize = 1;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRecord.ForeColor = System.Drawing.Color.Black;
            this.btnRecord.Image = global::BeeUi.Properties.Resources.Play_2;
            this.btnRecord.IsCLick = false;
            this.btnRecord.IsNotChange = false;
            this.btnRecord.IsRect = false;
            this.btnRecord.IsUnGroup = true;
            this.btnRecord.Location = new System.Drawing.Point(102, 4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(116, 39);
            this.btnRecord.TabIndex = 10;
            this.btnRecord.Text = "Continuous";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecord.TextColor = System.Drawing.Color.Black;
            this.btnRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnCap
            // 
            this.btnCap.BackColor = System.Drawing.Color.White;
            this.btnCap.BackgroundColor = System.Drawing.Color.White;
            this.btnCap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCap.BackgroundImage")));
            this.btnCap.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCap.BorderRadius = 5;
            this.btnCap.BorderSize = 1;
            this.btnCap.FlatAppearance.BorderSize = 0;
            this.btnCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCap.ForeColor = System.Drawing.Color.Black;
            this.btnCap.Image = global::BeeUi.Properties.Resources.Natural_User_Interface_2;
            this.btnCap.IsCLick = false;
            this.btnCap.IsNotChange = false;
            this.btnCap.IsRect = false;
            this.btnCap.IsUnGroup = true;
            this.btnCap.Location = new System.Drawing.Point(1, 4);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(95, 39);
            this.btnCap.TabIndex = 9;
            this.btnCap.Text = "Trigger";
            this.btnCap.TextColor = System.Drawing.Color.Black;
            this.btnCap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCap.UseVisualStyleBackColor = false;
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // btnCalib
            // 
            this.btnCalib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalib.BackColor = System.Drawing.Color.White;
            this.btnCalib.BackgroundColor = System.Drawing.Color.White;
            this.btnCalib.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalib.BackgroundImage")));
            this.btnCalib.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalib.BorderRadius = 5;
            this.btnCalib.BorderSize = 1;
            this.btnCalib.Enabled = false;
            this.btnCalib.FlatAppearance.BorderSize = 0;
            this.btnCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalib.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalib.ForeColor = System.Drawing.Color.Black;
            this.btnCalib.Image = global::BeeUi.Properties.Resources.Brightness_1;
            this.btnCalib.IsCLick = false;
            this.btnCalib.IsNotChange = false;
            this.btnCalib.IsRect = false;
            this.btnCalib.IsUnGroup = true;
            this.btnCalib.Location = new System.Drawing.Point(806, 47);
            this.btnCalib.Name = "btnCalib";
            this.btnCalib.Size = new System.Drawing.Size(130, 37);
            this.btnCalib.TabIndex = 15;
            this.btnCalib.Text = "Calib Briness";
            this.btnCalib.TextColor = System.Drawing.Color.Black;
            this.btnCalib.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalib.UseVisualStyleBackColor = false;
            this.btnCalib.Visible = false;
            this.btnCalib.Click += new System.EventHandler(this.btnCalib_Click);
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.BackColor = System.Drawing.Color.White;
            this.btnTest.BackgroundColor = System.Drawing.Color.White;
            this.btnTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTest.BackgroundImage")));
            this.btnTest.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTest.BorderRadius = 5;
            this.btnTest.BorderSize = 1;
            this.btnTest.Enabled = false;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.Black;
            this.btnTest.Image = global::BeeUi.Properties.Resources.Test_Passed;
            this.btnTest.IsCLick = false;
            this.btnTest.IsNotChange = false;
            this.btnTest.IsRect = false;
            this.btnTest.IsUnGroup = true;
            this.btnTest.Location = new System.Drawing.Point(806, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(130, 37);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "Mode Test";
            this.btnTest.TextColor = System.Drawing.Color.Black;
            this.btnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnResetQty
            // 
            this.btnResetQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(73)))));
            this.btnResetQty.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(73)))));
            this.btnResetQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetQty.BackgroundImage")));
            this.btnResetQty.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetQty.BorderRadius = 5;
            this.btnResetQty.BorderSize = 1;
            this.btnResetQty.FlatAppearance.BorderSize = 0;
            this.btnResetQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetQty.ForeColor = System.Drawing.Color.Black;
            this.btnResetQty.IsCLick = false;
            this.btnResetQty.IsNotChange = true;
            this.btnResetQty.IsRect = false;
            this.btnResetQty.IsUnGroup = true;
            this.btnResetQty.Location = new System.Drawing.Point(419, 44);
            this.btnResetQty.Name = "btnResetQty";
            this.btnResetQty.Size = new System.Drawing.Size(81, 40);
            this.btnResetQty.TabIndex = 11;
            this.btnResetQty.Text = "Reset Qty";
            this.btnResetQty.TextColor = System.Drawing.Color.Black;
            this.btnResetQty.UseVisualStyleBackColor = false;
            this.btnResetQty.Click += new System.EventHandler(this.btnResetQty_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pStatus);
            this.Name = "View";
            this.Size = new System.Drawing.Size(939, 547);
            this.Load += new System.EventHandler(this.View_Load);
            this.MouseHover += new System.EventHandler(this.View_MouseHover);
            this.pStatus.ResumeLayout(false);
            this.pStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pView;
        private System.ComponentModel.BackgroundWorker workUndo;
        private System.Windows.Forms.Timer tmTool;
        private System.ComponentModel.BackgroundWorker workPlay;
        private System.Windows.Forms.Timer tmPlay;
        private System.ComponentModel.BackgroundWorker workShow;
        private System.Windows.Forms.Timer tmTrig;
        private System.ComponentModel.BackgroundWorker workGetColor;
        public Common.RJButton btnCap;
        public Common.RJButton btnRecord;
        public System.Windows.Forms.Panel pStatus;
        private System.Windows.Forms.Label lbSumOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSumNG;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbCycleTrigger;
        public System.Windows.Forms.Label lbStatus;
        public Common.RJButton btnResetQty;
        private System.Windows.Forms.CheckBox ckProcess;
        public Common.RJButton btnLive;
        public Common.RJButton btnShowSetting;
        private System.ComponentModel.BackgroundWorker workInsert;
        public System.Windows.Forms.Timer tmCheckPort;
        public Common.RJButton btnTest;
        public Common.RJButton btnCalib;
        public System.Windows.Forms.Timer tmCheckCCD;
        public Common.RJButton btnImg;
        private System.Windows.Forms.OpenFileDialog openFile;
        public System.ComponentModel.BackgroundWorker workReadCCD;
        public Common.RJButton btnZoomIn;
        public Common.RJButton btnZoomOut;
        public Cyotek.Windows.Forms.ImageBox imgView;
        public Common.RJButton btnFull;
    }
}
