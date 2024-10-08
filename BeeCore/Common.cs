
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp.Extensions;
using System.ComponentModel;

namespace BeeCore
{
  public   class Common
    {
        [DllImport(@".\BeeCV.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        unsafe public static extern IntPtr GetImage(ref int rows, ref int cols, ref int Type);
        [DllImport(@".\BeeCV.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]

        unsafe public static extern IntPtr GetImageCrop( ref int rows, ref int cols, ref int Type );
        public int numError = 0;
        public  bool IsErrorCCD = false;
        private static int frameRate = 0;
        public static Image ImageShow = new Bitmap(376, 240);
        public static Mat matRaw=new Mat(),matLive=new Mat();
        public static IntPtr intPtrRaw;
        [DllImport(@".\BeeCV.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        unsafe public static extern void SetSrc( IntPtr data, int image_rows, int image_cols, MatType matType);

        public unsafe static IntPtr ArrayToIntPtr(byte[] input)
        {
            IntPtr* ptr = stackalloc IntPtr[1];
            Marshal.Copy(input, 0, (IntPtr)ptr, sizeof(IntPtr));
            return *ptr;
        }
        public static System.Drawing.Size SizeCCD()
        {
            return new System.Drawing.Size(BeeCore.G.CCD.colCCD, BeeCore.G.CCD.rowCCD);

        }
        public static void SetRaw()
        {if (matRaw == null) matRaw = new Mat();
            if (matLive.Type() == MatType.CV_8UC4)
                Cv2.CvtColor(matLive.Clone(), matRaw, ColorConversionCodes.BGRA2BGR);
        else
            matRaw = matLive.Clone();
           // G.CommonPlus.BitmapSrc(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(raw));
            SetSrc(matRaw.Data, matRaw.Rows, matRaw.Cols, matRaw.Type());
        }
        public static Mat GetCrop()
        {
        
            int rows = 0, cols = 0 ,Type = 0;
            IntPtr intPtr=   GetImageCrop( ref rows, ref cols, ref Type);
            unsafe
            {
              
                Mat raw = new Mat(rows, cols, Type, intPtr);
                return raw;
            }
          
            return null;
        }
        public static Mat  GetImageRaw()
        {
            int rows = 0, cols = 0, Type = 0;
            switch (typeCCD)
            {
                case TypeCamera.USB:
                   
                    IntPtr intPtr = GetImage(ref rows, ref cols, ref Type);
                    unsafe
                    {

                        Mat raw = new Mat(rows, cols, Type, intPtr);
                        return raw;
                    }
                    break;
                case TypeCamera.BaslerGigE:
                  
                     intPtr = GetImage(ref rows, ref cols, ref Type);
                    unsafe
                    {

                        Mat raw = new Mat(rows, cols, Type, intPtr);
                        return raw;
                    }
                    break;
                case TypeCamera.TinyIV:

                    if (matLive != null)
                        if (!matLive.Empty())
                            return matLive.Clone();
                    else return null;
                    break;
            }    
            
           
            // \\  Mat raw=new  G.CommonPlus.ReturnRaw();
            return null;
        }
        public static void CalHist()
        {
            G.CCD.CalHist();
        }
        public static event PropertyChangedEventHandler FrameChanged;
        public static event PropertyChangedEventHandler PropertyChanged;
        public static void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(G.Common, new PropertyChangedEventArgs(propertyName));
            }
        }
        public static bool IsLive = false;
        public static void GetImgeTinyCam(Bitmap bmp)
        {
            try
            {
                if (bmp != null)
                {
                    if (TypeCCD == TypeCamera.TinyIV)
                    {
                       
                            matLive = OpenCvSharp.Extensions.BitmapConverter.ToMat(bmp).Clone();
                            //matRaw = raw.Clone();
                            //Cv2.CvtColor(raw.Clone(), matRaw, ColorConversionCodes.BGRA2BGR);
                            NotifyPropertyChanged("Image");
                        
                    
                    } 
                }

            }
            catch (Exception)
            {

            }
               }
        public static float Cycle = 0;
        public static bool ConnectCCD( int indexCCD,String Resolution)
        {
            String[] sp = Resolution.Split(' ');
            String[] sp2 = sp[0].Split('x');

            BeeCore.G.CCD.colCCD = Convert.ToInt32(sp2[0]);
            BeeCore.G.CCD.rowCCD =Convert.ToInt32( sp2[1]); 
          
            if (G.CCD.Connect(Convert.ToInt32(sp2[1]), Convert.ToInt32(sp2[0]),indexCCD))
            {
                G.CCD.ReadCCD();
                Cycle = G.CCD.cycle;
                ///G.CommonPlus.GetImageRaw();
                return true;
            }
            return false;
             
        }
        public static void Setting()
        {
            G.CCD.ShowSetting();
           

        }
        public static string ScanCCD()
        {
            return G.CCD.ScanCCD();
           

        }
        public static void DestroyAll()
        {
            G.CCD.DestroyAll();

        }
        public static bool StatusCCD()
        {

            return  G.CCD.IsErrCCD;


        }
        private static TypeCamera typeCCD;

        public static int FrameRate { get => frameRate; set
            {
                frameRate = value;
                if (FrameChanged != null)
                {
                    FrameChanged(G.Common, new PropertyChangedEventArgs("FrameChanged"));
                }
            }
        }

        public static TypeCamera TypeCCD { get => typeCCD; 
            set { typeCCD = value;
                G.CCD.typeCCD =(int) value;
            } }

        public static void ReadCCD(bool IsHist, TypeCamera typeCamera)
        {
            TypeCCD = typeCamera;
            switch (typeCamera)
            {
                case TypeCamera.USB:
            //if (IsHist)
            //    G.CCD.ReadRaw(true);
            //else
                G.CCD.ReadCCD();
                    break;
                case TypeCamera.BaslerGigE:
                    //if (IsHist)
                    //    G.CCD.ReadRaw(true);
                    //else
                    G.CCD.ReadCCD();
                    break;
                case TypeCamera.TinyIV:
                    
                    SetRaw();
                        break;
        }
          
        }
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public static Mat CropRotatedRect(Mat source, RotatedRect rect)
        {
            Mat matResult = new Mat();
            RotatedRect rot = rect;
            Point2f pCenter = new Point2f(rot.Center.X, rot.Center.Y);
            Size2f rect_size = new Size2f(rot.Size.Width, rot.Size.Height);
            RotatedRect rot2 = new RotatedRect(pCenter, rect_size, rot.Angle);
            double angle = rot.Angle;
            if (angle < -45)
            {
                angle += 90.0;

                Swap(ref rect_size.Width, ref rect_size.Height);
            }



            InputArray M = Cv2.GetRotationMatrix2D(rot2.Center, angle, 1.0);

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

        public static void  CreateTemp(TypeTool TypeTool)
        {
          
                CvPlus.Pattern pattern = new CvPlus.Pattern();
                pattern.CreateTemp();
            
         
        }
        public static Mat LoadImage(string path, ImreadModes mode)
        { Mat raw = OpenCvSharp.Cv2.ImRead(path, mode);

       
            
            return raw;
        }
    }
}
