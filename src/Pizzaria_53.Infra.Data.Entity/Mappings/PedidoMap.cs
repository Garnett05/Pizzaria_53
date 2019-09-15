using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("PEDIDO");

            builder.Property(c => c.Id)
                .HasColumnName("pd_id");

            builder.Property(c => c.Quantidade)
                .HasColumnName("pd_quantidade")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(c => c.ValorTotal)
                .HasColumnName("pd_valortotal")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(c => c.Descricao)
                .HasColumnName("pd_descricao")
                .HasColumnType("varchar(200)")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .HasColumnName("pd_datainclusao")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.DataAlteracao)
                .HasColumnName("pd_dataalteracao")
                .HasColumnType("datetime");

            builder
                .HasOne(p => p.Cliente)
                .WithOne();

            builder
                .HasOne(p => p.Pizzaria)
                .WithOne();

            builder
                .HasMany(p => p.ListaFormaPagamento)
                .WithOne();

            builder
                .HasOne(p => p.Status)
                .WithOne();
        }
    }
}
