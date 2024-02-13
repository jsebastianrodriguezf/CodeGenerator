using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegRegistroIntegracionConfiguration : IEntityTypeConfiguration<SegRegistroIntegracion>
{
    public void Configure(EntityTypeBuilder<SegRegistroIntegracion> builder)
    {
        builder.ToTable("seg_registroIntegracion");

        builder.HasIndex(e => e.Eid, "IX_seg_registroIntegracion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CodigoRespuesta)
            .HasMaxLength(20)
            .IsUnicode(false)
            .HasColumnName("codigoRespuesta");
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
        builder.Property(e => e.IdObjeto).HasColumnName("idObjeto");
        builder.Property(e => e.IdPuntoIntegracion).HasColumnName("id_puntoIntegracion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Mensaje)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("mensaje");
        builder.Property(e => e.NumeroReintento).HasColumnName("numeroReintento");
        builder.Property(e => e.RegistroIntegracion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("registroIntegracion");
        builder.Property(e => e.RegistroIntegracionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("registroIntegracion_codigo");
        builder.Property(e => e.Respuesta)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("respuesta");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdPuntoIntegracionNavigation).WithMany(p => p.SegRegistroIntegracions)
            .HasForeignKey(d => d.IdPuntoIntegracion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PuntoIntegracionRegistroIntegracion");
    }
}
