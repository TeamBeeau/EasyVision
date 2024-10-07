using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibSharp
{
    
    class Decompile
    {
        public Decompile()
        {

        }
        public static String DecompileMac(String MacAddress)
        {


            String sSum = "";
            foreach (char c in MacAddress)
            {
                switch (c)
                {
                    case '0': sSum += "d51sdgxhs"; break;
                    case '1': sSum += "dfd$$^$"; break;
                    case '2': sSum += "SDfsdfs%"; break;
                    case '3': sSum += "sdsa$%$"; break;
                    case '4': sSum += "SDFSFdsfk&"; break;
                    case '5': sSum += "sDGDRYt56"; break;
                    case '6': sSum += "sDGDgf65*"; break;
                    case '7': sSum += "Hdryrdg^7876"; break;
                    case '8': sSum += "FDD46ds"; break;
                    case '9': sSum += "fdfgd4545%"; break;
                    case 'A': sSum += "mauiuhihi"; break;
                    case 'B': sSum += "fSDGFs453"; break;
                    case 'C': sSum += "$^$%fb"; break;
                    case 'D': sSum += "mauiuhihi1"; break;
                    case 'E': sSum += "%&%^*ddx"; break;
                    case 'F': sSum += "#%#$tdvd"; break;
                    case 'G': sSum += "sdfsf$^#$&"; break;
                    case 'H': sSum += "baocc"; break;
                    case 'I': sSum += "dxzv@$#$"; break;
                    case 'J': sSum += "dienbao"; break;
                    case 'K': sSum += "chibao"; break;
                    case 'L': sSum += "stuppid@"; break;
                    case 'M': sSum += "dgdsgdsgfW354"; break;
                    case 'N': sSum += "mauiuhihi2"; break;
                    case 'O': sSum += "1#@!dsgdgdrg"; break;
                    case 'P': sSum += "#$##%^fFFDg"; break;
                    case 'Q': sSum += "@DGFDSGS"; break;
                    case 'R': sSum += "sgfsagvsdgh"; break;
                    case 'S': sSum += "dge^%&$"; break;
                    case 'T': sSum += "Qdgdgre4$^^$"; break;
                    case 'U': sSum += "sdgsg$%$#"; break;
                    case 'V': sSum += "dsfsdfE$%$"; break;
                    case 'X': sSum += "sfsfs5gWRG"; break;
                    case 'Y': sSum += "yi4ytfhsd"; break;
                    case 'Z': sSum += "mauiuhihi3"; break;
                    case 'W': sSum += "dg1df5dgf"; break;
                    case '/': sSum += "~"; break;
                    case '-': sSum += "segsdgsdgsge"; break;
                    default:
                        sSum += "_";
                        break;
                }
                sSum += "`";
            }
            return sSum;
        }
        public static String[] Compile(String DeCompile)
        {
            String[] sLine = DeCompile.Split('_');
            String[] output = new String[4];


            int i = 0;
            foreach (String s in sLine)
            {

                String[] sChar = s.Split('`');
                String sSum = "";
                foreach (String s2 in sChar)
                {

                    switch (s2)
                    {
                        case "d51sdgxhs": sSum += '0'; break;
                        case "dfd$$^$": sSum += '1'; break;
                        case "SDfsdfs%": sSum += '2'; break;
                        case "sdsa$%$": sSum += '3'; break;
                        case "SDFSFdsfk&": sSum += '4'; break;
                        case "sDGDRYt56": sSum += '5'; break;
                        case "sDGDgf65*": sSum += '6'; break;
                        case "Hdryrdg^7876": sSum += '7'; break;
                        case "FDD46ds": sSum += '8'; break;
                        case "fdfgd4545%": sSum += '9'; break;
                        case "mauiuhihi": sSum += 'A'; break;
                        case "fSDGFs453": sSum += 'B'; break;
                        case "$^$%fb": sSum += 'C'; break;
                        case "mauiuhihi1": sSum += 'D'; break;
                        case "%&%^*ddx": sSum += 'E'; break;
                        case "#%#$tdvd": sSum += 'F'; break;
                        case "sdfsf$^#$&": sSum += 'G'; break;
                        case "baocc": sSum += 'H'; break;
                        case "dxzv@$#$": sSum += 'I'; break;
                        case "dienbao": sSum += 'J'; break;
                        case "chibao": sSum += 'K'; break;
                        case "stuppid@": sSum += 'L'; break;
                        case "dgdsgdsgfW354": sSum += 'M'; break;
                        case "mauiuhihi2": sSum += 'N'; break;
                        case "1#@!dsgdgdrg": sSum += 'O'; break;
                        case "#$##%^fFFDg": sSum += 'P'; break;
                        case "@DGFDSGS": sSum += 'Q'; break;
                        case "sgfsagvsdgh": sSum += 'R'; break;
                        case "dge^%&$": sSum += 'S'; break;
                        case "Qdgdgre4$^^$": sSum += 'T'; break;
                        case "sdgsg$%$#": sSum += 'U'; break;
                        case "dsfsdfE$%$": sSum += 'V'; break;
                        case "sfsfs5gWRG": sSum += 'X'; break;
                        case "yi4ytfhsd": sSum += 'Y'; break;
                        case "mauiuhihi3": sSum += 'Z'; break;
                        case "dg1df5dgf": sSum += 'W'; break;
                        case "~": sSum += '/'; break;
                        case "segsdgsdgsge": sSum += '-'; break;

                        default:
                            sSum += "";
                            break;
                    }


                }
                output[i] = sSum;
                i++;
            }
            return output;
        }
        
        public static String GetMacAddress()
        {
            return "";

        }
    }
}
