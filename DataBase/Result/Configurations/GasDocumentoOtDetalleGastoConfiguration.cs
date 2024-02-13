using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GasDocumentoOtDetalleGastoConfiguration : IEntityTypeConfiguration<GasDocumentoOtDetalleGasto>
{
    public void Configure(EntityTypeBuilder<GasDocumentoOtDetalleGasto> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_gas_documento_ot_detalleGasto");

        builder.ToTable("gas_documento.ot_detalleGasto");

        builder.HasIndex(e => e.Eid, "IX_gas_documento_ot_detalleGasto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoOtDetalleGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.ot_detalleGasto");
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
        builder.Property(e => e.IdDetalleGasto).HasColumnName("id_detalleGasto");
        builder.Property(e => e.IdDocumentoGasto).HasColumnName("id_documento.gasto");
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDetalleGastoNavigation).WithMany(p => p.GasDocumentoOtDetalleGastos)
            .HasForeignKey(d => d.IdDetalleGasto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gas_documento_ot_detalleGasto_id_detalleGasto");

        builder.HasOne(d => d.IdDocumentoOtNavigation).WithMany(p => p.GasDocumentoOtDetalleGastos)
            .HasForeignKey(d => d.IdDocumentoOt)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gas_documento_ot_detalleGasto_id_documento_ot");

        builder.HasOne(d => d.IdItemDocumentoNavigation).WithMany(p => p.GasDocumentoOtDetalleGastos)
            .HasForeignKey(d => d.IdItemDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gas_documento_ot_detalleGasto_id_itemDocumento");
    }
}
