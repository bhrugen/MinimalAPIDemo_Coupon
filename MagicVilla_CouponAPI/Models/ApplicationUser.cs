using Microsoft.AspNetCore.Identity;

namespace MagicVilla_CouponAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
