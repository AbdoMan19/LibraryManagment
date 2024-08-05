using LibraryManagment.Models;
using Microsoft.EntityFrameworkCore;
namespace LibraryManagment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Book>Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrow> Borrows { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Borrow>().HasOne(b => b.Book).WithMany(bk => bk.Borrows).HasForeignKey(b => b.BookId);
            modelBuilder.Entity<Borrow>().HasOne(b => b.Member).WithMany(bk => bk.Borrows).HasForeignKey(b => b.MemberId);
            modelBuilder.Entity<Book>().HasOne(b => b.Author).WithMany(bk => bk.Books).HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<Book>().ToTable("book");
            modelBuilder.Entity<Borrow>().ToTable("borrow");
            modelBuilder.Entity<Member>().ToTable("member");
            modelBuilder.Entity<Author>().ToTable("author");
        }

    }
}
