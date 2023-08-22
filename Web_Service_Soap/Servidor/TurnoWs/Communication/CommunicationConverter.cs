using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace TPSejeLMSP.Communications
{
    public class CommunicationConverter
    {
        public static byte[] ToByteArray(string s)
        {
            if (s == null)
                throw new ArgumentNullException("s");

            if (s.Equals(string.Empty))
                return null;

            return Encoding.GetEncoding("Windows-1252").GetBytes(s);
        }
    }
}