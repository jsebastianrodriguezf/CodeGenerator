using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoSolicitudConfiguration : IEntityTypeConfiguration<ViewDocDocumentoSolicitud>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoSolicitud> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_solicitud");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Cargo)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cargo");
        builder.Property(e => e.Direccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("direccion");
        builder.Property(e => e.DocDocumentoSolicitudCosto).HasColumnName("doc_documento_solicitud_costo");
        builder.Property(e => e.DocDocumentoSolicitudCostoPlaneado).HasColumnName("doc_documento_solicitud_costoPlaneado");
        builder.Property(e => e.DocDocumentoSolicitudDescuento).HasColumnName("doc_documento_solicitud_descuento");
        builder.Property(e => e.DocDocumentoSolicitudDescuentoPlaneado).HasColumnName("doc_documento_solicitud_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreCosto).HasColumnName("doc_documento_solicitud_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_solicitud_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreDescuento).HasColumnName("doc_documento_solicitud_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_solicitud_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_solicitud_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_solicitud_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_solicitud_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_solicitud_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_solicitud_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_solicitud_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_solicitud_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_solicitud_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_solicitud_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_solicitud_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_solicitud_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIva).HasColumnName("doc_documento_solicitud_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_solicitud_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_solicitud_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreSubtotal).HasColumnName("doc_documento_solicitud_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_solicitud_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreTotal).HasColumnName("doc_documento_solicitud_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_solicitud_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoSolicitudDocDocumentoPadreTrm).HasColumnName("doc_documento_solicitud_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoSolicitudDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_solicitud_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoSolicitudDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_solicitud_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoSolicitudDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoSolicitudDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoSolicitudDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_solicitud_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoSolicitudDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_solicitud_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_solicitud_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoSolicitudDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_solicitud_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoSolicitudDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_solicitud_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoSolicitudDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoSolicitudDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_solicitud_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoSolicitudDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_solicitud_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocPrioridadDocumentoOrden).HasColumnName("doc_documento_solicitud_doc_prioridadDocumento_orden");
        builder.Property(e => e.DocDocumentoSolicitudDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoSolicitudDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_solicitud_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoSolicitudDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_solicitud_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoSolicitudDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_documento_codigo");
        builder.Property(e => e.DocDocumentoSolicitudDocumentoNumero).HasColumnName("doc_documento_solicitud_documento_numero");
        builder.Property(e => e.DocDocumentoSolicitudFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoSolicitudFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_fecha_fh");
        builder.Property(e => e.DocDocumentoSolicitudFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoSolicitudFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoSolicitudGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoSolicitudGenMonedaCambio).HasColumnName("doc_documento_solicitud_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoSolicitudGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoSolicitudGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoSolicitudIdDocumento).HasColumnName("doc_documento_solicitud_id_documento");
        builder.Property(e => e.DocDocumentoSolicitudIdEstadoTipoDocumento).HasColumnName("doc_documento_solicitud_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoSolicitudIdMoneda).HasColumnName("doc_documento_solicitud_id_moneda");
        builder.Property(e => e.DocDocumentoSolicitudIdMotivoestado).HasColumnName("doc_documento_solicitud_id_motivoestado");
        builder.Property(e => e.DocDocumentoSolicitudIdPrioridadDocumento).HasColumnName("doc_documento_solicitud_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoSolicitudIdSubtipoDocumento).HasColumnName("doc_documento_solicitud_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoSolicitudIdTerceroCliente).HasColumnName("doc_documento_solicitud_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoSolicitudIdTerceroProveedor).HasColumnName("doc_documento_solicitud_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoSolicitudIdUsuarioAsignado).HasColumnName("doc_documento_solicitud_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoSolicitudIdUsuarioEnUso).HasColumnName("doc_documento_solicitud_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoSolicitudIva).HasColumnName("doc_documento_solicitud_iva");
        builder.Property(e => e.DocDocumentoSolicitudIvaPlaneado).HasColumnName("doc_documento_solicitud_ivaPlaneado");
        builder.Property(e => e.DocDocumentoSolicitudPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_prefijo");
        builder.Property(e => e.DocDocumentoSolicitudRentabilidad).HasColumnName("doc_documento_solicitud_rentabilidad");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoSexo).HasColumnName("doc_documento_solicitud_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoSexo).HasColumnName("doc_documento_solicitud_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoSolicitudSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoSolicitudSubtotal).HasColumnName("doc_documento_solicitud_subtotal");
        builder.Property(e => e.DocDocumentoSolicitudSubtotalPlaneado).HasColumnName("doc_documento_solicitud_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteEsCliente).HasColumnName("doc_documento_solicitud_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_solicitud_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteEsFabricante).HasColumnName("doc_documento_solicitud_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteEsProspecto).HasColumnName("doc_documento_solicitud_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteEsProveedor).HasColumnName("doc_documento_solicitud_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteEsTransportador).HasColumnName("doc_documento_solicitud_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_solicitud_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_solicitud_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteIdZona).HasColumnName("doc_documento_solicitud_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorEsCliente).HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorIdZona).HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoSolicitudTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_solicitud_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoSolicitudTotal).HasColumnName("doc_documento_solicitud_total");
        builder.Property(e => e.DocDocumentoSolicitudTotalPlaneado).HasColumnName("doc_documento_solicitud_totalPlaneado");
        builder.Property(e => e.DocDocumentoSolicitudTrm).HasColumnName("doc_documento_solicitud_trm");
        builder.Property(e => e.DocMedioSolicitudMedioSolicitud)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_medioSolicitud_medioSolicitud");
        builder.Property(e => e.DocMedioSolicitudMedioSolicitudCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_medioSolicitud_medioSolicitud_codigo");
        builder.Property(e => e.DocumentoSolicitud)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.solicitud");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("email");
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
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
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
        builder.Property(e => e.IdDepartamentoSolicitud).HasColumnName("id_departamentoSolicitud");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdMedioSolicitud).HasColumnName("id_medioSolicitud");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
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
        builder.Property(e => e.Solicitante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("solicitante");
        builder.Property(e => e.SolucionTelefonica).HasColumnName("solucionTelefonica");
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
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
