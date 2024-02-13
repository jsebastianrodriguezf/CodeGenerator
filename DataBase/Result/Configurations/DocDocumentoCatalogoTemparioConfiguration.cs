using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoCatalogoTemparioConfiguration : IEntityTypeConfiguration<DocDocumentoCatalogoTempario>
{
    public void Configure(EntityTypeBuilder<DocDocumentoCatalogoTempario> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_catalogo_tempario");

        builder.ToTable("doc_documento_catalogo.tempario");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_catalogo_tempario");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoCatalogoTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento_catalogo.tempario");
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
        builder.Property(e => e.IdCatalogoTempario).HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoTemparioNavigation).WithMany(p => p.DocDocumentoCatalogoTemparios)
            .HasForeignKey(d => d.IdCatalogoTempario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_catalogo_tempario_id_catalogo_tempario");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.DocDocumentoCatalogoTemparios)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_catalogo_tempario_id_documento");

        builder.HasOne(d => d.IdItemDocumentoNavigation).WithMany(p => p.DocDocumentoCatalogoTemparios)
            .HasForeignKey(d => d.IdItemDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_catalogo_tempario_id_itemDocumento");
    }
}
