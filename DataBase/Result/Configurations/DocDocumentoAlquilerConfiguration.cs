using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoAlquilerConfiguration : IEntityTypeConfiguration<DocDocumentoAlquiler>
{
    public void Configure(EntityTypeBuilder<DocDocumentoAlquiler> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_alquiler");

        builder.ToTable("doc_documento.alquiler");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_alquiler");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DocumentoAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.alquiler");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EjecutaDevolucion)
            .HasDefaultValue(true)
            .HasColumnName("ejecutaDevolucion");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFin_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MesVencido)
            .HasDefaultValue(true)
            .HasColumnName("mesVencido");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(3000)
            .IsUnicode(false)
            .HasColumnName("observaciones");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
