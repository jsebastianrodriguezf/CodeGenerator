using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDisEventoEstadoEventoConfiguration : IEntityTypeConfiguration<ViewDisEventoEstadoEvento>
{
    public void Configure(EntityTypeBuilder<ViewDisEventoEstadoEvento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_dis_evento_estadoEvento");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AfectaCliente).HasColumnName("afectaCliente");
        builder.Property(e => e.CatSistemaIdSistema).HasColumnName("cat_sistema_id_sistema");
        builder.Property(e => e.CatSistemaSistema)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_sistema");
        builder.Property(e => e.CatSistemaSistemaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_sistema_codigo");
        builder.Property(e => e.DisEstadoEventoEstadoEvento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("dis_estadoEvento_estadoEvento");
        builder.Property(e => e.DisEstadoEventoEstadoEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_estadoEvento_estadoEvento_codigo");
        builder.Property(e => e.DisEventoAfectaCliente).HasColumnName("dis_evento_afectaCliente");
        builder.Property(e => e.DisEventoAfectaProduccion).HasColumnName("dis_evento_afectaProduccion");
        builder.Property(e => e.DisEventoDuracionHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_duracion_hh");
        builder.Property(e => e.DisEventoEvento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("dis_evento_evento");
        builder.Property(e => e.DisEventoEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_evento_evento_codigo");
        builder.Property(e => e.DisEventoEventoTipo).HasColumnName("dis_evento_eventoTipo");
        builder.Property(e => e.DisEventoFechaHoraEstimadaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_fechaHoraEstimada_fh");
        builder.Property(e => e.DisEventoFechaHoraInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_fechaHoraInicio_ff");
        builder.Property(e => e.DisEventoIdEquipo).HasColumnName("dis_evento_id_equipo");
        builder.Property(e => e.DisEventoIdEstadoEquipo).HasColumnName("dis_evento_id_estadoEquipo");
        builder.Property(e => e.DisEventoIdEstadoEvento).HasColumnName("dis_evento_id_estadoEvento");
        builder.Property(e => e.DisEventoIdFalla).HasColumnName("dis_evento_id_falla");
        builder.Property(e => e.DisEventoIdFallaCausa).HasColumnName("dis_evento_id_falla_causa");
        builder.Property(e => e.DisEventoIdMetodoDeteccion).HasColumnName("dis_evento_id_metodoDeteccion");
        builder.Property(e => e.DisEventoIdMotivoEvento).HasColumnName("dis_evento_id_motivoEvento");
        builder.Property(e => e.DisEventoIdUsuario).HasColumnName("dis_evento_id_usuario");
        builder.Property(e => e.DisEventoNotas)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("dis_evento_notas");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EventoEstadoEvento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("evento_estadoEvento");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaHoraRegistroFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaHoraRegistro_fh");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEstadoEvento).HasColumnName("id_estadoEvento");
        builder.Property(e => e.IdEvento).HasColumnName("id_evento");
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
