using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewProSesionActividadConfiguration : IEntityTypeConfiguration<ViewProSesionActividad>
{
    public void Configure(EntityTypeBuilder<ViewProSesionActividad> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_pro_SesionActividad");

        builder.Property(e => e.Active).HasColumnName("active");
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
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaInicio)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_inicio");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdActividad).HasColumnName("id_actividad");
        builder.Property(e => e.IdEjecutores).HasColumnName("id_ejecutores");
        builder.Property(e => e.IdGrupoSesion).HasColumnName("id_GrupoSesion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ProActividadActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_actividad");
        builder.Property(e => e.ProActividadActividadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_actividad_codigo");
        builder.Property(e => e.ProActividadDescripcionDetallada)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_descripcionDetallada");
        builder.Property(e => e.ProActividadDuracion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_actividad_duracion");
        builder.Property(e => e.ProActividadFechaInicioReal)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_fechaInicioReal");
        builder.Property(e => e.ProActividadFechaTerminacionPlaneada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_fechaTerminacionPlaneada");
        builder.Property(e => e.ProActividadFechaTerminacionProyectada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_fechaTerminacionProyectada");
        builder.Property(e => e.ProActividadFechaTerminacionReal)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_fechaTerminacionReal");
        builder.Property(e => e.ProActividadFechainicioPlaneada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_fechainicioPlaneada");
        builder.Property(e => e.ProActividadFechainicioProyectada)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_actividad_fechainicioProyectada");
        builder.Property(e => e.ProEjecutoresCosto).HasColumnName("pro_ejecutores_costo");
        builder.Property(e => e.ProEjecutoresEjecutores)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pro_ejecutores_ejecutores");
        builder.Property(e => e.ProEjecutoresEjecutoresCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_ejecutores_ejecutores_codigo");
        builder.Property(e => e.ProEjecutoresIdHorarioEjecutores).HasColumnName("pro_ejecutores_id_horarioEjecutores");
        builder.Property(e => e.ProEjecutoresIdUsuario).HasColumnName("pro_ejecutores_id_usuario");
        builder.Property(e => e.ProEjecutoresUnidadTiempo)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasColumnName("pro_ejecutores_unidadTiempo");
        builder.Property(e => e.ProGrupoSesionGrupoSesion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pro_GrupoSesion_GrupoSesion");
        builder.Property(e => e.ProGrupoSesionGrupoSesionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_GrupoSesion_GrupoSesion_codigo");
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
    }
}
