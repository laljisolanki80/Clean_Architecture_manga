using Microsoft.AspNetCore.Identity;

namespace Maxnga.Infrastructure.EntityFrameworkDataAccess
{
    public class Consumer:IdentityUser
    {
        public string SSN { get; set; }
    }
}