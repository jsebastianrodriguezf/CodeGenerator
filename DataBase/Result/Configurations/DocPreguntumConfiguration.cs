using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocPreguntumConfiguration : IEntityTypeConfiguration<DocPreguntum>
{
    public void Configure(EntityTypeBuilder<DocPreguntum> builder)
    {
        builder.ToTable("doc_pregunta");

        builder.HasIndex(e => e.Eid, "IX_doc_pregunta");

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
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEvaluacion).HasColumnName("id_evaluacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Pregunta)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pregunta");
        builder.Property(e => e.PreguntaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pregunta_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor)
            .HasDefaultValue(1)
            .HasColumnName("valor");

        builder.HasOne(d => d.IdEvaluacionNavigation).WithMany(p => p.DocPregunta)
            .HasForeignKey(d => d.IdEvaluacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_pregunta_id_evaluacion");
    }
}
