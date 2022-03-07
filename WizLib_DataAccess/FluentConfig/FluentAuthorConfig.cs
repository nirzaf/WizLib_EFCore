using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WizLib_Model.Models;

namespace WizLib_DataAccess.FluentConfig;

public class FluentAuthorConfig : IEntityTypeConfiguration<Fluent_Author>
{
    public void Configure(EntityTypeBuilder<Fluent_Author> modelBuilder)
    {
        //Author
        modelBuilder.HasKey(b => b.Author_Id);
        modelBuilder.Property(b => b.FirstName).IsRequired();
        modelBuilder.Property(b => b.LastName).IsRequired();
        modelBuilder.Ignore(b => b.FullName);
    }
}