using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewProActividadEtapaConfiguration : IEntityTypeConfiguration<ViewProActividadEtapa>
{
    public void Configure(EntityTypeBuilder<ViewProActividadEtapa> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_pro_actividad_etapa");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.ActividadEtapa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("actividad_etapa");
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
        builder.Property(e => e.IdActividad).HasColumnName("id_actividad");
        builder.Property(e => e.IdEtapa).HasColumnName("id_etapa");
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
        builder.Property(e => e.ProEtapaCompletado).HasColumnName("pro_etapa_completado");
        builder.Property(e => e.ProEtapaDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("pro_etapa_descripcion");
        builder.Property(e => e.ProEtapaEtapa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pro_etapa_etapa");
        builder.Property(e => e.ProEtapaEtapaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_etapa_etapa_codigo");
        builder.Property(e => e.ProEtapaFechaFinPlaneada)
            .HasColumnType("datetime")
            .HasColumnName("pro_etapa_fechaFinPlaneada");
        builder.Property(e => e.ProEtapaFechaFinPlaneadaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_etapa_fechaFinPlaneada_ff");
        builder.Property(e => e.ProEtapaFechaFinProyectada)
            .HasColumnType("datetime")
            .HasColumnName("pro_etapa_fechaFinProyectada");
        builder.Property(e => e.ProEtapaFechaFinProyectadaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_etapa_fechaFinProyectada_ff");
        builder.Property(e => e.ProEtapaFechaFinReal)
            .HasColumnType("datetime")
            .HasColumnName("pro_etapa_fechaFinReal");
        builder.Property(e => e.ProEtapaFechaFinRealFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_etapa_fechaFinReal_ff");
        builder.Property(e => e.ProEtapaFechaInicioPlaneada)
            .HasColumnType("datetime")
            .HasColumnName("pro_etapa_fechaInicioPlaneada");
        builder.Property(e => e.ProEtapaFechaInicioPlaneadaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_etapa_fechaInicioPlaneada_ff");
        builder.Property(e => e.ProEtapaFechaInicioProyectada)
            .HasColumnType("datetime")
            .HasColumnName("pro_etapa_fechaInicioProyectada");
        builder.Property(e => e.ProEtapaFechaInicioProyectadaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_etapa_fechaInicioProyectada_ff");
        builder.Property(e => e.ProEtapaFechaInicioReal)
            .HasColumnType("datetime")
            .HasColumnName("pro_etapa_fechaInicioReal");
        builder.Property(e => e.ProEtapaFechaInicioRealFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("pro_etapa_fechaInicioReal_ff");
        builder.Property(e => e.ProEtapaOrden).HasColumnName("pro_etapa_orden");
        builder.Property(e => e.ProEtapaPorcentajePresupuesto).HasColumnName("pro_etapa_porcentajePresupuesto");
        builder.Property(e => e.ProEtapaValorPresupuesto)
            .HasColumnType("money")
            .HasColumnName("pro_etapa_valorPresupuesto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
