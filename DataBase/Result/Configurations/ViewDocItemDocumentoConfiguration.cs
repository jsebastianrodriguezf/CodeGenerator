using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocItemDocumentoConfiguration : IEntityTypeConfiguration<ViewDocItemDocumento>
{
    public void Configure(EntityTypeBuilder<ViewDocItemDocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_itemDocumento");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AfectoInventario).HasColumnName("afectoInventario");
        builder.Property(e => e.CantAuxiliar).HasColumnName("cantAuxiliar");
        builder.Property(e => e.CantidadEjecutado).HasColumnName("cantidadEjecutado");
        builder.Property(e => e.CantidadPlaneado).HasColumnName("cantidadPlaneado");
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
        builder.Property(e => e.CatListaPrecioEsPrivado).HasColumnName("cat_listaPrecio_esPrivado");
        builder.Property(e => e.CatListaPrecioIdMoneda).HasColumnName("cat_listaPrecio_id_moneda");
        builder.Property(e => e.CatListaPrecioListaPrecio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_listaPrecio_listaPrecio");
        builder.Property(e => e.CatListaPrecioListaPrecioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_listaPrecio_listaPrecio_codigo");
        builder.Property(e => e.CatListaPrecioParaCompra).HasColumnName("cat_listaPrecio_paraCompra");
        builder.Property(e => e.CatListaPrecioPorcentajeDescuento).HasColumnName("cat_listaPrecio_porcentajeDescuento");
        builder.Property(e => e.Costear).HasColumnName("costear");
        builder.Property(e => e.CostoEjecutado).HasColumnName("costoEjecutado");
        builder.Property(e => e.CostoPlaneado).HasColumnName("costoPlaneado");
        builder.Property(e => e.Detalle)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalle");
        builder.Property(e => e.DocCentroCostoCentroCosto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_centroCosto_centroCosto");
        builder.Property(e => e.DocCentroCostoCentroCostoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_centroCosto_centroCosto_codigo");
        builder.Property(e => e.DocDocumentoCosto).HasColumnName("doc_documento_costo");
        builder.Property(e => e.DocDocumentoCostoPlaneado).HasColumnName("doc_documento_costoPlaneado");
        builder.Property(e => e.DocDocumentoDescuento).HasColumnName("doc_documento_descuento");
        builder.Property(e => e.DocDocumentoDescuentoPlaneado).HasColumnName("doc_documento_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_documento");
        builder.Property(e => e.DocDocumentoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_documento_codigo");
        builder.Property(e => e.DocDocumentoDocumentoNumero).HasColumnName("doc_documento_documento_numero");
        builder.Property(e => e.DocDocumentoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fecha_fh");
        builder.Property(e => e.DocDocumentoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoIdDocumento).HasColumnName("doc_documento_id_documento");
        builder.Property(e => e.DocDocumentoIdEstadoTipoDocumento).HasColumnName("doc_documento_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoIdMoneda).HasColumnName("doc_documento_id_moneda");
        builder.Property(e => e.DocDocumentoIdMotivoestado).HasColumnName("doc_documento_id_motivoestado");
        builder.Property(e => e.DocDocumentoIdPrioridadDocumento).HasColumnName("doc_documento_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoIdSubtipoDocumento).HasColumnName("doc_documento_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoIdTerceroCliente).HasColumnName("doc_documento_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoIdTerceroProveedor).HasColumnName("doc_documento_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoIdUsuarioAsignado).HasColumnName("doc_documento_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoIdUsuarioEnUso).HasColumnName("doc_documento_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoIva).HasColumnName("doc_documento_iva");
        builder.Property(e => e.DocDocumentoIvaPlaneado).HasColumnName("doc_documento_ivaPlaneado");
        builder.Property(e => e.DocDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_prefijo");
        builder.Property(e => e.DocDocumentoRentabilidad).HasColumnName("doc_documento_rentabilidad");
        builder.Property(e => e.DocDocumentoSubtotal).HasColumnName("doc_documento_subtotal");
        builder.Property(e => e.DocDocumentoSubtotalPlaneado).HasColumnName("doc_documento_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoTotal).HasColumnName("doc_documento_total");
        builder.Property(e => e.DocDocumentoTotalPlaneado).HasColumnName("doc_documento_totalPlaneado");
        builder.Property(e => e.DocDocumentoTrm).HasColumnName("doc_documento_trm");
        builder.Property(e => e.DocIncotermIncoterm)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_incoterm_incoterm");
        builder.Property(e => e.DocIncotermIncotermCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_incoterm_incoterm_codigo");
        builder.Property(e => e.DocItemDocumentoPadreAfectoInventario).HasColumnName("doc_itemDocumento_padre_afectoInventario");
        builder.Property(e => e.DocItemDocumentoPadreCantAuxiliar).HasColumnName("doc_itemDocumento_padre_cantAuxiliar");
        builder.Property(e => e.DocItemDocumentoPadreCantidadEjecutado).HasColumnName("doc_itemDocumento_padre_cantidadEjecutado");
        builder.Property(e => e.DocItemDocumentoPadreCantidadPlaneado).HasColumnName("doc_itemDocumento_padre_cantidadPlaneado");
        builder.Property(e => e.DocItemDocumentoPadreCostear).HasColumnName("doc_itemDocumento_padre_costear");
        builder.Property(e => e.DocItemDocumentoPadreCostoEjecutado).HasColumnName("doc_itemDocumento_padre_costoEjecutado");
        builder.Property(e => e.DocItemDocumentoPadreCostoPlaneado).HasColumnName("doc_itemDocumento_padre_costoPlaneado");
        builder.Property(e => e.DocItemDocumentoPadreDetalle)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_padre_detalle");
        builder.Property(e => e.DocItemDocumentoPadreDtoEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_padre_dtoEjecutado");
        builder.Property(e => e.DocItemDocumentoPadreDtoPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_padre_dtoPlaneado");
        builder.Property(e => e.DocItemDocumentoPadreEsUrgente).HasColumnName("doc_itemDocumento_padre_esUrgente");
        builder.Property(e => e.DocItemDocumentoPadreHorasFestivas).HasColumnName("doc_itemDocumento_padre_horasFestivas");
        builder.Property(e => e.DocItemDocumentoPadreHorasGarantia).HasColumnName("doc_itemDocumento_padre_horasGarantia");
        builder.Property(e => e.DocItemDocumentoPadreHorasNocturnas).HasColumnName("doc_itemDocumento_padre_horasNocturnas");
        builder.Property(e => e.DocItemDocumentoPadreHorasOrdinales).HasColumnName("doc_itemDocumento_padre_horasOrdinales");
        builder.Property(e => e.DocItemDocumentoPadreIdBodega).HasColumnName("doc_itemDocumento_padre_id_bodega");
        builder.Property(e => e.DocItemDocumentoPadreIdCatalogo).HasColumnName("doc_itemDocumento_padre_id_catalogo");
        builder.Property(e => e.DocItemDocumentoPadreIdCentroCosto).HasColumnName("doc_itemDocumento_padre_id_centroCosto");
        builder.Property(e => e.DocItemDocumentoPadreIdDocumento).HasColumnName("doc_itemDocumento_padre_id_documento");
        builder.Property(e => e.DocItemDocumentoPadreIdIncoterm).HasColumnName("doc_itemDocumento_padre_id_incoterm");
        builder.Property(e => e.DocItemDocumentoPadreIdItemDocumento).HasColumnName("doc_itemDocumento_padre_id_itemDocumento");
        builder.Property(e => e.DocItemDocumentoPadreIdItemDocumentoSuperior).HasColumnName("doc_itemDocumento_padre_id_itemDocumento_superior");
        builder.Property(e => e.DocItemDocumentoPadreIdListaprecio).HasColumnName("doc_itemDocumento_padre_id_listaprecio");
        builder.Property(e => e.DocItemDocumentoPadreItemDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_padre_itemDocumento");
        builder.Property(e => e.DocItemDocumentoPadreItemDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_padre_itemDocumento_codigo");
        builder.Property(e => e.DocItemDocumentoPadreIvaEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_padre_ivaEjecutado");
        builder.Property(e => e.DocItemDocumentoPadreIvaPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_padre_ivaPlaneado");
        builder.Property(e => e.DocItemDocumentoPadreMargenPlaneado).HasColumnName("doc_itemDocumento_padre_margenPlaneado");
        builder.Property(e => e.DocItemDocumentoPadrePorcdescuento).HasColumnName("doc_itemDocumento_padre_porcdescuento");
        builder.Property(e => e.DocItemDocumentoPadrePorcdto).HasColumnName("doc_itemDocumento_padre_porcdto");
        builder.Property(e => e.DocItemDocumentoPadrePorcentajeCliente).HasColumnName("doc_itemDocumento_padre_porcentajeCliente");
        builder.Property(e => e.DocItemDocumentoPadrePorcentajeDistribuidor).HasColumnName("doc_itemDocumento_padre_porcentajeDistribuidor");
        builder.Property(e => e.DocItemDocumentoPadrePorcentajeFabricante).HasColumnName("doc_itemDocumento_padre_porcentajeFabricante");
        builder.Property(e => e.DocItemDocumentoPadrePorcentajeMargen).HasColumnName("doc_itemDocumento_padre_porcentajeMargen");
        builder.Property(e => e.DocItemDocumentoPadrePorciva).HasColumnName("doc_itemDocumento_padre_porciva");
        builder.Property(e => e.DocItemDocumentoPadreSubtotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_padre_subtotalEjecutado");
        builder.Property(e => e.DocItemDocumentoPadreSubtotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_padre_subtotalPlaneado");
        builder.Property(e => e.DocItemDocumentoPadreTotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_padre_totalEjecutado");
        builder.Property(e => e.DocItemDocumentoPadreTotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_padre_totalPlaneado");
        builder.Property(e => e.DocItemDocumentoPadreValorUnitarioEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_padre_valorUnitarioEjecutado");
        builder.Property(e => e.DocItemDocumentoPadreValorUnitarioPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_padre_valorUnitarioPlaneado");
        builder.Property(e => e.DocItemDocumentoPadreVencimientoGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_itemDocumento_padre_vencimientoGarantia_ff");
        builder.Property(e => e.DocItemDocumentoPadreVrbase).HasColumnName("doc_itemDocumento_padre_vrbase");
        builder.Property(e => e.DocItemDocumentoPadreVrenlista).HasColumnName("doc_itemDocumento_padre_vrenlista");
        builder.Property(e => e.DocItemDocumentoSuperiorAfectoInventario).HasColumnName("doc_itemDocumento_superior_afectoInventario");
        builder.Property(e => e.DocItemDocumentoSuperiorCantAuxiliar).HasColumnName("doc_itemDocumento_superior_cantAuxiliar");
        builder.Property(e => e.DocItemDocumentoSuperiorCantidadEjecutado).HasColumnName("doc_itemDocumento_superior_cantidadEjecutado");
        builder.Property(e => e.DocItemDocumentoSuperiorCantidadPlaneado).HasColumnName("doc_itemDocumento_superior_cantidadPlaneado");
        builder.Property(e => e.DocItemDocumentoSuperiorCostear).HasColumnName("doc_itemDocumento_superior_costear");
        builder.Property(e => e.DocItemDocumentoSuperiorCostoEjecutado).HasColumnName("doc_itemDocumento_superior_costoEjecutado");
        builder.Property(e => e.DocItemDocumentoSuperiorCostoPlaneado).HasColumnName("doc_itemDocumento_superior_costoPlaneado");
        builder.Property(e => e.DocItemDocumentoSuperiorDetalle)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_superior_detalle");
        builder.Property(e => e.DocItemDocumentoSuperiorDtoEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_superior_dtoEjecutado");
        builder.Property(e => e.DocItemDocumentoSuperiorDtoPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_superior_dtoPlaneado");
        builder.Property(e => e.DocItemDocumentoSuperiorEsUrgente).HasColumnName("doc_itemDocumento_superior_esUrgente");
        builder.Property(e => e.DocItemDocumentoSuperiorHorasFestivas).HasColumnName("doc_itemDocumento_superior_horasFestivas");
        builder.Property(e => e.DocItemDocumentoSuperiorHorasGarantia).HasColumnName("doc_itemDocumento_superior_horasGarantia");
        builder.Property(e => e.DocItemDocumentoSuperiorHorasNocturnas).HasColumnName("doc_itemDocumento_superior_horasNocturnas");
        builder.Property(e => e.DocItemDocumentoSuperiorHorasOrdinales).HasColumnName("doc_itemDocumento_superior_horasOrdinales");
        builder.Property(e => e.DocItemDocumentoSuperiorIdBodega).HasColumnName("doc_itemDocumento_superior_id_bodega");
        builder.Property(e => e.DocItemDocumentoSuperiorIdCatalogo).HasColumnName("doc_itemDocumento_superior_id_catalogo");
        builder.Property(e => e.DocItemDocumentoSuperiorIdCentroCosto).HasColumnName("doc_itemDocumento_superior_id_centroCosto");
        builder.Property(e => e.DocItemDocumentoSuperiorIdDocumento).HasColumnName("doc_itemDocumento_superior_id_documento");
        builder.Property(e => e.DocItemDocumentoSuperiorIdIncoterm).HasColumnName("doc_itemDocumento_superior_id_incoterm");
        builder.Property(e => e.DocItemDocumentoSuperiorIdItemDocumento).HasColumnName("doc_itemDocumento_superior_id_itemDocumento");
        builder.Property(e => e.DocItemDocumentoSuperiorIdItemDocumentoSuperior).HasColumnName("doc_itemDocumento_superior_id_itemDocumento_superior");
        builder.Property(e => e.DocItemDocumentoSuperiorIdListaprecio).HasColumnName("doc_itemDocumento_superior_id_listaprecio");
        builder.Property(e => e.DocItemDocumentoSuperiorItemDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_superior_itemDocumento");
        builder.Property(e => e.DocItemDocumentoSuperiorItemDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_superior_itemDocumento_codigo");
        builder.Property(e => e.DocItemDocumentoSuperiorIvaEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_superior_ivaEjecutado");
        builder.Property(e => e.DocItemDocumentoSuperiorIvaPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_superior_ivaPlaneado");
        builder.Property(e => e.DocItemDocumentoSuperiorMargenPlaneado).HasColumnName("doc_itemDocumento_superior_margenPlaneado");
        builder.Property(e => e.DocItemDocumentoSuperiorPorcdescuento).HasColumnName("doc_itemDocumento_superior_porcdescuento");
        builder.Property(e => e.DocItemDocumentoSuperiorPorcdto).HasColumnName("doc_itemDocumento_superior_porcdto");
        builder.Property(e => e.DocItemDocumentoSuperiorPorcentajeCliente).HasColumnName("doc_itemDocumento_superior_porcentajeCliente");
        builder.Property(e => e.DocItemDocumentoSuperiorPorcentajeDistribuidor).HasColumnName("doc_itemDocumento_superior_porcentajeDistribuidor");
        builder.Property(e => e.DocItemDocumentoSuperiorPorcentajeFabricante).HasColumnName("doc_itemDocumento_superior_porcentajeFabricante");
        builder.Property(e => e.DocItemDocumentoSuperiorPorcentajeMargen).HasColumnName("doc_itemDocumento_superior_porcentajeMargen");
        builder.Property(e => e.DocItemDocumentoSuperiorPorciva).HasColumnName("doc_itemDocumento_superior_porciva");
        builder.Property(e => e.DocItemDocumentoSuperiorSubtotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_superior_subtotalEjecutado");
        builder.Property(e => e.DocItemDocumentoSuperiorSubtotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_superior_subtotalPlaneado");
        builder.Property(e => e.DocItemDocumentoSuperiorTotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_superior_totalEjecutado");
        builder.Property(e => e.DocItemDocumentoSuperiorTotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_superior_totalPlaneado");
        builder.Property(e => e.DocItemDocumentoSuperiorValorUnitarioEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_superior_valorUnitarioEjecutado");
        builder.Property(e => e.DocItemDocumentoSuperiorValorUnitarioPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_superior_valorUnitarioPlaneado");
        builder.Property(e => e.DocItemDocumentoSuperiorVencimientoGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_itemDocumento_superior_vencimientoGarantia_ff");
        builder.Property(e => e.DocItemDocumentoSuperiorVrbase).HasColumnName("doc_itemDocumento_superior_vrbase");
        builder.Property(e => e.DocItemDocumentoSuperiorVrenlista).HasColumnName("doc_itemDocumento_superior_vrenlista");
        builder.Property(e => e.DtoEjecutado)
            .HasColumnType("money")
            .HasColumnName("dtoEjecutado");
        builder.Property(e => e.DtoPlaneado)
            .HasColumnType("money")
            .HasColumnName("dtoPlaneado");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsUrgente).HasColumnName("esUrgente");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenBodegaBodega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_bodega_bodega");
        builder.Property(e => e.GenBodegaBodegaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_bodega_bodega_codigo");
        builder.Property(e => e.GenBodegaIdSucursal).HasColumnName("gen_bodega_id_sucursal");
        builder.Property(e => e.GenBodegaSalidasEnRojo).HasColumnName("gen_bodega_salidasEnRojo");
        builder.Property(e => e.GenBodegaUsaLocalizacion).HasColumnName("gen_bodega_usaLocalizacion");
        builder.Property(e => e.HorasFestivas).HasColumnName("horasFestivas");
        builder.Property(e => e.HorasGarantia).HasColumnName("horasGarantia");
        builder.Property(e => e.HorasNocturnas).HasColumnName("horasNocturnas");
        builder.Property(e => e.HorasOrdinales).HasColumnName("horasOrdinales");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdBodega).HasColumnName("id_bodega");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdCentroCosto).HasColumnName("id_centroCosto");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdIncoterm).HasColumnName("id_incoterm");
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
        builder.Property(e => e.IdItemDocumentoSuperior).HasColumnName("id_itemDocumento_superior");
        builder.Property(e => e.IdListaprecio).HasColumnName("id_listaprecio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ItemDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("itemDocumento");
        builder.Property(e => e.ItemDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("itemDocumento_codigo");
        builder.Property(e => e.IvaEjecutado)
            .HasColumnType("money")
            .HasColumnName("ivaEjecutado");
        builder.Property(e => e.IvaPlaneado)
            .HasColumnType("money")
            .HasColumnName("ivaPlaneado");
        builder.Property(e => e.MargenPlaneado).HasColumnName("margenPlaneado");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Porcdescuento).HasColumnName("porcdescuento");
        builder.Property(e => e.Porcdto).HasColumnName("porcdto");
        builder.Property(e => e.PorcentajeCliente).HasColumnName("porcentajeCliente");
        builder.Property(e => e.PorcentajeDistribuidor).HasColumnName("porcentajeDistribuidor");
        builder.Property(e => e.PorcentajeFabricante).HasColumnName("porcentajeFabricante");
        builder.Property(e => e.PorcentajeMargen).HasColumnName("porcentajeMargen");
        builder.Property(e => e.Porciva).HasColumnName("porciva");
        builder.Property(e => e.SubtotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("subtotalEjecutado");
        builder.Property(e => e.SubtotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("subtotalPlaneado");
        builder.Property(e => e.TotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("totalEjecutado");
        builder.Property(e => e.TotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("totalPlaneado");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorUnitarioEjecutado)
            .HasColumnType("money")
            .HasColumnName("valorUnitarioEjecutado");
        builder.Property(e => e.ValorUnitarioPlaneado)
            .HasColumnType("money")
            .HasColumnName("valorUnitarioPlaneado");
        builder.Property(e => e.VencimientoGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("vencimientoGarantia_ff");
        builder.Property(e => e.Vrbase).HasColumnName("vrbase");
        builder.Property(e => e.Vrenlista).HasColumnName("vrenlista");
    }
}
