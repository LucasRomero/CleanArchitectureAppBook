using BookStoreCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreInfrastructure.Data.Config
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Property(x => x.Year)
                .IsRequired(true);

            builder.HasOne(b => b.Author)
                .WithMany(a => a.Books) // Especifica la colección en Author
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Cascade); // Opcional: configura el comportamiento de eliminación

        }
    }
}
