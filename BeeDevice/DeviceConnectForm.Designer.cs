
using System.ComponentModel;
using System.Windows.Forms;
using 合杰图像算法调试工具;

namespace BeeDevice
{
    partial class DeviceConnectForm
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
        private DeviceFindAndCom.DeviceFound SelectedDevice;

        public DriverInstall DriverInstallForm = new DriverInstall();

      
        private ComboBox CobLocalIPSel;

        private Label LabLocalIPSel;

        private ContextMenuStrip Cms_RightDeviceClick;

        private ToolStripMenuItem Tsm_ConnectDevice;

        private ToolStripMenuItem Tsm_DisconnectDevice;

        private ToolStripMenuItem Tsm_RestartDevice;

        private ToolStripMenuItem Tsm_SaveDeviceCfg;

        private Panel PanDeviceInfo;

        private TextBox TxbDeviceInfo;

        private Label LabDeviceInfo;

        private TextBox TxbDeviceAddr;

        private GroupBox GrbDeviceOps;

        private Button BtnRecoverUserSetting;

        private Button BtnSaveUserSetting;

        private Button BtnCaptrueImageSave;

        private Button BtnRecoverFactory;

        private Label LabDeviceAddr;

        private GroupBox GrbDevicesList;

        private TreeView TrvDevicesList;

        private ToolStripMenuItem Tsm_EditDeviceIp;

        private ImageList DeviceImageList;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("USB设备", 11, 11);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("网络设备", 10, 10);
            this.CobLocalIPSel = new System.Windows.Forms.ComboBox();
            this.LabLocalIPSel = new System.Windows.Forms.Label();
            this.Cms_RightDeviceClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tsm_ConnectDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_DisconnectDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_RestartDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_SaveDeviceCfg = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_EditDeviceIp = new System.Windows.Forms.ToolStripMenuItem();
            this.PanDeviceInfo = new System.Windows.Forms.Panel();
            this.TxbDeviceInfo = new System.Windows.Forms.TextBox();
            this.LabDeviceInfo = new System.Windows.Forms.Label();
            this.TxbDeviceAddr = new System.Windows.Forms.TextBox();
            this.GrbDeviceOps = new System.Windows.Forms.GroupBox();
            this.BtnRecoverUserSetting = new System.Windows.Forms.Button();
            this.BtnSaveUserSetting = new System.Windows.Forms.Button();
            this.BtnCaptrueImageSave = new System.Windows.Forms.Button();
            this.BtnRecoverFactory = new System.Windows.Forms.Button();
            this.LabDeviceAddr = new System.Windows.Forms.Label();
            this.GrbDevicesList = new System.Windows.Forms.GroupBox();
            this.TrvDevicesList = new System.Windows.Forms.TreeView();
            this.DeviceImageList = new System.Windows.Forms.ImageList(this.components);
            this.Cms_RightDeviceClick.SuspendLayout();
            this.PanDeviceInfo.SuspendLayout();
            this.GrbDeviceOps.SuspendLayout();
            this.GrbDevicesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // CobLocalIPSel
            // 
            this.CobLocalIPSel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CobLocalIPSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobLocalIPSel.FormattingEnabled = true;
            this.CobLocalIPSel.Location = new System.Drawing.Point(91, 12);
            this.CobLocalIPSel.Name = "CobLocalIPSel";
            this.CobLocalIPSel.Size = new System.Drawing.Size(234, 22);
            this.CobLocalIPSel.TabIndex = 20;
            this.CobLocalIPSel.DropDown += new System.EventHandler(this.CobLocalIPSel_DropDown);
            this.CobLocalIPSel.SelectedIndexChanged += new System.EventHandler(this.CobLocalIPSel_SelectedIndexChanged);
            this.CobLocalIPSel.DropDownClosed += new System.EventHandler(this.CobLocalIPSel_DropDownClosed);
            this.CobLocalIPSel.MouseLeave += new System.EventHandler(this.CobLocalIPSel_MouseLeave);
            // 
            // LabLocalIPSel
            // 
            this.LabLocalIPSel.AutoSize = true;
            this.LabLocalIPSel.Location = new System.Drawing.Point(5, 15);
            this.LabLocalIPSel.Name = "LabLocalIPSel";
            this.LabLocalIPSel.Size = new System.Drawing.Size(91, 14);
            this.LabLocalIPSel.TabIndex = 19;
            this.LabLocalIPSel.Text = "本地IP选择：";
            // 
            // Cms_RightDeviceClick
            // 
            this.Cms_RightDeviceClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_ConnectDevice,
            this.Tsm_DisconnectDevice,
            this.Tsm_RestartDevice,
            this.Tsm_SaveDeviceCfg,
            this.Tsm_EditDeviceIp});
            this.Cms_RightDeviceClick.Name = "CMS_DevideRightKey";
            this.Cms_RightDeviceClick.Size = new System.Drawing.Size(169, 114);
            this.Cms_RightDeviceClick.Opening += new System.ComponentModel.CancelEventHandler(this.Cms_RightDeviceClick_Opening);
            // 
            // Tsm_ConnectDevice
            // 
            this.Tsm_ConnectDevice.Image = global::BeeDevice.Properties.Resources.ImgTemp;
            this.Tsm_ConnectDevice.Name = "Tsm_ConnectDevice";
            this.Tsm_ConnectDevice.Size = new System.Drawing.Size(168, 22);
            this.Tsm_ConnectDevice.Text = "连接设备";
            this.Tsm_ConnectDevice.Click += new System.EventHandler(this.Tsm_ConnectDevice_Click);
            // 
            // Tsm_DisconnectDevice
            // 
            this.Tsm_DisconnectDevice.Image = global::BeeDevice.Properties.Resources.ImgTemp;
            this.Tsm_DisconnectDevice.Name = "Tsm_DisconnectDevice";
            this.Tsm_DisconnectDevice.Size = new System.Drawing.Size(168, 22);
            this.Tsm_DisconnectDevice.Text = "断开设备";
            this.Tsm_DisconnectDevice.Click += new System.EventHandler(this.Tsm_DisconnectDevice_Click);
            // 
            // Tsm_RestartDevice
            // 
            this.Tsm_RestartDevice.Name = "Tsm_RestartDevice";
            this.Tsm_RestartDevice.Size = new System.Drawing.Size(168, 22);
            this.Tsm_RestartDevice.Text = "重启设备(不保存)";
            this.Tsm_RestartDevice.Click += new System.EventHandler(this.Tsm_RestartDevice_Click);
            // 
            // Tsm_SaveDeviceCfg
            // 
            this.Tsm_SaveDeviceCfg.Name = "Tsm_SaveDeviceCfg";
            this.Tsm_SaveDeviceCfg.Size = new System.Drawing.Size(168, 22);
            this.Tsm_SaveDeviceCfg.Text = "保存配置到设备";
            this.Tsm_SaveDeviceCfg.Click += new System.EventHandler(this.Tsm_SaveDeviceCfg_Click);
            // 
            // Tsm_EditDeviceIp
            // 
            this.Tsm_EditDeviceIp.Name = "Tsm_EditDeviceIp";
            this.Tsm_EditDeviceIp.Size = new System.Drawing.Size(168, 22);
            this.Tsm_EditDeviceIp.Text = "修改IP地址";
            this.Tsm_EditDeviceIp.Click += new System.EventHandler(this.Tsm_EditDeviceIp_Click);
            // 
            // PanDeviceInfo
            // 
            this.PanDeviceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanDeviceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanDeviceInfo.Controls.Add(this.TxbDeviceInfo);
            this.PanDeviceInfo.Controls.Add(this.LabDeviceInfo);
            this.PanDeviceInfo.Controls.Add(this.TxbDeviceAddr);
            this.PanDeviceInfo.Controls.Add(this.GrbDeviceOps);
            this.PanDeviceInfo.Controls.Add(this.LabDeviceAddr);
            this.PanDeviceInfo.Location = new System.Drawing.Point(5, 458);
            this.PanDeviceInfo.Name = "PanDeviceInfo";
            this.PanDeviceInfo.Size = new System.Drawing.Size(326, 219);
            this.PanDeviceInfo.TabIndex = 22;
            // 
            // TxbDeviceInfo
            // 
            this.TxbDeviceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbDeviceInfo.Location = new System.Drawing.Point(9, 76);
            this.TxbDeviceInfo.Name = "TxbDeviceInfo";
            this.TxbDeviceInfo.ReadOnly = true;
            this.TxbDeviceInfo.Size = new System.Drawing.Size(307, 23);
            this.TxbDeviceInfo.TabIndex = 9;
            // 
            // LabDeviceInfo
            // 
            this.LabDeviceInfo.AutoSize = true;
            this.LabDeviceInfo.Location = new System.Drawing.Point(7, 59);
            this.LabDeviceInfo.Name = "LabDeviceInfo";
            this.LabDeviceInfo.Size = new System.Drawing.Size(63, 14);
            this.LabDeviceInfo.TabIndex = 8;
            this.LabDeviceInfo.Text = "设备信息";
            // 
            // TxbDeviceAddr
            // 
            this.TxbDeviceAddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbDeviceAddr.Location = new System.Drawing.Point(9, 33);
            this.TxbDeviceAddr.Name = "TxbDeviceAddr";
            this.TxbDeviceAddr.ReadOnly = true;
            this.TxbDeviceAddr.Size = new System.Drawing.Size(307, 23);
            this.TxbDeviceAddr.TabIndex = 7;
            // 
            // GrbDeviceOps
            // 
            this.GrbDeviceOps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbDeviceOps.Controls.Add(this.BtnRecoverUserSetting);
            this.GrbDeviceOps.Controls.Add(this.BtnSaveUserSetting);
            this.GrbDeviceOps.Controls.Add(this.BtnCaptrueImageSave);
            this.GrbDeviceOps.Controls.Add(this.BtnRecoverFactory);
            this.GrbDeviceOps.Location = new System.Drawing.Point(4, 105);
            this.GrbDeviceOps.Name = "GrbDeviceOps";
            this.GrbDeviceOps.Size = new System.Drawing.Size(312, 109);
            this.GrbDeviceOps.TabIndex = 6;
            this.GrbDeviceOps.TabStop = false;
            this.GrbDeviceOps.Text = "设备操作";
            // 
            // BtnRecoverUserSetting
            // 
            this.BtnRecoverUserSetting.Location = new System.Drawing.Point(161, 64);
            this.BtnRecoverUserSetting.Name = "BtnRecoverUserSetting";
            this.BtnRecoverUserSetting.Size = new System.Drawing.Size(120, 36);
            this.BtnRecoverUserSetting.TabIndex = 2;
            this.BtnRecoverUserSetting.Text = "恢复用户设置";
            this.BtnRecoverUserSetting.UseVisualStyleBackColor = true;
            this.BtnRecoverUserSetting.Visible = false;
            this.BtnRecoverUserSetting.Click += new System.EventHandler(this.BtnRecoverUserSetting_Click);
            // 
            // BtnSaveUserSetting
            // 
            this.BtnSaveUserSetting.Location = new System.Drawing.Point(16, 64);
            this.BtnSaveUserSetting.Name = "BtnSaveUserSetting";
            this.BtnSaveUserSetting.Size = new System.Drawing.Size(120, 36);
            this.BtnSaveUserSetting.TabIndex = 1;
            this.BtnSaveUserSetting.Text = "保存用户设置";
            this.BtnSaveUserSetting.UseVisualStyleBackColor = true;
            this.BtnSaveUserSetting.Visible = false;
            this.BtnSaveUserSetting.Click += new System.EventHandler(this.BtnSaveUserSetting_Click);
            // 
            // BtnCaptrueImageSave
            // 
            this.BtnCaptrueImageSave.Location = new System.Drawing.Point(161, 28);
            this.BtnCaptrueImageSave.Name = "BtnCaptrueImageSave";
            this.BtnCaptrueImageSave.Size = new System.Drawing.Size(120, 36);
            this.BtnCaptrueImageSave.TabIndex = 9;
            this.BtnCaptrueImageSave.Text = "存一张图";
            this.BtnCaptrueImageSave.UseVisualStyleBackColor = true;
            this.BtnCaptrueImageSave.Visible = false;
            this.BtnCaptrueImageSave.Click += new System.EventHandler(this.BtnCaptrueImageSave_Click);
            // 
            // BtnRecoverFactory
            // 
            this.BtnRecoverFactory.Location = new System.Drawing.Point(16, 28);
            this.BtnRecoverFactory.Name = "BtnRecoverFactory";
            this.BtnRecoverFactory.Size = new System.Drawing.Size(120, 36);
            this.BtnRecoverFactory.TabIndex = 0;
            this.BtnRecoverFactory.Text = "恢复出厂设置";
            this.BtnRecoverFactory.UseVisualStyleBackColor = true;
            this.BtnRecoverFactory.Click += new System.EventHandler(this.BtnRecoverFactory_Click);
            // 
            // LabDeviceAddr
            // 
            this.LabDeviceAddr.AutoSize = true;
            this.LabDeviceAddr.Location = new System.Drawing.Point(7, 12);
            this.LabDeviceAddr.Name = "LabDeviceAddr";
            this.LabDeviceAddr.Size = new System.Drawing.Size(63, 14);
            this.LabDeviceAddr.TabIndex = 5;
            this.LabDeviceAddr.Text = "设备位置";
            // 
            // GrbDevicesList
            // 
            this.GrbDevicesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbDevicesList.Controls.Add(this.TrvDevicesList);
            this.GrbDevicesList.Location = new System.Drawing.Point(8, 40);
            this.GrbDevicesList.Name = "GrbDevicesList";
            this.GrbDevicesList.Size = new System.Drawing.Size(323, 412);
            this.GrbDevicesList.TabIndex = 23;
            this.GrbDevicesList.TabStop = false;
            this.GrbDevicesList.Text = "设备列表";
            // 
            // TrvDevicesList
            // 
            this.TrvDevicesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrvDevicesList.ImageIndex = 0;
            this.TrvDevicesList.ImageList = this.DeviceImageList;
            this.TrvDevicesList.Location = new System.Drawing.Point(6, 17);
            this.TrvDevicesList.Name = "TrvDevicesList";
            treeNode1.ImageIndex = 11;
            treeNode1.Name = "Tree1UsbDevice";
            treeNode1.SelectedImageIndex = 11;
            treeNode1.Text = "USB设备";
            treeNode2.ImageIndex = 10;
            treeNode2.Name = "Tree1NetworkDevice";
            treeNode2.SelectedImageIndex = 10;
            treeNode2.Text = "网络设备";
            this.TrvDevicesList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.TrvDevicesList.SelectedImageIndex = 0;
            this.TrvDevicesList.Size = new System.Drawing.Size(311, 389);
            this.TrvDevicesList.TabIndex = 3;
            this.TrvDevicesList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvDevicesList_AfterSelect);
            this.TrvDevicesList.DoubleClick += new System.EventHandler(this.TrvDevicesList_DoubleClick);
            this.TrvDevicesList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrvDevicesList_MouseDown);
            // 
            // DeviceImageList
            // 
            this.DeviceImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.DeviceImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.DeviceImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // DeviceConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 689);
            this.Controls.Add(this.GrbDevicesList);
            this.Controls.Add(this.PanDeviceInfo);
            this.Controls.Add(this.CobLocalIPSel);
            this.Controls.Add(this.LabLocalIPSel);
            this.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.Name = "DeviceConnectForm";
            this.Text = "设备列表";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeviceConnectForm_FormClosed);
            this.Load += new System.EventHandler(this.DevideConnectForm_Load);
            this.Cms_RightDeviceClick.ResumeLayout(false);
            this.PanDeviceInfo.ResumeLayout(false);
            this.PanDeviceInfo.PerformLayout();
            this.GrbDeviceOps.ResumeLayout(false);
            this.GrbDevicesList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}