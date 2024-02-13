using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocSubtipoLecturaConfiguration : IEntityTypeConfiguration<DocSubtipoLectura>
{
    public void Configure(EntityTypeBuilder<DocSubtipoLectura> builder)
    {
        builder.ToTable("doc_subtipoLectura");

        builder.HasIndex(e => e.Eid, "IX_doc_subtipoLectura");

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
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdSubtipoDocumentoOrigen).HasColumnName("id_subtipoDocumento_origen");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.SubtipoLectura)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("subtipoLectura");
        builder.Property(e => e.SubtipoLecturaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("subtipoLectura_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
