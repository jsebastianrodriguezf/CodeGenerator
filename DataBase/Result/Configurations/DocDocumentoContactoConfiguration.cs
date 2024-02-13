using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoContactoConfiguration : IEntityTypeConfiguration<DocDocumentoContacto>
{
    public void Configure(EntityTypeBuilder<DocDocumentoContacto> builder)
    {
        builder.ToTable("doc_documento_contacto");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_contacto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoContacto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento_contacto");
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
        builder.Property(e => e.IdContacto).HasColumnName("id_contacto");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdContactoNavigation).WithMany(p => p.DocDocumentoContactos)
            .HasForeignKey(d => d.IdContacto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_contacto_id_contacto");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.DocDocumentoContactos)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_contacto_id_documento");
    }
}
