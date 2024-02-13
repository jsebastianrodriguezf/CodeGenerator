using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCntCorrimientoVisitaFijaConfiguration : IEntityTypeConfiguration<ViewCntCorrimientoVisitaFija>
{
    public void Configure(EntityTypeBuilder<ViewCntCorrimientoVisitaFija> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cnt_corrimientoVisitaFija");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CntVisitaFijaEsPorTrabajo).HasColumnName("cnt_visitaFija_esPorTrabajo");
        builder.Property(e => e.CntVisitaFijaFechaCreadaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_visitaFija_fechaCreada_ff");
        builder.Property(e => e.CntVisitaFijaFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_visitaFija_fecha_ff");
        builder.Property(e => e.CntVisitaFijaHorometro).HasColumnName("cnt_visitaFija_horometro");
        builder.Property(e => e.CntVisitaFijaIdCatalogoTempario).HasColumnName("cnt_visitaFija_id_catalogo.tempario");
        builder.Property(e => e.CntVisitaFijaIdContratoDetalleVisita).HasColumnName("cnt_visitaFija_id_contratoDetalleVisita");
        builder.Property(e => e.CntVisitaFijaIdContratoEquipo).HasColumnName("cnt_visitaFija_id_contratoEquipo");
        builder.Property(e => e.CntVisitaFijaIdDocumentoOt).HasColumnName("cnt_visitaFija_id_documento.ot");
        builder.Property(e => e.CntVisitaFijaVisitaFija)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_visitaFija_visitaFija");
        builder.Property(e => e.CntVisitaFijaVisitaFijaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cnt_visitaFija_visitaFija_codigo");
        builder.Property(e => e.CorrimientoVisitaFija)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("corrimientoVisitaFija");
        builder.Property(e => e.CorrimientoVisitaFijaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("corrimientoVisitaFija_codigo");
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
        builder.Property(e => e.FechaOriginalFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaOriginal_ff");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdVisitaFija).HasColumnName("id_visitaFija");
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
