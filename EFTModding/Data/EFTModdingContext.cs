using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EFTModding.Models
{
    public class EFTModdingContext : DbContext
    {
        public EFTModdingContext(DbContextOptions<EFTModdingContext> options)
            : base(options)
        {
        }

        public DbSet<Weapon> Weapon { get; set; }
    }
}
