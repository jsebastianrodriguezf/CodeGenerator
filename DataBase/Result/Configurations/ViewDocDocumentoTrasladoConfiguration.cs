using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoTrasladoConfiguration : IEntityTypeConfiguration<ViewDocDocumentoTraslado>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoTraslado> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_traslado");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocDocumentoTrasladoCosto).HasColumnName("doc_documento_traslado_costo");
        builder.Property(e => e.DocDocumentoTrasladoCostoPlaneado).HasColumnName("doc_documento_traslado_costoPlaneado");
        builder.Property(e => e.DocDocumentoTrasladoDescuento).HasColumnName("doc_documento_traslado_descuento");
        builder.Property(e => e.DocDocumentoTrasladoDescuentoPlaneado).HasColumnName("doc_documento_traslado_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreCosto).HasColumnName("doc_documento_traslado_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_traslado_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreDescuento).HasColumnName("doc_documento_traslado_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_traslado_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_traslado_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_traslado_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_traslado_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_traslado_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_traslado_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_traslado_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_traslado_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_traslado_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_traslado_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_traslado_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_traslado_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIva).HasColumnName("doc_documento_traslado_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_traslado_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_traslado_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreSubtotal).HasColumnName("doc_documento_traslado_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_traslado_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreTotal).HasColumnName("doc_documento_traslado_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_traslado_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoTrasladoDocDocumentoPadreTrm).HasColumnName("doc_documento_traslado_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoTrasladoDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_traslado_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoTrasladoDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_traslado_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoTrasladoDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoTrasladoDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoTrasladoDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_traslado_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoTrasladoDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_traslado_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_traslado_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoTrasladoDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_traslado_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoTrasladoDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_traslado_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoTrasladoDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoTrasladoDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_traslado_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoTrasladoDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_traslado_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocPrioridadDocumentoOrden).HasColumnName("doc_documento_traslado_doc_prioridadDocumento_orden");
        builder.Property(e => e.DocDocumentoTrasladoDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoTrasladoDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_traslado_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_traslado_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_traslado_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_traslado_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_traslado_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_traslado_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_traslado_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_traslado_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_traslado_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoTrasladoDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_traslado_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoTrasladoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_documento_codigo");
        builder.Property(e => e.DocDocumentoTrasladoDocumentoNumero).HasColumnName("doc_documento_traslado_documento_numero");
        builder.Property(e => e.DocDocumentoTrasladoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoTrasladoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_fecha_fh");
        builder.Property(e => e.DocDocumentoTrasladoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoTrasladoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoTrasladoGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoTrasladoGenMonedaCambio).HasColumnName("doc_documento_traslado_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoTrasladoGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoTrasladoGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoTrasladoIdDocumento).HasColumnName("doc_documento_traslado_id_documento");
        builder.Property(e => e.DocDocumentoTrasladoIdEstadoTipoDocumento).HasColumnName("doc_documento_traslado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoTrasladoIdMoneda).HasColumnName("doc_documento_traslado_id_moneda");
        builder.Property(e => e.DocDocumentoTrasladoIdMotivoestado).HasColumnName("doc_documento_traslado_id_motivoestado");
        builder.Property(e => e.DocDocumentoTrasladoIdPrioridadDocumento).HasColumnName("doc_documento_traslado_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoTrasladoIdSubtipoDocumento).HasColumnName("doc_documento_traslado_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoTrasladoIdTerceroCliente).HasColumnName("doc_documento_traslado_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoTrasladoIdTerceroProveedor).HasColumnName("doc_documento_traslado_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoTrasladoIdUsuarioAsignado).HasColumnName("doc_documento_traslado_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoTrasladoIdUsuarioEnUso).HasColumnName("doc_documento_traslado_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoTrasladoIva).HasColumnName("doc_documento_traslado_iva");
        builder.Property(e => e.DocDocumentoTrasladoIvaPlaneado).HasColumnName("doc_documento_traslado_ivaPlaneado");
        builder.Property(e => e.DocDocumentoTrasladoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_prefijo");
        builder.Property(e => e.DocDocumentoTrasladoRentabilidad).HasColumnName("doc_documento_traslado_rentabilidad");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_traslado_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_traslado_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_traslado_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_traslado_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_traslado_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_traslado_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_traslado_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_traslado_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_traslado_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_traslado_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_traslado_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_traslado_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoSexo).HasColumnName("doc_documento_traslado_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_traslado_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_traslado_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_traslado_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_traslado_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_traslado_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_traslado_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_traslado_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_traslado_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_traslado_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_traslado_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_traslado_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_traslado_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoSexo).HasColumnName("doc_documento_traslado_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoTrasladoSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoTrasladoSubtotal).HasColumnName("doc_documento_traslado_subtotal");
        builder.Property(e => e.DocDocumentoTrasladoSubtotalPlaneado).HasColumnName("doc_documento_traslado_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteEsCliente).HasColumnName("doc_documento_traslado_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_traslado_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteEsFabricante).HasColumnName("doc_documento_traslado_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteEsProspecto).HasColumnName("doc_documento_traslado_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteEsProveedor).HasColumnName("doc_documento_traslado_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteEsTransportador).HasColumnName("doc_documento_traslado_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_traslado_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_traslado_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteIdZona).HasColumnName("doc_documento_traslado_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorEsCliente).HasColumnName("doc_documento_traslado_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_traslado_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_traslado_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_traslado_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_traslado_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_traslado_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_traslado_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_traslado_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorIdZona).HasColumnName("doc_documento_traslado_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoTrasladoTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_traslado_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoTrasladoTotal).HasColumnName("doc_documento_traslado_total");
        builder.Property(e => e.DocDocumentoTrasladoTotalPlaneado).HasColumnName("doc_documento_traslado_totalPlaneado");
        builder.Property(e => e.DocDocumentoTrasladoTrm).HasColumnName("doc_documento_traslado_trm");
        builder.Property(e => e.DocumentoTraslado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.traslado");
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
        builder.Property(e => e.GenBodegaDestinoBodega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_bodega_destino_bodega");
        builder.Property(e => e.GenBodegaDestinoBodegaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_bodega_destino_bodega_codigo");
        builder.Property(e => e.GenBodegaDestinoIdSucursal).HasColumnName("gen_bodega_destino_id_sucursal");
        builder.Property(e => e.GenBodegaDestinoSalidasEnRojo).HasColumnName("gen_bodega_destino_salidasEnRojo");
        builder.Property(e => e.GenBodegaDestinoUsaLocalizacion).HasColumnName("gen_bodega_destino_usaLocalizacion");
        builder.Property(e => e.GenBodegaOrigenBodega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_bodega_origen_bodega");
        builder.Property(e => e.GenBodegaOrigenBodegaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_bodega_origen_bodega_codigo");
        builder.Property(e => e.GenBodegaOrigenIdSucursal).HasColumnName("gen_bodega_origen_id_sucursal");
        builder.Property(e => e.GenBodegaOrigenSalidasEnRojo).HasColumnName("gen_bodega_origen_salidasEnRojo");
        builder.Property(e => e.GenBodegaOrigenUsaLocalizacion).HasColumnName("gen_bodega_origen_usaLocalizacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdBodegaDestino).HasColumnName("id_bodega_destino");
        builder.Property(e => e.IdBodegaOrigen).HasColumnName("id_bodega_origen");
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
