using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoProyectoConfiguration : IEntityTypeConfiguration<ViewDocDocumentoProyecto>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoProyecto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_proyecto");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(2000)
            .IsUnicode(false)
            .HasColumnName("descripcion");
        builder.Property(e => e.DocDocumentoProyectoCosto).HasColumnName("doc_documento_proyecto_costo");
        builder.Property(e => e.DocDocumentoProyectoCostoPlaneado).HasColumnName("doc_documento_proyecto_costoPlaneado");
        builder.Property(e => e.DocDocumentoProyectoDescuento).HasColumnName("doc_documento_proyecto_descuento");
        builder.Property(e => e.DocDocumentoProyectoDescuentoPlaneado).HasColumnName("doc_documento_proyecto_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreCosto).HasColumnName("doc_documento_proyecto_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_proyecto_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreDescuento).HasColumnName("doc_documento_proyecto_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_proyecto_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_proyecto_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_proyecto_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_proyecto_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_proyecto_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_proyecto_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_proyecto_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_proyecto_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_proyecto_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_proyecto_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_proyecto_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_proyecto_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIva).HasColumnName("doc_documento_proyecto_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_proyecto_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_proyecto_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreSubtotal).HasColumnName("doc_documento_proyecto_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_proyecto_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreTotal).HasColumnName("doc_documento_proyecto_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_proyecto_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoProyectoDocDocumentoPadreTrm).HasColumnName("doc_documento_proyecto_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoProyectoDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_proyecto_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoProyectoDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_proyecto_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoProyectoDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoProyectoDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoProyectoDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_proyecto_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoProyectoDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_proyecto_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_proyecto_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoProyectoDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_proyecto_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoProyectoDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_proyecto_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoProyectoDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoProyectoDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_proyecto_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoProyectoDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_proyecto_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocPrioridadDocumentoOrden).HasColumnName("doc_documento_proyecto_doc_prioridadDocumento_orden");
        builder.Property(e => e.DocDocumentoProyectoDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoProyectoDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_proyecto_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoProyectoDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_proyecto_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoProyectoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_documento_codigo");
        builder.Property(e => e.DocDocumentoProyectoDocumentoNumero).HasColumnName("doc_documento_proyecto_documento_numero");
        builder.Property(e => e.DocDocumentoProyectoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoProyectoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_fecha_fh");
        builder.Property(e => e.DocDocumentoProyectoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoProyectoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoProyectoGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoProyectoGenMonedaCambio).HasColumnName("doc_documento_proyecto_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoProyectoGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoProyectoGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoProyectoIdDocumento).HasColumnName("doc_documento_proyecto_id_documento");
        builder.Property(e => e.DocDocumentoProyectoIdEstadoTipoDocumento).HasColumnName("doc_documento_proyecto_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoIdMoneda).HasColumnName("doc_documento_proyecto_id_moneda");
        builder.Property(e => e.DocDocumentoProyectoIdMotivoestado).HasColumnName("doc_documento_proyecto_id_motivoestado");
        builder.Property(e => e.DocDocumentoProyectoIdPrioridadDocumento).HasColumnName("doc_documento_proyecto_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoProyectoIdSubtipoDocumento).HasColumnName("doc_documento_proyecto_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoIdTerceroCliente).HasColumnName("doc_documento_proyecto_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoProyectoIdTerceroProveedor).HasColumnName("doc_documento_proyecto_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoProyectoIdUsuarioAsignado).HasColumnName("doc_documento_proyecto_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoProyectoIdUsuarioEnUso).HasColumnName("doc_documento_proyecto_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoProyectoIva).HasColumnName("doc_documento_proyecto_iva");
        builder.Property(e => e.DocDocumentoProyectoIvaPlaneado).HasColumnName("doc_documento_proyecto_ivaPlaneado");
        builder.Property(e => e.DocDocumentoProyectoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_prefijo");
        builder.Property(e => e.DocDocumentoProyectoRentabilidad).HasColumnName("doc_documento_proyecto_rentabilidad");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoSexo).HasColumnName("doc_documento_proyecto_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoSexo).HasColumnName("doc_documento_proyecto_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoProyectoSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoProyectoSubtotal).HasColumnName("doc_documento_proyecto_subtotal");
        builder.Property(e => e.DocDocumentoProyectoSubtotalPlaneado).HasColumnName("doc_documento_proyecto_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteEsCliente).HasColumnName("doc_documento_proyecto_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_proyecto_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteEsFabricante).HasColumnName("doc_documento_proyecto_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteEsProspecto).HasColumnName("doc_documento_proyecto_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteEsProveedor).HasColumnName("doc_documento_proyecto_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteEsTransportador).HasColumnName("doc_documento_proyecto_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_proyecto_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_proyecto_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteIdZona).HasColumnName("doc_documento_proyecto_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorEsCliente).HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorIdZona).HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoProyectoTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoProyectoTotal).HasColumnName("doc_documento_proyecto_total");
        builder.Property(e => e.DocDocumentoProyectoTotalPlaneado).HasColumnName("doc_documento_proyecto_totalPlaneado");
        builder.Property(e => e.DocDocumentoProyectoTrm).HasColumnName("doc_documento_proyecto_trm");
        builder.Property(e => e.DocumentoProyecto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.proyecto");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinEstimada)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFinEstimada");
        builder.Property(e => e.FechaInicioEstimada)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioEstimada");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Nombre)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("nombre");
        builder.Property(e => e.Presupuesto)
            .HasColumnType("money")
            .HasColumnName("presupuesto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
