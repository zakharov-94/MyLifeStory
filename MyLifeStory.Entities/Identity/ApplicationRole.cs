using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MyLifeStory.Entities.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole(string roleName) : base(roleName)
        {

        }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
