using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class OrtReporteTecnicoFallaConfiguration : IEntityTypeConfiguration<OrtReporteTecnicoFalla>
{
    public void Configure(EntityTypeBuilder<OrtReporteTecnicoFalla> builder)
    {
        builder.ToTable("ort_reporteTecnico_falla");

        builder.HasIndex(e => e.Eid, "IX_ort_reporteTecnico_falla");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
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
        builder.Property(e => e.IdFalla).HasColumnName("id_falla");
        builder.Property(e => e.IdFallaCausa).HasColumnName("id_falla_causa");
        builder.Property(e => e.IdFallaEfecto).HasColumnName("id_falla_efecto");
        builder.Property(e => e.IdReporteTecnico).HasColumnName("id_reporteTecnico");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ReporteTecnicoFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("reporteTecnico_falla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdFallaNavigation).WithMany(p => p.OrtReporteTecnicoFallaIdFallaNavigations)
            .HasForeignKey(d => d.IdFalla)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_reporteTecnico_falla_id_falla");

        builder.HasOne(d => d.IdFallaCausaNavigation).WithMany(p => p.OrtReporteTecnicoFallaIdFallaCausaNavigations)
            .HasForeignKey(d => d.IdFallaCausa)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__ort_repor__id_fa__75274EBB");

        builder.HasOne(d => d.IdFallaEfectoNavigation).WithMany(p => p.OrtReporteTecnicoFallaIdFallaEfectoNavigations)
            .HasForeignKey(d => d.IdFallaEfecto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__ort_repor__id_fa__770F972D");

        builder.HasOne(d => d.IdReporteTecnicoNavigation).WithMany(p => p.OrtReporteTecnicoFallas)
            .HasForeignKey(d => d.IdReporteTecnico)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_reporteTecnico_falla_id_reporteTecnico");
    }
}
