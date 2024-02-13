using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatCatalogoListaPrecioConfiguration : IEntityTypeConfiguration<CatCatalogoListaPrecio>
{
    public void Configure(EntityTypeBuilder<CatCatalogoListaPrecio> builder)
    {
        builder.ToTable("cat_catalogo_listaPrecio");

        builder.HasIndex(e => e.Eid, "IX_cat_catalogo_listaPrecio");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CatalogoListaPrecio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo_listaPrecio");
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
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdListaPrecio).HasColumnName("id_listaPrecio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PorcDto).HasColumnName("porcDto");
        builder.Property(e => e.PrecioVenta).HasColumnType("money");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.CatCatalogoListaPrecios)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_listaPrecio_id_catalogo");

        builder.HasOne(d => d.IdListaPrecioNavigation).WithMany(p => p.CatCatalogoListaPrecios)
            .HasForeignKey(d => d.IdListaPrecio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_listaPrecio_id_listaPrecio");
    }
}
