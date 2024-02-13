using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntTiempoRespuestumConfiguration : IEntityTypeConfiguration<CntTiempoRespuestum>
{
    public void Configure(EntityTypeBuilder<CntTiempoRespuestum> builder)
    {
        builder.ToTable("cnt_tiempoRespuesta");

        builder.HasIndex(e => e.Eid, "IX_cnt_tiempoRespuesta");

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
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdEstrategiaPrioridad).HasColumnName("id_estrategiaPrioridad");
        builder.Property(e => e.IdPrioridadDocumento).HasColumnName("id_prioridadDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.TiempoLimite)
            .HasDefaultValue(24)
            .HasColumnName("tiempoLimite");
        builder.Property(e => e.TiempoRespuesta)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tiempoRespuesta");
        builder.Property(e => e.TiempoRespuestaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tiempoRespuesta_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdContratoNavigation).WithMany(p => p.CntTiempoRespuesta)
            .HasForeignKey(d => d.IdContrato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_tiempoRespuesta_id_contrato");

        builder.HasOne(d => d.IdEstrategiaPrioridadNavigation).WithMany(p => p.CntTiempoRespuesta)
            .HasForeignKey(d => d.IdEstrategiaPrioridad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_tiempoRespuesta_id_estrategiaPrioridad");

        builder.HasOne(d => d.IdPrioridadDocumentoNavigation).WithMany(p => p.CntTiempoRespuesta)
            .HasForeignKey(d => d.IdPrioridadDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_tiempoRespuesta_id_prioridadDocumento");
    }
}
