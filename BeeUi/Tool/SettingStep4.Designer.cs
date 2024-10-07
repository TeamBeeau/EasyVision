
namespace BeeUi.Tool
{
    partial class SettingStep4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingStep4));
            this.workRead = new System.ComponentModel.BackgroundWorker();
            this.pLogic = new System.Windows.Forms.GroupBox();
            this.pLogic1 = new System.Windows.Forms.Panel();
            this.btnAnd = new BeeUi.Common.RJButton();
            this.btnOr = new BeeUi.Common.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numToolOK = new System.Windows.Forms.NumericUpDown();
            this.pAnyTool = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new BeeUi.Common.RJButton();
            this.btnTotalOK = new BeeUi.Common.RJButton();
            this.btnAnyOK = new BeeUi.Common.RJButton();
            this.btnCancel = new BeeUi.Common.RJButton();
            this.btnComplete = new BeeUi.Common.RJButton();
            this.pLogic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToolOK)).BeginInit();
            this.pAnyTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogic
            // 
            this.pLogic.Controls.Add(this.pLogic1);
            this.pLogic.Controls.Add(this.btnAnd);
            this.pLogic.Controls.Add(this.btnOr);
            this.pLogic.Enabled = false;
            this.pLogic.Location = new System.Drawing.Point(9, 151);
            this.pLogic.Name = "pLogic";
            this.pLogic.Size = new System.Drawing.Size(352, 306);
            this.pLogic.TabIndex = 18;
            this.pLogic.TabStop = false;
            this.pLogic.Text = "Logic";
            this.pLogic.Enter += new System.EventHandler(this.grLogic_Enter);
            // 
            // pLogic1
            // 
            this.pLogic1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pLogic1.AutoScroll = true;
            this.pLogic1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pLogic1.Location = new System.Drawing.Point(8, 65);
            this.pLogic1.Name = "pLogic1";
            this.pLogic1.Size = new System.Drawing.Size(338, 235);
            this.pLogic1.TabIndex = 21;
            // 
            // btnAnd
            // 
            this.btnAnd.BackColor = System.Drawing.Color.Transparent;
            this.btnAnd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnd.BackgroundImage")));
            this.btnAnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAnd.BorderRadius = 5;
            this.btnAnd.BorderSize = 1;
            this.btnAnd.FlatAppearance.BorderSize = 0;
            this.btnAnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnd.ForeColor = System.Drawing.Color.Black;
            this.btnAnd.IsCLick = true;
            this.btnAnd.IsNotChange = false;
            this.btnAnd.IsRect = false;
            this.btnAnd.IsUnGroup = false;
            this.btnAnd.Location = new System.Drawing.Point(17, 18);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(150, 40);
            this.btnAnd.TabIndex = 19;
            this.btnAnd.Text = "AND";
            this.btnAnd.TextColor = System.Drawing.Color.Black;
            this.btnAnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnd.UseVisualStyleBackColor = false;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnOr
            // 
            this.btnOr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOr.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnOr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOr.BackgroundImage")));
            this.btnOr.BorderColor = System.Drawing.Color.Silver;
            this.btnOr.BorderRadius = 5;
            this.btnOr.BorderSize = 1;
            this.btnOr.FlatAppearance.BorderSize = 0;
            this.btnOr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOr.ForeColor = System.Drawing.Color.Black;
            this.btnOr.IsCLick = false;
            this.btnOr.IsNotChange = false;
            this.btnOr.IsRect = false;
            this.btnOr.IsUnGroup = false;
            this.btnOr.Location = new System.Drawing.Point(176, 18);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(150, 40);
            this.btnOr.TabIndex = 20;
            this.btnOr.Text = "OR";
            this.btnOr.TextColor = System.Drawing.Color.Black;
            this.btnOr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOr.UseVisualStyleBackColor = false;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Status Condition";
            // 
            // numToolOK
            // 
            this.numToolOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numToolOK.Location = new System.Drawing.Point(235, 4);
            this.numToolOK.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numToolOK.Name = "numToolOK";
            this.numToolOK.Size = new System.Drawing.Size(109, 31);
            this.numToolOK.TabIndex = 20;
            this.numToolOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numToolOK.ValueChanged += new System.EventHandler(this.numToolOK_ValueChanged);
            // 
            // pAnyTool
            // 
            this.pAnyTool.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pAnyTool.Controls.Add(this.label2);
            this.pAnyTool.Controls.Add(this.numToolOK);
            this.pAnyTool.Enabled = false;
            this.pAnyTool.Location = new System.Drawing.Point(9, 96);
            this.pAnyTool.Name = "pAnyTool";
            this.pAnyTool.Size = new System.Drawing.Size(352, 42);
            this.pAnyTool.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Minimum Tool OK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BorderColor = System.Drawing.Color.Silver;
            this.btnLogin.BorderRadius = 3;
            this.btnLogin.BorderSize = 1;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.IsCLick = false;
            this.btnLogin.IsNotChange = false;
            this.btnLogin.IsRect = false;
            this.btnLogin.IsUnGroup = false;
            this.btnLogin.Location = new System.Drawing.Point(248, 49);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 40);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Logic";
            this.btnLogin.TextColor = System.Drawing.Color.Black;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnTotalOK
            // 
            this.btnTotalOK.BackColor = System.Drawing.Color.Transparent;
            this.btnTotalOK.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTotalOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotalOK.BackgroundImage")));
            this.btnTotalOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTotalOK.BorderColor = System.Drawing.Color.Transparent;
            this.btnTotalOK.BorderRadius = 5;
            this.btnTotalOK.BorderSize = 1;
            this.btnTotalOK.FlatAppearance.BorderSize = 0;
            this.btnTotalOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalOK.ForeColor = System.Drawing.Color.Black;
            this.btnTotalOK.IsCLick = true;
            this.btnTotalOK.IsNotChange = false;
            this.btnTotalOK.IsRect = false;
            this.btnTotalOK.IsUnGroup = false;
            this.btnTotalOK.Location = new System.Drawing.Point(20, 49);
            this.btnTotalOK.Name = "btnTotalOK";
            this.btnTotalOK.Size = new System.Drawing.Size(109, 40);
            this.btnTotalOK.TabIndex = 15;
            this.btnTotalOK.Text = "Total OK";
            this.btnTotalOK.TextColor = System.Drawing.Color.Black;
            this.btnTotalOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTotalOK.UseVisualStyleBackColor = false;
            this.btnTotalOK.Click += new System.EventHandler(this.btnTotalOK_Click);
            // 
            // btnAnyOK
            // 
            this.btnAnyOK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnyOK.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnyOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnyOK.BackgroundImage")));
            this.btnAnyOK.BorderColor = System.Drawing.Color.Silver;
            this.btnAnyOK.BorderRadius = 5;
            this.btnAnyOK.BorderSize = 1;
            this.btnAnyOK.FlatAppearance.BorderSize = 0;
            this.btnAnyOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnyOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnyOK.ForeColor = System.Drawing.Color.Black;
            this.btnAnyOK.IsCLick = false;
            this.btnAnyOK.IsNotChange = false;
            this.btnAnyOK.IsRect = false;
            this.btnAnyOK.IsUnGroup = false;
            this.btnAnyOK.Location = new System.Drawing.Point(134, 49);
            this.btnAnyOK.Name = "btnAnyOK";
            this.btnAnyOK.Size = new System.Drawing.Size(109, 40);
            this.btnAnyOK.TabIndex = 16;
            this.btnAnyOK.Text = "Any OK";
            this.btnAnyOK.TextColor = System.Drawing.Color.Black;
            this.btnAnyOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnyOK.UseVisualStyleBackColor = false;
            this.btnAnyOK.Click += new System.EventHandler(this.btnAnyOK_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(190, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 40);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnComplete.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnComplete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComplete.BackgroundImage")));
            this.btnComplete.BorderColor = System.Drawing.Color.Transparent;
            this.btnComplete.BorderRadius = 5;
            this.btnComplete.BorderSize = 1;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.Black;
            this.btnComplete.IsCLick = true;
            this.btnComplete.IsNotChange = true;
            this.btnComplete.IsRect = false;
            this.btnComplete.IsUnGroup = false;
            this.btnComplete.Location = new System.Drawing.Point(9, 464);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(175, 40);
            this.btnComplete.TabIndex = 12;
            this.btnComplete.Text = "Complete";
            this.btnComplete.TextColor = System.Drawing.Color.Black;
            this.btnComplete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // SettingStep4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pAnyTool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pLogic);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnTotalOK);
            this.Controls.Add(this.btnAnyOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComplete);
            this.Name = "SettingStep4";
            this.Size = new System.Drawing.Size(371, 516);
            this.Load += new System.EventHandler(this.SettingStep4_Load);
            this.pLogic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numToolOK)).EndInit();
            this.pAnyTool.ResumeLayout(false);
            this.pAnyTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.RJButton btnCancel;
        private Common.RJButton btnComplete;
        private System.ComponentModel.BackgroundWorker workRead;
        private Common.RJButton btnLogin;
        private Common.RJButton btnTotalOK;
        private Common.RJButton btnAnyOK;
        private Common.RJButton btnAnd;
        private Common.RJButton btnOr;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox pLogic;
        private System.Windows.Forms.Panel pLogic1;
        private System.Windows.Forms.NumericUpDown numToolOK;
        private System.Windows.Forms.Panel pAnyTool;
        private System.Windows.Forms.Label label2;
    }
}
