using System;
using System.IO;

namespace MssNet.Xml
{
    public class XmlDeserializer : IXmlDeserializer
    {
        public T Deserialize<T>(string xmlContent)
        {
            if (string.IsNullOrWhiteSpace(xmlContent))
                throw new ArgumentException("Cannot be null or whitespace.", nameof(xmlContent));

            using (TextReader reader = new StringReader(xmlContent))
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
