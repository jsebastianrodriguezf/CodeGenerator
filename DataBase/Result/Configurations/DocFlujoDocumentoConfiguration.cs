using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocFlujoDocumentoConfiguration : IEntityTypeConfiguration<DocFlujoDocumento>
{
    public void Configure(EntityTypeBuilder<DocFlujoDocumento> builder)
    {
        builder.ToTable("doc_flujoDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_flujoDocumento");

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
        builder.Property(e => e.FlujoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("flujoDocumento");
        builder.Property(e => e.FlujoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("flujoDocumento_codigo");
        builder.Property(e => e.IdEstadoTipoDocumentoOrigen).HasColumnName("id_estadoTipoDocumento_origen");
        builder.Property(e => e.IdEstadoTipoDocumentoResultado).HasColumnName("id_estadoTipoDocumento_resultado");
        builder.Property(e => e.IdSubtipoDocumentoDestino).HasColumnName("id_subtipoDocumento_destino");
        builder.Property(e => e.IdSubtipoDocumentoOrigen).HasColumnName("id_subtipoDocumento_origen");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ReplicarAtributos).HasColumnName("replicarAtributos");
        builder.Property(e => e.ReplicarComentario).HasColumnName("replicarComentario");
        builder.Property(e => e.ReplicarItems).HasColumnName("replicarItems");
        builder.Property(e => e.ReplicarItemsActividades).HasColumnName("replicarItemsActividades");
        builder.Property(e => e.Restrictivo).HasColumnName("restrictivo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEstadoTipoDocumentoOrigenNavigation).WithMany(p => p.DocFlujoDocumentoIdEstadoTipoDocumentoOrigenNavigations)
            .HasForeignKey(d => d.IdEstadoTipoDocumentoOrigen)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_flujoDocumento_id_estadoTipoDocumento_origen");

        builder.HasOne(d => d.IdEstadoTipoDocumentoResultadoNavigation).WithMany(p => p.DocFlujoDocumentoIdEstadoTipoDocumentoResultadoNavigations)
            .HasForeignKey(d => d.IdEstadoTipoDocumentoResultado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_flujoDocumento_id_estadoTipoDocumento_resultado");

        builder.HasOne(d => d.IdSubtipoDocumentoDestinoNavigation).WithMany(p => p.DocFlujoDocumentoIdSubtipoDocumentoDestinoNavigations)
            .HasForeignKey(d => d.IdSubtipoDocumentoDestino)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_flujoDocumento_id_subtipoDocumento_destino");

        builder.HasOne(d => d.IdSubtipoDocumentoOrigenNavigation).WithMany(p => p.DocFlujoDocumentoIdSubtipoDocumentoOrigenNavigations)
            .HasForeignKey(d => d.IdSubtipoDocumentoOrigen)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_flujoDocumento_id_subtipoDocumento_origen");
    }
}
