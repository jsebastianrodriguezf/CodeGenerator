using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenEnvioCorreoConfiguration : IEntityTypeConfiguration<GenEnvioCorreo>
{
    public void Configure(EntityTypeBuilder<GenEnvioCorreo> builder)
    {
        builder.ToTable("gen_envioCorreo");

        builder.HasIndex(e => e.Eid, "IX_gen_envioCorreo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AdjuntarArchivo).HasColumnName("adjuntarArchivo");
        builder.Property(e => e.CantidadMensajes).HasColumnName("cantidadMensajes");
        builder.Property(e => e.CantidadReintento).HasColumnName("cantidadReintento");
        builder.Property(e => e.CorreoAdicional)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("correoAdicional");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EnvioCorreo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("envioCorreo");
        builder.Property(e => e.EnvioCorreoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("envioCorreo_codigo");
        builder.Property(e => e.Estrategia)
            .HasDefaultValue(1)
            .HasColumnName("estrategia");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdRemitenteCorreo).HasColumnName("id_remitenteCorreo");
        builder.Property(e => e.IdReporte).HasColumnName("id_reporte");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PlantillaAdjunto)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("plantillaAdjunto");
        builder.Property(e => e.Tabla)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("tabla");
        builder.Property(e => e.TiempoPorMensajes).HasColumnName("tiempo_por_mensajes");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEstadoTipoDocumentoNavigation).WithMany(p => p.GenEnvioCorreos)
            .HasForeignKey(d => d.IdEstadoTipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_envioCorreo_id_estadoTipoDocumento");

        builder.HasOne(d => d.IdRemitenteCorreoNavigation).WithMany(p => p.GenEnvioCorreos)
            .HasForeignKey(d => d.IdRemitenteCorreo)
            .HasConstraintName("FK__gen_envio__id_re__3D42E84B");

        builder.HasOne(d => d.IdReporteNavigation).WithMany(p => p.GenEnvioCorreos)
            .HasForeignKey(d => d.IdReporte)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_envioCorreo_id_reporte");

        builder.HasOne(d => d.IdSubtipoDocumentoNavigation).WithMany(p => p.GenEnvioCorreos)
            .HasForeignKey(d => d.IdSubtipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_envioCorreo_id_subtipoDocumento");
    }
}
