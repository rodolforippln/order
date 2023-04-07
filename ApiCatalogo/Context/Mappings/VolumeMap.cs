using ApiCatalogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class VolumeMap : IEntityTypeConfiguration<Volume>
    {
        public void Configure(EntityTypeBuilder<Volume> builder)
        {
            //Tabela
            builder.ToTable("Volume");

            //Chave Primária
            //Volume
            builder
                .HasKey(c => c.VolumeId);

            builder
                .Property(c => c.Pieces)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            //Relacionamento com Categiria
            builder
                .HasOne(c => c.Order)
                .WithMany(p => p.Volumes);
        }
    }
}