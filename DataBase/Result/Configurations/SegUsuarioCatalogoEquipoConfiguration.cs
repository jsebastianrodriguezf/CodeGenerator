using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegUsuarioCatalogoEquipoConfiguration : IEntityTypeConfiguration<SegUsuarioCatalogoEquipo>
{
    public void Configure(EntityTypeBuilder<SegUsuarioCatalogoEquipo> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_seg_usuario_catalogo_equipo");

        builder.ToTable("seg_usuario_catalogo.equipo");

        builder.HasIndex(e => e.Eid, "IX_seg_usuario_catalogo_equipo");

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
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UsuarioCatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("usuario_catalogo.equipo");

        builder.HasOne(d => d.IdCatalogoEquipoNavigation).WithMany(p => p.SegUsuarioCatalogoEquipos)
            .HasForeignKey(d => d.IdCatalogoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_usuario_catalogo_equipo_id_catalogo_equipo");

        builder.HasOne(d => d.IdTipoServicioNavigation).WithMany(p => p.SegUsuarioCatalogoEquipos)
            .HasForeignKey(d => d.IdTipoServicio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_usuario_catalogo_equipo_id_tipoServicio");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.SegUsuarioCatalogoEquipos)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_usuario_catalogo_equipo_id_usuario");
    }
}
