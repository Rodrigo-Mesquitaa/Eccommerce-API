using Eccomerce_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eccomerce_API.ModelConfigs
{
    public class CustomerConfig : IEntityTypeConfiguration<CustomerModel>
    {
        public void Configure(EntityTypeBuilder<CustomerModel> builder)
        {
            builder.HasKey(b => b.Id).HasName("CustomerId");
            builder.Property(b => b.Name).HasMaxLength(500).IsRequired();
            builder.Property(b => b.Email).HasMaxLength(500);
            builder.Property(b => b.Password).HasMaxLength(500);
            builder.Property(b => b.Gender).HasMaxLength(500);
            builder.Property(b => b.is_married).HasMaxLength(500);
            builder.Property(b => b.Gender).HasMaxLength(500);
            builder.Property(b => b.Address).HasMaxLength(500);
        }
    }
}
