using BeeCore;
using BeeUi.Commons;
using BeeUi.Tool;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace BeeUi.Common
{
    [Serializable()]
    public partial class StepEdit : UserControl
    {

        public StepEdit()
        {
            InitializeComponent();
            this.Visible = false;



        }
        public void ButtonRadius(Control control, int radius)
        {
        }
        public void Load1()
        {
          
           
        }
        
        private void StepEdit_Load(object sender, EventArgs e)
        {
         //   G.StepEdit = this;
        }
       public SettingStep2 SettingStep2 ;
        public SettingStep1 SettingStep1;
        private void btnStep2_Click(object sender, EventArgs e)
        {
            G.IsCalib = false;
            if (SettingStep2==null)
            SettingStep2 = new SettingStep2();
            G.EditTool.pEditTool.Controls.Clear();
                SettingStep2 = new SettingStep2();
                SettingStep2.Parent = G.EditTool.pEditTool;
                SettingStep2.Dock = DockStyle.Fill;
            G.EditTool.lbNumStep.Text = "Step 2";
            G.EditTool.lbNameStep.Text = "Master Resgistration";
            G.EditTool.iconTool.BackgroundImage = Properties.Resources._2;
            G.EditTool.lbTool.Text = "Vui lòng chọn Ảnh mãu";

        }

        public dynamic LoadEidtGuiTool(TypeTool typeTool)
        {
            dynamic control = null;
            switch (typeTool)
            {
                case TypeTool.OutLine:

                    control = new ToolOutLine();

                    break;
                case TypeTool.Color_Area:
                    control = new ToolColorArea();
                    break;
                case TypeTool.Pattern:
                    control = new ToolPattern();
                    break;
                case TypeTool.Position_Adjustment:
                    control = new ToolPosition_Adjustment();

                    break;
                case TypeTool.Edge_Pixels:
                    control = new ToolEdgePixels();
                    break;
                default:
                    control = new ToolOutLine();
                    break;
            }
            return control;
        }

        
        bool IsLoaded = false;
        private void btnStep3_Click(object sender, EventArgs e)
        {
            ///SettingStep2.Visible = false;
            G.IsCalib = false;
            G.Header.LoadProg("Program\\"+Properties.Settings.Default.programCurrent);
           
            G.EditTool.lbNumStep.Text = "Step 3";
            G.EditTool.lbNameStep.Text = "Tool Setting";
            G.EditTool.iconTool.BackgroundImage = Properties.Resources._3;
            G.EditTool.lbTool.Text =  " Thêm tool và cài đặt thông số Tool";
        }

        private void btnStep1_Click(object sender, EventArgs e)
        {
        
            if (SettingStep1 == null)
                SettingStep1 = new SettingStep1();
         
          
            G.EditTool.pEditTool.Controls.Clear();
            SettingStep1 = new SettingStep1();
            SettingStep1.Parent = G.EditTool.pEditTool;
            SettingStep1.Dock = DockStyle.Fill;
            G.EditTool.lbNumStep.Text = "Step 1";
            G.EditTool.lbNameStep.Text = "Image Optimization";
            G.EditTool.iconTool.BackgroundImage = Properties.Resources._1;
            G.EditTool.lbTool.Text = "Setup Camera";
            if (!workConnect.IsBusy)
            workConnect.RunWorkerAsync();
        }

        private void workConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            G.IsCCD = true;//  BeeCore.Common.ConnectCCD(0);
          
        }

        private void workConnect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (G.IsCCD)
            {
             

                G.EditTool.View.imgView.Image = BeeCore.Common.GetImageRaw().ToBitmap();
                //G.Header.LoadProg("Program\\" + Properties.Settings.Default.programCurrent);


                SettingStep1.btnNextStep.Enabled=true;
            }
        
        }

        private void StepEdit_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible==true)
            {
                btnStep1.PerformClick();
            }
            else
            {
                if(G.Header!=null)
                G.Header.LoadProg("Program\\" + Properties.Settings.Default.programCurrent);
            }
        }
      public  SettingStep4 SettingStep4;
        private void btnStep4_Click(object sender, EventArgs e)
        {
            G.IsCalib = false;
            if (SettingStep4 == null)
                SettingStep4 = new SettingStep4();
            G.EditTool.pEditTool.Controls.Clear();
            SettingStep4 = new SettingStep4();
            SettingStep4.Parent = G.EditTool.pEditTool;
            SettingStep4.Dock = DockStyle.Fill;
            G.EditTool.lbNumStep.Text = "Step 4";
            G.EditTool.lbNameStep.Text = "Output Assignment";
            G.EditTool.iconTool.BackgroundImage = Properties.Resources._4;
            G.EditTool.lbTool.Text = "Setup Status OutPut";

        }

        private void btnSaveProgram_Click(object sender, EventArgs e)
        {
            
            G.Header.btnMode.PerformClick();
            G.Header.btnSave.PerformClick();
        }
    }
}
