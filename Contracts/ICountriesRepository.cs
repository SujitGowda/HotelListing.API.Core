
namespace HotelListing.API.Data.Contracts
{
    public interface ICountriesRepository:IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
