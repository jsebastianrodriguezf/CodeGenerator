using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatSistemaCatalogoEquipoConfiguration : IEntityTypeConfiguration<CatSistemaCatalogoEquipo>
{
    public void Configure(EntityTypeBuilder<CatSistemaCatalogoEquipo> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_cat_sistema_catalogo_equipo");

        builder.ToTable("cat_sistema_catalogo.equipo");

        builder.HasIndex(e => e.Eid, "IX_cat_sistema_catalogo_equipo");

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
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdVersionEquipo).HasColumnName("id_versionEquipo");
        builder.Property(e => e.SistemaCatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sistema_catalogo.equipo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoEquipoNavigation).WithMany(p => p.CatSistemaCatalogoEquipos)
            .HasForeignKey(d => d.IdCatalogoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_sistema_catalogo_equipo_id_catalogo_equipo");

        builder.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.CatSistemaCatalogoEquipos)
            .HasForeignKey(d => d.IdSistema)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_sistema_catalogo_equipo_id_sistema");

        builder.HasOne(d => d.IdVersionEquipoNavigation).WithMany(p => p.CatSistemaCatalogoEquipos)
            .HasForeignKey(d => d.IdVersionEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_sistema_catalogo_equipo_id_versionEquipo");
    }
}
