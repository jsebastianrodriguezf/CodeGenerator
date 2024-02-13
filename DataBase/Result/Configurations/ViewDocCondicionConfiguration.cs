using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocCondicionConfiguration : IEntityTypeConfiguration<ViewDocCondicion>
{
    public void Configure(EntityTypeBuilder<ViewDocCondicion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_condicion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Condicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("condicion");
        builder.Property(e => e.CondicionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("condicion_codigo");
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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.TextoLibre).HasColumnName("textoLibre");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
