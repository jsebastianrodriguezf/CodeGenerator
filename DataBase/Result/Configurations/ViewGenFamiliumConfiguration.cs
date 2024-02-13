using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenFamiliumConfiguration : IEntityTypeConfiguration<ViewGenFamilium>
{
    public void Configure(EntityTypeBuilder<ViewGenFamilium> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_familia");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Familia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("familia");
        builder.Property(e => e.FamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("familia_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenFamiliaPadreFamilia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_familia_padre_familia");
        builder.Property(e => e.GenFamiliaPadreFamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_familia_padre_familia_codigo");
        builder.Property(e => e.GenFamiliaPadreIdFamilia).HasColumnName("gen_familia_padre_id_familia");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdFamilia).HasColumnName("id_familia");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
