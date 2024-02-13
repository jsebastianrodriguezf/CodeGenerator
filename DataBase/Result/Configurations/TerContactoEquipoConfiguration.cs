using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TerContactoEquipoConfiguration : IEntityTypeConfiguration<TerContactoEquipo>
{
    public void Configure(EntityTypeBuilder<TerContactoEquipo> builder)
    {
        builder.ToTable("ter_contacto_equipo");

        builder.HasIndex(e => e.Eid, "IX_ter_contacto_equipo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ContactoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contacto_equipo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstadoContacto).HasColumnName("estado_contacto");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdContacto).HasColumnName("id_contacto");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdContactoNavigation).WithMany(p => p.TerContactoEquipos)
            .HasForeignKey(d => d.IdContacto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__ter_conta__id_co__423CA792");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.TerContactoEquipos)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__ter_conta__id_eq__3D77F275");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TerContactoEquipos)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__ter_conta__id_us__3F603AE7");
    }
}
