using MssNet.Models.Request;

namespace MssNet.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new MssClientSettings("username", "password", "source");
            var client = new MssClient(settings);

            var request = new Request
            {
                Search = new Search
                {
                    Id = "9000",
                    Lang = Languages.German,
                },
                Options = new Options
                {
                    HotelDetails = (int) (HotelDetails.BasicInfo | HotelDetails.Themes),
                },
            };

            var response = client.SendRequest(HeaderMethods.GetHotelList, request).Result;
        }
    }
}
