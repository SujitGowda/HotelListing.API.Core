﻿using System.ComponentModel.DataAnnotations;
//using Microsoft.Build.Framework;

namespace HotelListing.API.Data.Models.Hotels
{
    public abstract class BaseHotelDetails
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public double? Rating { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}