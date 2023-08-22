using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPSejeLMSP.Extensions
{
    public static class EnumExtension
    {
        public static string ToIntegerString(this Enum value)
        {
            return value.ToString("D");
        }
    }
}