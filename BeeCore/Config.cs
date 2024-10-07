﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeCore
{
    public  enum ConditionOK
    {
        TotalOK,
        AnyOK,
        Logic
    }
  public  enum LogicOK
    {
        AND,
        OR,
        
    }
    public enum UsedTool
    {
        NotUsed,
        Used,
        Invertse
    }
    public enum TypeCamera
    {
        USB,
        TinyIV,
        None
    }
    [Serializable()]
    public class Config
    {
        public TypeCamera TypeCamera = TypeCamera.USB;
        public String Resolution = "1280x720 (1.3 MP)";
        public int LimitDateSave = 15;
        public bool IsSaveOK = true, IsSaveNG = false;
        public bool IsSaveRaw = true, IsSaveRS = false;
        public int TypeSave = 1;
        public int numToolOK = 0;
       
        public LogicOK LogicOK =LogicOK.AND;
        public ConditionOK ConditionOK=ConditionOK.TotalOK;
        public Bitmap matRegister;
        public Bitmap matSample;
        public String namePort="",IDPort="";
        public String IDCamera="";
        public String nameUser = "User";
        public int CCD,ScoreCalib=1;
        public bool IsHist = false,IsShowGird=false,IsShowCenter=false,IsShowArea=false;
    }
}
