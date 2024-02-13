using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocPendienteDocumentoDocItemDocumentoConfiguration : IEntityTypeConfiguration<DocPendienteDocumentoDocItemDocumento>
{
    public void Configure(EntityTypeBuilder<DocPendienteDocumentoDocItemDocumento> builder)
    {
        builder.ToTable("doc_pendienteDocumento_doc_itemDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_pendienteDocumento_doc_itemDocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
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
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
        builder.Property(e => e.IdPendienteDocumento).HasColumnName("id_pendienteDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PendienteDocumentoDocItemDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pendienteDocumento_doc_itemDocumento");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdItemDocumentoNavigation).WithMany(p => p.DocPendienteDocumentoDocItemDocumentos)
            .HasForeignKey(d => d.IdItemDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__doc_pendi__id_it__1217C7CD");

        builder.HasOne(d => d.IdPendienteDocumentoNavigation).WithMany(p => p.DocPendienteDocumentoDocItemDocumentos)
            .HasForeignKey(d => d.IdPendienteDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__doc_pendi__id_pe__102F7F5B");
    }
}
