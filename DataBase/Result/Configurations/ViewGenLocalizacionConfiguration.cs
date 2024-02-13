using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenLocalizacionConfiguration : IEntityTypeConfiguration<ViewGenLocalizacion>
{
    public void Configure(EntityTypeBuilder<ViewGenLocalizacion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_localizacion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoBodegaBloquearCostear).HasColumnName("cat_catalogo_bodega_bloquearCostear");
        builder.Property(e => e.CatCatalogoBodegaCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_bodega_catalogo");
        builder.Property(e => e.CatCatalogoBodegaCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_bodega_catalogo_codigo");
        builder.Property(e => e.CatCatalogoBodegaCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_bodega_codigoInventario");
        builder.Property(e => e.CatCatalogoBodegaDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_bodega_descripcion");
        builder.Property(e => e.CatCatalogoBodegaEsNacional).HasColumnName("cat_catalogo_bodega_esNacional");
        builder.Property(e => e.CatCatalogoBodegaIdFamilia).HasColumnName("cat_catalogo_bodega_id_familia");
        builder.Property(e => e.CatCatalogoBodegaIdImpuesto).HasColumnName("cat_catalogo_bodega_id_impuesto");
        builder.Property(e => e.CatCatalogoBodegaIdSubTipoCatalogo).HasColumnName("cat_catalogo_bodega_id_subTipoCatalogo");
        builder.Property(e => e.CatCatalogoBodegaIdUnidad).HasColumnName("cat_catalogo_bodega_id_unidad");
        builder.Property(e => e.CatCatalogoBodegaPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_bodega_precioVenta");
        builder.Property(e => e.CatCatalogoBodegaTiempoConsecucion).HasColumnName("cat_catalogo_bodega_tiempoConsecucion");
        builder.Property(e => e.Costo)
            .HasColumnType("money")
            .HasColumnName("costo");
        builder.Property(e => e.Disponible).HasColumnName("disponible");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EnOrdenes).HasColumnName("enOrdenes");
        builder.Property(e => e.Existencia).HasColumnName("existencia");
        builder.Property(e => e.ExistenciaMaxima).HasColumnName("existenciaMaxima");
        builder.Property(e => e.ExistenciaMinima).HasColumnName("existenciaMinima");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdBodega).HasColumnName("id_bodega");
        builder.Property(e => e.IdCatalogoBodega).HasColumnName("id_catalogo_bodega");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Localizacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("localizacion");
        builder.Property(e => e.LocalizacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("localizacion_codigo");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Reservado).HasColumnName("reservado");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
