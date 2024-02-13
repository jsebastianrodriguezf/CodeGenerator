using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatDetalleRepuestoConfiguration : IEntityTypeConfiguration<CatDetalleRepuesto>
{
    public void Configure(EntityTypeBuilder<CatDetalleRepuesto> builder)
    {
        builder.ToTable("cat_detalleRepuesto");

        builder.HasIndex(e => e.Eid, "IX_cat_detalleRepuesto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cantidad)
            .HasDefaultValue(1.0)
            .HasColumnName("cantidad");
        builder.Property(e => e.DetalleRepuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleRepuesto");
        builder.Property(e => e.DetalleRepuestoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleRepuesto_codigo");
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
        builder.Property(e => e.IdCatalogoRepuesto).HasColumnName("id_catalogo.repuesto");
        builder.Property(e => e.IdCatalogoRepuestoHijo).HasColumnName("id_catalogo.repuesto_hijo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoRepuestoNavigation).WithMany(p => p.CatDetalleRepuestoIdCatalogoRepuestoNavigations)
            .HasForeignKey(d => d.IdCatalogoRepuesto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_detalleRepuesto_id_catalogo_repuesto");

        builder.HasOne(d => d.IdCatalogoRepuestoHijoNavigation).WithMany(p => p.CatDetalleRepuestoIdCatalogoRepuestoHijoNavigations)
            .HasForeignKey(d => d.IdCatalogoRepuestoHijo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_detalleRepuesto_id_catalogo_repuesto_hijo");
    }
}
