using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class OrtReporteTecnicoConfiguration : IEntityTypeConfiguration<OrtReporteTecnico>
{
    public void Configure(EntityTypeBuilder<OrtReporteTecnico> builder)
    {
        builder.ToTable("ort_reporteTecnico");

        builder.HasIndex(e => e.Eid, "IX_ort_reporteTecnico");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Compromisos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("compromisos");
        builder.Property(e => e.Diagnostico)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("diagnostico");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdCanalAtencion)
            .HasDefaultValue(0)
            .HasColumnName("id_canalAtencion");
        builder.Property(e => e.IdDocumentoGasto).HasColumnName("id_documento.gasto");
        builder.Property(e => e.IdGasto).HasColumnName("id_gasto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Numero)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("numero");
        builder.Property(e => e.Recomendaciones)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("recomendaciones");
        builder.Property(e => e.ReporteTecnico)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("reporteTecnico");
        builder.Property(e => e.ReporteTecnicoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("reporteTecnico_codigo");
        builder.Property(e => e.Trabajos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("trabajos");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCanalAtencionNavigation).WithMany(p => p.OrtReporteTecnicos)
            .HasForeignKey(d => d.IdCanalAtencion)
            .HasConstraintName("FK__ort_repor__id_ca__5C10BCD7");

        builder.HasOne(d => d.IdDocumentoGastoNavigation).WithMany(p => p.OrtReporteTecnicos)
            .HasForeignKey(d => d.IdDocumentoGasto)
            .HasConstraintName("FK_ort_reporteTecnico_doc_documento_gasto");

        builder.HasOne(d => d.IdGastoNavigation).WithMany(p => p.OrtReporteTecnicos)
            .HasForeignKey(d => d.IdGasto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_reporteTecnico_id_gasto");
    }
}
