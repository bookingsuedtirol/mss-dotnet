# mss-dotnet
MSS API wrapper for .NET projects

![NuGet](https://img.shields.io/nuget/v/HGV.MssNet)

> Warning! Do not use this in production yet!
> Supports only v2.0!

## Available services

- [x] getHotelList
- [x] getSpecialList
- [x] getRoomList
- [x] getPriceList
- [x] getRoomAvailability
- [x] getHotelPictures
- [ ] prepareBooking
- [ ] getBooking
- [ ] createInquiry
- [ ] getUserSources

## Example

```cs  
var settings = new MssClientSettings("username", "password", "source");
using (var client = new MssClient(settings))
{
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
            HotelDetails = (int) (HotelDetails.BasicInfo | PaymentOptionsForOnlineBooking.Themes),
        };
        return request;
    });
}
```
