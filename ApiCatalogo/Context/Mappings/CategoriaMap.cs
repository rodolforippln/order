using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            //Tabela
            builder.ToTable("Order");

            //Chave Primária
            //order
            builder
                .HasKey(c => c.OrderId);

            builder
                .Property(c => c.Nome)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(c => c.Descricao)
                .HasMaxLength(150);

            //// Índices
            //builder
            //    .HasIndex(x => x.Nome, "IX_Order_Name")
            //    .IsUnique();

            //Relacionamento com Company
            builder
                .HasOne(x => x.Company)
                .WithMany(x => x.Orders);
        }
    }
}