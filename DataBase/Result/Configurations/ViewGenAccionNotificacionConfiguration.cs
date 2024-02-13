using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenAccionNotificacionConfiguration : IEntityTypeConfiguration<ViewGenAccionNotificacion>
{
    public void Configure(EntityTypeBuilder<ViewGenAccionNotificacion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_accionNotificacion");

        builder.Property(e => e.AccionNotificacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("accionNotificacion");
        builder.Property(e => e.AccionNotificacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("accionNotificacion_codigo");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenTipoNotificacionTipoNotificacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_tipoNotificacion_tipoNotificacion");
        builder.Property(e => e.GenTipoNotificacionTipoNotificacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_tipoNotificacion_tipoNotificacion_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdPuntoIntegracion).HasColumnName("id_puntoIntegracion");
        builder.Property(e => e.IdTipoNotificacion).HasColumnName("id_tipoNotificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.SynPuntoIntegracionCantidadReintentos).HasColumnName("syn_puntoIntegracion_cantidadReintentos");
        builder.Property(e => e.SynPuntoIntegracionCodigosReintentos)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_codigosReintentos");
        builder.Property(e => e.SynPuntoIntegracionCondicion)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_condicion");
        builder.Property(e => e.SynPuntoIntegracionIdPuntoIntegracion).HasColumnName("syn_puntoIntegracion_id_puntoIntegracion");
        builder.Property(e => e.SynPuntoIntegracionIdSistemaIntegrar).HasColumnName("syn_puntoIntegracion_id_sistemaIntegrar");
        builder.Property(e => e.SynPuntoIntegracionIntervaloReintentos).HasColumnName("syn_puntoIntegracion_intervaloReintentos");
        builder.Property(e => e.SynPuntoIntegracionMetodo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_metodo");
        builder.Property(e => e.SynPuntoIntegracionPuntoIntegracion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_puntoIntegracion");
        builder.Property(e => e.SynPuntoIntegracionPuntoIntegracionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_puntoIntegracion_codigo");
        builder.Property(e => e.SynPuntoIntegracionTablaLocal)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_tablaLocal");
        builder.Property(e => e.SynPuntoIntegracionUrlConsumir)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_urlConsumir");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
