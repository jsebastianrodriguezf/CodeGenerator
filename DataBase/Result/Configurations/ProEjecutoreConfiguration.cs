using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProEjecutoreConfiguration : IEntityTypeConfiguration<ProEjecutore>
{
    public void Configure(EntityTypeBuilder<ProEjecutore> builder)
    {
        builder.ToTable("pro_ejecutores");

        builder.HasIndex(e => e.Eid, "IX_pro_ejecutores");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Costo).HasColumnName("costo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Ejecutores)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ejecutores");
        builder.Property(e => e.EjecutoresCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ejecutores_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdHorarioEjecutores).HasColumnName("id_horarioEjecutores");
        builder.Property(e => e.IdHorarioTrabajo).HasColumnName("id_horarioTrabajo");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UnidadTiempo)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("unidadTiempo");

        builder.HasOne(d => d.IdHorarioEjecutoresNavigation).WithMany(p => p.ProEjecutores)
            .HasForeignKey(d => d.IdHorarioEjecutores)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_pro_ejecutores_id_horarioEjecutores");

        builder.HasOne(d => d.IdHorarioTrabajoNavigation).WithMany(p => p.ProEjecutores)
            .HasForeignKey(d => d.IdHorarioTrabajo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_pro_ejecutores_id_horarioTrabajo");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.ProEjecutores)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_pro_ejecutores_id_usuario");
    }
}
