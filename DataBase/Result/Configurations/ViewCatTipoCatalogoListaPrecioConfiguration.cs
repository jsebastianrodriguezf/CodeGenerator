using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatTipoCatalogoListaPrecioConfiguration : IEntityTypeConfiguration<ViewCatTipoCatalogoListaPrecio>
{
    public void Configure(EntityTypeBuilder<ViewCatTipoCatalogoListaPrecio> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_tipoCatalogo_listaPrecio");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatListaPrecioEsPrivado).HasColumnName("cat_listaPrecio_esPrivado");
        builder.Property(e => e.CatListaPrecioIdMoneda).HasColumnName("cat_listaPrecio_id_moneda");
        builder.Property(e => e.CatListaPrecioListaPrecio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_listaPrecio_listaPrecio");
        builder.Property(e => e.CatListaPrecioListaPrecioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_listaPrecio_listaPrecio_codigo");
        builder.Property(e => e.CatListaPrecioPorcentajeDescuento).HasColumnName("cat_listaPrecio_porcentajeDescuento");
        builder.Property(e => e.CatTipoCatalogoAfectaInventario).HasColumnName("cat_tipoCatalogo_afectaInventario");
        builder.Property(e => e.CatTipoCatalogoAfectaProduccion).HasColumnName("cat_tipoCatalogo_afectaProduccion");
        builder.Property(e => e.CatTipoCatalogoTipoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_tipoCatalogo_tipoCatalogo");
        builder.Property(e => e.CatTipoCatalogoTipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_tipoCatalogo_tipoCatalogo_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdListaPrecio).HasColumnName("id_listaPrecio");
        builder.Property(e => e.IdTipoCatalogo).HasColumnName("id_tipoCatalogo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Porcentaje).HasColumnName("porcentaje");
        builder.Property(e => e.TipoCatalogoListaPrecio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tipoCatalogo_listaPrecio");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
