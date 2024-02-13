using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocEstadoTipoDocumentoSubtipoDocumentoConfiguration : IEntityTypeConfiguration<DocEstadoTipoDocumentoSubtipoDocumento>
{
    public void Configure(EntityTypeBuilder<DocEstadoTipoDocumentoSubtipoDocumento> builder)
    {
        builder.ToTable("doc_estadoTipoDocumento_subtipoDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_estadoTipoDocumento_subtipoDocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstadoTipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("estadoTipoDocumento_subtipoDocumento");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdEstadoTipoDocumentoDestino).HasColumnName("id_estadoTipoDocumento_destino");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.SpEjecucionfinal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("sp_ejecucionfinal");
        builder.Property(e => e.TiempoDeEjecucion).HasColumnName("tiempoDeEjecucion");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEstadoTipoDocumentoNavigation).WithMany(p => p.DocEstadoTipoDocumentoSubtipoDocumentoIdEstadoTipoDocumentoNavigations)
            .HasForeignKey(d => d.IdEstadoTipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_estadoTipoDocumento_subtipoDocumento_id_estadoTipoDocumento");

        builder.HasOne(d => d.IdEstadoTipoDocumentoDestinoNavigation).WithMany(p => p.DocEstadoTipoDocumentoSubtipoDocumentoIdEstadoTipoDocumentoDestinoNavigations)
            .HasForeignKey(d => d.IdEstadoTipoDocumentoDestino)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_estadoTipoDocumento_subtipoDocumento_id_estadoTipoDocumento_destino");

        builder.HasOne(d => d.IdSubtipoDocumentoNavigation).WithMany(p => p.DocEstadoTipoDocumentoSubtipoDocumentos)
            .HasForeignKey(d => d.IdSubtipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_estadoTipoDocumento_subtipoDocumento_id_subtipoDocumento");
    }
}
