using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewOrtReporteTecnicoFallaConfiguration : IEntityTypeConfiguration<ViewOrtReporteTecnicoFalla>
{
    public void Configure(EntityTypeBuilder<ViewOrtReporteTecnicoFalla> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_ort_reporteTecnico_falla");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquFallaCausaFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_causa_falla");
        builder.Property(e => e.EquFallaCausaFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_causa_falla_codigo");
        builder.Property(e => e.EquFallaCausaIdFalla).HasColumnName("equ_falla_causa_id_falla");
        builder.Property(e => e.EquFallaCausaIdTipoFalla).HasColumnName("equ_falla_causa_id_tipoFalla");
        builder.Property(e => e.EquFallaCausaProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_causa_procedimiento");
        builder.Property(e => e.EquFallaEfectoFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_efecto_falla");
        builder.Property(e => e.EquFallaEfectoFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_efecto_falla_codigo");
        builder.Property(e => e.EquFallaEfectoIdFalla).HasColumnName("equ_falla_efecto_id_falla");
        builder.Property(e => e.EquFallaEfectoIdTipoFalla).HasColumnName("equ_falla_efecto_id_tipoFalla");
        builder.Property(e => e.EquFallaEfectoProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_efecto_procedimiento");
        builder.Property(e => e.EquFallaFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_falla");
        builder.Property(e => e.EquFallaFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_falla_codigo");
        builder.Property(e => e.EquFallaIdFalla).HasColumnName("equ_falla_id_falla");
        builder.Property(e => e.EquFallaIdTipoFalla).HasColumnName("equ_falla_id_tipoFalla");
        builder.Property(e => e.EquFallaProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_procedimiento");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdFalla).HasColumnName("id_falla");
        builder.Property(e => e.IdFallaCausa).HasColumnName("id_falla_causa");
        builder.Property(e => e.IdFallaEfecto).HasColumnName("id_falla_efecto");
        builder.Property(e => e.IdReporteTecnico).HasColumnName("id_reporteTecnico");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.OrtReporteTecnicoCompromisos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_compromisos");
        builder.Property(e => e.OrtReporteTecnicoIdCanalAtencion).HasColumnName("ort_reporteTecnico_id_canalAtencion");
        builder.Property(e => e.OrtReporteTecnicoIdGasto).HasColumnName("ort_reporteTecnico_id_gasto");
        builder.Property(e => e.OrtReporteTecnicoNumero)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_numero");
        builder.Property(e => e.OrtReporteTecnicoRecomendaciones)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_recomendaciones");
        builder.Property(e => e.OrtReporteTecnicoReporteTecnico)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_reporteTecnico");
        builder.Property(e => e.OrtReporteTecnicoReporteTecnicoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_reporteTecnico_codigo");
        builder.Property(e => e.OrtReporteTecnicoTrabajos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_trabajos");
        builder.Property(e => e.ReporteTecnicoFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("reporteTecnico_falla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
