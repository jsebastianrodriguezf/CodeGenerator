using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewProActividadHitoConfiguration : IEntityTypeConfiguration<ViewProActividadHito>
{
    public void Configure(EntityTypeBuilder<ViewProActividadHito> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_pro_actividad_hito");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.ActividadHito)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("actividad_hito");
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
        builder.Property(e => e.IdHito).HasColumnName("id_hito");
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
        builder.Property(e => e.ProHitoHito)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pro_hito_hito");
        builder.Property(e => e.ProHitoHitoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_hito_hito_codigo");
        builder.Property(e => e.ProHitoIdDocumentoProyecto).HasColumnName("pro_hito_id_documento.proyecto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
