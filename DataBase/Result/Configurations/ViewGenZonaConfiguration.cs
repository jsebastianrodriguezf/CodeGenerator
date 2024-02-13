using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenZonaConfiguration : IEntityTypeConfiguration<ViewGenZona>
{
    public void Configure(EntityTypeBuilder<ViewGenZona> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_zona");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CodigoExterno)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("codigoExterno");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenZonaPadreCodigoExterno)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("gen_zona_padre_codigoExterno");
        builder.Property(e => e.GenZonaPadreIdZona).HasColumnName("gen_zona_padre_id_zona");
        builder.Property(e => e.GenZonaPadreNivel).HasColumnName("gen_zona_padre_nivel");
        builder.Property(e => e.GenZonaPadreTiempoDesplazamiento).HasColumnName("gen_zona_padre_tiempoDesplazamiento");
        builder.Property(e => e.GenZonaPadreZona)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_zona_padre_zona");
        builder.Property(e => e.GenZonaPadreZonaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_zona_padre_zona_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Nivel).HasColumnName("nivel");
        builder.Property(e => e.TiempoDesplazamiento).HasColumnName("tiempoDesplazamiento");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Zona)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("zona");
        builder.Property(e => e.ZonaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("zona_codigo");
    }
}
