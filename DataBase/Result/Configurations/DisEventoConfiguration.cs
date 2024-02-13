using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DisEventoConfiguration : IEntityTypeConfiguration<DisEvento>
{
    public void Configure(EntityTypeBuilder<DisEvento> builder)
    {
        builder.ToTable("dis_evento");

        builder.HasIndex(e => e.Eid, "IX_dis_evento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AfectaCliente)
            .HasDefaultValue(true)
            .HasColumnName("afectaCliente");
        builder.Property(e => e.AfectaProduccion)
            .HasDefaultValue(true)
            .HasColumnName("afectaProduccion");
        builder.Property(e => e.Codigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("codigo");
        builder.Property(e => e.DuracionHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("duracion_hh");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Evento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("evento");
        builder.Property(e => e.EventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("evento_codigo");
        builder.Property(e => e.EventoTipo).HasColumnName("eventoTipo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaHoraEstimadaFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaHoraEstimada_fh");
        builder.Property(e => e.FechaHoraInicioFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaHoraInicio_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdEstadoEquipo).HasColumnName("id_estadoEquipo");
        builder.Property(e => e.IdEstadoEvento).HasColumnName("id_estadoEvento");
        builder.Property(e => e.IdFalla).HasColumnName("id_falla");
        builder.Property(e => e.IdFallaCausa).HasColumnName("id_falla_causa");
        builder.Property(e => e.IdMetodoDeteccion).HasColumnName("id_metodoDeteccion");
        builder.Property(e => e.IdMotivoEvento).HasColumnName("id_motivoEvento");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Notas)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("notas");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.DisEventos)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_id_equipo");

        builder.HasOne(d => d.IdEstadoEquipoNavigation).WithMany(p => p.DisEventos)
            .HasForeignKey(d => d.IdEstadoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_id_estadoEquipo");

        builder.HasOne(d => d.IdEstadoEventoNavigation).WithMany(p => p.DisEventos)
            .HasForeignKey(d => d.IdEstadoEvento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_id_estadoEvento");

        builder.HasOne(d => d.IdFallaNavigation).WithMany(p => p.DisEventoIdFallaNavigations)
            .HasForeignKey(d => d.IdFalla)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_id_falla");

        builder.HasOne(d => d.IdFallaCausaNavigation).WithMany(p => p.DisEventoIdFallaCausaNavigations)
            .HasForeignKey(d => d.IdFallaCausa)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_id_falla_causa");

        builder.HasOne(d => d.IdMetodoDeteccionNavigation).WithMany(p => p.DisEventos)
            .HasForeignKey(d => d.IdMetodoDeteccion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_id_metodoDeteccion");

        builder.HasOne(d => d.IdMotivoEventoNavigation).WithMany(p => p.DisEventos)
            .HasForeignKey(d => d.IdMotivoEvento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_id_motivoEvento");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.DisEventos)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_id_usuario");
    }
}
