using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenEnvioCorreoConfiguration : IEntityTypeConfiguration<ViewGenEnvioCorreo>
{
    public void Configure(EntityTypeBuilder<ViewGenEnvioCorreo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_envioCorreo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AdjuntarArchivo).HasColumnName("adjuntarArchivo");
        builder.Property(e => e.CantidadMensajes).HasColumnName("cantidadMensajes");
        builder.Property(e => e.CantidadReintento).HasColumnName("cantidadReintento");
        builder.Property(e => e.CorreoAdicional)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("correoAdicional");
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
        builder.Property(e => e.DocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocSubtipoDocumentoCantidadAuxiliar).HasColumnName("doc_subtipoDocumento_cantidadAuxiliar");
        builder.Property(e => e.DocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocSubtipoDocumentoCerrarSol).HasColumnName("doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocSubtipoDocumentoConsecutivo).HasColumnName("doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocSubtipoDocumentoEjecutaDevolucion).HasColumnName("doc_subtipoDocumento_ejecutaDevolucion");
        builder.Property(e => e.DocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoMostrarPendienteDocumento).HasColumnName("doc_subtipoDocumento_mostrarPendienteDocumento");
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
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EnvioCorreo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("envioCorreo");
        builder.Property(e => e.EnvioCorreoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("envioCorreo_codigo");
        builder.Property(e => e.Estrategia).HasColumnName("estrategia");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenRemitenteCorreoArchivoCertificado)
            .HasMaxLength(800)
            .IsUnicode(false)
            .HasColumnName("gen_remitenteCorreo_archivoCertificado");
        builder.Property(e => e.GenRemitenteCorreoCertificado).HasColumnName("gen_remitenteCorreo_certificado");
        builder.Property(e => e.GenRemitenteCorreoCredenciales)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("gen_remitenteCorreo_credenciales");
        builder.Property(e => e.GenRemitenteCorreoCuentaCertificado)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("gen_remitenteCorreo_cuentaCertificado");
        builder.Property(e => e.GenRemitenteCorreoEsGsuite).HasColumnName("gen_remitenteCorreo_esGSuite");
        builder.Property(e => e.GenRemitenteCorreoPuerto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_remitenteCorreo_puerto");
        builder.Property(e => e.GenRemitenteCorreoRemitenteCorreo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_remitenteCorreo_remitenteCorreo");
        builder.Property(e => e.GenRemitenteCorreoRemitenteCorreoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_remitenteCorreo_remitenteCorreo_codigo");
        builder.Property(e => e.GenRemitenteCorreoServidor)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("gen_remitenteCorreo_servidor");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdRemitenteCorreo).HasColumnName("id_remitenteCorreo");
        builder.Property(e => e.IdReporte).HasColumnName("id_reporte");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PlantillaAdjunto)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("plantillaAdjunto");
        builder.Property(e => e.RepReporteBasica).HasColumnName("rep_reporte_basica");
        builder.Property(e => e.RepReporteCabecera)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("rep_reporte_cabecera");
        builder.Property(e => e.RepReporteEsFormato).HasColumnName("rep_reporte_esFormato");
        builder.Property(e => e.RepReporteIdFuncionalidad).HasColumnName("rep_reporte_id_funcionalidad");
        builder.Property(e => e.RepReporteOrden).HasColumnName("rep_reporte_orden");
        builder.Property(e => e.RepReporteReporte)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("rep_reporte_reporte");
        builder.Property(e => e.RepReporteReporteCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("rep_reporte_reporte_codigo");
        builder.Property(e => e.RepReporteTieneGraficos).HasColumnName("rep_reporte_tieneGraficos");
        builder.Property(e => e.Tabla)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("tabla");
        builder.Property(e => e.TiempoPorMensajes).HasColumnName("tiempo_por_mensajes");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
