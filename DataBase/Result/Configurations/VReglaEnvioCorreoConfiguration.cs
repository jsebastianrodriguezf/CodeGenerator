using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VReglaEnvioCorreoConfiguration : IEntityTypeConfiguration<VReglaEnvioCorreo>
{
    public void Configure(EntityTypeBuilder<VReglaEnvioCorreo> builder)
    {
        builder
            .HasNoKey()
            .ToView("v_reglaEnvioCorreo");

        builder.Property(e => e.CorreoAdicional)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("correoAdicional");
        builder.Property(e => e.EnvioCorreo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("envioCorreo");
        builder.Property(e => e.EnvioCorreoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("envioCorreo_codigo");
        builder.Property(e => e.Estrategia).HasColumnName("estrategia");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");
        builder.Property(e => e.IdReporte).HasColumnName("id_reporte");
        builder.Property(e => e.PlantillaAdjunto)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("plantillaAdjunto");
        builder.Property(e => e.Tabla)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("tabla");
    }
}
