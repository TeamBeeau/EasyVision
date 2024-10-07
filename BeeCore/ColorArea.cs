﻿using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace BeeCore
{
    [Serializable()]
    public  class ColorArea
    {
        public ColorArea ()
        {

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public TypeTool TypeTool;
        public RectRotate rotArea, rotCrop, rotMask;
        public RectRotate rotAreaTemp = new RectRotate();
        public RectRotate rotAreaAdjustment;
        public bool IsGetColor;
        public Mode TypeMode = Mode.Pattern;
        public TypeCrop TypeCrop;
        public string pathRaw = "";
        public int cycleTime = 0;
        public RectangleF rectArea=new RectangleF();

        private int _areaPixel=1;
        private int _score;


        private int styleColor;
        public int AreaPixel
        {
            get
            {
                return _areaPixel;
            }
            set
            {

                _areaPixel = value;
            }
        }

        public int Score
        {
            get
            {
                return _score;
            }
            set
            {

                _score = value;
            }
        }

        public int StyleColor { get => styleColor; 
            set { styleColor = value;
                G.colorArea.StyleColor = styleColor;
            }  }

        public Mat Undo(Mat raw, bool IsCalib=false)
        {

            G.colorArea.Undo(AreaPixel);
            SetColor(false, raw);
            return OpenCvSharp.Extensions.BitmapConverter.ToMat(G.CommonPlus.GetImageRsTemp());
           
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
        public List<Color> listCLShow = new List<Color>();
        public Color clShow;
        public System.Drawing.Color GetColor( Mat raw, int x,int y)
        {
            G.colorArea.StyleColor = styleColor;
            G.CommonPlus.BitmapSrc(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(raw));
           
            String S = G.colorArea.GetColor(x, y);
            clShow = System.Drawing.Color.Black;
            if (S == null||S=="") return clShow;
            String[] sp = S.Split(',');
            clShow = System.Drawing.Color.FromArgb(255, Convert.ToInt32(sp[0]), Convert.ToInt32(sp[1]), Convert.ToInt32(sp[2]));
          
            return clShow;

            
        }
        public void AddColor()
        {
            G.colorArea.AddColor();
            listCLShow.Add(clShow);
        }

        public int pxTemp=0;
        public String listColor="";
        public void LoadTemp(bool IsCCD,bool IsHist,TypeCamera typeCamera)
        {
            G.colorArea.StyleColor = styleColor;
            BeeCore.Common.ReadCCD(IsHist, typeCamera);
            G.colorArea.LoadTemp(listColor);
            G.colorArea.SetColorArea(AreaPixel);
        }
        public Mat ClearTemp()
        {
            G.colorArea.StyleColor = styleColor;
            listColor = "";
         
            G.colorArea.LoadTemp(listColor);
            G.colorArea.SetColorArea(AreaPixel);
            return OpenCvSharp.Extensions.BitmapConverter.ToMat(G.CommonPlus.GetImageRsTemp());

        }
        public Mat SetColor(bool IsCCD, Mat raw)
        {
            G.colorArea.StyleColor = styleColor;
            G.CommonPlus.BitmapSrc(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(raw));
             pxTemp = G.colorArea.SetColorArea(AreaPixel);
           
         
                listColor = G.colorArea.SaveTemp();
                 return OpenCvSharp.Extensions.BitmapConverter.ToMat(G.CommonPlus.GetImageRsTemp());
      
            
          
        }
        public bool IsOK = false;
        [DllImport(@".\BeeCV.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]

        unsafe public static extern IntPtr GetImageResult(ref int rows, ref int cols, ref int Type);
      
        public Bitmap CheckColor( Mat raw)
        {
            G.colorArea.StyleColor = styleColor;
            Bitmap btmRaw = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(raw);
                G.CommonPlus.BitmapSrc(btmRaw);
            

              G.colorArea.LoadTemp(listColor);
            IsOK = G.colorArea.CheckColor(false,0,0,0,0,0,AreaPixel,Score, pxTemp);
                return G.CommonPlus.GetImageResult();
        
        }
        public int ScoreRs;
        public Mat CheckColor(bool IsRun, Mat raw,RectRotate rot)
        {
            G.colorArea.StyleColor = styleColor;
            if (!IsRun)
            
            {
                Bitmap btmRaw = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(raw);
                G.CommonPlus.BitmapSrc(btmRaw);
            }

            G.colorArea.LoadTemp(listColor);
            IsOK = G.colorArea.CheckColor(true,(int)rot._PosCenter.X, (int)rot._PosCenter.Y, (int)rot._rect.Width, (int)rot._rect.Height, rot._angle, AreaPixel, Score, pxTemp);
            ScoreRs = G.colorArea.ScoreRS;
            int rows = 0, cols = 0 ,Type = 0;
            cycleTime =(int) G.colorArea.cycle;
            IntPtr intPtr= GetImageResult( ref rows, ref cols, ref Type);
            unsafe
            {
              
                Mat raws = new Mat(rows, cols, Type, intPtr);
                return raws;
            }
            return null;

        }
    }
}
