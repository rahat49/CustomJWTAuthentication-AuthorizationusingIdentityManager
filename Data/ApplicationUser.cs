using Microsoft.AspNetCore.Identity;

namespace Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
