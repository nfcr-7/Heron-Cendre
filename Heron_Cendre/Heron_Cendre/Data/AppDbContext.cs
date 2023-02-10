using Heron_Cendre.Models;
using Microsoft.EntityFrameworkCore;

namespace Heron_Cendre.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Chambre> chambres { get; set; }

        public DbSet<Client> clients { get; set; }  

        public DbSet<Evenement> evenements { get; set; }

        public DbSet<Menu> menu { get; set; }

        public DbSet<Prestation> prestations { get; set; }

        public DbSet<Reservation> reservation { get; set; }

        public DbSet<Table> table { get; set; } 
    }
}
