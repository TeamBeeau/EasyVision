using BeeDevice.Properties;
using Heroje_Debug_Tool.BaseClass;
using Heroje_Debug_Tool.SubForm;
using IniConfigFile_n;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using 合杰图像算法调试工具;
using 图像算法调试工具;

namespace BeeDevice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
		private SetCfgCB SetCfgCBFunc;








		public void LoadCamera()
        {
			AddSubPages();
			SetPagesCallBackFunction();
			Pages_Init();
			SetUiSplitDistance();
			base.WindowState = FormWindowState.Maximized;
			SetUiSplitDistance();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (ToolCfg.ThisSoftware == ToolCfg.SoftwareDef.Heroje_Standard)
			{
				Text = "合杰读码调试工具" + ToolCfg.VersionInfo;
				//base.Icon = Resources.logoIcon;
				//StartForm startForm = new StartForm();
				//startForm.Show();
				DateTime now = DateTime.Now;
				AddSubPages();
				SetPagesCallBackFunction();
				Pages_Init();
				
			}
			else if (ToolCfg.ThisSoftware == ToolCfg.SoftwareDef.Hide_Heroje_Logo)
			{
				Text = "读码调试工具" + ToolCfg.VersionInfo;
				AddSubPages();
				SetPagesCallBackFunction();
				Pages_Init();
			}
			SetUiSplitDistance();
			base.WindowState = FormWindowState.Maximized;
			SetUiSplitDistance();
			this.Hide();
		}

		private void AddSubPages()
		{
			DeviceConnectPage = new DeviceConnectForm();
			DeviceConnectPage.TopLevel = false;
			DeviceConnectPage.FormBorderStyle = FormBorderStyle.None;
			DeviceConnectPage.Height = MainContainer.Panel1.Height;
			DeviceConnectPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			DeviceConnectPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			MainContainer.Panel1.Controls.Add(DeviceConnectPage);
			DeviceConnectPage.Show();
			ReadingPage = new ReadingForm();
			ReadingPage.TopLevel = false;
			ReadingPage.FormBorderStyle = FormBorderStyle.None;
			ReadingPage.Dock = DockStyle.Fill;
			AddPage(ReadingPage, "读取");
			ReadingPage.DeviceSettingPage.Owner = this;
			CommunicateSettingPage = new CommunicateSettingForm();
			CommunicateSettingPage.TopLevel = false;
			CommunicateSettingPage.FormBorderStyle = FormBorderStyle.None;
			AddPage(CommunicateSettingPage, "通讯协议");
			DataEditPage = new DataEditForm();
			DataEditPage.TopLevel = false;
			DataEditPage.FormBorderStyle = FormBorderStyle.None;
			AddPage(DataEditPage, "数据编辑");
			IOInstructionPage = new IOInstructionForm();
			IOInstructionPage.TopLevel = false;
			IOInstructionPage.FormBorderStyle = FormBorderStyle.None;
			AddPage(IOInstructionPage, "IO指令");
			AlgorithmProtocolPage = new AlgorithmProtocolForm();
			AlgorithmProtocolPage.TopLevel = false;
			AlgorithmProtocolPage.FormBorderStyle = FormBorderStyle.None;
			AddPage(AlgorithmProtocolPage, "算法协议");
			ImageSaveSettingPage = new ImageSaveSettingForm();
			ImageSaveSettingPage.TopLevel = false;
			ImageSaveSettingPage.FormBorderStyle = FormBorderStyle.None;
			AddPage(ImageSaveSettingPage, "图像保存");
			OthersSettingPage = new OthersSettingForm();
			OthersSettingPage.TopLevel = false;
			OthersSettingPage.FormBorderStyle = FormBorderStyle.None;
			AddPage(OthersSettingPage, "其他");
			AdvancedSettingPage = new AdvancedSettingForm();
			AdvancedSettingPage.TopLevel = false;
			AdvancedSettingPage.FormBorderStyle = FormBorderStyle.None;
			AddPage(AdvancedSettingPage, "高级功能");
		}

		private void SetPagesCallBackFunction()
		{
			SetCfgCBFunc = DeviceConnectPage.SetPara;
			GetCfgCBFunc = DeviceConnectPage.GetPara;
			SendCfgDataCBFunc = DeviceConnectPage.DeviceConfigDataSend;
			DeviceConnectPage.SetCBFunc(UpdateParaAndDisplayCBFunc, ReadingPage.ReadingPage_Update, AdvancedSettingPage.AdvancedPage_Update);
			DeviceConnectPage.DevStateCallback = DevStateCB_Func;
			//ReadingPage.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc);
			//DataEditPage.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc);
			//IOInstructionPage.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc);
			//AlgorithmProtocolPage.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc, SetDecModeValueFuncCB);
			//CommunicateSettingPage.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc);
		//	ReadingPage.DeviceSettingPage.TemplateSettingPage.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, Temp_Setting_Page_SendDataCB, Template_Get_Show, TemplatePage_Draw_ROI_CB);
			//AdvancedSettingPage.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc);
			//ImageSaveSettingPage.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc);
			//OthersSettingPage.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc);
		//	ToolCfg.DeviceIPSettingPage = new FormDeviceIP(GetCfgCBFunc, DeviceConnectPage.ChangeIpByBrocast);
		}

		private bool Temp_Setting_Page_SendDataCB(uint action)
		{
			bool result = SendCfgDataCBFunc(action);
			if (action == 32768)
			{
				ReadingPage.UpdateTemplateRoiList();
			}
			return result;
		}

		private void AddPage(Control page, string pageName)
		{
			TabPage tabPage = new TabPage(pageName);
			tabPage.BorderStyle = BorderStyle.FixedSingle;
			tabPage.BackColor = Color.White;
			tabPage.Controls.Add(page);
			TabSetting.TabPages.Add(tabPage);
			page.Show();
			PageList.Add(tabPage);
		}

		private void UpdateParaAndDisplayCBFunc(UiParaInfoStu para)
		{
			IOInstructionPage.ShowTriggerStr();
			if (para.UpdateAdjState)
			{
				ReadingPage.UpdateUiDisplay(para);
				DataEditPage.UpdateUiDisplay(para);
				IOInstructionPage.UpdateUiDisplay(para);
				AlgorithmProtocolPage.UpdateUiDisplay(para);
				CommunicateSettingPage.UpdateUiDisplay(para);
				ReadingPage.DeviceSettingPage.TemplateSettingPage.UpdateUiDisplay(para);
				AdvancedSettingPage.UpdateUiDisplay(para);
				ImageSaveSettingPage.UpdateUiDisplay(para);
				if (para.ParaDataLen >= 4096)
				{
					RdbDecodeModeA.Visible = true;
					RdbDecodeModeB.Visible = true;
					RdbDecodeModeC.Visible = true;
				}
				else
				{
					RdbDecodeModeA.Visible = false;
					RdbDecodeModeB.Visible = false;
					RdbDecodeModeC.Visible = false;
				}
				DeviceNameTemp = para.DeviceName;
				DevCapacityArr = DeviceCapacity.GetCapacityInfo((byte)para.DeviceTypeRecord, para.ConnectType, DeviceNameTemp);
				TSM_UpgradeFirmware.Enabled = DevCapacityArr.IsNetworkDevice;
				ReadingPage.FunctionOnOff(DevCapacityArr.CapacityArr, DeviceNameTemp);
				CommunicateSettingPage.FunctionOnOff(DevCapacityArr.CapacityArr);
				ImageSaveSettingPage.FunctionOnOff(DevCapacityArr.CapacityArr);
				OthersSettingPage.Enabled = DevCapacityArr.CapacityArr[21];
				AdvancedSettingPage.FunctionOnOff(DevCapacityArr.CapacityArr);
			}
		}

		private void Pages_Init()
		{
			AddLanguageMenuItem();
			UpdateLanguageUI();
			DeviceConnectPage.Page_Init();
			ReadingPage.Page_Init();
		}

		private void AddLanguageMenuItem()
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath);
			FileInfo[] files = directoryInfo.GetFiles("*.xml");
			List<FileInfo> list = new List<FileInfo>();
			list.AddRange(files);
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Name.Contains("dpmcmd"))
				{
					list.Remove(list[i]);
					i--;
				}
			}
			FileInfo[] array = list.ToArray();
			FileInfo[] array2 = array;
			foreach (FileInfo fileInfo in array2)
			{
				if (fileInfo.Name.Contains("ChineseS"))
				{
					AddContextMenu("简体中文", TsmTop_Language.DropDownItems, MenuClicked);
				}
				else if (fileInfo.Name.Contains("ChineseT"))
				{
					AddContextMenu("繁體中文", TsmTop_Language.DropDownItems, MenuClicked);
				}
				else
				{
					AddContextMenu(fileInfo.Name.Substring(0, fileInfo.Name.Length - 4), TsmTop_Language.DropDownItems, MenuClicked);
				}
			}
			if (array.Length == 0)
			{
				FileStream fileStream = File.Create(ToolCfg.ConfigPath);
				fileStream.Flush();
				fileStream.Close();
				ControlAndXML controlAndXML = new ControlAndXML();
				controlAndXML.MainControlToXmlByLinq(new MainForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new DeviceConnectForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new ReadingForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new LightingForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new BarcodeTypeForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new DataEditForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new IOInstructionForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new ImageProcessingForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new AlgorithmProtocolForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new CommunicateSettingForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new TemplateSettingForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new AdvancedSettingForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new ImageSaveSettingForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new OthersSettingForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new DeviceSettingForm(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new CMD_Tool(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new ComDebugTool(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new ConfigBarcodeCheck(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new DriverInstall(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new FormNet(), ToolCfg.ConfigPath);
				controlAndXML.SubControlToXmlByLinq(new FormDeviceIP(), ToolCfg.ConfigPath);
				AddContextMenu("简体中文", TsmTop_Language.DropDownItems, MenuClicked);
				controlAndXML.AddTextToXml(MultLanguageText.CurLanguageCfg, ToolCfg.ConfigPath);
				return;
			}
			try
			{
				try
				{
					IniConfigFile iniConfigFile = new IniConfigFile();
					iniConfigFile.Config("config.ini");
					ToolCfg.ConfigPath = iniConfigFile.get("Language") + ".xml";
				}
				catch (Exception)
				{
				}
				SwitchLanguage(ToolCfg.ConfigPath);
			}
			catch (Exception ex2)
			{
				if (ToolCfg.ConfigPath.Contains("ChineseS"))
				{
					MessageBox.Show("程序运行需要的" + ToolCfg.ConfigPath + "配置文件格式不正确，导致程序不能正常运行。\r\n可以删掉程序目录下的" + ToolCfg.ConfigPath + "文件重试\r\n错误信息：\r\n" + ex2.Message, "错误");
				}
				else if (ToolCfg.ConfigPath.Contains("ChineseT"))
				{
					MessageBox.Show("軟體運行需要的" + ToolCfg.ConfigPath + "配置文件格式不正確，導致軟體不能正常運行。\r\n可以刪掉軟體目錄下的" + ToolCfg.ConfigPath + "文件重試\r\n錯誤信息：\r\n" + ex2.Message, "錯誤");
				}
				else
				{
					MessageBox.Show("Software important file:" + ToolCfg.ConfigPath + " which format is not match ，software will exit after press enter key.\r\nyou can delect " + ToolCfg.ConfigPath + "file in software directory and retryError Message:\r\n" + ex2.Message, "ERROR");
				}
			}
		}

		private void SwitchLanguage(string XmlPath)
		{
			ControlAndXML controlAndXML = new ControlAndXML();
			controlAndXML.XMLToControlByLinq(XmlPath, this);
			Text += ToolCfg.VersionInfo;
			controlAndXML.XMLToControlByLinq(XmlPath, DeviceConnectPage);
			controlAndXML.XMLToControlByLinq(XmlPath, ReadingPage);
			controlAndXML.XMLToControlByLinq(XmlPath, ReadingPage.DeviceSettingPage.LightingPage);
			controlAndXML.XMLToControlByLinq(XmlPath, ReadingPage.DeviceSettingPage.BarcodeTypePage);
			controlAndXML.XMLToControlByLinq(XmlPath, DataEditPage);
			controlAndXML.XMLToControlByLinq(XmlPath, IOInstructionPage);
			controlAndXML.XMLToControlByLinq(XmlPath, ReadingPage.DeviceSettingPage.ImageProcessingPage);
			controlAndXML.XMLToControlByLinq(XmlPath, AlgorithmProtocolPage);
			controlAndXML.XMLToControlByLinq(XmlPath, CommunicateSettingPage);
			controlAndXML.XMLToControlByLinq(XmlPath, ReadingPage.DeviceSettingPage.TemplateSettingPage);
			controlAndXML.XMLToControlByLinq(XmlPath, AdvancedSettingPage);
			controlAndXML.XMLToControlByLinq(XmlPath, ImageSaveSettingPage);
			controlAndXML.XMLToControlByLinq(XmlPath, OthersSettingPage);
			controlAndXML.XMLToControlByLinq(XmlPath, ReadingPage.DeviceSettingPage);
			controlAndXML.XMLToControlByLinq(XmlPath, ToolCfg.FormCMD_Tool);
			controlAndXML.XMLToControlByLinq(XmlPath, ComDebugToolForm);
			controlAndXML.XMLToControlByLinq(XmlPath, ToolCfg.ConfigBarcodeCheckForm);
			controlAndXML.XMLToControlByLinq(XmlPath, DeviceConnectPage.DriverInstallForm);
			controlAndXML.XMLToControlByLinq(XmlPath, FormNetTools);
			controlAndXML.XMLToControlByLinq(XmlPath, ToolCfg.DeviceIPSettingPage);
			MultLanguageText.SetCurLanguageText(controlAndXML.ReadMsgTextInfoFromXml(XmlPath));
			if (DevCapacityArr.CapacityArr == null)
			{
				DevCapacityArr.CapacityArr = new bool[64];
			}
			if (DeviceNameTemp == null)
			{
				DeviceNameTemp = "";
			}
			ReadingPage.DeviceSettingPage.LightingPage.FunctionOnOff(DevCapacityArr.CapacityArr, DeviceNameTemp);
			try
			{
				if (ToolCfg.ConfigPath.Contains("ChineseS"))
				{
					for (int i = 0; i < PageList.Count; i++)
					{
						PageList[i].Text = PageName_C[i];
					}
				}
				else if (ToolCfg.ConfigPath.Contains("ChineseT"))
				{
					for (int j = 0; j < PageList.Count; j++)
					{
						PageList[j].Text = PageName_T[j];
					}
				}
				else
				{
					for (int k = 0; k < PageList.Count; k++)
					{
						PageList[k].Text = PageName_E[k];
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private ToolStripMenuItem AddContextMenu(string text, ToolStripItemCollection cms, EventHandler callback)
		{
			if (text == "-")
			{
				ToolStripSeparator value = new ToolStripSeparator();
				cms.Add(value);
				return null;
			}
			if (!string.IsNullOrEmpty(text))
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(text);
				int num = 169;
				toolStripMenuItem.BackColor = Color.FromArgb(num, num, num);
				toolStripMenuItem.ForeColor = Color.Black;
				if (callback != null)
				{
					toolStripMenuItem.Click += callback;
				}
				cms.Add(toolStripMenuItem);
				return toolStripMenuItem;
			}
			return null;
		}

		private void MenuClicked(object sender, EventArgs e)
		{
			if ((sender as ToolStripMenuItem).Text.Contains("简体中文"))
			{
				ToolCfg.ConfigPath = "ChineseS.xml";
			}
			else if ((sender as ToolStripMenuItem).Text.Contains("繁體中文"))
			{
				ToolCfg.ConfigPath = "ChineseT.xml";
			}
			else
			{
				ToolCfg.ConfigPath = (sender as ToolStripMenuItem).Text.Substring(0, (sender as ToolStripMenuItem).Text.Length) + ".xml";
			}
			try
			{
				IniConfigFile iniConfigFile = new IniConfigFile();
				iniConfigFile.Config("config.ini");
				iniConfigFile.set("Language", ToolCfg.ConfigPath.Substring(0, ToolCfg.ConfigPath.Length - 4));
				iniConfigFile.save();
				SwitchLanguage(ToolCfg.ConfigPath);
				UpdateLanguageUI();
			}
			catch (Exception ex)
			{
				if (ToolCfg.ConfigPath.Contains("ChineseS"))
				{
					MessageBox.Show("程序运行需要的" + ToolCfg.ConfigPath + "配置文件格式不正确，导致程序不能正常运行。\r\n可以删掉程序目录下的" + ToolCfg.ConfigPath + "文件重试\r\n错误信息：\r\n" + ex.Message, "错误");
				}
				else if (ToolCfg.ConfigPath.Contains("ChineseT"))
				{
					MessageBox.Show("軟體運行需要的" + ToolCfg.ConfigPath + "配置文件格式不正確，導致軟體不能正常運行。\r\n可以刪掉軟體目錄下的" + ToolCfg.ConfigPath + "文件重試\r\n錯誤信息：\r\n" + ex.Message, "錯誤");
				}
				else
				{
					MessageBox.Show("Software important file:" + ToolCfg.ConfigPath + " which format is not match ，software will exit after press enter key.\r\nyou can delect " + ToolCfg.ConfigPath + "file in software directory and retryError Message:\r\n" + ex.Message, "ERROR");
				}
			}
		}

		private void UpdateLanguageUI()
		{
			DeviceConnectPage.UpdateLanguageUI();
			ReadingPage.UpdateLanguageUI();
			IOInstructionPage.UpdateLanguageUI();
			AlgorithmProtocolPage.UpdateLanguageUI();
			CommunicateSettingPage.UpdateLanguageUI();
			ReadingPage.DeviceSettingPage.TemplateSettingPage.UpdateLanguageUI();
			AdvancedSettingPage.UpdateLanguageUI();
			if (ToolCfg.ConfigPath.Contains("ChineseS") || ToolCfg.ConfigPath.Contains("ChineseT"))
			{
			}
			try
			{
				ToolCfg.UpdateAdjState = true;
				ToolCfg.SendReadBackCMD();
			}
			catch
			{
			}
		}

		private void ShowBootAnimation()
		{
			StartForm startForm = new StartForm();
			FormClosedTimer = new System.Timers.Timer(5000.0);
			FormClosedTimer.Elapsed += FormClosedTimer_Elapsed;
			FormClosedTimer.Start();
			startForm.Show();
			while (NeedWaiteStart)
			{
				Thread.Sleep(100);
				Application.DoEvents();
			}
			startForm.Close();
		}

		private void FormClosedTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			NeedWaiteStart = false;
			FormClosedTimer.Stop();
			FormClosedTimer.Dispose();
		}

		private void Template_Get_Show(ref template_config_t tmp, TemplateActionDef act)
		{
			switch (act)
			{
				case TemplateActionDef.Get_New_Template_Value:
					tmp.decode_config.decode_lib = AlgorithmProtocolPage.DecodeMode;
					tmp.decode_config.type_switch = ReadingPage.DeviceSettingPage.BarcodeTypePage.BarcodeSwitch;
					tmp.sensor_config.light_pwm1 = ReadingPage.DeviceSettingPage.LightingPage.Light_Pwm_1;
					tmp.sensor_config.light_pwm2 = ReadingPage.DeviceSettingPage.LightingPage.Light_Pwm_2;
					tmp.sensor_config.light_ctrl = ReadingPage.DeviceSettingPage.LightingPage.FarNearLight;
					tmp.sensor_config.exp_time = ReadingPage.TempExpVal;
					tmp.sensor_config.config_flag |= ReadingPage.ratio_value_cfg;
					tmp.sensor_config.gain_set = ReadingPage.TempGainVal;
					tmp.sensor_config.focus_set = ReadingPage.TempFocusVal;
					break;
				case TemplateActionDef.Show_New_Template_Value:
					if (((ulong)tmp.config_flag & 8uL) == 8)
					{
						bool flag = false;
						if (((ulong)tmp.sensor_config.config_flag & 2uL) == 2)
						{
							flag = true;
							ReadingPage.ratio_value_cfg = 2;
							ReadingPage.TempExpVal = tmp.sensor_config.exp_time;
						}
						else
						{
							ReadingPage.ratio_value_cfg = 32;
							ReadingPage.TempExpVal = tmp.sensor_config.exp_time;
						}
						if (((ulong)tmp.sensor_config.config_flag & 4uL) == 4)
						{
							flag = true;
							ReadingPage.TempGainVal = tmp.sensor_config.gain_set;
						}
						if (((ulong)tmp.sensor_config.config_flag & 1uL) == 1)
						{
							ReadingPage.DeviceSettingPage.LightingPage.Light_Pwm_1 = tmp.sensor_config.light_pwm1;
							ReadingPage.DeviceSettingPage.LightingPage.Light_Pwm_2 = tmp.sensor_config.light_pwm2;
						}
						if (((ulong)tmp.sensor_config.config_flag & 0x10uL) == 16)
						{
							ReadingPage.DeviceSettingPage.LightingPage.FarNearLight = tmp.sensor_config.light_ctrl;
						}
						if (((ulong)tmp.sensor_config.config_flag & 8uL) == 8)
						{
							ReadingPage.TempFocusVal = tmp.sensor_config.focus_set;
						}
					}
					if (((ulong)tmp.config_flag & 4uL) == 4)
					{
						if (tmp.decode_config.decode_lib == 1)
						{
							RdbDecodeModeA.Checked = true;
						}
						if (tmp.decode_config.decode_lib == 0)
						{
							RdbDecodeModeB.Checked = true;
						}
						if (tmp.decode_config.decode_lib == 2)
						{
							RdbDecodeModeC.Checked = true;
						}
						AlgorithmProtocolPage.DecodeMode = tmp.decode_config.decode_lib;
						ReadingPage.DeviceSettingPage.BarcodeTypePage.BarcodeSwitch = tmp.decode_config.type_switch;
					}
					break;
				case TemplateActionDef.Show_Old_Template_Value:
					ReadingPage.ratio_value_cfg = 2;
					ReadingPage.TempExpVal = tmp.sensor_config.exp_time;
					ReadingPage.TempGainVal = tmp.sensor_config.gain_set;
					ReadingPage.DeviceSettingPage.LightingPage.Light_Pwm_1 = tmp.sensor_config.light_pwm1;
					ReadingPage.DeviceSettingPage.LightingPage.Light_Pwm_2 = tmp.sensor_config.light_pwm2;
					break;
			}
		}

		private void SetDecModeValueFuncCB(ReadingForm.SetControlsValDef act, int val_1, string val_2)
		{
			switch (act)
			{
				case ReadingForm.SetControlsValDef.SetDecodeModeA:
					RdbDecodeModeA.Checked = true;
					break;
				case ReadingForm.SetControlsValDef.SetDecodeModeB:
					RdbDecodeModeB.Checked = true;
					break;
				case ReadingForm.SetControlsValDef.SetDecodeModeC:
					RdbDecodeModeC.Checked = true;
					break;
				case ReadingForm.SetControlsValDef.TrainCheck_Y:
					ChbUseTrainPara.Checked = true;
					break;
				case ReadingForm.SetControlsValDef.TrainCheck_N:
					ChbUseTrainPara.Checked = false;
					break;
				case ReadingForm.SetControlsValDef.BtnTrainTextChange:
					BtnDecodeCTraining.Text = val_2;
					break;
			}
		}

		private void RdbDecodeModeA_CheckedChanged(object sender, EventArgs e)
		{
			AlgorithmProtocolPage.SetDecodeMode(ReadingForm.SetControlsValDef.SetDecodeModeA);
			BtnDecodeCTraining.Visible = false;
			ChbUseTrainPara.Visible = false;
		}

		private void RdbDecodeModeB_CheckedChanged(object sender, EventArgs e)
		{
			AlgorithmProtocolPage.SetDecodeMode(ReadingForm.SetControlsValDef.SetDecodeModeB);
			BtnDecodeCTraining.Visible = false;
			ChbUseTrainPara.Visible = false;
		}

		private void RdbDecodeModeC_CheckedChanged(object sender, EventArgs e)
		{
			AlgorithmProtocolPage.SetDecodeMode(ReadingForm.SetControlsValDef.SetDecodeModeC);
			BtnDecodeCTraining.Visible = true;
			ChbUseTrainPara.Visible = true;
		}

		private void ChbUseTrainPara_CheckedChanged(object sender, EventArgs e)
		{
			if (ChbUseTrainPara.Checked)
			{
				AlgorithmProtocolPage.SetDecodeMode(ReadingForm.SetControlsValDef.TrainCheck_Y);
			}
			else
			{
				AlgorithmProtocolPage.SetDecodeMode(ReadingForm.SetControlsValDef.TrainCheck_N);
			}
		}

		private void BtnDecodeCTraining_Click(object sender, EventArgs e)
		{
			BtnDecodeCTraining.Text = AlgorithmProtocolPage.BtnDecodeCTraining_Click_Action();
		}

		private void SetUiSplitDistance()
		{
			try
			{
				IniConfigFile iniConfigFile = new IniConfigFile();
				iniConfigFile.Config("config.ini");
				//if (!iniConfigFile.get("ThisWindowState").Contains(base.WindowState.ToString()))
				//{
				//	return;
				//}
				int num = Convert.ToInt32(iniConfigFile.get("ThisScreenWidth"));
				if (num == Screen.PrimaryScreen.Bounds.Width)
				{
					int num2 = Convert.ToInt32(iniConfigFile.get("ThisScreenHeight"));
					if (num2 == Screen.PrimaryScreen.Bounds.Height)
					{
						MainContainer.SplitterDistance = Convert.ToInt32(iniConfigFile.get("SplitDisConnectPage"));
						ToolCfg.SplitDisReadingPage_h = Convert.ToInt32(iniConfigFile.get("SplitDisReadingPage_h"));
						ToolCfg.SplitDisReadingPage_v = Convert.ToInt32(iniConfigFile.get("SplitDisReadingPage_v"));
						ReadingPage.Set_SplitDistance_h_v(ToolCfg.SplitDisReadingPage_h, ToolCfg.SplitDisReadingPage_v);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private void SaveUiSplitDistance()
		{
			try
			{
				ToolCfg.ThisScreenWidth = Screen.PrimaryScreen.Bounds.Width;
				ToolCfg.ThisScreenHeight = Screen.PrimaryScreen.Bounds.Height;
				ToolCfg.SplitDisConnectPage = MainContainer.SplitterDistance;
				ReadingPage.Get_SplitDistance_h_v(ref ToolCfg.SplitDisReadingPage_h, ref ToolCfg.SplitDisReadingPage_v);
				IniConfigFile iniConfigFile = new IniConfigFile();
				iniConfigFile.Config("config.ini");
				iniConfigFile.set("ThisWindowState", base.WindowState.ToString());
				iniConfigFile.set("ThisScreenWidth", ToolCfg.ThisScreenWidth.ToString());
				iniConfigFile.set("ThisScreenHeight", ToolCfg.ThisScreenHeight.ToString());
				iniConfigFile.set("SplitDisConnectPage", ToolCfg.SplitDisConnectPage.ToString());
				iniConfigFile.set("SplitDisReadingPage_h", ToolCfg.SplitDisReadingPage_h.ToString());
				iniConfigFile.set("SplitDisReadingPage_v", ToolCfg.SplitDisReadingPage_v.ToString());
				iniConfigFile.save();
			}
			catch (Exception)
			{
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveUiSplitDistance();
			DeviceConnectPage.FormClosingDo(sender, e);
		}

		private void InstallUSBDrvToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeviceConnectPage.InstallUSBDrvTool(sender, e);
		}

		private void ComDebugToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ComDebugToolForm == null || ComDebugToolForm.IsDisposed)
			{
				ComDebugToolForm = new ComDebugTool();
				ComDebugToolForm.Show();
			}
			else
			{
				ComDebugToolForm.Show();
				ComDebugToolForm.Focus();
			}
		}

		private void NetworkDebugToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (FormNetTools == null || FormNetTools.IsDisposed)
			{
				FormNetTools = new FormNet();
				FormNetTools.Show();
			}
			else
			{
				FormNetTools.Show();
				FormNetTools.Activate();
			}
		}

		private void CmdCfgToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ToolCfg.FormCMD_Tool == null || ToolCfg.FormCMD_Tool.IsDisposed)
			{
				ToolCfg.FormCMD_Tool = new CMD_Tool();
				ToolCfg.FormCMD_Tool.SetCBFunc(GetCfgCBFunc);
				ToolCfg.FormCMD_Tool.Show();
			}
			else
			{
				ToolCfg.FormCMD_Tool.SetCBFunc(GetCfgCBFunc);
				ToolCfg.FormCMD_Tool.Show();
				ToolCfg.FormCMD_Tool.Focus();
			}
		}

		private void TSM_AboutSoftware_Click(object sender, EventArgs e)
		{
			AboutForm = new About();
			AboutForm.ShowDialog();
		}

		private void TSM_SoftwareCloseDo_Click(object sender, EventArgs e)
		{
			FormSetting = new SettingForm();
			FormSetting.ShowDialog();
		}

		private void TSM_FirmwareVersion_Click(object sender, EventArgs e)
		{
			//ShowFirmwareVerForm showFirmwareVerForm = new ShowFirmwareVerForm();
			//showFirmwareVerForm.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc);
			//showFirmwareVerForm.ShowDialog();
		}

		private void TSB_SaveCurrentCfg_Click(object sender, EventArgs e)
		{
			DeviceConnectPage.BtnSaveCurrentCfg_Click(null, null);
		}

		private void TSB_RestartDevice_Click(object sender, EventArgs e)
		{
			DeviceConnectPage.Tsm_RestartDevice_Click(null, null);
		}

		private void TsmTop_Tool_DropDownOpening(object sender, EventArgs e)
		{
			if (ToolCfg.ConfigPath.Contains("ChineseS"))
			{
				InstallUSBDrvToolStripMenuItem.Text = "安装USB驱动";
				Tsm_ComDebugTool.Text = "串口调试助手";
				Tsm_NetDebugTool.Text = "网口调试助手";
				Tsm_CmdConfigurationTool.Text = "命令配置工具";
			}
			else if (ToolCfg.ConfigPath.Contains("ChineseT"))
			{
				InstallUSBDrvToolStripMenuItem.Text = "安裝USB驅動";
				Tsm_ComDebugTool.Text = "串口調試助手";
				Tsm_NetDebugTool.Text = "網口調試助手";
				Tsm_CmdConfigurationTool.Text = "命令配置工具";
			}
			else
			{
				InstallUSBDrvToolStripMenuItem.Text = "Install USB Driver";
				Tsm_ComDebugTool.Text = "Serial Assistant";
				Tsm_NetDebugTool.Text = "Network Assistant";
				Tsm_CmdConfigurationTool.Text = "Command Configuration Tool";
			}
		}

		private void TsmTop_Disp_DropDownOpening(object sender, EventArgs e)
		{
			Tsm_ShowNetGrid.Checked = ToolCfg.IsDispNetGrid;
			if (ToolCfg.ConfigPath.Contains("ChineseS"))
			{
				Tsm_ShowNetGrid.Text = "显示标线";
			}
			else if (ToolCfg.ConfigPath.Contains("ChineseT"))
			{
				Tsm_ShowNetGrid.Text = "顯示標線";
			}
			else
			{
				Tsm_ShowNetGrid.Text = "Show Grid";
			}
		}

		private void Tsm_ShowNetGrid_Click(object sender, EventArgs e)
		{
			Tsm_ShowNetGrid.Checked = !Tsm_ShowNetGrid.Checked;
			ReadingPage.TSI_ShowNetGrid_Click(null, null);
		}

		private void TSB_SearchDevice_Click(object sender, EventArgs e)
		{
			TSB_SearchDevice.Enabled = false;
			DeviceConnectPage.Tsb_SearchDevice_Click(null, null);
			TSB_SearchDevice.Enabled = true;
		}

		private void TSB_ConnectDevice_Click(object sender, EventArgs e)
		{
			DeviceConnectPage.Tsb_ConnectDevice_Click(null, null);
		}

		private void TSB_DisconnectDevice_Click(object sender, EventArgs e)
		{
			DeviceConnectPage.Tsb_DisconnectDevice_Click(null, null);
		}

		private void TSB_OpenCfg_Click(object sender, EventArgs e)
		{
			DeviceConnectPage.Tsb_OpenCfg_Click(null, null);
		}

		private void TSB_SaveCfg_Click(object sender, EventArgs e)
		{
			DeviceConnectPage.Tsb_SaveCfg_Click(null, null);
		}

		private void TSM_UpgradeFirmware_Click(object sender, EventArgs e)
		{
			if (AdvancedSettingPage.CommunicationCheck())
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = ".bin|*.bin";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					AdvancedSettingPage.UploadFileToDevice(openFileDialog.FileName, true);
				}
			}
		}

		private void TSI_OpenCfg_Click(object sender, EventArgs e)
		{
			DeviceConnectPage.Tsb_OpenCfg_Click(null, null);
		}

		private void TSI_SaveCfg_Click(object sender, EventArgs e)
		{
			DeviceConnectPage.Tsb_SaveCfg_Click(null, null);
		}

		private void TSI_SaveCurrentImage_Click(object sender, EventArgs e)
		{
			ReadingPage.TSI_SaveCurrentImage_Click(null, null);
		}

		private void TemplatePage_Draw_ROI_CB(DeviceSettingForm.ImageRoiActionNum Act)
		{
			ReadingPage.ImageRoiActionCBFunc(Act);
		}

		private void BtnSaveCurrentCfg_BtnClick(object sender, EventArgs e)
		{
			DeviceConnectPage.BtnSaveCurrentCfg_Click(null, null);
		}

		private void BtnRestartDevice_BtnClick(object sender, EventArgs e)
		{
			DeviceConnectPage.Tsm_RestartDevice_Click(null, null);
		}

		private void DevStateCB_Func(DevStateDef a)
		{
			switch (a)
			{
				case DevStateDef.DevConnected:
					TSB_ConnectDevice.Enabled = false;
					TSB_DisconnectDevice.Enabled = true;
					break;
				case DevStateDef.DevDisConnnected:
					TSB_ConnectDevice.Enabled = true;
					TSB_DisconnectDevice.Enabled = false;
					break;
				case DevStateDef.BothDisenable:
					TSB_ConnectDevice.Enabled = false;
					TSB_DisconnectDevice.Enabled = false;
					break;
			}
		}

		private void Tsm_Regular_Barcode_Click(object sender, EventArgs e)
		{
			//RegularForm regularForm = new RegularForm();
			//regularForm.Regex_txt_path = regularForm.REGEX_BARCODE_STRING;
			//regularForm.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc, Tsm_Regular_Barcode.Text);
			//regularForm.ShowDialog();
		}

		private void Tsm_Regular_Output_Click(object sender, EventArgs e)
		{
			//RegularForm regularForm = new RegularForm();
			//regularForm.Regex_txt_path = regularForm.REGEX_OUTPUT_STRING;
		//	regularForm.SetCBFunc(SetCfgCBFunc, GetCfgCBFunc, SendCfgDataCBFunc, Tsm_Regular_Output.Text);
			//regularForm.ShowDialog();
		}
	}
}
