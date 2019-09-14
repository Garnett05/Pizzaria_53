using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class TipoProdutoMap : IEntityTypeConfiguration<TipoProduto>
    {
        public void Configure(EntityTypeBuilder<TipoProduto> builder)
        {
            builder.ToTable("TIPO_PRODUTO");

            builder.Property(c => c.Id)
                .HasColumnName("tipo_id");

            builder.Property(c => c.Descricao)
                .HasColumnName("tipo_descricao")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .HasColumnName("tipo_datainclusao")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.DataAlteracao)
                .HasColumnName("tipo_dataalteracao")
                .HasColumnType("datetime");
        }
    }
}
