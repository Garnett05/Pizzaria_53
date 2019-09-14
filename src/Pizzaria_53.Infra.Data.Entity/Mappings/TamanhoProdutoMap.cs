using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class TamanhoProdutoMap : IEntityTypeConfiguration<TamanhoProduto>
    {
        public void Configure(EntityTypeBuilder<TamanhoProduto> builder)
        {
            builder.ToTable("TAMANHO_PRODUTO");

            builder.Property(c => c.Id)
                .HasColumnName("tam_id");

            builder.Property(c => c.Descricao)
                .HasColumnName("tam_descricao")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .HasColumnName("tam_datainclusao")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.DataAlteracao)
                .HasColumnName("tam_dataalteracao")
                .HasColumnType("datetime");
        }
    }
}
