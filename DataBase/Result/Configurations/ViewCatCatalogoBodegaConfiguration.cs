using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatCatalogoBodegaConfiguration : IEntityTypeConfiguration<ViewCatCatalogoBodega>
{
    public void Configure(EntityTypeBuilder<ViewCatCatalogoBodega> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_catalogo_bodega");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoBloquearCostear).HasColumnName("cat_catalogo_bloquearCostear");
        builder.Property(e => e.CatCatalogoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_catalogo");
        builder.Property(e => e.CatCatalogoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_catalogo_codigo");
        builder.Property(e => e.CatCatalogoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_codigoInventario");
        builder.Property(e => e.CatCatalogoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_descripcion");
        builder.Property(e => e.CatCatalogoEsNacional).HasColumnName("cat_catalogo_esNacional");
        builder.Property(e => e.CatCatalogoIdFamilia).HasColumnName("cat_catalogo_id_familia");
        builder.Property(e => e.CatCatalogoIdImpuesto).HasColumnName("cat_catalogo_id_impuesto");
        builder.Property(e => e.CatCatalogoIdSubTipoCatalogo).HasColumnName("cat_catalogo_id_subTipoCatalogo");
        builder.Property(e => e.CatCatalogoIdUnidad).HasColumnName("cat_catalogo_id_unidad");
        builder.Property(e => e.CatCatalogoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_precioVenta");
        builder.Property(e => e.CatCatalogoTiempoConsecucion).HasColumnName("cat_catalogo_tiempoConsecucion");
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
        builder.Property(e => e.GenBodegaBodega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_bodega_bodega");
        builder.Property(e => e.GenBodegaBodegaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_bodega_bodega_codigo");
        builder.Property(e => e.GenBodegaSalidasEnRojo).HasColumnName("gen_bodega_salidasEnRojo");
        builder.Property(e => e.GenBodegaUsaLocalizacion).HasColumnName("gen_bodega_usaLocalizacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdBodega).HasColumnName("id_bodega");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Localizacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("localizacion");
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
