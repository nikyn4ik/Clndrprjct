using Microsoft.AspNetCore.Identity;

namespace Clndrprjct.Services
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string description, bool isDefault) : base(roleName)
        {
            Description = description;
            IsDefault = isDefault;
        }

        public string Description { get; set; }
        public bool IsDefault { get; set; }
    }
}
