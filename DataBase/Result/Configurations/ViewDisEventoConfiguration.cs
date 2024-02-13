using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDisEventoConfiguration : IEntityTypeConfiguration<ViewDisEvento>
{
    public void Configure(EntityTypeBuilder<ViewDisEvento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_dis_evento");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AfectaCliente).HasColumnName("afectaCliente");
        builder.Property(e => e.AfectaProduccion).HasColumnName("afectaProduccion");
        builder.Property(e => e.Codigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("codigo");
        builder.Property(e => e.DisEstadoEventoEstadoEvento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("dis_estadoEvento_estadoEvento");
        builder.Property(e => e.DisEstadoEventoEstadoEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_estadoEvento_estadoEvento_codigo");
        builder.Property(e => e.DisMetodoDeteccionMetodoDeteccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("dis_metodoDeteccion_metodoDeteccion");
        builder.Property(e => e.DisMetodoDeteccionMetodoDeteccionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_metodoDeteccion_metodoDeteccion_codigo");
        builder.Property(e => e.DisMotivoEventoEsFalla).HasColumnName("dis_motivoEvento_esFalla");
        builder.Property(e => e.DisMotivoEventoMotivoEvento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("dis_motivoEvento_motivoEvento");
        builder.Property(e => e.DisMotivoEventoMotivoEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_motivoEvento_motivoEvento_codigo");
        builder.Property(e => e.DisMotivoEventoResponsableServicio).HasColumnName("dis_motivoEvento_responsableServicio");
        builder.Property(e => e.DisMotivoEventoVaradaProduccion).HasColumnName("dis_motivoEvento_VaradaProduccion");
        builder.Property(e => e.DuracionHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("duracion_hh");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquEquipoCosto)
            .HasColumnType("money")
            .HasColumnName("equ_equipo_costo");
        builder.Property(e => e.EquEquipoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo");
        builder.Property(e => e.EquEquipoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo_codigo");
        builder.Property(e => e.EquEquipoEquipoSerial)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo_serial");
        builder.Property(e => e.EquEquipoFechaImportacionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_fechaImportacion_ff");
        builder.Property(e => e.EquEquipoFechaPuestaMarchaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_fechaPuestaMarcha_fh");
        builder.Property(e => e.EquEquipoGarantiaCancelada)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_garantiaCancelada");
        builder.Property(e => e.EquEquipoHorasGarantia).HasColumnName("equ_equipo_horasGarantia");
        builder.Property(e => e.EquEquipoHorometroActual).HasColumnName("equ_equipo_horometroActual");
        builder.Property(e => e.EquEquipoIdCatalogoEquipo).HasColumnName("equ_equipo_id_catalogo.equipo");
        builder.Property(e => e.EquEquipoIdEquipo).HasColumnName("equ_equipo_id_equipo");
        builder.Property(e => e.EquEquipoIdEstadoEquipo).HasColumnName("equ_equipo_id_estadoEquipo");
        builder.Property(e => e.EquEquipoIdSistema).HasColumnName("equ_equipo_id_sistema");
        builder.Property(e => e.EquEquipoIdSucursal).HasColumnName("equ_equipo_id_sucursal");
        builder.Property(e => e.EquEquipoIdTercero).HasColumnName("equ_equipo_id_tercero");
        builder.Property(e => e.EquEquipoIdTerceroComprador).HasColumnName("equ_equipo_id_tercero_comprador");
        builder.Property(e => e.EquEquipoIdTerceroServicio).HasColumnName("equ_equipo_id_tercero_servicio");
        builder.Property(e => e.EquEquipoIdVersionEquipo).HasColumnName("equ_equipo_id_versionEquipo");
        builder.Property(e => e.EquEquipoIdZona).HasColumnName("equ_equipo_id_zona");
        builder.Property(e => e.EquEquipoNombreContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_nombreContacto");
        builder.Property(e => e.EquEquipoObservaciones)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_observaciones");
        builder.Property(e => e.EquEquipoPromedioHoras).HasColumnName("equ_equipo_promedioHoras");
        builder.Property(e => e.EquEquipoTelefonoContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_telefonoContacto");
        builder.Property(e => e.EquEquipoUbicacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_ubicacion");
        builder.Property(e => e.EquEquipoUltimaLecturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_ultimaLectura_fh");
        builder.Property(e => e.EquEquipoVencimientoGarantiaDistribuidorFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_vencimientoGarantiaDistribuidor_ff");
        builder.Property(e => e.EquEquipoVencimientoGarantiaFabricaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_vencimientoGarantiaFabrica_ff");
        builder.Property(e => e.EquEstadoEquipoActivo).HasColumnName("equ_estadoEquipo_activo");
        builder.Property(e => e.EquEstadoEquipoEstadoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_estadoEquipo_estadoEquipo");
        builder.Property(e => e.EquEstadoEquipoEstadoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_estadoEquipo_estadoEquipo_codigo");
        builder.Property(e => e.EquFallaCausaFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_causa_falla");
        builder.Property(e => e.EquFallaCausaFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_causa_falla_codigo");
        builder.Property(e => e.EquFallaCausaIdFalla).HasColumnName("equ_falla_causa_id_falla");
        builder.Property(e => e.EquFallaCausaIdTipoFalla).HasColumnName("equ_falla_causa_id_tipoFalla");
        builder.Property(e => e.EquFallaCausaProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_causa_procedimiento");
        builder.Property(e => e.EquFallaFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_falla");
        builder.Property(e => e.EquFallaFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_falla_codigo");
        builder.Property(e => e.EquFallaIdFalla).HasColumnName("equ_falla_id_falla");
        builder.Property(e => e.EquFallaIdTipoFalla).HasColumnName("equ_falla_id_tipoFalla");
        builder.Property(e => e.EquFallaProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_procedimiento");
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
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaHoraEstimadaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaHoraEstimada_fh");
        builder.Property(e => e.FechaHoraInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaHoraInicio_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
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
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Notas)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("notas");
        builder.Property(e => e.SegUsuarioAccesoActivo).HasColumnName("seg_usuario_accesoActivo");
        builder.Property(e => e.SegUsuarioAplicaRecargo).HasColumnName("seg_usuario_aplicaRecargo");
        builder.Property(e => e.SegUsuarioCambiarClave).HasColumnName("seg_usuario_cambiarClave");
        builder.Property(e => e.SegUsuarioClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_clave");
        builder.Property(e => e.SegUsuarioCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_costoHora");
        builder.Property(e => e.SegUsuarioDireccion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_direccion");
        builder.Property(e => e.SegUsuarioEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_email");
        builder.Property(e => e.SegUsuarioFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioHabilitado).HasColumnName("seg_usuario_habilitado");
        builder.Property(e => e.SegUsuarioIdCargo).HasColumnName("seg_usuario_id_cargo");
        builder.Property(e => e.SegUsuarioIdGrupo).HasColumnName("seg_usuario_id_grupo");
        builder.Property(e => e.SegUsuarioIdPerfil).HasColumnName("seg_usuario_id_perfil");
        builder.Property(e => e.SegUsuarioIdUsuario).HasColumnName("seg_usuario_id_usuario");
        builder.Property(e => e.SegUsuarioIdZona).HasColumnName("seg_usuario_id_zona");
        builder.Property(e => e.SegUsuarioIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_identificacion");
        builder.Property(e => e.SegUsuarioIntentosFallidos).HasColumnName("seg_usuario_intentosFallidos");
        builder.Property(e => e.SegUsuarioNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_nombre");
        builder.Property(e => e.SegUsuarioNumeroIngresos).HasColumnName("seg_usuario_numeroIngresos");
        builder.Property(e => e.SegUsuarioPorcentajeComision).HasColumnName("seg_usuario_porcentajeComision");
        builder.Property(e => e.SegUsuarioPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_preferencias");
        builder.Property(e => e.SegUsuarioProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_profesion");
        builder.Property(e => e.SegUsuarioSexo).HasColumnName("seg_usuario_sexo");
        builder.Property(e => e.SegUsuarioTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_telefono");
        builder.Property(e => e.SegUsuarioUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_usuario");
        builder.Property(e => e.SegUsuarioUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_usuario_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
