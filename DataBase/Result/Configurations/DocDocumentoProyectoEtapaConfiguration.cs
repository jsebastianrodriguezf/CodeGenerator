using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoProyectoEtapaConfiguration : IEntityTypeConfiguration<DocDocumentoProyectoEtapa>
{
    public void Configure(EntityTypeBuilder<DocDocumentoProyectoEtapa> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_proyecto_etapa");

        builder.ToTable("doc_documento.proyecto_etapa");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_proyecto_etapa");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoProyectoEtapa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.proyecto_etapa");
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
        builder.Property(e => e.IdDocumentoProyecto).HasColumnName("id_documento.proyecto");
        builder.Property(e => e.IdEtapa).HasColumnName("id_etapa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDocumentoProyectoNavigation).WithMany(p => p.DocDocumentoProyectoEtapas)
            .HasForeignKey(d => d.IdDocumentoProyecto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento.proyecto_id_documento.proyecto");

        builder.HasOne(d => d.IdEtapaNavigation).WithMany(p => p.DocDocumentoProyectoEtapas)
            .HasForeignKey(d => d.IdEtapa)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_etapa_id_etapa");
    }
}
