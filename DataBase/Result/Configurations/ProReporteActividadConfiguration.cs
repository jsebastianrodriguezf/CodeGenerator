using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProReporteActividadConfiguration : IEntityTypeConfiguration<ProReporteActividad>
{
    public void Configure(EntityTypeBuilder<ProReporteActividad> builder)
    {
        builder.ToTable("pro_reporteActividad");

        builder.HasIndex(e => e.Eid, "IX_pro_reporteActividad");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Duracion)
            .HasDefaultValue(0.0)
            .HasColumnName("duracion");
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
        builder.Property(e => e.IdSesionActividad).HasColumnName("id_SesionActividad");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PorcentajeAvance)
            .HasDefaultValue(0.0)
            .HasColumnName("porcentaje_avance");
        builder.Property(e => e.ReporteActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("reporteActividad");
        builder.Property(e => e.ReporteActividadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("reporteActividad_codigo");
        builder.Property(e => e.Texto)
            .HasMaxLength(3000)
            .IsUnicode(false)
            .HasColumnName("texto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdActividadNavigation).WithMany(p => p.ProReporteActividads)
            .HasForeignKey(d => d.IdActividad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_reporteActividad_id_actividad");

        builder.HasOne(d => d.IdEjecutoresNavigation).WithMany(p => p.ProReporteActividads)
            .HasForeignKey(d => d.IdEjecutores)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_reporteActividad_id_ejecutores");

        builder.HasOne(d => d.IdSesionActividadNavigation).WithMany(p => p.ProReporteActividads)
            .HasForeignKey(d => d.IdSesionActividad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_reporteActividad_id_SesionActividad");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.ProReporteActividads)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_reporteActividad_id_sucursal");
    }
}
