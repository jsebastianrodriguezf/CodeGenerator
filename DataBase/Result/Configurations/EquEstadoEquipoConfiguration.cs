using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquEstadoEquipoConfiguration : IEntityTypeConfiguration<EquEstadoEquipo>
{
    public void Configure(EntityTypeBuilder<EquEstadoEquipo> builder)
    {
        builder.ToTable("equ_estadoEquipo");

        builder.HasIndex(e => e.Eid, "IX_equ_estadoEquipo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Activo).HasColumnName("activo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstadoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("estadoEquipo");
        builder.Property(e => e.EstadoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("estadoEquipo_codigo");
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
