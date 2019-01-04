using System;
using System.Xml.Serialization;

namespace MssNet.Models.Response
{
    [XmlRoot(ElementName = "root")]
    public class Root
    {
        [XmlElement(ElementName = "header")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "result")]
        public Result Result { get; set; }
    }

    public class Header
    {
        [XmlElement(ElementName = "error")]
        public Error Error { get; set; }

        [XmlElement(ElementName = "paging")]
        public Paging Paging { get; set; }

        [XmlElement(ElementName = "result_id")]
        public string ResultId { get; set; }

        [XmlElement(ElementName = "source")]
        public string Source { get; set; }

        [XmlElement(ElementName = "time")]
        public string Time { get; set; }
    }

    public class Error
    {
        [XmlElement(ElementName = "code")]
        public int Code { get; set; }

        [XmlElement(ElementName = "message")]
        public string Message { get; set; }
    }

    public class Paging
    {
        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlElement(ElementName = "total")]
        public int Total { get; set; }
    }

    public class Result
    {
        [XmlElement(ElementName = "hotel")]
        public Hotel[] Hotels { get; set; }

        [XmlElement(ElementName = "specials")]
        public Special[] Specials { get; set; }
    }

    public class Hotel
    {
        [XmlElement(ElementName = "address")]
        public Address Address { get; set; }

        [XmlElement(ElementName = "bookable")]
        public bool Bookable { get; set; }

        [XmlElement(ElementName = "channel")]
        public Channel Channel { get; set; }

        [XmlElement(ElementName = "check_in")]
        public CheckInOut CheckIn { get; set; }

        [XmlElement(ElementName = "check_out")]
        public CheckInOut CheckOut { get; set; }

        [XmlElement(ElementName = "contact")]
        public Contact Contact { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "features")]
        public int Features { get; set; }

        [XmlElement(ElementName = "features_view")]
        public Feature[] FeaturesView { get; set; }

        [XmlElement(ElementName = "gallery")]
        public Picture[] Gallery { get; set; }

        [XmlElement(ElementName = "geolocation")]
        public Geolocation Geolocation { get; set; }

        [XmlElement(ElementName = "headline")]
        public string Headline { get; set; }

        [XmlElement(ElementName = "hotel_payment")]
        public HotelPayment HotelPayment { get; set; }

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "id_lts")]
        public string IdLts { get; set; }

        [XmlElement(ElementName = "language")]
        public string Language { get; set; }

        [XmlElement(ElementName = "location")]
        public Location Location { get; set; }

        [XmlElement(ElementName = "location_name")]
        public LocationName LocationName { get; set; }

        [XmlElement(ElementName = "logo")]
        public Picture[] Logos { get; set; }

        [XmlElement(ElementName = "lts_data")]
        public LtsData LtsData { get; set; }

        [XmlElement(ElementName = "matching")]
        public Matching Matching { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "board")]
        public int Board { get; set; }

        [XmlElement(ElementName = "pers_age_min")]
        public decimal PersAgeMin { get; set; }

        [XmlElement(ElementName = "pictures")]
        public Picture[] Pictures { get; set; }

        [XmlElement(ElementName = "pos")]
        public string[] Pos { get; set; }

        [XmlElement(ElementName = "price_engine")]
        public int PriceEngine { get; set; }

        [XmlElement(ElementName = "price_from")]
        public decimal PriceFrom { get; set; }

        [XmlElement(ElementName = "ratings")]
        public Rating[] Ratings { get; set; }

        [XmlElement(ElementName = "stars")]
        public decimal Stars { get; set; }

        [XmlElement(ElementName = "type")]
        public int Type { get; set; }
    }

    public sealed class Languages
    {
        public static readonly string German = "de";
        public static readonly string italian = "it";
        public static readonly string English = "en";
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

        [XmlElement(ElementName = "zip")]
        public string Zip { get; set; }

        [XmlElement(ElementName = "url_streetview")]
        public string UrlStreetView { get; set; }
    }

    public class Channel
    {
        [XmlElement(ElementName = "base_price")]
        public Price[] BasePrices { get; set; }

        [XmlElement(ElementName = "channel_id")]
        public string ChannelId { get; set; }

        [XmlElement(ElementName = "from_price")]
        public decimal FromPrice { get; set; }

        [XmlElement(ElementName = "offer_description")]
        public Offer[] OfferDescriptions { get; set; }

        [XmlElement(ElementName = "room_description")]
        public Room[] Rooms { get; set; }

        [XmlElement(ElementName = "room_price")]
        public RoomPrice[] RoomPrices { get; set; }

        [XmlElement(ElementName = "service_price")]
        public Price[] ServicePrices { get; set; }

        [XmlElement(ElementName = "cancel_policies")]
        public CancelPolicy[] CancelPolicies { get; set; }

        [XmlElement(ElementName = "payment_terms")]
        public PaymentTerm[] PaymentTerms { get; set; }
    }

    public class Price
    {
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "pictures")]
        public Picture[] Pictures { get; set; }

        [XmlElement(ElementName = "price_ai")]
        public decimal PriceAi { get; set; }

        [XmlElement(ElementName = "price_amount")]
        public decimal PriceAmount { get; set; }

        [XmlElement(ElementName = "price_bb")]
        public decimal PriceBb { get; set; }

        [XmlElement(ElementName = "price_description")]
        public string PriceDescription { get; set; }

        [XmlElement(ElementName = "price_fb")]
        public decimal PriceFb { get; set; }

        [XmlElement(ElementName = "price_hb")]
        public decimal PriceHb { get; set; }

        [XmlElement(ElementName = "price_id")]
        public decimal PriceId { get; set; }

        [XmlElement(ElementName = "price_supplement")]
        public decimal PriceSupplement { get; set; }

        [XmlElement(ElementName = "price_title")]
        public string PriceTitle { get; set; }

        [XmlElement(ElementName = "price_total")]
        public decimal PriceTotal { get; set; }

        [XmlElement(ElementName = "price_typ")]
        public int PriceType { get; set; }

        [XmlElement(ElementName = "price_value")]
        public decimal PriceValue { get; set; }

        [XmlElement(ElementName = "price_ws")]
        public decimal PriceWs { get; set; }

        [XmlElement(ElementName = "supplement")]
        public int Supplement { get; set; }

        [XmlElement(ElementName = "title")]
        public string String { get; set; }

        [XmlElement(ElementName = "unit")]
        public int Unit { get; set; }

        [XmlElement(ElementName = "cancel_policy_id")]
        public int CancelPolicyId { get; set; }

        [XmlElement(ElementName = "payment_term_id")]
        public int PaymentTermId { get; set; }
    }

    public class Picture
    {
        [XmlElement(ElementName = "copyright")]
        public string Copyright { get; set; }

        [XmlElement(ElementName = "time")]
        public int Time { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "url")]
        public string Url { get; set; }
    }

    public class Offer
    {
        [XmlElement(ElementName = "offer_base_id")]
        public int OfferBaseId { get; set; }

        [XmlElement(ElementName = "offer_description")]
        public string OfferDescription { get; set; }

        [XmlElement(ElementName = "offer_gid")]
        public int OfferGid { get; set; }

        [XmlElement(ElementName = "offer_id")]
        public int OfferId { get; set; }

        [XmlElement(ElementName = "offer_show")]
        public int OfferShow { get; set; }

        [XmlElement(ElementName = "offer_title")]
        public string OfferTitle { get; set; }

        [XmlElement(ElementName = "offer_typ")]
        public int OfferType { get; set; }

        [XmlElement(ElementName = "pictures")]
        public Picture[] Pictures { get; set; }

        [XmlElement(ElementName = "themes")]
        public Theme[] Themes { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
    }

    public class Theme
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
    }

    public class Room
    {
        [XmlElement(ElementName = "days")]
        public Day[] Days { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "features")]
        public int Features { get; set; }

        [XmlElement(ElementName = "features_view")]
        public Feature[] FeaturesView { get; set; }

        [XmlElement(ElementName = "occupancy")]
        public Occupancy Occupancy { get; set; }

        [XmlElement(ElementName = "pictures")]
        public Picture[] Pictures { get; set; }

        [XmlElement(ElementName = "price_from")]
        public decimal PriceFrom { get; set; }

        [XmlElement(ElementName = "pricelist")]
        public PriceList[] PriceLists { get; set; }

        [XmlElement(ElementName = "properties")]
        public Properties Properties { get; set; }

        [XmlElement(ElementName = "room_code")]
        public string RoomCode { get; set; }

        [XmlElement(ElementName = "room_description")]
        public string RoomDescription { get; set; }

        [XmlElement(ElementName = "room_details")]
        public RoomDetail[] RoomDetails { get; set; }

        [XmlElement(ElementName = "room_free")]
        public decimal RoomFree { get; set; }

        [XmlElement(ElementName = "room_id")]
        public int RoomId { get; set; }

        [XmlElement(ElementName = "room_lts_id")]
        public int RoomLtsId { get; set; }

        [XmlElement(ElementName = "room_numbers")]
        public string[] RoomNumbers { get; set; }

        [XmlElement(ElementName = "room_persons")]
        public string RoomPersons { get; set; }

        [XmlElement(ElementName = "room_price")]
        public Price[] RoomPrices { get; set; }

        [XmlElement(ElementName = "room_title")]
        public string RoomTitle { get; set; }

        [XmlElement(ElementName = "room_total")]
        public decimal RoomTotal { get; set; }

        [XmlElement(ElementName = "room_type")]
        public int RoomType { get; set; }

        [XmlElement(ElementName = "service")]
        public int Service { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
    }

    public class Day
    {
        [XmlElement(ElementName = "date")]
        public DateTime Date { get; set; }

        [XmlElement(ElementName = "free")]
        public int Free { get; set; }

        [XmlElement(ElementName = "restrictions")]
        public Restrictions[] Restrictions { get; set; }
    }

    public class Restrictions
    {
        [XmlElement(ElementName = "arrival")]
        public int Arrival { get; set; }

        [XmlElement(ElementName = "children_max")]
        public int ChildrenMax { get; set; }

        [XmlElement(ElementName = "children_min")]
        public int ChildrenMin { get; set; }

        [XmlElement(ElementName = "close")]
        public int Close { get; set; }

        [XmlElement(ElementName = "days_arrival_max")]
        public int DaysArrivalMax { get; set; }

        [XmlElement(ElementName = "days_arrival_min")]
        public int DaysArrivalMin { get; set; }

        [XmlElement(ElementName = "departure")]
        public int Departure { get; set; }

        [XmlElement(ElementName = "holes")]
        public int Holes { get; set; }

        [XmlElement(ElementName = "max")]
        public int Max { get; set; }

        [XmlElement(ElementName = "max_arrival")]
        public int MaxArrival { get; set; }

        [XmlElement(ElementName = "min")]
        public int Min { get; set; }

        [XmlElement(ElementName = "min_arrival")]
        public int MinArrival { get; set; }

        [XmlElement(ElementName = "obj_id")]
        public int ObjId { get; set; }

        [XmlElement(ElementName = "pers_age_min")]
        public int PersAgeMin { get; set; }

        [XmlElement(ElementName = "service")]
        public int Service { get; set; }
    }

    public class Feature
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
    }

    public class Occupancy
    {
        [XmlElement(ElementName = "max")]
        public int Max { get; set; }

        [XmlElement(ElementName = "min")]
        public int Min { get; set; }

        [XmlElement(ElementName = "std")]
        public int Std { get; set; }
    }

    public class PriceList
    {
        [XmlElement(ElementName = "adults_max")]
        public int AdultsMax { get; set; }

        [XmlElement(ElementName = "adults_min")]
        public int AdultsMin { get; set; }

        [XmlElement(ElementName = "children_max")]
        public int ChildrenMax { get; set; }

        [XmlElement(ElementName = "children_min")]
        public int ChildrenMin { get; set; }

        [XmlElement(ElementName = "days_arrival")]
        public int DaysArrival { get; set; }

        [XmlElement(ElementName = "days_arrival_max")]
        public int DaysArrivalMax { get; set; }

        [XmlElement(ElementName = "days_arrival_min")]
        public int DaysArrivalMin { get; set; }

        [XmlElement(ElementName = "days_departure")]
        public int DaysDeparture { get; set; }

        [XmlElement(ElementName = "days_dur_max")]
        public int DaysDurMax { get; set; }

        [XmlElement(ElementName = "days_dur_min")]
        public int DaysDurMin { get; set; }

        [XmlElement(ElementName = "offer_base_id")]
        public int OfferBaseId { get; set; }

        [XmlElement(ElementName = "offer_id")]
        public int OfferId { get; set; }

        [XmlElement(ElementName = "offer_typ")]
        public int OfferType { get; set; }

        [XmlElement(ElementName = "prl_mode")]
        public int PrlMode { get; set; }

        [XmlElement(ElementName = "prl_unit")]
        public int PrlUnit { get; set; }

        [XmlElement(ElementName = "season")]
        public Season[] Seasons { get; set; }

        [XmlElement(ElementName = "special_typ")]
        public int SpecialType { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
    }

    public class Season
    {
        [XmlElement(ElementName = "date_end")]
        public DateTime DateEnd { get; set; }

        [XmlElement(ElementName = "date_start")]
        public DateTime DateStart { get; set; }

        [XmlElement(ElementName = "price")]
        public Price Title { get; set; }
    }

    public class Properties
    {
        [XmlElement(ElementName = "area")]
        public int Area { get; set; }

        [XmlElement(ElementName = "bath_rooms")]
        public int BathRooms { get; set; }

        [XmlElement(ElementName = "bed_rooms")]
        public int BedRooms { get; set; }

        [XmlElement(ElementName = "dining_rooms")]
        public int DiningRooms { get; set; }

        [XmlElement(ElementName = "living_rooms")]
        public int LivingRooms { get; set; }

        [XmlElement(ElementName = "max")]
        public int Max { get; set; }

        [XmlElement(ElementName = "min")]
        public int Min { get; set; }

        [XmlElement(ElementName = "std")]
        public int Std { get; set; }
    }

    public class RoomDetail
    {
        [XmlElement(ElementName = "availability")]
        public string Availability { get; set; }

        [XmlElement(ElementName = "number")]
        public string Number { get; set; }
    }

    public class RoomPrice
    {
        [XmlElement(ElementName = "offer_id")]
        public int OfferId { get; set; }

        [XmlElement(ElementName = "price_details")]
        public Price[] PriceDetails { get; set; }

        [XmlElement(ElementName = "price_inclusive")]
        public Price[] PriceInclusive { get; set; }

        [XmlElement(ElementName = "price_total")]
        public Price PriceTotal { get; set; }

        [XmlElement(ElementName = "room_id")]
        public int RoomId { get; set; }

        [XmlElement(ElementName = "room_seq")]
        public int RoomSeq { get; set; }
    }

    public enum RoomType
    {
        Room = 1,
        Apartment = 2
    }

    public class CancelPolicy
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "refundable")]
        public bool Refundable { get; set; }

        [XmlElement(ElementName = "refundable_until")]
        public DateTime RefundableUntil { get; set; }

        [XmlElement(ElementName = "penalties")]
        public Penalty[] Penalties { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "priority")]
        public string Priority { get; set; }
    }

    public class Penalty
    {
        [XmlElement(ElementName = "percent")]
        public int Percent { get; set; }

        [XmlElement(ElementName = "datefrom")]
        public DateTime From { get; set; }

        [XmlElement(ElementName = "daysarrival")]
        public int DaysArrival { get; set; }
    }

    public class PaymentTerm
    {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "owner_id")]
        public int OwnerId { get; set; }

        [XmlElement(ElementName = "methods")]
        public int Methods { get; set; }

        [XmlElement(ElementName = "prepayment")]
        public int PrePayment { get; set; }

        [XmlElement(ElementName = "ccards")]
        public int Ccards { get; set; }

        [XmlElement(ElementName = "priority")]
        public int Priority { get; set; }

        [XmlElement(ElementName = "bank")]
        public Bank Bank { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
    }

    public class Bank
    {
        [XmlElement(ElementName = "iban")]
        public string Iban { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "swift")]
        public string Swift { get; set; }
    }

    public class CheckInOut
    {
        [XmlElement(ElementName = "from")]
        public string From { get; set; }

        [XmlElement(ElementName = "to")]
        public string To { get; set; }
    }

    public class Special
    {
        [XmlElement(ElementName = "adults_max")]
        public int AdultsMax { get; set; }

        [XmlElement(ElementName = "adults_min")]
        public int AdultsMin { get; set; }

        [XmlElement(ElementName = "children_max")]
        public int ChildrenMax { get; set; }

        [XmlElement(ElementName = "children_min")]
        public int ChildrenMin { get; set; }

        [XmlElement(ElementName = "days_arrival")]
        public int DaysArrival { get; set; }

        [XmlElement(ElementName = "days_arrival_max")]
        public int DaysArrivalMax { get; set; }

        [XmlElement(ElementName = "days_arrival_min")]
        public int DaysArrivalMin { get; set; }

        [XmlElement(ElementName = "days_departure")]
        public int DaysDeparture { get; set; }

        [XmlElement(ElementName = "days_dur_max")]
        public int DaysDurMax { get; set; }

        [XmlElement(ElementName = "days_dur_min")]
        public int DaysDurMin { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "hotels")]
        public Hotel[] Hotels { get; set; }

        [XmlElement(ElementName = "inclusive")]
        public Price[] Inclusive { get; set; }

        [XmlElement(ElementName = "offer_id")]
        public int OfferId { get; set; }

        [XmlElement(ElementName = "offer_typ")]
        public int OfferType { get; set; }

        [XmlElement(ElementName = "pictures")]
        public Picture[] Pictures { get; set; }

        [XmlElement(ElementName = "seasons")]
        public Season[] Seasons { get; set; }

        [XmlElement(ElementName = "services")]
        public int[] Services { get; set; }

        [XmlElement(ElementName = "special_premium")]
        public int SpecialPremium { get; set; }

        [XmlElement(ElementName = "special_typ")]
        public int SpecialType { get; set; }

        [XmlElement(ElementName = "status")]
        public int Status { get; set; }

        [XmlElement(ElementName = "themes")]
        public Theme[] Themes { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "valid")]
        public int Valid { get; set; }

        [XmlElement(ElementName = "valid_end")]
        public DateTime ValidEnd { get; set; }

        [XmlElement(ElementName = "valid_start")]
        public DateTime ValidStart { get; set; }
    }

    public class Contact
    {
        [XmlElement(ElementName = "email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "fax")]
        public string Fax { get; set; }

        [XmlElement(ElementName = "phone")]
        public string Phone { get; set; }

        [XmlElement(ElementName = "web")]
        public string Web { get; set; }
    }

    public class Geolocation
    {
        [XmlElement(ElementName = "altitude")]
        public int Altitude { get; set; }

        [XmlElement(ElementName = "distance")]
        public int Distance { get; set; }

        [XmlElement(ElementName = "latitude")]
        public decimal Latitude { get; set; }

        [XmlElement(ElementName = "longitude")]
        public decimal Longitude { get; set; }
    }

    public class HotelPayment
    {
        [XmlElement(ElementName = "methods")]
        public int Methods { get; set; }
    }

    public class Location
    {
        [XmlElement(ElementName = "id_area")]
        public int IdArea { get; set; }

        [XmlElement(ElementName = "id_city")]
        public int IdCity { get; set; }

        [XmlElement(ElementName = "id_community")]
        public int IdCommunity { get; set; }

        [XmlElement(ElementName = "id_region")]
        public int IdRegion { get; set; }
    }

    public class LocationName
    {
        [XmlElement(ElementName = "name_area")]
        public string NameArea { get; set; }

        [XmlElement(ElementName = "name_city")]
        public string NameCity { get; set; }

        [XmlElement(ElementName = "name_community")]
        public string NameCommunity { get; set; }

        [XmlElement(ElementName = "name_region")]
        public string NameRegion { get; set; }
    }

    public class LtsData
    {
        [XmlElement(ElementName = "A0Ene")]
        public int A0Ene { get; set; }

        [XmlElement(ElementName = "A0MTV")]
        public int A0MTV { get; set; }

        [XmlElement(ElementName = "A0Rep")]
        public int A0Rep { get; set; }
    }

    public class Matching
    {
        [XmlElement(ElementName = "id_bok")]
        public int IdBok { get; set; }

        [XmlElement(ElementName = "id_exp")]
        public int IdExp { get; set; }

        [XmlElement(ElementName = "id_hrs")]
        public int IdHrs { get; set; }

        [XmlElement(ElementName = "id_htl")]
        public int IdHtl { get; set; }
    }

    [Flags]
    public enum Board
    {
        NotDefined = 0,
        Without = 1,
        Breakfast = 2,
        HalfBoard = 4,
        FullBoard = 8,
        AllInclusive = 16
    }

    public class Rating
    {
        [XmlElement(ElementName = "count")]
        public int Count { get; set; }

        [XmlElement(ElementName = "date")]
        public DateTime Date { get; set; }

        [XmlElement(ElementName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "provider")]
        public string Provider { get; set; }

        [XmlElement(ElementName = "value")]
        public decimal Value { get; set; }
    }
}
