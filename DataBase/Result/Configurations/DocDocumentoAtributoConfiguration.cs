using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoAtributoConfiguration : IEntityTypeConfiguration<DocDocumentoAtributo>
{
    public void Configure(EntityTypeBuilder<DocDocumentoAtributo> builder)
    {
        builder.ToTable("doc_documentoAtributo");

        builder.HasIndex(e => e.Eid, "IX_doc_documentoAtributo");

        builder.HasIndex(e => e.IdDocumento, "IX_id_documento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoAtributo)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("documentoAtributo");
        builder.Property(e => e.DocumentoAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("documentoAtributo_codigo");
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
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdOpcionAtributo).HasColumnName("id_opcionAtributo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.DocDocumentoAtributos)
            .HasForeignKey(d => d.IdAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documentoAtributo_id_atributo");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.DocDocumentoAtributos)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documentoAtributo_id_documento");

        builder.HasOne(d => d.IdOpcionAtributoNavigation).WithMany(p => p.DocDocumentoAtributos)
            .HasForeignKey(d => d.IdOpcionAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documentoAtributo_id_opcionAtributo");
    }
}
