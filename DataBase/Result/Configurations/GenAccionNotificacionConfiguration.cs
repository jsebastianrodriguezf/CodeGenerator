using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenAccionNotificacionConfiguration : IEntityTypeConfiguration<GenAccionNotificacion>
{
    public void Configure(EntityTypeBuilder<GenAccionNotificacion> builder)
    {
        builder.ToTable("gen_accionNotificacion");

        builder.HasIndex(e => e.Eid, "IX_gen_accionNotificacion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.AccionNotificacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("accionNotificacion");
        builder.Property(e => e.AccionNotificacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("accionNotificacion_codigo");
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
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdPuntoIntegracion).HasColumnName("id_puntoIntegracion");
        builder.Property(e => e.IdTipoNotificacion).HasColumnName("id_tipoNotificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdPuntoIntegracionNavigation).WithMany(p => p.GenAccionNotificacions)
            .HasForeignKey(d => d.IdPuntoIntegracion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_accionNotificacion_id_puntoIntegracion");

        builder.HasOne(d => d.IdTipoNotificacionNavigation).WithMany(p => p.GenAccionNotificacions)
            .HasForeignKey(d => d.IdTipoNotificacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_accionNotificacion_id_tipoNotificacion");
    }
}
