﻿using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ProfilePictureUrl { get; set; }
        public string password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
