using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VCorreosAenviarConfiguration : IEntityTypeConfiguration<VCorreosAenviar>
{
    public void Configure(EntityTypeBuilder<VCorreosAenviar> builder)
    {
        builder
            .HasNoKey()
            .ToView("v_correosAEnviar");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.Os)
            .HasMaxLength(25)
            .IsUnicode(false)
            .HasColumnName("os");
        builder.Property(e => e.SerialEquipo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("serialEquipo");
    }
}
