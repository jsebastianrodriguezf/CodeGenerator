using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatCatalogoBodegaConfiguration : IEntityTypeConfiguration<CatCatalogoBodega>
{
    public void Configure(EntityTypeBuilder<CatCatalogoBodega> builder)
    {
        builder.ToTable("cat_catalogo_bodega");

        builder.HasIndex(e => e.Eid, "IX_cat_catalogo_bodega");

        builder.HasIndex(e => new { e.IdCatalogo, e.IdBodega }, "UK_cat_catalogo_bodega").IsUnique();

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CatalogoBodega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo_bodega");
        builder.Property(e => e.Costo)
            .HasColumnType("money")
            .HasColumnName("costo");
        builder.Property(e => e.Disponible).HasColumnName("disponible");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EnOrdenes)
            .HasDefaultValue(0.0)
            .HasColumnName("enOrdenes");
        builder.Property(e => e.Existencia).HasColumnName("existencia");
        builder.Property(e => e.ExistenciaMaxima)
            .HasDefaultValue(0.0)
            .HasColumnName("existenciaMaxima");
        builder.Property(e => e.ExistenciaMinima).HasColumnName("existenciaMinima");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdBodega).HasColumnName("id_bodega");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Localizacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("localizacion");
        builder.Property(e => e.Reservado).HasColumnName("reservado");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdBodegaNavigation).WithMany(p => p.CatCatalogoBodegas)
            .HasForeignKey(d => d.IdBodega)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_bodega_id_bodega");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.CatCatalogoBodegas)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_bodega_id_catalogo");
    }
}
