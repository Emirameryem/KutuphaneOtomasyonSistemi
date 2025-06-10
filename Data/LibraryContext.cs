using Microsoft.EntityFrameworkCore;
using KütüphaneOtomasyon.Models;

namespace KütüphaneOtomasyon.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Gerekirse Fluent API ayarları
        }
    }
}


