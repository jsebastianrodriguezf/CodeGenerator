using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatPruebaCheckListAtributoConfiguration : IEntityTypeConfiguration<CatPruebaCheckListAtributo>
{
    public void Configure(EntityTypeBuilder<CatPruebaCheckListAtributo> builder)
    {
        builder.ToTable("cat_pruebaCheckList_atributo");

        builder.HasIndex(e => e.Eid, "IX_cat_pruebaCheckList_atributo");

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
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdPruebaCheckList).HasColumnName("id_pruebaCheckList");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.PruebaCheckListAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pruebaCheckList_atributo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.CatPruebaCheckListAtributos)
            .HasForeignKey(d => d.IdAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_pruebaCheckList_atributo_id_atributo");

        builder.HasOne(d => d.IdPruebaCheckListNavigation).WithMany(p => p.CatPruebaCheckListAtributos)
            .HasForeignKey(d => d.IdPruebaCheckList)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_pruebaCheckList_atributo_id_pruebaCheckList");
    }
}
