
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSharp
{
    [Serializable()]
    public  class Access
    {
        public static void SaveKeys(String Keys, String path)
        {

            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, Keys);
                ms.Position = 0;
                byte[] buffer = new byte[(int)ms.Length];
                ms.Read(buffer, 0, buffer.Length);
                File.WriteAllText(path, Convert.ToBase64String(buffer));
                File.Exists(path);


            }
        }
        public static String LoadKeys(String path)
        {
            try
            {

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(File.ReadAllText(path))))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    return (String)bf.Deserialize(ms);
                }

            }
            catch (Exception)
            { }
            return null;
        }
      
        public Access()
        {

        }

       
    }
}
