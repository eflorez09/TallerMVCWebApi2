using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entities;

namespace Data.Catalog.Config
{
    public class AddressConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(ci => ci.Name)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(ci => ci.Email)
                .IsRequired(true)
                .HasMaxLength(100);

            builder.Property(ci => ci.Phone)
                .IsRequired(false)
                .HasMaxLength(10);

            builder.Property(ci => ci.Message)
                .IsRequired(true)
                .HasMaxLength(500);

            builder.Property(ci => ci.RegistrationDate)
                .IsRequired(true)
                .HasColumnType("datetime");
        }
    }
}
