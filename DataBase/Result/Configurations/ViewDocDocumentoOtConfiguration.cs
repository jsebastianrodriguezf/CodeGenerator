using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoOtConfiguration : IEntityTypeConfiguration<ViewDocDocumentoOt>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoOt> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_ot");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Cargo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cargo");
        builder.Property(e => e.CatSistemaIdSistema).HasColumnName("cat_sistema_id_sistema");
        builder.Property(e => e.CatSistemaSistema)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_sistema");
        builder.Property(e => e.CatSistemaSistemaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_sistema_codigo");
        builder.Property(e => e.CntContratoCondiciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_condiciones");
        builder.Property(e => e.CntContratoContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_contrato");
        builder.Property(e => e.CntContratoContratoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_contrato_codigo");
        builder.Property(e => e.CntContratoDiasCumplimiento).HasColumnName("cnt_contrato_diasCumplimiento");
        builder.Property(e => e.CntContratoFechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_contrato_fechaFin_ff");
        builder.Property(e => e.CntContratoFechaInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_contrato_fechaInicio_ff");
        builder.Property(e => e.CntContratoIdDepartamentoSolicitud).HasColumnName("cnt_contrato_id_departamentoSolicitud");
        builder.Property(e => e.CntContratoIdDocumentoAlquiler).HasColumnName("cnt_contrato_id_documento.alquiler");
        builder.Property(e => e.CntContratoIdPeriodoContrato).HasColumnName("cnt_contrato_id_periodoContrato");
        builder.Property(e => e.CntContratoIdSubtipoDocumento).HasColumnName("cnt_contrato_id_subtipoDocumento");
        builder.Property(e => e.CntContratoIdTercero).HasColumnName("cnt_contrato_id_tercero");
        builder.Property(e => e.CntContratoIdTerceroServicio).HasColumnName("cnt_contrato_id_tercero_servicio");
        builder.Property(e => e.CntContratoIdTipoContrato).HasColumnName("cnt_contrato_id_tipoContrato");
        builder.Property(e => e.CntContratoIdTipoServicio).HasColumnName("cnt_contrato_id_tipoServicio");
        builder.Property(e => e.CntContratoIdUsuarioCoordinador).HasColumnName("cnt_contrato_id_usuario_coordinador");
        builder.Property(e => e.CntContratoNumero)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_numero");
        builder.Property(e => e.CntContratoPresupuesto)
            .HasColumnType("money")
            .HasColumnName("cnt_contrato_presupuesto");
        builder.Property(e => e.CntContratoTotalContrato)
            .HasColumnType("money")
            .HasColumnName("cnt_contrato_totalContrato");
        builder.Property(e => e.Compromisos)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("compromisos");
        builder.Property(e => e.Contacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contacto");
        builder.Property(e => e.DiagnosticoInicial)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("diagnosticoInicial");
        builder.Property(e => e.DireccionUbicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("direccionUbicacion");
        builder.Property(e => e.DistribuyeCentros).HasColumnName("distribuyeCentros");
        builder.Property(e => e.DocDocumentoOtCosto).HasColumnName("doc_documento_ot_costo");
        builder.Property(e => e.DocDocumentoOtCostoPlaneado).HasColumnName("doc_documento_ot_costoPlaneado");
        builder.Property(e => e.DocDocumentoOtDescuento).HasColumnName("doc_documento_ot_descuento");
        builder.Property(e => e.DocDocumentoOtDescuentoPlaneado).HasColumnName("doc_documento_ot_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreCosto).HasColumnName("doc_documento_ot_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_ot_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreDescuento).HasColumnName("doc_documento_ot_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_ot_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_ot_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_ot_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_ot_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_ot_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_ot_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_ot_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_ot_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_ot_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_ot_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_ot_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_ot_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIva).HasColumnName("doc_documento_ot_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_ot_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_ot_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreSubtotal).HasColumnName("doc_documento_ot_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_ot_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreTotal).HasColumnName("doc_documento_ot_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_ot_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoOtDocDocumentoPadreTrm).HasColumnName("doc_documento_ot_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoOtDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_ot_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoOtDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_ot_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoOtDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoOtDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoOtDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_ot_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoOtDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOtDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoOtDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_ot_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoOtDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_ot_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoOtDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_ot_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoOtDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_ot_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOtDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoOtDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoOtDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_ot_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoOtDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_ot_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoOtDocPrioridadDocumentoOrden).HasColumnName("doc_documento_ot_doc_prioridadDocumento_orden");
        builder.Property(e => e.DocDocumentoOtDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoOtDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoOtDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_ot_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_ot_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_ot_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_ot_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_ot_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_ot_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_ot_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_ot_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_ot_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoOtDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_ot_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoOtDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_documento_codigo");
        builder.Property(e => e.DocDocumentoOtDocumentoNumero).HasColumnName("doc_documento_ot_documento_numero");
        builder.Property(e => e.DocDocumentoOtFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoOtFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fecha_fh");
        builder.Property(e => e.DocDocumentoOtFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoOtFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoOtGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoOtGenMonedaCambio).HasColumnName("doc_documento_ot_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoOtGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoOtGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoOtIdDocumento).HasColumnName("doc_documento_ot_id_documento");
        builder.Property(e => e.DocDocumentoOtIdEstadoTipoDocumento).HasColumnName("doc_documento_ot_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOtIdMoneda).HasColumnName("doc_documento_ot_id_moneda");
        builder.Property(e => e.DocDocumentoOtIdMotivoestado).HasColumnName("doc_documento_ot_id_motivoestado");
        builder.Property(e => e.DocDocumentoOtIdPrioridadDocumento).HasColumnName("doc_documento_ot_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoOtIdSubtipoDocumento).HasColumnName("doc_documento_ot_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoOtIdTerceroCliente).HasColumnName("doc_documento_ot_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoOtIdTerceroProveedor).HasColumnName("doc_documento_ot_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoOtIdUsuarioAsignado).HasColumnName("doc_documento_ot_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoOtIdUsuarioEnUso).HasColumnName("doc_documento_ot_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoOtIva).HasColumnName("doc_documento_ot_iva");
        builder.Property(e => e.DocDocumentoOtIvaPlaneado).HasColumnName("doc_documento_ot_ivaPlaneado");
        builder.Property(e => e.DocDocumentoOtPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_prefijo");
        builder.Property(e => e.DocDocumentoOtRentabilidad).HasColumnName("doc_documento_ot_rentabilidad");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_ot_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_ot_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_ot_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_ot_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_ot_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_ot_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_ot_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_ot_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_ot_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_ot_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_ot_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_ot_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoSexo).HasColumnName("doc_documento_ot_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoOtSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_ot_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_ot_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_ot_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_ot_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_ot_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_ot_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_ot_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_ot_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_ot_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_ot_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_ot_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_ot_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoSexo).HasColumnName("doc_documento_ot_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoOtSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoOtSubtotal).HasColumnName("doc_documento_ot_subtotal");
        builder.Property(e => e.DocDocumentoOtSubtotalPlaneado).HasColumnName("doc_documento_ot_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteEsCliente).HasColumnName("doc_documento_ot_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_ot_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteEsFabricante).HasColumnName("doc_documento_ot_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteEsProspecto).HasColumnName("doc_documento_ot_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteEsProveedor).HasColumnName("doc_documento_ot_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteEsTransportador).HasColumnName("doc_documento_ot_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_ot_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteIdFormaPago).HasColumnName("doc_documento_ot_ter_tercero_cliente_id_formaPago");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_ot_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteIdZona).HasColumnName("doc_documento_ot_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteTiempoEntrega).HasColumnName("doc_documento_ot_ter_tercero_cliente_tiempoEntrega");
        builder.Property(e => e.DocDocumentoOtTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorEsCliente).HasColumnName("doc_documento_ot_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_ot_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_ot_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_ot_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_ot_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_ot_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_ot_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_ot_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorIdZona).HasColumnName("doc_documento_ot_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoOtTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoOtTotal).HasColumnName("doc_documento_ot_total");
        builder.Property(e => e.DocDocumentoOtTotalPlaneado).HasColumnName("doc_documento_ot_totalPlaneado");
        builder.Property(e => e.DocDocumentoOtTrm).HasColumnName("doc_documento_ot_trm");
        builder.Property(e => e.DocumentoOt)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.ot");
        builder.Property(e => e.DuracionEstimada).HasColumnName("duracionEstimada");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("email");
        builder.Property(e => e.EnTaller).HasColumnName("enTaller");
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
        builder.Property(e => e.Fax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("fax");
        builder.Property(e => e.FechaCompromisoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCompromiso_fh");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaGarantia_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenTipoServicioDiasGarantia).HasColumnName("gen_tipoServicio_diasGarantia");
        builder.Property(e => e.GenTipoServicioTieneGarantia).HasColumnName("gen_tipoServicio_tieneGarantia");
        builder.Property(e => e.GenTipoServicioTipoServicio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_tipoServicio_tipoServicio");
        builder.Property(e => e.GenTipoServicioTipoServicioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_tipoServicio_tipoServicio_codigo");
        builder.Property(e => e.GenZonaCodigoExterno)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("gen_zona_codigoExterno");
        builder.Property(e => e.GenZonaIdZona).HasColumnName("gen_zona_id_zona");
        builder.Property(e => e.GenZonaNivel).HasColumnName("gen_zona_nivel");
        builder.Property(e => e.GenZonaTiempoDesplazamiento).HasColumnName("gen_zona_tiempoDesplazamiento");
        builder.Property(e => e.GenZonaZona)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_zona_zona");
        builder.Property(e => e.GenZonaZonaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_zona_zona_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdDepartamentoSolicitud).HasColumnName("id_departamentoSolicitud");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdFamilia).HasColumnName("id_familia");
        builder.Property(e => e.IdMotivoCancelacion).HasColumnName("id_motivoCancelacion");
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuarioCoordinador).HasColumnName("id_usuario_coordinador");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.MotivoServicio)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("motivoServicio");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.OrtDepartamentoSolicitudDepartamentoSolicitud)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_departamentoSolicitud_departamentoSolicitud");
        builder.Property(e => e.OrtDepartamentoSolicitudDepartamentoSolicitudCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_departamentoSolicitud_departamentoSolicitud_codigo");
        builder.Property(e => e.OrtDepartamentoSolicitudRecibeSolicitudes).HasColumnName("ort_departamentoSolicitud_recibeSolicitudes");
        builder.Property(e => e.OrtMotivoCancelacionMotivoCancelacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_motivoCancelacion_motivoCancelacion");
        builder.Property(e => e.OrtMotivoCancelacionMotivoCancelacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_motivoCancelacion_motivoCancelacion_codigo");
        builder.Property(e => e.OrtMotivoCancelacionResponsableServicio).HasColumnName("ort_motivoCancelacion_responsableServicio");
        builder.Property(e => e.PorcentajeCliente).HasColumnName("porcentajeCliente");
        builder.Property(e => e.PorcentajeDistribuidor).HasColumnName("porcentajeDistribuidor");
        builder.Property(e => e.PorcentajeFabricante).HasColumnName("porcentajeFabricante");
        builder.Property(e => e.ReclamacionFabrica)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("reclamacionFabrica");
        builder.Property(e => e.Recomendaciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("recomendaciones");
        builder.Property(e => e.SegUsuarioCoordinadorAccesoActivo).HasColumnName("seg_usuario_coordinador_accesoActivo");
        builder.Property(e => e.SegUsuarioCoordinadorAplicaRecargo).HasColumnName("seg_usuario_coordinador_aplicaRecargo");
        builder.Property(e => e.SegUsuarioCoordinadorCambiarClave).HasColumnName("seg_usuario_coordinador_cambiarClave");
        builder.Property(e => e.SegUsuarioCoordinadorClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_clave");
        builder.Property(e => e.SegUsuarioCoordinadorCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_coordinador_costoHora");
        builder.Property(e => e.SegUsuarioCoordinadorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_direccion");
        builder.Property(e => e.SegUsuarioCoordinadorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_email");
        builder.Property(e => e.SegUsuarioCoordinadorFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_coordinador_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioCoordinadorFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_coordinador_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioCoordinadorFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_coordinador_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioCoordinadorHabilitado).HasColumnName("seg_usuario_coordinador_habilitado");
        builder.Property(e => e.SegUsuarioCoordinadorIdCargo).HasColumnName("seg_usuario_coordinador_id_cargo");
        builder.Property(e => e.SegUsuarioCoordinadorIdGrupo).HasColumnName("seg_usuario_coordinador_id_grupo");
        builder.Property(e => e.SegUsuarioCoordinadorIdPerfil).HasColumnName("seg_usuario_coordinador_id_perfil");
        builder.Property(e => e.SegUsuarioCoordinadorIdUsuario).HasColumnName("seg_usuario_coordinador_id_usuario");
        builder.Property(e => e.SegUsuarioCoordinadorIdZona).HasColumnName("seg_usuario_coordinador_id_zona");
        builder.Property(e => e.SegUsuarioCoordinadorIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_identificacion");
        builder.Property(e => e.SegUsuarioCoordinadorIntentosFallidos).HasColumnName("seg_usuario_coordinador_intentosFallidos");
        builder.Property(e => e.SegUsuarioCoordinadorNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_nombre");
        builder.Property(e => e.SegUsuarioCoordinadorNumeroIngresos).HasColumnName("seg_usuario_coordinador_numeroIngresos");
        builder.Property(e => e.SegUsuarioCoordinadorPorcentajeComision).HasColumnName("seg_usuario_coordinador_porcentajeComision");
        builder.Property(e => e.SegUsuarioCoordinadorPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_coordinador_preferencias");
        builder.Property(e => e.SegUsuarioCoordinadorProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_profesion");
        builder.Property(e => e.SegUsuarioCoordinadorSexo).HasColumnName("seg_usuario_coordinador_sexo");
        builder.Property(e => e.SegUsuarioCoordinadorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_telefono");
        builder.Property(e => e.SegUsuarioCoordinadorUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_usuario");
        builder.Property(e => e.SegUsuarioCoordinadorUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_usuario_codigo");
        builder.Property(e => e.SegunTempario).HasColumnName("segunTempario");
        builder.Property(e => e.Telefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("telefono");
        builder.Property(e => e.TerSucursalCodigorecursiva)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_codigorecursiva");
        builder.Property(e => e.TerSucursalContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_contacto");
        builder.Property(e => e.TerSucursalDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Direccion");
        builder.Property(e => e.TerSucursalEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Email");
        builder.Property(e => e.TerSucursalFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Fax");
        builder.Property(e => e.TerSucursalIdEstadoTercero).HasColumnName("ter_sucursal_id_estadoTercero");
        builder.Property(e => e.TerSucursalIdSucursal).HasColumnName("ter_sucursal_id_sucursal");
        builder.Property(e => e.TerSucursalIdTercero).HasColumnName("ter_sucursal_id_tercero");
        builder.Property(e => e.TerSucursalIdUsuarioAsesor).HasColumnName("ter_sucursal_id_usuario_asesor");
        builder.Property(e => e.TerSucursalIdUsuarioTecnico).HasColumnName("ter_sucursal_id_usuario_tecnico");
        builder.Property(e => e.TerSucursalIdZona).HasColumnName("ter_sucursal_id_zona");
        builder.Property(e => e.TerSucursalParaAlquiler).HasColumnName("ter_sucursal_paraAlquiler");
        builder.Property(e => e.TerSucursalParaSoporte).HasColumnName("ter_sucursal_paraSoporte");
        builder.Property(e => e.TerSucursalParaVenta).HasColumnName("ter_sucursal_paraVenta");
        builder.Property(e => e.TerSucursalSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal");
        builder.Property(e => e.TerSucursalSucursalCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal_codigo");
        builder.Property(e => e.TerSucursalTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_telefono");
        builder.Property(e => e.Trabajos)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("trabajos");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
