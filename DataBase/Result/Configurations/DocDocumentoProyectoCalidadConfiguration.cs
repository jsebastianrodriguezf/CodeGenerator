using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoProyectoCalidadConfiguration : IEntityTypeConfiguration<DocDocumentoProyectoCalidad>
{
    public void Configure(EntityTypeBuilder<DocDocumentoProyectoCalidad> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_proyecto_calidad");

        builder.ToTable("doc_documento.proyecto_calidad");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_proyecto_calidad");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoProyectoCalidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.proyecto_calidad");
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
        builder.Property(e => e.IdCalidad).HasColumnName("id_calidad");
        builder.Property(e => e.IdDocumentoProyecto).HasColumnName("id_documento.proyecto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
