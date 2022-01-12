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

            modelBuilder.Entity<Predavac>().HasData(new[]
            {
                new Predavac{ Id=-1, Ime="Pera", Prezime="Peric",
                                Telefon = "12345", Mejl="p@p.p"},
                new Predavac{ Id=-2, Ime="Neko", Prezime="Nekic",
                                Telefon = "345345", Mejl="bla@bla.bla"},
                new Predavac{ Id=-3, Ime="Asd", Prezime="Qwe",
                                Telefon = "65432", Mejl="asd@asd.asd"}
            });
            modelBuilder.Entity<Polaznik>().HasData(new[]
            {
                new Polaznik{ Id=-4, Ime="Qweqwe", Prezime="Asdasd",
                                Telefon = "0123135", Mejl="q@q.q"},
                new Polaznik{ Id=-5, Ime="Zxczxc", Prezime="Zxczxc",
                                Telefon = "5363456346", Mejl="zxc@bla.bla"},
                new Polaznik{ Id=-6, Ime="Lkj", Prezime="Lkj",
                                Telefon = "34235", Mejl="lkj@l.l"}
            });
        }

        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Polaznik> Polaznici { get; set; }
        public DbSet<Predavac> Predavaci { get; set; }
    }
}