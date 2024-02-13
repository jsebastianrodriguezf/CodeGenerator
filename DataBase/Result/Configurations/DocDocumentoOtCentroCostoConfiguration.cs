using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoOtCentroCostoConfiguration : IEntityTypeConfiguration<DocDocumentoOtCentroCosto>
{
    public void Configure(EntityTypeBuilder<DocDocumentoOtCentroCosto> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_ot_centroCosto");

        builder.ToTable("doc_documento.ot_centroCosto");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_ot_centroCosto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoOtCentroCosto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.ot_centroCosto");
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
        builder.Property(e => e.IdCentroCosto).HasColumnName("id_centroCosto");
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Porcentaje).HasColumnName("porcentaje");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCentroCostoNavigation).WithMany(p => p.DocDocumentoOtCentroCostos)
            .HasForeignKey(d => d.IdCentroCosto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_centroCosto_id_centroCosto");

        builder.HasOne(d => d.IdDocumentoOtNavigation).WithMany(p => p.DocDocumentoOtCentroCostos)
            .HasForeignKey(d => d.IdDocumentoOt)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_centroCosto_id_documento_ot");
    }
}
