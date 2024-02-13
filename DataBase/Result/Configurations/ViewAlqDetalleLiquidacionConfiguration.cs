using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewAlqDetalleLiquidacionConfiguration : IEntityTypeConfiguration<ViewAlqDetalleLiquidacion>
{
    public void Configure(EntityTypeBuilder<ViewAlqDetalleLiquidacion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_alq_detalleLiquidacion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
        builder.Property(e => e.DetalleLiquidacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleLiquidacion");
        builder.Property(e => e.DetalleLiquidacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleLiquidacion_codigo");
        builder.Property(e => e.Dias).HasColumnName("dias");
        builder.Property(e => e.DisEventoAfectaCliente).HasColumnName("dis_evento_afectaCliente");
        builder.Property(e => e.DisEventoAfectaProduccion).HasColumnName("dis_evento_afectaProduccion");
        builder.Property(e => e.DisEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_evento_codigo");
        builder.Property(e => e.DisEventoDuracionHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_duracion_hh");
        builder.Property(e => e.DisEventoEvento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("dis_evento_evento");
        builder.Property(e => e.DisEventoEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_evento_evento_codigo");
        builder.Property(e => e.DisEventoEventoTipo).HasColumnName("dis_evento_eventoTipo");
        builder.Property(e => e.DisEventoFechaHoraEstimadaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_fechaHoraEstimada_fh");
        builder.Property(e => e.DisEventoFechaHoraInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_fechaHoraInicio_ff");
        builder.Property(e => e.DisEventoIdEquipo).HasColumnName("dis_evento_id_equipo");
        builder.Property(e => e.DisEventoIdEstadoEquipo).HasColumnName("dis_evento_id_estadoEquipo");
        builder.Property(e => e.DisEventoIdEstadoEvento).HasColumnName("dis_evento_id_estadoEvento");
        builder.Property(e => e.DisEventoIdFalla).HasColumnName("dis_evento_id_falla");
        builder.Property(e => e.DisEventoIdFallaCausa).HasColumnName("dis_evento_id_falla_causa");
        builder.Property(e => e.DisEventoIdMetodoDeteccion).HasColumnName("dis_evento_id_metodoDeteccion");
        builder.Property(e => e.DisEventoIdMotivoEvento).HasColumnName("dis_evento_id_motivoEvento");
        builder.Property(e => e.DisEventoIdUsuario).HasColumnName("dis_evento_id_usuario");
        builder.Property(e => e.DisEventoNotas)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("dis_evento_notas");
        builder.Property(e => e.DocDocumentoMovimientoCosto).HasColumnName("doc_documento_movimiento_costo");
        builder.Property(e => e.DocDocumentoMovimientoCostoPlaneado).HasColumnName("doc_documento_movimiento_costoPlaneado");
        builder.Property(e => e.DocDocumentoMovimientoDescuento).HasColumnName("doc_documento_movimiento_descuento");
        builder.Property(e => e.DocDocumentoMovimientoDescuentoPlaneado).HasColumnName("doc_documento_movimiento_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoMovimientoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_movimiento_documento");
        builder.Property(e => e.DocDocumentoMovimientoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_movimiento_documento_codigo");
        builder.Property(e => e.DocDocumentoMovimientoDocumentoNumero).HasColumnName("doc_documento_movimiento_documento_numero");
        builder.Property(e => e.DocDocumentoMovimientoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_movimiento_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoMovimientoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_movimiento_fecha_fh");
        builder.Property(e => e.DocDocumentoMovimientoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_movimiento_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoMovimientoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_movimiento_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoMovimientoIdDocumento).HasColumnName("doc_documento_movimiento_id_documento");
        builder.Property(e => e.DocDocumentoMovimientoIdEstadoTipoDocumento).HasColumnName("doc_documento_movimiento_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoMovimientoIdMoneda).HasColumnName("doc_documento_movimiento_id_moneda");
        builder.Property(e => e.DocDocumentoMovimientoIdMotivoestado).HasColumnName("doc_documento_movimiento_id_motivoestado");
        builder.Property(e => e.DocDocumentoMovimientoIdPrioridadDocumento).HasColumnName("doc_documento_movimiento_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoMovimientoIdSubtipoDocumento).HasColumnName("doc_documento_movimiento_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoMovimientoIdTerceroCliente).HasColumnName("doc_documento_movimiento_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoMovimientoIdTerceroProveedor).HasColumnName("doc_documento_movimiento_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoMovimientoIva).HasColumnName("doc_documento_movimiento_iva");
        builder.Property(e => e.DocDocumentoMovimientoIvaPlaneado).HasColumnName("doc_documento_movimiento_ivaPlaneado");
        builder.Property(e => e.DocDocumentoMovimientoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_movimiento_prefijo");
        builder.Property(e => e.DocDocumentoMovimientoRentabilidad).HasColumnName("doc_documento_movimiento_rentabilidad");
        builder.Property(e => e.DocDocumentoMovimientoSubtotal).HasColumnName("doc_documento_movimiento_subtotal");
        builder.Property(e => e.DocDocumentoMovimientoSubtotalPlaneado).HasColumnName("doc_documento_movimiento_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoMovimientoTotal).HasColumnName("doc_documento_movimiento_total");
        builder.Property(e => e.DocDocumentoMovimientoTotalPlaneado).HasColumnName("doc_documento_movimiento_totalPlaneado");
        builder.Property(e => e.DocDocumentoMovimientoTrm).HasColumnName("doc_documento_movimiento_trm");
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
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquDetalleAlquilerBloquearDespacho).HasColumnName("equ_detalleAlquiler_bloquearDespacho");
        builder.Property(e => e.EquDetalleAlquilerCantidadAlquilada).HasColumnName("equ_detalleAlquiler_cantidadAlquilada");
        builder.Property(e => e.EquDetalleAlquilerCantidadSolicitada).HasColumnName("equ_detalleAlquiler_cantidadSolicitada");
        builder.Property(e => e.EquDetalleAlquilerDetalleAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_detalleAlquiler_detalleAlquiler");
        builder.Property(e => e.EquDetalleAlquilerDetalleAlquilerCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_detalleAlquiler_detalleAlquiler_codigo");
        builder.Property(e => e.EquDetalleAlquilerEsSerializado).HasColumnName("equ_detalleAlquiler_esSerializado");
        builder.Property(e => e.EquDetalleAlquilerEstadoalquiler).HasColumnName("equ_detalleAlquiler_estadoalquiler");
        builder.Property(e => e.EquDetalleAlquilerFechaDespachoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_detalleAlquiler_fechaDespacho_ff");
        builder.Property(e => e.EquDetalleAlquilerFechaDevolucionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_detalleAlquiler_fechaDevolucion_ff");
        builder.Property(e => e.EquDetalleAlquilerFechaInicioFacturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_detalleAlquiler_fechaInicioFactura_fh");
        builder.Property(e => e.EquDetalleAlquilerFechaUltimaFacturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_detalleAlquiler_fechaUltimaFactura_fh");
        builder.Property(e => e.EquDetalleAlquilerIdCatalogo).HasColumnName("equ_detalleAlquiler_id_catalogo");
        builder.Property(e => e.EquDetalleAlquilerIdDocumentoAlquiler).HasColumnName("equ_detalleAlquiler_id_documento.alquiler");
        builder.Property(e => e.EquDetalleAlquilerIdEquipo).HasColumnName("equ_detalleAlquiler_id_equipo");
        builder.Property(e => e.EquDetalleAlquilerIdSucursal).HasColumnName("equ_detalleAlquiler_id_sucursal");
        builder.Property(e => e.EquDetalleAlquilerIdTercero).HasColumnName("equ_detalleAlquiler_id_tercero");
        builder.Property(e => e.EquDetalleAlquilerValorHora)
            .HasColumnType("money")
            .HasColumnName("equ_detalleAlquiler_valorHora");
        builder.Property(e => e.EquDetalleAlquilerValorHoraStandBy)
            .HasColumnType("money")
            .HasColumnName("equ_detalleAlquiler_ValorHoraStandBy");
        builder.Property(e => e.EquDetalleAlquilerValorMes).HasColumnName("equ_detalleAlquiler_valorMes");
        builder.Property(e => e.EquDetalleAlquilerValorMulta)
            .HasColumnType("money")
            .HasColumnName("equ_detalleAlquiler_valorMulta");
        builder.Property(e => e.EquDetalleAlquilerValorPeriodo)
            .HasColumnType("money")
            .HasColumnName("equ_detalleAlquiler_valorPeriodo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFin_fh");
        builder.Property(e => e.FechaInicioFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicio_fh");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Horometro).HasColumnName("horometro");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdDetalleAlquiler).HasColumnName("id_detalleAlquiler");
        builder.Property(e => e.IdDocumentoMovimiento).HasColumnName("id_documento_movimiento");
        builder.Property(e => e.IdEvento).HasColumnName("id_evento");
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
        builder.Property(e => e.IdTarifa).HasColumnName("id_tarifa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Saldo).HasColumnName("saldo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
