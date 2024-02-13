using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoCatalogoTemparioConfiguration : IEntityTypeConfiguration<ViewDocDocumentoCatalogoTempario>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoCatalogoTempario> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_catalogo_tempario");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoTemparioBloquearCostear).HasColumnName("cat_catalogo_tempario_bloquearCostear");
        builder.Property(e => e.CatCatalogoTemparioCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_catalogo_codigo");
        builder.Property(e => e.CatCatalogoTemparioCatalogoTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.tempario_catalogo.tempario");
        builder.Property(e => e.CatCatalogoTemparioCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_codigoInventario");
        builder.Property(e => e.CatCatalogoTemparioDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_descripcion");
        builder.Property(e => e.CatCatalogoTemparioDetieneEquipos).HasColumnName("cat_catalogo.tempario_detieneEquipos");
        builder.Property(e => e.CatCatalogoTemparioDuracionEstimada).HasColumnName("cat_catalogo.tempario_duracionEstimada");
        builder.Property(e => e.CatCatalogoTemparioEnTaller).HasColumnName("cat_catalogo.tempario_enTaller");
        builder.Property(e => e.CatCatalogoTemparioEsCiclico).HasColumnName("cat_catalogo.tempario_esCiclico");
        builder.Property(e => e.CatCatalogoTemparioEsNacional).HasColumnName("cat_catalogo_tempario_esNacional");
        builder.Property(e => e.CatCatalogoTemparioFacturaTodo).HasColumnName("cat_catalogo.tempario_facturaTodo");
        builder.Property(e => e.CatCatalogoTemparioHorasDetencion).HasColumnName("cat_catalogo.tempario_horasDetencion");
        builder.Property(e => e.CatCatalogoTemparioIdFamilia).HasColumnName("cat_catalogo_tempario_id_familia");
        builder.Property(e => e.CatCatalogoTemparioIdImpuesto).HasColumnName("cat_catalogo_tempario_id_impuesto");
        builder.Property(e => e.CatCatalogoTemparioIdSubtipoCatalogo).HasColumnName("cat_catalogo_tempario_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoTemparioIdTipoServicio).HasColumnName("cat_catalogo.tempario_id_tipoServicio");
        builder.Property(e => e.CatCatalogoTemparioIdUnidad).HasColumnName("cat_catalogo_tempario_id_unidad");
        builder.Property(e => e.CatCatalogoTemparioIncluirMenores).HasColumnName("cat_catalogo.tempario_incluirMenores");
        builder.Property(e => e.CatCatalogoTemparioModoAjuste).HasColumnName("cat_catalogo.tempario_modoAjuste");
        builder.Property(e => e.CatCatalogoTemparioPeriodoDias).HasColumnName("cat_catalogo.tempario_periodoDias");
        builder.Property(e => e.CatCatalogoTemparioPeriodoHoras).HasColumnName("cat_catalogo.tempario_periodoHoras");
        builder.Property(e => e.CatCatalogoTemparioPorcGarantia).HasColumnName("cat_catalogo.tempario_porcGarantia");
        builder.Property(e => e.CatCatalogoTemparioPorcTropicalizacion).HasColumnName("cat_catalogo.tempario_porcTropicalizacion");
        builder.Property(e => e.CatCatalogoTemparioPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_tempario_precioVenta");
        builder.Property(e => e.CatCatalogoTemparioProyectar).HasColumnName("cat_catalogo.tempario_proyectar");
        builder.Property(e => e.CatCatalogoTemparioTiempoConsecucion).HasColumnName("cat_catalogo_tempario_tiempoConsecucion");
        builder.Property(e => e.DocDocumentoCosto).HasColumnName("doc_documento_costo");
        builder.Property(e => e.DocDocumentoCostoPlaneado).HasColumnName("doc_documento_costoPlaneado");
        builder.Property(e => e.DocDocumentoDescuento).HasColumnName("doc_documento_descuento");
        builder.Property(e => e.DocDocumentoDescuentoPlaneado).HasColumnName("doc_documento_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_documento");
        builder.Property(e => e.DocDocumentoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_documento_codigo");
        builder.Property(e => e.DocDocumentoDocumentoNumero).HasColumnName("doc_documento_documento_numero");
        builder.Property(e => e.DocDocumentoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fecha_fh");
        builder.Property(e => e.DocDocumentoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoIdDocumento).HasColumnName("doc_documento_id_documento");
        builder.Property(e => e.DocDocumentoIdEstadoTipoDocumento).HasColumnName("doc_documento_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoIdMoneda).HasColumnName("doc_documento_id_moneda");
        builder.Property(e => e.DocDocumentoIdMotivoestado).HasColumnName("doc_documento_id_motivoestado");
        builder.Property(e => e.DocDocumentoIdPrioridadDocumento).HasColumnName("doc_documento_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoIdSubtipoDocumento).HasColumnName("doc_documento_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoIdTerceroCliente).HasColumnName("doc_documento_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoIdTerceroProveedor).HasColumnName("doc_documento_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoIdUsuarioAsignado).HasColumnName("doc_documento_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoIdUsuarioEnUso).HasColumnName("doc_documento_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoIva).HasColumnName("doc_documento_iva");
        builder.Property(e => e.DocDocumentoIvaPlaneado).HasColumnName("doc_documento_ivaPlaneado");
        builder.Property(e => e.DocDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_prefijo");
        builder.Property(e => e.DocDocumentoRentabilidad).HasColumnName("doc_documento_rentabilidad");
        builder.Property(e => e.DocDocumentoSubtotal).HasColumnName("doc_documento_subtotal");
        builder.Property(e => e.DocDocumentoSubtotalPlaneado).HasColumnName("doc_documento_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoTotal).HasColumnName("doc_documento_total");
        builder.Property(e => e.DocDocumentoTotalPlaneado).HasColumnName("doc_documento_totalPlaneado");
        builder.Property(e => e.DocDocumentoTrm).HasColumnName("doc_documento_trm");
        builder.Property(e => e.DocItemDocumentoAfectoInventario).HasColumnName("doc_itemDocumento_afectoInventario");
        builder.Property(e => e.DocItemDocumentoCantAuxiliar).HasColumnName("doc_itemDocumento_cantAuxiliar");
        builder.Property(e => e.DocItemDocumentoCantidadEjecutado).HasColumnName("doc_itemDocumento_cantidadEjecutado");
        builder.Property(e => e.DocItemDocumentoCantidadPlaneado).HasColumnName("doc_itemDocumento_cantidadPlaneado");
        builder.Property(e => e.DocItemDocumentoCostear).HasColumnName("doc_itemDocumento_costear");
        builder.Property(e => e.DocItemDocumentoCostoEjecutado).HasColumnName("doc_itemDocumento_costoEjecutado");
        builder.Property(e => e.DocItemDocumentoCostoPlaneado).HasColumnName("doc_itemDocumento_costoPlaneado");
        builder.Property(e => e.DocItemDocumentoDetalle)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_detalle");
        builder.Property(e => e.DocItemDocumentoDtoEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_dtoEjecutado");
        builder.Property(e => e.DocItemDocumentoDtoPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_dtoPlaneado");
        builder.Property(e => e.DocItemDocumentoEsUrgente).HasColumnName("doc_itemDocumento_esUrgente");
        builder.Property(e => e.DocItemDocumentoHorasFestivas).HasColumnName("doc_itemDocumento_horasFestivas");
        builder.Property(e => e.DocItemDocumentoHorasGarantia).HasColumnName("doc_itemDocumento_horasGarantia");
        builder.Property(e => e.DocItemDocumentoHorasNocturnas).HasColumnName("doc_itemDocumento_horasNocturnas");
        builder.Property(e => e.DocItemDocumentoHorasOrdinales).HasColumnName("doc_itemDocumento_horasOrdinales");
        builder.Property(e => e.DocItemDocumentoIdBodega).HasColumnName("doc_itemDocumento_id_bodega");
        builder.Property(e => e.DocItemDocumentoIdCatalogo).HasColumnName("doc_itemDocumento_id_catalogo");
        builder.Property(e => e.DocItemDocumentoIdCentroCosto).HasColumnName("doc_itemDocumento_id_centroCosto");
        builder.Property(e => e.DocItemDocumentoIdDocumento).HasColumnName("doc_itemDocumento_id_documento");
        builder.Property(e => e.DocItemDocumentoIdIncoterm).HasColumnName("doc_itemDocumento_id_incoterm");
        builder.Property(e => e.DocItemDocumentoIdItemDocumento).HasColumnName("doc_itemDocumento_id_itemDocumento");
        builder.Property(e => e.DocItemDocumentoIdItemDocumentoSuperior).HasColumnName("doc_itemDocumento_id_itemDocumento_superior");
        builder.Property(e => e.DocItemDocumentoIdListaprecio).HasColumnName("doc_itemDocumento_id_listaprecio");
        builder.Property(e => e.DocItemDocumentoItemDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_itemDocumento");
        builder.Property(e => e.DocItemDocumentoItemDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_itemDocumento_codigo");
        builder.Property(e => e.DocItemDocumentoIvaEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_ivaEjecutado");
        builder.Property(e => e.DocItemDocumentoIvaPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_ivaPlaneado");
        builder.Property(e => e.DocItemDocumentoPorcdescuento).HasColumnName("doc_itemDocumento_porcdescuento");
        builder.Property(e => e.DocItemDocumentoPorcdto).HasColumnName("doc_itemDocumento_porcdto");
        builder.Property(e => e.DocItemDocumentoPorcentajeCliente).HasColumnName("doc_itemDocumento_porcentajeCliente");
        builder.Property(e => e.DocItemDocumentoPorcentajeDistribuidor).HasColumnName("doc_itemDocumento_porcentajeDistribuidor");
        builder.Property(e => e.DocItemDocumentoPorcentajeFabricante).HasColumnName("doc_itemDocumento_porcentajeFabricante");
        builder.Property(e => e.DocItemDocumentoPorciva).HasColumnName("doc_itemDocumento_porciva");
        builder.Property(e => e.DocItemDocumentoSubtotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_subtotalEjecutado");
        builder.Property(e => e.DocItemDocumentoSubtotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_subtotalPlaneado");
        builder.Property(e => e.DocItemDocumentoTotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_totalEjecutado");
        builder.Property(e => e.DocItemDocumentoTotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_totalPlaneado");
        builder.Property(e => e.DocItemDocumentoValorUnitarioEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_valorUnitarioEjecutado");
        builder.Property(e => e.DocItemDocumentoValorUnitarioPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_valorUnitarioPlaneado");
        builder.Property(e => e.DocItemDocumentoVencimientoGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_itemDocumento_vencimientoGarantia_ff");
        builder.Property(e => e.DocItemDocumentoVrbase).HasColumnName("doc_itemDocumento_vrbase");
        builder.Property(e => e.DocItemDocumentoVrenlista).HasColumnName("doc_itemDocumento_vrenlista");
        builder.Property(e => e.DocumentoCatalogoTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento_catalogo.tempario");
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
        builder.Property(e => e.IdCatalogoTempario).HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
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
