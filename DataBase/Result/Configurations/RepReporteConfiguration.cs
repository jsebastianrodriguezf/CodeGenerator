using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class RepReporteConfiguration : IEntityTypeConfiguration<RepReporte>
{
    public void Configure(EntityTypeBuilder<RepReporte> builder)
    {
        builder.ToTable("rep_reporte");

        builder.HasIndex(e => e.Eid, "IX_rep_reporte");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Basica).HasColumnName("basica");
        builder.Property(e => e.Cabecera)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("cabecera");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsFormato).HasColumnName("esFormato");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdFuncionalidad).HasColumnName("id_funcionalidad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Reporte)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("reporte");
        builder.Property(e => e.ReporteCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("reporte_codigo");
        builder.Property(e => e.TieneGraficos).HasColumnName("tieneGraficos");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdFuncionalidadNavigation).WithMany(p => p.RepReportes)
            .HasForeignKey(d => d.IdFuncionalidad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_rep_reporte_id_funcionalidad");
    }
}
