using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewProActividadConfiguration : IEntityTypeConfiguration<ViewProActividad>
{
    public void Configure(EntityTypeBuilder<ViewProActividad> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_pro_actividad");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Actividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("actividad");
        builder.Property(e => e.ActividadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("actividad_codigo");
        builder.Property(e => e.DescripcionDetallada)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("descripcionDetallada");
        builder.Property(e => e.Duracion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("duracion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaInicioReal)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioReal");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaTerminacionPlaneada)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaTerminacionPlaneada");
        builder.Property(e => e.FechaTerminacionProyectada)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaTerminacionProyectada");
        builder.Property(e => e.FechaTerminacionReal)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaTerminacionReal");
        builder.Property(e => e.FechainicioPlaneada)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechainicioPlaneada");
        builder.Property(e => e.FechainicioProyectada)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechainicioProyectada");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
