using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquDetallePagoAlquilerConfiguration : IEntityTypeConfiguration<EquDetallePagoAlquiler>
{
    public void Configure(EntityTypeBuilder<EquDetallePagoAlquiler> builder)
    {
        builder.ToTable("equ_detallePagoAlquiler");

        builder.HasIndex(e => e.Eid, "IX_equ_detallePagoAlquiler");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DetallePagoAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detallePagoAlquiler");
        builder.Property(e => e.DetallePagoAlquilerCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detallePagoAlquiler_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Facturado).HasColumnName("facturado");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFin_ff");
        builder.Property(e => e.FechaInicialFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicial_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Horometro)
            .HasDefaultValue(0.0)
            .HasColumnName("horometro");
        builder.Property(e => e.IdDocumento)
            .HasDefaultValue(0)
            .HasColumnName("id_documento");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
        builder.Property(e => e.IdPagoAlquiler).HasColumnName("id_pagoAlquiler");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor)
            .HasColumnType("money")
            .HasColumnName("valor");
        builder.Property(e => e.ValorMulta)
            .HasDefaultValue(0.0)
            .HasColumnName("valorMulta");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.EquDetallePagoAlquilers)
            .HasForeignKey(d => d.IdDocumento)
            .HasConstraintName("FK_equ_detallePagoAlquiler_id_documento");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.EquDetallePagoAlquilers)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_detallePagoAlquiler_id_equipo");

        builder.HasOne(d => d.IdItemDocumentoNavigation).WithMany(p => p.EquDetallePagoAlquilers)
            .HasForeignKey(d => d.IdItemDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_detallePagoAlquiler_id_itemDocumento");

        builder.HasOne(d => d.IdPagoAlquilerNavigation).WithMany(p => p.EquDetallePagoAlquilers)
            .HasForeignKey(d => d.IdPagoAlquiler)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_detallePagoAlquiler_id_pagoAlquiler");
    }
}
