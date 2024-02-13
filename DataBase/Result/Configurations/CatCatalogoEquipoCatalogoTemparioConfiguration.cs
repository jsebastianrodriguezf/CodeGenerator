using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatCatalogoEquipoCatalogoTemparioConfiguration : IEntityTypeConfiguration<CatCatalogoEquipoCatalogoTempario>
{
    public void Configure(EntityTypeBuilder<CatCatalogoEquipoCatalogoTempario> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_cat_catalogo_equipo_catalogo_tempario");

        builder.ToTable("cat_catalogo.equipo_catalogo.tempario");

        builder.HasIndex(e => e.Eid, "IX_cat_catalogo_equipo_catalogo_tempario");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CatalogoEquipoCatalogoTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.equipo_catalogo.tempario");
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
        builder.Property(e => e.IdCatalogoTempario).HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoEquipoNavigation).WithMany(p => p.CatCatalogoEquipoCatalogoTemparios)
            .HasForeignKey(d => d.IdCatalogoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_equipo_catalogo_tempario_id_catalogo_equipo");

        builder.HasOne(d => d.IdCatalogoTemparioNavigation).WithMany(p => p.CatCatalogoEquipoCatalogoTemparios)
            .HasForeignKey(d => d.IdCatalogoTempario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_equipo_catalogo_tempario_id_catalogo_tempario");
    }
}
