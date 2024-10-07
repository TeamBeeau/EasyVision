﻿
namespace BeeUi.Tool
{
    partial class SettingStep2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingStep2));
            this.workRead = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new BeeUi.Common.RJButton();
            this.btnNextStep = new BeeUi.Common.RJButton();
            this.btnCapCamera = new BeeUi.Common.RJButton();
            this.btnLoadImge = new BeeUi.Common.RJButton();
            this.tmNotPress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // workRead
            // 
            this.workRead.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workRead_DoWork);
            this.workRead.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workRead_RunWorkerCompleted);
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
            this.btnCancel.Size = new System.Drawing.Size(171, 40);
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
            // btnCapCamera
            // 
            this.btnCapCamera.BackColor = System.Drawing.Color.White;
            this.btnCapCamera.BackgroundColor = System.Drawing.Color.White;
            this.btnCapCamera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapCamera.BackgroundImage")));
            this.btnCapCamera.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapCamera.BorderRadius = 10;
            this.btnCapCamera.BorderSize = 1;
            this.btnCapCamera.FlatAppearance.BorderSize = 0;
            this.btnCapCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapCamera.ForeColor = System.Drawing.Color.Black;
            this.btnCapCamera.Image = global::BeeUi.Properties.Resources.Camera;
            this.btnCapCamera.IsCLick = false;
            this.btnCapCamera.IsNotChange = false;
            this.btnCapCamera.IsRect = false;
            this.btnCapCamera.IsUnGroup = true;
            this.btnCapCamera.Location = new System.Drawing.Point(42, 162);
            this.btnCapCamera.Name = "btnCapCamera";
            this.btnCapCamera.Size = new System.Drawing.Size(292, 62);
            this.btnCapCamera.TabIndex = 10;
            this.btnCapCamera.Text = "Đăng Ký ảnh  từ Camera Chụp\r\n";
            this.btnCapCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapCamera.TextColor = System.Drawing.Color.Black;
            this.btnCapCamera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapCamera.UseVisualStyleBackColor = false;
            this.btnCapCamera.Click += new System.EventHandler(this.btnCapCamera_Click);
            // 
            // btnLoadImge
            // 
            this.btnLoadImge.BackColor = System.Drawing.Color.White;
            this.btnLoadImge.BackgroundColor = System.Drawing.Color.White;
            this.btnLoadImge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadImge.BackgroundImage")));
            this.btnLoadImge.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadImge.BorderRadius = 10;
            this.btnLoadImge.BorderSize = 1;
            this.btnLoadImge.FlatAppearance.BorderSize = 0;
            this.btnLoadImge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImge.ForeColor = System.Drawing.Color.Black;
            this.btnLoadImge.Image = global::BeeUi.Properties.Resources.Folder;
            this.btnLoadImge.IsCLick = false;
            this.btnLoadImge.IsNotChange = true;
            this.btnLoadImge.IsRect = false;
            this.btnLoadImge.IsUnGroup = true;
            this.btnLoadImge.Location = new System.Drawing.Point(42, 79);
            this.btnLoadImge.Name = "btnLoadImge";
            this.btnLoadImge.Size = new System.Drawing.Size(292, 62);
            this.btnLoadImge.TabIndex = 9;
            this.btnLoadImge.Text = "Đăng Ký ảnh từ file Ảnh";
            this.btnLoadImge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadImge.TextColor = System.Drawing.Color.Black;
            this.btnLoadImge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadImge.UseVisualStyleBackColor = false;
            this.btnLoadImge.Click += new System.EventHandler(this.btnLoadImge_Click);
            // 
            // tmNotPress
            // 
            this.tmNotPress.Interval = 200;
            this.tmNotPress.Tick += new System.EventHandler(this.tmNotPress_Tick);
            // 
            // SettingStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.btnCapCamera);
            this.Controls.Add(this.btnLoadImge);
            this.Name = "SettingStep2";
            this.Size = new System.Drawing.Size(371, 560);
            this.Load += new System.EventHandler(this.SettingStep2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Common.RJButton btnLoadImge;
        private Common.RJButton btnCapCamera;
        private Common.RJButton btnCancel;
        private Common.RJButton btnNextStep;
        private System.ComponentModel.BackgroundWorker workRead;
        private System.Windows.Forms.Timer tmNotPress;
    }
}
