using HotelListing.API.Data.Models.Hotels;

namespace HotelListing.API.Data.Models.Country
{
    public class CountryDetailsModel:BaseCountryDetails
    {
        public int Id { get; set; }
        public List<HotelsModel> Hotels { get; set; }

    }
    
}
