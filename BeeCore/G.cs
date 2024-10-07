using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace BeeCore
{
    public enum AnchorPoint
    {
        TopLeft, TopRight, BottomLeft, BottomRight, Rotation, Center, None
    }

    public enum AreaCrop
    {
        Rect, Circle
    }
    public enum TypeTool
    {
        Position_Adjustment,
        Pattern,
        OutLine,
        Edge_Pixels,
        Color_Area,
       
       
        Width,
        Diameter,
        Edge,
        Pitch,
        OCR
    }
    public enum GroupTool
    {
        Basic_Tool,Extra_Tool_1,Extra_Tool_2,None
    }    
    public enum WindowView { 
        Window,
        Process
    }
    public enum TypeCrop
    {
        Crop, Area,Mask,None
    }
    public enum Mode
    {
        Pattern, OutLine
    }
    public enum Function
    {
        LoadImage, LearnPattern
    }
    public struct G
    {
        public static Common Common = new Common();
        public static CvPlus.ColorArea colorArea = new CvPlus.ColorArea();
        public static CvPlus.CCD CCD = new CvPlus.CCD();
        public static CvPlus.Pattern pattern = new CvPlus.Pattern();
        public static bool IsCheck = false;
        public static CvPlus.Common CommonPlus = new CvPlus.Common();
        public static WindowView WindowView = WindowView.Window;
    }
   public static class GLobal
    {
       
    }
}
