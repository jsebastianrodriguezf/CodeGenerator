using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoConfiguration : IEntityTypeConfiguration<ViewDocDocumento>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Costo).HasColumnName("costo");
        builder.Property(e => e.CostoPlaneado).HasColumnName("costoPlaneado");
        builder.Property(e => e.Descuento).HasColumnName("descuento");
        builder.Property(e => e.DescuentoPlaneado).HasColumnName("descuentoPlaneado");
        builder.Property(e => e.DocDocumentoPadreCosto).HasColumnName("doc_documento_padre_costo");
        builder.Property(e => e.DocDocumentoPadreCostoPlaneado).HasColumnName("doc_documento_padre_costoPlaneado");
        builder.Property(e => e.DocDocumentoPadreDescuento).HasColumnName("doc_documento_padre_descuento");
        builder.Property(e => e.DocDocumentoPadreDescuentoPlaneado).HasColumnName("doc_documento_padre_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoPadreDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_padre_documento");
        builder.Property(e => e.DocDocumentoPadreDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_padre_documento_codigo");
        builder.Property(e => e.DocDocumentoPadreDocumentoNumero).HasColumnName("doc_documento_padre_documento_numero");
        builder.Property(e => e.DocDocumentoPadreFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_padre_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoPadreFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_padre_fecha_fh");
        builder.Property(e => e.DocDocumentoPadreFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_padre_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoPadreFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_padre_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoPadreIdDocumento).HasColumnName("doc_documento_padre_id_documento");
        builder.Property(e => e.DocDocumentoPadreIdEstadoTipoDocumento).HasColumnName("doc_documento_padre_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoPadreIdMoneda).HasColumnName("doc_documento_padre_id_moneda");
        builder.Property(e => e.DocDocumentoPadreIdMotivoestado).HasColumnName("doc_documento_padre_id_motivoestado");
        builder.Property(e => e.DocDocumentoPadreIdPrioridadDocumento).HasColumnName("doc_documento_padre_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoPadreIdSubtipoDocumento).HasColumnName("doc_documento_padre_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoPadreIdTerceroCliente).HasColumnName("doc_documento_padre_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoPadreIdTerceroProveedor).HasColumnName("doc_documento_padre_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoPadreIdUsuarioAsignado).HasColumnName("doc_documento_padre_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoPadreIdUsuarioEnUso).HasColumnName("doc_documento_padre_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoPadreIva).HasColumnName("doc_documento_padre_iva");
        builder.Property(e => e.DocDocumentoPadreIvaPlaneado).HasColumnName("doc_documento_padre_ivaPlaneado");
        builder.Property(e => e.DocDocumentoPadrePrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_padre_prefijo");
        builder.Property(e => e.DocDocumentoPadreRentabilidad).HasColumnName("doc_documento_padre_rentabilidad");
        builder.Property(e => e.DocDocumentoPadreSubtotal).HasColumnName("doc_documento_padre_subtotal");
        builder.Property(e => e.DocDocumentoPadreSubtotalPlaneado).HasColumnName("doc_documento_padre_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoPadreTotal).HasColumnName("doc_documento_padre_total");
        builder.Property(e => e.DocDocumentoPadreTotalPlaneado).HasColumnName("doc_documento_padre_totalPlaneado");
        builder.Property(e => e.DocDocumentoPadreTrm).HasColumnName("doc_documento_padre_trm");
        builder.Property(e => e.DocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoMotivoObligatorio).HasColumnName("doc_estadoTipoDocumento_motivoObligatorio");
        builder.Property(e => e.DocEstadoTipoDocumentoObservacionesObligatorio).HasColumnName("doc_estadoTipoDocumento_observacionesObligatorio");
        builder.Property(e => e.DocEstadoTipoDocumentoOrden).HasColumnName("doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.DocMotivoestadoIdEstadoTipoDocumento).HasColumnName("doc_motivoestado_id_estadoTipoDocumento");
        builder.Property(e => e.DocMotivoestadoMotivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_motivoestado_motivoestado");
        builder.Property(e => e.DocMotivoestadoMotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_motivoestado_motivoestado_codigo");
        builder.Property(e => e.DocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocPrioridadDocumentoOrden).HasColumnName("doc_prioridadDocumento_orden");
        builder.Property(e => e.DocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocSubtipoDocumentoArchivosAdjuntosApp).HasColumnName("doc_subtipoDocumento_archivosAdjuntosApp");
        builder.Property(e => e.DocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocSubtipoDocumentoCantidadAuxiliar).HasColumnName("doc_subtipoDocumento_cantidadAuxiliar");
        builder.Property(e => e.DocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocSubtipoDocumentoCerrarSol).HasColumnName("doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocSubtipoDocumentoConsecutivo).HasColumnName("doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocSubtipoDocumentoEjecutaDevolucion).HasColumnName("doc_subtipoDocumento_ejecutaDevolucion");
        builder.Property(e => e.DocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoMostrarPendienteDocumento).HasColumnName("doc_subtipoDocumento_mostrarPendienteDocumento");
        builder.Property(e => e.DocSubtipoDocumentoMostrarValoresEjecutados).HasColumnName("doc_subtipoDocumento_mostrarValoresEjecutados");
        builder.Property(e => e.DocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocSubtipoDocumentoTipoCobro).HasColumnName("doc_subtipoDocumento_tipoCobro");
        builder.Property(e => e.DocSubtipoDocumentoValUrgente).HasColumnName("doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocSubtipoDocumentoVerIncoterm).HasColumnName("doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.Documento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento");
        builder.Property(e => e.DocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("documento_codigo");
        builder.Property(e => e.DocumentoNumero).HasColumnName("documento_numero");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCierre_ff");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_fh");
        builder.Property(e => e.FechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaLimite_fh");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaSugerida_fh");
        builder.Property(e => e.GenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("gen_moneda_abreviatura");
        builder.Property(e => e.GenMonedaCambio).HasColumnName("gen_moneda_cambio");
        builder.Property(e => e.GenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_moneda_moneda");
        builder.Property(e => e.GenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_moneda_moneda_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdMoneda).HasColumnName("id_moneda");
        builder.Property(e => e.IdMotivoestado).HasColumnName("id_motivoestado");
        builder.Property(e => e.IdPrioridadDocumento).HasColumnName("id_prioridadDocumento");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdTerceroCliente).HasColumnName("id_tercero_cliente");
        builder.Property(e => e.IdTerceroProveedor).HasColumnName("id_tercero_proveedor");
        builder.Property(e => e.IdUsuarioAsignado).HasColumnName("id_usuario_asignado");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioEnUso).HasColumnName("id_usuario_enUso");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Iva).HasColumnName("iva");
        builder.Property(e => e.IvaPlaneado).HasColumnName("ivaPlaneado");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Prefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("prefijo");
        builder.Property(e => e.Rentabilidad).HasColumnName("rentabilidad");
        builder.Property(e => e.SegUsuarioAsignadoAccesoActivo).HasColumnName("seg_usuario_asignado_accesoActivo");
        builder.Property(e => e.SegUsuarioAsignadoAplicaRecargo).HasColumnName("seg_usuario_asignado_aplicaRecargo");
        builder.Property(e => e.SegUsuarioAsignadoCambiarClave).HasColumnName("seg_usuario_asignado_cambiarClave");
        builder.Property(e => e.SegUsuarioAsignadoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asignado_clave");
        builder.Property(e => e.SegUsuarioAsignadoCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_asignado_costoHora");
        builder.Property(e => e.SegUsuarioAsignadoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asignado_direccion");
        builder.Property(e => e.SegUsuarioAsignadoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asignado_email");
        builder.Property(e => e.SegUsuarioAsignadoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_asignado_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioAsignadoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_asignado_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioAsignadoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_asignado_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioAsignadoHabilitado).HasColumnName("seg_usuario_asignado_habilitado");
        builder.Property(e => e.SegUsuarioAsignadoIdCargo).HasColumnName("seg_usuario_asignado_id_cargo");
        builder.Property(e => e.SegUsuarioAsignadoIdDispositivo)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asignado_idDispositivo");
        builder.Property(e => e.SegUsuarioAsignadoIdGrupo).HasColumnName("seg_usuario_asignado_id_grupo");
        builder.Property(e => e.SegUsuarioAsignadoIdPerfil).HasColumnName("seg_usuario_asignado_id_perfil");
        builder.Property(e => e.SegUsuarioAsignadoIdUsuario).HasColumnName("seg_usuario_asignado_id_usuario");
        builder.Property(e => e.SegUsuarioAsignadoIdZona).HasColumnName("seg_usuario_asignado_id_zona");
        builder.Property(e => e.SegUsuarioAsignadoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asignado_identificacion");
        builder.Property(e => e.SegUsuarioAsignadoIntentosFallidos).HasColumnName("seg_usuario_asignado_intentosFallidos");
        builder.Property(e => e.SegUsuarioAsignadoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asignado_nombre");
        builder.Property(e => e.SegUsuarioAsignadoNumeroIngresos).HasColumnName("seg_usuario_asignado_numeroIngresos");
        builder.Property(e => e.SegUsuarioAsignadoPorcentajeComision).HasColumnName("seg_usuario_asignado_porcentajeComision");
        builder.Property(e => e.SegUsuarioAsignadoPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_asignado_preferencias");
        builder.Property(e => e.SegUsuarioAsignadoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asignado_profesion");
        builder.Property(e => e.SegUsuarioAsignadoSexo).HasColumnName("seg_usuario_asignado_sexo");
        builder.Property(e => e.SegUsuarioAsignadoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asignado_telefono");
        builder.Property(e => e.SegUsuarioAsignadoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asignado_usuario");
        builder.Property(e => e.SegUsuarioAsignadoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asignado_usuario_codigo");
        builder.Property(e => e.SegUsuarioEnUsoAccesoActivo).HasColumnName("seg_usuario_enUso_accesoActivo");
        builder.Property(e => e.SegUsuarioEnUsoAplicaRecargo).HasColumnName("seg_usuario_enUso_aplicaRecargo");
        builder.Property(e => e.SegUsuarioEnUsoCambiarClave).HasColumnName("seg_usuario_enUso_cambiarClave");
        builder.Property(e => e.SegUsuarioEnUsoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_enUso_clave");
        builder.Property(e => e.SegUsuarioEnUsoCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_enUso_costoHora");
        builder.Property(e => e.SegUsuarioEnUsoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_enUso_direccion");
        builder.Property(e => e.SegUsuarioEnUsoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_enUso_email");
        builder.Property(e => e.SegUsuarioEnUsoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_enUso_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioEnUsoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_enUso_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioEnUsoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_enUso_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioEnUsoHabilitado).HasColumnName("seg_usuario_enUso_habilitado");
        builder.Property(e => e.SegUsuarioEnUsoIdCargo).HasColumnName("seg_usuario_enUso_id_cargo");
        builder.Property(e => e.SegUsuarioEnUsoIdDispositivo)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_enUso_idDispositivo");
        builder.Property(e => e.SegUsuarioEnUsoIdGrupo).HasColumnName("seg_usuario_enUso_id_grupo");
        builder.Property(e => e.SegUsuarioEnUsoIdPerfil).HasColumnName("seg_usuario_enUso_id_perfil");
        builder.Property(e => e.SegUsuarioEnUsoIdUsuario).HasColumnName("seg_usuario_enUso_id_usuario");
        builder.Property(e => e.SegUsuarioEnUsoIdZona).HasColumnName("seg_usuario_enUso_id_zona");
        builder.Property(e => e.SegUsuarioEnUsoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_enUso_identificacion");
        builder.Property(e => e.SegUsuarioEnUsoIntentosFallidos).HasColumnName("seg_usuario_enUso_intentosFallidos");
        builder.Property(e => e.SegUsuarioEnUsoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_enUso_nombre");
        builder.Property(e => e.SegUsuarioEnUsoNumeroIngresos).HasColumnName("seg_usuario_enUso_numeroIngresos");
        builder.Property(e => e.SegUsuarioEnUsoPorcentajeComision).HasColumnName("seg_usuario_enUso_porcentajeComision");
        builder.Property(e => e.SegUsuarioEnUsoPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_enUso_preferencias");
        builder.Property(e => e.SegUsuarioEnUsoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_enUso_profesion");
        builder.Property(e => e.SegUsuarioEnUsoSexo).HasColumnName("seg_usuario_enUso_sexo");
        builder.Property(e => e.SegUsuarioEnUsoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_enUso_telefono");
        builder.Property(e => e.SegUsuarioEnUsoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_enUso_usuario");
        builder.Property(e => e.SegUsuarioEnUsoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_enUso_usuario_codigo");
        builder.Property(e => e.Subtotal).HasColumnName("subtotal");
        builder.Property(e => e.SubtotalPlaneado).HasColumnName("subtotalPlaneado");
        builder.Property(e => e.TerTerceroClienteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_clasificacion");
        builder.Property(e => e.TerTerceroClienteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_contacto");
        builder.Property(e => e.TerTerceroClienteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_direccion");
        builder.Property(e => e.TerTerceroClienteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_email");
        builder.Property(e => e.TerTerceroClienteEsCliente).HasColumnName("ter_tercero_cliente_esCliente");
        builder.Property(e => e.TerTerceroClienteEsEmpresaPropia).HasColumnName("ter_tercero_cliente_esEmpresaPropia");
        builder.Property(e => e.TerTerceroClienteEsFabricante).HasColumnName("ter_tercero_cliente_esFabricante");
        builder.Property(e => e.TerTerceroClienteEsProspecto).HasColumnName("ter_tercero_cliente_esProspecto");
        builder.Property(e => e.TerTerceroClienteEsProveedor).HasColumnName("ter_tercero_cliente_esProveedor");
        builder.Property(e => e.TerTerceroClienteEsTransportador).HasColumnName("ter_tercero_cliente_esTransportador");
        builder.Property(e => e.TerTerceroClienteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_fax");
        builder.Property(e => e.TerTerceroClienteIdEstadoTercero).HasColumnName("ter_tercero_cliente_id_estadoTercero");
        builder.Property(e => e.TerTerceroClienteIdFormaPago).HasColumnName("ter_tercero_cliente_id_formaPago");
        builder.Property(e => e.TerTerceroClienteIdNaturalezaTercero).HasColumnName("ter_tercero_cliente_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroClienteIdZona).HasColumnName("ter_tercero_cliente_id_zona");
        builder.Property(e => e.TerTerceroClienteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_notas");
        builder.Property(e => e.TerTerceroClienteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_representante");
        builder.Property(e => e.TerTerceroClienteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_telefono");
        builder.Property(e => e.TerTerceroClienteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_tercero");
        builder.Property(e => e.TerTerceroClienteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_tercero_codigo");
        builder.Property(e => e.TerTerceroClienteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_tercero_nit");
        builder.Property(e => e.TerTerceroClienteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroClienteTiempoEntrega).HasColumnName("ter_tercero_cliente_tiempoEntrega");
        builder.Property(e => e.TerTerceroClienteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente_website");
        builder.Property(e => e.TerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.TerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_contacto");
        builder.Property(e => e.TerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_direccion");
        builder.Property(e => e.TerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_email");
        builder.Property(e => e.TerTerceroProveedorEsCliente).HasColumnName("ter_tercero_proveedor_esCliente");
        builder.Property(e => e.TerTerceroProveedorEsEmpresaPropia).HasColumnName("ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.TerTerceroProveedorEsFabricante).HasColumnName("ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.TerTerceroProveedorEsProspecto).HasColumnName("ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.TerTerceroProveedorEsProveedor).HasColumnName("ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.TerTerceroProveedorEsTransportador).HasColumnName("ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.TerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_fax");
        builder.Property(e => e.TerTerceroProveedorIdEstadoTercero).HasColumnName("ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.TerTerceroProveedorIdFormaPago).HasColumnName("ter_tercero_proveedor_id_formaPago");
        builder.Property(e => e.TerTerceroProveedorIdNaturalezaTercero).HasColumnName("ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroProveedorIdZona).HasColumnName("ter_tercero_proveedor_id_zona");
        builder.Property(e => e.TerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_notas");
        builder.Property(e => e.TerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_representante");
        builder.Property(e => e.TerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_telefono");
        builder.Property(e => e.TerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_tercero");
        builder.Property(e => e.TerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.TerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.TerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroProveedorTiempoEntrega).HasColumnName("ter_tercero_proveedor_tiempoEntrega");
        builder.Property(e => e.TerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_website");
        builder.Property(e => e.Total).HasColumnName("total");
        builder.Property(e => e.TotalPlaneado).HasColumnName("totalPlaneado");
        builder.Property(e => e.Trm).HasColumnName("trm");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
