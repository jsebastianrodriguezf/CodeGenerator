using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class AlqHistoricoAlquilerConfiguration : IEntityTypeConfiguration<AlqHistoricoAlquiler>
{
    public void Configure(EntityTypeBuilder<AlqHistoricoAlquiler> builder)
    {
        builder.ToTable("alq_historicoAlquiler");

        builder.HasIndex(e => e.Eid, "IX_alq_historicoAlquiler");

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
        builder.Property(e => e.FechaEstado)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaEstado");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.HistoricoAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("historicoAlquiler");
        builder.Property(e => e.HistoricoAlquilerCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("historicoAlquiler_codigo");
        builder.Property(e => e.IdDocumento)
            .HasDefaultValue(0)
            .HasColumnName("id_documento");
        builder.Property(e => e.IdEquipo)
            .HasDefaultValue(0)
            .HasColumnName("id_equipo");
        builder.Property(e => e.IdEstadoEquipo)
            .HasDefaultValue(0)
            .HasColumnName("id_estadoEquipo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.AlqHistoricoAlquilers)
            .HasForeignKey(d => d.IdDocumento)
            .HasConstraintName("FK__alq_histo__id_do__78E205AF");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.AlqHistoricoAlquilers)
            .HasForeignKey(d => d.IdEquipo)
            .HasConstraintName("FK__alq_histo__id_eq__751174CB");

        builder.HasOne(d => d.IdEstadoEquipoNavigation).WithMany(p => p.AlqHistoricoAlquilers)
            .HasForeignKey(d => d.IdEstadoEquipo)
            .HasConstraintName("FK__alq_histo__id_es__76F9BD3D");
    }
}
