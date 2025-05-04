using AracKiralamaVeSatisOtomasyonu.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaVeSatisOtomasyonu.UI.Context
{
    public class MyDbContext:DbContext
    {
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Arac> Arac { get; set; }
        public DbSet<Kiralama> Kiralama { get; set; }
        public DbSet<Satis> Satis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer("Server=DESKTOP-RBVSQIL\\SQLEXPRESS;Database=AracKiralamaVeSatisOtomasyonuDB;Trusted_Connection=True;TrustServerCertificate=True");
            }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { Id = 1, KategoriAdi = "Sedan" },
                new Kategori { Id = 2, KategoriAdi = "SUV" },
                new Kategori { Id = 3, KategoriAdi = "Hatchback" },
                new Kategori { Id = 4, KategoriAdi = "Minivan" }
            );
        }
        }
    }
