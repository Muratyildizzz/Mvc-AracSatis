using AracSatis.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSatis.Data
{
    public class BaseDbContext:DbContext
    {
        public DbSet<Arac> Aracs { get; set; }
        public DbSet<Kullanici> Kullanicilarr { get; set; }
        public DbSet<Marka> Markalarr { get; set; }
        public DbSet<Musteri> Musterilerr { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Satis> Satislarr { get; set; }
        public DbSet<Slider> Sliderlerr { get; set; }

      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MURATYıLDıZ\\MSSQLSERVER22;database=Arac_Satiss;integrated security=True;TrustServerCertificate=True");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marka>().Property(m => m.Adi).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.Entity<Rol>().Property(m => m.Adi).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                Id = 1,
                Adi = "Admin",
            });
            modelBuilder.Entity<Kullanici>().HasData(new Kullanici
            {
                Id = 1,
                Adi = "Admin",
                AktifMi = true,
                EklenmeTarihi = DateTime.Now,
                Email = "admin@gmail.com",
                KullaniciAdi = "admin",
                Sifre = "12345",
                //Rol = new Rol { Id = 1 },
                RolId = 1,
                Soyadi = "admin",
                Telefon = "0553",
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
