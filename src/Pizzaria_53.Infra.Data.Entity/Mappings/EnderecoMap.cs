using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("ENDERECO");

            builder.Property(c => c.Id)
                .HasColumnName("end_id");

            builder.Property(c => c.Logadouro)
                .HasColumnName("end_logadouro")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Numero)
                .HasColumnName("end_numero")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(c => c.Longitude)
                .HasColumnName("end_longitude")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(c => c.Latitude)
                .HasColumnName("end_latitude")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(c => c.Complemento)
                .HasColumnName("end_complemento")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(c => c.DataInclusao)
                .HasColumnName("end_datainclusao")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.DataAlteracao)
                .HasColumnName("end_dataalteracao")
                .HasColumnType("datetime")
        }
    }
}
