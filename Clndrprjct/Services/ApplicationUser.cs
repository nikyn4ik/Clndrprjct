using Microsoft.AspNetCore.Identity;

namespace Clndrprjct.Services
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
