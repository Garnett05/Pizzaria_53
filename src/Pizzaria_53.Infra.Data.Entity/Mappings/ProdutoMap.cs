using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTO");

            builder.Property(c => c.Id)
                .HasColumnName("prod_id");

            builder.Property(c => c.Nome)
                .HasColumnName("prod_nome")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Descricao)
                .HasColumnName("prod_descricao")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Valor)
                .HasColumnName("prod_valor")
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .HasColumnName("prod_datainclusao")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.DataAlteracao)
                .HasColumnName("prod_dataalteracao")
                .HasColumnType("datetime");

            builder
                .HasOne(p => p.TamanhoProduto)
                .WithOne();

            builder
                .HasOne(p => p.TipoProduto)
                .WithOne();
        }
    }
}
