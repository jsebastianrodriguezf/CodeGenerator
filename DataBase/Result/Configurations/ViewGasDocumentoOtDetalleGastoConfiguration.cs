using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGasDocumentoOtDetalleGastoConfiguration : IEntityTypeConfiguration<ViewGasDocumentoOtDetalleGasto>
{
    public void Configure(EntityTypeBuilder<ViewGasDocumentoOtDetalleGasto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gas_documento_ot_detalleGasto");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocDocumentoOtCargo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_cargo");
        builder.Property(e => e.DocDocumentoOtCompromisos)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_compromisos");
        builder.Property(e => e.DocDocumentoOtContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_contacto");
        builder.Property(e => e.DocDocumentoOtCosto).HasColumnName("doc_documento_ot_costo");
        builder.Property(e => e.DocDocumentoOtCostoPlaneado).HasColumnName("doc_documento_ot_costoPlaneado");
        builder.Property(e => e.DocDocumentoOtDescuento).HasColumnName("doc_documento_ot_descuento");
        builder.Property(e => e.DocDocumentoOtDescuentoPlaneado).HasColumnName("doc_documento_ot_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoOtDiagnosticoInicial)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_diagnosticoInicial");
        builder.Property(e => e.DocDocumentoOtDireccionUbicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_direccionUbicacion");
        builder.Property(e => e.DocDocumentoOtDistribuyeCentros).HasColumnName("doc_documento.ot_distribuyeCentros");
        builder.Property(e => e.DocDocumentoOtDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_documento_codigo");
        builder.Property(e => e.DocDocumentoOtDocumentoNumero).HasColumnName("doc_documento_ot_documento_numero");
        builder.Property(e => e.DocDocumentoOtDocumentoOt)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_documento.ot");
        builder.Property(e => e.DocDocumentoOtDuracionEstimada).HasColumnName("doc_documento.ot_duracionEstimada");
        builder.Property(e => e.DocDocumentoOtEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_email");
        builder.Property(e => e.DocDocumentoOtEnTaller).HasColumnName("doc_documento.ot_enTaller");
        builder.Property(e => e.DocDocumentoOtFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_fax");
        builder.Property(e => e.DocDocumentoOtFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoOtFechaCompromisoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.ot_fechaCompromiso_fh");
        builder.Property(e => e.DocDocumentoOtFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fecha_fh");
        builder.Property(e => e.DocDocumentoOtFechaGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.ot_fechaGarantia_ff");
        builder.Property(e => e.DocDocumentoOtFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoOtFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoOtIdContrato).HasColumnName("doc_documento.ot_id_contrato");
        builder.Property(e => e.DocDocumentoOtIdDepartamentoSolicitud).HasColumnName("doc_documento.ot_id_departamentoSolicitud");
        builder.Property(e => e.DocDocumentoOtIdDocumento).HasColumnName("doc_documento_ot_id_documento");
        builder.Property(e => e.DocDocumentoOtIdEquipo).HasColumnName("doc_documento.ot_id_equipo");
        builder.Property(e => e.DocDocumentoOtIdEstadoTipoDocumento).HasColumnName("doc_documento_ot_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOtIdMoneda).HasColumnName("doc_documento_ot_id_moneda");
        builder.Property(e => e.DocDocumentoOtIdMotivoCancelacion).HasColumnName("doc_documento.ot_id_motivoCancelacion");
        builder.Property(e => e.DocDocumentoOtIdMotivoestado).HasColumnName("doc_documento_ot_id_motivoestado");
        builder.Property(e => e.DocDocumentoOtIdPrioridadDocumento).HasColumnName("doc_documento_ot_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoOtIdSistema).HasColumnName("doc_documento.ot_id_sistema");
        builder.Property(e => e.DocDocumentoOtIdSubtipoDocumento).HasColumnName("doc_documento_ot_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoOtIdSucursal).HasColumnName("doc_documento.ot_id_sucursal");
        builder.Property(e => e.DocDocumentoOtIdTerceroCliente).HasColumnName("doc_documento_ot_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoOtIdTerceroProveedor).HasColumnName("doc_documento_ot_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoOtIdTipoServicio).HasColumnName("doc_documento.ot_id_tipoServicio");
        builder.Property(e => e.DocDocumentoOtIdUsuarioCoordinador).HasColumnName("doc_documento.ot_id_usuario_coordinador");
        builder.Property(e => e.DocDocumentoOtIdZona).HasColumnName("doc_documento.ot_id_zona");
        builder.Property(e => e.DocDocumentoOtIva).HasColumnName("doc_documento_ot_iva");
        builder.Property(e => e.DocDocumentoOtIvaPlaneado).HasColumnName("doc_documento_ot_ivaPlaneado");
        builder.Property(e => e.DocDocumentoOtMotivoServicio)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_motivoServicio");
        builder.Property(e => e.DocDocumentoOtPorcentajeCliente).HasColumnName("doc_documento.ot_porcentajeCliente");
        builder.Property(e => e.DocDocumentoOtPorcentajeDistribuidor).HasColumnName("doc_documento.ot_porcentajeDistribuidor");
        builder.Property(e => e.DocDocumentoOtPorcentajeFabricante).HasColumnName("doc_documento.ot_porcentajeFabricante");
        builder.Property(e => e.DocDocumentoOtPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_prefijo");
        builder.Property(e => e.DocDocumentoOtReclamacionFabrica)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_reclamacionFabrica");
        builder.Property(e => e.DocDocumentoOtRecomendaciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_recomendaciones");
        builder.Property(e => e.DocDocumentoOtRentabilidad).HasColumnName("doc_documento_ot_rentabilidad");
        builder.Property(e => e.DocDocumentoOtSegunTempario).HasColumnName("doc_documento.ot_segunTempario");
        builder.Property(e => e.DocDocumentoOtSubtotal).HasColumnName("doc_documento_ot_subtotal");
        builder.Property(e => e.DocDocumentoOtSubtotalPlaneado).HasColumnName("doc_documento_ot_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoOtTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_telefono");
        builder.Property(e => e.DocDocumentoOtTotal).HasColumnName("doc_documento_ot_total");
        builder.Property(e => e.DocDocumentoOtTotalPlaneado).HasColumnName("doc_documento_ot_totalPlaneado");
        builder.Property(e => e.DocDocumentoOtTrabajos)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_trabajos");
        builder.Property(e => e.DocDocumentoOtTrm).HasColumnName("doc_documento_ot_trm");
        builder.Property(e => e.DocItemDocumentoAfectoInventario).HasColumnName("doc_itemDocumento_afectoInventario");
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
        builder.Property(e => e.DocumentoOtDetalleGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.ot_detalleGasto");
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
        builder.Property(e => e.GasDetalleGastoCantidad).HasColumnName("gas_detalleGasto_cantidad");
        builder.Property(e => e.GasDetalleGastoDetalleGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gas_detalleGasto_detalleGasto");
        builder.Property(e => e.GasDetalleGastoDetalleGastoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gas_detalleGasto_detalleGasto_codigo");
        builder.Property(e => e.GasDetalleGastoFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("gas_detalleGasto_fecha_ff");
        builder.Property(e => e.GasDetalleGastoIdCatalogo).HasColumnName("gas_detalleGasto_id_catalogo");
        builder.Property(e => e.GasDetalleGastoIdGasto).HasColumnName("gas_detalleGasto_id_gasto");
        builder.Property(e => e.GasDetalleGastoValor).HasColumnName("gas_detalleGasto_valor");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdDetalleGasto).HasColumnName("id_detalleGasto");
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
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
