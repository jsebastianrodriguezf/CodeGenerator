using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSynPuntoIntegracionEstadoTipoDocumentoConfiguration : IEntityTypeConfiguration<ViewSynPuntoIntegracionEstadoTipoDocumento>
{
    public void Configure(EntityTypeBuilder<ViewSynPuntoIntegracionEstadoTipoDocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_syn_puntoIntegracion_estadoTipoDocumento");

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
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdPuntoIntegracion).HasColumnName("id_puntoIntegracion");
        builder.Property(e => e.IdRolEstado).HasColumnName("idRolEstado");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PuntoIntegracionEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("puntoIntegracion_estadoTipoDocumento");
        builder.Property(e => e.SynPuntoIntegracionCondicion)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_condicion");
        builder.Property(e => e.SynPuntoIntegracionIdPuntoIntegracion).HasColumnName("syn_puntoIntegracion_id_puntoIntegracion");
        builder.Property(e => e.SynPuntoIntegracionIdSistemaIntegrar).HasColumnName("syn_puntoIntegracion_id_sistemaIntegrar");
        builder.Property(e => e.SynPuntoIntegracionMetodo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_metodo");
        builder.Property(e => e.SynPuntoIntegracionPuntoIntegracion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_puntoIntegracion");
        builder.Property(e => e.SynPuntoIntegracionPuntoIntegracionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_puntoIntegracion_codigo");
        builder.Property(e => e.SynPuntoIntegracionTablaLocal)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_tablaLocal");
        builder.Property(e => e.SynPuntoIntegracionUrlConsumir)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_urlConsumir");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
