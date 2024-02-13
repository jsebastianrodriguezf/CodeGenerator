using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatListaPrecioConfiguration : IEntityTypeConfiguration<CatListaPrecio>
{
    public void Configure(EntityTypeBuilder<CatListaPrecio> builder)
    {
        builder.ToTable("cat_listaPrecio");

        builder.HasIndex(e => e.Eid, "IX_cat_listaPrecio");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsPrivado).HasColumnName("esPrivado");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdMoneda).HasColumnName("id_moneda");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ListaPrecio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("listaPrecio");
        builder.Property(e => e.ListaPrecioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("listaPrecio_codigo");
        builder.Property(e => e.ParaCompra).HasColumnName("paraCompra");
        builder.Property(e => e.PorcentajeDescuento).HasColumnName("porcentajeDescuento");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.CatListaPrecios)
            .HasForeignKey(d => d.IdMoneda)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_cat_listaPrecio_id_moneda");
    }
}
