using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoSalidumConfiguration : IEntityTypeConfiguration<ViewDocDocumentoSalidum>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoSalidum> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_salida");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Asunto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("asunto");
        builder.Property(e => e.DireccionEntrega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("direccionEntrega");
        builder.Property(e => e.DocDocumentoSalidaCosto).HasColumnName("doc_documento_salida_costo");
        builder.Property(e => e.DocDocumentoSalidaCostoPlaneado).HasColumnName("doc_documento_salida_costoPlaneado");
        builder.Property(e => e.DocDocumentoSalidaDescuento).HasColumnName("doc_documento_salida_descuento");
        builder.Property(e => e.DocDocumentoSalidaDescuentoPlaneado).HasColumnName("doc_documento_salida_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreCosto).HasColumnName("doc_documento_salida_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_salida_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreDescuento).HasColumnName("doc_documento_salida_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_salida_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_salida_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_salida_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_salida_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_salida_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_salida_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_salida_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_salida_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_salida_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_salida_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_salida_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_salida_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIva).HasColumnName("doc_documento_salida_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_salida_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_salida_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreSubtotal).HasColumnName("doc_documento_salida_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_salida_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreTotal).HasColumnName("doc_documento_salida_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_salida_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoSalidaDocDocumentoPadreTrm).HasColumnName("doc_documento_salida_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoSalidaDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_salida_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoSalidaDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_salida_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoSalidaDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoSalidaDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoSalidaDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_salida_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoSalidaDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_salida_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_salida_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoSalidaDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_salida_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoSalidaDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_salida_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoSalidaDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoSalidaDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_salida_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoSalidaDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_salida_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocPrioridadDocumentoOrden).HasColumnName("doc_documento_salida_doc_prioridadDocumento_orden");
        builder.Property(e => e.DocDocumentoSalidaDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoSalidaDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_salida_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_salida_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_salida_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_salida_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_salida_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_salida_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_salida_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_salida_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_salida_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoSalidaDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_salida_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoSalidaDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_documento_codigo");
        builder.Property(e => e.DocDocumentoSalidaDocumentoNumero).HasColumnName("doc_documento_salida_documento_numero");
        builder.Property(e => e.DocDocumentoSalidaFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoSalidaFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_fecha_fh");
        builder.Property(e => e.DocDocumentoSalidaFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoSalidaFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoSalidaGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoSalidaGenMonedaCambio).HasColumnName("doc_documento_salida_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoSalidaGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoSalidaGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoSalidaIdDocumento).HasColumnName("doc_documento_salida_id_documento");
        builder.Property(e => e.DocDocumentoSalidaIdEstadoTipoDocumento).HasColumnName("doc_documento_salida_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoSalidaIdMoneda).HasColumnName("doc_documento_salida_id_moneda");
        builder.Property(e => e.DocDocumentoSalidaIdMotivoestado).HasColumnName("doc_documento_salida_id_motivoestado");
        builder.Property(e => e.DocDocumentoSalidaIdPrioridadDocumento).HasColumnName("doc_documento_salida_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoSalidaIdSubtipoDocumento).HasColumnName("doc_documento_salida_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoSalidaIdTerceroCliente).HasColumnName("doc_documento_salida_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoSalidaIdTerceroProveedor).HasColumnName("doc_documento_salida_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoSalidaIdUsuarioAsignado).HasColumnName("doc_documento_salida_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoSalidaIdUsuarioEnUso).HasColumnName("doc_documento_salida_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoSalidaIva).HasColumnName("doc_documento_salida_iva");
        builder.Property(e => e.DocDocumentoSalidaIvaPlaneado).HasColumnName("doc_documento_salida_ivaPlaneado");
        builder.Property(e => e.DocDocumentoSalidaPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_prefijo");
        builder.Property(e => e.DocDocumentoSalidaRentabilidad).HasColumnName("doc_documento_salida_rentabilidad");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_salida_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_salida_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_salida_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_salida_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_salida_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_salida_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_salida_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_salida_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_salida_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_salida_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_salida_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_salida_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoSexo).HasColumnName("doc_documento_salida_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_salida_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_salida_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_salida_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_salida_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_salida_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_salida_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_salida_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_salida_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_salida_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_salida_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_salida_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_salida_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoSexo).HasColumnName("doc_documento_salida_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoSalidaSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoSalidaSubtotal).HasColumnName("doc_documento_salida_subtotal");
        builder.Property(e => e.DocDocumentoSalidaSubtotalPlaneado).HasColumnName("doc_documento_salida_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteEsCliente).HasColumnName("doc_documento_salida_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_salida_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteEsFabricante).HasColumnName("doc_documento_salida_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteEsProspecto).HasColumnName("doc_documento_salida_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteEsProveedor).HasColumnName("doc_documento_salida_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteEsTransportador).HasColumnName("doc_documento_salida_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_salida_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_salida_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteIdZona).HasColumnName("doc_documento_salida_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorEsCliente).HasColumnName("doc_documento_salida_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_salida_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_salida_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_salida_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_salida_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_salida_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_salida_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_salida_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorIdZona).HasColumnName("doc_documento_salida_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoSalidaTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_salida_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoSalidaTotal).HasColumnName("doc_documento_salida_total");
        builder.Property(e => e.DocDocumentoSalidaTotalPlaneado).HasColumnName("doc_documento_salida_totalPlaneado");
        builder.Property(e => e.DocDocumentoSalidaTrm).HasColumnName("doc_documento_salida_trm");
        builder.Property(e => e.DocumentoSalida)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.salida");
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
        builder.Property(e => e.IdTerceroTransportador).HasColumnName("id_tercero_transportador");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioRecibe).HasColumnName("id_usuario_recibe");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("observaciones");
        builder.Property(e => e.SegUsuarioRecibeAccesoActivo).HasColumnName("seg_usuario_recibe_accesoActivo");
        builder.Property(e => e.SegUsuarioRecibeAplicaRecargo).HasColumnName("seg_usuario_recibe_aplicaRecargo");
        builder.Property(e => e.SegUsuarioRecibeCambiarClave).HasColumnName("seg_usuario_recibe_cambiarClave");
        builder.Property(e => e.SegUsuarioRecibeClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_recibe_clave");
        builder.Property(e => e.SegUsuarioRecibeCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_recibe_costoHora");
        builder.Property(e => e.SegUsuarioRecibeDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_recibe_direccion");
        builder.Property(e => e.SegUsuarioRecibeEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_recibe_email");
        builder.Property(e => e.SegUsuarioRecibeFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_recibe_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioRecibeFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_recibe_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioRecibeFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_recibe_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioRecibeHabilitado).HasColumnName("seg_usuario_recibe_habilitado");
        builder.Property(e => e.SegUsuarioRecibeIdCargo).HasColumnName("seg_usuario_recibe_id_cargo");
        builder.Property(e => e.SegUsuarioRecibeIdGrupo).HasColumnName("seg_usuario_recibe_id_grupo");
        builder.Property(e => e.SegUsuarioRecibeIdPerfil).HasColumnName("seg_usuario_recibe_id_perfil");
        builder.Property(e => e.SegUsuarioRecibeIdUsuario).HasColumnName("seg_usuario_recibe_id_usuario");
        builder.Property(e => e.SegUsuarioRecibeIdZona).HasColumnName("seg_usuario_recibe_id_zona");
        builder.Property(e => e.SegUsuarioRecibeIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_recibe_identificacion");
        builder.Property(e => e.SegUsuarioRecibeIntentosFallidos).HasColumnName("seg_usuario_recibe_intentosFallidos");
        builder.Property(e => e.SegUsuarioRecibeNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_recibe_nombre");
        builder.Property(e => e.SegUsuarioRecibeNumeroIngresos).HasColumnName("seg_usuario_recibe_numeroIngresos");
        builder.Property(e => e.SegUsuarioRecibePorcentajeComision).HasColumnName("seg_usuario_recibe_porcentajeComision");
        builder.Property(e => e.SegUsuarioRecibePreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_recibe_preferencias");
        builder.Property(e => e.SegUsuarioRecibeProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_recibe_profesion");
        builder.Property(e => e.SegUsuarioRecibeSexo).HasColumnName("seg_usuario_recibe_sexo");
        builder.Property(e => e.SegUsuarioRecibeTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_recibe_telefono");
        builder.Property(e => e.SegUsuarioRecibeUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_recibe_usuario");
        builder.Property(e => e.SegUsuarioRecibeUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_recibe_usuario_codigo");
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
        builder.Property(e => e.TerTerceroTransportadorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_clasificacion");
        builder.Property(e => e.TerTerceroTransportadorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_contacto");
        builder.Property(e => e.TerTerceroTransportadorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_direccion");
        builder.Property(e => e.TerTerceroTransportadorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_email");
        builder.Property(e => e.TerTerceroTransportadorEsCliente).HasColumnName("ter_tercero_transportador_esCliente");
        builder.Property(e => e.TerTerceroTransportadorEsEmpresaPropia).HasColumnName("ter_tercero_transportador_esEmpresaPropia");
        builder.Property(e => e.TerTerceroTransportadorEsFabricante).HasColumnName("ter_tercero_transportador_esFabricante");
        builder.Property(e => e.TerTerceroTransportadorEsProspecto).HasColumnName("ter_tercero_transportador_esProspecto");
        builder.Property(e => e.TerTerceroTransportadorEsProveedor).HasColumnName("ter_tercero_transportador_esProveedor");
        builder.Property(e => e.TerTerceroTransportadorEsTransportador).HasColumnName("ter_tercero_transportador_esTransportador");
        builder.Property(e => e.TerTerceroTransportadorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_fax");
        builder.Property(e => e.TerTerceroTransportadorIdEstadoTercero).HasColumnName("ter_tercero_transportador_id_estadoTercero");
        builder.Property(e => e.TerTerceroTransportadorIdNaturalezaTercero).HasColumnName("ter_tercero_transportador_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroTransportadorIdZona).HasColumnName("ter_tercero_transportador_id_zona");
        builder.Property(e => e.TerTerceroTransportadorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_notas");
        builder.Property(e => e.TerTerceroTransportadorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_representante");
        builder.Property(e => e.TerTerceroTransportadorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_telefono");
        builder.Property(e => e.TerTerceroTransportadorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_tercero");
        builder.Property(e => e.TerTerceroTransportadorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_tercero_codigo");
        builder.Property(e => e.TerTerceroTransportadorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_tercero_nit");
        builder.Property(e => e.TerTerceroTransportadorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroTransportadorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_transportador_website");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
