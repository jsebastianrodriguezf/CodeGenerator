using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoGastoConfiguration : IEntityTypeConfiguration<DocDocumentoGasto>
{
    public void Configure(EntityTypeBuilder<DocDocumentoGasto> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_gasto");

        builder.ToTable("doc_documento.gasto");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_gasto");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Concepto)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("concepto");
        builder.Property(e => e.Consignado).HasColumnName("consignado");
        builder.Property(e => e.Dias).HasColumnName("dias");
        builder.Property(e => e.DocumentoGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.gasto");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasDefaultValueSql("((0))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioSolicitante).HasColumnName("id_usuario_solicitante");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdNavigation).WithOne(p => p.DocDocumentoGasto)
            .HasForeignKey<DocDocumentoGasto>(d => d.Id)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_gasto_doc_documento");
    }
}
