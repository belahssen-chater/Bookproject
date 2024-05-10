using Microsoft.EntityFrameworkCore;

namespace Bookproj.Models
{
	public class OnlineLibraryDbContext : DbContext
	{
		public OnlineLibraryDbContext()
		{
			
		}

		public OnlineLibraryDbContext(DbContextOptions<OnlineLibraryDbContext> options)
			: base(options)
		{
		}

		public DbSet<Book> Books { get; set; }

		public DbSet<Borrowing> Borrowings { get; set; }

		public DbSet<Comment> Comments { get; set; }

		public DbSet<Genre> Genres { get; set; }

		public DbSet<User> Users { get; set; }

		public DbSet<Author> Authors { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			
			modelBuilder.Entity<Book>().ToTable("Books");
			modelBuilder.Entity<User>().ToTable("Users");
			modelBuilder.Entity<Author>().ToTable("Authors");
			modelBuilder.Entity<Comment>().ToTable("Comments");
			modelBuilder.Entity<Borrowing>().ToTable("Borrowings");
            modelBuilder.Entity<Genre>().ToTable("Genres");



        }

    }

}
