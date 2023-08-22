using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace TurnoWs.Extensions
{
    public static class ObjectExtension
    {
        public static string Serialize<T>(this T value)
        {
            if (value == null)
            {
                return null;
            }

            var xmlserializer = new XmlSerializer(typeof(T));
            var stringWriter = new StringWriter();
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            using (var writer = XmlWriter.Create(stringWriter))
            {
                xmlserializer.Serialize(writer, value, ns);
                return stringWriter.ToString();
            }
        }
    }

}

