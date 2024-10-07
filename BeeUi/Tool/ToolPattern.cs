﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeeCore;
using BeeUi.Common;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace BeeUi.Tool
{
    [Serializable()]
    public partial class ToolPattern : UserControl
    {
        
        public ToolPattern( )
        {
            InitializeComponent();
            
        }
       public TypeTool TypeTool=TypeTool.Pattern;
        public void LoadPara(dynamic Content)
        {
            OutLine Para = (OutLine)Content;
            Bitmap bmTemp = Propety.matTemp;
            if (bmTemp != null)
            {
                Propety.LearnPattern(indexTool, OpenCvSharp.Extensions.BitmapConverter.ToMat(bmTemp));
               
                   
            }
            trackScore.Value =Para.Score; 
            trackNumObject.Value= Para.NumObject;
            trackMaxOverLap.Value = (int)(Para.OverLap * 100);
            txtAngle.Text = (int)Para.Angle + "";
            if (Propety.NumObject == 0) Propety.NumObject = 1;
            Propety.ckBitwiseNot = Para.ckBitwiseNot;
            Propety.ckSIMD = Para.ckSIMD;
            Propety.ckSubPixel = Para.ckSubPixel;
            ckBitwiseNot.IsCLick = Para.ckBitwiseNot;
            ckSIMD.IsCLick = Para.ckSIMD;
            ckSubPixel.IsCLick = Para.ckSubPixel;
            Propety.TypeMode = Para.TypeMode;
            if (Propety.IsHighSpeed)
                btnHighSpeed.IsCLick = true;
            else
                btnNormal.IsCLick = true;
        }
        private void trackScore_ValueChanged(int obj)
        {
            Propety.Score = trackScore.Value;
            G.IsCheck = true;
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();

        }

        public OutLine Propety=new OutLine();
        public Mat matTemp = new Mat();
        Mat matClear = new Mat(); Mat matMask = new Mat();
        public void GetTemp(RectRotate rotateRect, Mat matRegister)
        {
           
                float angle = rotateRect._rectRotation;
                if (rotateRect._rectRotation < 0) angle = 360 + rotateRect._rectRotation;
                Mat matCrop = G.EditTool.View.CropRotatedRect(matRegister, new RotatedRect(new Point2f(rotateRect._PosCenter.X + (rotateRect._rect.Width / 2 + rotateRect._rect.X), rotateRect._PosCenter.Y + (rotateRect._rect.Height / 2 + rotateRect._rect.Y)), new Size2f(rotateRect._rect.Width, rotateRect._rect.Height), angle));
                if (matCrop.Type() == MatType.CV_8UC3)
                    Cv2.CvtColor(matCrop, matTemp, ColorConversionCodes.BGR2GRAY);
                if (Propety.IsAreaWhite)
                    Cv2.BitwiseNot(matTemp, matTemp);
           
        }
     
        public Graphics ShowResult(Graphics gc)
        {
            if (Propety.rotAreaAdjustment == null&& G.IsRun) return gc;
            gc.ResetTransform();
           // gc.FillEllipse(Brushes.Black, Propety.rotArea._PosCenter.X, Propety.rotArea._PosCenter.Y, 6, 6);

            var mat = new Matrix();
            RectRotate rotA = Propety.rotArea;
            if (G.IsRun) rotA = Propety.rotAreaAdjustment;
            mat.Translate(rotA._PosCenter.X, rotA._PosCenter.Y);
            mat.Rotate(rotA._rectRotation);
            gc.Transform = mat;
            //gc.FillEllipse(Brushes.Blue, -3, -3, 6, 6);
            gc.DrawString(indexTool + "", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point((int)rotA._rect.X, (int)rotA._rect.Y));

            gc.DrawRectangle(new Pen(Color.Silver, 1), new Rectangle((int)rotA._rect.X, (int)rotA._rect.Y, (int)rotA._rect.Width, (int)rotA._rect.Height));
            gc.ResetTransform();
            if (!Propety.IsOK)
            {
                Color cl = Color.Red;
                if (G.PropetyTools[G.PropetyTools.FindIndex(a => a.Propety == Propety)].UsedTool == UsedTool.Invertse &&
                    G.Config.ConditionOK == ConditionOK.Logic)
                    cl = Color.LimeGreen;
                if (Propety.rectRotates.Count > 0)
                {
                    int i = 1;
                    foreach (RectRotate rot in Propety.rectRotates)
                    {
                        mat = new Matrix();

                        mat.Translate(rotA._PosCenter.X, rotA._PosCenter.Y);
                        mat.Rotate(rotA._rectRotation);
                        mat.Translate(rotA._rect.X, rotA._rect.Y);
                        gc.Transform = mat;
                        mat.Translate(rot._PosCenter.X, rot._PosCenter.Y);
                        mat.Rotate(rot._rectRotation);
                        gc.Transform = mat;
                        gc.DrawString(i + "", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point((int)rot._rect.X, (int)rot._rect.Y));
                        i++;
                        //gc.FillEllipse(Brushes.Black, -3, -3, 6, 6);
                        gc.DrawRectangle(new Pen(cl, 4), new Rectangle((int)rot._rect.X, (int)rot._rect.Y, (int)rot._rect.Width, (int)rot._rect.Height));
                        gc.ResetTransform();
                    }
                }
                else
                {
                    mat = new Matrix();

                    mat.Translate(Propety.rotCrop._PosCenter.X, Propety.rotCrop._PosCenter.Y);
                    mat.Rotate(Propety.rotCrop._rectRotation);
                    gc.Transform = mat;

                    RectangleF _rect = Propety.rotCrop._rect;
                    if (G.PropetyTools[G.PropetyTools.FindIndex(a => a.Propety == Propety)].UsedTool == UsedTool.Invertse &&
                          G.Config.ConditionOK == ConditionOK.Logic)
                        gc.DrawRectangle(new Pen(Color.LimeGreen, 4), new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));

                    else
                        gc.DrawRectangle(new Pen(Color.Red, 4), new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));
                    // 
                }
                gc.ResetTransform();
                return gc;
            }
            else
            {
                Color cl = Color.LimeGreen;
                if (G.PropetyTools[G.PropetyTools.FindIndex(a => a.Propety == Propety)].UsedTool == UsedTool.Invertse &&
                    G.Config.ConditionOK == ConditionOK.Logic)
                    cl = Color.Red;
                int i = 0;
                    foreach (RectRotate rot in Propety.rectRotates)
                {
                    mat = new Matrix();

                    mat.Translate(rotA._PosCenter.X, rotA._PosCenter.Y);
                    mat.Rotate(rotA._rectRotation);
                    mat.Translate(rotA._rect.X, rotA._rect.Y);
                    gc.Transform = mat;
                    mat.Translate(rot._PosCenter.X, rot._PosCenter.Y);
                    mat.Rotate(rot._rectRotation);
                    gc.Transform = mat;
                    gc.DrawString(i + "", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new System.Drawing.Point((int)rot._rect.X, (int)rot._rect.Y));
                    i++;
                    //gc.FillEllipse(Brushes.Black, -3, -3, 6, 6);
                    gc.DrawRectangle(new Pen(cl, 4), new Rectangle((int)rot._rect.X, (int)rot._rect.Y, (int)rot._rect.Width, (int)rot._rect.Height));
                    gc.ResetTransform();
                }
            }
          


            return gc;
        }
        public Graphics ShowEdit(Graphics gc, RectangleF _rect)
        {
            if (matTemp == null) return gc;

            if (G.TypeCrop != TypeCrop.Area)
                try
                {
                    Mat matShow = matTemp.Clone();
                    if (Propety.TypeMode == Mode.OutLine)
                    {
                        Bitmap bmTemp = matShow.ToBitmap();

                        bmTemp.MakeTransparent(Color.Black);
                        bmTemp = G.EditTool.View.ChangeToColor(bmTemp, Color.FromArgb(0, 255, 0), 1f);

                        gc.DrawImage(bmTemp, _rect);
                    }
                    if (matMask != null)
                    {
                        Bitmap myBitmap2 = matMask.ToBitmap();
                        myBitmap2.MakeTransparent(Color.Black);
                        myBitmap2 = G.EditTool.View.ChangeToColor(myBitmap2, Color.OrangeRed, 1f);

                        gc.DrawImage(myBitmap2, _rect);
                    }

                }
                catch (Exception ex) { }
            return gc;
        }

       
        private void rjButton3_Click(object sender, EventArgs e)
        {

          
          //  cv3.Pattern();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {

        }

        private void btnCropRect_Click(object sender, EventArgs e)
        {
            G.TypeCrop = BeeCore.TypeCrop.Crop;
            Propety.TypeCrop = G.TypeCrop;

         
            G.EditTool.View.imgView.Invalidate();
            G.EditTool.View.imgView.Cursor = Cursors.Default;
        }

        private void btnCropArea_Click(object sender, EventArgs e)
        {
            G.TypeCrop = BeeCore.TypeCrop.Area;
            Propety.TypeCrop = G.TypeCrop;
            
            G.EditTool.View.imgView.Invalidate();
            G.EditTool.View.imgView.Cursor = Cursors.Default;
        }

       
        private void btnCannyMin_Click(object sender, EventArgs e)
        {
            Propety.threshMin = 180;
            Propety.threshMax = 255;
            Propety.LearnPattern(indexTool, matTemp);

        }

        private void btnCannyMedium_Click(object sender, EventArgs e)
        {
            Propety.threshMin = 100;
            Propety.threshMax = 255;
            Propety.LearnPattern(indexTool, matTemp);
        }

        private void btnCannyMax_Click(object sender, EventArgs e)
        {
            Propety.threshMin = 0;
            Propety.threshMax = 255;
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();

        }

    
        
      
        public void Process()
        {
            Propety.rectRotates = new List<RectRotate>();
            if (G.IsRun)
            {
                if (G.rotPositionAdjustment != null)
                    Propety.rotAreaAdjustment = G.EditTool.View.GetPositionAdjustment(Propety.rotArea, G.rotPositionAdjustment);
                else
                    Propety.rotAreaAdjustment = Propety.rotArea;
                Propety.Matching(G.IsRun, BeeCore.Common.matRaw.ToBitmap(), indexTool, Propety.rotAreaAdjustment);

            }
            else
                Propety.Matching(G.IsRun, BeeCore.Common.matRaw.ToBitmap(), indexTool, Propety.rotArea);
        }
        Bitmap bmResult ;
        private void threadProcess_DoWork(object sender, DoWorkEventArgs e)
        {
          
        }
        public int indexTool = 0;
        private void threadProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (G.IsLoad)
                Process();

            G.EditTool.View.imgView.Invalidate();
         
            G.EditTool.View.lbCycleTrigger.Text = "[" + Propety.cycleTime + "ms]";
        }

        private void trackScore_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackScore_MouseUp(object sender, MouseEventArgs e)
        {
           

            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }

        private void trackMaxOverLap_Scroll(object sender, EventArgs e)
        {
            lbOverLap.Text = trackMaxOverLap.Value + " %";
            Propety.OverLap = (trackMaxOverLap.Value * 1) / 100.0;
        }

        private void trackMaxOverLap_MouseUp(object sender, MouseEventArgs e)
        {
          

            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }
        
       
        private void btnSubAngle_Click(object sender, EventArgs e)
        {
            Propety.Angle -= 10;
            if (Propety.Angle < 0) Propety.Angle = 0;
                txtAngle.Text = Propety.Angle+"";
            if(Propety.Angle==0)
            {
                Propety.AngleLower = Propety.rotCrop._rectRotation - 1;
                Propety.AngleUper = Propety.rotCrop._rectRotation + 1;
            }
            else
            {
                Propety.AngleLower = Propety.rotCrop._rectRotation - Propety.Angle;
                Propety.AngleUper = Propety.rotCrop._rectRotation + Propety.Angle;
            }    
          
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }

        private void btnPlusAngle_Click(object sender, EventArgs e)
        {
            Propety.Angle += 10;
            if (Propety.Angle >180) Propety.Angle = 180;
            txtAngle.Text = Propety.Angle + "";
            if (Propety.Angle == 0)
            {
                Propety.AngleLower = Propety.rotCrop._rectRotation - 1;
                Propety.AngleUper = Propety.rotCrop._rectRotation + 1;
            }
            else
            {
                Propety.AngleLower = Propety.rotCrop._rectRotation - Propety.Angle;
                Propety.AngleUper = Propety.rotCrop._rectRotation + Propety.Angle;
            }
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }

        private void ckSIMD_Click(object sender, EventArgs e)
        {
            Propety.ckSIMD = !Propety.ckSIMD;
              if(Propety.ckSIMD)
                {
                ckSIMD.BackColor = Color.Goldenrod;
                ckSIMD.BorderColor = Color.DarkGoldenrod;
                }
                else
                { 
                ckSIMD.BackColor = Color.WhiteSmoke;
                ckSIMD.BorderColor = Color.Silver;
                ckSIMD.TextColor = Color.Black;
                }
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }

        private void ckBitwiseNot_Click(object sender, EventArgs e)
        {
            Propety.ckBitwiseNot = !Propety.ckBitwiseNot;
            if (Propety.ckBitwiseNot)
            {
                ckBitwiseNot.BackColor = Color.Goldenrod;
                ckBitwiseNot.BorderColor = Color.DarkGoldenrod;
            }
            else
            {
                ckBitwiseNot.BackColor = Color.WhiteSmoke;
                ckBitwiseNot.BorderColor = Color.Silver;
                ckBitwiseNot.TextColor = Color.Black;
            }
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }

        private void ckSubPixel_Click(object sender, EventArgs e)
        {
            Propety.ckSubPixel = !Propety.ckSubPixel;
            if (Propety.ckSubPixel)
            {
                ckSubPixel.BackColor = Color.Goldenrod;
                ckSubPixel.BorderColor = Color.DarkGoldenrod;
            }
            else
            {
                ckSubPixel.BackColor = Color.WhiteSmoke;
                ckSubPixel.BorderColor = Color.Silver;
                ckSubPixel.TextColor = Color.Black;
            }
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }
     
        public void Loads()
        {
            Propety.TypeTool = TypeTool.Pattern;
     
            Propety.TypeMode = Mode.Pattern;
            Propety.pathRaw = G.EditTool.View.pathRaw;
            //Propety.NumObject = 1;
        }
        private void ToolOutLine_Load(object sender, EventArgs e)
        {
            Loads();


        }

        private void ToolOutLine_VisibleChanged(object sender, EventArgs e)
        {

        }
       public bool IsClear = false;
        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.IsCLick = !btnClear.IsCLick;
            IsClear = btnClear.IsCLick;
            G.EditTool.View.Cursor = new Cursor(Properties.Resources.Erase1.Handle);



            G.EditTool.View.imgView.Invalidate();



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            G.IsCancel = true;
            this.Parent.Controls.Remove(this);
            G.ToolSettings.Visible = true;
        }

        private void btnAreaBlack_Click(object sender, EventArgs e)
        {
            Propety.IsAreaWhite = false;
             GetTemp(Propety.rotCrop,BeeCore.Common.matRaw );
            G.EditTool.View.imgView.Invalidate();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Propety.IsHighSpeed = false;
        }

        private void btnHighSpeed_Click(object sender, EventArgs e)
        {
            Propety.IsHighSpeed = true;

        }
        private void btnAreaWhite_Click(object sender, EventArgs e)
        {
            Propety.IsAreaWhite = true;
            GetTemp(Propety.rotCrop, BeeCore.Common.matRaw);
            G.EditTool.View.imgView.Invalidate();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            G.IsCheck = true;
            this.Parent.Controls.Remove(this);
          
            G.ToolSettings.Visible = true;
        }

        private void trackBar21_Load(object sender, EventArgs e)
        {

        }

        private void trackNumObject_ValueChanged(int obj)
        {
            Propety.NumObject = trackNumObject.Value;
        }
    }
}
