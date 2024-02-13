using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocOpcionRespuestumConfiguration : IEntityTypeConfiguration<DocOpcionRespuestum>
{
    public void Configure(EntityTypeBuilder<DocOpcionRespuestum> builder)
    {
        builder.ToTable("doc_opcionRespuesta");

        builder.HasIndex(e => e.Eid, "IX_doc_opcionRespuesta");

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
        builder.Property(e => e.IdPregunta).HasColumnName("id_pregunta");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
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
        builder.Property(e => e.Valor)
            .HasDefaultValue(1)
            .HasColumnName("valor");

        builder.HasOne(d => d.IdPreguntaNavigation).WithMany(p => p.DocOpcionRespuesta)
            .HasForeignKey(d => d.IdPregunta)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_opcionRespuesta_id_pregunta");
    }
}
