﻿using AutoMapper;
using HotelListing.API.Data.Models.Country;
using HotelListing.API.Data.Models.Hotels;
using HotelListing.API.Data.Models.Users;

namespace HotelListing.API.Data.Configuratons
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryModel>().ReverseMap();
            CreateMap<Country, GetCountryModel>().ReverseMap();
            CreateMap<Country, CountryDetailsModel>().ReverseMap();
            CreateMap<Country,UpdateCountryModel>().ReverseMap();
            CreateMap<Hotel, HotelsModel>().ReverseMap();
            CreateMap<Hotel, CreateHotelDetails>().ReverseMap();
            CreateMap<ApiUser, ApiUserDetails>().ReverseMap();

        }
    }
}
