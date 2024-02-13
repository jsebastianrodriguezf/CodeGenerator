using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoCotizacionConfiguration : IEntityTypeConfiguration<ViewDocDocumentoCotizacion>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoCotizacion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_cotizacion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Cargo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cargo");
        builder.Property(e => e.Condiciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("condiciones");
        builder.Property(e => e.Contacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contacto");
        builder.Property(e => e.DocDocumentoCotizacionCosto).HasColumnName("doc_documento_cotizacion_costo");
        builder.Property(e => e.DocDocumentoCotizacionCostoPlaneado).HasColumnName("doc_documento_cotizacion_costoPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionDescuento).HasColumnName("doc_documento_cotizacion_descuento");
        builder.Property(e => e.DocDocumentoCotizacionDescuentoPlaneado).HasColumnName("doc_documento_cotizacion_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreCosto).HasColumnName("doc_documento_cotizacion_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_cotizacion_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreDescuento).HasColumnName("doc_documento_cotizacion_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_cotizacion_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_cotizacion_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_cotizacion_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_cotizacion_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_cotizacion_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_cotizacion_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_cotizacion_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_cotizacion_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_cotizacion_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_cotizacion_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_cotizacion_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_cotizacion_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIva).HasColumnName("doc_documento_cotizacion_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_cotizacion_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_cotizacion_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreSubtotal).HasColumnName("doc_documento_cotizacion_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_cotizacion_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreTotal).HasColumnName("doc_documento_cotizacion_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_cotizacion_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionDocDocumentoPadreTrm).HasColumnName("doc_documento_cotizacion_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoCotizacionDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_cotizacion_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoCotizacionDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_cotizacion_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoCotizacionDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoCotizacionDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoCotizacionDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_cotizacion_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoCotizacionDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_cotizacion_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_cotizacion_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoCotizacionDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_cotizacion_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoCotizacionDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_cotizacion_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoCotizacionDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoCotizacionDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_cotizacion_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoCotizacionDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_cotizacion_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocPrioridadDocumentoOrden).HasColumnName("doc_documento_cotizacion_doc_prioridadDocumento_orden");
        builder.Property(e => e.DocDocumentoCotizacionDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoCotizacionDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_cotizacion_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoCotizacionDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_cotizacion_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoCotizacionDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_documento_codigo");
        builder.Property(e => e.DocDocumentoCotizacionDocumentoNumero).HasColumnName("doc_documento_cotizacion_documento_numero");
        builder.Property(e => e.DocDocumentoCotizacionFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoCotizacionFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_fecha_fh");
        builder.Property(e => e.DocDocumentoCotizacionFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoCotizacionFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoCotizacionGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoCotizacionGenMonedaCambio).HasColumnName("doc_documento_cotizacion_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoCotizacionGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoCotizacionGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoCotizacionIdDocumento).HasColumnName("doc_documento_cotizacion_id_documento");
        builder.Property(e => e.DocDocumentoCotizacionIdEstadoTipoDocumento).HasColumnName("doc_documento_cotizacion_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionIdMoneda).HasColumnName("doc_documento_cotizacion_id_moneda");
        builder.Property(e => e.DocDocumentoCotizacionIdMotivoestado).HasColumnName("doc_documento_cotizacion_id_motivoestado");
        builder.Property(e => e.DocDocumentoCotizacionIdPrioridadDocumento).HasColumnName("doc_documento_cotizacion_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoCotizacionIdSubtipoDocumento).HasColumnName("doc_documento_cotizacion_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionIdTerceroCliente).HasColumnName("doc_documento_cotizacion_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoCotizacionIdTerceroProveedor).HasColumnName("doc_documento_cotizacion_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoCotizacionIdUsuarioAsignado).HasColumnName("doc_documento_cotizacion_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoCotizacionIdUsuarioEnUso).HasColumnName("doc_documento_cotizacion_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoCotizacionIva).HasColumnName("doc_documento_cotizacion_iva");
        builder.Property(e => e.DocDocumentoCotizacionIvaPlaneado).HasColumnName("doc_documento_cotizacion_ivaPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_prefijo");
        builder.Property(e => e.DocDocumentoCotizacionRentabilidad).HasColumnName("doc_documento_cotizacion_rentabilidad");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoSexo).HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoSexo).HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoCotizacionSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoCotizacionSubtotal).HasColumnName("doc_documento_cotizacion_subtotal");
        builder.Property(e => e.DocDocumentoCotizacionSubtotalPlaneado).HasColumnName("doc_documento_cotizacion_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteEsCliente).HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteEsFabricante).HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteEsProspecto).HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteEsProveedor).HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteEsTransportador).HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteIdZona).HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorEsCliente).HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorIdZona).HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoCotizacionTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoCotizacionTotal).HasColumnName("doc_documento_cotizacion_total");
        builder.Property(e => e.DocDocumentoCotizacionTotalPlaneado).HasColumnName("doc_documento_cotizacion_totalPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionTrm).HasColumnName("doc_documento_cotizacion_trm");
        builder.Property(e => e.DocumentoCotizacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.cotizacion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("email");
        builder.Property(e => e.Encabezado)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("encabezado");
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
        builder.Property(e => e.EsAiu).HasColumnName("esAIU");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioAsesor).HasColumnName("id_usuario_asesor");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Notas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("notas");
        builder.Property(e => e.ProcentajeA).HasColumnName("procentajeA");
        builder.Property(e => e.ProcentajeI).HasColumnName("procentajeI");
        builder.Property(e => e.ProcentajeU).HasColumnName("procentajeU");
        builder.Property(e => e.SegUsuarioAsesorAccesoActivo).HasColumnName("seg_usuario_asesor_accesoActivo");
        builder.Property(e => e.SegUsuarioAsesorAplicaRecargo).HasColumnName("seg_usuario_asesor_aplicaRecargo");
        builder.Property(e => e.SegUsuarioAsesorCambiarClave).HasColumnName("seg_usuario_asesor_cambiarClave");
        builder.Property(e => e.SegUsuarioAsesorClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_clave");
        builder.Property(e => e.SegUsuarioAsesorCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_asesor_costoHora");
        builder.Property(e => e.SegUsuarioAsesorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_direccion");
        builder.Property(e => e.SegUsuarioAsesorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_email");
        builder.Property(e => e.SegUsuarioAsesorFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_asesor_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioAsesorFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_asesor_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioAsesorFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_asesor_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioAsesorHabilitado).HasColumnName("seg_usuario_asesor_habilitado");
        builder.Property(e => e.SegUsuarioAsesorIdCargo).HasColumnName("seg_usuario_asesor_id_cargo");
        builder.Property(e => e.SegUsuarioAsesorIdGrupo).HasColumnName("seg_usuario_asesor_id_grupo");
        builder.Property(e => e.SegUsuarioAsesorIdPerfil).HasColumnName("seg_usuario_asesor_id_perfil");
        builder.Property(e => e.SegUsuarioAsesorIdUsuario).HasColumnName("seg_usuario_asesor_id_usuario");
        builder.Property(e => e.SegUsuarioAsesorIdZona).HasColumnName("seg_usuario_asesor_id_zona");
        builder.Property(e => e.SegUsuarioAsesorIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_identificacion");
        builder.Property(e => e.SegUsuarioAsesorIntentosFallidos).HasColumnName("seg_usuario_asesor_intentosFallidos");
        builder.Property(e => e.SegUsuarioAsesorNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_nombre");
        builder.Property(e => e.SegUsuarioAsesorNumeroIngresos).HasColumnName("seg_usuario_asesor_numeroIngresos");
        builder.Property(e => e.SegUsuarioAsesorPorcentajeComision).HasColumnName("seg_usuario_asesor_porcentajeComision");
        builder.Property(e => e.SegUsuarioAsesorPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_asesor_preferencias");
        builder.Property(e => e.SegUsuarioAsesorProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_profesion");
        builder.Property(e => e.SegUsuarioAsesorSexo).HasColumnName("seg_usuario_asesor_sexo");
        builder.Property(e => e.SegUsuarioAsesorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_telefono");
        builder.Property(e => e.SegUsuarioAsesorUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_usuario");
        builder.Property(e => e.SegUsuarioAsesorUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_usuario_codigo");
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
        builder.Property(e => e.Validez).HasColumnName("validez");
        builder.Property(e => e.ValorA).HasColumnName("valorA");
        builder.Property(e => e.ValorI).HasColumnName("valorI");
        builder.Property(e => e.ValorU).HasColumnName("valorU");
        builder.Property(e => e.Version).HasColumnName("version");
    }
}
