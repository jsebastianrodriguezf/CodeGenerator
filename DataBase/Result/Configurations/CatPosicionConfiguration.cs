using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatPosicionConfiguration : IEntityTypeConfiguration<CatPosicion>
{
    public void Configure(EntityTypeBuilder<CatPosicion> builder)
    {
        builder.ToTable("cat_posicion");

        builder.HasIndex(e => e.Eid, "IX_cat_posicion");

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
        builder.Property(e => e.IdCatalogoEquipoComponente).HasColumnName("id_catalogo.equipo_componente");
        builder.Property(e => e.IdCatalogoEquipoEquipo).HasColumnName("id_catalogo.equipo_equipo");
        builder.Property(e => e.IdDimensionX).HasColumnName("id_dimension_x");
        builder.Property(e => e.IdDimensionY).HasColumnName("id_dimension_y");
        builder.Property(e => e.IdDimensionZ).HasColumnName("id_dimension_z");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Posicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("posicion");
        builder.Property(e => e.PosicionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("posicion_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoEquipoComponenteNavigation).WithMany(p => p.CatPosicionIdCatalogoEquipoComponenteNavigations)
            .HasForeignKey(d => d.IdCatalogoEquipoComponente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_posicion_id_catalogo_equipo_componente");

        builder.HasOne(d => d.IdCatalogoEquipoEquipoNavigation).WithMany(p => p.CatPosicionIdCatalogoEquipoEquipoNavigations)
            .HasForeignKey(d => d.IdCatalogoEquipoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_posicion_id_catalogo_equipo_equipo");

        builder.HasOne(d => d.IdDimensionXNavigation).WithMany(p => p.CatPosicionIdDimensionXNavigations)
            .HasForeignKey(d => d.IdDimensionX)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_posicion_id_dimension_x");

        builder.HasOne(d => d.IdDimensionYNavigation).WithMany(p => p.CatPosicionIdDimensionYNavigations)
            .HasForeignKey(d => d.IdDimensionY)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_posicion_id_dimension_y");

        builder.HasOne(d => d.IdDimensionZNavigation).WithMany(p => p.CatPosicionIdDimensionZNavigations)
            .HasForeignKey(d => d.IdDimensionZ)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_posicion_id_dimension_z");
    }
}
