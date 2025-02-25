using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.UserId).IsRequired();
            builder.Property(c => c.Date).IsRequired().HasColumnType("date");

            builder.OwnsMany(c => c.Products, product =>
            {
                product.WithOwner().HasForeignKey("CartId");
                product.Property<int>("Id");
                product.HasKey("Id");
                product.Property(p => p.ProductId).IsRequired();
                product.Property(p => p.Quantity).IsRequired();
            });
        }
    }
}