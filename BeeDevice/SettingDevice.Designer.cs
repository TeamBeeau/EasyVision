
namespace BeeDevice
{
    partial class SettingDevice
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
            this.CheckAutoExp = new System.Windows.Forms.CheckBox();
            this.trackExposure = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackExposure)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckAutoExp
            // 
            this.CheckAutoExp.AutoSize = true;
            this.CheckAutoExp.Location = new System.Drawing.Point(25, 30);
            this.CheckAutoExp.Name = "CheckAutoExp";
            this.CheckAutoExp.Size = new System.Drawing.Size(95, 17);
            this.CheckAutoExp.TabIndex = 0;
            this.CheckAutoExp.Text = "Auto Exposure";
            this.CheckAutoExp.UseVisualStyleBackColor = true;
            this.CheckAutoExp.CheckedChanged += new System.EventHandler(this.CheckAutoExp_CheckedChanged);
            // 
            // trackExposure
            // 
            this.trackExposure.Location = new System.Drawing.Point(25, 53);
            this.trackExposure.Maximum = 255;
            this.trackExposure.Minimum = 1;
            this.trackExposure.Name = "trackExposure";
            this.trackExposure.Size = new System.Drawing.Size(340, 45);
            this.trackExposure.TabIndex = 1;
            this.trackExposure.Value = 1;
            this.trackExposure.Scroll += new System.EventHandler(this.trackExposure_Scroll);
            // 
            // SettingDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 139);
            this.Controls.Add(this.trackExposure);
            this.Controls.Add(this.CheckAutoExp);
            this.Name = "SettingDevice";
            this.Text = "SettingDevice";
            this.Load += new System.EventHandler(this.SettingDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackExposure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckAutoExp;
        private System.Windows.Forms.TrackBar trackExposure;
    }
}