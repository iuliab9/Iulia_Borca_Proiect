using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iulia_Borca_Proiect.Models;

namespace Iulia_Borca_Proiect.Data
{
    public class Iulia_Borca_ProiectContext : DbContext
    {
        public Iulia_Borca_ProiectContext (DbContextOptions<Iulia_Borca_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Iulia_Borca_Proiect.Models.Flower> Flower { get; set; } = default!;
    }
}
