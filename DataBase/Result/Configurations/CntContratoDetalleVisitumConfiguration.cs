using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntContratoDetalleVisitumConfiguration : IEntityTypeConfiguration<CntContratoDetalleVisitum>
{
    public void Configure(EntityTypeBuilder<CntContratoDetalleVisitum> builder)
    {
        builder.ToTable("cnt_contratoDetalleVisita");

        builder.HasIndex(e => e.Eid, "IX_cnt_contratoDetalleVisita");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AproximarA).HasColumnName("aproximarA");
        builder.Property(e => e.CadaN).HasColumnName("cadaN");
        builder.Property(e => e.ContratoDetalleVisita)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contratoDetalleVisita");
        builder.Property(e => e.ContratoDetalleVisitaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contratoDetalleVisita_codigo");
        builder.Property(e => e.Dia).HasColumnName("dia");
        builder.Property(e => e.DiaHabil).HasColumnName("diaHabil");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Estrategia).HasColumnName("estrategia");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaInactivaFinalFf)
            .HasDefaultValueSql("(NULL)")
            .HasColumnType("datetime")
            .HasColumnName("fechaInactivaFinal_ff");
        builder.Property(e => e.FechaInactivaInicialFf)
            .HasDefaultValueSql("(NULL)")
            .HasColumnType("datetime")
            .HasColumnName("fechaInactivaInicial_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Frecuencia).HasColumnName("frecuencia");
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IncluirMenores).HasColumnName("incluirMenores");
        builder.Property(e => e.PorTrabajo).HasColumnName("porTrabajo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdContratoNavigation).WithMany(p => p.CntContratoDetalleVisita)
            .HasForeignKey(d => d.IdContrato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contratoDetalleVisita_id_contrato");
    }
}
