using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocEstadoTipoDocumentoConfiguration : IEntityTypeConfiguration<DocEstadoTipoDocumento>
{
    public void Configure(EntityTypeBuilder<DocEstadoTipoDocumento> builder)
    {
        builder.ToTable("doc_estadoTipoDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_estadoTipoDocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AfectaIndicador)
            .HasDefaultValue(true)
            .HasColumnName("afectaIndicador");
        builder.Property(e => e.AfectaInventario).HasColumnName("afectaInventario");
        builder.Property(e => e.Color)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValue("FFFFFF")
            .HasColumnName("color");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("descripcion");
        builder.Property(e => e.EditaDocumento)
            .HasDefaultValue(true)
            .HasColumnName("editaDocumento");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("estadoTipoDocumento");
        builder.Property(e => e.EstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("estadoTipoDocumento_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MotivoObligatorio).HasColumnName("motivoObligatorio");
        builder.Property(e => e.ObservacionesObligatorio).HasColumnName("observacionesObligatorio");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.PuedeRegresar)
            .HasDefaultValue(true)
            .HasColumnName("puedeRegresar");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.DocEstadoTipoDocumentos)
            .HasForeignKey(d => d.IdTipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_estadoTipoDocumento_id_tipoDocumento");
    }
}
