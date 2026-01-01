using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

public class LibraryDbContext : DbContext
{
	public LibraryDbContext(DbContextOptions options) : base(options) { }

	public DbSet<Book> Books { get; set; }
	public DbSet<Member> Members { get; set; }
	public DbSet<IssueRecord> IssueRecords { get; set; }
}
