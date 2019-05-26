using MssNet.Models.Request;

namespace MssNet.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = new MssClientSettings("username", "password", "source");
            var client = new MssClient(settings);

            var response = client.SendRequest(request =>
            {
                request.Header.Method = HeaderMethods.GetHotelList;
                request.Request.Search = new Search
                {
                    Id = "9000",
                    Lang = Languages.German,
                };
                request.Request.Options = new Options
                {
                    HotelDetails = (int) (HotelDetails.BasicInfo | HotelDetails.Themes),
                };
                return request;
            }).Result;
        }
    }
}