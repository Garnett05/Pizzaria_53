using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class PizzariaMap : IEntityTypeConfiguration<Pizzaria>
    {
        public void Configure(EntityTypeBuilder<Pizzaria> builder)
        {
            builder.ToTable("PIZZARIA");

            builder.Property(c => c.Id)
                .HasColumnName("piz_id");

            builder.Property(c => c.Nome)
                .HasColumnName("piz_nome")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Telefone)
                .HasColumnName("piz_telefone")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(c => c.EMail)
                .HasColumnName("piz_email")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .HasColumnName("piz_datainclusao")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.DataAlteracao)
                .HasColumnName("piz_dataalteracao")
                .HasColumnType("datetime");

            builder
                .HasOne(p => p.Endereco)
                .WithOne();
        }
    }
}
