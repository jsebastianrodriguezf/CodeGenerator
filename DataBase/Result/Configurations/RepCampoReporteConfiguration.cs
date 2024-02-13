using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class RepCampoReporteConfiguration : IEntityTypeConfiguration<RepCampoReporte>
{
    public void Configure(EntityTypeBuilder<RepCampoReporte> builder)
    {
        builder.ToTable("rep_campoReporte");

        builder.HasIndex(e => e.Eid, "IX_rep_campoReporte");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
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
        builder.Property(e => e.EsParametro)
            .HasDefaultValue(true)
            .HasColumnName("esParametro");
        builder.Property(e => e.EsSerie).HasColumnName("esSerie");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdReporte).HasColumnName("id_reporte");
        builder.Property(e => e.IdTipoCampoReporte).HasColumnName("id_tipoCampoReporte");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ParametroTotal)
            .HasDefaultValue(true)
            .HasColumnName("parametroTotal");
        builder.Property(e => e.Tabla)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorDefecto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("valorDefecto");

        builder.HasOne(d => d.IdReporteNavigation).WithMany(p => p.RepCampoReportes)
            .HasForeignKey(d => d.IdReporte)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_rep_campoReporte_id_reporte");

        builder.HasOne(d => d.IdTipoCampoReporteNavigation).WithMany(p => p.RepCampoReportes)
            .HasForeignKey(d => d.IdTipoCampoReporte)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_rep_campoReporte_id_tipoCampoReporte");
    }
}
