using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCntVisitaFijaConfiguration : IEntityTypeConfiguration<ViewCntVisitaFija>
{
    public void Configure(EntityTypeBuilder<ViewCntVisitaFija> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cnt_visitaFija");

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
        builder.Property(e => e.CntConfigContratoAproximarA).HasColumnName("cnt_configContrato_aproximarA");
        builder.Property(e => e.CntConfigContratoCadaN).HasColumnName("cnt_configContrato_cadaN");
        builder.Property(e => e.CntConfigContratoConfigContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_configContrato_configContrato");
        builder.Property(e => e.CntConfigContratoDia).HasColumnName("cnt_configContrato_dia");
        builder.Property(e => e.CntConfigContratoDiaHabil).HasColumnName("cnt_configContrato_diaHabil");
        builder.Property(e => e.CntConfigContratoEstrategia).HasColumnName("cnt_configContrato_estrategia");
        builder.Property(e => e.CntConfigContratoFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_configContrato_fecha_ff");
        builder.Property(e => e.CntConfigContratoFrecuencia).HasColumnName("cnt_configContrato_frecuencia");
        builder.Property(e => e.CntConfigContratoIdCatalogoTempario).HasColumnName("cnt_configContrato_id_catalogo.tempario");
        builder.Property(e => e.CntConfigContratoIdContratoEquipo).HasColumnName("cnt_configContrato_id_contratoEquipo");
        builder.Property(e => e.CntConfigContratoIdTerceroProveedor).HasColumnName("cnt_configContrato_id_tercero_proveedor");
        builder.Property(e => e.CntConfigContratoIncluirMenores).HasColumnName("cnt_configContrato_incluirMenores");
        builder.Property(e => e.CntConfigContratoPorTrabajo).HasColumnName("cnt_configContrato_porTrabajo");
        builder.Property(e => e.CntContratoContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_contrato");
        builder.Property(e => e.CntContratoDetalleVisitaAproximarA).HasColumnName("cnt_contratoDetalleVisita_aproximarA");
        builder.Property(e => e.CntContratoDetalleVisitaCadaN).HasColumnName("cnt_contratoDetalleVisita_cadaN");
        builder.Property(e => e.CntContratoDetalleVisitaContratoDetalleVisita)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_contratoDetalleVisita_contratoDetalleVisita");
        builder.Property(e => e.CntContratoDetalleVisitaContratoDetalleVisitaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cnt_contratoDetalleVisita_contratoDetalleVisita_codigo");
        builder.Property(e => e.CntContratoDetalleVisitaDia).HasColumnName("cnt_contratoDetalleVisita_dia");
        builder.Property(e => e.CntContratoDetalleVisitaDiaHabil).HasColumnName("cnt_contratoDetalleVisita_diaHabil");
        builder.Property(e => e.CntContratoDetalleVisitaEstrategia).HasColumnName("cnt_contratoDetalleVisita_estrategia");
        builder.Property(e => e.CntContratoDetalleVisitaFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_contratoDetalleVisita_fecha_ff");
        builder.Property(e => e.CntContratoDetalleVisitaFrecuencia).HasColumnName("cnt_contratoDetalleVisita_frecuencia");
        builder.Property(e => e.CntContratoDetalleVisitaIdContrato).HasColumnName("cnt_contratoDetalleVisita_id_contrato");
        builder.Property(e => e.CntContratoDetalleVisitaIncluirMenores).HasColumnName("cnt_contratoDetalleVisita_incluirMenores");
        builder.Property(e => e.CntContratoDetalleVisitaPorTrabajo).HasColumnName("cnt_contratoDetalleVisita_porTrabajo");
        builder.Property(e => e.CntContratoEquipoContratoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_contratoEquipo_contratoEquipo");
        builder.Property(e => e.CntContratoEquipoContratoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cnt_contratoEquipo_contratoEquipo_codigo");
        builder.Property(e => e.CntContratoEquipoFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_contratoEquipo_fecha_ff");
        builder.Property(e => e.CntContratoEquipoIdContrato).HasColumnName("cnt_contratoEquipo_id_contrato");
        builder.Property(e => e.CntContratoEquipoIdContratoDetalleVisita).HasColumnName("cnt_contratoEquipo_id_contratoDetalleVisita");
        builder.Property(e => e.CntContratoEquipoIdEquipo).HasColumnName("cnt_contratoEquipo_id_equipo");
        builder.Property(e => e.CntContratoEquipoPrecioServicio)
            .HasColumnType("money")
            .HasColumnName("cnt_contratoEquipo_precioServicio");
        builder.Property(e => e.CntContratoEquipoPrecioVisita)
            .HasColumnType("money")
            .HasColumnName("cnt_contratoEquipo_precioVisita");
        builder.Property(e => e.CntContratoEquipoPromedio).HasColumnName("cnt_contratoEquipo_promedio");
        builder.Property(e => e.CntContratoIdTercero).HasColumnName("cnt_contrato_id_tercero");
        builder.Property(e => e.CntTipocontratoId).HasColumnName("cnt_tipocontrato_id");
        builder.Property(e => e.CorreoRecordatorio)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("correoRecordatorio");
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
        builder.Property(e => e.DocDocumentoOtIdUsuarioAsignado).HasColumnName("doc_documento_ot_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoOtIdUsuarioCoordinador).HasColumnName("doc_documento.ot_id_usuario_coordinador");
        builder.Property(e => e.DocDocumentoOtIdUsuarioEnUso).HasColumnName("doc_documento_ot_id_usuario_enUso");
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
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquEquipoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo");
        builder.Property(e => e.EquEquipoEquipoSerial)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo_serial");
        builder.Property(e => e.EquEquipoId).HasColumnName("equ_equipo_id");
        builder.Property(e => e.EsPorTrabajo).HasColumnName("esPorTrabajo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaCreadaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreada_ff");
        builder.Property(e => e.FechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Fechavencimiento)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechavencimiento");
        builder.Property(e => e.GenZonaId).HasColumnName("gen_zona_id");
        builder.Property(e => e.Horometro).HasColumnName("horometro");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCatalogoTempario).HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdConfigContrato).HasColumnName("id_configContrato");
        builder.Property(e => e.IdContratoDetalleVisita).HasColumnName("id_contratoDetalleVisita");
        builder.Property(e => e.IdContratoEquipo).HasColumnName("id_contratoEquipo");
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Presupuesto).HasColumnName("presupuesto");
        builder.Property(e => e.TerSucursalDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_direccion");
        builder.Property(e => e.TerSucursalSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal");
        builder.Property(e => e.Tipocontrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tipocontrato");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.VisitaFija)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("visitaFija");
        builder.Property(e => e.VisitaFijaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("visitaFija_codigo");
    }
}
