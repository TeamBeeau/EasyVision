namespace BeeUi
{
    partial class EditTool
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
            this.StatusBar = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripCamera = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbFrameRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtRecept = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbLicence = new System.Windows.Forms.Label();
            this.pEdit = new System.Windows.Forms.Panel();
            this.pEditTool = new System.Windows.Forms.Panel();
            this.pName = new System.Windows.Forms.Panel();
            this.lbNameStep = new System.Windows.Forms.Label();
            this.lbNumStep = new System.Windows.Forms.Label();
            this.lbTool = new System.Windows.Forms.Label();
            this.iconTool = new System.Windows.Forms.PictureBox();
            this.pView = new System.Windows.Forms.Panel();
            this.StatusBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pEdit.SuspendLayout();
            this.pName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTool)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StatusBar.Controls.Add(this.statusStrip1);
            this.StatusBar.Controls.Add(this.lbLicence);
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.Location = new System.Drawing.Point(0, 681);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1024, 25);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCamera,
            this.lbFrameRate,
            this.toolStripPort,
            this.txtRecept});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(629, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripCamera
            // 
            this.toolStripCamera.Image = global::BeeUi.Properties.Resources.CameraNotConnect;
            this.toolStripCamera.Name = "toolStripCamera";
            this.toolStripCamera.Size = new System.Drawing.Size(48, 20);
            this.toolStripCamera.Text = "0 fps";
            // 
            // lbFrameRate
            // 
            this.lbFrameRate.Name = "lbFrameRate";
            this.lbFrameRate.Size = new System.Drawing.Size(34, 20);
            this.lbFrameRate.Text = "0 Fps";
            // 
            // toolStripPort
            // 
            this.toolStripPort.Image = global::BeeUi.Properties.Resources.PortNotConnect;
            this.toolStripPort.Name = "toolStripPort";
            this.toolStripPort.Size = new System.Drawing.Size(129, 20);
            this.toolStripPort.Text = "Port Not Connected";
            // 
            // txtRecept
            // 
            this.txtRecept.Name = "txtRecept";
            this.txtRecept.Size = new System.Drawing.Size(22, 20);
            this.txtRecept.Text = "---";
            // 
            // lbLicence
            // 
            this.lbLicence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLicence.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicence.Location = new System.Drawing.Point(629, 0);
            this.lbLicence.Name = "lbLicence";
            this.lbLicence.Size = new System.Drawing.Size(395, 25);
            this.lbLicence.TabIndex = 1;
            this.lbLicence.Text = "Licence :";
            this.lbLicence.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pEdit
            // 
            this.pEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pEdit.Controls.Add(this.pEditTool);
            this.pEdit.Controls.Add(this.pName);
            this.pEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pEdit.Location = new System.Drawing.Point(629, 0);
            this.pEdit.Name = "pEdit";
            this.pEdit.Size = new System.Drawing.Size(395, 681);
            this.pEdit.TabIndex = 14;
            // 
            // pEditTool
            // 
            this.pEditTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEditTool.Location = new System.Drawing.Point(0, 95);
            this.pEditTool.Name = "pEditTool";
            this.pEditTool.Size = new System.Drawing.Size(395, 586);
            this.pEditTool.TabIndex = 1;
            // 
            // pName
            // 
            this.pName.Controls.Add(this.lbNameStep);
            this.pName.Controls.Add(this.lbNumStep);
            this.pName.Controls.Add(this.lbTool);
            this.pName.Controls.Add(this.iconTool);
            this.pName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pName.Location = new System.Drawing.Point(0, 0);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(395, 95);
            this.pName.TabIndex = 0;
            // 
            // lbNameStep
            // 
            this.lbNameStep.AutoSize = true;
            this.lbNameStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameStep.Location = new System.Drawing.Point(81, 6);
            this.lbNameStep.Name = "lbNameStep";
            this.lbNameStep.Size = new System.Drawing.Size(171, 31);
            this.lbNameStep.TabIndex = 3;
            this.lbNameStep.Text = "Tool Setting";
            // 
            // lbNumStep
            // 
            this.lbNumStep.AutoSize = true;
            this.lbNumStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumStep.Location = new System.Drawing.Point(13, 16);
            this.lbNumStep.Name = "lbNumStep";
            this.lbNumStep.Size = new System.Drawing.Size(62, 20);
            this.lbNumStep.TabIndex = 2;
            this.lbNumStep.Text = "Step 3";
            // 
            // lbTool
            // 
            this.lbTool.AutoSize = true;
            this.lbTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTool.Location = new System.Drawing.Point(47, 59);
            this.lbTool.Name = "lbTool";
            this.lbTool.Size = new System.Drawing.Size(72, 20);
            this.lbTool.TabIndex = 1;
            this.lbTool.Text = "OutLine";
            // 
            // iconTool
            // 
            this.iconTool.BackgroundImage = global::BeeUi.Properties.Resources.Add;
            this.iconTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconTool.Location = new System.Drawing.Point(17, 55);
            this.iconTool.Name = "iconTool";
            this.iconTool.Size = new System.Drawing.Size(24, 24);
            this.iconTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconTool.TabIndex = 0;
            this.iconTool.TabStop = false;
            // 
            // pView
            // 
            this.pView.BackColor = System.Drawing.Color.White;
            this.pView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pView.Location = new System.Drawing.Point(0, 0);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(629, 681);
            this.pView.TabIndex = 16;
            // 
            // EditTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pView);
            this.Controls.Add(this.pEdit);
            this.Controls.Add(this.StatusBar);
            this.Name = "EditTool";
            this.Size = new System.Drawing.Size(1024, 706);
            this.Load += new System.EventHandler(this.EditTool_Load);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pEdit.ResumeLayout(false);
            this.pName.ResumeLayout(false);
            this.pName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTool)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StatusBar;
        public System.Windows.Forms.Panel pEdit;
        public System.Windows.Forms.Panel pEditTool;
        public System.Windows.Forms.Label lbNameStep;
        public System.Windows.Forms.Label lbNumStep;
        public System.Windows.Forms.Label lbTool;
        public System.Windows.Forms.PictureBox iconTool;
        public System.Windows.Forms.Panel pView;
        public Common.Header header1;
        public System.Windows.Forms.Label lbLicence;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripCamera;
        public System.Windows.Forms.ToolStripStatusLabel toolStripPort;
        public System.Windows.Forms.ToolStripStatusLabel txtRecept;
        public System.Windows.Forms.Panel pName;
        public System.Windows.Forms.ToolStripStatusLabel lbFrameRate;
    }
}
