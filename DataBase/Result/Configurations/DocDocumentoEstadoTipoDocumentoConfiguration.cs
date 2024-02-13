using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoEstadoTipoDocumentoConfiguration : IEntityTypeConfiguration<DocDocumentoEstadoTipoDocumento>
{
    public void Configure(EntityTypeBuilder<DocDocumentoEstadoTipoDocumento> builder)
    {
        builder.ToTable("doc_documento_estadoTipoDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_estadoTipoDocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento_estadoTipoDocumento");
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
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdMotivoestado).HasColumnName("id_motivoestado");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Notas)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("notas");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.DocDocumentoEstadoTipoDocumentos)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_estadoTipoDocumento_id_documento");

        builder.HasOne(d => d.IdEstadoTipoDocumentoNavigation).WithMany(p => p.DocDocumentoEstadoTipoDocumentos)
            .HasForeignKey(d => d.IdEstadoTipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_estadoTipoDocumento_id_estadoTipoDocumento");

        builder.HasOne(d => d.IdMotivoestadoNavigation).WithMany(p => p.DocDocumentoEstadoTipoDocumentos)
            .HasForeignKey(d => d.IdMotivoestado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_estadoTipoDocumento_id_motivoestado");
    }
}
