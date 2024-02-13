using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VAlquileresPreliquidarConfiguration : IEntityTypeConfiguration<VAlquileresPreliquidar>
{
    public void Configure(EntityTypeBuilder<VAlquileresPreliquidar> builder)
    {
        builder
            .HasNoKey()
            .ToView("v_alquileresPreliquidar");

        builder.Property(e => e.FechaAlq)
            .HasMaxLength(7)
            .IsUnicode(false)
            .HasColumnName("fechaALQ");
        builder.Property(e => e.IdAlquiler).HasColumnName("idAlquiler");
        builder.Property(e => e.UltimaFactura).HasColumnType("smalldatetime");
    }
}
