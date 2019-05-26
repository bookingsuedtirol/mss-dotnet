using MssNet.Models.Request;

namespace MssNet
{
    public sealed class MssClientHelper
    {
        public static Root CreateRequestWithDefaults(MssClientSettings settings)
        {
            return new Root
            {
                Version = "2.0",
                Header = new Header
                {
                    Credentials = new Credentials
                    {
                        User = settings?.User,
                        Password = settings?.Password,
                        Source = settings?.Source,
                    },
                },
                Request = CreateDefaultRequest(),
            };
        }

        private static Request CreateDefaultRequest()
        {
            return new Request
            {
                Search = new Search
                {
                    Lang = Languages.German
                }
            };
        }
    }
}