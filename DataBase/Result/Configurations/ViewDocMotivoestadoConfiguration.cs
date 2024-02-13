using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocMotivoestadoConfiguration : IEntityTypeConfiguration<ViewDocMotivoestado>
{
    public void Configure(EntityTypeBuilder<ViewDocMotivoestado> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_motivoestado");

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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Motivoestado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("motivoestado");
        builder.Property(e => e.MotivoestadoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("motivoestado_codigo");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
