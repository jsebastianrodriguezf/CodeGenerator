using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class RepIndicadorConfiguration : IEntityTypeConfiguration<RepIndicador>
{
    public void Configure(EntityTypeBuilder<RepIndicador> builder)
    {
        builder.ToTable("rep_indicador");

        builder.HasIndex(e => e.Eid, "IX_rep_indicador");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cabecera)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cabecera");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("descripcion");
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
        builder.Property(e => e.Indicador)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("indicador");
        builder.Property(e => e.IndicadorCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("indicador_codigo");
        builder.Property(e => e.Seccion1)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seccion1");
        builder.Property(e => e.Seccion2)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seccion2");
        builder.Property(e => e.Seccion3)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seccion3");
        builder.Property(e => e.Seccion4)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seccion4");
        builder.Property(e => e.Seccion5)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seccion5");
        builder.Property(e => e.Seccion6)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seccion6");
        builder.Property(e => e.Seccion7)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seccion7");
        builder.Property(e => e.Seccion8)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seccion8");
        builder.Property(e => e.Titulo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("titulo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdReporteNavigation).WithMany(p => p.RepIndicadors)
            .HasForeignKey(d => d.IdReporte)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_rep_indicador_id_reporte");
    }
}
