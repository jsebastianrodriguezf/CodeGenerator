using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatCatalogoProductoConfiguration : IEntityTypeConfiguration<ViewCatCatalogoProducto>
{
    public void Configure(EntityTypeBuilder<ViewCatCatalogoProducto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_catalogo_producto");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoProductoBloquearCostear).HasColumnName("cat_catalogo_producto_bloquearCostear");
        builder.Property(e => e.CatCatalogoProductoCatSubtipoCatalogoIdTipoCatalogo).HasColumnName("cat_catalogo_producto_cat_subtipoCatalogo_id_tipoCatalogo");
        builder.Property(e => e.CatCatalogoProductoCatSubtipoCatalogoSubtipoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_cat_subtipoCatalogo_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoProductoCatSubtipoCatalogoSubtipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_cat_subtipoCatalogo_subtipoCatalogo_codigo");
        builder.Property(e => e.CatCatalogoProductoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_catalogo_codigo");
        builder.Property(e => e.CatCatalogoProductoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_codigoInventario");
        builder.Property(e => e.CatCatalogoProductoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_descripcion");
        builder.Property(e => e.CatCatalogoProductoEsNacional).HasColumnName("cat_catalogo_producto_esNacional");
        builder.Property(e => e.CatCatalogoProductoGenFamiliaFamilia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_gen_familia_familia");
        builder.Property(e => e.CatCatalogoProductoGenFamiliaFamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_gen_familia_familia_codigo");
        builder.Property(e => e.CatCatalogoProductoGenFamiliaIdFamilia).HasColumnName("cat_catalogo_producto_gen_familia_id_familia");
        builder.Property(e => e.CatCatalogoProductoGenImpuestoImpuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_gen_impuesto_impuesto");
        builder.Property(e => e.CatCatalogoProductoGenImpuestoImpuestoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_gen_impuesto_impuesto_codigo");
        builder.Property(e => e.CatCatalogoProductoGenImpuestoValor).HasColumnName("cat_catalogo_producto_gen_impuesto_valor");
        builder.Property(e => e.CatCatalogoProductoGenUnidadUnidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_gen_unidad_unidad");
        builder.Property(e => e.CatCatalogoProductoGenUnidadUnidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_producto_gen_unidad_unidad_codigo");
        builder.Property(e => e.CatCatalogoProductoIdFamilia).HasColumnName("cat_catalogo_producto_id_familia");
        builder.Property(e => e.CatCatalogoProductoIdImpuesto).HasColumnName("cat_catalogo_producto_id_impuesto");
        builder.Property(e => e.CatCatalogoProductoIdSubtipoCatalogo).HasColumnName("cat_catalogo_producto_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoProductoIdUnidad).HasColumnName("cat_catalogo_producto_id_unidad");
        builder.Property(e => e.CatCatalogoProductoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_producto_precioVenta");
        builder.Property(e => e.CatCatalogoProductoTiempoConsecucion).HasColumnName("cat_catalogo_producto_tiempoConsecucion");
        builder.Property(e => e.CatalogoProducto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.producto");
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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
