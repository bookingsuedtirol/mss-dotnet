using MssNet.Xml;
using System;
using Xunit;

namespace MssNet.Tests
{
    public class XmlSerializerTest
    {
        [Fact]
        public void SerializeObject_GivenNull_ShouldThrowArgumentNullException()
        {
            var serializer = new XmlSerializer();
            var exception = Assert.Throws<ArgumentNullException>(() => serializer.SerializeObject<object>(null));

            Assert.Equal(Sanitize("Value cannot be null.\r\nParameter name: obj"), exception.Message);
        }

        [Fact]
        public void SerializeObject_GivenValidObject_ShouldReturnXmlContent()
        {
            var serializer = new XmlSerializer();
            string xmlContent = serializer.SerializeObject(new Person("Rainer", "Zufall"));

            Assert.Equal(Sanitize("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Person xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <FirstName>Rainer</FirstName>\r\n  <LastName>Zufall</LastName>\r\n</Person>"), xmlContent);
        }

        private string Sanitize(string str)
        {
            return str.Replace("\r\n", Environment.NewLine);
        }
    }
}
