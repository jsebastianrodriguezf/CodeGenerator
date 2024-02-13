using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoComentarioConfiguration : IEntityTypeConfiguration<DocDocumentoComentario>
{
    public void Configure(EntityTypeBuilder<DocDocumentoComentario> builder)
    {
        builder.ToTable("doc_documentoComentario");

        builder.HasIndex(e => e.Eid, "IX_doc_documentoComentario");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cerrada).HasColumnName("cerrada");
        builder.Property(e => e.Comentario)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("comentario");
        builder.Property(e => e.ConRespuesta).HasColumnName("conRespuesta");
        builder.Property(e => e.DocumentoComentario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documentoComentario");
        builder.Property(e => e.DocumentoComentarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("documentoComentario_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaOrden)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaOrden");
        builder.Property(e => e.FechaOriginal)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaOriginal");
        builder.Property(e => e.FechaRecordarFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaRecordar_fh");
        builder.Property(e => e.Finalizado).HasColumnName("finalizado");
        builder.Property(e => e.IdContacto).HasColumnName("id_contacto");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdDocumentoComentario).HasColumnName("id_documentoComentario");
        builder.Property(e => e.IdReporteTecnico).HasColumnName("id_reporteTecnico");
        builder.Property(e => e.IdTarea).HasColumnName("id_tarea");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioOriginal).HasColumnName("id_usuarioOriginal");
        builder.Property(e => e.Recordar)
            .HasDefaultValue(true)
            .HasColumnName("recordar");
        builder.Property(e => e.Relevante)
            .HasDefaultValue(1)
            .HasColumnName("relevante");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdContactoNavigation).WithMany(p => p.DocDocumentoComentarios)
            .HasForeignKey(d => d.IdContacto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documentoComentario_id_contacto");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.DocDocumentoComentarios)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documentoComentario_id_documento");

        builder.HasOne(d => d.IdDocumentoComentarioNavigation).WithMany(p => p.InverseIdDocumentoComentarioNavigation)
            .HasForeignKey(d => d.IdDocumentoComentario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documentoComentario_id_documentoComentario");

        builder.HasOne(d => d.IdReporteTecnicoNavigation).WithMany(p => p.DocDocumentoComentarios)
            .HasForeignKey(d => d.IdReporteTecnico)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__doc_docum__id_re__541A9554");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.DocDocumentoComentarios)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documentoComentario_id_usuario");
    }
}
