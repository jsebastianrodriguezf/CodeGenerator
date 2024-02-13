using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoEntradumConfiguration : IEntityTypeConfiguration<ViewDocDocumentoEntradum>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoEntradum> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_entrada");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Asunto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("asunto");
        builder.Property(e => e.DireccionEntrega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("direccionEntrega");
        builder.Property(e => e.DocDocumentoEntradaCosto).HasColumnName("doc_documento_entrada_costo");
        builder.Property(e => e.DocDocumentoEntradaCostoPlaneado).HasColumnName("doc_documento_entrada_costoPlaneado");
        builder.Property(e => e.DocDocumentoEntradaDescuento).HasColumnName("doc_documento_entrada_descuento");
        builder.Property(e => e.DocDocumentoEntradaDescuentoPlaneado).HasColumnName("doc_documento_entrada_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreCosto).HasColumnName("doc_documento_entrada_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_entrada_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreDescuento).HasColumnName("doc_documento_entrada_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_entrada_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_entrada_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_entrada_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_entrada_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_entrada_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_entrada_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_entrada_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_entrada_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_entrada_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_entrada_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_entrada_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_entrada_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIva).HasColumnName("doc_documento_entrada_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_entrada_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_entrada_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreSubtotal).HasColumnName("doc_documento_entrada_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_entrada_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreTotal).HasColumnName("doc_documento_entrada_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_entrada_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoEntradaDocDocumentoPadreTrm).HasColumnName("doc_documento_entrada_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoEntradaDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_entrada_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoEntradaDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_entrada_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoEntradaDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoEntradaDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoEntradaDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_entrada_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoEntradaDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_entrada_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_entrada_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoEntradaDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_entrada_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoEntradaDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_entrada_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoEntradaDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoEntradaDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_entrada_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoEntradaDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_entrada_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoEntradaDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_entrada_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_entrada_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_entrada_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_entrada_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_entrada_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_entrada_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_entrada_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoTipoCobro).HasColumnName("doc_documento_entrada_doc_subtipoDocumento_tipoCobro");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_entrada_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_entrada_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoEntradaDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_entrada_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoEntradaDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_documento_codigo");
        builder.Property(e => e.DocDocumentoEntradaDocumentoNumero).HasColumnName("doc_documento_entrada_documento_numero");
        builder.Property(e => e.DocDocumentoEntradaFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoEntradaFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_fecha_fh");
        builder.Property(e => e.DocDocumentoEntradaFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoEntradaFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoEntradaGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoEntradaGenMonedaCambio).HasColumnName("doc_documento_entrada_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoEntradaGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoEntradaGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoEntradaIdDocumento).HasColumnName("doc_documento_entrada_id_documento");
        builder.Property(e => e.DocDocumentoEntradaIdEstadoTipoDocumento).HasColumnName("doc_documento_entrada_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoEntradaIdMoneda).HasColumnName("doc_documento_entrada_id_moneda");
        builder.Property(e => e.DocDocumentoEntradaIdMotivoestado).HasColumnName("doc_documento_entrada_id_motivoestado");
        builder.Property(e => e.DocDocumentoEntradaIdPrioridadDocumento).HasColumnName("doc_documento_entrada_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoEntradaIdSubtipoDocumento).HasColumnName("doc_documento_entrada_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoEntradaIdTerceroCliente).HasColumnName("doc_documento_entrada_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoEntradaIdTerceroProveedor).HasColumnName("doc_documento_entrada_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoEntradaIdUsuarioAsignado).HasColumnName("doc_documento_entrada_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoEntradaIdUsuarioEnUso).HasColumnName("doc_documento_entrada_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoEntradaIva).HasColumnName("doc_documento_entrada_iva");
        builder.Property(e => e.DocDocumentoEntradaIvaPlaneado).HasColumnName("doc_documento_entrada_ivaPlaneado");
        builder.Property(e => e.DocDocumentoEntradaPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_prefijo");
        builder.Property(e => e.DocDocumentoEntradaRentabilidad).HasColumnName("doc_documento_entrada_rentabilidad");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_entrada_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_entrada_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_entrada_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_entrada_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_entrada_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_entrada_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_entrada_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_entrada_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_entrada_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_entrada_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_entrada_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_entrada_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoSexo).HasColumnName("doc_documento_entrada_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_entrada_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_entrada_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_entrada_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_entrada_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_entrada_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_entrada_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_entrada_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_entrada_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_entrada_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_entrada_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_entrada_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_entrada_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoSexo).HasColumnName("doc_documento_entrada_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoEntradaSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoEntradaSubtotal).HasColumnName("doc_documento_entrada_subtotal");
        builder.Property(e => e.DocDocumentoEntradaSubtotalPlaneado).HasColumnName("doc_documento_entrada_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteEsCliente).HasColumnName("doc_documento_entrada_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_entrada_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteEsFabricante).HasColumnName("doc_documento_entrada_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteEsProspecto).HasColumnName("doc_documento_entrada_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteEsProveedor).HasColumnName("doc_documento_entrada_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteEsTransportador).HasColumnName("doc_documento_entrada_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_entrada_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_entrada_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteIdZona).HasColumnName("doc_documento_entrada_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorEsCliente).HasColumnName("doc_documento_entrada_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_entrada_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_entrada_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_entrada_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_entrada_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_entrada_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_entrada_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_entrada_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorIdZona).HasColumnName("doc_documento_entrada_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoEntradaTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_entrada_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoEntradaTotal).HasColumnName("doc_documento_entrada_total");
        builder.Property(e => e.DocDocumentoEntradaTotalPlaneado).HasColumnName("doc_documento_entrada_totalPlaneado");
        builder.Property(e => e.DocDocumentoEntradaTrm).HasColumnName("doc_documento_entrada_trm");
        builder.Property(e => e.DocumentoEntrada)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.entrada");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsPorAjuste).HasColumnName("esPorAjuste");
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
