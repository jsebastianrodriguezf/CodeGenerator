using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatTarifaCatalogoConfiguration : IEntityTypeConfiguration<ViewCatTarifaCatalogo>
{
    public void Configure(EntityTypeBuilder<ViewCatTarifaCatalogo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_tarifaCatalogo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AlqTipoTarifaTipoTarifa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("alq_tipoTarifa_tipoTarifa");
        builder.Property(e => e.AlqTipoTarifaTipoTarifaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("alq_tipoTarifa_tipoTarifa_codigo");
        builder.Property(e => e.AlqTipoTarifaValor)
            .HasColumnType("decimal(10, 1)")
            .HasColumnName("alq_tipoTarifa_valor");
        builder.Property(e => e.CatCatalogoElementoBloquearCostear).HasColumnName("cat_catalogo_elemento_bloquearCostear");
        builder.Property(e => e.CatCatalogoElementoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_elemento_catalogo");
        builder.Property(e => e.CatCatalogoElementoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_elemento_catalogo_codigo");
        builder.Property(e => e.CatCatalogoElementoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_elemento_codigoInventario");
        builder.Property(e => e.CatCatalogoElementoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_elemento_descripcion");
        builder.Property(e => e.CatCatalogoElementoEsNacional).HasColumnName("cat_catalogo_elemento_esNacional");
        builder.Property(e => e.CatCatalogoElementoIdFamilia).HasColumnName("cat_catalogo_elemento_id_familia");
        builder.Property(e => e.CatCatalogoElementoIdImpuesto).HasColumnName("cat_catalogo_elemento_id_impuesto");
        builder.Property(e => e.CatCatalogoElementoIdSubTipoCatalogo).HasColumnName("cat_catalogo_elemento_id_subTipoCatalogo");
        builder.Property(e => e.CatCatalogoElementoIdUnidad).HasColumnName("cat_catalogo_elemento_id_unidad");
        builder.Property(e => e.CatCatalogoElementoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_elemento_precioVenta");
        builder.Property(e => e.CatCatalogoElementoTiempoConsecucion).HasColumnName("cat_catalogo_elemento_tiempoConsecucion");
        builder.Property(e => e.CatCatalogoTarifaBloquearCostear).HasColumnName("cat_catalogo_tarifa_bloquearCostear");
        builder.Property(e => e.CatCatalogoTarifaCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tarifa_catalogo");
        builder.Property(e => e.CatCatalogoTarifaCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tarifa_catalogo_codigo");
        builder.Property(e => e.CatCatalogoTarifaCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tarifa_codigoInventario");
        builder.Property(e => e.CatCatalogoTarifaDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tarifa_descripcion");
        builder.Property(e => e.CatCatalogoTarifaEsNacional).HasColumnName("cat_catalogo_tarifa_esNacional");
        builder.Property(e => e.CatCatalogoTarifaIdFamilia).HasColumnName("cat_catalogo_tarifa_id_familia");
        builder.Property(e => e.CatCatalogoTarifaIdImpuesto).HasColumnName("cat_catalogo_tarifa_id_impuesto");
        builder.Property(e => e.CatCatalogoTarifaIdSubTipoCatalogo).HasColumnName("cat_catalogo_tarifa_id_subTipoCatalogo");
        builder.Property(e => e.CatCatalogoTarifaIdUnidad).HasColumnName("cat_catalogo_tarifa_id_unidad");
        builder.Property(e => e.CatCatalogoTarifaPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_tarifa_precioVenta");
        builder.Property(e => e.CatCatalogoTarifaTiempoConsecucion).HasColumnName("cat_catalogo_tarifa_tiempoConsecucion");
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
        builder.Property(e => e.IdCatalogoElemento).HasColumnName("id_catalogo_elemento");
        builder.Property(e => e.IdCatalogoTarifa).HasColumnName("id_catalogo_tarifa");
        builder.Property(e => e.IdTipotarifa).HasColumnName("id_tipotarifa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.TarifaCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tarifaCatalogo");
        builder.Property(e => e.TarifaCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tarifaCatalogo_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
