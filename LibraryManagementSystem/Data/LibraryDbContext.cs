
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Models; // change to your namespace

public class LibraryDbContext : DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<IssueRecord> IssueRecords { get; set; }
}
