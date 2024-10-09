﻿using BeeCore;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeUi.Tool
{
    [Serializable()]
    public partial class SettingStep2 : UserControl
    {
        public SettingStep2()
        {
            InitializeComponent();
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (File.Exists("Register.png"))
                File.Delete("Register.png");
            Cv2.ImWrite("Register.png", BeeCore.Common.matRaw);
            G.StepEdit.SettingStep2.Parent.Controls.Remove(G.StepEdit.SettingStep2);
            G.StepEdit.btnStep3.PerformClick();
        }

        private void SettingStep2_Load(object sender, EventArgs e)
        {
            if (G.EditTool.View == null)
            {
                G.EditTool.View = new View();
                G.EditTool.View.Dock = DockStyle.Fill;
                G.EditTool.View.Parent = G.EditTool.pView;

            }

        }
       
        private void btnLoadImge_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                G.EditTool.View. pathRaw = fileDialog.FileName;
              BeeCore.Common.matRaw = BeeCore.Common.LoadImage(G.EditTool.View.pathRaw, ImreadModes.AnyColor);
                G.Config.matRegister = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(BeeCore.Common.matRaw);

                G.EditTool.View.matMaskAdd = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1);
                G.EditTool.View.matTemp = new Mat(); G.EditTool.View.matCrop = new Mat();
                G.EditTool.View.bmMask = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1);
                G.EditTool.View.matMaskAdd = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1);
                G.EditTool.View.matResgiter = BeeCore.Common.matRaw.Clone();
                btnNextStep.Enabled = true;
                G.EditTool.View.imgView.Image = BeeCore.Common.matRaw.ToBitmap();
                btnNextStep.BackgroundImage = Properties.Resources.btnChoose;
               
            

            }
        }

        private void btnCapCamera_Click(object sender, EventArgs e)
        {
            if (!workRead.IsBusy)
                workRead.RunWorkerAsync();
            tmNotPress.Enabled = true;


        }

        private void workRead_DoWork(object sender, DoWorkEventArgs e)
        {
            BeeCore.Common.ReadCCD(G.Config.IsHist, G.Config.TypeCamera);
         


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
            G.EditTool.View.imgView.Image = BeeCore.Common.matRaw.ToBitmap();
            btnNextStep.BackgroundImage = Properties.Resources.btnChoose;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            G.Header.btnMode.PerformClick();
        }

        private void tmNotPress_Tick(object sender, EventArgs e)
        {
            btnCapCamera.IsCLick =!btnCapCamera.IsCLick;
            tmNotPress.Enabled = false;
        }
    }
}
