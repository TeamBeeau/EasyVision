using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeCore
{
  
    [Serializable()]
    public class ParaCam
    {
        public  int Exposure
        {
            get => exposure; set
            {
                exposure = value;
                G.CCD.Exposure = value; G.CCD.SetPara();
            }
        }
        public  int exposure = 0;
    }
}
