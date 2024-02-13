using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoEvaluacionConfiguration : IEntityTypeConfiguration<DocDocumentoEvaluacion>
{
    public void Configure(EntityTypeBuilder<DocDocumentoEvaluacion> builder)
    {
        builder.ToTable("doc_documento_evaluacion");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_evaluacion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoEvaluacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento_evaluacion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaEncuestaFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaEncuesta_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdEvaluacion).HasColumnName("id_evaluacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("observaciones");
        builder.Property(e => e.PersonaEncuestada)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("personaEncuestada");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.DocDocumentoEvaluacions)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_evaluacion_id_documento");

        builder.HasOne(d => d.IdEvaluacionNavigation).WithMany(p => p.DocDocumentoEvaluacions)
            .HasForeignKey(d => d.IdEvaluacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_evaluacion_id_evaluacion");
    }
}
