using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class AlqDetalleLiquidacionConfiguration : IEntityTypeConfiguration<AlqDetalleLiquidacion>
{
    public void Configure(EntityTypeBuilder<AlqDetalleLiquidacion> builder)
    {
        builder.ToTable("alq_detalleLiquidacion");

        builder.HasIndex(e => e.Eid, "IX_alq_detalleLiquidacion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
        builder.Property(e => e.DetalleLiquidacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleLiquidacion");
        builder.Property(e => e.DetalleLiquidacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleLiquidacion_codigo");
        builder.Property(e => e.Dias).HasColumnName("dias");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFin_fh");
        builder.Property(e => e.FechaInicioFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicio_fh");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Horometro)
            .HasDefaultValue(0.0)
            .HasColumnName("horometro");
        builder.Property(e => e.IdDetalleAlquiler).HasColumnName("id_detalleAlquiler");
        builder.Property(e => e.IdDocumentoMovimiento)
            .HasDefaultValue(0)
            .HasColumnName("id_documento_movimiento");
        builder.Property(e => e.IdEvento).HasColumnName("id_evento");
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
        builder.Property(e => e.IdTarifa)
            .HasDefaultValue(0)
            .HasColumnName("id_tarifa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Saldo).HasColumnName("saldo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDetalleAlquilerNavigation).WithMany(p => p.AlqDetalleLiquidacions)
            .HasForeignKey(d => d.IdDetalleAlquiler)
            .HasConstraintName("FK_alq_detalleLiquidacion_id_detalleAlquiler");

        builder.HasOne(d => d.IdEventoNavigation).WithMany(p => p.AlqDetalleLiquidacions)
            .HasForeignKey(d => d.IdEvento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__alq_detal__id_ev__50A92BCC");

        builder.HasOne(d => d.IdItemDocumentoNavigation).WithMany(p => p.AlqDetalleLiquidacions)
            .HasForeignKey(d => d.IdItemDocumento)
            .HasConstraintName("FK_alq_detalleLiquidacion_id_itemDocumento");

        builder.HasOne(d => d.IdTarifaNavigation).WithMany(p => p.AlqDetalleLiquidacions)
            .HasForeignKey(d => d.IdTarifa)
            .HasConstraintName("FK_alq_detalleLiquidacion_id_tarifa");
    }
}
