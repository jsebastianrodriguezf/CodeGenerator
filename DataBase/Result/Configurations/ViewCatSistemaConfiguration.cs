using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatSistemaConfiguration : IEntityTypeConfiguration<ViewCatSistema>
{
    public void Configure(EntityTypeBuilder<ViewCatSistema> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_sistema");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatSistemaPadreIdSistema).HasColumnName("cat_sistema_padre_id_sistema");
        builder.Property(e => e.CatSistemaPadreSistema)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_padre_sistema");
        builder.Property(e => e.CatSistemaPadreSistemaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_padre_sistema_codigo");
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
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Sistema)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sistema");
        builder.Property(e => e.SistemaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("sistema_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
