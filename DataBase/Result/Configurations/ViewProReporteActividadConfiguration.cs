using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewProReporteActividadConfiguration : IEntityTypeConfiguration<ViewProReporteActividad>
{
    public void Configure(EntityTypeBuilder<ViewProReporteActividad> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_pro_reporteActividad");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.IdSesionActividad).HasColumnName("id_SesionActividad");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PorcentajeAvance).HasColumnName("porcentaje_avance");
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
        builder.Property(e => e.ProSesionActividadDescripcion)
            .HasMaxLength(3000)
            .IsUnicode(false)
            .HasColumnName("pro_SesionActividad_descripcion");
        builder.Property(e => e.ProSesionActividadDuracion).HasColumnName("pro_SesionActividad_duracion");
        builder.Property(e => e.ProSesionActividadFechaInicio)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_SesionActividad_fecha_inicio");
        builder.Property(e => e.ProSesionActividadIdActividad).HasColumnName("pro_SesionActividad_id_actividad");
        builder.Property(e => e.ProSesionActividadIdEjecutores).HasColumnName("pro_SesionActividad_id_ejecutores");
        builder.Property(e => e.ProSesionActividadIdGrupoSesion).HasColumnName("pro_SesionActividad_id_GrupoSesion");
        builder.Property(e => e.ProSesionActividadSesionActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pro_SesionActividad_SesionActividad");
        builder.Property(e => e.ProSesionActividadSesionActividadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_SesionActividad_SesionActividad_codigo");
        builder.Property(e => e.ReporteActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("reporteActividad");
        builder.Property(e => e.ReporteActividadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("reporteActividad_codigo");
        builder.Property(e => e.TerSucursalCodigorecursiva)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_codigorecursiva");
        builder.Property(e => e.TerSucursalContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_contacto");
        builder.Property(e => e.TerSucursalDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Direccion");
        builder.Property(e => e.TerSucursalEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Email");
        builder.Property(e => e.TerSucursalFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Fax");
        builder.Property(e => e.TerSucursalIdEstadoTercero).HasColumnName("ter_sucursal_id_estadoTercero");
        builder.Property(e => e.TerSucursalIdSucursal).HasColumnName("ter_sucursal_id_sucursal");
        builder.Property(e => e.TerSucursalIdTercero).HasColumnName("ter_sucursal_id_tercero");
        builder.Property(e => e.TerSucursalIdUsuarioAsesor).HasColumnName("ter_sucursal_id_usuario_asesor");
        builder.Property(e => e.TerSucursalIdUsuarioTecnico).HasColumnName("ter_sucursal_id_usuario_tecnico");
        builder.Property(e => e.TerSucursalIdZona).HasColumnName("ter_sucursal_id_zona");
        builder.Property(e => e.TerSucursalParaAlquiler).HasColumnName("ter_sucursal_paraAlquiler");
        builder.Property(e => e.TerSucursalParaSoporte).HasColumnName("ter_sucursal_paraSoporte");
        builder.Property(e => e.TerSucursalParaVenta).HasColumnName("ter_sucursal_paraVenta");
        builder.Property(e => e.TerSucursalSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal");
        builder.Property(e => e.TerSucursalSucursalCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal_codigo");
        builder.Property(e => e.TerSucursalTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_telefono");
        builder.Property(e => e.Texto)
            .HasMaxLength(3000)
            .IsUnicode(false)
            .HasColumnName("texto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
