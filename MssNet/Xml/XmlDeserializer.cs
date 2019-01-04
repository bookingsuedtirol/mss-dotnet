using System;
using System.IO;

namespace MssNet.Xml
{
    public class XmlDeserializer : IXmlDeserializer
    {
        public T Deserialize<T>(string xmlContent)
        {
            if (string.IsNullOrWhiteSpace(xmlContent))
                throw new ArgumentException($"{nameof(xmlContent)} cannot be null or whitespace.");

            using (TextReader reader = new StringReader(xmlContent))
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
