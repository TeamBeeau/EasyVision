
namespace BeeUi
{
    partial class ScanCCD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanCCD));
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.cbCCD = new System.Windows.Forms.ComboBox();
            this.work = new System.ComponentModel.BackgroundWorker();
            this.cbReSolution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGigE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Controller";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Brown;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(38, 269);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(307, 46);
            this.btnConnect.TabIndex = 33;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnAreaBlack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Camera";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::BeeUi.Properties.Resources.Delete;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(35)))));
            this.btnClose.Location = new System.Drawing.Point(371, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 38;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            this.openFile.Filter = "KeyAcitve|*.bee";
            // 
            // cbCCD
            // 
            this.cbCCD.BackColor = System.Drawing.Color.Wheat;
            this.cbCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCCD.FormattingEnabled = true;
            this.cbCCD.Location = new System.Drawing.Point(152, 173);
            this.cbCCD.Name = "cbCCD";
            this.cbCCD.Size = new System.Drawing.Size(193, 32);
            this.cbCCD.TabIndex = 39;
            // 
            // work
            // 
            this.work.DoWork += new System.ComponentModel.DoWorkEventHandler(this.work_DoWork);
            this.work.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.work_RunWorkerCompleted);
            // 
            // cbReSolution
            // 
            this.cbReSolution.BackColor = System.Drawing.Color.Wheat;
            this.cbReSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReSolution.FormattingEnabled = true;
            this.cbReSolution.Items.AddRange(new object[] {
            "320x240 (0.08 MP)",
            "640x480 (0.3 MP)",
            "800x600 (0,5 MP)",
            "1024x768 (0.8 MP)",
            "1280x720 (1.3 MP)",
            "1600x1200 (1.9 MP)",
            "1920x1080 (2.1 MP)",
            "2048x1536 (3.1 MP)",
            "2592x1944 (5 MP)",
            "3840x2748 (10MP)"});
            this.cbReSolution.Location = new System.Drawing.Point(152, 211);
            this.cbReSolution.Name = "cbReSolution";
            this.cbReSolution.Size = new System.Drawing.Size(193, 32);
            this.cbReSolution.TabIndex = 42;
            this.cbReSolution.SelectedIndexChanged += new System.EventHandler(this.cbReSolution_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Resolution";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::BeeUi.Properties.Resources.Camera;
            this.button1.Location = new System.Drawing.Point(38, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 89);
            this.button1.TabIndex = 43;
            this.button1.Text = "USB";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGigE
            // 
            this.btnGigE.BackColor = System.Drawing.Color.SeaShell;
            this.btnGigE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGigE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGigE.ForeColor = System.Drawing.Color.Black;
            this.btnGigE.Image = global::BeeUi.Properties.Resources.baslerGigE;
            this.btnGigE.Location = new System.Drawing.Point(153, 55);
            this.btnGigE.Name = "btnGigE";
            this.btnGigE.Size = new System.Drawing.Size(109, 89);
            this.btnGigE.TabIndex = 44;
            this.btnGigE.Text = "GigE";
            this.btnGigE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGigE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGigE.UseVisualStyleBackColor = false;
            this.btnGigE.Click += new System.EventHandler(this.btnGigE_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaShell;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::BeeUi.Properties.Resources.baslerGigE;
            this.button3.Location = new System.Drawing.Point(268, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 89);
            this.button3.TabIndex = 45;
            this.button3.Text = "USB";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ScanCCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(392, 344);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGigE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbReSolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCCD);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScanCCD";
            this.Text = "FormActive";
            this.Load += new System.EventHandler(this.ScanCCD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            public System.Windows.Forms.Label label2;
            private System.Windows.Forms.Button btnConnect;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Button btnClose;
            private System.Windows.Forms.OpenFileDialog openFile;
        private System.ComponentModel.BackgroundWorker work;
        private Common.RJButton btnSimulation;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbCCD;
        public System.Windows.Forms.ComboBox cbReSolution;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGigE;
        private System.Windows.Forms.Button button3;
    }
    }