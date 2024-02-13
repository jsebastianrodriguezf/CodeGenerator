using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocEstadoTipoDocumentoPerfilConfiguration : IEntityTypeConfiguration<DocEstadoTipoDocumentoPerfil>
{
    public void Configure(EntityTypeBuilder<DocEstadoTipoDocumentoPerfil> builder)
    {
        builder.ToTable("doc_estadoTipoDocumento_perfil");

        builder.HasIndex(e => e.Eid, "IX_doc_estadoTipoDocumento_perfil");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstadoTipoDocumentoPerfil)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("estadoTipoDocumento_perfil");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdPerfil).HasColumnName("id_perfil");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEstadoTipoDocumentoNavigation).WithMany(p => p.DocEstadoTipoDocumentoPerfils)
            .HasForeignKey(d => d.IdEstadoTipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_estadoTipoDocumento_perfil_id_estadoTipoDocumento");

        builder.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.DocEstadoTipoDocumentoPerfils)
            .HasForeignKey(d => d.IdPerfil)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_estadoTipoDocumento_perfil_id_perfil");
    }
}
