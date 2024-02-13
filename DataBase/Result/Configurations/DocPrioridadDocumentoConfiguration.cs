using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocPrioridadDocumentoConfiguration : IEntityTypeConfiguration<DocPrioridadDocumento>
{
    public void Configure(EntityTypeBuilder<DocPrioridadDocumento> builder)
    {
        builder.ToTable("doc_prioridadDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_prioridadDocumento");

        builder.Property(e => e.Id).HasColumnName("id");
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
        builder.Property(e => e.IdEstrategiaPrioridad).HasColumnName("id_estrategiaPrioridad");
        builder.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.PrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("prioridadDocumento");
        builder.Property(e => e.PrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("prioridadDocumento_codigo");
        builder.Property(e => e.TiempoRespuesta)
            .HasDefaultValue(24)
            .HasColumnName("tiempoRespuesta");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEstrategiaPrioridadNavigation).WithMany(p => p.DocPrioridadDocumentos)
            .HasForeignKey(d => d.IdEstrategiaPrioridad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_prioridadDocumento_id_estrategiaPrioridad");

        builder.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.DocPrioridadDocumentos)
            .HasForeignKey(d => d.IdTipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_prioridadDocumento_id_tipoDocumento");
    }
}
