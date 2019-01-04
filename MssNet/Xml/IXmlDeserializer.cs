namespace MssNet.Xml
{
    public interface IXmlDeserializer
    {
        T Deserialize<T>(string xmlContent);
    }
}
