using MssNet.Xml;
using System;
using Xunit;

namespace MssNet.Tests
{
    public class XmlDeserializerTest
    {
        [Fact]
        public void DeserializeObject_GivenNull_ShouldThrowArgumentException()
        {
            var deserializer = new XmlDeserializer();
            var exception = Assert.Throws<ArgumentException>(() => deserializer.Deserialize<Person>(null));

            Assert.Equal("xmlContent", exception.ParamName);
        }

        [Fact]
        public void DeserializeObject_GivenEmpty_ShouldThrowArgumentException()
        {
            var deserializer = new XmlDeserializer();
            var exception = Assert.Throws<ArgumentException>(() => deserializer.Deserialize<Person>(""));

            Assert.Equal("xmlContent", exception.ParamName);
        }

        [Fact]
        public void DeserializeObject_GivenWhietspace_ShouldThrowArgumentException()
        {
            var deserializer = new XmlDeserializer();
            var exception = Assert.Throws<ArgumentException>(() => deserializer.Deserialize<Person>(" "));

            Assert.Equal("xmlContent", exception.ParamName);
        }

        [Fact]
        public void DeserializeObject_GivenValidXmlContent_ShouldReturnObject()
        {
            var deserializer = new XmlDeserializer();
            var xmlContent = "<Person><FirstName>Rainer</FirstName><LastName>Zufall</LastName></Person>";
            var person = deserializer.Deserialize<Person>(xmlContent);

            Assert.NotNull(person);
            Assert.Equal("Rainer", person.FirstName);
            Assert.Equal("Zufall", person.LastName);
        }
    }
}
