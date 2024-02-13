using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocPreguntumConfiguration : IEntityTypeConfiguration<ViewDocPreguntum>
{
    public void Configure(EntityTypeBuilder<ViewDocPreguntum> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_pregunta");

        builder.Property(e => e.Activa).HasColumnName("activa");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocEvaluacionActiva).HasColumnName("doc_evaluacion_activa");
        builder.Property(e => e.DocEvaluacionEvaluacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_evaluacion_evaluacion");
        builder.Property(e => e.DocEvaluacionEvaluacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_evaluacion_evaluacion_codigo");
        builder.Property(e => e.DocEvaluacionIdSubtipoDocumento).HasColumnName("doc_evaluacion_id_subtipoDocumento");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEvaluacion).HasColumnName("id_evaluacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
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
        builder.Property(e => e.Valor).HasColumnName("valor");
    }
}
