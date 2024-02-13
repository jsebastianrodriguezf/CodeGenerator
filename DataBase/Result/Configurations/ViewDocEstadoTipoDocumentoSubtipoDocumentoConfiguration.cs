using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocEstadoTipoDocumentoSubtipoDocumentoConfiguration : IEntityTypeConfiguration<ViewDocEstadoTipoDocumentoSubtipoDocumento>
{
    public void Configure(EntityTypeBuilder<ViewDocEstadoTipoDocumentoSubtipoDocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_estadoTipoDocumento_subtipoDocumento");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoAfectaIndicador).HasColumnName("doc_estadoTipoDocumento_destino_afectaIndicador");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoAfectaInventario).HasColumnName("doc_estadoTipoDocumento_destino_afectaInventario");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_destino_color");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_destino_descripcion");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoEditaDocumento).HasColumnName("doc_estadoTipoDocumento_destino_editaDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_destino_estadoTipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_destino_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoIdTipoDocumento).HasColumnName("doc_estadoTipoDocumento_destino_id_tipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoMotivoObligatorio).HasColumnName("doc_estadoTipoDocumento_destino_motivoObligatorio");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoObservacionesObligatorio).HasColumnName("doc_estadoTipoDocumento_destino_observacionesObligatorio");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoOrden).HasColumnName("doc_estadoTipoDocumento_destino_orden");
        builder.Property(e => e.DocEstadoTipoDocumentoDestinoPuedeRegresar).HasColumnName("doc_estadoTipoDocumento_destino_puedeRegresar");
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
        builder.Property(e => e.EstadoTipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("estadoTipoDocumento_subtipoDocumento");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdEstadoTipoDocumentoDestino).HasColumnName("id_estadoTipoDocumento_destino");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.SpEjecucionfinal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sp_ejecucionfinal");
        builder.Property(e => e.TiempoDeEjecucion).HasColumnName("tiempoDeEjecucion");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
