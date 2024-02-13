using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegCargoActividadConfiguration : IEntityTypeConfiguration<SegCargoActividad>
{
    public void Configure(EntityTypeBuilder<SegCargoActividad> builder)
    {
        builder.ToTable("seg_cargo_actividad");

        builder.HasIndex(e => e.Eid, "IX_seg_cargo_actividad");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CargoActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cargo_actividad");
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
        builder.Property(e => e.IdCargo).HasColumnName("id_cargo");
        builder.Property(e => e.IdCatalogoActividad).HasColumnName("id_catalogo.actividad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCargoNavigation).WithMany(p => p.SegCargoActividads)
            .HasForeignKey(d => d.IdCargo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_cargo_actividad_id_cargo");

        builder.HasOne(d => d.IdCatalogoActividadNavigation).WithMany(p => p.SegCargoActividads)
            .HasForeignKey(d => d.IdCatalogoActividad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_cargo_actividad_id_catalogo_actividad");
    }
}
