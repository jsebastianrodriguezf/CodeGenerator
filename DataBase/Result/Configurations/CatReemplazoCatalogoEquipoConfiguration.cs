using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatReemplazoCatalogoEquipoConfiguration : IEntityTypeConfiguration<CatReemplazoCatalogoEquipo>
{
    public void Configure(EntityTypeBuilder<CatReemplazoCatalogoEquipo> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_cat_reemplazo_catalogo_equipo");

        builder.ToTable("cat_reemplazo_catalogo.equipo");

        builder.HasIndex(e => e.Eid, "IX_cat_reemplazo_catalogo_equipo");

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
        builder.Property(e => e.IdReemplazo).HasColumnName("id_reemplazo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdVersionEquipo).HasColumnName("id_versionEquipo");
        builder.Property(e => e.ReemplazoCatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("reemplazo_catalogo.equipo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoEquipoNavigation).WithMany(p => p.CatReemplazoCatalogoEquipos)
            .HasForeignKey(d => d.IdCatalogoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_reemplazo_catalogo_equipo_id_catalogo_equipo");

        builder.HasOne(d => d.IdReemplazoNavigation).WithMany(p => p.CatReemplazoCatalogoEquipos)
            .HasForeignKey(d => d.IdReemplazo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_reemplazo_catalogo_equipo_id_reemplazo");

        builder.HasOne(d => d.IdVersionEquipoNavigation).WithMany(p => p.CatReemplazoCatalogoEquipos)
            .HasForeignKey(d => d.IdVersionEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_reemplazo_catalogo_equipo_id_versionEquipo");
    }
}
