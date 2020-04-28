using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace MyLifeStory.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string ProfilePhoto { get; set; }

        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
