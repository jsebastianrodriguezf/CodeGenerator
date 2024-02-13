using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntContratoEquipoConfiguration : IEntityTypeConfiguration<CntContratoEquipo>
{
    public void Configure(EntityTypeBuilder<CntContratoEquipo> builder)
    {
        builder.ToTable("cnt_contratoEquipo");

        builder.HasIndex(e => e.Eid, "IX_cnt_contratoEquipo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ContratoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contratoEquipo");
        builder.Property(e => e.ContratoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contratoEquipo_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdContratoDetalleVisita).HasColumnName("id_contratoDetalleVisita");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PrecioServicio)
            .HasDefaultValue(0m)
            .HasColumnType("money")
            .HasColumnName("precioServicio");
        builder.Property(e => e.PrecioVisita)
            .HasDefaultValue(0m)
            .HasColumnType("money")
            .HasColumnName("precioVisita");
        builder.Property(e => e.Promedio)
            .HasDefaultValue(0.0)
            .HasColumnName("promedio");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdContratoNavigation).WithMany(p => p.CntContratoEquipos)
            .HasForeignKey(d => d.IdContrato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contratoEquipo_id_contrato");

        builder.HasOne(d => d.IdContratoDetalleVisitaNavigation).WithMany(p => p.CntContratoEquipos)
            .HasForeignKey(d => d.IdContratoDetalleVisita)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contratoEquipo_id_contratoDetalleVisita");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.CntContratoEquipos)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contratoEquipo_id_equipo");
    }
}
