using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GeoUbicacionConfiguration : IEntityTypeConfiguration<GeoUbicacion>
{
    public void Configure(EntityTypeBuilder<GeoUbicacion> builder)
    {
        builder.ToTable("geo_ubicacion");

        builder.HasIndex(e => e.Eid, "IX_geo_ubicacion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_fh");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdObjeto)
            .HasDefaultValue(0)
            .HasColumnName("idObjeto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Latitud)
            .HasDefaultValue(0.0)
            .HasColumnName("latitud");
        builder.Property(e => e.Longitud)
            .HasDefaultValue(0.0)
            .HasColumnName("longitud");
        builder.Property(e => e.Tabla)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("tabla");
        builder.Property(e => e.Ubicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ubicacion");
        builder.Property(e => e.UbicacionCodigo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ubicacion_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
