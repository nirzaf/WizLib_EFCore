using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizLib_Model.Models;

namespace WizLib_DataAccess.FluentConfig
{
    public class FluentPublisherConfig : IEntityTypeConfiguration<Fluent_Publisher>
    {
        public void Configure(EntityTypeBuilder<Fluent_Publisher> modelBuilder)
        {
            //Publisher
            modelBuilder.HasKey(b => b.Publisher_Id);
            modelBuilder.Property(b => b.Name).IsRequired();
            modelBuilder.Property(b => b.Location).IsRequired();

        }
    }
}
