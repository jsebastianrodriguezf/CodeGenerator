using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatVersionEquipoConfiguration : IEntityTypeConfiguration<CatVersionEquipo>
{
    public void Configure(EntityTypeBuilder<CatVersionEquipo> builder)
    {
        builder.ToTable("cat_versionEquipo");

        builder.HasIndex(e => e.Eid, "IX_cat_versionEquipo");

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
        builder.Property(e => e.IdCatalogoEquipo).HasColumnName("id_catalogo.equipo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.VersionEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("versionEquipo");
        builder.Property(e => e.VersionEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("versionEquipo_codigo");

        builder.HasOne(d => d.IdCatalogoEquipoNavigation).WithMany(p => p.CatVersionEquipos)
            .HasForeignKey(d => d.IdCatalogoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_versionEquipo_id_catalogo_equipo");
    }
}
