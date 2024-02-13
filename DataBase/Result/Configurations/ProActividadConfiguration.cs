using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProActividadConfiguration : IEntityTypeConfiguration<ProActividad>
{
    public void Configure(EntityTypeBuilder<ProActividad> builder)
    {
        builder.ToTable("pro_actividad");

        builder.HasIndex(e => e.Eid, "IX_pro_actividad");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
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
            .HasDefaultValueSql("((0))")
            .HasColumnName("descripcionDetallada");
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
        builder.Property(e => e.FechaInicioReal)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioReal");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaTerminacionPlaneada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaTerminacionPlaneada");
        builder.Property(e => e.FechaTerminacionProyectada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaTerminacionProyectada");
        builder.Property(e => e.FechaTerminacionReal)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaTerminacionReal");
        builder.Property(e => e.FechainicioPlaneada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechainicioPlaneada");
        builder.Property(e => e.FechainicioProyectada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechainicioProyectada");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
