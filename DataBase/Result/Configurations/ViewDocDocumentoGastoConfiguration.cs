using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoGastoConfiguration : IEntityTypeConfiguration<ViewDocDocumentoGasto>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoGasto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_gasto");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Concepto)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("concepto");
        builder.Property(e => e.Consignado).HasColumnName("consignado");
        builder.Property(e => e.Dias).HasColumnName("dias");
        builder.Property(e => e.DocDocumentoGastoCosto).HasColumnName("doc_documento_gasto_costo");
        builder.Property(e => e.DocDocumentoGastoCostoPlaneado).HasColumnName("doc_documento_gasto_costoPlaneado");
        builder.Property(e => e.DocDocumentoGastoDescuento).HasColumnName("doc_documento_gasto_descuento");
        builder.Property(e => e.DocDocumentoGastoDescuentoPlaneado).HasColumnName("doc_documento_gasto_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreCosto).HasColumnName("doc_documento_gasto_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_gasto_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreDescuento).HasColumnName("doc_documento_gasto_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_gasto_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_gasto_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_gasto_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_gasto_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_gasto_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_gasto_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_gasto_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_gasto_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_gasto_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_gasto_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_gasto_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_gasto_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIva).HasColumnName("doc_documento_gasto_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_gasto_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_gasto_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreSubtotal).HasColumnName("doc_documento_gasto_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_gasto_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreTotal).HasColumnName("doc_documento_gasto_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_gasto_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoGastoDocDocumentoPadreTrm).HasColumnName("doc_documento_gasto_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoMotivoObligatorio).HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_motivoObligatorio");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoObservacionesObligatorio).HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_observacionesObligatorio");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoGastoDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_gasto_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoGastoDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_gasto_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoGastoDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoGastoDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoGastoDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_gasto_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoGastoDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_gasto_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoGastoDocPrioridadDocumentoOrden).HasColumnName("doc_documento_gasto_doc_prioridadDocumento_orden");
        builder.Property(e => e.DocDocumentoGastoDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoGastoDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoGastoDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_gasto_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoEjecutaDevolucion).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_ejecutaDevolucion");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoTipoCobro).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_tipoCobro");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoGastoDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_gasto_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoGastoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_documento_codigo");
        builder.Property(e => e.DocDocumentoGastoDocumentoNumero).HasColumnName("doc_documento_gasto_documento_numero");
        builder.Property(e => e.DocDocumentoGastoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoGastoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fecha_fh");
        builder.Property(e => e.DocDocumentoGastoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoGastoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoGastoGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoGastoGenMonedaCambio).HasColumnName("doc_documento_gasto_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoGastoGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoGastoGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoGastoIdDocumento).HasColumnName("doc_documento_gasto_id_documento");
        builder.Property(e => e.DocDocumentoGastoIdEstadoTipoDocumento).HasColumnName("doc_documento_gasto_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoGastoIdMoneda).HasColumnName("doc_documento_gasto_id_moneda");
        builder.Property(e => e.DocDocumentoGastoIdMotivoestado).HasColumnName("doc_documento_gasto_id_motivoestado");
        builder.Property(e => e.DocDocumentoGastoIdPrioridadDocumento).HasColumnName("doc_documento_gasto_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoGastoIdSubtipoDocumento).HasColumnName("doc_documento_gasto_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoGastoIdTerceroCliente).HasColumnName("doc_documento_gasto_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoGastoIdTerceroProveedor).HasColumnName("doc_documento_gasto_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoGastoIdUsuarioAsignado).HasColumnName("doc_documento_gasto_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoGastoIdUsuarioEnUso).HasColumnName("doc_documento_gasto_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoGastoIva).HasColumnName("doc_documento_gasto_iva");
        builder.Property(e => e.DocDocumentoGastoIvaPlaneado).HasColumnName("doc_documento_gasto_ivaPlaneado");
        builder.Property(e => e.DocDocumentoGastoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_prefijo");
        builder.Property(e => e.DocDocumentoGastoRentabilidad).HasColumnName("doc_documento_gasto_rentabilidad");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_gasto_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_gasto_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_gasto_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_gasto_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_gasto_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_gasto_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_gasto_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_gasto_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_gasto_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_gasto_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_gasto_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_gasto_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoSexo).HasColumnName("doc_documento_gasto_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_gasto_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_gasto_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_gasto_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_gasto_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_gasto_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_gasto_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_gasto_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_gasto_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_gasto_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_gasto_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_gasto_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_gasto_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoSexo).HasColumnName("doc_documento_gasto_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoGastoSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoGastoSubtotal).HasColumnName("doc_documento_gasto_subtotal");
        builder.Property(e => e.DocDocumentoGastoSubtotalPlaneado).HasColumnName("doc_documento_gasto_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteEsCliente).HasColumnName("doc_documento_gasto_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_gasto_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteEsFabricante).HasColumnName("doc_documento_gasto_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteEsProspecto).HasColumnName("doc_documento_gasto_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteEsProveedor).HasColumnName("doc_documento_gasto_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteEsTransportador).HasColumnName("doc_documento_gasto_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_gasto_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_gasto_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteIdZona).HasColumnName("doc_documento_gasto_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoGastoTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorEsCliente).HasColumnName("doc_documento_gasto_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_gasto_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_gasto_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_gasto_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_gasto_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_gasto_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_gasto_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_gasto_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorIdZona).HasColumnName("doc_documento_gasto_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoGastoTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoGastoTotal).HasColumnName("doc_documento_gasto_total");
        builder.Property(e => e.DocDocumentoGastoTotalPlaneado).HasColumnName("doc_documento_gasto_totalPlaneado");
        builder.Property(e => e.DocDocumentoGastoTrm).HasColumnName("doc_documento_gasto_trm");
        builder.Property(e => e.DocumentoGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.gasto");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioSolicitante).HasColumnName("id_usuario_solicitante");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.SegUsuarioSolicitanteAccesoActivo).HasColumnName("seg_usuario_solicitante_accesoActivo");
        builder.Property(e => e.SegUsuarioSolicitanteAplicaRecargo).HasColumnName("seg_usuario_solicitante_aplicaRecargo");
        builder.Property(e => e.SegUsuarioSolicitanteCambiarClave).HasColumnName("seg_usuario_solicitante_cambiarClave");
        builder.Property(e => e.SegUsuarioSolicitanteClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_clave");
        builder.Property(e => e.SegUsuarioSolicitanteCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_solicitante_costoHora");
        builder.Property(e => e.SegUsuarioSolicitanteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_direccion");
        builder.Property(e => e.SegUsuarioSolicitanteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_email");
        builder.Property(e => e.SegUsuarioSolicitanteFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_solicitante_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioSolicitanteFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_solicitante_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioSolicitanteFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_solicitante_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioSolicitanteHabilitado).HasColumnName("seg_usuario_solicitante_habilitado");
        builder.Property(e => e.SegUsuarioSolicitanteIdCargo).HasColumnName("seg_usuario_solicitante_id_cargo");
        builder.Property(e => e.SegUsuarioSolicitanteIdGrupo).HasColumnName("seg_usuario_solicitante_id_grupo");
        builder.Property(e => e.SegUsuarioSolicitanteIdPerfil).HasColumnName("seg_usuario_solicitante_id_perfil");
        builder.Property(e => e.SegUsuarioSolicitanteIdUsuario).HasColumnName("seg_usuario_solicitante_id_usuario");
        builder.Property(e => e.SegUsuarioSolicitanteIdZona).HasColumnName("seg_usuario_solicitante_id_zona");
        builder.Property(e => e.SegUsuarioSolicitanteIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_identificacion");
        builder.Property(e => e.SegUsuarioSolicitanteIntentosFallidos).HasColumnName("seg_usuario_solicitante_intentosFallidos");
        builder.Property(e => e.SegUsuarioSolicitanteNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_nombre");
        builder.Property(e => e.SegUsuarioSolicitanteNumeroIngresos).HasColumnName("seg_usuario_solicitante_numeroIngresos");
        builder.Property(e => e.SegUsuarioSolicitantePorcentajeComision).HasColumnName("seg_usuario_solicitante_porcentajeComision");
        builder.Property(e => e.SegUsuarioSolicitantePreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_solicitante_preferencias");
        builder.Property(e => e.SegUsuarioSolicitanteProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_profesion");
        builder.Property(e => e.SegUsuarioSolicitanteSexo).HasColumnName("seg_usuario_solicitante_sexo");
        builder.Property(e => e.SegUsuarioSolicitanteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_telefono");
        builder.Property(e => e.SegUsuarioSolicitanteUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_usuario");
        builder.Property(e => e.SegUsuarioSolicitanteUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_usuario_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
