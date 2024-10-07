﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeeCore;
using BeeUi.Common;
using BeeUi.Commons;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace BeeUi.Tool
{
    [Serializable()]
    public partial class ToolOutLine : UserControl
    {
    
        public ToolOutLine( )
        {
            InitializeComponent();
            
        }
        private void trackScore_ValueChanged(int obj)
        {
            Propety.Score = trackScore.Value;
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();

        }
        public void LoadPara(dynamic Content)
        {
            OutLine Para = (OutLine)Content;
            Bitmap bmTemp = Propety.matTemp;
              if (bmTemp != null)
            {
                Propety.LearnPattern(indexTool, OpenCvSharp.Extensions.BitmapConverter.ToMat(bmTemp));
                }
            trackScore.Value = (int)(Para.Score * 100);
            trackMaxOverLap.Value = (int)(Para.OverLap * 100);
            txtAngle.Text = (int)Para.Angle + "";

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
            if (Propety.threshMin == 0)
                btnCannyMax.IsCLick = true;
            else if (Propety.threshMin == 100)
                btnCannyMedium.IsCLick = true;
            else
                btnCannyMin.IsCLick = true;
        }
        public TypeTool TypeTool;
 
        public OutLine Propety=new OutLine();
        private void rjButton3_Click(object sender, EventArgs e)
        {

          
          //  cv3.Pattern();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
           
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }

         private void btnCropRect_Click(object sender, EventArgs e)
        {
            G.TypeCrop = BeeCore.TypeCrop.Crop;
           Propety.TypeCrop = G.TypeCrop;
            IsFullSize = false;
            Propety.rotArea = Propety.rotAreaTemp.Clone();
            G.IsCheck = false;
         
            G.EditTool.View.imgView.Invalidate();
            G.EditTool.View.Cursor = Cursors.Default;
            if (IsClear)
                btnClear.PerformClick();
        }

        private void btnCropArea_Click(object sender, EventArgs e)
        {
            IsFullSize = true;
            Propety.rotAreaTemp = Propety.rotArea.Clone();
            Propety.rotArea = new RectRotate(new RectangleF(-BeeCore.Common.matRaw.Width / 2 , -BeeCore.Common.matRaw.Height / 2 , BeeCore.Common.matRaw.Width , BeeCore.Common.matRaw.Height ), new PointF(BeeCore.Common.matRaw.Width / 2, BeeCore.Common.matRaw.Height / 2), 0, AnchorPoint.None);

            G.IsCheck = false;
            G.TypeCrop = BeeCore.TypeCrop.Area;
           Propety.TypeCrop = G.TypeCrop;
            
            G.EditTool.View.imgView.Invalidate();
            G.EditTool.View.Cursor = Cursors.Default;
            if (IsClear)
                btnClear.PerformClick();
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }

        public RJButton ButtonPress( RJButton control ,Control parent)
        {
            foreach (Control con in parent.Controls)
            {
                if(con==control)
                {
                    control.BackColor = Color.Goldenrod;
                    control.BorderColor = Color.DarkGoldenrod;
                }  
                else
                {
                    RJButton btn = con as RJButton;
                    btn.BackColor = Color.WhiteSmoke;
                    btn.BorderColor = Color.Silver;
                    btn.TextColor = Color.Black;
                }    
            }
            return control;


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
            Propety.rotAreaAdjustment = new RectRotate();
            Propety.rotAreaAdjustment._rect = Propety.rotArea._rect;
            Propety.rotAreaAdjustment._PosCenter = new PointF(Propety.rotArea._PosCenter.X + G.X_Adjustment, Propety.rotArea._PosCenter.Y + G.Y_Adjustment);
            Propety.rotAreaAdjustment._angle = Propety.rotArea._rectRotation + G.angle_Adjustment;
           


                if(G.IsRun)
               Propety.Matching(G.IsRun, BeeCore.Common.matRaw.ToBitmap(), indexTool, Propety.rotAreaAdjustment);
            else
               Propety.Matching(G.IsRun, BeeCore.Common.matRaw.ToBitmap(), indexTool, Propety.rotArea);
        }
        Bitmap bmResult ;
        public int indexTool;
        private void threadProcess_DoWork(object sender, DoWorkEventArgs e)
        {

            Process();

        }
        public Mat matTemp=new Mat();
        Mat matClear = new Mat(); Mat matMask = new Mat();
        public void GetTemp( RectRotate rotateRect)
        {
            float angle = rotateRect._rectRotation;
            if (rotateRect._rectRotation < 0) angle = 360 + rotateRect._rectRotation;
          Mat  matCrop =G.EditTool.View. CropRotatedRect(BeeCore.Common.matRaw, new RotatedRect(new Point2f(rotateRect._PosCenter.X + (rotateRect._rect.Width / 2 + rotateRect._rect.X), rotateRect._PosCenter.Y + (rotateRect._rect.Height / 2 + rotateRect._rect.Y)), new Size2f(rotateRect._rect.Width, rotateRect._rect.Height), angle));
            Mat matOut = new Mat();
            Cv2.Canny(matCrop, matOut,Propety.threshMin,Propety.threshMax);

            Mat crop = G.EditTool.View.CropRotatedRect(G.EditTool.View.bmMask, new RotatedRect(new Point2f(rotateRect._PosCenter.X + (rotateRect._rect.Width / 2 + rotateRect._rect.X), rotateRect._PosCenter.Y + (rotateRect._rect.Height / 2 + rotateRect._rect.Y)), new Size2f(rotateRect._rect.Width, rotateRect._rect.Height), angle));
         
            Cv2.BitwiseNot(crop, matClear);
             Mat rs = new Mat();
            Cv2.BitwiseAnd(matClear, matOut, matTemp);
            Cv2.BitwiseAnd(crop, matOut, matMask);
        }
        public Graphics  ShowResult(Graphics gc)
        {
                gc.ResetTransform();
                var mat = new Matrix();
            RectRotate rotA = Propety.rotArea;
            if (G.IsRun) rotA = Propety.rotAreaAdjustment;
            mat.Translate(rotA._PosCenter.X, rotA._PosCenter.Y);
                mat.Rotate(rotA._rectRotation);
                gc.Transform = mat;
            
                gc.DrawRectangle(new Pen(Color.Silver, 1), new Rectangle((int)rotA._rect.X, (int)rotA._rect.Y, (int)rotA._rect.Width, (int)rotA._rect.Height));
                gc.ResetTransform();
            if (matTemp.Empty()) return gc;
            if (!Propety.IsOK)
                {
                     mat = new Matrix();
              
                mat.Translate(Propety.rotCrop._PosCenter.X , Propety.rotCrop._PosCenter.Y );
                    mat.Rotate(Propety.rotCrop._rectRotation);
                    gc.Transform = mat;
                    Bitmap bmTemp = matTemp.ToBitmap();
                    bmTemp.MakeTransparent(Color.Black);
                    bmTemp = G.EditTool.View.ChangeToColor(bmTemp, Color.Red, 0.7f);

         
                    RectangleF _rect = Propety.rotCrop._rect;
                    gc.DrawRectangle(new Pen(Color.Red, 2), new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));
                    gc.DrawImage(bmTemp,  Propety.rotCrop._rect);
                    gc.ResetTransform();
                    return gc;
                }    
                foreach (RectRotate rot in Propety.rectRotates)
                {
                    mat = new Matrix();
               
                mat.Translate(rotA._PosCenter.X, rotA._PosCenter.Y );
                mat.Rotate(rotA._rectRotation);
                mat.Translate(rotA._rect.X, rotA._rect.Y);
                gc.Transform = mat;
                mat.Translate(rot._PosCenter.X,  rot._PosCenter.Y);
                    mat.Rotate(rot._rectRotation);
                    gc.Transform = mat;
                    Mat matShow =matTemp.Clone();
                //if (TypeTool == TypeTool.Pattern)
                //{
                //    Cv2.BitwiseNot(matShow, matShow);
                //}
                Bitmap myBitmap = matShow.ToBitmap();
                myBitmap.MakeTransparent(Color.Black);
                myBitmap = G.EditTool.View.ChangeToColor(myBitmap, Color.FromArgb(0,255,0),1f);


                gc.DrawImage(myBitmap, rot._rect);
                    gc.DrawRectangle(new Pen(Color.LimeGreen, 1), new Rectangle((int)rot._rect.X, (int)rot._rect.Y, (int)rot._rect.Width, (int)rot._rect.Height));
                    gc.ResetTransform();
                }
           Propety.rectRotates = new List<RectRotate>();


            return gc;
        }
        public Graphics ShowEdit(Graphics gc, RectangleF _rect)
        {
            if (matTemp == null) return gc;
            
                if (G.TypeCrop != TypeCrop.Area)
                try
                {
                    Mat matShow = matTemp.Clone();
                    Cv2.ImShow("a", G.EditTool.View.matTemp);
                    Bitmap bmTemp = matShow.ToBitmap();
                    bmTemp.MakeTransparent(Color.Black);
                    bmTemp = G.EditTool.View.ChangeToColor(bmTemp, Color.FromArgb(0, 255, 0), 1f);

                    gc.DrawImage(bmTemp, _rect);
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
       
        private void threadProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          
            G.IsCheck = true;
            G.EditTool.View.imgView.Invalidate();
           // G.EditTool.View.imgView.ImageIpl = null;
           //  G.EditTool.View.imgView.Image = bmResult;
            G.EditTool.View.lbCycleTrigger.Text = "[" +Propety.cycleTime + "ms]";
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
            float angleOrigin = Propety.rotCrop._rectRotation;
            //if (angleOrigin < 0) angleOrigin = 360 - angleOrigin;
           Propety.Angle -= 10;
            if (Propety.Angle < 0)Propety.Angle = 0;
            txtAngle.Text =Propety.Angle + "";
            if (Propety.Angle == 0)
            {
               Propety.AngleLower = angleOrigin - 1;
               Propety.AngleUper = angleOrigin + 1;
            }
            else
            {
               Propety.AngleLower = angleOrigin -Propety.Angle;
               Propety.AngleUper = angleOrigin +Propety.Angle;
            }
           // if (Propety.AngleUper > 360)Propety.AngleUper =Propety.AngleUper - 360;
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }

        private void btnPlusAngle_Click(object sender, EventArgs e)
        {
         
           // if (angleOrigin < 0) angleOrigin = 360 + angleOrigin;
           Propety.Angle += 10;
            float angleOrigin = Propety.rotCrop._rectRotation;
            if (Propety.Angle >180)Propety.Angle = 180;
            txtAngle.Text =Propety.Angle + "";
            if (Propety.Angle == 0)
            {
               Propety.AngleLower = angleOrigin - 1;
               Propety.AngleUper = angleOrigin + 1;
            }
            else
            {
               Propety.AngleLower = angleOrigin -Propety.Angle;
               Propety.AngleUper = angleOrigin +Propety.Angle;
            }
            //if (Propety.AngleUper > 360)Propety.AngleUper =Propety.AngleUper - 360;
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
            TypeTool = TypeTool.OutLine;
           Propety.TypeMode = Mode.OutLine;
           Propety.NumObject = 1;
           Propety.pathRaw = G.EditTool.View.pathRaw;
          
        }
        private void ToolOutLine_Load(object sender, EventArgs e)
        {
            Loads();


        }

        private void ToolOutLine_VisibleChanged(object sender, EventArgs e)
        {

        }
        public bool IsFullSize=false;
        public    bool IsClear = false;
        public Eraser Eraser;
        private void btnClear_Click(object sender, EventArgs e)
        {
          
            if (Eraser == null)
            {
               
                Eraser = new Eraser();
                Eraser.Parent =this;
                Eraser.BringToFront();
                Eraser.Location = new System.Drawing.Point(this.Width / 2 - Eraser.Width / 2, this.Height / 2 - Eraser.Height / 2);
            }
           
       
       

            btnClear.IsCLick = !IsClear;
            IsClear = btnClear.IsCLick;
            if(IsClear)
            {
                tmClear.Enabled = true;
                Eraser.Show();
                G.EditTool.View.Cursor = new Cursor(Properties.Resources.Erase1.Handle);
                G.TypeCrop = TypeCrop.Crop;
                G.IsCheck = false;
                G.EditTool.View.imgView.Invalidate();
            }
            else
                Eraser.Hide();




            G.EditTool.View.imgView.Invalidate();
         

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            G.EditTool.View.bmMask = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void tmClear_Tick(object sender, EventArgs e)
        {
            
        }

        private void txtAngle_TextChanged(object sender, EventArgs e)
        {
            try
            {
               Propety.Angle = Convert.ToInt32(txtAngle.Text.Trim());
                float angleOrigin = Propety.rotCrop._rectRotation;
                if (Propety.Angle > 180)Propety.Angle = 180;
                txtAngle.Text =Propety.Angle + "";
                if (Propety.Angle == 0)
                {
                   Propety.AngleLower = angleOrigin - 1;
                   Propety.AngleUper = angleOrigin + 1;
                }
                else
                {
                   Propety.AngleLower = angleOrigin -Propety.Angle;
                   Propety.AngleUper = angleOrigin +Propety.Angle;
                }
                //if (Propety.AngleUper > 360)Propety.AngleUper =Propety.AngleUper - 360;
                if (!threadProcess.IsBusy)
                    threadProcess.RunWorkerAsync();
            }
            catch(Exception )
            {
                txtAngle.Text =Propety.Angle+"";
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
        Propety. IsHighSpeed = false;
        }

        private void btnHighSpeed_Click(object sender, EventArgs e)
        {
           Propety.IsHighSpeed = true;

        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            G.TypeCrop = TypeCrop.Mask;
            G.EditTool.View.imgView.Invalidate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            G.IsCancel = true;
            this.Parent.Controls.Remove(this);
            G.ToolSettings.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            G.IsCheck = true;
            this.Parent.Controls.Remove(this);
           
            G.ToolSettings.Visible = true;
        }
    }
}
