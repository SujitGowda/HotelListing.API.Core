using AutoMapper;
using HotelListing.API.Data.Contracts;

namespace HotelListing.API.Data.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context,IMapper mapper) : base(context,mapper)
        {
        }
    }
}
