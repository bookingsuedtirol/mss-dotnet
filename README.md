# mss-dotnet
MSS API wrapper for .NET projects

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
        HotelDetails = (int) (HotelDetails.BasicInfo | HotelDetails.PaymentOptionsForOnlineBooking),
    },
};

var response = client.SendRequest(HeaderMethods.GetHotelList, request).Result;
```