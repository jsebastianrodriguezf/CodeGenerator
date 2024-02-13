using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewRepCampoReporteConfiguration : IEntityTypeConfiguration<ViewRepCampoReporte>
{
    public void Configure(EntityTypeBuilder<ViewRepCampoReporte> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_rep_campoReporte");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CampoReporte)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("campoReporte");
        builder.Property(e => e.CampoReporteCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("campoReporte_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsParametro).HasColumnName("esParametro");
        builder.Property(e => e.EsSerie).HasColumnName("esSerie");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdReporte).HasColumnName("id_reporte");
        builder.Property(e => e.IdTipoCampoReporte).HasColumnName("id_tipoCampoReporte");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ParametroTotal).HasColumnName("parametroTotal");
        builder.Property(e => e.RepReporteCabecera)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("rep_reporte_cabecera");
        builder.Property(e => e.RepReporteEsFormato).HasColumnName("rep_reporte_esFormato");
        builder.Property(e => e.RepReporteIdFuncionalidad).HasColumnName("rep_reporte_id_funcionalidad");
        builder.Property(e => e.RepReporteReporte)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("rep_reporte_reporte");
        builder.Property(e => e.RepReporteReporteCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("rep_reporte_reporte_codigo");
        builder.Property(e => e.RepReporteTieneGraficos).HasColumnName("rep_reporte_tieneGraficos");
        builder.Property(e => e.RepTipoCampoReporteTipoCampoReporte)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("rep_tipoCampoReporte_tipoCampoReporte");
        builder.Property(e => e.RepTipoCampoReporteTipoCampoReporteCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("rep_tipoCampoReporte_tipoCampoReporte_codigo");
        builder.Property(e => e.Tabla)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorDefecto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("valorDefecto");
    }
}
