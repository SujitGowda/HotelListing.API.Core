﻿namespace HotelListing.API.Data.Models.Users
{
    public class AuthResponseDetails
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
