using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatAtributoOpcionAtributoConfiguration : IEntityTypeConfiguration<CatAtributoOpcionAtributo>
{
    public void Configure(EntityTypeBuilder<CatAtributoOpcionAtributo> builder)
    {
        builder.ToTable("cat_atributo_opcionAtributo");

        builder.HasIndex(e => e.Eid, "IX_cat_atributo_opcionAtributo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AtributoOpcionAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("atributo_opcionAtributo");
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
        builder.Property(e => e.IdAtributo)
            .HasDefaultValue(0)
            .HasColumnName("id_atributo");
        builder.Property(e => e.IdOpcionAtributo)
            .HasDefaultValue(0)
            .HasColumnName("id_opcionAtributo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.CatAtributoOpcionAtributos)
            .HasForeignKey(d => d.IdAtributo)
            .HasConstraintName("FK__cat_atrib__id_at__37343DE3");

        builder.HasOne(d => d.IdOpcionAtributoNavigation).WithMany(p => p.CatAtributoOpcionAtributos)
            .HasForeignKey(d => d.IdOpcionAtributo)
            .HasConstraintName("FK__cat_atrib__id_op__391C8655");
    }
}
