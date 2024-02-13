using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatCatalogoConfiguration : IEntityTypeConfiguration<CatCatalogo>
{
    public void Configure(EntityTypeBuilder<CatCatalogo> builder)
    {
        builder.ToTable("cat_catalogo");

        builder.HasIndex(e => e.Eid, "IX_cat_catalogo");

        builder.HasIndex(e => e.CodigoInventario, "IX_cat_catalogo_codigoInventario");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.BloquearCostear).HasColumnName("bloquearCostear");
        builder.Property(e => e.Catalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo");
        builder.Property(e => e.CatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("catalogo_codigo");
        builder.Property(e => e.CodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("codigoInventario");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("descripcion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsNacional)
            .HasDefaultValue(true)
            .HasColumnName("esNacional");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdFamilia).HasColumnName("id_familia");
        builder.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
        builder.Property(e => e.IdSubtipoCatalogo).HasColumnName("id_subtipoCatalogo");
        builder.Property(e => e.IdUnidad).HasColumnName("id_unidad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PrecioVenta)
            .HasColumnType("money")
            .HasColumnName("precioVenta");
        builder.Property(e => e.TiempoConsecucion).HasColumnName("tiempoConsecucion");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdFamiliaNavigation).WithMany(p => p.CatCatalogos)
            .HasForeignKey(d => d.IdFamilia)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_id_familia");

        builder.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.CatCatalogos)
            .HasForeignKey(d => d.IdImpuesto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_id_impuesto");

        builder.HasOne(d => d.IdSubtipoCatalogoNavigation).WithMany(p => p.CatCatalogos)
            .HasForeignKey(d => d.IdSubtipoCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_id_subtipoCatalogo");

        builder.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.CatCatalogos)
            .HasForeignKey(d => d.IdUnidad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_id_unidad");
    }
}
