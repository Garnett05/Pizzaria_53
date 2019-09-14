using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria_53.Domain.Models;

namespace Pizzaria_53.Infra.Data.Entity.Mappings
{
    class StatusMap : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("STATUS");

            builder.Property(c => c.Id)
                .HasColumnName("stt_id");

            builder.Property(c => c.Descricao)
                .HasColumnName("stt_descricao")
                .HasColumnType("varchar(45)")
                .HasMaxLength(45)
                .IsRequired();

            builder.Property(c => c.DataInclusao)
                .HasColumnName("stt_datainclusao")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(c => c.DataAlteracao)
                .HasColumnName("stt_dataalteracao")
                .HasColumnType("datetime");
        }
    }
}
