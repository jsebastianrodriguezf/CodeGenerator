using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProSesionActividadConfiguration : IEntityTypeConfiguration<ProSesionActividad>
{
    public void Configure(EntityTypeBuilder<ProSesionActividad> builder)
    {
        builder.ToTable("pro_SesionActividad");

        builder.HasIndex(e => e.Eid, "IX_pro_SesionActividad");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(3000)
            .IsUnicode(false)
            .HasColumnName("descripcion");
        builder.Property(e => e.Duracion).HasColumnName("duracion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaInicio)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_inicio");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdActividad).HasColumnName("id_actividad");
        builder.Property(e => e.IdEjecutores).HasColumnName("id_ejecutores");
        builder.Property(e => e.IdGrupoSesion).HasColumnName("id_GrupoSesion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.SesionActividad)
            .HasMaxLength(300)
            .IsUnicode(false);
        builder.Property(e => e.SesionActividadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("SesionActividad_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdActividadNavigation).WithMany(p => p.ProSesionActividads)
            .HasForeignKey(d => d.IdActividad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_SesionActividad_id_actividad");

        builder.HasOne(d => d.IdEjecutoresNavigation).WithMany(p => p.ProSesionActividads)
            .HasForeignKey(d => d.IdEjecutores)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_SesionActividad_id_ejecutores");

        builder.HasOne(d => d.IdGrupoSesionNavigation).WithMany(p => p.ProSesionActividads)
            .HasForeignKey(d => d.IdGrupoSesion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_SesionActividad_id_GrupoSesion");
    }
}
