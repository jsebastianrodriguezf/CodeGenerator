using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class RepOpcionReporteConfiguration : IEntityTypeConfiguration<RepOpcionReporte>
{
    public void Configure(EntityTypeBuilder<RepOpcionReporte> builder)
    {
        builder.ToTable("rep_opcionReporte");

        builder.HasIndex(e => e.Eid, "IX_rep_opcionReporte");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Defecto).HasColumnName("defecto");
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
        builder.Property(e => e.IdReporte).HasColumnName("id_reporte");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.OpcionReporte)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("opcionReporte");
        builder.Property(e => e.OpcionReporteCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("opcionReporte_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdReporteNavigation).WithMany(p => p.RepOpcionReportes)
            .HasForeignKey(d => d.IdReporte)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_rep_opcionReporte_id_reporte");
    }
}
