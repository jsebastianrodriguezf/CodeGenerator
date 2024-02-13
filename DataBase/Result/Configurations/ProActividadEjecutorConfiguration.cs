using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProActividadEjecutorConfiguration : IEntityTypeConfiguration<ProActividadEjecutor>
{
    public void Configure(EntityTypeBuilder<ProActividadEjecutor> builder)
    {
        builder.ToTable("pro_actividad_ejecutor");

        builder.HasIndex(e => e.Eid, "IX_pro_actividad_ejecutor");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ActividadEjecutor)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("actividad_ejecutor");
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
        builder.Property(e => e.IdActividad).HasColumnName("id_actividad");
        builder.Property(e => e.IdEjecutores).HasColumnName("id_ejecutores");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdActividadNavigation).WithMany(p => p.ProActividadEjecutors)
            .HasForeignKey(d => d.IdActividad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_actividad_ejecutor_id_actividad");

        builder.HasOne(d => d.IdEjecutoresNavigation).WithMany(p => p.ProActividadEjecutors)
            .HasForeignKey(d => d.IdEjecutores)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_actividad_ejecutor_id_ejecutores");
    }
}
