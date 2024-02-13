using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquEquipoAtributoConfiguration : IEntityTypeConfiguration<ViewEquEquipoAtributo>
{
    public void Configure(EntityTypeBuilder<ViewEquEquipoAtributo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_equipoAtributo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatAtributoAtributo)
            .HasMaxLength(900)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_atributo");
        builder.Property(e => e.CatAtributoAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_atributo_codigo");
        builder.Property(e => e.CatAtributoEsObligatorio).HasColumnName("cat_atributo_esObligatorio");
        builder.Property(e => e.CatAtributoEsVariable).HasColumnName("cat_atributo_esVariable");
        builder.Property(e => e.CatAtributoIdSeccionAtributo).HasColumnName("cat_atributo_id_seccionAtributo");
        builder.Property(e => e.CatAtributoIdTipoAtributo).HasColumnName("cat_atributo_id_tipoAtributo");
        builder.Property(e => e.CatAtributoIdUnidad).HasColumnName("cat_atributo_id_unidad");
        builder.Property(e => e.CatAtributoNombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_nombreControl");
        builder.Property(e => e.CatAtributoResaltado).HasColumnName("cat_atributo_resaltado");
        builder.Property(e => e.CatAtributoValorMaximo).HasColumnName("cat_atributo_ValorMaximo");
        builder.Property(e => e.CatAtributoValorMinimo).HasColumnName("cat_atributo_valorMinimo");
        builder.Property(e => e.CatPruebaCheckListActivo).HasColumnName("cat_pruebaCheckList_activo");
        builder.Property(e => e.CatPruebaCheckListPruebaCheckList)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_pruebaCheckList_pruebaCheckList");
        builder.Property(e => e.CatPruebaCheckListPruebaCheckListCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_pruebaCheckList_pruebaCheckList_codigo");
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
        builder.Property(e => e.EquEquipoCosto)
            .HasColumnType("money")
            .HasColumnName("equ_equipo_costo");
        builder.Property(e => e.EquEquipoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo");
        builder.Property(e => e.EquEquipoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo_codigo");
        builder.Property(e => e.EquEquipoEquipoSerial)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo_serial");
        builder.Property(e => e.EquEquipoFechaImportacionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_fechaImportacion_ff");
        builder.Property(e => e.EquEquipoFechaPuestaMarchaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_fechaPuestaMarcha_fh");
        builder.Property(e => e.EquEquipoGarantiaCancelada)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_garantiaCancelada");
        builder.Property(e => e.EquEquipoHorasGarantia).HasColumnName("equ_equipo_horasGarantia");
        builder.Property(e => e.EquEquipoHorometroActual).HasColumnName("equ_equipo_horometroActual");
        builder.Property(e => e.EquEquipoIdCatalogoEquipo).HasColumnName("equ_equipo_id_catalogo.equipo");
        builder.Property(e => e.EquEquipoIdCentroCosto).HasColumnName("equ_equipo_id_centroCosto");
        builder.Property(e => e.EquEquipoIdEquipo).HasColumnName("equ_equipo_id_equipo");
        builder.Property(e => e.EquEquipoIdEstadoEquipo).HasColumnName("equ_equipo_id_estadoEquipo");
        builder.Property(e => e.EquEquipoIdSistema).HasColumnName("equ_equipo_id_sistema");
        builder.Property(e => e.EquEquipoIdSucursal).HasColumnName("equ_equipo_id_sucursal");
        builder.Property(e => e.EquEquipoIdTercero).HasColumnName("equ_equipo_id_tercero");
        builder.Property(e => e.EquEquipoIdTerceroComprador).HasColumnName("equ_equipo_id_tercero_comprador");
        builder.Property(e => e.EquEquipoIdTerceroServicio).HasColumnName("equ_equipo_id_tercero_servicio");
        builder.Property(e => e.EquEquipoIdVersionEquipo).HasColumnName("equ_equipo_id_versionEquipo");
        builder.Property(e => e.EquEquipoIdZona).HasColumnName("equ_equipo_id_zona");
        builder.Property(e => e.EquEquipoNombreContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_nombreContacto");
        builder.Property(e => e.EquEquipoObservaciones)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_observaciones");
        builder.Property(e => e.EquEquipoPromedioHoras).HasColumnName("equ_equipo_promedioHoras");
        builder.Property(e => e.EquEquipoTelefonoContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_telefonoContacto");
        builder.Property(e => e.EquEquipoUbicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_ubicacion");
        builder.Property(e => e.EquEquipoUltimaLecturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_ultimaLectura_fh");
        builder.Property(e => e.EquEquipoVencimientoGarantiaDistribuidorFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_vencimientoGarantiaDistribuidor_ff");
        builder.Property(e => e.EquEquipoVencimientoGarantiaFabricaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_vencimientoGarantiaFabrica_ff");
        builder.Property(e => e.EquOpcionAtributoIdAtributo).HasColumnName("equ_opcionAtributo_id_atributo");
        builder.Property(e => e.EquOpcionAtributoOpcionAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_opcionAtributo_opcionAtributo");
        builder.Property(e => e.EquOpcionAtributoOpcionAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_opcionAtributo_opcionAtributo_codigo");
        builder.Property(e => e.EquOpcionAtributoOrden).HasColumnName("equ_opcionAtributo_orden");
        builder.Property(e => e.EquipoAtributo)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equipoAtributo");
        builder.Property(e => e.EquipoAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equipoAtributo_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdEvento).HasColumnName("id_evento");
        builder.Property(e => e.IdOpcionAtributo).HasColumnName("id_opcionAtributo");
        builder.Property(e => e.IdPruebaCheckList).HasColumnName("id_pruebaCheckList");
        builder.Property(e => e.IdReporteTecnico).HasColumnName("id_reporteTecnico");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.OrtReporteTecnicoCompromisos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_compromisos");
        builder.Property(e => e.OrtReporteTecnicoDiagnostico)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_diagnostico");
        builder.Property(e => e.OrtReporteTecnicoIdCanalAtencion).HasColumnName("ort_reporteTecnico_id_canalAtencion");
        builder.Property(e => e.OrtReporteTecnicoIdDocumentoGasto).HasColumnName("ort_reporteTecnico_id_documento.gasto");
        builder.Property(e => e.OrtReporteTecnicoIdGasto).HasColumnName("ort_reporteTecnico_id_gasto");
        builder.Property(e => e.OrtReporteTecnicoNumero)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_numero");
        builder.Property(e => e.OrtReporteTecnicoRecomendaciones)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_recomendaciones");
        builder.Property(e => e.OrtReporteTecnicoReporteTecnico)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_reporteTecnico");
        builder.Property(e => e.OrtReporteTecnicoReporteTecnicoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_reporteTecnico_codigo");
        builder.Property(e => e.OrtReporteTecnicoTrabajos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_trabajos");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Unidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("unidad");
    }
}
