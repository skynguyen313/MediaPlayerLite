using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Media_Player_Lite.MyLib
{
    public static class ChangeStringVN
    {
        public static string Change_AV(string ip_str_change)
        {
            Regex v_reg_regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string v_str_FormD = ip_str_change.Normalize(NormalizationForm.FormD);
            return v_reg_regex.Replace(v_str_FormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}
