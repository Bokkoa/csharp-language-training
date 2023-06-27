using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ReadData
{
    public class AppSellingBooksContext : DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress; Initial Catalog=WebBooks; Integrated Security=True; TrustServerCertificate=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
          optionsBuilder.UseSqlServer(connectionString);
        }

        // adding the multiple primary key
        protected override void OnModelCreating(ModelBuilder modelBuilder){
          modelBuilder.Entity<BookAuthor>().HasKey(xi => new {xi.AuthorId, xi.BookId});
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Price> Price { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }
    }
}
