using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatCatalogoEquipoConfiguration : IEntityTypeConfiguration<CatCatalogoEquipo>
{
    public void Configure(EntityTypeBuilder<CatCatalogoEquipo> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_cat_catalogo_equipo");

        builder.ToTable("cat_catalogo.equipo");

        builder.HasIndex(e => e.Eid, "IX_cat_catalogo_equipo");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.equipo");
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
        builder.Property(e => e.GarantiaHoras).HasColumnName("garantiaHoras");
        builder.Property(e => e.GarantiaMeses).HasColumnName("garantiaMeses");
        builder.Property(e => e.IdMarca).HasColumnName("id_marca");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ManejaHorometro).HasColumnName("manejaHorometro");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.CatCatalogoEquipos)
            .HasForeignKey(d => d.IdMarca)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_equipo_id_marca");
    }
}
