using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSynPuntoIntegracionConfiguration : IEntityTypeConfiguration<ViewSynPuntoIntegracion>
{
    public void Configure(EntityTypeBuilder<ViewSynPuntoIntegracion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_syn_puntoIntegracion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CantidadReintentos).HasColumnName("cantidadReintentos");
        builder.Property(e => e.CodigosReintentos)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("codigosReintentos");
        builder.Property(e => e.Condicion)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("condicion");
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
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdPuntoIntegracion).HasColumnName("id_puntoIntegracion");
        builder.Property(e => e.IdSistemaIntegrar).HasColumnName("id_sistemaIntegrar");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IntervaloReintentos).HasColumnName("intervaloReintentos");
        builder.Property(e => e.Metodo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("metodo");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PuntoIntegracion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("puntoIntegracion");
        builder.Property(e => e.PuntoIntegracionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("puntoIntegracion_codigo");
        builder.Property(e => e.SynPuntoIntegracionPadreCantidadReintentos).HasColumnName("syn_puntoIntegracion_padre_cantidadReintentos");
        builder.Property(e => e.SynPuntoIntegracionPadreCodigosReintentos)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_padre_codigosReintentos");
        builder.Property(e => e.SynPuntoIntegracionPadreCondicion)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_padre_condicion");
        builder.Property(e => e.SynPuntoIntegracionPadreIdPuntoIntegracion).HasColumnName("syn_puntoIntegracion_padre_id_puntoIntegracion");
        builder.Property(e => e.SynPuntoIntegracionPadreIdSistemaIntegrar).HasColumnName("syn_puntoIntegracion_padre_id_sistemaIntegrar");
        builder.Property(e => e.SynPuntoIntegracionPadreIntervaloReintentos).HasColumnName("syn_puntoIntegracion_padre_intervaloReintentos");
        builder.Property(e => e.SynPuntoIntegracionPadreMetodo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_padre_metodo");
        builder.Property(e => e.SynPuntoIntegracionPadrePuntoIntegracion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_padre_puntoIntegracion");
        builder.Property(e => e.SynPuntoIntegracionPadrePuntoIntegracionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_padre_puntoIntegracion_codigo");
        builder.Property(e => e.SynPuntoIntegracionPadreTablaLocal)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_padre_tablaLocal");
        builder.Property(e => e.SynPuntoIntegracionPadreUrlConsumir)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_padre_urlConsumir");
        builder.Property(e => e.SynSistemaIntegrarClave)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_sistemaIntegrar_clave");
        builder.Property(e => e.SynSistemaIntegrarEstructuraResponseAutenticar)
            .IsUnicode(false)
            .HasColumnName("syn_sistemaIntegrar_estructuraResponseAutenticar");
        builder.Property(e => e.SynSistemaIntegrarIdTipoAutenticacion).HasColumnName("syn_sistemaIntegrar_id_tipoAutenticacion");
        builder.Property(e => e.SynSistemaIntegrarMetodoAutenticar)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_sistemaIntegrar_metodoAutenticar");
        builder.Property(e => e.SynSistemaIntegrarSistemaIntegrar)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("syn_sistemaIntegrar_sistemaIntegrar");
        builder.Property(e => e.SynSistemaIntegrarSistemaIntegrarCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_sistemaIntegrar_sistemaIntegrar_codigo");
        builder.Property(e => e.SynSistemaIntegrarToken)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("syn_sistemaIntegrar_token");
        builder.Property(e => e.SynSistemaIntegrarUrlAutenticar)
            .HasMaxLength(800)
            .IsUnicode(false)
            .HasColumnName("syn_sistemaIntegrar_urlAutenticar");
        builder.Property(e => e.SynSistemaIntegrarUsuario)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_sistemaIntegrar_usuario");
        builder.Property(e => e.TablaLocal)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("tablaLocal");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UrlConsumir)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("urlConsumir");
    }
}
