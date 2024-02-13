using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoSalidumConfiguration : IEntityTypeConfiguration<DocDocumentoSalidum>
{
    public void Configure(EntityTypeBuilder<DocDocumentoSalidum> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_salida");

        builder.ToTable("doc_documento.salida");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_salida");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Asunto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("asunto");
        builder.Property(e => e.DireccionEntrega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("direccionEntrega");
        builder.Property(e => e.DocumentoSalida)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.salida");
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
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTerceroTransportador).HasColumnName("id_tercero_transportador");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioRecibe).HasColumnName("id_usuario_recibe");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("observaciones");
        builder.Property(e => e.Solicitante)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("solicitante");
        builder.Property(e => e.TelefonoEntrega)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("telefonoEntrega");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.DocDocumentoSalida)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_salida_id_sucursal");

        builder.HasOne(d => d.IdTerceroTransportadorNavigation).WithMany(p => p.DocDocumentoSalida)
            .HasForeignKey(d => d.IdTerceroTransportador)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_salida_id_tercero_transportador");

        builder.HasOne(d => d.IdUsuarioRecibeNavigation).WithMany(p => p.DocDocumentoSalida)
            .HasForeignKey(d => d.IdUsuarioRecibe)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_salida_id_usuario_recibe");
    }
}
