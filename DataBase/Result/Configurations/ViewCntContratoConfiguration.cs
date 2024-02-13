using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCntContratoConfiguration : IEntityTypeConfiguration<ViewCntContrato>
{
    public void Configure(EntityTypeBuilder<ViewCntContrato> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cnt_contrato");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CntPeriodoContratoPeriodoContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_periodoContrato_periodoContrato");
        builder.Property(e => e.CntPeriodoContratoPeriodoContratoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cnt_periodoContrato_periodoContrato_codigo");
        builder.Property(e => e.CntTipoContratoTipoContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_tipoContrato_tipoContrato");
        builder.Property(e => e.CntTipoContratoTipoContratoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cnt_tipoContrato_tipoContrato_codigo");
        builder.Property(e => e.Condiciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("condiciones");
        builder.Property(e => e.Contrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contrato");
        builder.Property(e => e.ContratoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contrato_codigo");
        builder.Property(e => e.DiasCumplimiento).HasColumnName("diasCumplimiento");
        builder.Property(e => e.DocDocumentoAlquilerCosto).HasColumnName("doc_documento_alquiler_costo");
        builder.Property(e => e.DocDocumentoAlquilerCostoPlaneado).HasColumnName("doc_documento_alquiler_costoPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDescuento).HasColumnName("doc_documento_alquiler_descuento");
        builder.Property(e => e.DocDocumentoAlquilerDescuentoPlaneado).HasColumnName("doc_documento_alquiler_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.alquiler_documento.alquiler");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_documento_codigo");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoNumero).HasColumnName("doc_documento_alquiler_documento_numero");
        builder.Property(e => e.DocDocumentoAlquilerEjecutaDevolucion).HasColumnName("doc_documento.alquiler_ejecutaDevolucion");
        builder.Property(e => e.DocDocumentoAlquilerFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoAlquilerFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fecha_fh");
        builder.Property(e => e.DocDocumentoAlquilerFechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.alquiler_fechaFin_ff");
        builder.Property(e => e.DocDocumentoAlquilerFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoAlquilerFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaSugerida_fh");
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
        builder.Property(e => e.DocDocumentoAlquilerMesVencido).HasColumnName("doc_documento.alquiler_mesVencido");
        builder.Property(e => e.DocDocumentoAlquilerObservaciones)
            .HasMaxLength(3000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.alquiler_observaciones");
        builder.Property(e => e.DocDocumentoAlquilerPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_prefijo");
        builder.Property(e => e.DocDocumentoAlquilerRentabilidad).HasColumnName("doc_documento_alquiler_rentabilidad");
        builder.Property(e => e.DocDocumentoAlquilerSubtotal).HasColumnName("doc_documento_alquiler_subtotal");
        builder.Property(e => e.DocDocumentoAlquilerSubtotalPlaneado).HasColumnName("doc_documento_alquiler_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerTotal).HasColumnName("doc_documento_alquiler_total");
        builder.Property(e => e.DocDocumentoAlquilerTotalPlaneado).HasColumnName("doc_documento_alquiler_totalPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerTrm).HasColumnName("doc_documento_alquiler_trm");
        builder.Property(e => e.DocEstadoTipoDocumentoInicialAfectaIndicador).HasColumnName("doc_estadoTipoDocumento_inicial_afectaIndicador");
        builder.Property(e => e.DocEstadoTipoDocumentoInicialAfectaInventario).HasColumnName("doc_estadoTipoDocumento_inicial_afectaInventario");
        builder.Property(e => e.DocEstadoTipoDocumentoInicialColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_inicial_color");
        builder.Property(e => e.DocEstadoTipoDocumentoInicialDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_inicial_descripcion");
        builder.Property(e => e.DocEstadoTipoDocumentoInicialEditaDocumento).HasColumnName("doc_estadoTipoDocumento_inicial_editaDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoInicialEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_inicial_estadoTipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoInicialEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_inicial_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocEstadoTipoDocumentoInicialIdTipoDocumento).HasColumnName("doc_estadoTipoDocumento_inicial_id_tipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoInicialOrden).HasColumnName("doc_estadoTipoDocumento_inicial_orden");
        builder.Property(e => e.DocEstadoTipoDocumentoInicialPuedeRegresar).HasColumnName("doc_estadoTipoDocumento_inicial_puedeRegresar");
        builder.Property(e => e.DocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocSubtipoDocumentoCerrarSol).HasColumnName("doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocSubtipoDocumentoConsecutivo).HasColumnName("doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocSubtipoDocumentoEjecutaDevolucion).HasColumnName("doc_subtipoDocumento_ejecutaDevolucion");
        builder.Property(e => e.DocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudBloquearDespacho).HasColumnName("doc_subtipoDocumento_solicitud_bloquearDespacho");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudCargarSolicitante).HasColumnName("doc_subtipoDocumento_solicitud_cargarSolicitante");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudCerrarSol).HasColumnName("doc_subtipoDocumento_solicitud_cerrarSol");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudConsecutivo).HasColumnName("doc_subtipoDocumento_solicitud_consecutivo");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudEjecutaDevolucion).HasColumnName("doc_subtipoDocumento_solicitud_ejecutaDevolucion");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudIdTipoDocumento).HasColumnName("doc_subtipoDocumento_solicitud_id_tipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_solicitud_prefijo");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudProgramarPlaneadas).HasColumnName("doc_subtipoDocumento_solicitud_programarPlaneadas");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_solicitud_subtipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_solicitud_subtipoDocumento_codigo");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudValUrgente).HasColumnName("doc_subtipoDocumento_solicitud_valUrgente");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudVerCentroCosto).HasColumnName("doc_subtipoDocumento_solicitud_verCentroCosto");
        builder.Property(e => e.DocSubtipoDocumentoSolicitudVerIncoterm).HasColumnName("doc_subtipoDocumento_solicitud_verIncoterm");
        builder.Property(e => e.DocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocSubtipoDocumentoValUrgente).HasColumnName("doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocSubtipoDocumentoVerIncoterm).HasColumnName("doc_subtipoDocumento_verIncoterm");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFin_ff");
        builder.Property(e => e.FechaInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicio_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenTipoServicioDiasGarantia).HasColumnName("gen_tipoServicio_diasGarantia");
        builder.Property(e => e.GenTipoServicioTieneGarantia).HasColumnName("gen_tipoServicio_tieneGarantia");
        builder.Property(e => e.GenTipoServicioTipoServicio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_tipoServicio_tipoServicio");
        builder.Property(e => e.GenTipoServicioTipoServicioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_tipoServicio_tipoServicio_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdDepartamentoSolicitud).HasColumnName("id_departamentoSolicitud");
        builder.Property(e => e.IdDocumentoAlquiler).HasColumnName("id_documento.alquiler");
        builder.Property(e => e.IdEstadoTipoDocumentoInicial).HasColumnName("id_estadoTipoDocumento_inicial");
        builder.Property(e => e.IdPeriodoContrato).HasColumnName("id_periodoContrato");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdSubtipoDocumentoSolicitud).HasColumnName("id_subtipoDocumento_solicitud");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdTerceroServicio).HasColumnName("id_tercero_servicio");
        builder.Property(e => e.IdTipoContrato).HasColumnName("id_tipoContrato");
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuarioCoordinador).HasColumnName("id_usuario_coordinador");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Numero)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("numero");
        builder.Property(e => e.OrtDepartamentoSolicitudDepartamentoSolicitud)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_departamentoSolicitud_departamentoSolicitud");
        builder.Property(e => e.OrtDepartamentoSolicitudDepartamentoSolicitudCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_departamentoSolicitud_departamentoSolicitud_codigo");
        builder.Property(e => e.OrtDepartamentoSolicitudRecibeSolicitudes).HasColumnName("ort_departamentoSolicitud_recibeSolicitudes");
        builder.Property(e => e.Presupuesto)
            .HasColumnType("money")
            .HasColumnName("presupuesto");
        builder.Property(e => e.SegUsuarioCoordinadorAccesoActivo).HasColumnName("seg_usuario_coordinador_accesoActivo");
        builder.Property(e => e.SegUsuarioCoordinadorAplicaRecargo).HasColumnName("seg_usuario_coordinador_aplicaRecargo");
        builder.Property(e => e.SegUsuarioCoordinadorCambiarClave).HasColumnName("seg_usuario_coordinador_cambiarClave");
        builder.Property(e => e.SegUsuarioCoordinadorClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_clave");
        builder.Property(e => e.SegUsuarioCoordinadorCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_coordinador_costoHora");
        builder.Property(e => e.SegUsuarioCoordinadorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_direccion");
        builder.Property(e => e.SegUsuarioCoordinadorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_email");
        builder.Property(e => e.SegUsuarioCoordinadorFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_coordinador_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioCoordinadorFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_coordinador_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioCoordinadorFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_coordinador_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioCoordinadorHabilitado).HasColumnName("seg_usuario_coordinador_habilitado");
        builder.Property(e => e.SegUsuarioCoordinadorIdCargo).HasColumnName("seg_usuario_coordinador_id_cargo");
        builder.Property(e => e.SegUsuarioCoordinadorIdGrupo).HasColumnName("seg_usuario_coordinador_id_grupo");
        builder.Property(e => e.SegUsuarioCoordinadorIdPerfil).HasColumnName("seg_usuario_coordinador_id_perfil");
        builder.Property(e => e.SegUsuarioCoordinadorIdUsuario).HasColumnName("seg_usuario_coordinador_id_usuario");
        builder.Property(e => e.SegUsuarioCoordinadorIdZona).HasColumnName("seg_usuario_coordinador_id_zona");
        builder.Property(e => e.SegUsuarioCoordinadorIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_identificacion");
        builder.Property(e => e.SegUsuarioCoordinadorIntentosFallidos).HasColumnName("seg_usuario_coordinador_intentosFallidos");
        builder.Property(e => e.SegUsuarioCoordinadorNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_nombre");
        builder.Property(e => e.SegUsuarioCoordinadorNumeroIngresos).HasColumnName("seg_usuario_coordinador_numeroIngresos");
        builder.Property(e => e.SegUsuarioCoordinadorPorcentajeComision).HasColumnName("seg_usuario_coordinador_porcentajeComision");
        builder.Property(e => e.SegUsuarioCoordinadorPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_coordinador_preferencias");
        builder.Property(e => e.SegUsuarioCoordinadorProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_profesion");
        builder.Property(e => e.SegUsuarioCoordinadorSexo).HasColumnName("seg_usuario_coordinador_sexo");
        builder.Property(e => e.SegUsuarioCoordinadorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_telefono");
        builder.Property(e => e.SegUsuarioCoordinadorUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_usuario");
        builder.Property(e => e.SegUsuarioCoordinadorUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_coordinador_usuario_codigo");
        builder.Property(e => e.TerTerceroClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_clasificacion");
        builder.Property(e => e.TerTerceroContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_contacto");
        builder.Property(e => e.TerTerceroDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_direccion");
        builder.Property(e => e.TerTerceroEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_email");
        builder.Property(e => e.TerTerceroEsCliente).HasColumnName("ter_tercero_esCliente");
        builder.Property(e => e.TerTerceroEsEmpresaPropia).HasColumnName("ter_tercero_esEmpresaPropia");
        builder.Property(e => e.TerTerceroEsFabricante).HasColumnName("ter_tercero_esFabricante");
        builder.Property(e => e.TerTerceroEsProspecto).HasColumnName("ter_tercero_esProspecto");
        builder.Property(e => e.TerTerceroEsProveedor).HasColumnName("ter_tercero_esProveedor");
        builder.Property(e => e.TerTerceroEsTransportador).HasColumnName("ter_tercero_esTransportador");
        builder.Property(e => e.TerTerceroFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fax");
        builder.Property(e => e.TerTerceroIdEstadoTercero).HasColumnName("ter_tercero_id_estadoTercero");
        builder.Property(e => e.TerTerceroIdNaturalezaTercero).HasColumnName("ter_tercero_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroIdZona).HasColumnName("ter_tercero_id_zona");
        builder.Property(e => e.TerTerceroNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_notas");
        builder.Property(e => e.TerTerceroRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_representante");
        builder.Property(e => e.TerTerceroServicioClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_clasificacion");
        builder.Property(e => e.TerTerceroServicioContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_contacto");
        builder.Property(e => e.TerTerceroServicioDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_direccion");
        builder.Property(e => e.TerTerceroServicioEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_email");
        builder.Property(e => e.TerTerceroServicioEsCliente).HasColumnName("ter_tercero_servicio_esCliente");
        builder.Property(e => e.TerTerceroServicioEsEmpresaPropia).HasColumnName("ter_tercero_servicio_esEmpresaPropia");
        builder.Property(e => e.TerTerceroServicioEsFabricante).HasColumnName("ter_tercero_servicio_esFabricante");
        builder.Property(e => e.TerTerceroServicioEsProspecto).HasColumnName("ter_tercero_servicio_esProspecto");
        builder.Property(e => e.TerTerceroServicioEsProveedor).HasColumnName("ter_tercero_servicio_esProveedor");
        builder.Property(e => e.TerTerceroServicioEsTransportador).HasColumnName("ter_tercero_servicio_esTransportador");
        builder.Property(e => e.TerTerceroServicioFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_fax");
        builder.Property(e => e.TerTerceroServicioIdEstadoTercero).HasColumnName("ter_tercero_servicio_id_estadoTercero");
        builder.Property(e => e.TerTerceroServicioIdNaturalezaTercero).HasColumnName("ter_tercero_servicio_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroServicioIdZona).HasColumnName("ter_tercero_servicio_id_zona");
        builder.Property(e => e.TerTerceroServicioNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_notas");
        builder.Property(e => e.TerTerceroServicioRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_representante");
        builder.Property(e => e.TerTerceroServicioTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_telefono");
        builder.Property(e => e.TerTerceroServicioTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_tercero");
        builder.Property(e => e.TerTerceroServicioTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_tercero_codigo");
        builder.Property(e => e.TerTerceroServicioTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_tercero_nit");
        builder.Property(e => e.TerTerceroServicioTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroServicioWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_website");
        builder.Property(e => e.TerTerceroTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_telefono");
        builder.Property(e => e.TerTerceroTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero");
        builder.Property(e => e.TerTerceroTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_codigo");
        builder.Property(e => e.TerTerceroTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_nit");
        builder.Property(e => e.TerTerceroTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_website");
        builder.Property(e => e.TotalContrato)
            .HasColumnType("money")
            .HasColumnName("totalContrato");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
