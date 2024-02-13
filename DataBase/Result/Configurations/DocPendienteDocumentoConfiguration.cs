using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocPendienteDocumentoConfiguration : IEntityTypeConfiguration<DocPendienteDocumento>
{
    public void Configure(EntityTypeBuilder<DocPendienteDocumento> builder)
    {
        builder.ToTable("doc_pendienteDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_pendienteDocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
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
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdReporteTecnico).HasColumnName("id_reporteTecnico");
        builder.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");
        builder.Property(e => e.IdTipoPendiente).HasColumnName("id_tipoPendiente");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Olvidar).HasColumnName("olvidar");
        builder.Property(e => e.PendienteDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pendienteDocumento");
        builder.Property(e => e.PendienteDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pendienteDocumento_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.DocPendienteDocumentos)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_pendienteDocumento_id_catalogo");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.DocPendienteDocumentos)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_pendienteDocumento_id_documento");

        builder.HasOne(d => d.IdReporteTecnicoNavigation).WithMany(p => p.DocPendienteDocumentos)
            .HasForeignKey(d => d.IdReporteTecnico)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__doc_pendi__id_re__52324CE2");

        builder.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.DocPendienteDocumentos)
            .HasForeignKey(d => d.IdTipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_pendienteDocumento_id_tipoDocumento");
    }
}
