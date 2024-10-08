using BeeCore;
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

namespace BeeUi.Tool
{
   
    [Serializable()]
    public partial class SettingStep1 : UserControl
    {
   
        public SettingStep1()
        {
            InitializeComponent();
            btnNextStep.Enabled = false;
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (File.Exists("Default.config"))
                File.Delete("Default.config");
            Access.SaveConfig("Default.config", G.Config);
            btnNextStep.Enabled = false;
            this.Parent.Controls.Remove(this);
            if (btnLive.IsCLick)
                btnLive.PerformClick();
            G.StepEdit.btnStep2.PerformClick();

        }

        private void SettingStep2_Load(object sender, EventArgs e)
        {
            
            if (G.EditTool.View == null)
            {
                G.EditTool.View = new View();
                G.EditTool.View.Dock = DockStyle.Fill;
                G.EditTool.View.Parent = G.EditTool.pView;

            }
            G.EditTool.View.btnCalib.Enabled = false;
            G.EditTool.View.btnTest.Enabled = false;
            btnShowGrid.IsCLick = G.Config.IsShowGird ;
            btnShowCenter.IsCLick = G.Config.IsShowCenter;
            btnShowArea.IsCLick = G.Config.IsShowArea;
          
            btnEqubtnalize.IsCLick = G.Config.IsHist ;
        }
       
        private void btnLoadImge_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                G.EditTool.View. pathRaw = fileDialog.FileName;
              BeeCore.Common.matRaw = BeeCore.Common.LoadImage(G.EditTool.View.pathRaw, ImreadModes.AnyColor);
                G.EditTool.View.matRes = BeeCore.Common.matRaw.Clone();
              
                 G.EditTool.View.matTemp = new Mat(); G.EditTool.View.matCrop = new Mat();
                G.EditTool.View.bmMask = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1);
                G.EditTool.View.matMaskAdd = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1);

                G.EditTool.View.imgView.ImageIpl = BeeCore.Common.matRaw;

                G.EditTool.View.imgView.Invalidate();
                btnNextStep.Enabled = true;
                btnNextStep.BackgroundImage = Properties.Resources.btnChoose;

            

            }
        }

        private void btnCapCamera_Click(object sender, EventArgs e)
        {
            if (!workRead.IsBusy)
                workRead.RunWorkerAsync();



        }

        private void workRead_DoWork(object sender, DoWorkEventArgs e)
        {
            BeeCore.Common.ReadCCD(G.Config.IsHist,G.Config.TypeCamera);
         


        }

        private void workRead_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BeeCore.Common.matRaw = BeeCore.Common.GetImageRaw();
            G.Config.matRegister = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(BeeCore.Common.matRaw);
         
            G.EditTool.View.matMaskAdd = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1);
            G.EditTool.View.matTemp = new Mat(); G.EditTool.View.matCrop = new Mat();
            G.EditTool.View.bmMask = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1);
            G.EditTool.View.matMaskAdd = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1);
            G.EditTool.View.matResgiter = BeeCore.Common.matRaw.Clone();
            btnNextStep.Enabled = true;
            G.EditTool.View.imgView.ImageIpl = BeeCore.Common.matRaw;
            btnNextStep.BackgroundImage = Properties.Resources.btnChoose;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            G.Header.btnMode.PerformClick();
        }
        public int indexTool;
   

        private void btnEqualize_Click(object sender, EventArgs e)
        {
            G.Config.IsHist  = btnEqubtnalize.IsCLick;

            if (File.Exists("Default.config"))
                File.Delete("Default.config");
            Access.SaveConfig("Default.config", G.Config);
            BeeCore.Common.ReadCCD(G.Config.IsHist, G.Config.TypeCamera);
            BeeCore.Common.matRaw= BeeCore.Common.GetImageRaw();
            G.EditTool.View.imgView.ImageIpl= BeeCore.Common.matRaw;
        }
        public void PressLive()
        {
            if (btnCalib.IsCLick) btnCalib.PerformClick();
            G.EditTool.View.btnLive.Enabled = true;

            G.EditTool.View.btnLive.PerformClick();
            if (btnLive.IsCLick)
                G.EditTool.View.btnLive.Enabled = false;
            else
                G.EditTool.View.btnLive.Enabled = true;
        }
        private void btnLive_Click(object sender, EventArgs e)
        {
            PressLive();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            G.EditTool.View.btnShowSetting.PerformClick();
        }

     

        private void trackScoreErr_Load(object sender, EventArgs e)
        {

        }

       

        private void btnShowGrid_Click(object sender, EventArgs e)
        {
            G.Config.IsShowGird = btnShowGrid.IsCLick;
            G.EditTool.View.imgView.Invalidate();
        }

        private void btnShowCenter_Click(object sender, EventArgs e)
        {
            G.Config.IsShowCenter = btnShowCenter.IsCLick;
            G.EditTool.View.imgView.Invalidate();
        }

        private void btnShowArea_Click(object sender, EventArgs e)
        {
            G.Config.IsShowArea = btnShowArea.IsCLick;
            G.EditTool.View.imgView.Invalidate();
        }

        private void SettingStep1_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                G.Config.IsShowCenter = false;
                G.Config.IsShowArea = false;
                G.Config.IsShowGird = false;
                G.EditTool.View.imgView.Invalidate();
                if (btnLive.IsCLick)
                {
                    btnLive.IsCLick = false; PressLive();
                }
            }
                   
        }
        FormCalib formCalib;
        private void btnCalib_Click(object sender, EventArgs e)
        {
            if(btnCalib.IsCLick)
            {
                if (formCalib != null)
                    formCalib.Close();

                formCalib = new FormCalib();
                formCalib.Show();
            }    
            else
            {
                if(formCalib!=null)
                formCalib.Close();
            }    
        }
    }
}
