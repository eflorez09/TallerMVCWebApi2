using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entities;

namespace Data.Catalog
{

    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Contact>(ConfigureContact);
        }

        private void ConfigureContact(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");

            builder.Property(ci => ci.Id)
                .ForSqlServerUseSequenceHiLo("contact_hilo")
                .IsRequired();

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