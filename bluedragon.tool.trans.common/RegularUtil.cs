using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bluedragon.tool.trans.common
{
    public class RegularUtil
    {
        private static Regex reg = null;

        public static bool CustomizeCheck(string pattern, string sourceString)
        {
            reg = new Regex(pattern);
            return reg.IsMatch(sourceString);
        }

        public static bool IsNumeric(string sourceString)
        {
            reg = new Regex(@"\d+");
            return reg.IsMatch(sourceString);
        }

        public static bool IsIPAddress(string sourceString)
        {
            reg = new Regex(@"\b(25[0-5]|2[0-4][0-9]|[0-1]*[0-9]*[0-9]\.){3}(25[0-5]|2[0-4][0-9]|[0-1]?[0-9]?[0-9])\b");
            return reg.IsMatch(sourceString);
        }

        public static bool IsChiness(string sourceString)
        {
            reg = new Regex("[\u4e00-\u9fa5]");
            return reg.IsMatch(sourceString);
        }
    }
}
