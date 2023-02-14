

using Api.DotNet6.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace ApiDotNet6.Infra.Data.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(p => p.Id);

            builder.Property(x => x.Id)
                .HasColumnName("IdProduto")
                .UseIdentityColumn();

            builder.Property(x => x.CodErp)
                .HasColumnName("CodErp");

            builder.Property(x => x.Name)
                .HasColumnName("Nome");

            builder.Property(x => x.Price)
                .HasColumnName("Preco");

            builder.HasMany(x => x.Purchase)
                .WithOne(p => p.Product)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
