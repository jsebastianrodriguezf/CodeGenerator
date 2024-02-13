using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoCotizacionCondicionConfiguration : IEntityTypeConfiguration<DocDocumentoCotizacionCondicion>
{
    public void Configure(EntityTypeBuilder<DocDocumentoCotizacionCondicion> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_cotizacion_condicion");

        builder.ToTable("doc_documento.cotizacion_condicion");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_cotizacion_condicion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoCotizacionCondicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.cotizacion_condicion");
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
        builder.Property(e => e.IdCondicion).HasColumnName("id_condicion");
        builder.Property(e => e.IdDocumentoCotizacion).HasColumnName("id_documento.cotizacion");
        builder.Property(e => e.IdOpcionCondicion).HasColumnName("id_opcionCondicion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Imprimir)
            .HasDefaultValue(true)
            .HasColumnName("imprimir");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCondicionNavigation).WithMany(p => p.DocDocumentoCotizacionCondicions)
            .HasForeignKey(d => d.IdCondicion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_cotizacion_condicion_id_condicion");

        builder.HasOne(d => d.IdDocumentoCotizacionNavigation).WithMany(p => p.DocDocumentoCotizacionCondicions)
            .HasForeignKey(d => d.IdDocumentoCotizacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_cotizacion_condicion_id_documento_cotizacion");

        builder.HasOne(d => d.IdOpcionCondicionNavigation).WithMany(p => p.DocDocumentoCotizacionCondicions)
            .HasForeignKey(d => d.IdOpcionCondicion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_cotizacion_condicion_id_opcionCondicion");
    }
}
