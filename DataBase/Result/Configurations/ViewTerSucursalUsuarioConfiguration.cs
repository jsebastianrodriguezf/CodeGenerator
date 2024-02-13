using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewTerSucursalUsuarioConfiguration : IEntityTypeConfiguration<ViewTerSucursalUsuario>
{
    public void Configure(EntityTypeBuilder<ViewTerSucursalUsuario> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_ter_sucursal_usuario");

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
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
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
            .HasMaxLength(300)
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
        builder.Property(e => e.SucursalUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sucursal_usuario");
        builder.Property(e => e.TerSucursalCodigorecursiva)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_codigorecursiva");
        builder.Property(e => e.TerSucursalContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_contacto");
        builder.Property(e => e.TerSucursalDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Direccion");
        builder.Property(e => e.TerSucursalEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Email");
        builder.Property(e => e.TerSucursalFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Fax");
        builder.Property(e => e.TerSucursalIdEstadoTercero).HasColumnName("ter_sucursal_id_estadoTercero");
        builder.Property(e => e.TerSucursalIdSucursal).HasColumnName("ter_sucursal_id_sucursal");
        builder.Property(e => e.TerSucursalIdTercero).HasColumnName("ter_sucursal_id_tercero");
        builder.Property(e => e.TerSucursalIdUsuarioAsesor).HasColumnName("ter_sucursal_id_usuario_asesor");
        builder.Property(e => e.TerSucursalIdUsuarioTecnico).HasColumnName("ter_sucursal_id_usuario_tecnico");
        builder.Property(e => e.TerSucursalIdZona).HasColumnName("ter_sucursal_id_zona");
        builder.Property(e => e.TerSucursalParaAlquiler).HasColumnName("ter_sucursal_paraAlquiler");
        builder.Property(e => e.TerSucursalParaSoporte).HasColumnName("ter_sucursal_paraSoporte");
        builder.Property(e => e.TerSucursalParaVenta).HasColumnName("ter_sucursal_paraVenta");
        builder.Property(e => e.TerSucursalSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal");
        builder.Property(e => e.TerSucursalSucursalCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal_codigo");
        builder.Property(e => e.TerSucursalTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_telefono");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
