using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntVisitaFijaConfiguration : IEntityTypeConfiguration<CntVisitaFija>
{
    public void Configure(EntityTypeBuilder<CntVisitaFija> builder)
    {
        builder.ToTable("cnt_visitaFija");

        builder.HasIndex(e => e.Eid, "IX_cnt_visitaFija");

        builder.HasIndex(e => e.IdContratoEquipo, "IX_id_contratoEquipo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CorreoRecordatorio)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("correoRecordatorio");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsPorTrabajo)
            .HasDefaultValue(false)
            .HasColumnName("esPorTrabajo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaCreadaFf)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreada_ff");
        builder.Property(e => e.FechaFf)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Horometro).HasColumnName("horometro");
        builder.Property(e => e.IdCatalogoTempario).HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdConfigContrato)
            .HasDefaultValue(0)
            .HasColumnName("id_configContrato");
        builder.Property(e => e.IdContratoDetalleVisita).HasColumnName("id_contratoDetalleVisita");
        builder.Property(e => e.IdContratoEquipo).HasColumnName("id_contratoEquipo");
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Presupuesto)
            .HasDefaultValue(0.0)
            .HasColumnName("presupuesto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.VisitaFija)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("visitaFija");
        builder.Property(e => e.VisitaFijaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("visitaFija_codigo");

        builder.HasOne(d => d.IdCatalogoTemparioNavigation).WithMany(p => p.CntVisitaFijas)
            .HasForeignKey(d => d.IdCatalogoTempario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_visitaFija_id_catalogo_tempario");

        builder.HasOne(d => d.IdConfigContratoNavigation).WithMany(p => p.CntVisitaFijas)
            .HasForeignKey(d => d.IdConfigContrato)
            .HasConstraintName("FK__cnt_visit__id_co__69BFBDB0");

        builder.HasOne(d => d.IdContratoDetalleVisitaNavigation).WithMany(p => p.CntVisitaFijas)
            .HasForeignKey(d => d.IdContratoDetalleVisita)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_visitaFija_id_contratoDetalleVisita");

        builder.HasOne(d => d.IdContratoEquipoNavigation).WithMany(p => p.CntVisitaFijas)
            .HasForeignKey(d => d.IdContratoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_visitaFija_id_contratoEquipo");

        builder.HasOne(d => d.IdDocumentoOtNavigation).WithMany(p => p.CntVisitaFijas)
            .HasForeignKey(d => d.IdDocumentoOt)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_visitaFija_id_documento_ot");
    }
}
