using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenNotificacionConfiguration : IEntityTypeConfiguration<ViewGenNotificacion>
{
    public void Configure(EntityTypeBuilder<ViewGenNotificacion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_notificacion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Datos).HasColumnName("datos");
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
        builder.Property(e => e.IdTipoNotificacion).HasColumnName("id_tipoNotificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioDestino).HasColumnName("id_usuario_destino");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioOrigen).HasColumnName("id_usuario_origen");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Notificacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("notificacion");
        builder.Property(e => e.NotificacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("notificacion_codigo");
        builder.Property(e => e.SegUsuarioDestinoAccesoActivo).HasColumnName("seg_usuario_destino_accesoActivo");
        builder.Property(e => e.SegUsuarioDestinoAplicaRecargo).HasColumnName("seg_usuario_destino_aplicaRecargo");
        builder.Property(e => e.SegUsuarioDestinoCambiarClave).HasColumnName("seg_usuario_destino_cambiarClave");
        builder.Property(e => e.SegUsuarioDestinoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_destino_clave");
        builder.Property(e => e.SegUsuarioDestinoCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_destino_costoHora");
        builder.Property(e => e.SegUsuarioDestinoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_destino_direccion");
        builder.Property(e => e.SegUsuarioDestinoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_destino_email");
        builder.Property(e => e.SegUsuarioDestinoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_destino_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioDestinoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_destino_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioDestinoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_destino_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioDestinoHabilitado).HasColumnName("seg_usuario_destino_habilitado");
        builder.Property(e => e.SegUsuarioDestinoIdCargo).HasColumnName("seg_usuario_destino_id_cargo");
        builder.Property(e => e.SegUsuarioDestinoIdDispositivo)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_destino_idDispositivo");
        builder.Property(e => e.SegUsuarioDestinoIdGrupo).HasColumnName("seg_usuario_destino_id_grupo");
        builder.Property(e => e.SegUsuarioDestinoIdPerfil).HasColumnName("seg_usuario_destino_id_perfil");
        builder.Property(e => e.SegUsuarioDestinoIdUsuario).HasColumnName("seg_usuario_destino_id_usuario");
        builder.Property(e => e.SegUsuarioDestinoIdZona).HasColumnName("seg_usuario_destino_id_zona");
        builder.Property(e => e.SegUsuarioDestinoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_destino_identificacion");
        builder.Property(e => e.SegUsuarioDestinoIntentosFallidos).HasColumnName("seg_usuario_destino_intentosFallidos");
        builder.Property(e => e.SegUsuarioDestinoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_destino_nombre");
        builder.Property(e => e.SegUsuarioDestinoNumeroIngresos).HasColumnName("seg_usuario_destino_numeroIngresos");
        builder.Property(e => e.SegUsuarioDestinoPorcentajeComision).HasColumnName("seg_usuario_destino_porcentajeComision");
        builder.Property(e => e.SegUsuarioDestinoPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_destino_preferencias");
        builder.Property(e => e.SegUsuarioDestinoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_destino_profesion");
        builder.Property(e => e.SegUsuarioDestinoSexo).HasColumnName("seg_usuario_destino_sexo");
        builder.Property(e => e.SegUsuarioDestinoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_destino_telefono");
        builder.Property(e => e.SegUsuarioDestinoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_destino_usuario");
        builder.Property(e => e.SegUsuarioDestinoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_destino_usuario_codigo");
        builder.Property(e => e.SegUsuarioOrigenAccesoActivo).HasColumnName("seg_usuario_origen_accesoActivo");
        builder.Property(e => e.SegUsuarioOrigenAplicaRecargo).HasColumnName("seg_usuario_origen_aplicaRecargo");
        builder.Property(e => e.SegUsuarioOrigenCambiarClave).HasColumnName("seg_usuario_origen_cambiarClave");
        builder.Property(e => e.SegUsuarioOrigenClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_origen_clave");
        builder.Property(e => e.SegUsuarioOrigenCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_origen_costoHora");
        builder.Property(e => e.SegUsuarioOrigenDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_origen_direccion");
        builder.Property(e => e.SegUsuarioOrigenEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_origen_email");
        builder.Property(e => e.SegUsuarioOrigenFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_origen_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioOrigenFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_origen_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioOrigenFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_origen_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioOrigenHabilitado).HasColumnName("seg_usuario_origen_habilitado");
        builder.Property(e => e.SegUsuarioOrigenIdCargo).HasColumnName("seg_usuario_origen_id_cargo");
        builder.Property(e => e.SegUsuarioOrigenIdDispositivo)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_origen_idDispositivo");
        builder.Property(e => e.SegUsuarioOrigenIdGrupo).HasColumnName("seg_usuario_origen_id_grupo");
        builder.Property(e => e.SegUsuarioOrigenIdPerfil).HasColumnName("seg_usuario_origen_id_perfil");
        builder.Property(e => e.SegUsuarioOrigenIdUsuario).HasColumnName("seg_usuario_origen_id_usuario");
        builder.Property(e => e.SegUsuarioOrigenIdZona).HasColumnName("seg_usuario_origen_id_zona");
        builder.Property(e => e.SegUsuarioOrigenIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_origen_identificacion");
        builder.Property(e => e.SegUsuarioOrigenIntentosFallidos).HasColumnName("seg_usuario_origen_intentosFallidos");
        builder.Property(e => e.SegUsuarioOrigenNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_origen_nombre");
        builder.Property(e => e.SegUsuarioOrigenNumeroIngresos).HasColumnName("seg_usuario_origen_numeroIngresos");
        builder.Property(e => e.SegUsuarioOrigenPorcentajeComision).HasColumnName("seg_usuario_origen_porcentajeComision");
        builder.Property(e => e.SegUsuarioOrigenPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_origen_preferencias");
        builder.Property(e => e.SegUsuarioOrigenProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_origen_profesion");
        builder.Property(e => e.SegUsuarioOrigenSexo).HasColumnName("seg_usuario_origen_sexo");
        builder.Property(e => e.SegUsuarioOrigenTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_origen_telefono");
        builder.Property(e => e.SegUsuarioOrigenUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_origen_usuario");
        builder.Property(e => e.SegUsuarioOrigenUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_origen_usuario_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
