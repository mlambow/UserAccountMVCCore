using Microsoft.AspNetCore.Identity;

namespace UserAccount.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
