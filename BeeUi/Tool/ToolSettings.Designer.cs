
namespace BeeUi.Tool
{
    partial class ToolSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelect = new BeeUi.Common.RJButton();
            this.btnCopy = new BeeUi.Common.RJButton();
            this.btnEnEdit = new BeeUi.Common.RJButton();
            this.btnAdd = new BeeUi.Common.RJButton();
            this.pAllTool = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.btnDelect);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.btnEnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 58);
            this.panel1.TabIndex = 8;
            // 
            // btnDelect
            // 
            this.btnDelect.BackColor = System.Drawing.Color.White;
            this.btnDelect.BackgroundColor = System.Drawing.Color.White;
            this.btnDelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelect.BackgroundImage")));
            this.btnDelect.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelect.BorderRadius = 10;
            this.btnDelect.BorderSize = 1;
            this.btnDelect.Enabled = false;
            this.btnDelect.FlatAppearance.BorderSize = 0;
            this.btnDelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelect.ForeColor = System.Drawing.Color.Black;
            this.btnDelect.Image = global::BeeUi.Properties.Resources.BID_ICON_DELETE_E_32BIT;
            this.btnDelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelect.IsCLick = false;
            this.btnDelect.IsNotChange = true;
            this.btnDelect.IsRect = false;
            this.btnDelect.IsUnGroup = true;
            this.btnDelect.Location = new System.Drawing.Point(310, 4);
            this.btnDelect.Name = "btnDelect";
            this.btnDelect.Size = new System.Drawing.Size(87, 50);
            this.btnDelect.TabIndex = 10;
            this.btnDelect.Text = "Delete";
            this.btnDelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelect.TextColor = System.Drawing.Color.Black;
            this.btnDelect.UseVisualStyleBackColor = false;
            this.btnDelect.Click += new System.EventHandler(this.btnDelect_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.White;
            this.btnCopy.BackgroundColor = System.Drawing.Color.White;
            this.btnCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopy.BackgroundImage")));
            this.btnCopy.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.BorderRadius = 10;
            this.btnCopy.BorderSize = 1;
            this.btnCopy.Enabled = false;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.Black;
            this.btnCopy.Image = global::BeeUi.Properties.Resources.BID_ICON_COPY_D_32BIT;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopy.IsCLick = false;
            this.btnCopy.IsNotChange = true;
            this.btnCopy.IsRect = false;
            this.btnCopy.IsUnGroup = true;
            this.btnCopy.Location = new System.Drawing.Point(217, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(87, 50);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopy.TextColor = System.Drawing.Color.Black;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnEnEdit
            // 
            this.btnEnEdit.BackColor = System.Drawing.Color.White;
            this.btnEnEdit.BackgroundColor = System.Drawing.Color.White;
            this.btnEnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnEdit.BackgroundImage")));
            this.btnEnEdit.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnEdit.BorderRadius = 10;
            this.btnEnEdit.BorderSize = 1;
            this.btnEnEdit.FlatAppearance.BorderSize = 0;
            this.btnEnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEnEdit.Image = global::BeeUi.Properties.Resources.BID_ICON_TOOL_EDIT_E_32BIT;
            this.btnEnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnEdit.IsCLick = false;
            this.btnEnEdit.IsNotChange = false;
            this.btnEnEdit.IsRect = false;
            this.btnEnEdit.IsUnGroup = true;
            this.btnEnEdit.Location = new System.Drawing.Point(124, 4);
            this.btnEnEdit.Name = "btnEnEdit";
            this.btnEnEdit.Size = new System.Drawing.Size(87, 50);
            this.btnEnEdit.TabIndex = 8;
            this.btnEnEdit.Text = "Edit";
            this.btnEnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnEdit.TextColor = System.Drawing.Color.Black;
            this.btnEnEdit.UseVisualStyleBackColor = false;
            this.btnEnEdit.Click += new System.EventHandler(this.btnEnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::BeeUi.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.IsCLick = false;
            this.btnAdd.IsNotChange = true;
            this.btnAdd.IsRect = false;
            this.btnAdd.IsUnGroup = true;
            this.btnAdd.Location = new System.Drawing.Point(3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pAllTool
            // 
            this.pAllTool.AutoScroll = true;
            this.pAllTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAllTool.Location = new System.Drawing.Point(0, 58);
            this.pAllTool.Name = "pAllTool";
            this.pAllTool.Size = new System.Drawing.Size(400, 467);
            this.pAllTool.TabIndex = 9;
            // 
            // ToolSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.pAllTool);
            this.Controls.Add(this.panel1);
            this.Name = "ToolSettings";
            this.Size = new System.Drawing.Size(400, 525);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pAllTool;
        public Common.RJButton btnAdd;
        public Common.RJButton btnDelect;
        public Common.RJButton btnCopy;
        public Common.RJButton btnEnEdit;
    }
}
