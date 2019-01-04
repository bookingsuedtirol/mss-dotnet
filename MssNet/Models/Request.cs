using System;
using System.Xml.Serialization;

namespace MssNet.Models.Request
{
    [XmlRoot(ElementName = "root")]
    public class Root
    {
        [XmlElement(ElementName = "version")]
        public string Version { get; set; }

        [XmlElement(ElementName = "header")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "request")]
        public Request Request { get; set; }
    }

    public class Header
    {
        [XmlElement(ElementName = "credentials")]
        public Credentials Credentials { get; set; }

        [XmlElement(ElementName = "method")]
        public string Method { get; set; }

        [XmlElement(ElementName = "paging")]
        public Paging Paging { get; set; }
    }

    public sealed class HeaderMethods
    {
        public static readonly string GetHotelList = "getHotelList";
        public static readonly string GetSpecialList = "getSpecialList";
        public static readonly string GetRoomList = "getRoomList";
        public static readonly string GetPriceList = "getPriceList";
        public static readonly string GetRoomAvailability = "getRoomAvailability";
        public static readonly string GetHotelPictures = "getHotelPictures";
        public static readonly string PrepareBooking = "prepareBooking";
        public static readonly string GetBooking = "getBooking";
        public static readonly string CreateInquiry = "createInquiry";
        public static readonly string GetUserSources = "getUserSources";
    }

    public class Credentials
    {
        [XmlElement(ElementName = "user")]
        public string User { get; set; }

        [XmlElement(ElementName = "password")]
        public string Password { get; set; }

        [XmlElement(ElementName = "source")]
        public string Source { get; set; }
    }

    public class Paging
    {
        [XmlElement(ElementName = "start")]
        public int Start { get; set; } = 0;

        [XmlElement(ElementName = "limit")]
        public int Limit { get; set; } = 0;
    }

    public class Request
    {
        [XmlElement(ElementName = "search")]
        public Search Search { get; set; }

        [XmlElement(ElementName = "options")]
        public Options Options { get; set; }

        [XmlElement(ElementName = "order")]
        public Order Order { get; set; }

        [XmlElement(ElementName = "data")]
        public Data Data { get; set; }

        [XmlElement(ElementName = "logging")]
        public Logging Logging { get; set; }
    }

    public class Search
    {
        [XmlElement(ElementName = "lang")]
        public string Lang { get; set; }

        [XmlElement(ElementName = "result_id")]
        public string ResultId { get; set; }

        [XmlElement(ElementName = "agent")]
        public string Agent { get; set; }

        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "search_hotel")]
        public SearchHotel SearchHotel { get; set; }

        [XmlElement(ElementName = "search_location")]
        public SearchLocation SearchLocation { get; set; }

        [XmlElement(ElementName = "search_distance")]
        public SearchDistance SearchDistance { get; set; }

        [XmlElement(ElementName = "search_offer")]
        public SearchOffer SearchOffer { get; set; }

        [XmlElement(ElementName = "search_lts")]
        public SearchLts SearchLts { get; set; }

        [XmlElement(ElementName = "search_special")]
        public SearchSpecial SearchSpecial { get; set; }

        [XmlElement(ElementName = "search_availability")]
        public SearchAvailability SearchAvailability { get; set; }

        [XmlElement(ElementName = "search_pricelist")]
        public SearchPriceList SearchPriceList { get; set; }

        [XmlElement(ElementName = "in")]
        public int[] In { get; set; }

        [XmlElement(ElementName = "id_ofchannel")]
        public string IdOfChannel { get; set; }

        [XmlElement(ElementName = "transaction_id")]
        public int? TransactionId { get; set; }

        [XmlElement(ElementName = "booking_id")]
        public string BookingId { get; set; }

        [XmlElement(ElementName = "guest_email")]
        public string GuestEmail { get; set; }
    }

    public sealed class Languages
    {
        public static readonly string German = "de";
        public static readonly string Italian = "it";
        public static readonly string English = "en";
        public static readonly string Spanish = "es";
        public static readonly string French = "fr";
        public static readonly string Russian = "ru";
        public static readonly string Danish = "da";
    }

    public class SearchHotel
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "type")]
        public int Type { get; set; }

        [XmlElement(ElementName = "stars")]
        public Stars Stars { get; set; }

        [XmlElement(ElementName = "feature")]
        public int Feature { get; set; }

        [XmlElement(ElementName = "theme")]
        public int HotelTheme { get; set; }
    }

    [Flags]
    public enum HotelTypes
    {
        Hotel = 1,
        SkiSchool = 2,
        Residence = 4,
        Appartment = 16,
        FarmVacation = 32,
        MountainInn = 64,
        CampingSite = 128,
        HolidayHome = 256,
        YouthHostel = 512,
        Guesthouse = 1024,
        Refuge = 2048,
        Garni = 4096,
        Inn = 8192,
    }

    public class Stars
    {
        [XmlElement(ElementName = "min")]
        public decimal Min { get; set; }

        [XmlElement(ElementName = "max")]
        public decimal Max { get; set; }
    }

    [Flags]
    public enum HotelFeatures
    {
        Garage = 1,
        Elevator = 2,
        Restaurant = 4,
        Gym = 8,
        Wellness = 16,
        Spa = 32,
        Breakfast = 64,
        Buffet = 128,
        OutdoorPool = 256,
        IndoorPool = 512,
        Bar = 1024,
        BarrierFree = 2048,
        Wlan = 4096,
        ShuttleService = 8192,
        Childcare = 16384,
        SmallPetsAllowed = 32768,
        BeautyFarm = 65536,
        CentralLocation = 262144,
        CoveredParking = 524288,
        OpenParking = 1048576,
        Massages = 2097152,
        Sauna = 4194304,
        SteamBath = 8388608,
        PublicBar = 16777216,
        DogsAllowed = 33554432,
    }

    [Flags]
    public enum HotelThemes
    {
        Family = 1,
        Wellness = 2,
        Hiking = 4,
        Motorcycle = 8,
        Bike = 16,
        Golf = 32,
        Riding = 64,
        Romantic = 128,
        Ski = 256,
        Meeting = 512,
        CrossCountrySkiing = 1024,
        Culture = 2048,
        Snowshoeing = 4096,
    }

    public class SearchLocation
    {
        [XmlElement(ElementName = "location")]
        public int[] Location { get; set; }

        [XmlElement(ElementName = "location_lts")]
        public string[] LocationLts { get; set; }
    }

    public class SearchDistance
    {
        [XmlElement(ElementName = "latitude")]
        public decimal Latitude { get; set; }

        [XmlElement(ElementName = "longitude")]
        public decimal Longitude { get; set; }

        [XmlElement(ElementName = "radius")]
        public int Radius { get; set; }
    }

    public class SearchOffer
    {
        [XmlElement(ElementName = "arrival")]
        public DateTime Arrival { get; set; }

        [XmlElement(ElementName = "departure")]
        public DateTime Departure { get; set; }

        [XmlElement(ElementName = "service")]
        public int Service { get; set; }

        [XmlElement(ElementName = "feature")]
        public int Feature { get; set; }

        [XmlElement(ElementName = "channel_id")]
        public string[] ChannelId { get; set; }

        [XmlElement(ElementName = "room")]
        public Room[] Rooms { get; set; }

        [XmlElement(ElementName = "typ")]
        public int Type { get; set; }

        [XmlElement(ElementName = "rateplan")]
        public Rateplan Rateplan { get; set; }
    }

    public enum Boards
    {
        Without = 1,
        Breakfast = 2,
        HalfBoard = 3,
        FullBoard = 4,
        AllInclusive = 5
    }

    [Flags]
    public enum RoomFeatures
    {
        Balcony = 1,
        Terrace = 2,
        MiniBar = 4,
        Safe = 8,
        TV = 16,
        Satellite = 32,
        Wlan = 64,
        Internet = 128,
        BarrierFree = 512
    }

    public class Room
    {
        [XmlElement(ElementName = "offer_id")]
        public int OfferId { get; set; }

        [XmlElement(ElementName = "room_id")]
        public int RoomId { get; set; }

        [XmlElement(ElementName = "service")]
        public int Service { get; set; }

        [XmlElement(ElementName = "room_type")]
        public int RoomType { get; set; }

        [XmlElement(ElementName = "room_seq")]
        public int RoomSeq { get; set; }

        [XmlElement(ElementName = "person")]
        public int[] Person { get; set; }
    }

    public enum RoomTypes
    {
        All = 0,
        Room = 1,
        Apartment = 2
    }

    public enum SearchOfferTypes
    {
        DefaultPricelist = 10,
        PeopleAge = 20,
        PeopleNumber = 21,
        Staying = 22,
        BookingDate = 23,
        Weekday = 24,
        NoReference = 25,
        SpecialPeopleAge = 50,
        SpecialPeopleNumber = 51,
        SpecialStaying = 52,
        SpecialBookingDate = 53,
        SpecialWeekday = 54,
        SpecialNoReference = 55
    }

    public class Rateplan
    {
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "source")]
        public string Source { get; set; }
    }

    public class SearchLts
    {
        [XmlElement(ElementName = "A0Ene")]
        public int A0Ene { get; set; }

        [XmlElement(ElementName = "A0MTV")]
        public int A0MTV { get; set; }

        [XmlElement(ElementName = "A0Rep")]
        public int A0Rep { get; set; }
    }

    public class SearchSpecial
    {
        [XmlElement(ElementName = "offerId")]
        public int[] OfferId { get; set; }

        [XmlElement(ElementName = "date_from")]
        public DateTime DateFrom { get; set; }

        [XmlElement(ElementName = "date_to")]
        public DateTime DateTo { get; set; }

        [XmlElement(ElementName = "theme")]
        public int Theme { get; set; }

        [XmlElement(ElementName = "validity")]
        public Validity Validity { get; set; }

        [XmlElement(ElementName = "typ")]
        public int Type { get; set; }

        [XmlElement(ElementName = "premium")]
        public int Premium { get; set; }
    }

    [Flags]
    public enum SpecialThemes
    {
        Hiking = 1,
        Cycling = 2,
        Family = 4,
        Wellness = 8,
        Food = 16,
        Golf = 32,
        Culture = 64,
        Motorsport = 128,
        CarFree = 256,
        SkiSnowboard = 512,
        SummerActivities = 1024,
        Events = 2048,
        ChristmasMarkets = 4096,
        ActiveWinter = 8192,
        Vitalpina = 16384,
        VitalpinaBreathe = 32768,
        BikeHotelsEBike = 65536,
        BikeHotelsFreeride = 131072,
        BikeHotelsMountainbike = 524288,
        BikeHotelsBikeTours = 1048576,
        BikeHotelsRacingBike = 2097152,
        FamilyHotels = 4194304,
        FamilyHotelsNatureDetective = 8388608,
        FamilyHotel = 33554432,
        FamilyHotelsNatureDetectiveSummer = 67108864,
        FamilyHotelsNatureDetectiveWinter = 134217728
    }

    public class Validity
    {
        [XmlElement(ElementName = "valid")]
        public bool IsValid { get; set; }

        [XmlElement(ElementName = "offers")]
        public bool HasOffers { get; set; }

        [XmlElement(ElementName = "arrival")]
        public DateTime Arrival { get; set; }

        [XmlElement(ElementName = "departure")]
        public DateTime Departure { get; set; }

        [XmlElement(ElementName = "service")]
        public int Service { get; set; }

        [XmlElement(ElementName = "room")]
        public Room[] Rooms { get; set; }
    }

    public enum SearchSpecialTypes
    {
        PriceLists = 0,
        Packages = 1,
        Specials = 2,
        ShortLongStays = 4
    }

    [Flags]
    public enum SearchSpecialPremiums
    {
        FamilyHotelsPremium = 2,
        VinumHotelsPremium = 4,
        SüdtirolBalancePremium = 8,
        VitalpinaDurchatmen = 16,
        VitalpinaWohlfühlen = 32,
        VitalpinaErnährung = 64,
        VitalpinaAktiv = 128,
        VitalpinaPremium = 256,
        BikehotelsMountainbike = 512,
        BikehotelsBikeTouringEBike = 1024,
        BikehotelsRoadbike = 2048,
        BikehotelsPremium = 4096,
        ArchitectureDays = 8192,
        VinumHotels = 16384,
        FamilyHotels = 32768,
        FamilyHotelsNatureDetective = 65536,
        FamilyHotelsNatureDetectiveWinter = 131072
    }

    public class SearchAvailability
    {
        [XmlElement(ElementName = "date_from")]
        public DateTime DateFrom { get; set; }

        [XmlElement(ElementName = "date_to")]
        public DateTime DateTo { get; set; }

        [XmlElement(ElementName = "offer_id")]
        public int[] OfferId { get; set; }

        [XmlElement(ElementName = "room_id")]
        public int[] RoomId { get; set; }
    }

    public class SearchPriceList
    {
        [XmlElement(ElementName = "date_from")]
        public DateTime DateFrom { get; set; }

        [XmlElement(ElementName = "date_to")]
        public DateTime DateTo { get; set; }

        [XmlElement(ElementName = "service")]
        public int Service { get; set; }

        [XmlElement(ElementName = "room_id")]
        public int[] RoomId { get; set; }

        [XmlElement(ElementName = "typ")]
        public int Type { get; set; }
    }

    public class Options
    {
        [XmlElement(ElementName = "hotel_details")]
        public int HotelDetails { get; set; }

        [XmlElement(ElementName = "offer_details")]
        public int OfferDetails { get; set; }

        [XmlElement(ElementName = "room_details")]
        public int RoomDetails { get; set; }

        [XmlElement(ElementName = "special_details")]
        public int SpecialDetails { get; set; }

        [XmlElement(ElementName = "pricelist_details")]
        public int PriceListDetails { get; set; }

        [XmlElement(ElementName = "picture_date")]
        public DateTime? PictureDate { get; set; }

        [XmlElement(ElementName = "lts_bookable")]
        public int? LtsBookable { get; set; }

        [XmlElement(ElementName = "get_availability")]
        public bool? GetAvailability { get; set; }

        [XmlElement(ElementName = "get_restrictions")]
        public bool? GetRestrictions { get; set; }

        [XmlElement(ElementName = "get_roomdetails")]
        public bool? GetRoomDetails { get; set; }

        [XmlElement(ElementName = "base_price")]
        public int? BasePrice { get; set; }
    }

    [Flags]
    public enum HotelDetails
    {
        BasicInfo = 1,
        Themes = 2,
        HotelFacilities = 4,
        ShortDescription = 8,
        FullDescription = 16,
        GeographicInformation = 32,
        Coordinates = 64,
        Address = 128,
        Contacts = 256,
        PaymentOptionsForOnlineBooking = 512,
        PaymentOptionsAtHotel = 1024,
        Logo = 2048,
        HeaderImages = 4096,
        Gallery = 8192,
        HotelMatching = 16384,
        GeographicalInformationAsText = 32768,
        HotelNavigatorData = 65536,
        DetailedHotelFacilities = 131072,
        SalesPoint = 524288,
        LtsSpecificParameters = 262144,
        CheckInOut = 1048576,
        SourceData = 2097152
    }

    [Flags]
    public enum OfferDetails
    {
        None = 0,
        BasicInfo = 1,
        RoomCode = 4,
        RoomTitle = 8,
        PriceDetails = 16,
        RoomImages = 32,
        RoomFacilitiesFilter = 64,
        RoomDescription = 256,
        IncludedServices = 1024,
        AdditionalServices = 2048,
        RoomFacilitiesDetails = 4096,
        PriceImages = 8192,
        Themes = 16384,
        RoomFeatures = 32768,
        CancelPolicies = 262144,
        PaymentTerms = 1048576,
    }

    [Flags]
    public enum RoomDetails
    {
        BasicInfo = 4,
        Title = 8,
        RoomImages = 32,
        RoomFacilitiesFilter = 64,
        RoomDescription = 256,
        RoomFacilitiesDetails = 4096,
        RoomFeatures = 32768,
        RoomNumbers = 65536
    }

    [Flags]
    public enum SpecialDetails
    {
        BasicInfo = 1,
        Title = 2,
        Descriptions = 4,
        Seasons = 8,
        Images = 16,
        Themes = 32,
        IncludedServices = 64
    }

    [Flags]
    public enum PriceListDetails
    {
        BaseData = 1,
        Headlines = 8,
        Seasons = 4194304
    }

    public class Order
    {
        [XmlElement(ElementName = "field")]
        public string Field { get; set; }

        [XmlElement(ElementName = "dir")]
        public string Dir { get; set; }
    }

    public class Data
    {
        [XmlElement(ElementName = "guest")]
        public Guest Guest { get; set; }

        [XmlElement(ElementName = "company")]
        public Company Company { get; set; }

        [XmlElement(ElementName = "payment")]
        public Payment Payment { get; set; }

        [XmlElement(ElementName = "note")]
        public string Note { get; set; }

        [XmlElement(ElementName = "details")]
        public Details Details { get; set; }

        [XmlElement(ElementName = "form")]
        public Form Form { get; set; }

        [XmlElement(ElementName = "tracking")]
        public Tracking Tracking { get; set; }
    }

    public class Guest
    {
        [XmlElement(ElementName = "gender")]
        public string Gender { get; set; }

        [XmlElement(ElementName = "prefix")]
        public string Prefix { get; set; }

        [XmlElement(ElementName = "firstname")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "lastname")]
        public string LastaName { get; set; }

        [XmlElement(ElementName = "email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "phone")]
        public string Phone { get; set; }

        [XmlElement(ElementName = "address")]
        public Address Address { get; set; }

        [XmlElement(ElementName = "newsletter")]
        public bool IsSubscribedToNewsletter { get; set; }
    }

    public class Address
    {
        [XmlElement(ElementName = "street")]
        public string Street { get; set; }

        [XmlElement(ElementName = "zipcode")]
        public string ZipCode { get; set; }

        [XmlElement(ElementName = "city")]
        public string City { get; set; }

        [XmlElement(ElementName = "country")]
        public string Country { get; set; }
    }

    public class Company
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "taxnumber")]
        public string TaxNumber { get; set; }

        [XmlElement(ElementName = "address")]
        public Address Address { get; set; }
    }

    public class Payment
    {
        [XmlElement(ElementName = "method")]
        public int Method { get; set; }

        [XmlElement(ElementName = "invoice")]
        public bool Invoice { get; set; }
    }

    [Flags]
    public enum PaymentMethods
    {
        CreditCardDeposit = 1,
        CreditCardAsSecurity = 2,
        CreditCardPayment = 8,
        BankTransferDeposit = 4,
        BankTransferPayment = 16,
        AccommodationPayment = 32
    }

    public class Details
    {
        [XmlElement(ElementName = "extr_price")]
        public ExtraPrice[] EtryPrices { get; set; }
    }

    public class ExtraPrice
    {
        [XmlElement(ElementName = "price_id")]
        public int PriceId { get; set; }

        [XmlElement(ElementName = "price_amount")]
        public decimal PriceAmount { get; set; }
    }

    public class Form
    {
        [XmlElement(ElementName = "url_success")]
        public string UrlSuccess { get; set; }

        [XmlElement(ElementName = "url_failure")]
        public string UrlFailure { get; set; }
    }

    public class Tracking
    {
        [XmlElement(ElementName = "partner")]
        public string Partner { get; set; }

        [XmlElement(ElementName = "media")]
        public string Media { get; set; }

        [XmlElement(ElementName = "campaign")]
        public string Campaign { get; set; }

        [XmlElement(ElementName = "companyinfo")]
        public string CompanyInfo { get; set; }
    }

    public class Logging
    {
        [XmlElement(ElementName = "step")]
        public string Step { get; set; }
    }
}
