namespace BeeUi.Common
{
    partial class Header
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            this.workConnect = new System.ComponentModel.BackgroundWorker();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.pProgram = new System.Windows.Forms.Panel();
            this.btnAdd = new BeeUi.Common.RJButton();
            this.btnUser = new BeeUi.Common.RJButton();
            this.btnReport = new BeeUi.Common.RJButton();
            this.btnSave = new BeeUi.Common.RJButton();
            this.btnDelect = new BeeUi.Common.RJButton();
            this.btnSaveAs = new BeeUi.Common.RJButton();
            this.btnIO = new BeeUi.Common.RJButton();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.workLoadProgram = new System.ComponentModel.BackgroundWorker();
            this.pProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // workConnect
            // 
            this.workConnect.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workConnect_DoWork);
            this.workConnect.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workConnect_RunWorkerCompleted);
            // 
            // cbProgram
            // 
            this.cbProgram.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(14, 28);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(208, 32);
            this.cbProgram.TabIndex = 0;
            this.cbProgram.SelectedIndexChanged += new System.EventHandler(this.cbProgram_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chọn Model";
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "*.prog";
            this.saveFile.Filter = "Program | *.prog";
            this.saveFile.InitialDirectory = "Program";
            this.saveFile.Title = "Save As";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Add          Save        Copy       Delete";
            // 
            // btnMode
            // 
            this.btnMode.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.btnMode.Location = new System.Drawing.Point(0, 0);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(210, 65);
            this.btnMode.TabIndex = 18;
            this.btnMode.Text = "RUN";
            this.btnMode.UseVisualStyleBackColor = false;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // pProgram
            // 
            this.pProgram.Controls.Add(this.label2);
            this.pProgram.Controls.Add(this.label1);
            this.pProgram.Controls.Add(this.btnAdd);
            this.pProgram.Controls.Add(this.cbProgram);
            this.pProgram.Controls.Add(this.btnUser);
            this.pProgram.Controls.Add(this.btnReport);
            this.pProgram.Controls.Add(this.btnSave);
            this.pProgram.Controls.Add(this.btnDelect);
            this.pProgram.Controls.Add(this.btnSaveAs);
            this.pProgram.Controls.Add(this.btnIO);
            this.pProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pProgram.Location = new System.Drawing.Point(210, 0);
            this.pProgram.Name = "pProgram";
            this.pProgram.Size = new System.Drawing.Size(814, 65);
            this.pProgram.TabIndex = 23;
            this.pProgram.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::BeeUi.Properties.Resources.Add;
            this.btnAdd.IsCLick = false;
            this.btnAdd.IsNotChange = true;
            this.btnAdd.IsRect = false;
            this.btnAdd.IsUnGroup = true;
            this.btnAdd.Location = new System.Drawing.Point(238, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.BackgroundColor = System.Drawing.Color.White;
            this.btnUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUser.BackgroundImage")));
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUser.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.BorderRadius = 5;
            this.btnUser.BorderSize = 1;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Image = global::BeeUi.Properties.Resources.Customer;
            this.btnUser.IsCLick = false;
            this.btnUser.IsNotChange = true;
            this.btnUser.IsRect = false;
            this.btnUser.IsUnGroup = true;
            this.btnUser.Location = new System.Drawing.Point(728, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(77, 59);
            this.btnUser.TabIndex = 21;
            this.btnUser.Text = "Account";
            this.btnUser.TextColor = System.Drawing.Color.Black;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackColor = System.Drawing.Color.White;
            this.btnReport.BackgroundColor = System.Drawing.Color.White;
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.BorderRadius = 5;
            this.btnReport.BorderSize = 1;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.IsCLick = false;
            this.btnReport.IsNotChange = true;
            this.btnReport.IsRect = false;
            this.btnReport.IsUnGroup = true;
            this.btnReport.Location = new System.Drawing.Point(645, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(77, 59);
            this.btnReport.TabIndex = 19;
            this.btnReport.Text = "Report";
            this.btnReport.TextColor = System.Drawing.Color.Black;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderSize = 1;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::BeeUi.Properties.Resources.Save;
            this.btnSave.IsCLick = false;
            this.btnSave.IsNotChange = true;
            this.btnSave.IsRect = false;
            this.btnSave.IsUnGroup = true;
            this.btnSave.Location = new System.Drawing.Point(287, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 32);
            this.btnSave.TabIndex = 14;
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelect
            // 
            this.btnDelect.BackColor = System.Drawing.Color.White;
            this.btnDelect.BackgroundColor = System.Drawing.Color.White;
            this.btnDelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelect.BackgroundImage")));
            this.btnDelect.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelect.BorderRadius = 5;
            this.btnDelect.BorderSize = 1;
            this.btnDelect.FlatAppearance.BorderSize = 0;
            this.btnDelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelect.ForeColor = System.Drawing.Color.Black;
            this.btnDelect.Image = global::BeeUi.Properties.Resources.BID_ICON_DELETE_E_32BIT;
            this.btnDelect.IsCLick = false;
            this.btnDelect.IsNotChange = true;
            this.btnDelect.IsRect = false;
            this.btnDelect.IsUnGroup = true;
            this.btnDelect.Location = new System.Drawing.Point(385, 11);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(38, 32);
            this.btnDelect.TabIndex = 13;
            this.btnDelect.TextColor = System.Drawing.Color.Black;
            this.btnDelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelect.UseVisualStyleBackColor = false;
            this.btnDelect.Click += new System.EventHandler(this.btnDelect_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.BackColor = System.Drawing.Color.White;
            this.btnSaveAs.BackgroundColor = System.Drawing.Color.White;
            this.btnSaveAs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.BackgroundImage")));
            this.btnSaveAs.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAs.BorderRadius = 5;
            this.btnSaveAs.BorderSize = 1;
            this.btnSaveAs.FlatAppearance.BorderSize = 0;
            this.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAs.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAs.Image = global::BeeUi.Properties.Resources.Copy;
            this.btnSaveAs.IsCLick = false;
            this.btnSaveAs.IsNotChange = true;
            this.btnSaveAs.IsRect = false;
            this.btnSaveAs.IsUnGroup = true;
            this.btnSaveAs.Location = new System.Drawing.Point(336, 11);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(38, 32);
            this.btnSaveAs.TabIndex = 15;
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAs.TextColor = System.Drawing.Color.Black;
            this.btnSaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveAs.UseVisualStyleBackColor = false;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnIO
            // 
            this.btnIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIO.BackColor = System.Drawing.Color.White;
            this.btnIO.BackgroundColor = System.Drawing.Color.White;
            this.btnIO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIO.BackgroundImage")));
            this.btnIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIO.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIO.BorderRadius = 5;
            this.btnIO.BorderSize = 1;
            this.btnIO.FlatAppearance.BorderSize = 0;
            this.btnIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIO.ForeColor = System.Drawing.Color.Black;
            this.btnIO.Image = ((System.Drawing.Image)(resources.GetObject("btnIO.Image")));
            this.btnIO.IsCLick = false;
            this.btnIO.IsNotChange = true;
            this.btnIO.IsRect = false;
            this.btnIO.IsUnGroup = true;
            this.btnIO.Location = new System.Drawing.Point(562, 3);
            this.btnIO.Name = "btnIO";
            this.btnIO.Size = new System.Drawing.Size(77, 59);
            this.btnIO.TabIndex = 20;
            this.btnIO.Text = "Settings";
            this.btnIO.TextColor = System.Drawing.Color.Black;
            this.btnIO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIO.UseVisualStyleBackColor = false;
            this.btnIO.Click += new System.EventHandler(this.btnIO_Click);
            // 
            // SerialPort
            // 
            this.SerialPort.BaudRate = 115200;
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Visible = false;
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pProgram);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.textBox1);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1024, 65);
            this.Load += new System.EventHandler(this.Header_Load);
            this.pProgram.ResumeLayout(false);
            this.pProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker workConnect;
        private RJButton btnDelect;
        private RJButton btnAdd;
        private RJButton btnSaveAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private RJButton btnReport;
        private RJButton btnIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pProgram;
        public System.Windows.Forms.Button btnMode;
        public System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.TextBox textBox1;
        public RJButton btnSave;
        public RJButton btnUser;
        private System.ComponentModel.BackgroundWorker workLoadProgram;
        public System.Windows.Forms.ComboBox cbProgram;
    }
}
