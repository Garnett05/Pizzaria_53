using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("CLIENTE");

            builder.Property(c => c.Id)
                .HasColumnName("cli_Id");

            builder.Property(c => c.Nome)
                .HasColumnName("cli_nome")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.EMail)
                .HasColumnName("cli_email")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Telefone)
                .HasColumnName("cli_telefone")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .HasColumnName("cli_datainclusao")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.DataAlteracao)
                .HasColumnName("cli_dataalteracao")
                .HasColumnType("datetime");

            builder
               .HasOne(p => p.EnderecoId)
               .WithMany()
               .HasForeignKey(f => f.EnderecoId);
        }
    }
}
