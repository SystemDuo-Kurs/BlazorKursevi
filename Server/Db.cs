using BlazorKursevi.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorKursevi.Server
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> opcije) : base(opcije)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Osoba>().HasKey(o => o.Id);
            modelBuilder.Entity<Osoba>()
                .HasIndex(o => o.Telefon)
                .IsUnique();
        }

        private DbSet<Osoba> Osobe { get; set; }
        private DbSet<Polaznik> Polaznici { get; set; }
        private DbSet<Predavac> Predavaci { get; set; }
    }
}