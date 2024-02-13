using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquDetalleAlquilerConfiguration : IEntityTypeConfiguration<ViewEquDetalleAlquiler>
{
    public void Configure(EntityTypeBuilder<ViewEquDetalleAlquiler> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_detalleAlquiler");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.BloquearDespacho).HasColumnName("bloquearDespacho");
        builder.Property(e => e.CantidadAlquilada).HasColumnName("cantidadAlquilada");
        builder.Property(e => e.CantidadSolicitada).HasColumnName("cantidadSolicitada");
        builder.Property(e => e.CatCatalogoBloquearCostear).HasColumnName("cat_catalogo_bloquearCostear");
        builder.Property(e => e.CatCatalogoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_catalogo");
        builder.Property(e => e.CatCatalogoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_catalogo_codigo");
        builder.Property(e => e.CatCatalogoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_codigoInventario");
        builder.Property(e => e.CatCatalogoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_descripcion");
        builder.Property(e => e.CatCatalogoEsNacional).HasColumnName("cat_catalogo_esNacional");
        builder.Property(e => e.CatCatalogoIdFamilia).HasColumnName("cat_catalogo_id_familia");
        builder.Property(e => e.CatCatalogoIdImpuesto).HasColumnName("cat_catalogo_id_impuesto");
        builder.Property(e => e.CatCatalogoIdSubtipoCatalogo).HasColumnName("cat_catalogo_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoIdUnidad).HasColumnName("cat_catalogo_id_unidad");
        builder.Property(e => e.CatCatalogoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_precioVenta");
        builder.Property(e => e.CatCatalogoTiempoConsecucion).HasColumnName("cat_catalogo_tiempoConsecucion");
        builder.Property(e => e.DetalleAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleAlquiler");
        builder.Property(e => e.DetalleAlquilerCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleAlquiler_codigo");
        builder.Property(e => e.DocDocumentoAlquilerCosto).HasColumnName("doc_documento_alquiler_costo");
        builder.Property(e => e.DocDocumentoAlquilerCostoPlaneado).HasColumnName("doc_documento_alquiler_costoPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDescuento).HasColumnName("doc_documento_alquiler_descuento");
        builder.Property(e => e.DocDocumentoAlquilerDescuentoPlaneado).HasColumnName("doc_documento_alquiler_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.alquiler_documento.alquiler");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_documento_codigo");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoNumero).HasColumnName("doc_documento_alquiler_documento_numero");
        builder.Property(e => e.DocDocumentoAlquilerFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoAlquilerFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fecha_fh");
        builder.Property(e => e.DocDocumentoAlquilerFechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.alquiler_fechaFin_ff");
        builder.Property(e => e.DocDocumentoAlquilerFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoAlquilerFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoAlquilerIdDocumento).HasColumnName("doc_documento_alquiler_id_documento");
        builder.Property(e => e.DocDocumentoAlquilerIdEstadoTipoDocumento).HasColumnName("doc_documento_alquiler_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerIdMoneda).HasColumnName("doc_documento_alquiler_id_moneda");
        builder.Property(e => e.DocDocumentoAlquilerIdMotivoestado).HasColumnName("doc_documento_alquiler_id_motivoestado");
        builder.Property(e => e.DocDocumentoAlquilerIdPrioridadDocumento).HasColumnName("doc_documento_alquiler_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoAlquilerIdSubtipoDocumento).HasColumnName("doc_documento_alquiler_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerIdTerceroCliente).HasColumnName("doc_documento_alquiler_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoAlquilerIdTerceroProveedor).HasColumnName("doc_documento_alquiler_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoAlquilerIva).HasColumnName("doc_documento_alquiler_iva");
        builder.Property(e => e.DocDocumentoAlquilerIvaPlaneado).HasColumnName("doc_documento_alquiler_ivaPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerMesVencido).HasColumnName("doc_documento.alquiler_mesVencido");
        builder.Property(e => e.DocDocumentoAlquilerObservaciones)
            .HasMaxLength(3000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.alquiler_observaciones");
        builder.Property(e => e.DocDocumentoAlquilerPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_prefijo");
        builder.Property(e => e.DocDocumentoAlquilerRentabilidad).HasColumnName("doc_documento_alquiler_rentabilidad");
        builder.Property(e => e.DocDocumentoAlquilerSubtotal).HasColumnName("doc_documento_alquiler_subtotal");
        builder.Property(e => e.DocDocumentoAlquilerSubtotalPlaneado).HasColumnName("doc_documento_alquiler_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerTotal).HasColumnName("doc_documento_alquiler_total");
        builder.Property(e => e.DocDocumentoAlquilerTotalPlaneado).HasColumnName("doc_documento_alquiler_totalPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerTrm).HasColumnName("doc_documento_alquiler_trm");
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
            .HasMaxLength(300)
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
        builder.Property(e => e.EsSerializado).HasColumnName("esSerializado");
        builder.Property(e => e.Estadoalquiler).HasColumnName("estadoalquiler");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaDespachoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaDespacho_ff");
        builder.Property(e => e.FechaDevolucionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaDevolucion_ff");
        builder.Property(e => e.FechaInicioFacturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioFactura_fh");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaUltimaFacturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaUltimaFactura_fh");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdDocumentoAlquiler).HasColumnName("id_documento.alquiler");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
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
        builder.Property(e => e.ValorHora)
            .HasColumnType("money")
            .HasColumnName("valorHora");
        builder.Property(e => e.ValorHoraStandBy).HasColumnType("money");
        builder.Property(e => e.ValorMes).HasColumnName("valorMes");
        builder.Property(e => e.ValorMulta)
            .HasColumnType("money")
            .HasColumnName("valorMulta");
        builder.Property(e => e.ValorPeriodo)
            .HasColumnType("money")
            .HasColumnName("valorPeriodo");
    }
}
