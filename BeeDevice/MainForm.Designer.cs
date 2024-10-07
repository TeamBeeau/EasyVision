
using Heroje_Debug_Tool.BaseClass;
using Heroje_Debug_Tool.SubForm;
using System.Collections.Generic;
using System.Windows.Forms;
using 合杰图像算法调试工具;
using 图像算法调试工具;

namespace BeeDevice
{
    partial class MainForm
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
        /// private SetCfgCB SetCfgCBFunc;

        private GetCfgCB GetCfgCBFunc;

        private SendCfgDataCB SendCfgDataCBFunc;

        public DeviceConnectForm DeviceConnectPage;

        public ReadingForm ReadingPage;

        private DataEditForm DataEditPage;

        private IOInstructionForm IOInstructionPage;

        private AlgorithmProtocolForm AlgorithmProtocolPage;

        private CommunicateSettingForm CommunicateSettingPage;

        private AdvancedSettingForm AdvancedSettingPage;

        private ImageSaveSettingForm ImageSaveSettingPage;

        private OthersSettingForm OthersSettingPage;

        private string[] PageName_C = new string[8] { "读取", "通讯协议", "数据编辑", "IO指令", "算法协议", "图像保存", "其他", "高级功能" };

        private string[] PageName_T = new string[8] { "讀取", "通訊協定", "資料編輯", "IO指令", "演算法協定", "圖像保存", "其他", "高級功能" };

        private string[] PageName_E = new string[8] { "Read", "Communicate", "DataEdit", "IO CMD", "Algorithm", "ImgSave", "Others", "Advance" };

        private List<TabPage> PageList = new List<TabPage>();

        private DeviceCapacity.DeviceCapacityInfoStu DevCapacityArr;

        private string DeviceNameTemp;

        private bool NeedWaiteStart = true;

        private System.Timers.Timer FormClosedTimer;

        private ComDebugTool ComDebugToolForm = new ComDebugTool();

        private FormNet FormNetTools = new FormNet();

        private About AboutForm;

        private SettingForm FormSetting;

      

        private MenuStrip MenuTopMain;

        private ToolStripMenuItem TsmTop_File;

        private ToolStripMenuItem TsmTop_Disp;

        private ToolStripMenuItem TsmTop_Sys;

        private ToolStripMenuItem TsmTop_Tool;

        private ToolStripMenuItem TsmTop_Help;

        private ToolStrip ToolStrip_Icon;

        private ToolStripSeparator TSS_Separator1;

        private ToolStripButton TSB_SearchDevice;

        private ToolStripButton TSB_ConnectDevice;

        private ToolStripButton TSB_DisconnectDevice;

        private ToolStripSeparator TSS_Separator2;

        private SplitContainer MainContainer;

        private TabControl TabSetting;

        private ToolStripMenuItem InstallUSBDrvToolStripMenuItem;

        private Panel PanDecMode;

        private RadioButton RdbDecodeModeC;

        private RadioButton RdbDecodeModeB;

        private RadioButton RdbDecodeModeA;

        private ToolStripMenuItem TsmTop_Language;

        private ToolStripMenuItem TSM_AboutSoftware;

        private ToolStripMenuItem TSM_SoftwareCloseDo;

        private CheckBox ChbUseTrainPara;

        private Button BtnDecodeCTraining;

        private ToolStripButton TSB_OpenCfg;

        private ToolStripButton TSB_SaveCfg;

        private ToolStripMenuItem Tsm_ComDebugTool;

        private ToolStripMenuItem Tsm_NetDebugTool;

        private ToolStripMenuItem Tsm_CmdConfigurationTool;

        private ToolStripMenuItem TSI_InstallGuide;

        private ToolStripMenuItem Tsm_ShowNetGrid;

        private ToolStripMenuItem TSM_UpgradeFirmware;

        private ToolStripMenuItem TSI_OpenCfg;

        private ToolStripMenuItem TSI_SaveCfg;

        private ToolStripMenuItem TSI_SaveCurrentImage;

        private ToolStripMenuItem TSM_FirmwareVersion;

        private Button BtnSaveCurrentCfg;

        private Button BtnRestartDevice;

        private ToolStripMenuItem TsmTop_Setting;

        private ToolStripMenuItem Tsm_Regular_Barcode;

        private ToolStripMenuItem Tsm_Regular_Output;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuTopMain = new System.Windows.Forms.MenuStrip();
            this.TsmTop_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSI_OpenCfg = new System.Windows.Forms.ToolStripMenuItem();
            this.TSI_SaveCfg = new System.Windows.Forms.ToolStripMenuItem();
            this.TSI_SaveCurrentImage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTop_Disp = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_ShowNetGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTop_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.InstallUSBDrvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_ComDebugTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_NetDebugTool = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_CmdConfigurationTool = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTop_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Regular_Barcode = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Regular_Output = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTop_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTop_Sys = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_AboutSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_FirmwareVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_SoftwareCloseDo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_UpgradeFirmware = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTop_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSI_InstallGuide = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Icon = new System.Windows.Forms.ToolStrip();
            this.TSB_SearchDevice = new System.Windows.Forms.ToolStripButton();
            this.TSB_ConnectDevice = new System.Windows.Forms.ToolStripButton();
            this.TSB_DisconnectDevice = new System.Windows.Forms.ToolStripButton();
            this.TSS_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_OpenCfg = new System.Windows.Forms.ToolStripButton();
            this.TSB_SaveCfg = new System.Windows.Forms.ToolStripButton();
            this.TSS_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.TabSetting = new System.Windows.Forms.TabControl();
            this.PanDecMode = new System.Windows.Forms.Panel();
            this.ChbUseTrainPara = new System.Windows.Forms.CheckBox();
            this.BtnDecodeCTraining = new System.Windows.Forms.Button();
            this.RdbDecodeModeC = new System.Windows.Forms.RadioButton();
            this.RdbDecodeModeB = new System.Windows.Forms.RadioButton();
            this.RdbDecodeModeA = new System.Windows.Forms.RadioButton();
            this.BtnSaveCurrentCfg = new System.Windows.Forms.Button();
            this.BtnRestartDevice = new System.Windows.Forms.Button();
            this.MenuTopMain.SuspendLayout();
            this.ToolStrip_Icon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.MainContainer).BeginInit();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.PanDecMode.SuspendLayout();
            base.SuspendLayout();
            this.MenuTopMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5f);
            this.MenuTopMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.TsmTop_File, this.TsmTop_Disp, this.TsmTop_Tool, this.TsmTop_Setting, this.TsmTop_Language, this.TsmTop_Sys, this.TsmTop_Help });
            this.MenuTopMain.Location = new System.Drawing.Point(0, 0);
            this.MenuTopMain.Name = "MenuTopMain";
            this.MenuTopMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuTopMain.Size = new System.Drawing.Size(1264, 28);
            this.MenuTopMain.TabIndex = 0;
            this.MenuTopMain.Text = "MenuStripTop";
            this.TsmTop_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.TSI_OpenCfg, this.TSI_SaveCfg, this.TSI_SaveCurrentImage });
            this.TsmTop_File.Name = "TsmTop_File";
            this.TsmTop_File.Size = new System.Drawing.Size(66, 24);
            this.TsmTop_File.Text = "文件(F)";
            this.TSI_OpenCfg.Name = "TSI_OpenCfg";
            this.TSI_OpenCfg.Size = new System.Drawing.Size(168, 24);
            this.TSI_OpenCfg.Text = "打开配置(O)";
            this.TSI_OpenCfg.Click += new System.EventHandler(TSI_OpenCfg_Click);
            this.TSI_SaveCfg.Name = "TSI_SaveCfg";
            this.TSI_SaveCfg.Size = new System.Drawing.Size(168, 24);
            this.TSI_SaveCfg.Text = "保存配置(S)";
            this.TSI_SaveCfg.Click += new System.EventHandler(TSI_SaveCfg_Click);
            this.TSI_SaveCurrentImage.Name = "TSI_SaveCurrentImage";
            this.TSI_SaveCurrentImage.Size = new System.Drawing.Size(168, 24);
            this.TSI_SaveCurrentImage.Text = "图像另存为(A)";
            this.TSI_SaveCurrentImage.Click += new System.EventHandler(TSI_SaveCurrentImage_Click);
            this.TsmTop_Disp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.Tsm_ShowNetGrid });
            this.TsmTop_Disp.Name = "TsmTop_Disp";
            this.TsmTop_Disp.Size = new System.Drawing.Size(68, 24);
            this.TsmTop_Disp.Text = "显示(V)";
            this.TsmTop_Disp.DropDownOpening += new System.EventHandler(TsmTop_Disp_DropDownOpening);
            this.Tsm_ShowNetGrid.Name = "Tsm_ShowNetGrid";
            this.Tsm_ShowNetGrid.Size = new System.Drawing.Size(134, 24);
            this.Tsm_ShowNetGrid.Text = "显示标线";
            this.Tsm_ShowNetGrid.Click += new System.EventHandler(Tsm_ShowNetGrid_Click);
            this.TsmTop_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.InstallUSBDrvToolStripMenuItem, this.Tsm_ComDebugTool, this.Tsm_NetDebugTool, this.Tsm_CmdConfigurationTool });
            this.TsmTop_Tool.Name = "TsmTop_Tool";
            this.TsmTop_Tool.Size = new System.Drawing.Size(66, 24);
            this.TsmTop_Tool.Text = "工具(L)";
            this.TsmTop_Tool.DropDownOpening += new System.EventHandler(TsmTop_Tool_DropDownOpening);
            this.InstallUSBDrvToolStripMenuItem.Name = "InstallUSBDrvToolStripMenuItem";
            this.InstallUSBDrvToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.InstallUSBDrvToolStripMenuItem.Text = "安装USB驱动";
            this.InstallUSBDrvToolStripMenuItem.Click += new System.EventHandler(InstallUSBDrvToolStripMenuItem_Click);
            this.Tsm_ComDebugTool.Name = "Tsm_ComDebugTool";
            this.Tsm_ComDebugTool.Size = new System.Drawing.Size(162, 24);
            this.Tsm_ComDebugTool.Text = "串口调试助手";
            this.Tsm_ComDebugTool.Click += new System.EventHandler(ComDebugToolStripMenuItem_Click);
            this.Tsm_NetDebugTool.Name = "Tsm_NetDebugTool";
            this.Tsm_NetDebugTool.Size = new System.Drawing.Size(162, 24);
            this.Tsm_NetDebugTool.Text = "网口调试助手";
            this.Tsm_NetDebugTool.Click += new System.EventHandler(NetworkDebugToolStripMenuItem_Click);
            this.Tsm_CmdConfigurationTool.Name = "Tsm_CmdConfigurationTool";
            this.Tsm_CmdConfigurationTool.Size = new System.Drawing.Size(162, 24);
            this.Tsm_CmdConfigurationTool.Text = "命令配置工具";
            this.Tsm_CmdConfigurationTool.Click += new System.EventHandler(CmdCfgToolStripMenuItem_Click);
            this.TsmTop_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.Tsm_Regular_Barcode, this.Tsm_Regular_Output });
            this.TsmTop_Setting.Name = "TsmTop_Setting";
            this.TsmTop_Setting.Size = new System.Drawing.Size(95, 24);
            this.TsmTop_Setting.Text = "高级设置(S)";
            this.Tsm_Regular_Barcode.Name = "Tsm_Regular_Barcode";
            this.Tsm_Regular_Barcode.Size = new System.Drawing.Size(210, 24);
            this.Tsm_Regular_Barcode.Text = "正则表达式-条码匹配";
            this.Tsm_Regular_Barcode.Click += new System.EventHandler(Tsm_Regular_Barcode_Click);
            this.Tsm_Regular_Output.Name = "Tsm_Regular_Output";
            this.Tsm_Regular_Output.Size = new System.Drawing.Size(210, 24);
            this.Tsm_Regular_Output.Text = "正则表达式-输出过滤";
            this.Tsm_Regular_Output.Click += new System.EventHandler(Tsm_Regular_Output_Click);
            this.TsmTop_Language.Name = "TsmTop_Language";
            this.TsmTop_Language.Size = new System.Drawing.Size(49, 24);
            this.TsmTop_Language.Text = "语言";
            this.TsmTop_Sys.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.TSM_AboutSoftware, this.TSM_FirmwareVersion, this.TSM_SoftwareCloseDo, this.TSM_UpgradeFirmware });
            this.TsmTop_Sys.Name = "TsmTop_Sys";
            this.TsmTop_Sys.Size = new System.Drawing.Size(73, 24);
            this.TsmTop_Sys.Text = "系统(M)";
            this.TSM_AboutSoftware.Name = "TSM_AboutSoftware";
            this.TSM_AboutSoftware.Size = new System.Drawing.Size(204, 24);
            this.TSM_AboutSoftware.Text = "关于软件";
            this.TSM_AboutSoftware.Click += new System.EventHandler(TSM_AboutSoftware_Click);
            this.TSM_FirmwareVersion.Name = "TSM_FirmwareVersion";
            this.TSM_FirmwareVersion.Size = new System.Drawing.Size(204, 24);
            this.TSM_FirmwareVersion.Text = "查看固件版本信息";
            this.TSM_FirmwareVersion.Click += new System.EventHandler(TSM_FirmwareVersion_Click);
            this.TSM_SoftwareCloseDo.Name = "TSM_SoftwareCloseDo";
            this.TSM_SoftwareCloseDo.Size = new System.Drawing.Size(204, 24);
            this.TSM_SoftwareCloseDo.Text = "设置软件退出时动作";
            this.TSM_SoftwareCloseDo.Click += new System.EventHandler(TSM_SoftwareCloseDo_Click);
            this.TSM_UpgradeFirmware.Name = "TSM_UpgradeFirmware";
            this.TSM_UpgradeFirmware.Size = new System.Drawing.Size(204, 24);
            this.TSM_UpgradeFirmware.Text = "固件升级";
            this.TSM_UpgradeFirmware.Click += new System.EventHandler(TSM_UpgradeFirmware_Click);
            this.TsmTop_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.TSI_InstallGuide });
            this.TsmTop_Help.Name = "TsmTop_Help";
            this.TsmTop_Help.Size = new System.Drawing.Size(70, 24);
            this.TsmTop_Help.Text = "帮助(H)";
            this.TSI_InstallGuide.Name = "TSI_InstallGuide";
            this.TSI_InstallGuide.Size = new System.Drawing.Size(180, 24);
            this.TSI_InstallGuide.Text = "安装指南";
            this.ToolStrip_Icon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.ToolStrip_Icon.AutoSize = false;
            this.ToolStrip_Icon.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStrip_Icon.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip_Icon.Font = new System.Drawing.Font("宋体", 10.5f);
            this.ToolStrip_Icon.Items.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.TSB_SearchDevice, this.TSB_ConnectDevice, this.TSB_DisconnectDevice, this.TSS_Separator1, this.TSB_OpenCfg, this.TSB_SaveCfg, this.TSS_Separator2 });
            this.ToolStrip_Icon.Location = new System.Drawing.Point(0, 31);
            this.ToolStrip_Icon.Name = "ToolStrip_Icon";
            this.ToolStrip_Icon.Size = new System.Drawing.Size(1264, 77);
            this.ToolStrip_Icon.TabIndex = 1;
            this.ToolStrip_Icon.Text = "toolStrip1";
            this.TSB_SearchDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            //this.TSB_SearchDevice.Image = (System.Drawing.Image)resources.GetObject("TSB_SearchDevice.Image");
            this.TSB_SearchDevice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_SearchDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_SearchDevice.Name = "TSB_SearchDevice";
            this.TSB_SearchDevice.Size = new System.Drawing.Size(68, 74);
            this.TSB_SearchDevice.Text = "搜索设备";
            this.TSB_SearchDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_SearchDevice.Click += new System.EventHandler(TSB_SearchDevice_Click);
            this.TSB_ConnectDevice.Enabled = false;
           // this.TSB_ConnectDevice.Image = (System.Drawing.Image)resources.GetObject("TSB_ConnectDevice.Image");
            this.TSB_ConnectDevice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_ConnectDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_ConnectDevice.Name = "TSB_ConnectDevice";
            this.TSB_ConnectDevice.Size = new System.Drawing.Size(68, 74);
            this.TSB_ConnectDevice.Text = "连接设备";
            this.TSB_ConnectDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_ConnectDevice.Click += new System.EventHandler(TSB_ConnectDevice_Click);
            this.TSB_DisconnectDevice.Enabled = false;
            //this.TSB_DisconnectDevice.Image = (System.Drawing.Image)resources.GetObject("TSB_DisconnectDevice.Image");
            this.TSB_DisconnectDevice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_DisconnectDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_DisconnectDevice.Name = "TSB_DisconnectDevice";
            this.TSB_DisconnectDevice.Size = new System.Drawing.Size(68, 74);
            this.TSB_DisconnectDevice.Text = "断开设备";
            this.TSB_DisconnectDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_DisconnectDevice.Click += new System.EventHandler(TSB_DisconnectDevice_Click);
            this.TSS_Separator1.Name = "TSS_Separator1";
            this.TSS_Separator1.Size = new System.Drawing.Size(6, 77);
            //this.TSB_OpenCfg.Image = (System.Drawing.Image)resources.GetObject("TSB_OpenCfg.Image");
            this.TSB_OpenCfg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_OpenCfg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_OpenCfg.Name = "TSB_OpenCfg";
            this.TSB_OpenCfg.Size = new System.Drawing.Size(68, 74);
            this.TSB_OpenCfg.Text = "打开配置";
            this.TSB_OpenCfg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_OpenCfg.Click += new System.EventHandler(TSB_OpenCfg_Click);
            //this.TSB_SaveCfg.Image = (System.Drawing.Image)resources.GetObject("TSB_SaveCfg.Image");
            this.TSB_SaveCfg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_SaveCfg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_SaveCfg.Name = "TSB_SaveCfg";
            this.TSB_SaveCfg.Size = new System.Drawing.Size(68, 74);
            this.TSB_SaveCfg.Text = "保存配置";
            this.TSB_SaveCfg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSB_SaveCfg.Click += new System.EventHandler(TSB_SaveCfg_Click);
            this.TSS_Separator2.Name = "TSS_Separator2";
            this.TSS_Separator2.Size = new System.Drawing.Size(6, 77);
            this.MainContainer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainContainer.Location = new System.Drawing.Point(1, 111);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Panel2.Controls.Add(this.TabSetting);
            this.MainContainer.Size = new System.Drawing.Size(1260, 646);
            this.MainContainer.SplitterDistance = 340;
            this.MainContainer.SplitterWidth = 5;
            this.MainContainer.TabIndex = 4;
            this.TabSetting.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.TabSetting.ItemSize = new System.Drawing.Size(60, 29);
            this.TabSetting.Location = new System.Drawing.Point(-1, -1);
            this.TabSetting.Name = "TabSetting";
            this.TabSetting.SelectedIndex = 0;
            this.TabSetting.Size = new System.Drawing.Size(893, 642);
            this.TabSetting.TabIndex = 0;
            this.PanDecMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.PanDecMode.BackColor = System.Drawing.SystemColors.Control;
            this.PanDecMode.Controls.Add(this.ChbUseTrainPara);
            this.PanDecMode.Controls.Add(this.BtnDecodeCTraining);
            this.PanDecMode.Controls.Add(this.RdbDecodeModeC);
            this.PanDecMode.Controls.Add(this.RdbDecodeModeB);
            this.PanDecMode.Controls.Add(this.RdbDecodeModeA);
            this.PanDecMode.Location = new System.Drawing.Point(699, 58);
            this.PanDecMode.Name = "PanDecMode";
            this.PanDecMode.Size = new System.Drawing.Size(345, 27);
            this.PanDecMode.TabIndex = 5;
            this.ChbUseTrainPara.AutoSize = true;
            this.ChbUseTrainPara.Location = new System.Drawing.Point(275, 7);
            this.ChbUseTrainPara.Name = "ChbUseTrainPara";
            this.ChbUseTrainPara.Size = new System.Drawing.Size(15, 14);
            this.ChbUseTrainPara.TabIndex = 55;
            this.ChbUseTrainPara.UseVisualStyleBackColor = true;
            this.ChbUseTrainPara.Visible = false;
            this.ChbUseTrainPara.CheckedChanged += new System.EventHandler(ChbUseTrainPara_CheckedChanged);
            this.BtnDecodeCTraining.Location = new System.Drawing.Point(291, 2);
            this.BtnDecodeCTraining.Name = "BtnDecodeCTraining";
            this.BtnDecodeCTraining.Size = new System.Drawing.Size(48, 23);
            this.BtnDecodeCTraining.TabIndex = 54;
            this.BtnDecodeCTraining.Text = "训练";
            this.BtnDecodeCTraining.UseVisualStyleBackColor = true;
            this.BtnDecodeCTraining.Visible = false;
            this.BtnDecodeCTraining.Click += new System.EventHandler(BtnDecodeCTraining_Click);
            this.RdbDecodeModeC.AutoSize = true;
            this.RdbDecodeModeC.Location = new System.Drawing.Point(187, 4);
            this.RdbDecodeModeC.Name = "RdbDecodeModeC";
            this.RdbDecodeModeC.Size = new System.Drawing.Size(88, 18);
            this.RdbDecodeModeC.TabIndex = 30;
            this.RdbDecodeModeC.Text = "C增强模式";
            this.RdbDecodeModeC.UseVisualStyleBackColor = true;
            this.RdbDecodeModeC.CheckedChanged += new System.EventHandler(RdbDecodeModeC_CheckedChanged);
            this.RdbDecodeModeB.AutoSize = true;
            this.RdbDecodeModeB.Location = new System.Drawing.Point(97, 3);
            this.RdbDecodeModeB.Name = "RdbDecodeModeB";
            this.RdbDecodeModeB.Size = new System.Drawing.Size(88, 18);
            this.RdbDecodeModeB.TabIndex = 29;
            this.RdbDecodeModeB.Text = "B快速模式";
            this.RdbDecodeModeB.UseVisualStyleBackColor = true;
            this.RdbDecodeModeB.CheckedChanged += new System.EventHandler(RdbDecodeModeB_CheckedChanged);
            this.RdbDecodeModeA.AutoSize = true;
            this.RdbDecodeModeA.Location = new System.Drawing.Point(3, 3);
            this.RdbDecodeModeA.Name = "RdbDecodeModeA";
            this.RdbDecodeModeA.Size = new System.Drawing.Size(88, 18);
            this.RdbDecodeModeA.TabIndex = 28;
            this.RdbDecodeModeA.Text = "A精细模式";
            this.RdbDecodeModeA.UseVisualStyleBackColor = true;
            this.RdbDecodeModeA.CheckedChanged += new System.EventHandler(RdbDecodeModeA_CheckedChanged);
            this.BtnSaveCurrentCfg.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.BtnSaveCurrentCfg.Location = new System.Drawing.Point(1056, 54);
            this.BtnSaveCurrentCfg.Name = "BtnSaveCurrentCfg";
            this.BtnSaveCurrentCfg.Size = new System.Drawing.Size(120, 35);
            this.BtnSaveCurrentCfg.TabIndex = 8;
            this.BtnSaveCurrentCfg.Text = "保存配置到设备";
            this.BtnSaveCurrentCfg.UseVisualStyleBackColor = true;
            this.BtnSaveCurrentCfg.Click += new System.EventHandler(BtnSaveCurrentCfg_BtnClick);
            this.BtnRestartDevice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.BtnRestartDevice.Location = new System.Drawing.Point(1179, 54);
            this.BtnRestartDevice.Name = "BtnRestartDevice";
            this.BtnRestartDevice.Size = new System.Drawing.Size(74, 35);
            this.BtnRestartDevice.TabIndex = 9;
            this.BtnRestartDevice.Text = "重启设备";
            this.BtnRestartDevice.UseVisualStyleBackColor = true;
            this.BtnRestartDevice.Click += new System.EventHandler(BtnRestartDevice_BtnClick);
            base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 14f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            base.ClientSize = new System.Drawing.Size(1264, 761);
            base.Controls.Add(this.BtnRestartDevice);
            base.Controls.Add(this.BtnSaveCurrentCfg);
            base.Controls.Add(this.PanDecMode);
            base.Controls.Add(this.MainContainer);
            base.Controls.Add(this.MenuTopMain);
            base.Controls.Add(this.ToolStrip_Icon);
            this.Font = new System.Drawing.Font("宋体", 10.5f);
            base.MainMenuStrip = this.MenuTopMain;
            base.Name = "MainForm";
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "合杰读码调试工具V8.08";
            base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(MainForm_FormClosing);
            base.Load += new System.EventHandler(MainForm_Load);
            this.MenuTopMain.ResumeLayout(false);
            this.MenuTopMain.PerformLayout();
            this.ToolStrip_Icon.ResumeLayout(false);
            this.ToolStrip_Icon.PerformLayout();
            this.MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.MainContainer).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.PanDecMode.ResumeLayout(false);
            this.PanDecMode.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();

        }

        #endregion
    }
}