﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeeCore;
#if DEBUG == false
using BeeCore;
#endif
using BeeUi.Common;
using BeeUi.Commons;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace BeeUi.Tool
{
    [Serializable()]
    public partial class ToolColorArea : UserControl
    {
     
        public TypeTool TypeTool;
        public ToolColorArea( )
        {
            InitializeComponent();
        }
        public int indexTool;
        
        public BeeCore.ColorArea Propety=new ColorArea();
        public Mat matTemp = new Mat();
        Mat bmRs =null;
        Mat matClear = new Mat(); Mat matMask = new Mat();
        public bool IsClear;
        public void LoadPara( dynamic Content)
        {
          
            ColorArea Para = (ColorArea)Content;
            if(Para.listCLShow==null)
            Para.listCLShow = new List<Color>();
            if(G.Config.TypeCamera==TypeCamera.USB)
            Propety.LoadTemp(G.IsCCD,G.Config.IsHist,G.Config.TypeCamera);
            trackScore.Value =Para.Score ;
            trackPixel.Value = (int)Para.AreaPixel;
            if (!Convert.ToBoolean(Para.StyleColor))
                btnColor.IsCLick = true;
            else
                btnClWhite.IsCLick = true;

            trackScore.Value = Para.Score;
           
        }
        public Mat RotateMat(Mat raw, RotatedRect rot)
        {
            Mat matRs = new Mat(), matR = Cv2.GetRotationMatrix2D(rot.Center, rot.Angle, 1);

            float fTranslationX = (rot.Size.Width - 1) / 2.0f - rot.Center.X;
            float fTranslationY = (rot.Size.Height - 1) / 2.0f - rot.Center.Y;
            matR.At<double>(0, 2) += fTranslationX;
            matR.At<double>(1, 2) += fTranslationY;
            Cv2.WarpAffine(raw, matRs, matR, new OpenCvSharp.Size(rot.Size.Width, rot.Size.Height), InterpolationFlags.Linear, BorderTypes.Constant);
            return matRs;
        }
        public Mat matCrop=new Mat();
        public Mat GetTemp(RectRotate rotateRect)
        {
          
            float angle = rotateRect._rectRotation;
            if (rotateRect._rectRotation < 0) angle = 360 + rotateRect._rectRotation;
             matCrop =  RotateMat(BeeCore.Common.matRaw, new RotatedRect(new Point2f(rotateRect._PosCenter.X, rotateRect._PosCenter.Y), new Size2f(rotateRect._rect.Width, rotateRect._rect.Height), rotateRect._angle));

            
            picColor.Invalidate();
            return Propety.SetColor(G.IsRun, matCrop);
           
        }
        
        public Graphics ShowResult(Graphics gc)
        {if (bmRs == null) return gc;
            gc.ResetTransform();
            var mat = new Matrix();
            RectRotate rotA = Propety.rotArea;
            if (G.IsRun) rotA = Propety.rotAreaAdjustment;
            mat.Translate(rotA._PosCenter.X, rotA._PosCenter.Y);
            mat.Rotate(rotA._rectRotation);
            gc.Transform = mat;

            gc.DrawRectangle(new Pen(Color.Silver, 1), new Rectangle((int)rotA._rect.X, (int)rotA._rect.Y, (int)rotA._rect.Width, (int)rotA._rect.Height));
            
            //gc.ResetTransform();
            if (!Propety.IsOK)
            {
            //    mat = new Matrix();

            //    mat.Translate(rotA._PosCenter.X, rotA._PosCenter.Y);
            //    mat.Rotate(rotA._rectRotation);
            //    gc.Transform = mat;
                RectangleF _rect = rotA._rect;
                if (G.IsDrawProcess)
                {
                    Bitmap bmTemp = bmRs.ToBitmap();
                    bmTemp.MakeTransparent(Color.Black);
                    bmTemp = G.EditTool.View.ChangeToColor(bmTemp, Color.Red, 0.7f);
                    gc.DrawImage(bmTemp, rotA._rect);
                }

              
                gc.DrawRectangle(new Pen(Color.Red, 2), new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));
               
             
             
            }
            else
            {
                //mat = new Matrix();

                //mat.Translate(rotA._PosCenter.X, rotA._PosCenter.Y);
                //mat.Rotate(rotA._rectRotation);

                //gc.Transform = mat;
                if (G.IsDrawProcess)
                {
                    Bitmap myBitmap = bmRs.ToBitmap();
                    myBitmap.MakeTransparent(Color.Black);
                    myBitmap = G.EditTool.View.ChangeToColor(myBitmap, Color.FromArgb(0, 255, 0), 1f);
                    gc.DrawImage(myBitmap, rotA._rect);
                }

                
                gc.DrawRectangle(new Pen(Color.LimeGreen,2), new Rectangle((int)rotA._rect.X, (int)rotA._rect.Y, (int)rotA._rect.Width, (int)rotA._rect.Height));
               
            }
            String s= (int)(  indexTool+1)+"."+ G.PropetyTools[indexTool].Name;
         SizeF sz=   gc.MeasureString(s, new Font("Arial", 10, FontStyle.Bold));
            gc.FillRectangle(Brushes.White, new Rectangle((int)rotA._rect.X, (int)rotA._rect.Y, (int)sz.Width,(int) sz.Height));
            gc.DrawString(s, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point((int)rotA._rect.X, (int)rotA._rect.Y));

            gc.ResetTransform();
            return gc;
        }

        public Graphics ShowEdit(Graphics gc, RectangleF _rect)
        {
            if (matTemp.Empty())
            {
                float angle = Propety.rotArea._rectRotation;
                if (Propety.rotArea._rectRotation < 0) angle = 360 + Propety.rotArea._rectRotation;
                 matCrop = RotateMat(BeeCore.Common.matRaw, new RotatedRect(new Point2f(Propety.rotArea._PosCenter.X, Propety.rotArea._PosCenter.Y), new Size2f(Propety.rotArea._rect.Width, Propety.rotArea._rect.Height), Propety.rotArea._angle));

                matTemp = Propety.SetColor(false, matCrop);
               
            }
           

            try
                {
                    Mat matShow = matTemp.Clone();
                   
                    Bitmap bmTemp = matShow.ToBitmap();
                    bmTemp.MakeTransparent(Color.Black);
                    bmTemp = G.EditTool.View.ChangeToColor(bmTemp, Color.LimeGreen, 0.6f);

                    gc.DrawImage(bmTemp, _rect);
                    //if (matMask != null)
                    //{
                    //    Bitmap myBitmap2 = matMask.ToBitmap();
                    //    myBitmap2.MakeTransparent(Color.Black);
                    //    myBitmap2 = G.EditTool.View.ChangeToColor(myBitmap2, Color.Orange, 0.9f);
                    //    myBitmap2.MakeTransparent(Color.Black);

                    //    gc.DrawImage(myBitmap2, _rect);
                    //}

                }
                catch (Exception ex) { 
            }
            return gc;
        }
       
        private void rjButton3_Click(object sender, EventArgs e)
        {

          
          //  cv3.Pattern();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            G.IsCheck = true;
            this.Parent.Controls.Remove(this);
            G.ToolSettings.Visible = true;
            btnGetColor.IsCLick = false;
            Propety.IsGetColor = btnGetColor.IsCLick;
        }
        
      
     
      
        public void Process()
        {
            if (G.rotPositionAdjustment != null)
                Propety.rotAreaAdjustment = G.EditTool.View.GetPositionAdjustment(Propety.rotArea, G.rotPositionAdjustment);
            else
                Propety.rotAreaAdjustment = Propety.rotArea;

           Mat matCrop = new Mat();
            
            if(G.IsCCD)
            {
                if (!G.IsRun)
                    bmRs = Propety.CheckColor(G.IsRun, BeeCore.Common.matRaw, Propety.rotArea);
                else
                    bmRs = Propety.CheckColor(G.IsRun, BeeCore.Common.matRaw, Propety.rotAreaAdjustment);
            }
              
            else
                {
                    if (G.IsRun)
                    {
                        matCrop = RotateMat(BeeCore.Common.matRaw, new RotatedRect(new Point2f(Propety.rotAreaAdjustment._PosCenter.X, Propety.rotAreaAdjustment._PosCenter.Y), new Size2f(Propety.rotAreaAdjustment._rect.Width, Propety.rotAreaAdjustment._rect.Height), Propety.rotAreaAdjustment._angle));

                    }
                    else
                    {
                        matCrop = RotateMat(BeeCore.Common.matRaw, new RotatedRect(new Point2f(Propety.rotArea._PosCenter.X, Propety.rotArea._PosCenter.Y), new Size2f(Propety.rotArea._rect.Width, Propety.rotArea._rect.Height), Propety.rotArea._angle));

                    }
               // bmRs = Propety.CheckColor(matCrop);// Compare(matCrop, EdgePixel.IsBitNot);

            }

        }
    
        private void threadProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            Process();



        }

        private void threadProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            G.EditTool.View.imgView.Invalidate();
          //  Cv2.ImShow("a", bmRs);
          //  G.EditTool.View.lbCycleTrigger.Text = "[" + Propety.cycleTime + "ms]";
        }

        private void trackScore_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackScore_MouseUp(object sender, MouseEventArgs e)
        {
           

            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }

      
        private void trackMaxOverLap_MouseUp(object sender, MouseEventArgs e)
        {
          

            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();
        }
        
      

     

      
      
      
        private void ToolOutLine_Load(object sender, EventArgs e)
        {
            TypeTool = TypeTool.Color_Area;
          
          
            Propety.pathRaw = G.EditTool.View.pathRaw;
        }

        private void ToolOutLine_VisibleChanged(object sender, EventArgs e)
        {

        }
      
        public ExtractColor ExtractColor;
       
        private void btnClear_Click(object sender, EventArgs e)
        {
           // Propety.SetRaw(BeeCore.Common.matRaw);
            
            //if (ExtractColor == null)
            //{

            //    ExtractColor = new ExtractColor(Propety);
            //    ExtractColor.Parent = this;
            //    ExtractColor.BringToFront();
            //    ExtractColor.Location = new System.Drawing.Point(this.Width / 2 - ExtractColor.Width / 2, this.Height / 2 - ExtractColor.Height / 2);
            //}




            btnGetColor.IsCLick = !Propety.IsGetColor;
            Propety.IsGetColor = btnGetColor.IsCLick;
            if (Propety.IsGetColor)
            {
               
               // ExtractColor.Show();
                G.EditTool.View.imgView.Cursor = new Cursor(Properties.Resources.Color_Dropper.Handle);
              
                G.IsCheck = false;
                G.EditTool.View.imgView.Invalidate();
            }
            else
                G.EditTool.View.imgView.Cursor = Cursors.Default;





            G.EditTool.View.imgView.Invalidate();

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCropRect_Click_1(object sender, EventArgs e)
        {
            G.TypeCrop = BeeCore.TypeCrop.Area;
            Propety.TypeCrop = G.TypeCrop;
            IsFullSize = false;
            if (Propety.rotAreaTemp != null)
                Propety.rotArea = Propety.rotAreaTemp.Clone();
            G.IsCheck = false;

            G.EditTool.View.imgView.Invalidate();
            G.EditTool.View.Cursor = Cursors.Default;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        bool IsFullSize;
        private void btnCropArea_Click_1(object sender, EventArgs e)
        {
            IsFullSize = true;
            Propety.rotAreaTemp = Propety.rotArea.Clone();
            Propety.rotArea = new RectRotate(new RectangleF(-BeeCore.Common.matRaw.Width / 2, -BeeCore.Common.matRaw.Height / 2, BeeCore.Common.matRaw.Width, BeeCore.Common.matRaw.Height), new PointF(BeeCore.Common.matRaw.Width / 2, BeeCore.Common.matRaw.Height / 2), 0, AnchorPoint.None);

            G.IsCheck = false;
            G.TypeCrop = BeeCore.TypeCrop.Area;
            Propety.TypeCrop = G.TypeCrop;

            G.EditTool.View.imgView.Invalidate();
            G.EditTool.View.Cursor = Cursors.Default;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            G.IsCancel = true;
            this.Parent.Controls.Remove(this);
            G.ToolSettings.Visible = true;
            btnGetColor.IsCLick = false;
            Propety.IsGetColor = btnGetColor.IsCLick;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Propety.StyleColor = 0;

        }

        private void btnClWhite_Click(object sender, EventArgs e)
        {
            Propety.StyleColor = 1;

            btnDeleteAll.PerformClick();
        }

        private void btnClBlack_Click(object sender, EventArgs e)
        {
            Propety.StyleColor = 2;

            btnDeleteAll.PerformClick();
        }

        private void trackScore_ValueChanged(int obj)
        {
            G.IsCheck = true;
            Propety.Score = trackScore.Value ;
            if (!threadProcess.IsBusy)
                threadProcess.RunWorkerAsync();

        }
       
        private void picColor_Click(object sender, EventArgs e)
        {
            
        }

        private void picColor_Paint(object sender, PaintEventArgs e)
        {
            int x = 0;int h = picColor.Height;int w = h;
            foreach (Color cl in Propety.listCLShow)
            {

                e.Graphics.FillRectangle(new SolidBrush( cl), new RectangleF(x, 0, w, h));
                e.Graphics.DrawRectangle(new Pen(Color.Black,1), new Rectangle(x, 0, w, h));
                x += w ;
            }
        }

        private void trackPixel_Validating(object sender, CancelEventArgs e)
        {

        }

        private void trackPixel_ValueChanged(int obj)
        {
            Propety.AreaPixel = trackPixel.Value;
            if(matCrop.Empty())
            {
                float angle = Propety.rotArea._rectRotation;
                if (Propety.rotArea._rectRotation < 0) angle = 360 + Propety.rotArea._rectRotation;
                matCrop = RotateMat(BeeCore.Common.matRaw, new RotatedRect(new Point2f(Propety.rotArea._PosCenter.X, Propety.rotArea._PosCenter.Y), new Size2f(Propety.rotArea._rect.Width, Propety.rotArea._rect.Height), Propety.rotArea._angle));


            }
            matTemp =  Propety.SetColor(false, matCrop);
            G.EditTool.View.imgView.Invalidate();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Propety.listCLShow.RemoveAt(Propety.listCLShow.Count - 1);
            G.EditTool.View.Undo(Propety);
            picColor.Invalidate();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {

            
           
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            Propety.listCLShow = new List<Color>();
            G.EditTool.View.ClearTemp(Propety);
            picColor.Invalidate();
        }

        private void pMode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMask_Click(object sender, EventArgs e)
        {

        }
    }
}
