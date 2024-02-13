using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatReemplazoConfiguration : IEntityTypeConfiguration<ViewCatReemplazo>
{
    public void Configure(EntityTypeBuilder<ViewCatReemplazo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_reemplazo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoRepuesto1BloquearCostear).HasColumnName("cat_catalogo_repuesto_1_bloquearCostear");
        builder.Property(e => e.CatCatalogoRepuesto1CatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_1_catalogo_codigo");
        builder.Property(e => e.CatCatalogoRepuesto1CatalogoRepuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.repuesto_1_catalogo.repuesto");
        builder.Property(e => e.CatCatalogoRepuesto1CodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_1_codigoInventario");
        builder.Property(e => e.CatCatalogoRepuesto1Descripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_1_descripcion");
        builder.Property(e => e.CatCatalogoRepuesto1EsNacional).HasColumnName("cat_catalogo_repuesto_1_esNacional");
        builder.Property(e => e.CatCatalogoRepuesto1GarantiaDias).HasColumnName("cat_catalogo.repuesto_1_garantiaDias");
        builder.Property(e => e.CatCatalogoRepuesto1GarantiaHoras).HasColumnName("cat_catalogo.repuesto_1_garantiaHoras");
        builder.Property(e => e.CatCatalogoRepuesto1IdFamilia).HasColumnName("cat_catalogo_repuesto_1_id_familia");
        builder.Property(e => e.CatCatalogoRepuesto1IdImpuesto).HasColumnName("cat_catalogo_repuesto_1_id_impuesto");
        builder.Property(e => e.CatCatalogoRepuesto1IdMarca).HasColumnName("cat_catalogo.repuesto_1_id_marca");
        builder.Property(e => e.CatCatalogoRepuesto1IdSubtipoCatalogo).HasColumnName("cat_catalogo_repuesto_1_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoRepuesto1IdUnidad).HasColumnName("cat_catalogo_repuesto_1_id_unidad");
        builder.Property(e => e.CatCatalogoRepuesto1PrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_repuesto_1_precioVenta");
        builder.Property(e => e.CatCatalogoRepuesto1TiempoConsecucion).HasColumnName("cat_catalogo_repuesto_1_tiempoConsecucion");
        builder.Property(e => e.CatCatalogoRepuesto1Vigente).HasColumnName("cat_catalogo.repuesto_1_vigente");
        builder.Property(e => e.CatCatalogoRepuestoBloquearCostear).HasColumnName("cat_catalogo_repuesto_bloquearCostear");
        builder.Property(e => e.CatCatalogoRepuestoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_catalogo_codigo");
        builder.Property(e => e.CatCatalogoRepuestoCatalogoRepuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.repuesto_catalogo.repuesto");
        builder.Property(e => e.CatCatalogoRepuestoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_codigoInventario");
        builder.Property(e => e.CatCatalogoRepuestoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_descripcion");
        builder.Property(e => e.CatCatalogoRepuestoEsNacional).HasColumnName("cat_catalogo_repuesto_esNacional");
        builder.Property(e => e.CatCatalogoRepuestoGarantiaDias).HasColumnName("cat_catalogo.repuesto_garantiaDias");
        builder.Property(e => e.CatCatalogoRepuestoGarantiaHoras).HasColumnName("cat_catalogo.repuesto_garantiaHoras");
        builder.Property(e => e.CatCatalogoRepuestoIdFamilia).HasColumnName("cat_catalogo_repuesto_id_familia");
        builder.Property(e => e.CatCatalogoRepuestoIdImpuesto).HasColumnName("cat_catalogo_repuesto_id_impuesto");
        builder.Property(e => e.CatCatalogoRepuestoIdMarca).HasColumnName("cat_catalogo.repuesto_id_marca");
        builder.Property(e => e.CatCatalogoRepuestoIdSubtipoCatalogo).HasColumnName("cat_catalogo_repuesto_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoRepuestoIdUnidad).HasColumnName("cat_catalogo_repuesto_id_unidad");
        builder.Property(e => e.CatCatalogoRepuestoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_repuesto_precioVenta");
        builder.Property(e => e.CatCatalogoRepuestoTiempoConsecucion).HasColumnName("cat_catalogo_repuesto_tiempoConsecucion");
        builder.Property(e => e.CatCatalogoRepuestoVigente).HasColumnName("cat_catalogo.repuesto_vigente");
        builder.Property(e => e.CatTipoReemplazoTipoReemplazo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_tipoReemplazo_tipoReemplazo");
        builder.Property(e => e.CatTipoReemplazoTipoReemplazoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_tipoReemplazo_tipoReemplazo_codigo");
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
        builder.Property(e => e.IdCatalogoRepuesto).HasColumnName("id_catalogo.repuesto");
        builder.Property(e => e.IdCatalogoRepuesto1).HasColumnName("id_catalogo.repuesto_1");
        builder.Property(e => e.IdTipoReemplazo).HasColumnName("id_tipoReemplazo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Reemplazo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("reemplazo");
        builder.Property(e => e.ReemplazoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("reemplazo_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
