using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatTipoCatalogoListaPrecioConfiguration : IEntityTypeConfiguration<CatTipoCatalogoListaPrecio>
{
    public void Configure(EntityTypeBuilder<CatTipoCatalogoListaPrecio> builder)
    {
        builder.ToTable("cat_tipoCatalogo_listaPrecio");

        builder.HasIndex(e => e.Eid, "IX_cat_tipoCatalogo_listaPrecio");

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
        builder.Property(e => e.IdListaPrecio).HasColumnName("id_listaPrecio");
        builder.Property(e => e.IdTipoCatalogo).HasColumnName("id_tipoCatalogo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Porcentaje).HasColumnName("porcentaje");
        builder.Property(e => e.TipoCatalogoListaPrecio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tipoCatalogo_listaPrecio");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdListaPrecioNavigation).WithMany(p => p.CatTipoCatalogoListaPrecios)
            .HasForeignKey(d => d.IdListaPrecio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_tipoCatalogo_listaPrecio_id_listaPrecio");

        builder.HasOne(d => d.IdTipoCatalogoNavigation).WithMany(p => p.CatTipoCatalogoListaPrecios)
            .HasForeignKey(d => d.IdTipoCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_tipoCatalogo_listaPrecio_id_tipoCatalogo");
    }
}
