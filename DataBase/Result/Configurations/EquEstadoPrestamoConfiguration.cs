using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquEstadoPrestamoConfiguration : IEntityTypeConfiguration<EquEstadoPrestamo>
{
    public void Configure(EntityTypeBuilder<EquEstadoPrestamo> builder)
    {
        builder.ToTable("equ_estadoPrestamo");

        builder.HasIndex(e => e.Eid, "IX_equ_estadoPrestamo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstadoPrestamo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("estadoPrestamo");
        builder.Property(e => e.EstadoPrestamoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("estadoPrestamo_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
