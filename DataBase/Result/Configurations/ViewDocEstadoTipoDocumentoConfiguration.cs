using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocEstadoTipoDocumentoConfiguration : IEntityTypeConfiguration<ViewDocEstadoTipoDocumento>
{
    public void Configure(EntityTypeBuilder<ViewDocEstadoTipoDocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_estadoTipoDocumento");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AfectaIndicador).HasColumnName("afectaIndicador");
        builder.Property(e => e.AfectaInventario).HasColumnName("afectaInventario");
        builder.Property(e => e.Color)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("color");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("descripcion");
        builder.Property(e => e.DocTipoDocumentoEsSalida).HasColumnName("doc_tipoDocumento_esSalida");
        builder.Property(e => e.DocTipoDocumentoMostrarBodega).HasColumnName("doc_tipoDocumento_mostrarBodega");
        builder.Property(e => e.DocTipoDocumentoMostrarCentroCosto).HasColumnName("doc_tipoDocumento_mostrarCentroCosto");
        builder.Property(e => e.DocTipoDocumentoMostrarIncoterm).HasColumnName("doc_tipoDocumento_mostrarIncoterm");
        builder.Property(e => e.DocTipoDocumentoPuedeSerMayor).HasColumnName("doc_tipoDocumento_puedeSerMayor");
        builder.Property(e => e.DocTipoDocumentoPuedeSerMenor).HasColumnName("doc_tipoDocumento_puedeSerMenor");
        builder.Property(e => e.DocTipoDocumentoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_tipoDocumento_tipoDocumento");
        builder.Property(e => e.DocTipoDocumentoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_tipoDocumento_tipoDocumento_codigo");
        builder.Property(e => e.EditaDocumento).HasColumnName("editaDocumento");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("estadoTipoDocumento");
        builder.Property(e => e.EstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("estadoTipoDocumento_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MotivoObligatorio).HasColumnName("motivoObligatorio");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ObservacionesObligatorio).HasColumnName("observacionesObligatorio");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.PuedeRegresar).HasColumnName("puedeRegresar");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
