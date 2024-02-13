using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenNotificacionConfiguration : IEntityTypeConfiguration<GenNotificacion>
{
    public void Configure(EntityTypeBuilder<GenNotificacion> builder)
    {
        builder.ToTable("gen_notificacion");

        builder.HasIndex(e => e.Eid, "IX_gen_notificacion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Datos)
            .HasDefaultValue("")
            .HasColumnName("datos");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdTipoNotificacion).HasColumnName("id_tipoNotificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioDestino).HasColumnName("id_usuario_destino");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioOrigen).HasColumnName("id_usuario_origen");
        builder.Property(e => e.Notificacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("notificacion");
        builder.Property(e => e.NotificacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("notificacion_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdTipoNotificacionNavigation).WithMany(p => p.GenNotificacions)
            .HasForeignKey(d => d.IdTipoNotificacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_notificacion_id_tipoNotificacion");

        builder.HasOne(d => d.IdUsuarioDestinoNavigation).WithMany(p => p.GenNotificacionIdUsuarioDestinoNavigations)
            .HasForeignKey(d => d.IdUsuarioDestino)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_notificacion_id_usuario_destino");

        builder.HasOne(d => d.IdUsuarioOrigenNavigation).WithMany(p => p.GenNotificacionIdUsuarioOrigenNavigations)
            .HasForeignKey(d => d.IdUsuarioOrigen)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_notificacion_id_usuario_origen");
    }
}
