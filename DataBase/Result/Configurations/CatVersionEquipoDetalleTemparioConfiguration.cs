using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatVersionEquipoDetalleTemparioConfiguration : IEntityTypeConfiguration<CatVersionEquipoDetalleTempario>
{
    public void Configure(EntityTypeBuilder<CatVersionEquipoDetalleTempario> builder)
    {
        builder.ToTable("cat_versionEquipo_detalleTempario");

        builder.HasIndex(e => e.Eid, "IX_cat_versionEquipo_detalleTempario");

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
        builder.Property(e => e.IdDetalleTempario).HasColumnName("id_detalleTempario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdVersionEquipo).HasColumnName("id_versionEquipo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.VersionEquipoDetalleTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("versionEquipo_detalleTempario");

        builder.HasOne(d => d.IdDetalleTemparioNavigation).WithMany(p => p.CatVersionEquipoDetalleTemparios)
            .HasForeignKey(d => d.IdDetalleTempario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_versionEquipo_detalleTempario_id_detalleTempario");

        builder.HasOne(d => d.IdVersionEquipoNavigation).WithMany(p => p.CatVersionEquipoDetalleTemparios)
            .HasForeignKey(d => d.IdVersionEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_versionEquipo_detalleTempario_id_versionEquipo");
    }
}
