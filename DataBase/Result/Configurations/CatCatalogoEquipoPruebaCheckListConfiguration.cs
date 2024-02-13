using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatCatalogoEquipoPruebaCheckListConfiguration : IEntityTypeConfiguration<CatCatalogoEquipoPruebaCheckList>
{
    public void Configure(EntityTypeBuilder<CatCatalogoEquipoPruebaCheckList> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_cat_catalogo_equipo_pruebaCheckList");

        builder.ToTable("cat_catalogo.equipo_pruebaCheckList");

        builder.HasIndex(e => e.Eid, "IX_cat_catalogo_equipo_pruebaCheckList");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CatalogoEquipoPruebaCheckList)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.equipo_pruebaCheckList");
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
        builder.Property(e => e.IdCatalogoEquipo).HasColumnName("id_catalogo.equipo");
        builder.Property(e => e.IdPruebaCheckList).HasColumnName("id_pruebaCheckList");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoEquipoNavigation).WithMany(p => p.CatCatalogoEquipoPruebaCheckLists)
            .HasForeignKey(d => d.IdCatalogoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_equipo_pruebaCheckList_id_catalogo_equipo");

        builder.HasOne(d => d.IdPruebaCheckListNavigation).WithMany(p => p.CatCatalogoEquipoPruebaCheckLists)
            .HasForeignKey(d => d.IdPruebaCheckList)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_equipo_pruebaCheckList_id_pruebaCheckList");
    }
}
