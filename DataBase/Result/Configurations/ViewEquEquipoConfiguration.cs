using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquEquipoConfiguration : IEntityTypeConfiguration<ViewEquEquipo>
{
    public void Configure(EntityTypeBuilder<ViewEquEquipo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_equipo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoEquipoBloquearCostear).HasColumnName("cat_catalogo_equipo_bloquearCostear");
        builder.Property(e => e.CatCatalogoEquipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_catalogo_codigo");
        builder.Property(e => e.CatCatalogoEquipoCatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.equipo_catalogo.equipo");
        builder.Property(e => e.CatCatalogoEquipoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_codigoInventario");
        builder.Property(e => e.CatCatalogoEquipoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_descripcion");
        builder.Property(e => e.CatCatalogoEquipoEsNacional).HasColumnName("cat_catalogo_equipo_esNacional");
        builder.Property(e => e.CatCatalogoEquipoGarantiaHoras).HasColumnName("cat_catalogo.equipo_garantiaHoras");
        builder.Property(e => e.CatCatalogoEquipoGarantiaMeses).HasColumnName("cat_catalogo.equipo_garantiaMeses");
        builder.Property(e => e.CatCatalogoEquipoIdFamilia).HasColumnName("cat_catalogo_equipo_id_familia");
        builder.Property(e => e.CatCatalogoEquipoIdImpuesto).HasColumnName("cat_catalogo_equipo_id_impuesto");
        builder.Property(e => e.CatCatalogoEquipoIdMarca).HasColumnName("cat_catalogo.equipo_id_marca");
        builder.Property(e => e.CatCatalogoEquipoIdSubtipoCatalogo).HasColumnName("cat_catalogo_equipo_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoEquipoIdUnidad).HasColumnName("cat_catalogo_equipo_id_unidad");
        builder.Property(e => e.CatCatalogoEquipoManejaHorometro).HasColumnName("cat_catalogo.equipo_manejaHorometro");
        builder.Property(e => e.CatCatalogoEquipoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_equipo_precioVenta");
        builder.Property(e => e.CatCatalogoEquipoTiempoConsecucion).HasColumnName("cat_catalogo_equipo_tiempoConsecucion");
        builder.Property(e => e.CatSistemaIdSistema).HasColumnName("cat_sistema_id_sistema");
        builder.Property(e => e.CatSistemaSistema)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_sistema");
        builder.Property(e => e.CatSistemaSistemaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_sistema_codigo");
        builder.Property(e => e.CatSubtipocatalogoSubtipocatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_subtipocatalogo_subtipocatalogo");
        builder.Property(e => e.CatVersionEquipoIdCatalogoEquipo).HasColumnName("cat_versionEquipo_id_catalogo.equipo");
        builder.Property(e => e.CatVersionEquipoVersionEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_versionEquipo_versionEquipo");
        builder.Property(e => e.CatVersionEquipoVersionEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_versionEquipo_versionEquipo_codigo");
        builder.Property(e => e.Costo)
            .HasColumnType("money")
            .HasColumnName("costo");
        builder.Property(e => e.DocCentroCostoCentroCosto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_centroCosto_centroCosto");
        builder.Property(e => e.DocCentroCostoCentroCostoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_centroCosto_centroCosto_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquEquipoPadreCosto)
            .HasColumnType("money")
            .HasColumnName("equ_equipo_padre_costo");
        builder.Property(e => e.EquEquipoPadreEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_equipo");
        builder.Property(e => e.EquEquipoPadreEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_equipo_codigo");
        builder.Property(e => e.EquEquipoPadreEquipoSerial)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_equipo_serial");
        builder.Property(e => e.EquEquipoPadreFechaImportacionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_padre_fechaImportacion_ff");
        builder.Property(e => e.EquEquipoPadreFechaPuestaMarchaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_padre_fechaPuestaMarcha_fh");
        builder.Property(e => e.EquEquipoPadreGarantiaCancelada)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_garantiaCancelada");
        builder.Property(e => e.EquEquipoPadreHorasGarantia).HasColumnName("equ_equipo_padre_horasGarantia");
        builder.Property(e => e.EquEquipoPadreHorometroActual).HasColumnName("equ_equipo_padre_horometroActual");
        builder.Property(e => e.EquEquipoPadreIdCatalogoEquipo).HasColumnName("equ_equipo_padre_id_catalogo.equipo");
        builder.Property(e => e.EquEquipoPadreIdCentroCosto).HasColumnName("equ_equipo_padre_id_centroCosto");
        builder.Property(e => e.EquEquipoPadreIdEquipo).HasColumnName("equ_equipo_padre_id_equipo");
        builder.Property(e => e.EquEquipoPadreIdEstadoEquipo).HasColumnName("equ_equipo_padre_id_estadoEquipo");
        builder.Property(e => e.EquEquipoPadreIdSistema).HasColumnName("equ_equipo_padre_id_sistema");
        builder.Property(e => e.EquEquipoPadreIdSucursal).HasColumnName("equ_equipo_padre_id_sucursal");
        builder.Property(e => e.EquEquipoPadreIdTercero).HasColumnName("equ_equipo_padre_id_tercero");
        builder.Property(e => e.EquEquipoPadreIdTerceroComprador).HasColumnName("equ_equipo_padre_id_tercero_comprador");
        builder.Property(e => e.EquEquipoPadreIdTerceroServicio).HasColumnName("equ_equipo_padre_id_tercero_servicio");
        builder.Property(e => e.EquEquipoPadreIdVersionEquipo).HasColumnName("equ_equipo_padre_id_versionEquipo");
        builder.Property(e => e.EquEquipoPadreIdZona).HasColumnName("equ_equipo_padre_id_zona");
        builder.Property(e => e.EquEquipoPadreNombreContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_nombreContacto");
        builder.Property(e => e.EquEquipoPadreObservaciones)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_observaciones");
        builder.Property(e => e.EquEquipoPadrePromedioHoras).HasColumnName("equ_equipo_padre_promedioHoras");
        builder.Property(e => e.EquEquipoPadreTelefonoContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_telefonoContacto");
        builder.Property(e => e.EquEquipoPadreUbicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_ubicacion");
        builder.Property(e => e.EquEquipoPadreUltimaLecturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_padre_ultimaLectura_fh");
        builder.Property(e => e.EquEquipoPadreVencimientoGarantiaDistribuidorFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_padre_vencimientoGarantiaDistribuidor_ff");
        builder.Property(e => e.EquEquipoPadreVencimientoGarantiaFabricaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_padre_vencimientoGarantiaFabrica_ff");
        builder.Property(e => e.EquEstadoEquipoActivo).HasColumnName("equ_estadoEquipo_activo");
        builder.Property(e => e.EquEstadoEquipoEstadoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_estadoEquipo_estadoEquipo");
        builder.Property(e => e.EquEstadoEquipoEstadoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_estadoEquipo_estadoEquipo_codigo");
        builder.Property(e => e.Equipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equipo");
        builder.Property(e => e.EquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equipo_codigo");
        builder.Property(e => e.EquipoSerial)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equipo_serial");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaImportacionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaImportacion_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaPuestaMarchaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaPuestaMarcha_fh");
        builder.Property(e => e.GarantiaCancelada)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("garantiaCancelada");
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
        builder.Property(e => e.HorasGarantia).HasColumnName("horasGarantia");
        builder.Property(e => e.HorometroActual).HasColumnName("horometroActual");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCatalogoEquipo).HasColumnName("id_catalogo.equipo");
        builder.Property(e => e.IdCentroCosto).HasColumnName("id_centroCosto");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdEstadoEquipo).HasColumnName("id_estadoEquipo");
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdTerceroComprador).HasColumnName("id_tercero_comprador");
        builder.Property(e => e.IdTerceroServicio).HasColumnName("id_tercero_servicio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdVersionEquipo).HasColumnName("id_versionEquipo");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.NombreContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("nombreContacto");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("observaciones");
        builder.Property(e => e.PromedioHoras).HasColumnName("promedioHoras");
        builder.Property(e => e.TelefonoContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("telefonoContacto");
        builder.Property(e => e.TerSucursalCargo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_cargo");
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
        builder.Property(e => e.TerTerceroClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_clasificacion");
        builder.Property(e => e.TerTerceroCompradorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_clasificacion");
        builder.Property(e => e.TerTerceroCompradorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_contacto");
        builder.Property(e => e.TerTerceroCompradorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_direccion");
        builder.Property(e => e.TerTerceroCompradorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_email");
        builder.Property(e => e.TerTerceroCompradorEsCliente).HasColumnName("ter_tercero_comprador_esCliente");
        builder.Property(e => e.TerTerceroCompradorEsEmpresaPropia).HasColumnName("ter_tercero_comprador_esEmpresaPropia");
        builder.Property(e => e.TerTerceroCompradorEsFabricante).HasColumnName("ter_tercero_comprador_esFabricante");
        builder.Property(e => e.TerTerceroCompradorEsProspecto).HasColumnName("ter_tercero_comprador_esProspecto");
        builder.Property(e => e.TerTerceroCompradorEsProveedor).HasColumnName("ter_tercero_comprador_esProveedor");
        builder.Property(e => e.TerTerceroCompradorEsTransportador).HasColumnName("ter_tercero_comprador_esTransportador");
        builder.Property(e => e.TerTerceroCompradorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_fax");
        builder.Property(e => e.TerTerceroCompradorIdEstadoTercero).HasColumnName("ter_tercero_comprador_id_estadoTercero");
        builder.Property(e => e.TerTerceroCompradorIdNaturalezaTercero).HasColumnName("ter_tercero_comprador_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroCompradorIdZona).HasColumnName("ter_tercero_comprador_id_zona");
        builder.Property(e => e.TerTerceroCompradorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_notas");
        builder.Property(e => e.TerTerceroCompradorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_representante");
        builder.Property(e => e.TerTerceroCompradorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_telefono");
        builder.Property(e => e.TerTerceroCompradorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_tercero");
        builder.Property(e => e.TerTerceroCompradorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_tercero_codigo");
        builder.Property(e => e.TerTerceroCompradorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_tercero_nit");
        builder.Property(e => e.TerTerceroCompradorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroCompradorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_comprador_website");
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
        builder.Property(e => e.TerTerceroServicioClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_clasificacion");
        builder.Property(e => e.TerTerceroServicioContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_contacto");
        builder.Property(e => e.TerTerceroServicioDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_direccion");
        builder.Property(e => e.TerTerceroServicioEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_email");
        builder.Property(e => e.TerTerceroServicioEsCliente).HasColumnName("ter_tercero_servicio_esCliente");
        builder.Property(e => e.TerTerceroServicioEsEmpresaPropia).HasColumnName("ter_tercero_servicio_esEmpresaPropia");
        builder.Property(e => e.TerTerceroServicioEsFabricante).HasColumnName("ter_tercero_servicio_esFabricante");
        builder.Property(e => e.TerTerceroServicioEsProspecto).HasColumnName("ter_tercero_servicio_esProspecto");
        builder.Property(e => e.TerTerceroServicioEsProveedor).HasColumnName("ter_tercero_servicio_esProveedor");
        builder.Property(e => e.TerTerceroServicioEsTransportador).HasColumnName("ter_tercero_servicio_esTransportador");
        builder.Property(e => e.TerTerceroServicioFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_fax");
        builder.Property(e => e.TerTerceroServicioIdEstadoTercero).HasColumnName("ter_tercero_servicio_id_estadoTercero");
        builder.Property(e => e.TerTerceroServicioIdNaturalezaTercero).HasColumnName("ter_tercero_servicio_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroServicioIdZona).HasColumnName("ter_tercero_servicio_id_zona");
        builder.Property(e => e.TerTerceroServicioNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_notas");
        builder.Property(e => e.TerTerceroServicioRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_representante");
        builder.Property(e => e.TerTerceroServicioTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_telefono");
        builder.Property(e => e.TerTerceroServicioTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_tercero");
        builder.Property(e => e.TerTerceroServicioTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_tercero_codigo");
        builder.Property(e => e.TerTerceroServicioTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_tercero_nit");
        builder.Property(e => e.TerTerceroServicioTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroServicioWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_servicio_website");
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
        builder.Property(e => e.Ubicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ubicacion");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UltimaLecturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("ultimaLectura_fh");
        builder.Property(e => e.VencimientoGarantiaDistribuidorFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("vencimientoGarantiaDistribuidor_ff");
        builder.Property(e => e.VencimientoGarantiaFabricaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("vencimientoGarantiaFabrica_ff");
    }
}
