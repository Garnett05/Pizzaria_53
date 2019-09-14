using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class FormaPagamentoMap : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.ToTable("FORMA_PAGAMENTO");

            builder.Property(c => c.Id)
                .HasColumnName("fp_id");

            builder.Property(c => c.Descricao)
                .HasColumnName("fp_descricao")
                .HasColumnType("varchar(45)")
                .HasMaxLength(45)
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .HasColumnName("fp_datainclusao")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.DataAlteracao)
                .HasColumnName("fp_dataalteracao")
                .HasColumnType("datetime");
        }

    }
}
