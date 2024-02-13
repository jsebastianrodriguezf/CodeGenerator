using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewRepCategoriumConfiguration : IEntityTypeConfiguration<ViewRepCategorium>
{
    public void Configure(EntityTypeBuilder<ViewRepCategorium> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_rep_categoria");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Categoria)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("categoria");
        builder.Property(e => e.CategoriaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("categoria_codigo");
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
        builder.Property(e => e.IdCategoria).HasColumnName("id_categoria");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.RepCategoriaPadreCategoria)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("rep_categoria_padre_categoria");
        builder.Property(e => e.RepCategoriaPadreCategoriaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("rep_categoria_padre_categoria_codigo");
        builder.Property(e => e.RepCategoriaPadreIdCategoria).HasColumnName("rep_categoria_padre_id_categoria");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
