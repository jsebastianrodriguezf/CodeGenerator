using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegRegistroPeticionConfiguration : IEntityTypeConfiguration<SegRegistroPeticion>
{
    public void Configure(EntityTypeBuilder<SegRegistroPeticion> builder)
    {
        builder.ToTable("seg_registroPeticion");

        builder.HasIndex(e => e.Eid, "IX_seg_registroPeticion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Aplicacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("aplicacion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsExitosa).HasColumnName("esExitosa");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MensajeRespuesta)
            .IsUnicode(false)
            .HasColumnName("mensajeRespuesta");
        builder.Property(e => e.Modulo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("modulo");
        builder.Property(e => e.RegistroPeticion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("registroPeticion");
        builder.Property(e => e.RegistroPeticionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("registroPeticion_codigo");
        builder.Property(e => e.TamanoPeticion).HasColumnName("tamanoPeticion");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UrlServicio)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("urlServicio");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SegRegistroPeticions)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_registroPeticion_usuario_id_usuario");
    }
}
