using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProActividadRecursoFisicoConfiguration : IEntityTypeConfiguration<ProActividadRecursoFisico>
{
    public void Configure(EntityTypeBuilder<ProActividadRecursoFisico> builder)
    {
        builder.ToTable("pro_actividad_recursoFisico");

        builder.HasIndex(e => e.Eid, "IX_pro_actividad_recursoFisico");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ActividadRecursoFisico)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("actividad_recursoFisico");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
        builder.Property(e => e.Duracion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("duracion");
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
        builder.Property(e => e.IdRecursoFisico).HasColumnName("id_recursoFisico");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdActividadNavigation).WithMany(p => p.ProActividadRecursoFisicos)
            .HasForeignKey(d => d.IdActividad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_actividad_recursoFisico_id_actividad");

        builder.HasOne(d => d.IdRecursoFisicoNavigation).WithMany(p => p.ProActividadRecursoFisicos)
            .HasForeignKey(d => d.IdRecursoFisico)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_actividad_recursoFisico_id_recursoFisico");
    }
}
