using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSegUsuarioConfiguration : IEntityTypeConfiguration<ViewSegUsuario>
{
    public void Configure(EntityTypeBuilder<ViewSegUsuario> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_seg_usuario");

        builder.Property(e => e.AccesoActivo).HasColumnName("accesoActivo");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AplicaRecargo).HasColumnName("aplicaRecargo");
        builder.Property(e => e.CambiarClave).HasColumnName("cambiarClave");
        builder.Property(e => e.Clave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("clave");
        builder.Property(e => e.CostoHora)
            .HasColumnType("money")
            .HasColumnName("costoHora");
        builder.Property(e => e.Direccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("direccion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("email");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaIntentoFallido_fh");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaUltimoCambioClave_fh");
        builder.Property(e => e.FechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaUltimoIngreso_fh");
        builder.Property(e => e.GenZonaCodigoExterno)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("gen_zona_codigoExterno");
        builder.Property(e => e.GenZonaIdZona).HasColumnName("gen_zona_id_zona");
        builder.Property(e => e.GenZonaNivel).HasColumnName("gen_zona_nivel");
        builder.Property(e => e.GenZonaTiempoDesplazamiento).HasColumnName("gen_zona_tiempoDesplazamiento");
        builder.Property(e => e.GenZonaZona)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_zona_zona");
        builder.Property(e => e.GenZonaZonaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_zona_zona_codigo");
        builder.Property(e => e.Habilitado).HasColumnName("habilitado");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCargo).HasColumnName("id_cargo");
        builder.Property(e => e.IdDispositivo)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("idDispositivo");
        builder.Property(e => e.IdGrupo).HasColumnName("id_grupo");
        builder.Property(e => e.IdPerfil).HasColumnName("id_perfil");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.Identificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("identificacion");
        builder.Property(e => e.IntentosFallidos).HasColumnName("intentosFallidos");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Nombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("nombre");
        builder.Property(e => e.NumeroIngresos).HasColumnName("numeroIngresos");
        builder.Property(e => e.PorcentajeComision).HasColumnName("porcentajeComision");
        builder.Property(e => e.Preferencias)
            .HasColumnType("image")
            .HasColumnName("preferencias");
        builder.Property(e => e.Profesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("profesion");
        builder.Property(e => e.SegCargoCargo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_cargo_cargo");
        builder.Property(e => e.SegCargoCargoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_cargo_cargo_codigo");
        builder.Property(e => e.SegCargoEsAdministrativo).HasColumnName("seg_cargo_esAdministrativo");
        builder.Property(e => e.SegCargoEsComercial).HasColumnName("seg_cargo_esComercial");
        builder.Property(e => e.SegCargoEsCoordinador).HasColumnName("seg_cargo_esCoordinador");
        builder.Property(e => e.SegCargoEsTecnico).HasColumnName("seg_cargo_esTecnico");
        builder.Property(e => e.SegCargoValorHora)
            .HasColumnType("money")
            .HasColumnName("seg_cargo_valorHora");
        builder.Property(e => e.SegGrupoActivo).HasColumnName("seg_grupo_activo");
        builder.Property(e => e.SegGrupoGrupo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_grupo_grupo");
        builder.Property(e => e.SegGrupoGrupoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_grupo_grupo_codigo");
        builder.Property(e => e.SegPerfilDescripcion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_perfil_descripcion");
        builder.Property(e => e.SegPerfilMostrarBotones).HasColumnName("seg_perfil_mostrarBotones");
        builder.Property(e => e.SegPerfilParaCliente).HasColumnName("seg_perfil_paraCliente");
        builder.Property(e => e.SegPerfilParaProveedor).HasColumnName("seg_perfil_paraProveedor");
        builder.Property(e => e.SegPerfilPerfil)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_perfil_perfil");
        builder.Property(e => e.SegPerfilPerfilCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_perfil_perfil_codigo");
        builder.Property(e => e.SegUsuarioPadreAccesoActivo).HasColumnName("seg_usuario_padre_accesoActivo");
        builder.Property(e => e.SegUsuarioPadreAplicaRecargo).HasColumnName("seg_usuario_padre_aplicaRecargo");
        builder.Property(e => e.SegUsuarioPadreCambiarClave).HasColumnName("seg_usuario_padre_cambiarClave");
        builder.Property(e => e.SegUsuarioPadreClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_padre_clave");
        builder.Property(e => e.SegUsuarioPadreCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_padre_costoHora");
        builder.Property(e => e.SegUsuarioPadreDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_padre_direccion");
        builder.Property(e => e.SegUsuarioPadreEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_padre_email");
        builder.Property(e => e.SegUsuarioPadreFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_padre_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioPadreFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_padre_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioPadreFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_padre_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioPadreHabilitado).HasColumnName("seg_usuario_padre_habilitado");
        builder.Property(e => e.SegUsuarioPadreIdCargo).HasColumnName("seg_usuario_padre_id_cargo");
        builder.Property(e => e.SegUsuarioPadreIdDispositivo)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_padre_idDispositivo");
        builder.Property(e => e.SegUsuarioPadreIdGrupo).HasColumnName("seg_usuario_padre_id_grupo");
        builder.Property(e => e.SegUsuarioPadreIdPerfil).HasColumnName("seg_usuario_padre_id_perfil");
        builder.Property(e => e.SegUsuarioPadreIdUsuario).HasColumnName("seg_usuario_padre_id_usuario");
        builder.Property(e => e.SegUsuarioPadreIdZona).HasColumnName("seg_usuario_padre_id_zona");
        builder.Property(e => e.SegUsuarioPadreIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_padre_identificacion");
        builder.Property(e => e.SegUsuarioPadreIntentosFallidos).HasColumnName("seg_usuario_padre_intentosFallidos");
        builder.Property(e => e.SegUsuarioPadreNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_padre_nombre");
        builder.Property(e => e.SegUsuarioPadreNumeroIngresos).HasColumnName("seg_usuario_padre_numeroIngresos");
        builder.Property(e => e.SegUsuarioPadrePorcentajeComision).HasColumnName("seg_usuario_padre_porcentajeComision");
        builder.Property(e => e.SegUsuarioPadrePreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_padre_preferencias");
        builder.Property(e => e.SegUsuarioPadreProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_padre_profesion");
        builder.Property(e => e.SegUsuarioPadreSexo).HasColumnName("seg_usuario_padre_sexo");
        builder.Property(e => e.SegUsuarioPadreTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_padre_telefono");
        builder.Property(e => e.SegUsuarioPadreUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_padre_usuario");
        builder.Property(e => e.SegUsuarioPadreUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_padre_usuario_codigo");
        builder.Property(e => e.Sexo).HasColumnName("sexo");
        builder.Property(e => e.Telefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("telefono");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Usuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("usuario");
        builder.Property(e => e.UsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("usuario_codigo");
    }
}
