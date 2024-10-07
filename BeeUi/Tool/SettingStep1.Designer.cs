
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
            this.btnSetting = new BeeUi.Common.RJButton();
            this.btnShowArea = new BeeUi.Common.RJButton();
            this.btnShowCenter = new BeeUi.Common.RJButton();
            this.btnShowGrid = new BeeUi.Common.RJButton();
            this.btnLive = new BeeUi.Common.RJButton();
            this.btnEqubtnalize = new BeeUi.Common.RJButton();
            this.btnCancel = new BeeUi.Common.RJButton();
            this.btnNextStep = new BeeUi.Common.RJButton();
            this.btnCalib = new BeeUi.Common.RJButton();
            this.SuspendLayout();
            // 
            // workRead
            // 
            this.workRead.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workRead_DoWork);
            this.workRead.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workRead_RunWorkerCompleted);
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
            this.btnSetting.Location = new System.Drawing.Point(286, 13);
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
            this.btnShowArea.Location = new System.Drawing.Point(242, 83);
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
            this.btnShowCenter.Location = new System.Drawing.Point(135, 83);
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
            this.btnShowGrid.Location = new System.Drawing.Point(29, 83);
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
            this.btnLive.Location = new System.Drawing.Point(29, 13);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(251, 55);
            this.btnLive.TabIndex = 35;
            this.btnLive.Text = "Live";
            this.btnLive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLive.TextColor = System.Drawing.Color.Black;
            this.btnLive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLive.UseVisualStyleBackColor = false;
            this.btnLive.Click += new System.EventHandler(this.btnLive_Click);
            // 
            // btnEqubtnalize
            // 
            this.btnEqubtnalize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEqubtnalize.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnEqubtnalize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEqubtnalize.BackgroundImage")));
            this.btnEqubtnalize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEqubtnalize.BorderColor = System.Drawing.Color.Silver;
            this.btnEqubtnalize.BorderRadius = 5;
            this.btnEqubtnalize.BorderSize = 1;
            this.btnEqubtnalize.Enabled = false;
            this.btnEqubtnalize.FlatAppearance.BorderSize = 0;
            this.btnEqubtnalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqubtnalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqubtnalize.ForeColor = System.Drawing.Color.Black;
            this.btnEqubtnalize.Image = global::BeeUi.Properties.Resources.Image;
            this.btnEqubtnalize.IsCLick = false;
            this.btnEqubtnalize.IsNotChange = false;
            this.btnEqubtnalize.IsRect = false;
            this.btnEqubtnalize.IsUnGroup = true;
            this.btnEqubtnalize.Location = new System.Drawing.Point(29, 139);
            this.btnEqubtnalize.Name = "btnEqubtnalize";
            this.btnEqubtnalize.Size = new System.Drawing.Size(318, 59);
            this.btnEqubtnalize.TabIndex = 33;
            this.btnEqubtnalize.Text = "Equalize Image";
            this.btnEqubtnalize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEqubtnalize.TextColor = System.Drawing.Color.Black;
            this.btnEqubtnalize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEqubtnalize.UseVisualStyleBackColor = false;
            this.btnEqubtnalize.Click += new System.EventHandler(this.btnEqualize_Click);
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
            // btnCalib
            // 
            this.btnCalib.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalib.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalib.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalib.BackgroundImage")));
            this.btnCalib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalib.BorderColor = System.Drawing.Color.Silver;
            this.btnCalib.BorderRadius = 5;
            this.btnCalib.BorderSize = 1;
            this.btnCalib.Enabled = false;
            this.btnCalib.FlatAppearance.BorderSize = 0;
            this.btnCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalib.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalib.ForeColor = System.Drawing.Color.Black;
            this.btnCalib.Image = global::BeeUi.Properties.Resources.Brightness;
            this.btnCalib.IsCLick = false;
            this.btnCalib.IsNotChange = false;
            this.btnCalib.IsRect = false;
            this.btnCalib.IsUnGroup = true;
            this.btnCalib.Location = new System.Drawing.Point(29, 204);
            this.btnCalib.Name = "btnCalib";
            this.btnCalib.Size = new System.Drawing.Size(318, 59);
            this.btnCalib.TabIndex = 40;
            this.btnCalib.Text = "Calib Briness";
            this.btnCalib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalib.TextColor = System.Drawing.Color.Black;
            this.btnCalib.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalib.UseVisualStyleBackColor = false;
            this.btnCalib.Click += new System.EventHandler(this.btnCalib_Click);
            // 
            // SettingStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCalib);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnShowArea);
            this.Controls.Add(this.btnShowCenter);
            this.Controls.Add(this.btnShowGrid);
            this.Controls.Add(this.btnLive);
            this.Controls.Add(this.btnEqubtnalize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNextStep);
            this.Name = "SettingStep1";
            this.Size = new System.Drawing.Size(371, 560);
            this.Load += new System.EventHandler(this.SettingStep2_Load);
            this.VisibleChanged += new System.EventHandler(this.SettingStep1_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private Common.RJButton btnCancel;
        private System.ComponentModel.BackgroundWorker workRead;
        public Common.RJButton btnNextStep;
        public Common.RJButton btnEqubtnalize;
        public Common.RJButton btnLive;
        public Common.RJButton btnShowGrid;
        public Common.RJButton btnShowCenter;
        public Common.RJButton btnShowArea;
        public Common.RJButton btnSetting;
        public Common.RJButton btnCalib;
    }
}
