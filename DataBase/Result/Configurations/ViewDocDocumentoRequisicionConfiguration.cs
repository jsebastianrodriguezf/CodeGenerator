using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoRequisicionConfiguration : IEntityTypeConfiguration<ViewDocDocumentoRequisicion>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoRequisicion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_requisicion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Asunto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("asunto");
        builder.Property(e => e.DireccionEntrega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("direccionEntrega");
        builder.Property(e => e.DocDocumentoRequisicionCosto).HasColumnName("doc_documento_requisicion_costo");
        builder.Property(e => e.DocDocumentoRequisicionCostoPlaneado).HasColumnName("doc_documento_requisicion_costoPlaneado");
        builder.Property(e => e.DocDocumentoRequisicionDescuento).HasColumnName("doc_documento_requisicion_descuento");
        builder.Property(e => e.DocDocumentoRequisicionDescuentoPlaneado).HasColumnName("doc_documento_requisicion_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreCosto).HasColumnName("doc_documento_requisicion_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_requisicion_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreDescuento).HasColumnName("doc_documento_requisicion_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_requisicion_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_requisicion_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_requisicion_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_requisicion_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_requisicion_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_requisicion_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_requisicion_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_requisicion_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_requisicion_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_requisicion_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_requisicion_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_requisicion_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIva).HasColumnName("doc_documento_requisicion_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_requisicion_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_requisicion_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreSubtotal).HasColumnName("doc_documento_requisicion_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_requisicion_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreTotal).HasColumnName("doc_documento_requisicion_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_requisicion_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoRequisicionDocDocumentoPadreTrm).HasColumnName("doc_documento_requisicion_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoRequisicionDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_requisicion_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoRequisicionDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_requisicion_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoRequisicionDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoRequisicionDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoRequisicionDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_requisicion_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoRequisicionDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_requisicion_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_requisicion_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoRequisicionDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_requisicion_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoRequisicionDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_requisicion_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoRequisicionDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoRequisicionDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_requisicion_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoRequisicionDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_requisicion_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocPrioridadDocumentoOrden).HasColumnName("doc_documento_requisicion_doc_prioridadDocumento_orden");
        builder.Property(e => e.DocDocumentoRequisicionDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoRequisicionDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_requisicion_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoRequisicionDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_requisicion_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoRequisicionDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_documento_codigo");
        builder.Property(e => e.DocDocumentoRequisicionDocumentoNumero).HasColumnName("doc_documento_requisicion_documento_numero");
        builder.Property(e => e.DocDocumentoRequisicionFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoRequisicionFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_fecha_fh");
        builder.Property(e => e.DocDocumentoRequisicionFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoRequisicionFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoRequisicionGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoRequisicionGenMonedaCambio).HasColumnName("doc_documento_requisicion_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoRequisicionGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoRequisicionGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoRequisicionIdDocumento).HasColumnName("doc_documento_requisicion_id_documento");
        builder.Property(e => e.DocDocumentoRequisicionIdEstadoTipoDocumento).HasColumnName("doc_documento_requisicion_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoRequisicionIdMoneda).HasColumnName("doc_documento_requisicion_id_moneda");
        builder.Property(e => e.DocDocumentoRequisicionIdMotivoestado).HasColumnName("doc_documento_requisicion_id_motivoestado");
        builder.Property(e => e.DocDocumentoRequisicionIdPrioridadDocumento).HasColumnName("doc_documento_requisicion_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoRequisicionIdSubtipoDocumento).HasColumnName("doc_documento_requisicion_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoRequisicionIdTerceroCliente).HasColumnName("doc_documento_requisicion_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoRequisicionIdTerceroProveedor).HasColumnName("doc_documento_requisicion_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoRequisicionIdUsuarioAsignado).HasColumnName("doc_documento_requisicion_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoRequisicionIdUsuarioEnUso).HasColumnName("doc_documento_requisicion_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoRequisicionIva).HasColumnName("doc_documento_requisicion_iva");
        builder.Property(e => e.DocDocumentoRequisicionIvaPlaneado).HasColumnName("doc_documento_requisicion_ivaPlaneado");
        builder.Property(e => e.DocDocumentoRequisicionPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_prefijo");
        builder.Property(e => e.DocDocumentoRequisicionRentabilidad).HasColumnName("doc_documento_requisicion_rentabilidad");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoSexo).HasColumnName("doc_documento_requisicion_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoSexo).HasColumnName("doc_documento_requisicion_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoRequisicionSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoRequisicionSubtotal).HasColumnName("doc_documento_requisicion_subtotal");
        builder.Property(e => e.DocDocumentoRequisicionSubtotalPlaneado).HasColumnName("doc_documento_requisicion_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteEsCliente).HasColumnName("doc_documento_requisicion_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_requisicion_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteEsFabricante).HasColumnName("doc_documento_requisicion_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteEsProspecto).HasColumnName("doc_documento_requisicion_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteEsProveedor).HasColumnName("doc_documento_requisicion_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteEsTransportador).HasColumnName("doc_documento_requisicion_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_requisicion_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_requisicion_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteIdZona).HasColumnName("doc_documento_requisicion_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorEsCliente).HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorIdZona).HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoRequisicionTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_requisicion_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoRequisicionTotal).HasColumnName("doc_documento_requisicion_total");
        builder.Property(e => e.DocDocumentoRequisicionTotalPlaneado).HasColumnName("doc_documento_requisicion_totalPlaneado");
        builder.Property(e => e.DocDocumentoRequisicionTrm).HasColumnName("doc_documento_requisicion_trm");
        builder.Property(e => e.DocumentoRequisicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.requisicion");
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
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("observaciones");
        builder.Property(e => e.Solicitante)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("solicitante");
        builder.Property(e => e.TelefonoEntrega)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("telefonoEntrega");
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
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
