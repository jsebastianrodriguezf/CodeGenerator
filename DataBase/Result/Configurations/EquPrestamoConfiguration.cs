using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquPrestamoConfiguration : IEntityTypeConfiguration<EquPrestamo>
{
    public void Configure(EntityTypeBuilder<EquPrestamo> builder)
    {
        builder.ToTable("equ_prestamo");

        builder.HasIndex(e => e.Eid, "IX_equ_prestamo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCompromisoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCompromiso_ff");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaPrestamoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaPrestamo_ff");
        builder.Property(e => e.IdEstadoPrestamo).HasColumnName("id_estadoPrestamo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioEntrego).HasColumnName("id_usuario_entrego");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Notas)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("notas");
        builder.Property(e => e.Prestamo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("prestamo");
        builder.Property(e => e.PrestamoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("prestamo_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEstadoPrestamoNavigation).WithMany(p => p.EquPrestamos)
            .HasForeignKey(d => d.IdEstadoPrestamo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_prestamo_id_estadoPrestamo");

        builder.HasOne(d => d.IdUsuarioEntregoNavigation).WithMany(p => p.EquPrestamos)
            .HasForeignKey(d => d.IdUsuarioEntrego)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_prestamo_id_usuario_entrego");
    }
}
