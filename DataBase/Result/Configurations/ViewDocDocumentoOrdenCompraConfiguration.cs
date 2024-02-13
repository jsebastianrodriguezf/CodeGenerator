using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoOrdenCompraConfiguration : IEntityTypeConfiguration<ViewDocDocumentoOrdenCompra>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoOrdenCompra> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_ordenCompra");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Asunto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("asunto");
        builder.Property(e => e.DireccionEntrega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("direccionEntrega");
        builder.Property(e => e.DocDocumentoOrdenCompraCosto).HasColumnName("doc_documento_ordenCompra_costo");
        builder.Property(e => e.DocDocumentoOrdenCompraCostoPlaneado).HasColumnName("doc_documento_ordenCompra_costoPlaneado");
        builder.Property(e => e.DocDocumentoOrdenCompraDescuento).HasColumnName("doc_documento_ordenCompra_descuento");
        builder.Property(e => e.DocDocumentoOrdenCompraDescuentoPlaneado).HasColumnName("doc_documento_ordenCompra_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreCosto).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreDescuento).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIdDocumento).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIdMoneda).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIva).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreRentabilidad).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreSubtotal).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreTotal).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoOrdenCompraDocDocumentoPadreTrm).HasColumnName("doc_documento_ordenCompra_doc_documento_padre_trm");
        builder.Property(e => e.DocDocumentoOrdenCompraDocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_documento_ordenCompra_doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocDocumentoOrdenCompraDocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_documento_ordenCompra_doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocDocumentoOrdenCompraDocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocDocumentoOrdenCompraDocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocDocumentoOrdenCompraDocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_documento_ordenCompra_doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraDocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_ordenCompra_doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocEstadoTipoDocumentoOrden).HasColumnName("doc_documento_ordenCompra_doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocDocumentoOrdenCompraDocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_documento_ordenCompra_doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocDocumentoOrdenCompraDocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_documento_ordenCompra_doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_motivoestado_motivoestado");
        builder.Property(e => e.DocDocumentoOrdenCompraDocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraDocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_documento_ordenCompra_doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocDocumentoOrdenCompraDocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_documento_ordenCompra_doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocPrioridadDocumentoOrden).HasColumnName("doc_documento_ordenCompra_doc_prioridadDocumento_orden");
        builder.Property(e => e.DocDocumentoOrdenCompraDocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraDocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_documento_ordenCompra_doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoCerrarSol).HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoConsecutivo).HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoValUrgente).HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocDocumentoOrdenCompraDocSubtipoDocumentoVerIncoterm).HasColumnName("doc_documento_ordenCompra_doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.DocDocumentoOrdenCompraDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_documento_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraDocumentoNumero).HasColumnName("doc_documento_ordenCompra_documento_numero");
        builder.Property(e => e.DocDocumentoOrdenCompraFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoOrdenCompraFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_fecha_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraGenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_gen_moneda_abreviatura");
        builder.Property(e => e.DocDocumentoOrdenCompraGenMonedaCambio).HasColumnName("doc_documento_ordenCompra_gen_moneda_cambio");
        builder.Property(e => e.DocDocumentoOrdenCompraGenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_gen_moneda_moneda");
        builder.Property(e => e.DocDocumentoOrdenCompraGenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_gen_moneda_moneda_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraIdDocumento).HasColumnName("doc_documento_ordenCompra_id_documento");
        builder.Property(e => e.DocDocumentoOrdenCompraIdEstadoTipoDocumento).HasColumnName("doc_documento_ordenCompra_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraIdMoneda).HasColumnName("doc_documento_ordenCompra_id_moneda");
        builder.Property(e => e.DocDocumentoOrdenCompraIdMotivoestado).HasColumnName("doc_documento_ordenCompra_id_motivoestado");
        builder.Property(e => e.DocDocumentoOrdenCompraIdPrioridadDocumento).HasColumnName("doc_documento_ordenCompra_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraIdSubtipoDocumento).HasColumnName("doc_documento_ordenCompra_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoOrdenCompraIdTerceroCliente).HasColumnName("doc_documento_ordenCompra_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoOrdenCompraIdTerceroProveedor).HasColumnName("doc_documento_ordenCompra_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoOrdenCompraIdUsuarioAsignado).HasColumnName("doc_documento_ordenCompra_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoOrdenCompraIdUsuarioEnUso).HasColumnName("doc_documento_ordenCompra_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoOrdenCompraIva).HasColumnName("doc_documento_ordenCompra_iva");
        builder.Property(e => e.DocDocumentoOrdenCompraIvaPlaneado).HasColumnName("doc_documento_ordenCompra_ivaPlaneado");
        builder.Property(e => e.DocDocumentoOrdenCompraPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_prefijo");
        builder.Property(e => e.DocDocumentoOrdenCompraRentabilidad).HasColumnName("doc_documento_ordenCompra_rentabilidad");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoAccesoActivo).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoAplicaRecargo).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoCambiarClave).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_clave");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_costoHora");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_direccion");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_email");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoHabilitado).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_habilitado");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoIdCargo).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_id_cargo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoIdGrupo).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_id_grupo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoIdPerfil).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_id_perfil");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoIdUsuario).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_id_usuario");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoIdZona).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_id_zona");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_identificacion");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoIntentosFallidos).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_nombre");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoNumeroIngresos).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoPorcentajeComision).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_preferencias");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_profesion");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoSexo).HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_sexo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_telefono");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_usuario");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoAccesoActivo).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoAplicaRecargo).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoCambiarClave).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_clave");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_costoHora");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_direccion");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_email");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoHabilitado).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_habilitado");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoIdCargo).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_id_cargo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoIdGrupo).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_id_grupo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoIdPerfil).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_id_perfil");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoIdUsuario).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_id_usuario");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoIdZona).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_id_zona");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_identificacion");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoIntentosFallidos).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_nombre");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoNumeroIngresos).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoPorcentajeComision).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_preferencias");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_profesion");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoSexo).HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_sexo");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_telefono");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_usuario");
        builder.Property(e => e.DocDocumentoOrdenCompraSegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraSubtotal).HasColumnName("doc_documento_ordenCompra_subtotal");
        builder.Property(e => e.DocDocumentoOrdenCompraSubtotalPlaneado).HasColumnName("doc_documento_ordenCompra_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_clasificacion");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_contacto");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_direccion");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_email");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteEsCliente).HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_esCliente");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteEsEmpresaPropia).HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteEsFabricante).HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_esFabricante");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteEsProspecto).HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_esProspecto");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteEsProveedor).HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_esProveedor");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteEsTransportador).HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_esTransportador");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_fax");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteIdEstadoTercero).HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteIdNaturalezaTercero).HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteIdZona).HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_id_zona");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_notas");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_representante");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_telefono");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_tercero");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_cliente_website");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_contacto");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_direccion");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_email");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorEsCliente).HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_esCliente");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorEsEmpresaPropia).HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorEsFabricante).HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorEsProspecto).HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorEsProveedor).HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorEsTransportador).HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_fax");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorIdEstadoTercero).HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorIdNaturalezaTercero).HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorIdZona).HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_id_zona");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_notas");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_representante");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_telefono");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_tercero");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.DocDocumentoOrdenCompraTerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ordenCompra_ter_tercero_proveedor_website");
        builder.Property(e => e.DocDocumentoOrdenCompraTotal).HasColumnName("doc_documento_ordenCompra_total");
        builder.Property(e => e.DocDocumentoOrdenCompraTotalPlaneado).HasColumnName("doc_documento_ordenCompra_totalPlaneado");
        builder.Property(e => e.DocDocumentoOrdenCompraTrm).HasColumnName("doc_documento_ordenCompra_trm");
        builder.Property(e => e.DocFormaPagoFormaPago)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_formaPago_formaPago");
        builder.Property(e => e.DocFormaPagoFormaPagoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_formaPago_formaPago_codigo");
        builder.Property(e => e.DocFormapagoDiaspago).HasColumnName("doc_formapago_diaspago");
        builder.Property(e => e.DocumentoOrdenCompra)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.ordenCompra");
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
        builder.Property(e => e.FechaPagoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaPago_ff");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdFormaPago).HasColumnName("id_formaPago");
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
