using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocPrioridadSubtipoDocumentoConfiguration : IEntityTypeConfiguration<DocPrioridadSubtipoDocumento>
{
    public void Configure(EntityTypeBuilder<DocPrioridadSubtipoDocumento> builder)
    {
        builder.ToTable("doc_prioridadSubtipoDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_prioridadSubtipoDocumento");

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
        builder.Property(e => e.IdPrioridadDocumento).HasColumnName("id_prioridadDocumento");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PrioridadSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("prioridadSubtipoDocumento");
        builder.Property(e => e.PrioridadSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("prioridadSubtipoDocumento_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdPrioridadDocumentoNavigation).WithMany(p => p.DocPrioridadSubtipoDocumentos)
            .HasForeignKey(d => d.IdPrioridadDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__doc_prior__id_pr__1E1F42AD");

        builder.HasOne(d => d.IdSubtipoDocumentoNavigation).WithMany(p => p.DocPrioridadSubtipoDocumentos)
            .HasForeignKey(d => d.IdSubtipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__doc_prior__id_su__1C36FA3B");
    }
}
