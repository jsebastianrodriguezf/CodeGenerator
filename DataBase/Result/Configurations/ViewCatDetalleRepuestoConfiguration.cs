using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatDetalleRepuestoConfiguration : IEntityTypeConfiguration<ViewCatDetalleRepuesto>
{
    public void Configure(EntityTypeBuilder<ViewCatDetalleRepuesto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_detalleRepuesto");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
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
        builder.Property(e => e.CatCatalogoRepuestoHijoBloquearCostear).HasColumnName("cat_catalogo_repuesto_hijo_bloquearCostear");
        builder.Property(e => e.CatCatalogoRepuestoHijoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_hijo_catalogo_codigo");
        builder.Property(e => e.CatCatalogoRepuestoHijoCatalogoRepuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.repuesto_hijo_catalogo.repuesto");
        builder.Property(e => e.CatCatalogoRepuestoHijoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_hijo_codigoInventario");
        builder.Property(e => e.CatCatalogoRepuestoHijoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_hijo_descripcion");
        builder.Property(e => e.CatCatalogoRepuestoHijoEsNacional).HasColumnName("cat_catalogo_repuesto_hijo_esNacional");
        builder.Property(e => e.CatCatalogoRepuestoHijoGarantiaDias).HasColumnName("cat_catalogo.repuesto_hijo_garantiaDias");
        builder.Property(e => e.CatCatalogoRepuestoHijoGarantiaHoras).HasColumnName("cat_catalogo.repuesto_hijo_garantiaHoras");
        builder.Property(e => e.CatCatalogoRepuestoHijoIdFamilia).HasColumnName("cat_catalogo_repuesto_hijo_id_familia");
        builder.Property(e => e.CatCatalogoRepuestoHijoIdImpuesto).HasColumnName("cat_catalogo_repuesto_hijo_id_impuesto");
        builder.Property(e => e.CatCatalogoRepuestoHijoIdMarca).HasColumnName("cat_catalogo.repuesto_hijo_id_marca");
        builder.Property(e => e.CatCatalogoRepuestoHijoIdSubtipoCatalogo).HasColumnName("cat_catalogo_repuesto_hijo_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoRepuestoHijoIdUnidad).HasColumnName("cat_catalogo_repuesto_hijo_id_unidad");
        builder.Property(e => e.CatCatalogoRepuestoHijoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_repuesto_hijo_precioVenta");
        builder.Property(e => e.CatCatalogoRepuestoHijoTiempoConsecucion).HasColumnName("cat_catalogo_repuesto_hijo_tiempoConsecucion");
        builder.Property(e => e.CatCatalogoRepuestoHijoVigente).HasColumnName("cat_catalogo.repuesto_hijo_vigente");
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
        builder.Property(e => e.DetalleRepuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleRepuesto");
        builder.Property(e => e.DetalleRepuestoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleRepuesto_codigo");
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
        builder.Property(e => e.IdCatalogoRepuestoHijo).HasColumnName("id_catalogo.repuesto_hijo");
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
