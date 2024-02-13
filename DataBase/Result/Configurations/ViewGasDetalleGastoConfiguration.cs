using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGasDetalleGastoConfiguration : IEntityTypeConfiguration<ViewGasDetalleGasto>
{
    public void Configure(EntityTypeBuilder<ViewGasDetalleGasto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gas_detalleGasto");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
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
        builder.Property(e => e.CatCatalogoIdSubtipoCatalogo).HasColumnName("cat_catalogo_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoIdUnidad).HasColumnName("cat_catalogo_id_unidad");
        builder.Property(e => e.CatCatalogoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_precioVenta");
        builder.Property(e => e.CatCatalogoTiempoConsecucion).HasColumnName("cat_catalogo_tiempoConsecucion");
        builder.Property(e => e.DetalleGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleGasto");
        builder.Property(e => e.DetalleGastoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleGasto_codigo");
        builder.Property(e => e.DocDocumentoGastoConcepto)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.gasto_concepto");
        builder.Property(e => e.DocDocumentoGastoConsignado).HasColumnName("doc_documento.gasto_consignado");
        builder.Property(e => e.DocDocumentoGastoCosto).HasColumnName("doc_documento_gasto_costo");
        builder.Property(e => e.DocDocumentoGastoCostoPlaneado).HasColumnName("doc_documento_gasto_costoPlaneado");
        builder.Property(e => e.DocDocumentoGastoDescuento).HasColumnName("doc_documento_gasto_descuento");
        builder.Property(e => e.DocDocumentoGastoDescuentoPlaneado).HasColumnName("doc_documento_gasto_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoGastoDias).HasColumnName("doc_documento.gasto_dias");
        builder.Property(e => e.DocDocumentoGastoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_documento_codigo");
        builder.Property(e => e.DocDocumentoGastoDocumentoGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.gasto_documento.gasto");
        builder.Property(e => e.DocDocumentoGastoDocumentoNumero).HasColumnName("doc_documento_gasto_documento_numero");
        builder.Property(e => e.DocDocumentoGastoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoGastoFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.gasto_fecha_ff");
        builder.Property(e => e.DocDocumentoGastoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fecha_fh");
        builder.Property(e => e.DocDocumentoGastoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoGastoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoGastoIdDocumento).HasColumnName("doc_documento_gasto_id_documento");
        builder.Property(e => e.DocDocumentoGastoIdEstadoTipoDocumento).HasColumnName("doc_documento_gasto_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoGastoIdMoneda).HasColumnName("doc_documento_gasto_id_moneda");
        builder.Property(e => e.DocDocumentoGastoIdMotivoestado).HasColumnName("doc_documento_gasto_id_motivoestado");
        builder.Property(e => e.DocDocumentoGastoIdPrioridadDocumento).HasColumnName("doc_documento_gasto_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoGastoIdSubtipoDocumento).HasColumnName("doc_documento_gasto_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoGastoIdTerceroCliente).HasColumnName("doc_documento_gasto_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoGastoIdTerceroProveedor).HasColumnName("doc_documento_gasto_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoGastoIdUsuarioAsignado).HasColumnName("doc_documento_gasto_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoGastoIdUsuarioEnUso).HasColumnName("doc_documento_gasto_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoGastoIva).HasColumnName("doc_documento_gasto_iva");
        builder.Property(e => e.DocDocumentoGastoIvaPlaneado).HasColumnName("doc_documento_gasto_ivaPlaneado");
        builder.Property(e => e.DocDocumentoGastoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_prefijo");
        builder.Property(e => e.DocDocumentoGastoRentabilidad).HasColumnName("doc_documento_gasto_rentabilidad");
        builder.Property(e => e.DocDocumentoGastoSubtotal).HasColumnName("doc_documento_gasto_subtotal");
        builder.Property(e => e.DocDocumentoGastoSubtotalPlaneado).HasColumnName("doc_documento_gasto_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoGastoTotal).HasColumnName("doc_documento_gasto_total");
        builder.Property(e => e.DocDocumentoGastoTotalPlaneado).HasColumnName("doc_documento_gasto_totalPlaneado");
        builder.Property(e => e.DocDocumentoGastoTrm).HasColumnName("doc_documento_gasto_trm");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GasGastoConcepto)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("gas_gasto_concepto");
        builder.Property(e => e.GasGastoConsignado).HasColumnName("gas_gasto_consignado");
        builder.Property(e => e.GasGastoDias).HasColumnName("gas_gasto_dias");
        builder.Property(e => e.GasGastoFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("gas_gasto_fecha_ff");
        builder.Property(e => e.GasGastoGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gas_gasto_gasto");
        builder.Property(e => e.GasGastoGastoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gas_gasto_gasto_codigo");
        builder.Property(e => e.GasGastoIdEstadoTipoDocumento).HasColumnName("gas_gasto_id_estadoTipoDocumento");
        builder.Property(e => e.GasGastoIdTipoGasto).HasColumnName("gas_gasto_id_tipoGasto");
        builder.Property(e => e.GasGastoIdUsuarioAprobo).HasColumnName("gas_gasto_id_usuario_aprobo");
        builder.Property(e => e.GasGastoIdUsuarioSolicitante).HasColumnName("gas_gasto_id_usuario_solicitante");
        builder.Property(e => e.GasGastoNumero).HasColumnName("gas_gasto_numero");
        builder.Property(e => e.GasGastoValor).HasColumnName("gas_gasto_valor");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdDocumentoGasto).HasColumnName("id_documento.gasto");
        builder.Property(e => e.IdGasto).HasColumnName("id_gasto");
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
        builder.Property(e => e.Valor).HasColumnName("valor");
    }
}
