using BeeCore;
using BeeDevice;
using BeeUi.Common;
using BeeUi.Commons;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;
using Timer = System.Windows.Forms.Timer;

namespace BeeUi
{
    [Serializable()]
    public partial class View : UserControl
    {
        public event System.Windows.Forms.PreviewKeyDownEventHandler PreviewKeyDown;
        public event KeyEventHandler KeyDown;
        public static bool IsKeyDown(Keys Key)
        {
            return (Control.ModifierKeys & Key) == Key;
        }
        Keys KeysOld;
        bool IsKeyPress = false;
        Timer tmKey = new Timer();
        public Mat matResgiter = null;
        private void KeyboardListener_s_KeyEventHandler(object sender, EventArgs e)
        {

            KeyboardListener.UniversalKeyEventArgs eventArgs = (KeyboardListener.UniversalKeyEventArgs)e;

            




                KeysOld = eventArgs.KeyCode;
                if (IsKeyDown(Keys.Control)&&!IsKeyPress)
                {
               
                if (eventArgs.KeyCode == Keys.Z)
                {
                    tmKey.Enabled = true;
                    IsKeyPress = true;
                    Undo(toolEdit.Propety);
                    imgView.Invalidate();

                }
                }
            
        }
              public View()
        {
            InitializeComponent();
            KeyboardListener.s_KeyEventHandler += new EventHandler(KeyboardListener_s_KeyEventHandler);
            tmKey.Tick += TmKey_Tick;
            tmKey.Interval = 50;
        }

        private void TmKey_Tick(object sender, EventArgs e)
        {
            IsKeyPress = false;
            tmKey.Enabled= false;
        }

        private void imgView_Click(object sender, EventArgs e)
        {
            
        }

        private void imgView_SizeChanged(object sender, EventArgs e)
        {

        }

        private void imgView_Resize(object sender, EventArgs e)
        {

        }

        private void imgView_BindingContextChanged(object sender, EventArgs e)
        {
            imgView.Size=new System.Drawing.Size(pView.Width, pView.Height);
        }
        bool IsRect = false;
        public AreaCrop _AreaCrop=AreaCrop.Rect;

        public Point pDown;
     
        private SizeF _dragSize;
        private PointF _dragStart,_dragCenter;
        private PointF _dragStartOffset;
        private RectangleF _dragRect;
        private AnchorPoint _dragAnchor;
        private Single _dragRot;
        bool _drag;
        private void ShowCursor( AnchorPoint anchorPoint ,float angle)
        {
            if (angle < 0) angle = 360 + angle;
            if (angle == 360) angle =0;
            //Cursor curLeft= Cursors.SizeNWSE;
            //Cursor curRight= Cursors.SizeNESW;
            Cursor curLeft = Cursors.Default;
            Cursor curRight = Cursors.Default;
            //if(angle<45)
            //{
            //    curLeft = Cursors.SizeNS;
            //    curRight = Cursors.SizeWE;
            //}
            //else if (angle <90)
            //{
            //    curLeft = Cursors.SizeNWSE;
            //    curRight = Cursors.SizeNESW;
            //}
            //else if (angle < 135)
            //{
            //    curLeft = Cursors.SizeNWSE;
            //    curRight = Cursors.SizeNESW;
            //}
            //else if (angle < 180)
            //{
            //    curLeft = Cursors.SizeNS;
            //    curRight = Cursors.SizeWE;
            //}
            //else if (angle < 225)
            //{
            //    curLeft = Cursors.SizeNS;
            //    curRight = Cursors.SizeWE;
            //}
            //else if (angle < 270)
            //{
            //    curLeft = Cursors.SizeNS;
            //    curRight = Cursors.SizeWE;
            //}
            //else
            //{
            //    curLeft = Cursors.SizeNS;
            //    curRight = Cursors.SizeWE;
            //}
            switch (anchorPoint)
            {
                case AnchorPoint.TopLeft:
                    this.Cursor = curLeft;
                    break;
                case AnchorPoint.TopRight:
                    this.Cursor = curRight;
                    break;
                case AnchorPoint.BottomLeft:
                    this.Cursor = curRight;
                    break;
                case AnchorPoint.BottomRight:
                    this.Cursor = curLeft;
                    break;
                case AnchorPoint.Rotation:
                    this.Cursor = Cursors.Default;
                    break;
                case AnchorPoint.Center:
                    this.Cursor = Cursors.Hand;
                    break;
                case AnchorPoint.None:
                    this.Cursor = Cursors.Default;
                    break;
            }
         }
        public void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        HierarchyIndex[] HierarchyIndex;
       OpenCvSharp.Point[][] contourOutLine;
     
      
    public    Mat matCrop=new Mat(),matTemp= new Mat();
        public Mat CropRotatedRect(Mat source, RotatedRect rect )
        {
          Mat matResult  = new Mat();
            RotatedRect rot = rect;
            Point2f pCenter = new Point2f(rot.Center.X , rot.Center.Y);
            Size2f rect_size = new Size2f(rot.Size.Width , rot.Size.Height );
            RotatedRect rot2 = new RotatedRect(pCenter, rect_size, rot.Angle);
            double angle = rot.Angle;
            if (angle < -45)
            {
                angle += 90.0;

                Swap(ref rect_size.Width, ref rect_size.Height);
            }



            InputArray M =Cv2.GetRotationMatrix2D(rot2.Center, angle, 1.0);

            Mat crop1 = new Mat(); 
            try
            {
                Cv2.WarpAffine(source, crop1, M, source.Size(), InterpolationFlags.Cubic);

                Cv2.GetRectSubPix(crop1, new OpenCvSharp.Size(rect_size.Width, rect_size.Height), rot2.Center, matResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            return matResult;
        }
        Color Renk = Color.Red;
        Point pMove;
        public Mat matClear,matMask;
        Rect rectClear = new Rect();
      public  int widthClear = 15;
        public Mat matRes = null;
        public Mat bmMask = null;
        public Mat matMaskAdd = null;
        public List<Mat> listMask = new List<Mat>();
        public List<Mat> listRedo= new List<Mat>();
        public void Undo(dynamic Propety)
        {
            toolEdit.matTemp = Propety.Undo(toolEdit.matCrop);
         
            imgView.Invalidate();
        }
        public void ClearTemp(dynamic Propety)
        {

            toolEdit.matTemp = toolEdit.Propety.ClearTemp();
           
            imgView.Invalidate();
        }
        public void RefreshMask()
        {
          bmMask = new Mat(BeeCore.Common.matRaw.Rows,BeeCore.Common.matRaw.Cols, MatType.CV_8UC1, Scalar.Black);

            Mat matGroup= new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1, Scalar.Black);
            foreach (Mat mat in listMask)
            {
               
                Cv2.BitwiseOr(mat, matGroup, bmMask);
               
            }
           
          imgView.Invalidate();
            imgView.Update();
        }
        public PointF RotatePoint(float angle, PointF pt)
        {
            var a = angle * System.Math.PI / 180.0;
            float cosa =(float) Math.Cos(a), sina =(float) Math.Sin(a);
            return new PointF((float)pt.X * cosa - pt.Y * sina, (float)pt.X * sina + pt.Y * cosa);
        }
        RectRotate rotateDraw = new RectRotate();
        bool IsDone = false;
        PointF ptRotatePt2f(PointF ptInput, PointF ptOrg, double dAngle)
        {
            double dWidth = ptOrg.X * 2;
            double dHeight = ptOrg.Y * 2;
            double dY1 = dHeight - ptInput.Y, dY2 = dHeight - ptOrg.Y;

            double dX = (ptInput.X - ptOrg.X) * Math.Cos(dAngle) - (dY1 - ptOrg.Y) * Math.Sin(dAngle) + ptOrg.X;
            double dY = (ptInput.X - ptOrg.X) * Math.Sin(dAngle) + (dY1 - ptOrg.Y) * Math.Cos(dAngle) + dY2;

            dY = -dY + dHeight;
            return new PointF((float)dX, (float)dY);
        }
        double rtTop, rtLeft, rtRight, rtBotton;
        public void BoundRotate( RectRotate rot)
        {
            float Fi = rot._rectRotation;
            double w = rot._rect.Width;
            double h = rot._rect.Height;

            double  H = w * Math.Abs(Math.Sin(Fi)) + h * Math.Abs(Math.Cos(Fi));
            double W = w * Math.Abs(Math.Cos(Fi)) + h * Math.Abs(Math.Sin(Fi));

            double   AS = Math.Abs(Math.Sin(Fi));
            double cs = Math.Abs(Math.Cos(Fi));
             h = (H * cs - W * AS) / ( cs*cs - AS*AS);
             w = -(H * AS - W * cs) / (cs * cs - AS * AS);
            rtTop = w * cs;
            rtRight = h * cs;
            rtBotton = h * AS ;
            rtLeft = w * AS;
         
        }
        Color clChoose;
        private void imgView_MouseMove(object sender, MouseEventArgs e)
        {
            pMove = e.Location;
                if (G.IsRun) return;
            if (toolEdit != null)
                if (toolEdit.TypeTool == TypeTool.Color_Area)
            {
              
                    if (toolEdit.Propety.IsGetColor)
                        imgView.Cursor = new Cursor(Properties.Resources.Color_Dropper.Handle);
                    else
                        imgView.Cursor = Cursors.Default;
                    if (toolEdit.Propety.IsGetColor)
                    {
                        if(!workGetColor.IsBusy)
                        workGetColor.RunWorkerAsync();
                        return;
                    }
                }

            try
            {
                if (toolEdit == null) return;

                RectRotate rotateRect = new RectRotate();
                if (toolEdit.IsClear)
                {
                    if (_drag)
                    {

                        rectClear = new Rect(e.Location.X - widthClear/2, e.Location.Y + widthClear / 4, widthClear, widthClear);
                        bmp = new Mat(rectClear.Width, rectClear.Height, MatType.CV_8UC1, Scalar.White);
                        bmp.CopyTo(new Mat(matMaskAdd, rectClear));
                        bmp.CopyTo(new Mat(bmMask, rectClear));
                      
                      
                    }

                }

         
                pDown = e.Location;
                //this.Cursor = Cursors.Default;
            
                    if (_drag)
                    {
                        if (G.TypeCrop == TypeCrop.Area)
                        {

                            // if(toolEdit.Propety.rotCrop._rectRotation.Contains(toolEdit.Propety.rotArea._rectRotation))
                            if (toolEdit.Propety.rotArea == null)
                                return;
                            rotateRect = new RectRotate(toolEdit.Propety.rotArea._rect, toolEdit.Propety.rotArea._PosCenter, toolEdit.Propety.rotArea._rectRotation, toolEdit.Propety.rotArea._dragAnchor);
                        }
                        else if (G.TypeCrop == TypeCrop.Mask)
                        {

                            // if(toolEdit.Propety.rotCrop._rectRotation.Contains(toolEdit.Propety.rotArea._rectRotation))
                            if (toolEdit.Propety.rotMask == null)
                                return;
                            rotateRect = new RectRotate(toolEdit.Propety.rotMask._rect, toolEdit.Propety.rotMask._PosCenter, toolEdit.Propety.rotMask._rectRotation, toolEdit.Propety.rotMask._dragAnchor);
                        }
                        else
                        {
                            if (toolEdit.Propety.rotCrop == null)
                                return;
                            rotateRect = new RectRotate(toolEdit.Propety.rotCrop._rect, toolEdit.Propety.rotCrop._PosCenter, toolEdit.Propety.rotCrop._rectRotation, toolEdit.Propety.rotCrop._dragAnchor);
                        }
                        var mat = new Matrix();

                        mat.Translate(_dragCenter.X, _dragCenter.Y);
                        mat.Rotate(rotateRect._rectRotation);
                        mat.Invert();

                        var point = mat.TransformPoint(new PointF(e.X, e.Y));

                        SizeF deltaSize=new SizeF();
                        PointF clamped;
                        float deltaX = 0, deltaY = 0;
                        switch (rotateRect._dragAnchor)
                        {
                            case AnchorPoint.TopLeft:
                                
                                IsDone = true;
                                clamped = new PointF(Math.Min(0, point.X), Math.Min(0, point.Y));
                                deltaSize = new SizeF(clamped.X - _dragStart.X, clamped.Y - _dragStart.Y);
                               
                                rotateRect._rect = new RectangleF(
                                       _dragRect.Left + deltaSize.Width/2,
                                       _dragRect.Top +deltaSize.Height/2,
                                       _dragRect.Width - deltaSize.Width,
                                       _dragRect.Height - deltaSize.Height);
                                deltaX = deltaSize.Width/2; deltaY = deltaSize.Height/2;

                                break;

                            case AnchorPoint.TopRight:

                                clamped = new PointF(Math.Max(0, point.X), Math.Min(0, point.Y));
                                deltaSize = new SizeF(clamped.X - _dragStart.X, clamped.Y - _dragStart.Y);
                              //  if (deltaSize.Width < 2 && deltaSize.Height < 2) return;
                                rotateRect._rect = new RectangleF(
                                    _dragRect.Left- deltaSize.Width/2,
                                    _dragRect.Top + deltaSize.Height/2,
                                    _dragRect.Width + deltaSize.Width,
                                    _dragRect.Height - deltaSize.Height);
                                deltaX = deltaSize.Width/2; deltaY = deltaSize.Height/2;
                                break;

                            case AnchorPoint.BottomLeft:

                                clamped = new PointF(Math.Min(0, point.X), Math.Max(0, point.Y));
                                deltaSize = new SizeF(clamped.X - _dragStart.X, clamped.Y - _dragStart.Y);
                                rotateRect._rect = new RectangleF(
                                    _dragRect.Left + deltaSize.Width/2,
                                    _dragRect.Top - deltaSize.Height/2,
                                    _dragRect.Width - deltaSize.Width,
                                    _dragRect.Height + deltaSize.Height);
                                deltaX = deltaSize.Width/2; deltaY = deltaSize.Height/2;
                             
                                break;

                            case AnchorPoint.BottomRight:

                                clamped = new PointF(Math.Max(0, point.X), Math.Max(0, point.Y));
                                deltaSize = new SizeF(clamped.X - _dragStart.X, clamped.Y - _dragStart.Y);
                                rotateRect._rect = new RectangleF(
                                    _dragRect.Left - deltaSize.Width/2,
                                    _dragRect.Top - deltaSize.Height/2,
                                    _dragRect.Width + deltaSize.Width,
                                    _dragRect.Height + deltaSize.Height);
                                deltaX = deltaSize.Width/2; deltaY = deltaSize.Height/2;
                                break;

                            case AnchorPoint.Rotation:
                               
                                var vecX = point.X;
                                var vecY = -point.Y;

                                var len = Math.Sqrt(vecX * vecX + vecY * vecY);

                                var normX = vecX / len;
                                var normY = vecY / len;

                                //In rectangles's space, 
                                //compute dot product between, 
                                //Up and mouse-position vector
                                var dotProduct = (0 * normX + 1 * normY);
                                var angle = Math.Acos(dotProduct);

                                if (point.X < 0)
                                    angle = -angle;

                                // Add (delta-radians) to rotation as degrees
                                float fAngle = (float)((180 / Math.PI) * angle);
                                if (fAngle != float.NaN&& fAngle!=0)
                                    rotateRect._rectRotation += fAngle;

                                break;

                            case AnchorPoint.Center:

                                //move this in screen-space
                                rotateRect._PosCenter = new PointF(e.X - _dragStartOffset.X, e.Y - _dragStartOffset.Y);
                                break;
                        }
                       
                        if (rotateRect._dragAnchor != AnchorPoint.None)
                        {
                          
                            if(rotateRect._dragAnchor != AnchorPoint.Center)
                            if (deltaX != 0 || deltaY != 0)
                            {
                                PointF pDelta = RotatePoint(rotateRect._rectRotation, new PointF(deltaX, deltaY));

                                rotateRect._PosCenter = new PointF(_dragCenter.X + pDelta.X, _dragCenter.Y + pDelta.Y);
                               
                                IsDone = false;
                            }
                            if (G.TypeCrop == TypeCrop.Area)
                            {
                                float x = rotateRect._PosCenter.X - rotateRect._rect.Width/2;
                                float y = rotateRect._PosCenter.Y - rotateRect._rect.Height/2;
                                float w = rotateRect._rect.Width; float h = rotateRect._rect.Height;
                                if (x<0)
                                {

                                    rotateRect._PosCenter = new PointF(rotateRect._PosCenter.X - x, rotateRect._PosCenter.Y);
                                }
                                else if (x + w > BeeCore.Common.matRaw.Width)
                                {

                                    rotateRect._PosCenter = new PointF(rotateRect._PosCenter.X - (x + w - BeeCore.Common.matRaw.Width), rotateRect._PosCenter.Y);
                                }
                                  if (y < 0)
                                {

                                    rotateRect._PosCenter = new PointF(rotateRect._PosCenter.X, rotateRect._PosCenter.Y- y);
                                }
                               
                                else if (y + h > BeeCore.Common.matRaw.Height)
                                {

                                    rotateRect._PosCenter = new PointF(rotateRect._PosCenter.X , rotateRect._PosCenter.Y -(y+h - BeeCore.Common.matRaw.Height));
                                }
                                if (toolEdit.Propety.rotCrop != null)
                                {
                                    RectRotate rectRotate1 = toolEdit.Propety.rotCrop;
                                    RotatedRect rot = new RotatedRect(new Point2f(rectRotate1._PosCenter.X, rectRotate1._PosCenter.Y), new Size2f(rectRotate1._rect.Width, rectRotate1._rect.Height), rectRotate1._rectRotation);
                                    Rect bound = rot.BoundingRect();
                                    RectRotate rectRotate2 = rotateRect;
                                    RectangleF rectF = new RectangleF(rectRotate2._PosCenter.X + rectRotate2._rect.X, rectRotate2._PosCenter.Y + rectRotate2._rect.Y, rectRotate2._rect.Width, rectRotate2._rect.Height);

                                    if (!rectF.Contains(new PointF(bound.X, bound.Y)) ||
                                       !rectF.Contains(new PointF(bound.X + bound.Width, bound.Y)) ||
                                       !rectF.Contains(new PointF(bound.X, bound.Y + bound.Height)) ||
                                       !rectF.Contains(new PointF(bound.X + bound.Width, bound.Y + bound.Height)))
                                        return;
                                     }
                            if (rotateRect == null) return;
                            toolEdit.Propety.rotArea = new RectRotate(new RectangleF(rotateRect._rect.X, rotateRect._rect.Y, rotateRect._rect.Width, rotateRect._rect.Height), new PointF(rotateRect._PosCenter.X, rotateRect._PosCenter.Y), rotateRect._rectRotation, rotateRect._dragAnchor);

                        }
                        else if (G.TypeCrop == TypeCrop.Crop)
                            {
                                RotatedRect rot = new RotatedRect(new Point2f(rotateRect._PosCenter.X, rotateRect._PosCenter.Y), new Size2f(rotateRect._rect.Width, rotateRect._rect.Height), rotateRect._rectRotation);
                               Rect bound= rot.BoundingRect();
                                RectRotate rectRotate2 = toolEdit.Propety.rotArea;
                                RectangleF rectF = new RectangleF(rectRotate2._PosCenter.X + rectRotate2._rect.X, rectRotate2._PosCenter.Y + rectRotate2._rect.Y, rectRotate2._rect.Width, rectRotate2._rect.Height);
                             
                             if(!rectF.Contains(new PointF( bound.X,bound.Y))||
                                !rectF.Contains(new PointF(bound.X+bound.Width, bound.Y)) ||
                                !rectF.Contains(new PointF(bound.X, bound.Y+bound.Height))||
                                !rectF.Contains(new PointF(bound.X + bound.Width, bound.Y + bound.Height)) )
                                    return;

                                if (rotateRect == null) return;
                                toolEdit.Propety.rotCrop = new RectRotate(new RectangleF( rotateRect._rect.X, rotateRect._rect.Y, rotateRect._rect.Width, rotateRect._rect.Height),new PointF( rotateRect._PosCenter.X, rotateRect._PosCenter.Y), rotateRect._rectRotation, rotateRect._dragAnchor);
                            }

                             else
                            {
                                RotatedRect rot = new RotatedRect(new Point2f(rotateRect._PosCenter.X, rotateRect._PosCenter.Y), new Size2f(rotateRect._rect.Width, rotateRect._rect.Height), rotateRect._rectRotation);
                                Rect bound = rot.BoundingRect();
                                RectRotate rectRotate2 = toolEdit.Propety.rotArea;
                                RectangleF rectF = new RectangleF(rectRotate2._PosCenter.X + rectRotate2._rect.X, rectRotate2._PosCenter.Y + rectRotate2._rect.Y, rectRotate2._rect.Width, rectRotate2._rect.Height);

                                if (!rectF.Contains(new PointF(bound.X, bound.Y)) ||
                                   !rectF.Contains(new PointF(bound.X + bound.Width, bound.Y)) ||
                                   !rectF.Contains(new PointF(bound.X, bound.Y + bound.Height)) ||
                                   !rectF.Contains(new PointF(bound.X + bound.Width, bound.Y + bound.Height)))
                                    return;

                                if (rotateRect == null) return;
                                toolEdit.Propety.rotMask = new RectRotate(new RectangleF(rotateRect._rect.X, rotateRect._rect.Y, rotateRect._rect.Width, rotateRect._rect.Height), new PointF(rotateRect._PosCenter.X, rotateRect._PosCenter.Y), rotateRect._rectRotation, rotateRect._dragAnchor);
                            }
                        }
                        if (G.TypeCrop == TypeCrop.Crop||toolEdit.Propety.rotCrop==null)
                        {

                        if (toolEdit.Propety.TypeTool != TypeTool.Color_Area)
                            if (rotateRect != null)
                            {
                              //  toolEdit.matTemp = toolEdit.Propety.Processing(BeeCore.Common.matRaw);

                                toolEdit.matTemp = toolEdit.Propety.GetTemp(rotateRect, BeeCore.Common.matRaw, bmMask);
                            }
                        //GetTemp(RectRotate rotateRect, Mat BeeCore.Common.matRaw, Mat bmMask,  Mat matClear, ref Mat matMask, ref Mat matTemp)

                    }



                }
                    else
                    {
                        int IsCheck = 0 ;
                        if (!toolEdit.IsClear)
                        {
                            G.TypeCrop = TypeCrop.Crop;
                          
                            X:
                            if (toolEdit.Propety.rotCrop == null)
                                G.TypeCrop = TypeCrop.Area;
                            if (G.TypeCrop == TypeCrop.Area)
                            {

                                if (toolEdit.Propety.rotArea == null) return;
                                rotateRect = new RectRotate(toolEdit.Propety.rotArea._rect, toolEdit.Propety.rotArea._PosCenter, toolEdit.Propety.rotArea._rectRotation, toolEdit.Propety.rotArea._dragAnchor);
                            }
                            else if (G.TypeCrop == TypeCrop.Mask)
                            {

                                if (toolEdit.Propety.rotMask == null) return;
                                rotateRect = new RectRotate(toolEdit.Propety.rotMask._rect, toolEdit.Propety.rotMask._PosCenter, toolEdit.Propety.rotMask._rectRotation, toolEdit.Propety.rotMask._dragAnchor);
                            }
                            else
                            {
                                if (toolEdit.Propety.rotCrop == null) return;
                                rotateRect = new RectRotate(toolEdit.Propety.rotCrop._rect, toolEdit.Propety.rotCrop._PosCenter, toolEdit.Propety.rotCrop._rectRotation, toolEdit.Propety.rotCrop._dragAnchor);
                            }
                            var mat = new Matrix();
                            mat.Translate(rotateRect._PosCenter.X, rotateRect._PosCenter.Y);
                            mat.Rotate(rotateRect._rectRotation);
                            mat.Invert();
                            // Mouse point in Rectangle's space. 
                            var point = mat.TransformPoint(new PointF(e.X, e.Y));

                            RectangleF _rect = rotateRect._rect;
                           
                            var rect = new RectangleF(rotateRect._rect.X - 5, rotateRect._rect.Y - 5, rotateRect._rect.Width+ 10, rotateRect._rect.Height +10);
                            if (G.TypeCrop == TypeCrop.Area)
                                rect = new RectangleF(rotateRect._rect.X - 20, rotateRect._rect.Y - 20, rotateRect._rect.Width +40, rotateRect._rect.Height+40);

                            var rectTopLeft = new RectangleF(_rect.Left - 5f, _rect.Top - 5f, 10f, 10f);
                            var rectTopRight = new RectangleF(_rect.Left + _rect.Width - 5f, _rect.Top - 5f, 10f, 10f);
                            var rectBottomLeft = new RectangleF(_rect.Left - 5f, _rect.Top + _rect.Height - 5f, 10f, 10f);
                            var rectBottomRight = new RectangleF(_rect.Left + _rect.Width - 5f, _rect.Top + _rect.Height - 5f, 10f, 10f);
                            var rectRotate = new RectangleF(-5, _rect.Top - 30, 20f, 20f);
                            _dragCenter = new PointF(rotateRect._PosCenter.X, rotateRect._PosCenter.Y);
                            if (rectTopLeft.Contains(point))
                            {
                                _dragStart = new PointF(point.X, point.Y);
                                rotateRect._dragAnchor = AnchorPoint.TopLeft;
                                _dragRect = new RectangleF(_rect.Left, _rect.Top, _rect.Width, _rect.Height);

                            }
                            else if (rectTopRight.Contains(point))
                            {

                                _dragStart = new PointF(point.X, point.Y);
                                rotateRect._dragAnchor = AnchorPoint.TopRight;
                                _dragRect = new RectangleF(_rect.Left, _rect.Top, _rect.Width, _rect.Height);
                            }
                            else if (rectBottomLeft.Contains(point))
                            {

                                _dragStart = new PointF(point.X, point.Y);
                                rotateRect._dragAnchor = AnchorPoint.BottomLeft;
                                _dragRect = new RectangleF(_rect.Left, _rect.Top, _rect.Width, _rect.Height);
                            }
                            else if (rectBottomRight.Contains(point))
                            {

                                _dragStart = new PointF(point.X, point.Y);
                                rotateRect._dragAnchor = AnchorPoint.BottomRight;
                                _dragRect = new RectangleF(_rect.Left, _rect.Top, _rect.Width, _rect.Height);
                            }
                            else if (rectRotate.Contains(point) )
                            {

                                _dragStart = new PointF(point.X, point.Y);
                                rotateRect._dragAnchor = AnchorPoint.Rotation;
                                _dragRect = new RectangleF(_rect.Left, _rect.Top, _rect.Width, _rect.Height);
                                _dragRot = rotateRect._rectRotation;
                            }
                            else if (rect.Contains(point))
                            {
                               
                                _dragStart = new PointF(point.X, point.Y);
                                rotateRect._dragAnchor = AnchorPoint.Center;
                                _dragRect = new RectangleF(_rect.Left, _rect.Top, _rect.Width, _rect.Height);
                                _dragStartOffset = new PointF(e.X - rotateRect._PosCenter.X, e.Y - rotateRect._PosCenter.Y);
                            }

                            else
                            {

                                rotateRect._dragAnchor = AnchorPoint.None;
                                var rectNone = new RectangleF(rotateRect._rect.X + rotateRect._rect.Width / 4, rotateRect._rect.Y + rotateRect._rect.Height / 4, rotateRect._rect.Width + rotateRect._rect.Width / 2, rotateRect._rect.Height + rotateRect._rect.Height / 2);

                                if (IsCheck == 0)
                                {
                                  
                                  
                                    if (!rectNone.Contains(point))
                                    {
                                         if (toolEdit.Propety.rotMask == null|| toolEdit.Propety.rotCrop == null)
                                        {
                                            IsCheck+=2;
                                            G.IsCheck = false;
                                            G.TypeCrop = TypeCrop.Area;
                                            goto X;
                                        }
                                        else
                                        {
                                            IsCheck++; G.IsCheck = false;
                                            G.TypeCrop = TypeCrop.Mask;
                                            goto X;
                                        }
                                    }
                                    else
                                    {

                                    }

                                    
                                }
                                else   if (IsCheck == 1)
                                {

                                    if (!rectNone.Contains(point))
                                    {
                                        IsCheck++; G.IsCheck = false;
                                        G.TypeCrop = TypeCrop.Area;
                                        goto X;
                                    }
                                }
                                else
                                {

                                    //G.IsCheck = true;
                                    if (!toolEdit.threadProcess.IsBusy)
                                        toolEdit.threadProcess.RunWorkerAsync();
                                    if (toolEdit.Propety.rotCrop == null)
                                        G.TypeCrop = TypeCrop.Area;
                                    else
                                    G.TypeCrop = TypeCrop.Crop;
                                }
                                
                            }

                            if (G.TypeCrop == TypeCrop.Area)
                                toolEdit.Propety.rotArea._dragAnchor = rotateRect._dragAnchor;
                            else if (G.TypeCrop == TypeCrop.Mask)
                                toolEdit.Propety.rotMask._dragAnchor = rotateRect._dragAnchor;
                            else
                                toolEdit.Propety.rotCrop._dragAnchor = rotateRect._dragAnchor;
                        }
                      
                    }
                if (rotateRect._dragAnchor != AnchorPoint.None)
                    G.IsCheck = false;
              //  rotateDraw = rotateRect.Clone();
                //  ShowCursor(rotateRect._dragAnchor, rotateRect._rectRotation);
                imgView.Invalidate();
            }
            catch(Exception ex)
            {

            }
        }


      
        private void imgView_MouseDown(object sender, MouseEventArgs e)
        {
            if (toolEdit == null) return;
            pDown = e.Location;
            _drag = true;
            if (toolEdit.IsClear)
                return;
            //if (G.TypeCrop == TypeCrop.Area && toolEdit.Propety.rotArea._dragAnchor == AnchorPoint.None ||
            //    G.TypeCrop == TypeCrop.Crop && toolEdit.Propety.rotCrop._dragAnchor == AnchorPoint.None)
            //{
            //    G.IsCheck = true;
            //}
            //else
            //{
            //    G.IsCheck = false;
              
              
                if (toolEdit.Propety.TypeTool == TypeTool.Color_Area)
                {
              
                    if (toolEdit.Propety.IsGetColor)
                        toolEdit.Propety.AddColor();
                
             

                }
           // }
         
              
            imgView.Invalidate();
        }
        bool _isPaint;
        float _thiness = 2;
      public   bool IsLoad = false;
        Graphics g;
        Mat  bmp = new Mat(10, 10,MatType.CV_8UC1,Scalar.White);
        bool Durum;
        int x = 5;

      public  Bitmap ChangeToColor(Bitmap bmp, Color c, float opacity)
        {
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            using (Graphics g = Graphics.FromImage(bmp2))
            {
                float tr = c.R / 255f;
                float tg = c.G / 255f;
                float tb = c.B / 255f;

                ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                  {
                 new float[] {0, 0, 0, 0, 0},
                 new float[] {0, 0, 0, 0, 0},
                 new float[] {0, 0, 0, 0, 0},
                 new float[] {0, 0, 0, opacity, 0},
                 new float[] {tr, tg, tb, 0, 1}  // kudos to OP!
                  });
              
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(colorMatrix);

                g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp2;
        }



        private TypeCrop IsTypeArea()
        {
            return G.TypeCrop;
              
        }
      
        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
        //public RectRotate GetPositionAdjustment(RectRotate rotOrigin, RectRotate rotTemp)
        //{
        //    if (G.Y_Adjustment == 0) return rotOrigin;
        //    System.Drawing.Size sz = BeeCore.Common.SizeCCD();
        //    RectRotate rot = new RectRotate();

        //    rot._rect = rotOrigin._rect;

        //    PointF pPos = new PointF(rotTemp._PosCenter.X + G.X_Adjustment, rotTemp._PosCenter.Y + G.Y_Adjustment);
        //    double DeltaX = rotOrigin._PosCenter.X - rotTemp._PosCenter.X;
        //    double DeltaY = rotOrigin._PosCenter.Y - rotTemp._PosCenter.Y;
        //    double angle1 = Math.Atan(G.Y_Adjustment / G.X_Adjustment) * 180 / Math.PI;

        //    double angle2 = 90 - Math.Abs(angle1);
        //    rot._rectRotation = rotOrigin._rectRotation +(float) angle2+G.angle_Adjustment;
        //    int dauX = 1; int dauY = 1;
        //    if (DeltaX != 0)
        //        dauX = DeltaX > 0 ? 1 : -1;
        //    if (DeltaY != 0)
        //        dauY = DeltaY > 0 ? 1 : -1;
        //       double cos1 = Math.Cos((angle2) * Math.PI / 180);
        //       double sin1 = Math.Sin((angle2) * Math.PI / 180);

        //    double R = GetDistance(rotOrigin._PosCenter.X, rotOrigin._PosCenter.Y, rotTemp._PosCenter.X, rotTemp._PosCenter.Y);
        //    double DelX =R* cos1;
        //    double DelY = R * sin1;



        //    rot._PosCenter = new PointF(pPos.X - (float)DelX , pPos.Y -(float)DelY * dauY);
        //    double R2 = GetDistance(rot._PosCenter.X, rot._PosCenter.Y, pPos.X, pPos.Y);

        //    return rot;
        //}

        public RectRotate GetPositionAdjustment(RectRotate rotOrigin, RectRotate rotTemp)
        {
            System.Drawing.Size sz = BeeCore.Common.SizeCCD();
            RectRotate rot = new RectRotate();

            rot._rect = rotOrigin._rect;
            rot._rectRotation = rotOrigin._rectRotation + G.angle_Adjustment;
            PointF pPos = new PointF(rotTemp._PosCenter.X + G.X_Adjustment, rotTemp._PosCenter.Y + G.Y_Adjustment);
            double DeltaX = rotOrigin._PosCenter.X - rotTemp._PosCenter.X;
            double DeltaY = rotOrigin._PosCenter.Y - rotTemp._PosCenter.Y;
            int dauX = 1; int dauY = 1;
            if (DeltaX != 0)
                dauX = DeltaX > 0 ? 1 : -1;
            if (DeltaY != 0)
                dauY = DeltaY > 0 ? 1 : -1;

            double angle1 = Math.Atan(Math.Abs( DeltaY / DeltaX)) * 180 / Math.PI;
         

            //    angle1 = 180 - angle1;
            //else if (DeltaX < 0 && DeltaY > 0)
            //    angle1 = - angle1;
            //if(angle1<0) angle1 = 360 + angle1;
            double distance = GetDistance(rotOrigin._PosCenter.X, rotOrigin._PosCenter.Y, rotTemp._PosCenter.X, rotTemp._PosCenter.Y);
            double angle2 = angle1 - G.angle_Adjustment;
            if (DeltaX > 0 && DeltaY < 0)
                angle2 = angle1 - G.angle_Adjustment;
            else if (DeltaX > 0 && DeltaY > 0)
                angle2 = -angle1 - G.angle_Adjustment;
            else if (DeltaX < 0 && DeltaY < 0)
                angle2 = angle1 + G.angle_Adjustment;
           // else if (DeltaX < 0 && DeltaY > 0)
           //     angle2 = -angle1- G.angle_Adjustment;
            double cos1 = Math.Cos((angle2) * Math.PI / 180);
            double sin1 = Math.Sin((angle2) * Math.PI / 180);
            double DeltaX1 = distance * cos1;
            double DeltaY1 = distance * sin1;

            if (DeltaX > 0 && DeltaY > 0)
                DeltaY1 = -DeltaY1;
          // else if (DeltaX < 0 && DeltaY < 0)
                //DeltaY1 = -DeltaY1;
            rot._PosCenter = new PointF(pPos.X + (float)DeltaX1 * dauX, pPos.Y + (float)DeltaY1*dauY );

            return rot;
        }
        Graphics gc;
        
        private void imgView_Paint(object sender, PaintEventArgs e)
        {
            

                if (G.IsRun)
                {
              

                    //  gcResult = gc;

                    return;
                }
               


                    gc = e.Graphics;

                var mat = new Matrix();
                int index = 0;
                if (G.Config.IsShowCenter)
                {
                    e.Graphics.DrawLine(new Pen(Brushes.Blue, 1), imgView.Width / 2, 0, imgView.Width / 2, imgView.Height);
                    e.Graphics.DrawLine(new Pen(Brushes.Blue, 1), 0, imgView.Height / 2, imgView.Width, imgView.Height / 2);
                }
                if (G.Config.IsShowGird)
                {
                    int W = imgView.Width, H = imgView.Height;
                    int step = Math.Min(W, H) / 15;
                    for (int x = step; x < W; x += step)
                        e.Graphics.DrawLine(new Pen(Brushes.Gray, 1), x, 0, x, imgView.Height);
                    for (int y = step; y < W; y += step)
                        e.Graphics.DrawLine(new Pen(Brushes.Gray, 1), 0, y, imgView.Width, y);
                }
                if (G.Config.IsShowArea)
                {
                    int indexTool = 0;
                    foreach (Tools tool in G.listAlltool)
                    {
                        RectRotate rot = tool.tool.Propety.rotArea;
                        mat = new Matrix();
                        mat.Translate(rot._PosCenter.X, rot._PosCenter.Y);
                        mat.Rotate(rot._rectRotation);
                        RectangleF _rect3 = rot._rect;
                        gc.Transform = mat;
                        gc.DrawRectangle(new Pen(Color.Blue, 1), new Rectangle((int)_rect3.X, (int)_rect3.Y, (int)_rect3.Width, (int)_rect3.Height));
                        String s = (int)(indexTool + 1) + "." + G.PropetyTools[indexTool].Name;
                        SizeF sz = gc.MeasureString(s, new Font("Arial", 10, FontStyle.Bold));
                        gc.FillRectangle(Brushes.White, new Rectangle((int)rot._rect.X, (int)rot._rect.Y, (int)sz.Width, (int)sz.Height));
                        gc.DrawString(s, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point((int)rot._rect.X, (int)rot._rect.Y));
                        indexTool++;
                        gc.ResetTransform();
                    }

                }
                if (toolEdit != null)
                    foreach (Tools tool in G.listAlltool)
                    {
                        if (index != toolEdit.indexTool || !G.IsEdit)
                        {
                            RectRotate rot = tool.tool.Propety.rotArea;
                            mat = new Matrix();
                            mat.Translate(rot._PosCenter.X, rot._PosCenter.Y);
                            mat.Rotate(rot._rectRotation);
                            RectangleF _rect3 = rot._rect;
                            gc.Transform = mat;
                            gc.DrawRectangle(new Pen(Color.Cornsilk, 2), new Rectangle((int)_rect3.X, (int)_rect3.Y, (int)_rect3.Width, (int)_rect3.Height));
                            gc.ResetTransform();
                        }
                        index++;
                    }

                if (!G.IsEdit)
                {
                    return;
                }
                if (toolEdit == null)
                    return;
                if (imgView.Image == null)
                    return;

                RectangleF _rect = new RectangleF(); ;
                PointF _rectPos = new PointF(); ;
                Single _rectRotation = 0;
                AnchorPoint _dragAnchor = AnchorPoint.None;
                Pen penRect = new Pen(Color.Orange, 2);

                switch (IsTypeArea())
                {
                    case TypeCrop.Area:
                        if (toolEdit.Propety.rotArea != null)
                        {
                            _rect = toolEdit.Propety.rotArea._rect;
                            _rectPos = toolEdit.Propety.rotArea._PosCenter;
                            _rectRotation = toolEdit.Propety.rotArea._rectRotation;
                            _dragAnchor = toolEdit.Propety.rotArea._dragAnchor;
                            penRect = new Pen(Color.DeepSkyBlue, 2);
                        }
                        else return;
                        break;
                    case TypeCrop.Crop:
                        {
                            if (toolEdit.Propety.rotCrop != null)
                            {
                                _rect = toolEdit.Propety.rotCrop._rect;
                                _rectPos = toolEdit.Propety.rotCrop._PosCenter;
                                _rectRotation = toolEdit.Propety.rotCrop._rectRotation;
                                _dragAnchor = toolEdit.Propety.rotCrop._dragAnchor;
                                penRect = new Pen(Color.Orange, 2);
                            }

                        }
                        break;
                    case TypeCrop.Mask:
                        {
                            if (toolEdit.Propety.rotMask != null)
                            {
                                _rect = toolEdit.Propety.rotMask._rect;
                                _rectPos = toolEdit.Propety.rotMask._PosCenter;
                                _rectRotation = toolEdit.Propety.rotMask._rectRotation;
                                _dragAnchor = toolEdit.Propety.rotMask._dragAnchor;
                                penRect = new Pen(Color.FromArgb(100, 111, 211, 213), 2);
                            }
                            else return;
                        }
                        break;
                }

                if (G.TypeCrop == TypeCrop.Area)
                {
                    //Crop
                    if (toolEdit.Propety.rotCrop != null)
                    {
                        mat = new Matrix();
                        mat.Translate(toolEdit.Propety.rotCrop._PosCenter.X, toolEdit.Propety.rotCrop._PosCenter.Y);
                        mat.Rotate(toolEdit.Propety.rotCrop._rectRotation);
                        RectangleF _rect2 = toolEdit.Propety.rotCrop._rect;
                        gc.Transform = mat;
                        gc.DrawRectangle(new Pen(Color.Silver, 2), new Rectangle((int)_rect2.X, (int)_rect2.Y, (int)_rect2.Width, (int)_rect2.Height));
                        gc.ResetTransform();
                    }
                    //Mask
                    if (toolEdit.Propety.rotMask != null)
                    {
                        mat = new Matrix();
                        mat.Translate(toolEdit.Propety.rotMask._PosCenter.X, toolEdit.Propety.rotMask._PosCenter.Y);
                        mat.Rotate(toolEdit.Propety.rotMask._rectRotation);
                        RectangleF _rect2 = toolEdit.Propety.rotMask._rect;
                        gc.Transform = mat;
                        gc.FillRectangle(new SolidBrush(Color.FromArgb(70, 111, 211, 213)), new Rectangle((int)_rect2.X, (int)_rect2.Y, (int)_rect2.Width, (int)_rect2.Height));
                        gc.ResetTransform();
                    }

                }
                else if (G.TypeCrop == TypeCrop.Crop)
                {
                    //Area
                    mat = new Matrix();
                    mat.Translate(toolEdit.Propety.rotArea._PosCenter.X, toolEdit.Propety.rotArea._PosCenter.Y);
                    mat.Rotate(toolEdit.Propety.rotArea._rectRotation);
                    RectangleF _rect2 = toolEdit.Propety.rotArea._rect;
                    gc.Transform = mat;
                    gc.DrawRectangle(new Pen(Color.LightGray, 2), new Rectangle((int)_rect2.X, (int)_rect2.Y, (int)_rect2.Width, (int)_rect2.Height));
                    gc.ResetTransform();
                    //Mask
                    if (toolEdit.Propety.rotMask != null)
                    {
                        mat = new Matrix();
                        mat.Translate(toolEdit.Propety.rotMask._PosCenter.X, toolEdit.Propety.rotMask._PosCenter.Y);
                        mat.Rotate(toolEdit.Propety.rotMask._rectRotation);
                        _rect2 = toolEdit.Propety.rotMask._rect;
                        gc.Transform = mat;
                        gc.FillRectangle(new SolidBrush(Color.FromArgb(70, 111, 211, 213)), new Rectangle((int)_rect2.X, (int)_rect2.Y, (int)_rect2.Width, (int)_rect2.Height));
                        gc.ResetTransform();
                    }
                }
                else
                { //Crop
                    if (toolEdit.Propety.rotCrop != null)
                    {
                        mat = new Matrix();
                        mat.Translate(toolEdit.Propety.rotCrop._PosCenter.X, toolEdit.Propety.rotCrop._PosCenter.Y);
                        mat.Rotate(toolEdit.Propety.rotCrop._rectRotation);
                        RectangleF _rect3 = toolEdit.Propety.rotCrop._rect;
                        gc.Transform = mat;
                        gc.DrawRectangle(new Pen(Color.Silver, 2), new Rectangle((int)_rect3.X, (int)_rect3.Y, (int)_rect3.Width, (int)_rect3.Height));
                        gc.ResetTransform();
                    }
                    //Area
                    mat = new Matrix();
                    mat.Translate(toolEdit.Propety.rotArea._PosCenter.X, toolEdit.Propety.rotArea._PosCenter.Y);
                    mat.Rotate(toolEdit.Propety.rotArea._rectRotation);
                    RectangleF _rect2 = toolEdit.Propety.rotArea._rect;
                    gc.Transform = mat;
                    gc.DrawRectangle(new Pen(Color.LightGray, 2), new Rectangle((int)_rect2.X, (int)_rect2.Y, (int)_rect2.Width, (int)_rect2.Height));
                    gc.ResetTransform();


                }
                var backNone = new SolidBrush(Color.FromArgb(10, 220, 220, 220));
                mat = new Matrix();


                try
                {
                    if (_rectRotation == float.NaN) return;
                    mat = new Matrix();
                    mat.Translate(_rectPos.X, _rectPos.Y);
                    mat.Rotate(_rectRotation);
                    gc.Transform = mat;
                    var rectTopLeft = new RectangleF(_rect.Left - 5f, _rect.Top - 5f, 10f, 10f);
                    var rectTopRight = new RectangleF(_rect.Left + _rect.Width - 5f, _rect.Top - 5f, 10f, 10f);
                    var rectBottomLeft = new RectangleF(_rect.Left - 5f, _rect.Top + _rect.Height - 5f, 10f, 10f);
                    var rectBottomRight = new RectangleF(_rect.Left + _rect.Width - 5f, _rect.Top + _rect.Height - 5f, 10f, 10f);
                    var rectRotate = new RectangleF(-5, _rect.Top + -30, 20f, 20f);
                    var rectCenter = new RectangleF(-5, -5, 10f, 10f);

                    var backNG = new SolidBrush(Color.FromArgb(0, 0, 0, 255));
                    var backChoose = new SolidBrush(Color.FromArgb(60, 255, 205, 35));
                    var cornerNone = new SolidBrush(Color.OrangeRed);
                    var cornerChoose = new SolidBrush(Color.Blue);
                    var _clX = new Pen(Color.LightGray, 1);
                    var _clY = new Pen(Color.Gray, 1);
                    if (!G.IsCheck)
                    {
                        if (G.TypeCrop == TypeCrop.Crop || toolEdit.Propety.rotCrop == null)
                            toolEdit.ShowEdit(gc, _rect);

                        else if (G.TypeCrop == TypeCrop.Mask)
                            gc.FillRectangle(new SolidBrush(Color.FromArgb(90, 111, 211, 213)), new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));

                        switch (_dragAnchor)
                        {
                            case AnchorPoint.None:
                                gc.DrawRectangle(penRect, new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));
                                gc.FillEllipse(cornerNone, rectTopLeft);
                                gc.FillEllipse(cornerNone, rectTopRight);
                                gc.FillEllipse(cornerNone, rectBottomLeft);
                                gc.FillEllipse(cornerNone, rectBottomRight);
                                gc.DrawImage(Properties.Resources.Rotate, rectRotate);
                                //gc.FillRectangle(cornerNone, rectCenter);
                                break;

                            case AnchorPoint.TopLeft:
                                // gc.FillRectangle(backNone, _rect);
                                gc.DrawRectangle(penRect, new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));
                                gc.FillEllipse(cornerChoose, rectTopLeft);
                                gc.FillEllipse(cornerNone, rectTopRight);
                                gc.FillEllipse(cornerNone, rectBottomLeft);
                                gc.FillEllipse(cornerNone, rectBottomRight);
                                gc.DrawImage(Properties.Resources.Rotate, rectRotate);
                                // gc.FillRectangle(cornerNone, rectCenter);
                                break;
                            case AnchorPoint.TopRight:
                                //  gc.FillRectangle(backNone, _rect);
                                gc.DrawRectangle(penRect, new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));
                                gc.FillEllipse(cornerNone, rectTopLeft);
                                gc.FillEllipse(cornerChoose, rectTopRight);
                                gc.FillEllipse(cornerNone, rectBottomLeft);
                                gc.FillEllipse(cornerNone, rectBottomRight);
                                gc.DrawImage(Properties.Resources.Rotate, rectRotate);
                                break;
                            case AnchorPoint.BottomLeft:
                                //  gc.FillRectangle(backNone, _rect);
                                gc.DrawRectangle(penRect, new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));
                                gc.FillEllipse(cornerNone, rectTopLeft);
                                gc.FillEllipse(cornerNone, rectTopRight);
                                gc.FillEllipse(cornerChoose, rectBottomLeft);
                                gc.FillEllipse(cornerNone, rectBottomRight);
                                gc.DrawImage(Properties.Resources.Rotate, rectRotate);
                                break;
                            case AnchorPoint.BottomRight:
                                //gc.FillRectangle(backNone, _rect);
                                gc.DrawRectangle(penRect, new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));
                                gc.FillEllipse(cornerNone, rectTopLeft);
                                gc.FillEllipse(cornerNone, rectTopRight);
                                gc.FillEllipse(cornerNone, rectBottomLeft);
                                gc.FillEllipse(cornerChoose, rectBottomRight);
                                gc.DrawImage(Properties.Resources.Rotate, rectRotate);
                                break;
                            case AnchorPoint.Center:
                                // gc.FillRectangle(backChoose, _rect);
                                gc.DrawRectangle(penRect, new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));
                                gc.FillEllipse(cornerNone, rectTopLeft);
                                gc.FillEllipse(cornerNone, rectTopRight);
                                gc.FillEllipse(cornerNone, rectBottomLeft);
                                gc.FillEllipse(cornerNone, rectBottomRight);
                                gc.DrawImage(Properties.Resources.Rotate, rectRotate);
                                break;
                            case AnchorPoint.Rotation:
                                // gc.FillRectangle(backNone, _rect);
                                gc.DrawRectangle(penRect, new Rectangle((int)_rect.X, (int)_rect.Y, (int)_rect.Width, (int)_rect.Height));
                                gc.FillEllipse(cornerNone, rectTopLeft);
                                gc.FillEllipse(cornerNone, rectTopRight);
                                gc.FillEllipse(cornerNone, rectBottomLeft);
                                gc.FillEllipse(cornerNone, rectBottomRight);
                                gc.DrawImage(Properties.Resources.Rotate2, rectRotate);
                                break;


                        }
                        if (toolEdit.IsClear && _drag)
                        {
                            gc.ResetTransform();
                            gc.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 255, 255)), new Rectangle(rectClear.X, rectClear.Y, widthClear, widthClear));
                            gc.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(rectClear.X, rectClear.Y, widthClear, widthClear));

                        }

                    }
                    if (G.IsCheck)
                        gc = toolEdit.ShowResult(gc);
                    gc.ResetTransform();

                    if (toolEdit.Propety.IsGetColor)
                    {
                        e.Graphics.DrawEllipse(new Pen(clChoose, 5), new Rectangle(new Point(pMove.X - 25, pMove.Y - 25), new Size(50, 50)));
                    }
                }
                catch (Exception)
                {

                }
            
           
        }
        public void tool_MouseMove(object sender, MouseEventArgs e)
        {

         //   G.IsCheck = false;
            imgView.Invalidate();
        }
        private void View_Load(object sender, EventArgs e)
        {
         if(G.IsCCD)
             tmCheckCCD.Enabled = true;
            // toolEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tool_MouseMove);
            BeeCore.Common.matRaw= BeeCore.Common.GetImageRaw(G.Config.TypeCamera);
            if (BeeCore.Common.matRaw!=null)
                if (!BeeCore.Common.matRaw.Empty())
                    imgView.ImageIpl = BeeCore.Common.matRaw;
            BeeCore.Common.FrameChanged += Common_FrameChanged;
        }

        private void Common_FrameChanged(object sender, PropertyChangedEventArgs e)
        {
            G.EditTool.lbFrameRate.Text = BeeCore.Common.FrameRate+" fps ";
        }

        public dynamic toolEdit;
      
        public void CurrentTool()
        {
            
            switch(toolEdit.Propety.TypeTool)
             {
                case TypeTool.OutLine:
                
                    
                    toolEdit.OutLinepathRaw = pathRaw;
                    toolEdit.OutLineIsProcess = IsProcess;
                    break;
                case  TypeTool.Pattern:


                    toolEdit.OutLinepathRaw = pathRaw;
                    toolEdit.OutLineIsProcess = IsProcess;
                    break;
            }
        }
        public void ToolMouseUp()
        {
            if (toolEdit == null) return;
            if(toolEdit.IsClear)
            {

                listMask.Add(matMaskAdd.Clone());
                matMaskAdd = new Mat(BeeCore.Common.matRaw.Rows, BeeCore.Common.matRaw.Cols, MatType.CV_8UC1, Scalar.Black);
               
            }
          
            switch (toolEdit.Propety.TypeTool)
            {
                case TypeTool.OutLine:
                case TypeTool.Pattern:
                   
                case TypeTool.Position_Adjustment:
                    if (toolEdit.Propety.rotCrop != null)
                        if (toolEdit.Propety.rotCrop._rect.Width != 0 && toolEdit.Propety.rotCrop._rect.Height != 0)
                        {
                            toolEdit.Propety.LearnPattern(toolEdit.indexTool, toolEdit.matTemp);

                        }
                    break;
                case TypeTool.Color_Area:
                  
                    toolEdit.matTemp = toolEdit.GetTemp( toolEdit.Propety.rotArea);
                    break;
            }
            //if (G.IsCheck)
            //    if (!toolEdit.threadProcess.IsBusy)
            //        toolEdit.threadProcess.RunWorkerAsync();
        }
        private void cbView_SelectedIndexChanged(object sender, EventArgs e)
        {
          //BeeCore.G.WindowView= (WindowView)Enum.Parse(typeof(WindowView), cbView.Text.Trim(), true);

          //  IsProcess = Convert.ToBoolean( (int)BeeCore.G.WindowView);
          //  CurrentTool();
        }
       public  String pathRaw;
       public bool IsProcess;

        private void workUndo_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }

        private void workUndo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
           
        }

        public String[] listPath;
        public int indexTool = 0; int indexImg = 0;
        private void btnPlay_Click(object sender, EventArgs e)
        {
            G.IsRun = true;
          
            if (!workPlay.IsBusy)
            workPlay.RunWorkerAsync();
            indexImg++;
            if (indexImg >= listPath.Count()) indexImg = 0;
              BeeCore.Common.ReadCCD(G.Config.IsHist, G.Config.TypeCamera);
            BeeCore.Common.matRaw = BeeCore.Common.GetImageRaw(G.Config.TypeCamera);
        }

        private void tmTool_Tick(object sender, EventArgs e)
        {
            if (indexTool < G.listAlltool.Count)
            {
                if (!G.listAlltool[indexTool].tool.threadProcess.IsBusy)
                    G.listAlltool[indexTool].tool.threadProcess.RunWorkerAsync();
            }    
                indexTool++;
        }
       
      public  DateTime tmCycle;
      
        int indexToolPosition = -1;
        bool IsAutoTrig;
        OutLine ParaPosition;
        private void workPlay_DoWork(object sender, DoWorkEventArgs e)
        {
           
            if (G.IsCap)
            {
                if (IsCapOne)
                {
                    foreach (Tools tool in G.listAlltool)
                    {
                       
                            tool.tool.Process();

                    }
                    return;
                    
                }    
                      BeeCore.Common.ReadCCD(G.Config.IsHist, G.Config.TypeCamera);

                if (G.StatusTrig == Trig.None)
                {
                    indexToolPosition = G.listAlltool.FindIndex(a => a.TypeTool == TypeTool.Position_Adjustment);
                    if (indexToolPosition > -1 && G.PropetyTools[indexToolPosition].Propety.IsAutoTrig)
                    {
                        ParaPosition = (OutLine)G.listAlltool[indexToolPosition].tool.Propety;
                        IsAutoTrig = ParaPosition.IsAutoTrig;
                        G.StatusTrig = Trig.Processing;
                    }
                    else
                    {
                        foreach (Tools tool in G.listAlltool)
                        {

                            tool.tool.Process();

                        }
                        return;
                    }
                }
                else if (G.StatusTrig == Trig.Processing || G.StatusTrig == Trig.NotTrig)
                {
                    G.listAlltool[indexToolPosition].tool.Process();
                    if (ParaPosition.IsOK && G.StatusTrig == Trig.Processing)
                    {
                        ParaPosition.numTempOK++;
                        if (ParaPosition.numTempOK >= ParaPosition.NumOK)
                        {
                            ParaPosition.numTempOK = 0;
                            G.StatusTrig = Trig.Trigged;


                        }
                    }
                    else if (!ParaPosition.IsOK && G.StatusTrig == Trig.Processing)
                    {
                        ParaPosition.numTempOK = 0;
                    }


                    if (!ParaPosition.IsOK && G.StatusTrig == Trig.NotTrig)
                    {
                        ParaPosition.numTempOK++;
                        if (ParaPosition.numTempOK >= ParaPosition.NumOK)
                        {
                            ParaPosition.numTempOK = 0;
                            G.StatusTrig = Trig.Complete;


                        }
                    }
                    else if (ParaPosition.IsOK && G.StatusTrig == Trig.NotTrig)
                    {
                        ParaPosition.numTempOK = 0;
                    }
                    return;

                }


                    else if (G.StatusTrig == Trig.Continue)
                {
                   
                    foreach (Tools tool in G.listAlltool)
                    {
                        if (tool.TypeTool != TypeTool.Position_Adjustment)
                            tool.tool.Process();

                    }
                }
            }

            else
            {
                BeeCore.Common.matRaw = BeeCore.Common.LoadImage(listPath[indexImg], ImreadModes.AnyColor);
                pathRaw = listPath[indexImg];

            }
            
             
                 
              
              
            
        }
        [DllImport("KERNEL32.DLL", EntryPoint =
   "SetProcessWorkingSetSize", SetLastError = true,
   CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize32Bit
   (IntPtr pProcess, int dwMinimumWorkingSetSize,
   int dwMaximumWorkingSetSize);

        [DllImport("KERNEL32.DLL", EntryPoint =
           "SetProcessWorkingSetSize", SetLastError = true,
           CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize64Bit
           (IntPtr pProcess, long dwMinimumWorkingSetSize,
           long dwMaximumWorkingSetSize);
        bool IsProcessing=false;
        Stopwatch stopWatch = new Stopwatch();

        int DelayTrig;
        Graphics graphicsOld;
        public void SQL_Insert(DateTime time, String model, int Qty, int Total, String Status, Mat raw,Bitmap rs)
        {
            if (!G.Config.IsSaveOK)
            {
                if(Status.Contains("OK"))
                {
                    return;
                }    
            }
            if (!G.Config.IsSaveNG)
            {
                if (Status.Contains("NG"))
                {
                    return;
                }
            }
            if (G.cnn.State == ConnectionState.Closed)
                G.cnn.Open();
            String pathRaw, pathRS;
            String date = DateTime.Now.ToString("yyyyMMdd");
            String Hour= DateTime.Now.ToString("HHmmss");
            pathRaw = "Report//" + date + "//Raw";
            pathRS = "Report//" + date + "//Result";
            if (!Directory.Exists(pathRaw))
            {
              
                Directory.CreateDirectory(pathRaw);
            }
            if (!Directory.Exists(pathRS))
            {
                Directory.CreateDirectory(pathRS);
            }
            SqlCommand command = new SqlCommand();
            command.Connection = G.cnn;
            String Model = Properties.Settings.Default.programCurrent.Replace(".prog", "");
            String Sql = "";
            command.CommandText = "INSERT into Report (Date,Model,Qty,Total,Status,Raw,Result) VALUES(@Date,@Model,@Qty,@Total,@Status,@Raw,@Result)";
            command.Prepare();
            command.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateTime.Now;             // 1
            command.Parameters.AddWithValue("@Model", model);                                             // 2                                                                                                      //  command.Parameters.Add("@Time", MySqlDbType.DateTime).Value = DateTime.Now;             // 3
            command.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;                                             // 4
            command.Parameters.Add("@Total", SqlDbType.Int).Value = Total;                                        // 5
            command.Parameters.AddWithValue("@Status", Status);                                           // 6
            command.Parameters.AddWithValue("@Raw", pathRaw+ "//"+ Model + "_"+ Hour+".png");// imageToByteArray(raw);         // 7
            command.Parameters.AddWithValue("@Result", pathRS + "//" + Model + "_" + Hour + ".png"); ;   // 8
            command.ExecuteNonQuery();
            Mat matRs = rs.ToMat();
            switch(G.Config.TypeSave)
            {
                case 1: 
                    Cv2.PyrDown(matRs, matRs);
                    Cv2.PyrDown(matRs, matRs);
                    Cv2.PyrDown(raw, raw);
                    Cv2.PyrDown(raw, raw);
                    break;
                case 2: 
                    Cv2.PyrDown(matRs, matRs);
                    Cv2.PyrDown(raw, raw);
                    break;
            }    
            if(G.Config.IsSaveRaw)
            Cv2.ImWrite( pathRaw + "//" + Model + "_"+ Hour + ".png", raw);
            if (G.Config.IsSaveRS)
                Cv2.ImWrite(pathRS + "//" + Model + "_" + Hour + ".png", matRs);


        }
      
        public void ShowResultTotal()
        {
         
            int indexTool = 0;
            int numToolOK = 0;
            G.TotalOK = true;
            if(bmResult!=null)
                bmResult.Dispose();
            // BeeCore.Common.matRaw= BeeCore.Common.GetImageRaw();
            //imgView.ImageIpl = BeeCore.Common.matRaw;
           // Cv2.ImShow("A", BeeCore.Common.matRaw);
            bmResult = new Bitmap(BeeCore.Common.matRaw.ToBitmap(),
                                    BeeCore.Common.matRaw.Width, BeeCore.Common.matRaw.Height);
            gc = Graphics.FromImage(bmResult);
            foreach (Tools tool in G.listAlltool)
            {
                // G.PropetyTools[indexTool]
                SumCycle += tool.tool.Propety.cycleTime;
                tool.tool.ShowResult(gc);
                tool.ItemTool.lbCycle.Text = tool.tool.Propety.cycleTime + " ms";
                tool.ItemTool.lbScore.Text = tool.tool.Propety.ScoreRs + "";
                tool.ItemTool.Score.ValueScore = tool.tool.Propety.ScoreRs;
                if (tool.tool.Propety.IsOK)
                {
                    switch (G.Config.ConditionOK)
                    {
                        case ConditionOK.TotalOK:
                            numToolOK++;
                            break;
                        case ConditionOK.AnyOK:
                            numToolOK++;
                            break;
                        case ConditionOK.Logic:
                            if (G.PropetyTools[indexTool].UsedTool == UsedTool.Invertse)
                            {
                                G.TotalOK = false;
                            }
                            break;
                    }
                    if (G.Config.ConditionOK == ConditionOK.Logic)
                    {
                        if (G.PropetyTools[indexTool].UsedTool == UsedTool.Used)
                        {
                            tool.ItemTool.lbStatus.Text = "OK";
                            tool.ItemTool.Score.ColorTrack = Color.FromArgb(0, 172, 73);
                            tool.ItemTool.lbScore.ForeColor = Color.FromArgb(0, 172, 73);
                            tool.ItemTool.lbStatus.BackColor = Color.FromArgb(0, 172, 73);
                        }
                        else
                        {
                            tool.ItemTool.Score.ColorTrack = Color.DarkRed;
                            tool.ItemTool.lbStatus.Text = "NG";
                            tool.ItemTool.lbScore.ForeColor = Color.DarkRed;
                            tool.ItemTool.lbStatus.BackColor = Color.DarkRed;
                        }
                    }
                    else
                    {
                        tool.ItemTool.lbStatus.Text = "OK";
                        tool.ItemTool.Score.ColorTrack = Color.FromArgb(0, 172, 73);
                        tool.ItemTool.lbScore.ForeColor = Color.FromArgb(0, 172, 73);
                        tool.ItemTool.lbStatus.BackColor = Color.FromArgb(0, 172, 73);
                    }    
                }

                else
                {
                    switch (G.Config.ConditionOK)
                    {
                        
                      
                        case ConditionOK.Logic:
                            if (G.PropetyTools[indexTool].UsedTool == UsedTool.Used)
                            {
                                G.TotalOK = false;
                            }
                            break;
                    }
                    if (G.Config.ConditionOK == ConditionOK.Logic)
                    {
                        if (G.PropetyTools[indexTool].UsedTool != UsedTool.Used)
                        {
                            tool.ItemTool.lbStatus.Text = "OK";
                            tool.ItemTool.Score.ColorTrack = Color.FromArgb(0, 172, 73);
                            tool.ItemTool.lbScore.ForeColor = Color.FromArgb(0, 172, 73);
                            tool.ItemTool.lbStatus.BackColor = Color.FromArgb(0, 172, 73);
                        }
                        else
                        {
                            tool.ItemTool.Score.ColorTrack = Color.DarkRed;
                            tool.ItemTool.lbStatus.Text = "NG";
                            tool.ItemTool.lbScore.ForeColor = Color.DarkRed;
                            tool.ItemTool.lbStatus.BackColor = Color.DarkRed;
                        }
                    }
                    else
                    {
                        tool.ItemTool.Score.ColorTrack = Color.DarkRed;
                        tool.ItemTool.lbStatus.Text = "NG";
                        tool.ItemTool.lbScore.ForeColor = Color.DarkRed;
                        tool.ItemTool.lbStatus.BackColor = Color.DarkRed;
                    }
                 
                }
               
                indexTool++;
            }
            switch (G.Config.ConditionOK)
            {
                case ConditionOK.TotalOK:
                    if (numToolOK < G.listAlltool.Count)
                        G.TotalOK = false;
                    else
                        G.TotalOK = true;
                    break;
                case ConditionOK.AnyOK:
                    if (numToolOK >= G.Config.numToolOK)
                        G.TotalOK = true;
                    else
                        G.TotalOK = false;
                    break;

            }
            if (G.TotalOK)
            {
                lbStatus.Text = "OK";
                lbStatus.BackColor = Color.FromArgb(255, 27, 186, 98);
                if (!G.IsModeTest)
                    G.SumOK++;
                try
                {
                    if (G.Header.SerialPort.IsOpen)
                    {
                        G.Header.SerialPort.WriteLine("True");
                        }
                    else
                    {
                        G.Header.SerialPort.Open();
                        G.Header.SerialPort.WriteLine("True");
                             }
                       
                }
                catch(Exception ex)
                {

                }
            
            }
            else
            {
                lbStatus.Text = "NG";
                lbStatus.BackColor = Color.DarkRed;
                if (!G.IsModeTest)
                    G.SumNG++;
             
                try
                {
                    if (G.Header.SerialPort.IsOpen)
                    {
                        G.Header.SerialPort.WriteLine("False");
                      
                    }
                    else
                    {
                        G.Header.SerialPort.Open();
                        G.Header.SerialPort.WriteLine("False");
                     
                    }
                }
                catch (Exception ex)
                {
                  //  MessageBox.Show(ex.Message);
                }
            }
            imgView.Image =(Image) bmResult.Clone();
            if(!G.IsModeTest)
            if (G.Config.IsSaveOK || G.Config.IsSaveNG)
            {
                if (!workInsert.IsBusy)
                {
                    workInsert.RunWorkerAsync();
                }
            }
            

            lbSumOK.Text = G.SumOK + ""; lbSumNG.Text= G.SumNG + "";
            SumCycle += BeeCore.Common.Cycle;
            lbCycleTrigger.Text = (int)SumCycle + " ms";
            SumCycle = 0;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {

                SetProcessWorkingSetSize32Bit(System.Diagnostics
                   .Process.GetCurrentProcess().Handle, -1, -1);

            }
            btnCap.Enabled = true;
        }
        public float SumCycle = 0;
        private void workPlay_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (IsCapOne)
            {
                ShowResultTotal();
                IsCapOne = false;
                btnCap.IsCLick = false;
              
                G.IsCap = false;
                if (G.Header.SerialPort.IsOpen)
                {
                
                G.Header.SerialPort.Write("OffTrig");

                    //  G.Header.SerialPort.WriteLine("OffTrig");
                }
                return;
            }
            if (IsAutoTrig==false)
            {
                ShowResultTotal();
                  indexTool = 0; G.IsCap = false;
              
             
                if (btnRecord.IsCLick)
                {
                    

                    G.IsCap = true;

                  
                    if (IsAutoTrig)
                        workPlay.RunWorkerAsync();
                    else
                        workReadCCD.RunWorkerAsync();
                }
                else
                {
                    G.IsCap = false;
                }
                if (G.Header.SerialPort.IsOpen)
                {
                    Thread.Sleep(100);
                    G.Header.SerialPort.WriteLine("OffTrig");
                  //  G.Header.SerialPort.WriteLine("OffTrig");
                }
                return;
            }
           
                if (G.StatusTrig==Trig.Continue)
            {
                G.StatusTrig = Trig.NotTrig;
                ShowResultTotal();


                indexTool = 0; G.IsCap = false;
              
                if (btnRecord.IsCLick)
                {
                   

                    G.IsCap = true;

                    if (IsAutoTrig)
                        
                        workPlay.RunWorkerAsync();
                    else
                            if (!workReadCCD.IsBusy)
                            workReadCCD.RunWorkerAsync();
                }
                else
                {
                    G.IsCap = false;
                }



            }

           else if (G.StatusTrig == Trig.NotTrig|| G.StatusTrig==Trig.Processing)
            {
               Mat matCCD    = BeeCore.Common.GetImageRaw(G.Config.TypeCamera);

                Tools tool = G.listAlltool[indexToolPosition];
                  
                OutLine Para = (OutLine)G.listAlltool[indexToolPosition].tool.Propety;
                RectRotate rot = Para.rotArea;
                float angle = rot._rectRotation;
                if (rot._rectRotation < 0) angle = 360 + rot._rectRotation;
                Mat matCrop = G.EditTool.View.CropRotatedRect(matCCD, new RotatedRect(new Point2f(rot._PosCenter.X + (rot._rect.Width / 2 + rot._rect.X), rot._PosCenter.Y + (rot._rect.Height / 2 + rot._rect.Y)), new Size2f(rot._rect.Width, rot._rect.Height), angle));

                matCrop.CopyTo(new Mat(BeeCore.Common.matRaw, new Rect((int)rot._PosCenter.X + (int)rot._rect.X, (int)rot._PosCenter.Y + (int)rot._rect.Y, (int)rot._rect.Width, (int)rot._rect.Height)));
                imgView.ImageIpl = BeeCore.Common.matRaw;
               
            
                DelayTrig = Para.DelayTrig;
                tmTrig.Interval = 1;
                tmTrig.Enabled = true;
                return;
            }
            else if (G.StatusTrig==Trig.Trigged)
            {
              
                BeeCore.Common.matRaw = BeeCore.Common.GetImageRaw(G.Config.TypeCamera);
                imgView.ImageIpl = BeeCore.Common.matRaw;
                tmTrig.Enabled = true;
                tmTrig.Interval = DelayTrig;
                return;
            }
            else if (G.StatusTrig == Trig.Complete)
            {

               // BeeCore.Common.matRaw = BeeCore.Common.GetImageRaw();
                //imgView.ImageIpl = BeeCore.Common.matRaw;
                tmTrig.Enabled = true;
                tmTrig.Interval = DelayTrig;
                return;
            }


        }
        public bool IsCapOne = false;
        Graphics gcResult;
        private void btnCap_Click(object sender, EventArgs e)
        {
            if (!G.IsRun) 
                return;
            if (btnRecord.IsCLick)
            {
               
                btnCap.IsCLick = false;
                MessageBox.Show("Please stop Mode Continue");
                return;
            }
            if (btnLive.IsCLick)
            {
              
                btnCap.IsCLick = false;
                MessageBox.Show("Please stop Mode Live");
                return;
            }
            btnCap.Enabled = false;
         
            G.IsCap = true;
            //if (G.Header.SerialPort.IsOpen)
            //    G.Header.SerialPort.Write("Ligh");
            //Thread.Sleep(1000);
            //gcResult = gc;
            // gc =imgView.CreateGraphics();

            tmCycle = DateTime.Now;
            IsCapOne = true;
            if (!workReadCCD.IsBusy) workReadCCD.RunWorkerAsync();
          //  if (!workPlay.IsBusy)
              //  workPlay.RunWorkerAsync();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
           
            if (btnLive.IsCLick)
            {
                btnRecord.IsCLick = false;
               
                MessageBox.Show("Please stop Mode LIVE");
                return;
            }    
            if (btnRecord.IsCLick)
            {
              
              
                G.IsCap = true;
                //gc = imgView.CreateGraphics();
                tmCycle = DateTime.Now;
                if (!workReadCCD.IsBusy) workReadCCD.RunWorkerAsync();
                //if (!workPlay.IsBusy)
                //    workPlay.RunWorkerAsync();
            }
            else
            {
                G.IsCap = false;
                btnCap.IsCLick = false;
            }    
           // tmPlay.Enabled = btnRecord.IsCLick;
         
        }

        private void tmPlay_Tick(object sender, EventArgs e)
        {
           
            tmPlay.Enabled = false;
        }
        public void Live()
        {
            gc = imgView.CreateGraphics();
            if (!workReadCCD.IsBusy)
                workReadCCD.RunWorkerAsync();

        }
        private void btnSer_Click(object sender, EventArgs e)
        {
            if (btnRecord.IsCLick)
            {
                btnLive.IsCLick = false;
             
                MessageBox.Show("Please stop Mode Continue");
                return;
            }
            if(G.Config.TypeCamera==TypeCamera.USB)
            {
                if (G.Header.SerialPort.IsOpen)
                {
                   
                 
                    //  G.Header.SerialPort.WriteLine("OffTrig");
                }
                Live();
            }
          
            else if (G.Config.TypeCamera == TypeCamera.TinyIV)
            {
                BeeCore.Common.ReadCCD(G.Config.IsHist, G.Config.TypeCamera);
                BeeCore.Common.IsLive = btnLive.IsCLick;
                if (btnLive.IsCLick)
                    BeeCore.Common.PropertyChanged += Common_PropertyChanged;
                else
                    BeeCore.Common.PropertyChanged -= Common_PropertyChanged;
            }
            if (BeeCore.Common.matRaw != null)
                if (!BeeCore.Common.matRaw.Empty())
                    G.EditTool.View.imgView.Location = new Point(G.EditTool.View.pView.Width / 2 - BeeCore.Common.matRaw.Width / 2, G.EditTool.View.pView.Height / 2 - BeeCore.Common.matRaw.Height / 2);
            if (btnLive.IsCLick)
            {
                if (G.Header.SerialPort.IsOpen)
                    G.Header.SerialPort.WriteLine("Live");
            }

            else
            {
                if (G.Header.SerialPort.IsOpen)
                    G.Header.SerialPort.WriteLine("Capture");
            }
        }

        public void Common_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
            imgView.ImageIpl = BeeCore.Common.matLive;
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

        private void workReadCCD_DoWork(object sender, DoWorkEventArgs e)
        {
            if (G.Config.TypeCamera == TypeCamera.USB)
            {
                BeeCore.Common.ReadCCD(G.Config.IsHist, G.Config.TypeCamera);
                BeeCore.Common.matRaw = BeeCore.Common.GetImageRaw(G.Config.TypeCamera);
            }
            else
            {
                if (BeeCore.Common.matLive != null)
                    if (!BeeCore.Common.matLive.Empty())
                        BeeCore.Common.matRaw = BeeCore.Common.matLive.Clone();
            }    
        }
       public Bitmap bmResult;
        private void workReadCCD_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            //  Cv2.ImShow("Result",BeeCore.Common.matRaw);

            //  bmResult = new Bitmap(OpenCvSharp.Extensions.BitmapConverter.ToBitmap( imgView.ImageIpl));
            //gc= Graphics.FromImage(bmResult);
            // imgView.Invalidate();
            if (btnLive.IsCLick)
            {
                if (imgView.ImageIpl!=null)
                imgView.ImageIpl.Dispose();
                imgView.ImageIpl = BeeCore.Common.matRaw.Clone();
                workReadCCD.RunWorkerAsync();
            } 
            else if (G.IsCap)
            {
               
                if (!workPlay.IsBusy)
                    workPlay.RunWorkerAsync();
              
            }
                
        }

        private void workShow_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }
      
        private void tmTrig_Tick(object sender, EventArgs e)
        {
            if (!btnRecord.IsCLick)
            {
                tmTrig.Enabled = false;
                return;
            }
            if (G.StatusTrig==Trig.Trigged)
            {
              
                G.StatusTrig = Trig.Continue;
                tmTrig.Enabled = false;
                tmCycle = DateTime.Now;
                 G.listAlltool[indexToolPosition].tool.ShowResult(gc);
                tmTrig.Enabled = false;
                if (!workReadCCD.IsBusy)
                    workReadCCD.RunWorkerAsync();
            }

            else if (G.StatusTrig == Trig.Complete)
            {

                G.StatusTrig = Trig.Processing;
                tmTrig.Enabled = false;
                tmCycle = DateTime.Now;
                G.listAlltool[indexToolPosition].tool.ShowResult(gc);
                tmTrig.Enabled = false;
                if(!workPlay.IsBusy)
                workPlay.RunWorkerAsync();
            }
          
            else
            {

                foreach (Tools tool in G.listAlltool)
                {
                  
                  
                    tool.tool.ShowResult(gc);

                }
               // G.listAlltool[indexToolPosition].tool.ShowResult(gc);
                //  BeeCore.Common.ReadCCD(G.Config.IsHist );
                tmTrig.Enabled = false;
                if (!workPlay.IsBusy)
                    workPlay.RunWorkerAsync();
            }
          
           
         
        }

        private void workShow_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
       
        }

        private void btnShowSetting_Click(object sender, EventArgs e)
        {
            if (G.Config.TypeCamera == TypeCamera.USB)
                BeeCore.Common.Setting();
            else if (G.Config.TypeCamera == TypeCamera.TinyIV)
            {
                SettingDevice settingDevice = new SettingDevice();
            
                settingDevice.Show();
               
              
            }
           
        }

        private void workGetColor_DoWork(object sender, DoWorkEventArgs e)
        {
           
                        clChoose = toolEdit.Propety.GetColor(BeeCore.Common.matRaw,pMove.X-10, pMove.Y+10);
                      
                 
        }

        private void workGetColor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            imgView.Invalidate();
        }

        private void btnResetQty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn Xóa dữ liệu Sản Xuất", "Xóa Tất cả dữ liệu hôm nay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                String date = DateTime.Now.ToString("yyyyMMdd");
                G.cnn.Close();
                String path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.Combine(Environment.CurrentDirectory, "Report") + "\\" + date + ".mdf" + ";Integrated Security=True;Connect Timeout=30"; ;
                con = new SqlConnection(path);
                con.Open();
                SqlServer sqlServer = new SqlServer();
                sqlServer.Delete("Report", "Model='" + Properties.Settings.Default.programCurrent.Replace(".prog", "") + "'", con);
                con.Close();
                G.cnn.Open();
                if (Directory.Exists("Report//" + date))
                {
                    System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo("Report//" + date);
                    if (Directory.Exists("Report//" + date))
                        G.ucReport.Empty(directory);
                }
                G.SumOK = 0;
                G.SumNG = 0;
                lbSumOK.Text = "---";
                lbSumNG.Text = "---";
                lbStatus.Text = "---";
                lbCycleTrigger.Text = "---";
            }
        }

        private void ckProcess_CheckedChanged(object sender, EventArgs e)
        {
            G.IsDrawProcess = ckProcess.Checked;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
           
              BeeCore.Common.ReadCCD(G.Config.IsHist, G.Config.TypeCamera);
            BeeCore.Common.CalHist();
        }

        private void workInsert_DoWork(object sender, DoWorkEventArgs e)
        {
            if(G.cnn.State==ConnectionState.Closed)
                G.ucReport.Connect_SQL();
            if (G.TotalOK)
                SQL_Insert(DateTime.Now, Properties.Settings.Default.programCurrent.Replace(".prog", ""), G.SumOK, G.SumOK + G.SumNG, "OK", BeeCore.Common.matRaw.Clone(), bmResult);
            else
                SQL_Insert(DateTime.Now, Properties.Settings.Default.programCurrent.Replace(".prog", ""), G.SumOK, G.SumOK + G.SumNG, "NG", BeeCore.Common.matRaw.Clone(), bmResult);

        }
        int numErrPort = 0;
        private void tmCheckPort_Tick(object sender, EventArgs e)
        {
           
            if (!G.Header.SerialPort.IsOpen)
            {
                try
                {
                    G.EditTool.toolStripPort.Image = Properties.Resources.PortNotConnect;
                    G.EditTool.toolStripPort.Text = "Port Not Connect";
                    G.Header.SerialPort.Close();
                    G.Header.SerialPort.Open();
                }
                catch (Exception ex)
                {
                    numErrPort++;
                }
                if(numErrPort>5)
                {
                    G.EditTool.toolStripPort.Image = Properties.Resources.PortNotConnect;
                    G.EditTool.toolStripPort.Text = "Port Not Connect";
                    // MessageBox.Show("Error connect Port " + G.Header.SerialPort.PortName);

                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            G.IsModeTest = btnTest.IsCLick;
        }
        FormCalib formCalib;

        private void btnCalib_Click(object sender, EventArgs e)
        {

            if (btnCalib.IsCLick)
            {
                if (formCalib != null)
                    formCalib.Close();

                formCalib = new FormCalib();
                formCalib.Show();
            }
            else
            {
                if (formCalib != null)
                    formCalib.Close();
            }
        }

        private void tmCheckCCD_Tick(object sender, EventArgs e)
        {
            if (G.Config.TypeCamera == TypeCamera.USB)
            {
                if (!btnCap.IsCLick && !btnRecord.IsCLick && !workPlay.IsBusy && !workReadCCD.IsBusy)
                    BeeCore.Common.ReadCCD(false, G.Config.TypeCamera);
                if (BeeCore.Common.StatusCCD())
                {

                    if (G.ScanCCD.ScanIDCCD().FindIndex(a => a.Contains(G.Config.IDCamera)) > -1)
                    {
                        if (!BeeCore.Common.ConnectCCD(G.ScanCCD.indexCCD, G.Config.Resolution))
                        {
                            G.EditTool.lbCam.Image = Properties.Resources.CameraNotConnect;
                            G.EditTool.lbCam.Text = "Camera Not Connect";

                            btnCap.Enabled = false;
                            btnRecord.Enabled = false;
                            btnCalib.Enabled = false;
                            btnTest.Enabled = false;
                            tmCheckCCD.Interval = 3000;
                        }
                        else
                        {
                            tmCheckCCD.Interval = 1000;
                            btnCap.Enabled = true;
                            if (G.Config.nameUser == "Admin")
                            {

                                btnRecord.Enabled = true;
                                btnCalib.Enabled = true;
                                btnTest.Enabled = true;
                            }
                            G.EditTool.lbCam.Image = Properties.Resources.CameraConnected;
                            G.EditTool.lbCam.Text = G.Config.IDCamera.Split('$')[0] + " Connected";
                        }
                    }
                    else
                    {
                        tmCheckCCD.Interval = 3000;
                        btnCap.Enabled = false;
                        btnRecord.Enabled = false;
                        btnCalib.Enabled = false;
                        btnTest.Enabled = false;
                        G.EditTool.lbCam.Image = Properties.Resources.CameraNotConnect;
                        G.EditTool.lbCam.Text = "Camera Not Connect";

                    }
                }
                else
                {
                    tmCheckCCD.Interval = 1000;
                    btnCap.Enabled = true;
                    if (G.Config.nameUser == "Admin")
                    {
                        btnRecord.Enabled = true;
                        btnCalib.Enabled = true;
                        btnTest.Enabled = true;
                    }
                    G.EditTool.lbCam.Image = Properties.Resources.CameraConnected;
                    G.EditTool.lbCam.Text =  G.Config.IDCamera.Split('$')[0] + " Connected";
                }
            }
               
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                BeeCore.Common.matRaw = Cv2.ImRead(openFile.FileName);
                imgView.ImageIpl = BeeCore.Common.matRaw;
            }    
          
        }

        private void tmClear_Tick(object sender, EventArgs e)
        {
            
        }

        private void pView_MouseLeave(object sender, EventArgs e)
        {
            //G.IsCheck = true;
           // imgView.Invalidate();
        }

        private void pView_MouseMove(object sender, MouseEventArgs e)
        {

          //  G.IsCheck = false;
          //  imgView.Invalidate();
        }

        private void View_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
           
           
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
           if ( fileDialog.ShowDialog()==DialogResult.OK)
            {
                listPath = fileDialog.FileNames;
                G.IsCheck = true;
                imgView.Invalidate();

             

            }

        }

        private void imgView_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (toolEdit == null) return;
            _drag = false;
            if(toolEdit.Propety.rotCrop!=null)
              toolEdit.Propety.rotCrop._dragAnchor = AnchorPoint.None;
            if (matCrop == null) return;
           
                ToolMouseUp();
            imgView.Invalidate();
            
        }
    }
}
