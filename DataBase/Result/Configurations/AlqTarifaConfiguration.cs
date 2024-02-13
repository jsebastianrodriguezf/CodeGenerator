using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class AlqTarifaConfiguration : IEntityTypeConfiguration<AlqTarifa>
{
    public void Configure(EntityTypeBuilder<AlqTarifa> builder)
    {
        builder.ToTable("alq_tarifa");

        builder.HasIndex(e => e.Eid, "IX_alq_tarifa");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CantidadIncluida).HasColumnName("cantidadIncluida");
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
        builder.Property(e => e.HorasIncluidas).HasColumnName("horasIncluidas");
        builder.Property(e => e.IdDetalleAlquiler).HasColumnName("id_detalleAlquiler");
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
        builder.Property(e => e.IdTipoTarifa).HasColumnName("id_tipoTarifa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Tarifa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tarifa");
        builder.Property(e => e.TarifaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tarifa_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDetalleAlquilerNavigation).WithMany(p => p.AlqTarifas)
            .HasForeignKey(d => d.IdDetalleAlquiler)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_alq_tarifa_id_detalleAlquiler");

        builder.HasOne(d => d.IdItemDocumentoNavigation).WithMany(p => p.AlqTarifas)
            .HasForeignKey(d => d.IdItemDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_alq_tarifa_id_itemDocumento");

        builder.HasOne(d => d.IdTipoTarifaNavigation).WithMany(p => p.AlqTarifas)
            .HasForeignKey(d => d.IdTipoTarifa)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_alq_tarifa_id_tipoTarifa");
    }
}
