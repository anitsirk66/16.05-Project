using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BookshopContext:DbContext
    {
        public BookshopContext() : base() { }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Worker>  Workers { get; set; }
        public DbSet<Genre>  Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Book_Order> Books_Orders { get; set; }
        public DbSet<Book_Genre> Books_Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=OLIVIABENSON\\SQLEXPRESS01;Initial Catalog=BookshopDB;Integrated Security=True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
