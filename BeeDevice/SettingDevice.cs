using Heroje_Debug_Tool.BaseClass;
using Heroje_Debug_Tool.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Heroje_Debug_Tool.SubForm.DeviceSettingForm;

namespace BeeDevice
{
    public partial class SettingDevice : Form
    {
        public SettingDevice()
        {
            InitializeComponent();
        }
		private ReadingForm.SetControlsValueCB SetControlsValueFuncCB;
		private int ExpRatioVal = 0;

		public bool anti_re_in = false;

		private int exp_value_val;

		private int SenGainVal = 0;

		private int FocusVal = 0;
		private SetCfgCB SetCfgCBFuncCB;
		private SendCfgDataCB SendCfgDataCBFuncCB;
		


		public delegate void CameraSetFormActionCB(ImageRoiActionNum num);

		private CameraSetFormActionCB CameraSetFormActionCBFunc;
		public void SetCBFunc(SetCfgCB setCfgCB, GetCfgCB getCfgCB, SendCfgDataCB sendCfgDataCB, ReadingForm.SetControlsValueCB setControlsValueCB, CameraSetFormActionCB imageRoiActionCB)
		{
			SetCfgCBFuncCB = setCfgCB;
			GetCfgCBFuncCB = getCfgCB;
			SendCfgDataCBFuncCB = sendCfgDataCB;
			SetControlsValueFuncCB = setControlsValueCB;
			CameraSetFormActionCBFunc = imageRoiActionCB;
		}


		private void CheckAutoExp_CheckedChanged(object sender, EventArgs e)
        {
			if (!ToolCfg.UpdateAdjState)
			{
				anti_re_in = true;
				if (CheckAutoExp.Checked)
				{
					//SetControlsValueFuncCB(ReadingForm.SetControlsValDef.SetExposure, 0, "");
					ExpRatioVal = 0;
				}
				else
				{
					ExpRatioVal = 1;
				}
				//SetControlsValueFuncCB(ReadingForm.SetControlsValDef.SetExposure, ExpRatioVal, "");
				SetCfgCBFuncCB(4607u, (ushort)ExpRatioVal);
				SendCfgDataCBFuncCB(128u);
			}
		}
		public LightingForm LightingPage = new LightingForm();

		public ImageProcessingForm ImageProcessingPage = new ImageProcessingForm();

		public BarcodeTypeForm BarcodeTypePage = new BarcodeTypeForm();

		public TemplateSettingForm TemplateSettingPage = new TemplateSettingForm();
		private TrackBar TrbHDR_LightExp;

		private TabPage Tp_Lighting;

		private TabPage Tp_ImageProcess;

		private TabPage Tp_BarcodeType;

		private TabPage Tp_Template;
		private GetCfgCB GetCfgCBFuncCB;
		private void SettingDevice_Load(object sender, EventArgs e)
        {
			ToolCfg.UpdateAdjState = false;
		trackExposure.Value=Convert.ToInt32(GetCfgCBFuncCB(4607u).ToString());
		}

        private void trackExposure_Scroll(object sender, EventArgs e)
        {
			ExpRatioVal = trackExposure.Value;
			
				SetControlsValueFuncCB(ReadingForm.SetControlsValDef.SetExposure, ExpRatioVal, "");
				if (!ToolCfg.UpdateAdjState)
				{
					SetCfgCBFuncCB(4607u, (ushort)ExpRatioVal);
					SendCfgDataCBFuncCB(128u);
				}
			
		}
    }
}
