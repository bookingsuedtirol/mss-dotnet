using MssNet.Text;
using System;
using System.IO;
using System.Text;

namespace MssNet.Xml
{
    public class XmlSerializer : IXmlSerializer
    {
        public string SerializeObject<T>(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException($"{nameof(obj)}");

            using (TextWriter writer = new EncodingAwareStringWriter(Encoding.UTF8))
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
                serializer.Serialize(writer, obj);

                return writer.ToString();
            }
        }
    }
}
