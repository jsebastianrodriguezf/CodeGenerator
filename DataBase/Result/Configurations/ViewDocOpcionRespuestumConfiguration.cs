using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocOpcionRespuestumConfiguration : IEntityTypeConfiguration<ViewDocOpcionRespuestum>
{
    public void Configure(EntityTypeBuilder<ViewDocOpcionRespuestum> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_opcionRespuesta");

        builder.Property(e => e.Activa).HasColumnName("activa");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocPreguntaActiva).HasColumnName("doc_pregunta_activa");
        builder.Property(e => e.DocPreguntaIdEvaluacion).HasColumnName("doc_pregunta_id_evaluacion");
        builder.Property(e => e.DocPreguntaOrden).HasColumnName("doc_pregunta_orden");
        builder.Property(e => e.DocPreguntaPregunta)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_pregunta_pregunta");
        builder.Property(e => e.DocPreguntaPreguntaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_pregunta_pregunta_codigo");
        builder.Property(e => e.DocPreguntaValor).HasColumnName("doc_pregunta_valor");
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
        builder.Property(e => e.IdPregunta).HasColumnName("id_pregunta");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.OpcionRespuesta)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("opcionRespuesta");
        builder.Property(e => e.OpcionRespuestaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("opcionRespuesta_codigo");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor).HasColumnName("valor");
    }
}
