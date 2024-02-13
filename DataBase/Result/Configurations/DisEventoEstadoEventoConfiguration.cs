using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DisEventoEstadoEventoConfiguration : IEntityTypeConfiguration<DisEventoEstadoEvento>
{
    public void Configure(EntityTypeBuilder<DisEventoEstadoEvento> builder)
    {
        builder.ToTable("dis_evento_estadoEvento");

        builder.HasIndex(e => e.Eid, "IX_dis_evento_estadoEvento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AfectaCliente).HasColumnName("afectaCliente");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EventoEstadoEvento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("evento_estadoEvento");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaHoraRegistroFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaHoraRegistro_fh");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEstadoEvento).HasColumnName("id_estadoEvento");
        builder.Property(e => e.IdEvento).HasColumnName("id_evento");
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEstadoEventoNavigation).WithMany(p => p.DisEventoEstadoEventos)
            .HasForeignKey(d => d.IdEstadoEvento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_estadoEvento_id_estadoEvento");

        builder.HasOne(d => d.IdEventoNavigation).WithMany(p => p.DisEventoEstadoEventos)
            .HasForeignKey(d => d.IdEvento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_estadoEvento_id_evento");

        builder.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.DisEventoEstadoEventos)
            .HasForeignKey(d => d.IdSistema)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_estadoEvento_id_sistema");
    }
}
