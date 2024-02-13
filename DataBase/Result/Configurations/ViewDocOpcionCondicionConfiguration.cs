using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocOpcionCondicionConfiguration : IEntityTypeConfiguration<ViewDocOpcionCondicion>
{
    public void Configure(EntityTypeBuilder<ViewDocOpcionCondicion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_opcionCondicion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocCondicionCondicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_condicion_condicion");
        builder.Property(e => e.DocCondicionCondicionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_condicion_condicion_codigo");
        builder.Property(e => e.DocCondicionTextoLibre).HasColumnName("doc_condicion_textoLibre");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCondicion).HasColumnName("id_condicion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.OpcionCondicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("opcionCondicion");
        builder.Property(e => e.OpcionCondicionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("opcionCondicion_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
