﻿using Microsoft.AspNetCore.Identity;

namespace RO_BOOKING_Backend.Entities
{
    public class Role : IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }

    }
}
