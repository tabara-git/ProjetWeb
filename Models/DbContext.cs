using Microsoft.EntityFrameworkCore;

namespace ProjetWeb.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }

        public BddContext(DbContextOptions<BddContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personne>().ToTable("Personne");
           
        }


    }

}
