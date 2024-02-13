using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocFlujoDocumentoConfiguration : IEntityTypeConfiguration<ViewDocFlujoDocumento>
{
    public void Configure(EntityTypeBuilder<ViewDocFlujoDocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_flujoDocumento");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocEstadoTipoDocumentoOrigenAfectaIndicador).HasColumnName("doc_estadoTipoDocumento_origen_afectaIndicador");
        builder.Property(e => e.DocEstadoTipoDocumentoOrigenAfectaInventario).HasColumnName("doc_estadoTipoDocumento_origen_afectaInventario");
        builder.Property(e => e.DocEstadoTipoDocumentoOrigenColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_origen_color");
        builder.Property(e => e.DocEstadoTipoDocumentoOrigenDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_origen_descripcion");
        builder.Property(e => e.DocEstadoTipoDocumentoOrigenEditaDocumento).HasColumnName("doc_estadoTipoDocumento_origen_editaDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoOrigenEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_origen_estadoTipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoOrigenEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_origen_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocEstadoTipoDocumentoOrigenIdTipoDocumento).HasColumnName("doc_estadoTipoDocumento_origen_id_tipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoOrigenOrden).HasColumnName("doc_estadoTipoDocumento_origen_orden");
        builder.Property(e => e.DocEstadoTipoDocumentoOrigenPuedeRegresar).HasColumnName("doc_estadoTipoDocumento_origen_puedeRegresar");
        builder.Property(e => e.DocEstadoTipoDocumentoResultadoAfectaIndicador).HasColumnName("doc_estadoTipoDocumento_resultado_afectaIndicador");
        builder.Property(e => e.DocEstadoTipoDocumentoResultadoAfectaInventario).HasColumnName("doc_estadoTipoDocumento_resultado_afectaInventario");
        builder.Property(e => e.DocEstadoTipoDocumentoResultadoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_resultado_color");
        builder.Property(e => e.DocEstadoTipoDocumentoResultadoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_resultado_descripcion");
        builder.Property(e => e.DocEstadoTipoDocumentoResultadoEditaDocumento).HasColumnName("doc_estadoTipoDocumento_resultado_editaDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoResultadoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_resultado_estadoTipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoResultadoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_resultado_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocEstadoTipoDocumentoResultadoIdTipoDocumento).HasColumnName("doc_estadoTipoDocumento_resultado_id_tipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoResultadoOrden).HasColumnName("doc_estadoTipoDocumento_resultado_orden");
        builder.Property(e => e.DocEstadoTipoDocumentoResultadoPuedeRegresar).HasColumnName("doc_estadoTipoDocumento_resultado_puedeRegresar");
        builder.Property(e => e.DocSubtipoDocumentoDestinoConsecutivo).HasColumnName("doc_subtipoDocumento_destino_consecutivo");
        builder.Property(e => e.DocSubtipoDocumentoDestinoIdTipoDocumento).HasColumnName("doc_subtipoDocumento_destino_id_tipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoDestinoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_destino_prefijo");
        builder.Property(e => e.DocSubtipoDocumentoDestinoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_destino_subtipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoDestinoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_destino_subtipoDocumento_codigo");
        builder.Property(e => e.DocSubtipoDocumentoOrigenConsecutivo).HasColumnName("doc_subtipoDocumento_origen_consecutivo");
        builder.Property(e => e.DocSubtipoDocumentoOrigenIdTipoDocumento).HasColumnName("doc_subtipoDocumento_origen_id_tipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoOrigenPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_origen_prefijo");
        builder.Property(e => e.DocSubtipoDocumentoOrigenSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_origen_subtipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoOrigenSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_origen_subtipoDocumento_codigo");
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
        builder.Property(e => e.FlujoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("flujoDocumento");
        builder.Property(e => e.FlujoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("flujoDocumento_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEstadoTipoDocumentoOrigen).HasColumnName("id_estadoTipoDocumento_origen");
        builder.Property(e => e.IdEstadoTipoDocumentoResultado).HasColumnName("id_estadoTipoDocumento_resultado");
        builder.Property(e => e.IdSubtipoDocumentoDestino).HasColumnName("id_subtipoDocumento_destino");
        builder.Property(e => e.IdSubtipoDocumentoOrigen).HasColumnName("id_subtipoDocumento_origen");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ReplicarAtributos).HasColumnName("replicarAtributos");
        builder.Property(e => e.ReplicarComentario).HasColumnName("replicarComentario");
        builder.Property(e => e.ReplicarItems).HasColumnName("replicarItems");
        builder.Property(e => e.ReplicarItemsActividades).HasColumnName("replicarItemsActividades");
        builder.Property(e => e.Restrictivo).HasColumnName("restrictivo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
