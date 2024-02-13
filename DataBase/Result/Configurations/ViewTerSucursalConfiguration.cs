using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewTerSucursalConfiguration : IEntityTypeConfiguration<ViewTerSucursal>
{
    public void Configure(EntityTypeBuilder<ViewTerSucursal> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_ter_sucursal");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Cargo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cargo");
        builder.Property(e => e.Codigorecursiva)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("codigorecursiva");
        builder.Property(e => e.Contacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contacto");
        builder.Property(e => e.Direccion)
            .HasMaxLength(300)
            .IsUnicode(false);
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false);
        builder.Property(e => e.Fax)
            .HasMaxLength(100)
            .IsUnicode(false);
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
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
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEstadoTercero).HasColumnName("id_estadoTercero");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioAsesor).HasColumnName("id_usuario_asesor");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioTecnico).HasColumnName("id_usuario_tecnico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ParaAlquiler).HasColumnName("paraAlquiler");
        builder.Property(e => e.ParaSoporte).HasColumnName("paraSoporte");
        builder.Property(e => e.ParaVenta).HasColumnName("paraVenta");
        builder.Property(e => e.SegUsuarioAsesorAccesoActivo).HasColumnName("seg_usuario_asesor_accesoActivo");
        builder.Property(e => e.SegUsuarioAsesorAplicaRecargo).HasColumnName("seg_usuario_asesor_aplicaRecargo");
        builder.Property(e => e.SegUsuarioAsesorCambiarClave).HasColumnName("seg_usuario_asesor_cambiarClave");
        builder.Property(e => e.SegUsuarioAsesorClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_clave");
        builder.Property(e => e.SegUsuarioAsesorCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_asesor_costoHora");
        builder.Property(e => e.SegUsuarioAsesorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_direccion");
        builder.Property(e => e.SegUsuarioAsesorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_email");
        builder.Property(e => e.SegUsuarioAsesorFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_asesor_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioAsesorFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_asesor_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioAsesorFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_asesor_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioAsesorHabilitado).HasColumnName("seg_usuario_asesor_habilitado");
        builder.Property(e => e.SegUsuarioAsesorIdCargo).HasColumnName("seg_usuario_asesor_id_cargo");
        builder.Property(e => e.SegUsuarioAsesorIdGrupo).HasColumnName("seg_usuario_asesor_id_grupo");
        builder.Property(e => e.SegUsuarioAsesorIdPerfil).HasColumnName("seg_usuario_asesor_id_perfil");
        builder.Property(e => e.SegUsuarioAsesorIdUsuario).HasColumnName("seg_usuario_asesor_id_usuario");
        builder.Property(e => e.SegUsuarioAsesorIdZona).HasColumnName("seg_usuario_asesor_id_zona");
        builder.Property(e => e.SegUsuarioAsesorIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_identificacion");
        builder.Property(e => e.SegUsuarioAsesorIntentosFallidos).HasColumnName("seg_usuario_asesor_intentosFallidos");
        builder.Property(e => e.SegUsuarioAsesorNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_nombre");
        builder.Property(e => e.SegUsuarioAsesorNumeroIngresos).HasColumnName("seg_usuario_asesor_numeroIngresos");
        builder.Property(e => e.SegUsuarioAsesorPorcentajeComision).HasColumnName("seg_usuario_asesor_porcentajeComision");
        builder.Property(e => e.SegUsuarioAsesorPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_asesor_preferencias");
        builder.Property(e => e.SegUsuarioAsesorProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_profesion");
        builder.Property(e => e.SegUsuarioAsesorSexo).HasColumnName("seg_usuario_asesor_sexo");
        builder.Property(e => e.SegUsuarioAsesorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_telefono");
        builder.Property(e => e.SegUsuarioAsesorUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_usuario");
        builder.Property(e => e.SegUsuarioAsesorUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_asesor_usuario_codigo");
        builder.Property(e => e.SegUsuarioTecnicoAccesoActivo).HasColumnName("seg_usuario_tecnico_accesoActivo");
        builder.Property(e => e.SegUsuarioTecnicoAplicaRecargo).HasColumnName("seg_usuario_tecnico_aplicaRecargo");
        builder.Property(e => e.SegUsuarioTecnicoCambiarClave).HasColumnName("seg_usuario_tecnico_cambiarClave");
        builder.Property(e => e.SegUsuarioTecnicoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_tecnico_clave");
        builder.Property(e => e.SegUsuarioTecnicoCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_tecnico_costoHora");
        builder.Property(e => e.SegUsuarioTecnicoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_tecnico_direccion");
        builder.Property(e => e.SegUsuarioTecnicoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_tecnico_email");
        builder.Property(e => e.SegUsuarioTecnicoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_tecnico_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioTecnicoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_tecnico_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioTecnicoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_tecnico_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioTecnicoHabilitado).HasColumnName("seg_usuario_tecnico_habilitado");
        builder.Property(e => e.SegUsuarioTecnicoIdCargo).HasColumnName("seg_usuario_tecnico_id_cargo");
        builder.Property(e => e.SegUsuarioTecnicoIdGrupo).HasColumnName("seg_usuario_tecnico_id_grupo");
        builder.Property(e => e.SegUsuarioTecnicoIdPerfil).HasColumnName("seg_usuario_tecnico_id_perfil");
        builder.Property(e => e.SegUsuarioTecnicoIdUsuario).HasColumnName("seg_usuario_tecnico_id_usuario");
        builder.Property(e => e.SegUsuarioTecnicoIdZona).HasColumnName("seg_usuario_tecnico_id_zona");
        builder.Property(e => e.SegUsuarioTecnicoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_tecnico_identificacion");
        builder.Property(e => e.SegUsuarioTecnicoIntentosFallidos).HasColumnName("seg_usuario_tecnico_intentosFallidos");
        builder.Property(e => e.SegUsuarioTecnicoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_tecnico_nombre");
        builder.Property(e => e.SegUsuarioTecnicoNumeroIngresos).HasColumnName("seg_usuario_tecnico_numeroIngresos");
        builder.Property(e => e.SegUsuarioTecnicoPorcentajeComision).HasColumnName("seg_usuario_tecnico_porcentajeComision");
        builder.Property(e => e.SegUsuarioTecnicoPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_tecnico_preferencias");
        builder.Property(e => e.SegUsuarioTecnicoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_tecnico_profesion");
        builder.Property(e => e.SegUsuarioTecnicoSexo).HasColumnName("seg_usuario_tecnico_sexo");
        builder.Property(e => e.SegUsuarioTecnicoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_tecnico_telefono");
        builder.Property(e => e.SegUsuarioTecnicoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_tecnico_usuario");
        builder.Property(e => e.SegUsuarioTecnicoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_tecnico_usuario_codigo");
        builder.Property(e => e.Sucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sucursal");
        builder.Property(e => e.SucursalCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("sucursal_codigo");
        builder.Property(e => e.Telefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("telefono");
        builder.Property(e => e.TerEstadoTerceroEstadoTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_estadoTercero_estadoTercero");
        builder.Property(e => e.TerEstadoTerceroEstadoTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_estadoTercero_estadoTercero_codigo");
        builder.Property(e => e.TerSucursalPadreCargo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_padre_cargo");
        builder.Property(e => e.TerSucursalPadreCodigorecursiva)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_padre_codigorecursiva");
        builder.Property(e => e.TerSucursalPadreContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_padre_contacto");
        builder.Property(e => e.TerSucursalPadreDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_padre_Direccion");
        builder.Property(e => e.TerSucursalPadreEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_padre_Email");
        builder.Property(e => e.TerSucursalPadreFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_padre_Fax");
        builder.Property(e => e.TerSucursalPadreIdEstadoTercero).HasColumnName("ter_sucursal_padre_id_estadoTercero");
        builder.Property(e => e.TerSucursalPadreIdSucursal).HasColumnName("ter_sucursal_padre_id_sucursal");
        builder.Property(e => e.TerSucursalPadreIdTercero).HasColumnName("ter_sucursal_padre_id_tercero");
        builder.Property(e => e.TerSucursalPadreIdUsuarioAsesor).HasColumnName("ter_sucursal_padre_id_usuario_asesor");
        builder.Property(e => e.TerSucursalPadreIdUsuarioTecnico).HasColumnName("ter_sucursal_padre_id_usuario_tecnico");
        builder.Property(e => e.TerSucursalPadreIdZona).HasColumnName("ter_sucursal_padre_id_zona");
        builder.Property(e => e.TerSucursalPadreParaAlquiler).HasColumnName("ter_sucursal_padre_paraAlquiler");
        builder.Property(e => e.TerSucursalPadreParaSoporte).HasColumnName("ter_sucursal_padre_paraSoporte");
        builder.Property(e => e.TerSucursalPadreParaVenta).HasColumnName("ter_sucursal_padre_paraVenta");
        builder.Property(e => e.TerSucursalPadreSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_padre_sucursal");
        builder.Property(e => e.TerSucursalPadreSucursalCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_padre_sucursal_codigo");
        builder.Property(e => e.TerSucursalPadreTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_padre_telefono");
        builder.Property(e => e.TerTerceroClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_clasificacion");
        builder.Property(e => e.TerTerceroContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_contacto");
        builder.Property(e => e.TerTerceroDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_direccion");
        builder.Property(e => e.TerTerceroEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_email");
        builder.Property(e => e.TerTerceroEsCliente).HasColumnName("ter_tercero_esCliente");
        builder.Property(e => e.TerTerceroEsEmpresaPropia).HasColumnName("ter_tercero_esEmpresaPropia");
        builder.Property(e => e.TerTerceroEsFabricante).HasColumnName("ter_tercero_esFabricante");
        builder.Property(e => e.TerTerceroEsProspecto).HasColumnName("ter_tercero_esProspecto");
        builder.Property(e => e.TerTerceroEsProveedor).HasColumnName("ter_tercero_esProveedor");
        builder.Property(e => e.TerTerceroEsTransportador).HasColumnName("ter_tercero_esTransportador");
        builder.Property(e => e.TerTerceroFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fax");
        builder.Property(e => e.TerTerceroIdEstadoTercero).HasColumnName("ter_tercero_id_estadoTercero");
        builder.Property(e => e.TerTerceroIdNaturalezaTercero).HasColumnName("ter_tercero_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroIdZona).HasColumnName("ter_tercero_id_zona");
        builder.Property(e => e.TerTerceroNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_notas");
        builder.Property(e => e.TerTerceroRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_representante");
        builder.Property(e => e.TerTerceroTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_telefono");
        builder.Property(e => e.TerTerceroTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero");
        builder.Property(e => e.TerTerceroTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_codigo");
        builder.Property(e => e.TerTerceroTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_nit");
        builder.Property(e => e.TerTerceroTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_website");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
