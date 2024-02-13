using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocEvaluacionConfiguration : IEntityTypeConfiguration<DocEvaluacion>
{
    public void Configure(EntityTypeBuilder<DocEvaluacion> builder)
    {
        builder.ToTable("doc_evaluacion");

        builder.HasIndex(e => e.Eid, "IX_doc_evaluacion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Activa)
            .HasDefaultValue(true)
            .HasColumnName("activa");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Evaluacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("evaluacion");
        builder.Property(e => e.EvaluacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("evaluacion_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdSubtipoDocumentoNavigation).WithMany(p => p.DocEvaluacions)
            .HasForeignKey(d => d.IdSubtipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_evaluacion_id_subtipoDocumento");
    }
}
