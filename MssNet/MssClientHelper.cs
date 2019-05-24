using MssNet.Models.Request;

namespace MssNet
{
    public sealed class MssClientHelper
    {
        public static Root CreateRequestWithDefaults(MssClientSettings settings, string methodName, Request request, Paging paging = null)
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
                    Method = !string.IsNullOrWhiteSpace(methodName) ? methodName : HeaderMethods.GetHotelList,
                    Paging = paging,
                },
                Request = request ?? CreateDefaultRequest(),
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
