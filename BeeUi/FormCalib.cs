﻿using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace BeeUi
{
    public partial class FormCalib : Form
    {
        public FormCalib()
        {
            InitializeComponent();
        }
        private void btnSetSample_Click(object sender, EventArgs e)
        {
            if (btnCheck.IsCLick)
                btnCheck.PerformClick();
            if (btnLive.IsCLick)
                btnLive.PerformClick();
            if (G.EditTool.View.btnLive.IsCLick)
            {
                //G.EditTool.View.btnRecord.Enabled = true;
                G.EditTool.View.btnLive.PerformClick();

            }
            if (G.EditTool.View.btnRecord.IsCLick)
            {
                //G.EditTool.View.btnRecord.Enabled = true;
                G.EditTool.View.btnRecord.PerformClick();

            }
            BeeCore.Common.ReadCCD(false,G.Config.TypeCamera);
            BeeCore.Common.matRaw = BeeCore.Common.GetImageRaw(G.Config.TypeCamera);
            G.Config.matSample = BeeCore.Common.matRaw.ToBitmap();
            G.EditTool.View.imgView.ImageIpl = BeeCore.Common.matRaw;

        }

        private void workerCalib_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Scalar scalar = Scalar.Red;

            trackScoreErr.ValueScore = (int)valueMedium;
            if (trackScoreErr.ValueScore <= trackScoreErr.Value)
            {
                scalar = Scalar.Green;
                trackScoreErr.ColorTrack = Color.Green;
                lbStatus.Text = "OK";
                lbStatus.BackColor = Color.FromArgb(255, 27, 186, 98);

            }
            else
            {
                trackScoreErr.ColorTrack = Color.Red;
                lbStatus.Text = "NG";
                lbStatus.BackColor = Color.DarkRed;
            }    
                

             G.EditTool.View.imgView.ImageIpl = matRS;
            if (btnCheck.IsCLick)
                workerCalib.RunWorkerAsync();
        }
        private void trackScoreErr_ValueChanged(int obj)
        {
            G.Config.ScoreCalib = trackScoreErr.Value;
            if (trackScoreErr.ValueScore <= trackScoreErr.Value)
            {

                trackScoreErr.ColorTrack = Color.Green;
            }
            else
                trackScoreErr.ColorTrack = Color.Red;
        }
        Mat matRS = new Mat();
        float valueMedium = 0;
        private void workerCalib_DoWork(object sender, DoWorkEventArgs e)
        {
            BeeCore.Common.ReadCCD(false, G.Config.TypeCamera);
            Mat matRaw = BeeCore.Common.GetImageRaw(G.Config.TypeCamera);
            Mat matProcess = new Mat(matRaw.Size(), MatType.CV_8UC1);
            Mat matSample = G.Config.matSample.ToMat();
            Mat mask = new Mat(), matOr = new Mat();
            Cv2.CvtColor(matSample.Clone(), matSample, ColorConversionCodes.BGR2GRAY);
            Cv2.CvtColor(matRaw.Clone(), mask, ColorConversionCodes.BGR2GRAY);
            float valueMid = 0;
            for (int row = 0; row < matSample.Rows; row++)
            {
                for (int col = 0; col < matSample.Cols; col++)
                {

                    float valSample = matSample.Get<Vec3b>(row, col)[0];
                    float valRaw = mask.Get<Vec3b>(row, col)[0];
                    valueMid = Math.Abs(valRaw - valSample);
                    valueMedium += valueMid;
                    if (valueMid < G.Config.ScoreCalib)
                        matProcess.Set(row, col, 255);


                    else
                        matProcess.Set(row, col, 0);
                }
            }
            valueMedium = valueMedium / (matSample.Rows * matSample.Cols);


            Cv2.BitwiseNot(matProcess.Clone(), matOr);



            Scalar scalar = Scalar.Red;

            if (trackScoreErr.ValueScore <= trackScoreErr.Value)
            {
                scalar = Scalar.Green;
             
            }
           
            Mat matRed = new Mat(matOr.Size(), MatType.CV_8UC3, scalar);
            Cv2.CvtColor(matOr, matOr, ColorConversionCodes.GRAY2BGR);
            Mat mat2 = new Mat();
            Cv2.BitwiseAnd(matOr, matRed, mat2);
            Cv2.BitwiseOr(matRaw, mat2, matRS);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (btnLive.IsCLick)
                btnLive.PerformClick();
            if (btnCheck.IsCLick)
            {
                if (G.EditTool.View.btnLive.IsCLick)
                {
                    //G.EditTool.View.btnRecord.Enabled = true;
                    G.EditTool.View.btnLive.PerformClick();

                }
                if (G.EditTool.View.btnRecord.IsCLick)
                {
                    //G.EditTool.View.btnRecord.Enabled = true;
                    G.EditTool.View.btnRecord.PerformClick();

                }
                if (!workerCalib.IsBusy)
                    workerCalib.RunWorkerAsync();

            }

        }
        private void FormCalib_Load(object sender, EventArgs e)
        {
            
            trackScoreErr.Value = G.Config.ScoreCalib;
            if (!G.Config.nameUser.Contains("Admin"))
                trackScoreErr.Enabled = false;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);


        }

        private void FormCalib_FormClosing(object sender, FormClosingEventArgs e)
        {if (btnLive.IsCLick) btnLive.PerformClick();
            if (btnCheck.IsCLick) btnCheck.PerformClick();
            G.EditTool.View.btnCalib.IsCLick = false;
            if(G.StepEdit.SettingStep1!=null)
            G.StepEdit.SettingStep1.btnCalib.IsCLick = false;

        }
        bool IsHistOld = false;
        private void btnLive_Click(object sender, EventArgs e)
        {
            if (btnLive.IsCLick)
            {
                IsHistOld = G.Config.IsHist;
                G.Config.IsHist = false;
            }
              
            else
                G.Config.IsHist = IsHistOld;
            G.EditTool.View.btnLive.IsCLick = !G.EditTool.View.btnLive.IsCLick;
            G.EditTool.View.Live();
        }
    }
}
