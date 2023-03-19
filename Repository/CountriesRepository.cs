using AutoMapper;
using AutoMapper.QueryableExtensions;
using HotelListing.API.Data.Contracts;
using HotelListing.API.Data.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data.Repository
{
    public class CountriesRepository :GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;
        private readonly IMapper _mapper;

        public CountriesRepository(HotelListingDbContext context,IMapper mapper):base(context,mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<Country> GetDetails(int id)
        {
            //return await _context.countries.Include(q => q.Hotels)
            //    .FirstOrDefaultAsync(q => q.Id == id);

            var country = await _context.countries.Include(q => q.Hotels)
               .ProjectTo<Country>(_mapper.ConfigurationProvider)
               .FirstOrDefaultAsync(q => q.Id == id);

            if (country == null)
            {
                throw new NotFoundException(nameof(GetDetails), id);
            }

            return country;
        }
    }
}
