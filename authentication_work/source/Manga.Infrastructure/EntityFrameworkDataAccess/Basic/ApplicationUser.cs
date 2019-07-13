using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manga.Infrastructure.EntityFrameworkDataAccess.Basic
{
    public class ApplicationUser:IdentityUser
    {
        [Column]
        public string SSN { get; set; }
    }
}