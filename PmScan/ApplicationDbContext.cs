using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmScan
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BarcodeScan> BarcodeScans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=NBDenKi.db"); // Sử dụng SQLite
                                                                     // Hoặc dùng SQL Server:
                                                                     // optionsBuilder.UseSqlServer("Server=your_server;Database=your_db;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BarcodeScan>()
                .HasOne(b => b.Account)
                .WithMany(a => a.BarcodeScans)
                .HasForeignKey(b => b.AccountId);

            modelBuilder.Entity<BarcodeScan>()
                .HasOne(b => b.Product)
                .WithMany(p => p.BarcodeScans)
                .HasForeignKey(b => b.ProductId);
        }
    }
}
