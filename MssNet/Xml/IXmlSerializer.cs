namespace MssNet.Xml
{
    public interface IXmlSerializer
    {
        string SerializeObject<T>(T obj);
    }
}
