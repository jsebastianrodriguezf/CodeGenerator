using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquPrestamoEquipoConfiguration : IEntityTypeConfiguration<EquPrestamoEquipo>
{
    public void Configure(EntityTypeBuilder<EquPrestamoEquipo> builder)
    {
        builder.ToTable("equ_prestamo_equipo");

        builder.HasIndex(e => e.Eid, "IX_equ_prestamo_equipo");

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
        builder.Property(e => e.FechaDevolucionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaDevolucion_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdPrestamo).HasColumnName("id_prestamo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PrestamoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("prestamo_equipo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.EquPrestamoEquipos)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_prestamo_equipo_id_equipo");

        builder.HasOne(d => d.IdPrestamoNavigation).WithMany(p => p.EquPrestamoEquipos)
            .HasForeignKey(d => d.IdPrestamo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_prestamo_equipo_id_prestamo");
    }
}
