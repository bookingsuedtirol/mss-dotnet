using System.IO;
using System.Text;

namespace MssNet.Text
{
    public sealed class EncodingAwareStringWriter : StringWriter
    {
        private readonly Encoding encoding;

        public EncodingAwareStringWriter()
        {
        }

        public EncodingAwareStringWriter(Encoding encoding)
        {
            this.encoding = encoding;
        }

        public override Encoding Encoding
        {
            get => encoding;
        }
    }
}
