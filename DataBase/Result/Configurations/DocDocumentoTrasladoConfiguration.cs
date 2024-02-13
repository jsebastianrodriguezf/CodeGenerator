using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoTrasladoConfiguration : IEntityTypeConfiguration<DocDocumentoTraslado>
{
    public void Configure(EntityTypeBuilder<DocDocumentoTraslado> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_traslado");

        builder.ToTable("doc_documento.traslado");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_traslado");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoTraslado)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.traslado");
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
        builder.Property(e => e.IdBodegaDestino).HasColumnName("id_bodega_destino");
        builder.Property(e => e.IdBodegaOrigen).HasColumnName("id_bodega_origen");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdBodegaDestinoNavigation).WithMany(p => p.DocDocumentoTrasladoIdBodegaDestinoNavigations)
            .HasForeignKey(d => d.IdBodegaDestino)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_traslado_id_bodega_destino");

        builder.HasOne(d => d.IdBodegaOrigenNavigation).WithMany(p => p.DocDocumentoTrasladoIdBodegaOrigenNavigations)
            .HasForeignKey(d => d.IdBodegaOrigen)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_traslado_id_bodega_origen");
    }
}
