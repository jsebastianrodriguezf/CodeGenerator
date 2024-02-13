using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatCatalogoRepuestoConfiguration : IEntityTypeConfiguration<CatCatalogoRepuesto>
{
    public void Configure(EntityTypeBuilder<CatCatalogoRepuesto> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_cat_catalogo_repuesto");

        builder.ToTable("cat_catalogo.repuesto");

        builder.HasIndex(e => e.Eid, "IX_cat_catalogo_repuesto");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CatalogoRepuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.repuesto");
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
        builder.Property(e => e.GarantiaDias).HasColumnName("garantiaDias");
        builder.Property(e => e.GarantiaHoras).HasColumnName("garantiaHoras");
        builder.Property(e => e.IdMarca).HasColumnName("id_marca");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Peso)
            .HasDefaultValue(0.0)
            .HasColumnName("peso");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Vigente)
            .HasDefaultValue(true)
            .HasColumnName("vigente");

        builder.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.CatCatalogoRepuestos)
            .HasForeignKey(d => d.IdMarca)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_repuesto_id_marca");
    }
}
