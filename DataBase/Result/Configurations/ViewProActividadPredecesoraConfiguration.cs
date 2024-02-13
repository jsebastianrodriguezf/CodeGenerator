using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewProActividadPredecesoraConfiguration : IEntityTypeConfiguration<ViewProActividadPredecesora>
{
    public void Configure(EntityTypeBuilder<ViewProActividadPredecesora> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_pro_actividadPredecesora");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.ActividadPredecesora)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("actividadPredecesora");
        builder.Property(e => e.ActividadPredecesoraCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("actividadPredecesora_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdActividadDestino).HasColumnName("id_actividad_destino");
        builder.Property(e => e.IdActividadOrigen).HasColumnName("id_actividad_origen");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ProActividadDestinoActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_destino_actividad");
        builder.Property(e => e.ProActividadDestinoActividadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_destino_actividad_codigo");
        builder.Property(e => e.ProActividadDestinoDescripcionDetallada)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_destino_descripcionDetallada");
        builder.Property(e => e.ProActividadDestinoDuracion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_destino_duracion");
        builder.Property(e => e.ProActividadDestinoFechaInicioReal)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_destino_fechaInicioReal");
        builder.Property(e => e.ProActividadDestinoFechaTerminacionPlaneada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_destino_fechaTerminacionPlaneada");
        builder.Property(e => e.ProActividadDestinoFechaTerminacionProyectada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_destino_fechaTerminacionProyectada");
        builder.Property(e => e.ProActividadDestinoFechaTerminacionReal)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_destino_fechaTerminacionReal");
        builder.Property(e => e.ProActividadDestinoFechainicioPlaneada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_destino_fechainicioPlaneada");
        builder.Property(e => e.ProActividadDestinoFechainicioProyectada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_destino_fechainicioProyectada");
        builder.Property(e => e.ProActividadOrigenActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_origen_actividad");
        builder.Property(e => e.ProActividadOrigenActividadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_origen_actividad_codigo");
        builder.Property(e => e.ProActividadOrigenDescripcionDetallada)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_origen_descripcionDetallada");
        builder.Property(e => e.ProActividadOrigenDuracion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_origen_duracion");
        builder.Property(e => e.ProActividadOrigenFechaInicioReal)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_origen_fechaInicioReal");
        builder.Property(e => e.ProActividadOrigenFechaTerminacionPlaneada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_origen_fechaTerminacionPlaneada");
        builder.Property(e => e.ProActividadOrigenFechaTerminacionProyectada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_origen_fechaTerminacionProyectada");
        builder.Property(e => e.ProActividadOrigenFechaTerminacionReal)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_origen_fechaTerminacionReal");
        builder.Property(e => e.ProActividadOrigenFechainicioPlaneada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_origen_fechainicioPlaneada");
        builder.Property(e => e.ProActividadOrigenFechainicioProyectada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_origen_fechainicioProyectada");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
