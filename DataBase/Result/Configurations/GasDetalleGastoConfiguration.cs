using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GasDetalleGastoConfiguration : IEntityTypeConfiguration<GasDetalleGasto>
{
    public void Configure(EntityTypeBuilder<GasDetalleGasto> builder)
    {
        builder.ToTable("gas_detalleGasto");

        builder.HasIndex(e => e.Eid, "IX_gas_detalleGasto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
        builder.Property(e => e.DetalleGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleGasto");
        builder.Property(e => e.DetalleGastoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleGasto_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdDocumentoGasto).HasColumnName("id_documento.gasto");
        builder.Property(e => e.IdGasto).HasColumnName("id_gasto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor).HasColumnName("valor");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.GasDetalleGastos)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gas_detalleGasto_id_catalogo");

        builder.HasOne(d => d.IdGastoNavigation).WithMany(p => p.GasDetalleGastos)
            .HasForeignKey(d => d.IdGasto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gas_detalleGasto_id_gasto");
    }
}
