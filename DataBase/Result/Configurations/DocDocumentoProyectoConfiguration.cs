using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoProyectoConfiguration : IEntityTypeConfiguration<DocDocumentoProyecto>
{
    public void Configure(EntityTypeBuilder<DocDocumentoProyecto> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_proyecto");

        builder.ToTable("doc_documento.proyecto");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_proyecto");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(2000)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("descripcion");
        builder.Property(e => e.DocumentoProyecto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.proyecto");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinEstimada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFinEstimada");
        builder.Property(e => e.FechaInicioEstimada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioEstimada");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Nombre)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("nombre");
        builder.Property(e => e.Presupuesto)
            .HasDefaultValue(0m)
            .HasColumnType("money")
            .HasColumnName("presupuesto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
