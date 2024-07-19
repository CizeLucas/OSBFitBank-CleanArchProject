using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Data.EntityConfigurarion
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10, 2);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Caderno",
                    Description = "Caderno espiral 200 folhas",
                    Price = 27.80m,
                },
                new Product
                {
                    Id = 2,
                    Name = "Borracha",
                    Description = "Borracha branca média",
                    Price = 3.70m,
                },
                new Product
                {
                    Id = 3,
                    Name = "Estojo",
                    Description = "Estojo de plástico grande",
                    Price = 12.00m,
                },
                new Product
                {
                    Id = 4,
                    Name = "Lapiseira Grafite",
                    Description = "Lapiseira/Grafite 0.7mm",
                    Price = 9.99m,
                }
            );
        }
    }
}
