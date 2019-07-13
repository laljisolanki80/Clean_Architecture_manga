using Manga.Application.Boundaries.Register;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manga.Infrastructure.EntityFrameworkDataAccess.Basic
{
    public interface IAntiCorruption
    {
        Customer Translate(ApplicationUser applicationUser);
    }
}
