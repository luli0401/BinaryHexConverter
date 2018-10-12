using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHexConverter.Helper
{
    public static class Extension
    {
        public static string ToHexString(this int intValue)
        {
           return Convert.ToString(intValue, 16);
        }

        public static string ToBinaryString(this int intValue)
        {
            return Convert.ToString(intValue, 2);
        }

       
    }
}
