using MssNet.Models.Request;
using System.Threading.Tasks;

namespace MssNet.Sample
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var settings = new MssClientSettings("username", "password", "source");
            using var client = new MssClient(settings);
            var response = await client.SendRequest(request =>
            {
                request.Header.Method = HeaderMethods.GetHotelList;
                request.Request.Search = new Search
                {
                    Ids = new string[] { "9000" },
                    Lang = Languages.German,
                };
                request.Request.Options = new Options
                {
                    HotelDetails = (int)(HotelDetails.BasicInfo | HotelDetails.Coordinates),
                };
                return request;
            });
        }
    }
}