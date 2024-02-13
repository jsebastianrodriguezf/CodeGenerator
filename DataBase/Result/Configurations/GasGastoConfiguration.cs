using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GasGastoConfiguration : IEntityTypeConfiguration<GasGasto>
{
    public void Configure(EntityTypeBuilder<GasGasto> builder)
    {
        builder.ToTable("gas_gasto");

        builder.HasIndex(e => e.Eid, "IX_gas_gasto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Concepto)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("concepto");
        builder.Property(e => e.Consignado)
            .HasDefaultValue(true)
            .HasColumnName("consignado");
        builder.Property(e => e.Dias)
            .HasDefaultValue(1)
            .HasColumnName("dias");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Gasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gasto");
        builder.Property(e => e.GastoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gasto_codigo");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdTipoGasto).HasColumnName("id_tipoGasto");
        builder.Property(e => e.IdUsuarioAprobo).HasColumnName("id_usuario_aprobo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioSolicitante).HasColumnName("id_usuario_solicitante");
        builder.Property(e => e.Numero).HasColumnName("numero");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor).HasColumnName("valor");

        builder.HasOne(d => d.IdEstadoTipoDocumentoNavigation).WithMany(p => p.GasGastos)
            .HasForeignKey(d => d.IdEstadoTipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gas_gasto_id_estadoTipoDocumento");

        builder.HasOne(d => d.IdTipoGastoNavigation).WithMany(p => p.GasGastos)
            .HasForeignKey(d => d.IdTipoGasto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gas_gasto_id_tipoGasto");

        builder.HasOne(d => d.IdUsuarioAproboNavigation).WithMany(p => p.GasGastoIdUsuarioAproboNavigations)
            .HasForeignKey(d => d.IdUsuarioAprobo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gas_gasto_id_usuario_aprobo");

        builder.HasOne(d => d.IdUsuarioSolicitanteNavigation).WithMany(p => p.GasGastoIdUsuarioSolicitanteNavigations)
            .HasForeignKey(d => d.IdUsuarioSolicitante)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gas_gasto_id_usuario_solicitante");
    }
}
