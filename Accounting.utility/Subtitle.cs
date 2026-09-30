using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.utility
{
    public class Subtitle
    {
        public static string CreateSub(int Amount)
        {
            string Am = Amount.ToString();
            int len = Am.Length;
            string translate = "";
            for (int i = 0; i < len; i++)
            {
                char c = Am[i];
                int ind = len - i;

                if (ind % 3 == 0)
                {
                        translate += sadegan(c.ToString());
                }
                else if (ind % 3 == 1)
                {
                    translate += Yekan(c.ToString());
                    if((ind+1) / 3 == 2 && c != '0')
                    {
                        translate += " میلیون ";
                    }
                    else if((ind + 1) / 3 == 1 && c != '0')
                    {
                        translate += " هزار ";
                    }
                }
                else if (ind % 3 == 2)
                {
                    if (c == '1' &&Am[i + 1] != '0')
                    {
                        translate += motafareghe((c.ToString() + Am[i+1]));
                        i+=2;
                        continue;
                    }
                    translate += dahegan(c.ToString());
                }
                if (i != len - 1 && Am[i + 1] != '0')
                {
                   
                    translate += " و ";
                }
            }
            return translate + " تومن";
        }
        private static string Yekan(string s)
        {
            switch (s)
            {
                case "1":
                    return "یک";
                case "2":
                    return "دو";
                case "3":
                    return "سه";
                case "4":
                    return "چهار";
                case "5":
                    return "پنج";
                case "6":
                    return "شش";
                case "7":
                    return "هفت";
                case "8":
                    return "هشت";
                case "9":
                    return "نه";
                default:
                    return "";
                    break;
            }

        }
        private static string dahegan(string s)
        {
            switch (s)
            {
                case "1":
                    return "ده";
                case "2":
                    return "بیست";
                case "3":
                    return "سی";
                case "4":
                    return "چهل";
                case "5":
                    return "پنجاه";
                case "6":
                    return "شصت";
                case "7":
                    return "هفتاد";
                case "8":
                    return "هشتاد";
                case "9":
                    return "نود";
                default:
                    return "";
                    break;
            }
        }
        private static string sadegan(string s)
        {
            switch (s)
            {
                case "1":
                    return "صد";
                case "2":
                    return "دویست";
                case "3":
                    return "سیصد";
                case "4":
                    return "چهارصد";
                case "5":
                    return "پانصد";
                case "6":
                    return "ششصد";
                case "7":
                    return "هفتصد";
                case "8":
                    return "هشتصد";
                case "9":
                    return "نهصد";
                default:
                    return "";
                    break;
            }
        }
        private static string motafareghe(string s)
        {
            switch (s)
            {
                case "11":
                    return "یازده";
                case "12":
                    return "دوازده";
                case "13":
                    return "سیزده";
                case "14":
                    return "چهارده";
                case "15":
                    return "پانزده";
                case "16":
                    return "شانزده";
                case "17":
                    return "هفده";
                case "18":
                    return "هجده";
                case "19":
                    return "نوزده";
                default:
                    return "";
            }
        }
    }
}
