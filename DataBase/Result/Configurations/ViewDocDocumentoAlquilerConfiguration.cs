using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoAlquilerConfiguration : IEntityTypeConfiguration<ViewDocDocumentoAlquiler>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoAlquiler> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_alquiler");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocDocumentoAlquilerCosto).HasColumnName("doc_documento_alquiler_costo");
        builder.Property(e => e.DocDocumentoAlquilerCostoPlaneado).HasColumnName("doc_documento_alquiler_costoPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDescuento).HasColumnName("doc_documento_alquiler_descuento");
        builder.Property(e => e.DocDocumentoAlquilerDescuentoPlaneado).HasColumnName("doc_documento_alquiler_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreCosto).HasColumnName("doc_documento_alquiler_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_alquiler_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreDescuento).HasColumnName("doc_documento_alquiler_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_alquiler_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_alquiler_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_alquiler_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_alquiler_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_alquiler_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_alquiler_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_alquiler_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_alquiler_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_alquiler_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_alquiler_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_alquiler_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_alquiler_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIva).HasColumnName("doc_documento_alquiler_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_alquiler_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_alquiler_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreSubtotal).HasColumnName("doc_documento_alquiler_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_alquiler_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreTotal).HasColumnName("doc_documento_alquiler_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_alquiler_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDocDocumentoPadreTrm).HasColumnName("doc_documento_alquiler_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoAlquilerDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_alquiler_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoAlquilerDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_alquiler_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoAlquilerDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoAlquilerDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoAlquilerDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_alquiler_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoAlquilerDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_alquiler_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_alquiler_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoAlquilerDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_alquiler_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoAlquilerDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_alquiler_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoAlquilerDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoAlquilerDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_alquiler_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoAlquilerDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_alquiler_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocPrioridadDocumentoOrden).HasColumnName("doc_documento_alquiler_doc_prioridadDocumento_orden");
        builder.Property(e => e.DocDocumentoAlquilerDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoAlquilerDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_alquiler_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoAlquilerDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_alquiler_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_documento_codigo");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoNumero).HasColumnName("doc_documento_alquiler_documento_numero");
        builder.Property(e => e.DocDocumentoAlquilerFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoAlquilerFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fecha_fh");
        builder.Property(e => e.DocDocumentoAlquilerFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoAlquilerFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoAlquilerGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoAlquilerGenMonedaCambio).HasColumnName("doc_documento_alquiler_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoAlquilerGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoAlquilerGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoAlquilerIdDocumento).HasColumnName("doc_documento_alquiler_id_documento");
        builder.Property(e => e.DocDocumentoAlquilerIdEstadoTipoDocumento).HasColumnName("doc_documento_alquiler_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerIdMoneda).HasColumnName("doc_documento_alquiler_id_moneda");
        builder.Property(e => e.DocDocumentoAlquilerIdMotivoestado).HasColumnName("doc_documento_alquiler_id_motivoestado");
        builder.Property(e => e.DocDocumentoAlquilerIdPrioridadDocumento).HasColumnName("doc_documento_alquiler_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoAlquilerIdSubtipoDocumento).HasColumnName("doc_documento_alquiler_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerIdTerceroCliente).HasColumnName("doc_documento_alquiler_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoAlquilerIdTerceroProveedor).HasColumnName("doc_documento_alquiler_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoAlquilerIdUsuarioAsignado).HasColumnName("doc_documento_alquiler_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoAlquilerIdUsuarioEnUso).HasColumnName("doc_documento_alquiler_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoAlquilerIva).HasColumnName("doc_documento_alquiler_iva");
        builder.Property(e => e.DocDocumentoAlquilerIvaPlaneado).HasColumnName("doc_documento_alquiler_ivaPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_prefijo");
        builder.Property(e => e.DocDocumentoAlquilerRentabilidad).HasColumnName("doc_documento_alquiler_rentabilidad");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoSexo).HasColumnName("doc_documento_alquiler_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoSexo).HasColumnName("doc_documento_alquiler_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoAlquilerSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoAlquilerSubtotal).HasColumnName("doc_documento_alquiler_subtotal");
        builder.Property(e => e.DocDocumentoAlquilerSubtotalPlaneado).HasColumnName("doc_documento_alquiler_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteEsCliente).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteEsFabricante).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteEsProspecto).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteEsProveedor).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteEsTransportador).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteIdFormaPago).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_id_formaPago");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteIdZona).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteTiempoEntrega).HasColumnName("doc_documento_alquiler_ter_tercero_cliente_tiempoEntrega");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorEsCliente).HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorIdZona).HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoAlquilerTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoAlquilerTotal).HasColumnName("doc_documento_alquiler_total");
        builder.Property(e => e.DocDocumentoAlquilerTotalPlaneado).HasColumnName("doc_documento_alquiler_totalPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerTrm).HasColumnName("doc_documento_alquiler_trm");
        builder.Property(e => e.DocumentoAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.alquiler");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EjecutaDevolucion).HasColumnName("ejecutaDevolucion");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFin_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MesVencido).HasColumnName("mesVencido");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(3000)
            .IsUnicode(false)
            .HasColumnName("observaciones");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
