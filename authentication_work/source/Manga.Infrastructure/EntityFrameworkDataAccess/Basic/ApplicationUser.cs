using Microsoft.AspNetCore.Identity;

namespace Manga.Infrastructure.EntityFrameworkDataAccess.Basic
{
    public class ApplicationUser:IdentityUser
    {
        public string SSN { get; set; }
    }
}