﻿using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ProfilePictureUrl { get; set; }
    }
}
