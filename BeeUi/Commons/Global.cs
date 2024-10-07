using BeeCore;
using BeeUi.Common;
using BeeUi.Commons;
using BeeUi.Tool;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.Data.SqlClient;

namespace BeeUi
{
    [Serializable()]
    public enum Trig
    {
       None, Processing,Trigged,Continue,NotTrig,Complete
    }

    public struct G
    {
       
        public static BeeDevice.DeviceConnectForm DeviceConnectForm = new BeeDevice.DeviceConnectForm();
        public static String Licence = "";
          public static ScanCCD ScanCCD;
      public static bool IsModeTest = false;
        public static bool IsDone = false;
        public static ucReport ucReport=new ucReport();
        public static bool TotalOK = false;
        public static int SumOK, SumNG;
         public static String NamePort = "";
        public static Main Main;
      public static FormActive FormActive;
        public static KeyAcitve keys=new KeyAcitve();
        public static bool IsCap = false, IsActive;
        public static FormLoad Load;
        public static bool IsCancel;
        public static dynamic PropetyOld;
        public static Tool.AddTool AddTool;
            public static Header Header;
        public static Trig StatusTrig=Trig.None;
        public static int indexToolSelected;
          public static Config Config;
         public static VideoCapture camera;
       public static bool IsRun = true,IsCCD,IsEdit;
        public static RectRotate rotPositionAdjustment;
        public static bool IsCheck=false;
        public static StepEdit StepEdit=new StepEdit();
        public static float angle_Adjustment=0, X_Adjustment=0, Y_Adjustment=0;
        public static List<PropetyTool> PropetyTools = new List<PropetyTool>();
        public static List<Tools> listAlltool = new List<Tools>();
        public static List<iTool> listItool = new List<iTool>();
        public static bool IsCalib, isTop;
        public static string _pathSqlMaster;
        public static SqlConnection cnn=new SqlConnection();
        public static ToolSettings ToolSettings;
        public static bool IsLoad= false;
     public static TypeCrop TypeCrop = TypeCrop.Crop;
       public static TypeTool TypeTool = TypeTool.OutLine;
       public static Tools tool ;
        public static EditTool EditTool ;
        public static bool IsDrawProcess = false;
        public static Color clTrack = (Color)new ColorConverter().ConvertFromString("#444444");
        public static Account account = new Account();
    }
    internal class Global
    {
    }
}
