using Microsoft.EntityFrameworkCore;
using WizLib_DataAccess.FluentConfig;
using WizLib_Model.Models;

namespace WizLib_DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<BookDetailsFromView> BookDetailsFromViews { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookDetail> BookDetails { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }

    public DbSet<Fluent_BookDetail> FluentBookDetails { get; set; }
    public DbSet<Fluent_Book> FluentBooks { get; set; }
    public DbSet<Fluent_Author> FluentAuthors { get; set; }
    public DbSet<Fluent_Publisher> FluentPublishers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //we configure fluent API

        //category table name and column name
        modelBuilder.Entity<Category>().ToTable("Category");
        modelBuilder.Entity<Category>().Property(c => c.Name).HasColumnName("CategoryName");
        //composite key
        modelBuilder.Entity<BookAuthor>().HasKey(ba => new {ba.Author_Id, ba.Book_Id});
        modelBuilder.ApplyConfiguration(new FluentBookConfig());
        modelBuilder.ApplyConfiguration(new FluentBookDetailsConfig());
        modelBuilder.ApplyConfiguration(new FluentBookAuthorConfig());
        modelBuilder.ApplyConfiguration(new FluentPublisherConfig());
        modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
        modelBuilder.Entity<BookDetailsFromView>().HasNoKey().ToView("GetOnlyBookDetails");
    }
}