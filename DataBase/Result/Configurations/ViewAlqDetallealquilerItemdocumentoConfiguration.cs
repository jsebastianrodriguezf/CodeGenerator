using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewAlqDetallealquilerItemdocumentoConfiguration : IEntityTypeConfiguration<ViewAlqDetallealquilerItemdocumento>
{
    public void Configure(EntityTypeBuilder<ViewAlqDetallealquilerItemdocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_alq_detallealquiler_itemdocumento");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DetallealquilerItemdocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detallealquiler_itemdocumento");
        builder.Property(e => e.DocItemDocumentoAfectoInventario).HasColumnName("doc_itemDocumento_afectoInventario");
        builder.Property(e => e.DocItemDocumentoCantidadEjecutado).HasColumnName("doc_itemDocumento_cantidadEjecutado");
        builder.Property(e => e.DocItemDocumentoCantidadPlaneado).HasColumnName("doc_itemDocumento_cantidadPlaneado");
        builder.Property(e => e.DocItemDocumentoCostear).HasColumnName("doc_itemDocumento_costear");
        builder.Property(e => e.DocItemDocumentoCostoEjecutado).HasColumnName("doc_itemDocumento_costoEjecutado");
        builder.Property(e => e.DocItemDocumentoCostoPlaneado).HasColumnName("doc_itemDocumento_costoPlaneado");
        builder.Property(e => e.DocItemDocumentoDetalle)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_detalle");
        builder.Property(e => e.DocItemDocumentoDtoEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_dtoEjecutado");
        builder.Property(e => e.DocItemDocumentoDtoPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_dtoPlaneado");
        builder.Property(e => e.DocItemDocumentoEsUrgente).HasColumnName("doc_itemDocumento_esUrgente");
        builder.Property(e => e.DocItemDocumentoHorasFestivas).HasColumnName("doc_itemDocumento_horasFestivas");
        builder.Property(e => e.DocItemDocumentoHorasGarantia).HasColumnName("doc_itemDocumento_horasGarantia");
        builder.Property(e => e.DocItemDocumentoHorasNocturnas).HasColumnName("doc_itemDocumento_horasNocturnas");
        builder.Property(e => e.DocItemDocumentoHorasOrdinales).HasColumnName("doc_itemDocumento_horasOrdinales");
        builder.Property(e => e.DocItemDocumentoIdBodega).HasColumnName("doc_itemDocumento_id_bodega");
        builder.Property(e => e.DocItemDocumentoIdCatalogo).HasColumnName("doc_itemDocumento_id_catalogo");
        builder.Property(e => e.DocItemDocumentoIdCentroCosto).HasColumnName("doc_itemDocumento_id_centroCosto");
        builder.Property(e => e.DocItemDocumentoIdDocumento).HasColumnName("doc_itemDocumento_id_documento");
        builder.Property(e => e.DocItemDocumentoIdIncoterm).HasColumnName("doc_itemDocumento_id_incoterm");
        builder.Property(e => e.DocItemDocumentoIdItemDocumento).HasColumnName("doc_itemDocumento_id_itemDocumento");
        builder.Property(e => e.DocItemDocumentoIdItemDocumentoSuperior).HasColumnName("doc_itemDocumento_id_itemDocumento_superior");
        builder.Property(e => e.DocItemDocumentoIdListaprecio).HasColumnName("doc_itemDocumento_id_listaprecio");
        builder.Property(e => e.DocItemDocumentoItemDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_itemDocumento");
        builder.Property(e => e.DocItemDocumentoItemDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_itemDocumento_itemDocumento_codigo");
        builder.Property(e => e.DocItemDocumentoIvaEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_ivaEjecutado");
        builder.Property(e => e.DocItemDocumentoIvaPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_ivaPlaneado");
        builder.Property(e => e.DocItemDocumentoPorcdto).HasColumnName("doc_itemDocumento_porcdto");
        builder.Property(e => e.DocItemDocumentoPorcentajeCliente).HasColumnName("doc_itemDocumento_porcentajeCliente");
        builder.Property(e => e.DocItemDocumentoPorcentajeDistribuidor).HasColumnName("doc_itemDocumento_porcentajeDistribuidor");
        builder.Property(e => e.DocItemDocumentoPorcentajeFabricante).HasColumnName("doc_itemDocumento_porcentajeFabricante");
        builder.Property(e => e.DocItemDocumentoPorciva).HasColumnName("doc_itemDocumento_porciva");
        builder.Property(e => e.DocItemDocumentoSubtotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_subtotalEjecutado");
        builder.Property(e => e.DocItemDocumentoSubtotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_subtotalPlaneado");
        builder.Property(e => e.DocItemDocumentoTotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_totalEjecutado");
        builder.Property(e => e.DocItemDocumentoTotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_totalPlaneado");
        builder.Property(e => e.DocItemDocumentoValorUnitarioEjecutado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_valorUnitarioEjecutado");
        builder.Property(e => e.DocItemDocumentoValorUnitarioPlaneado)
            .HasColumnType("money")
            .HasColumnName("doc_itemDocumento_valorUnitarioPlaneado");
        builder.Property(e => e.DocItemDocumentoVencimientoGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_itemDocumento_vencimientoGarantia_ff");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquDetalleAlquilerCantidadAlquilada).HasColumnName("equ_detalleAlquiler_cantidadAlquilada");
        builder.Property(e => e.EquDetalleAlquilerCantidadSolicitada).HasColumnName("equ_detalleAlquiler_cantidadSolicitada");
        builder.Property(e => e.EquDetalleAlquilerDetalleAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_detalleAlquiler_detalleAlquiler");
        builder.Property(e => e.EquDetalleAlquilerDetalleAlquilerCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_detalleAlquiler_detalleAlquiler_codigo");
        builder.Property(e => e.EquDetalleAlquilerEstadoalquiler).HasColumnName("equ_detalleAlquiler_estadoalquiler");
        builder.Property(e => e.EquDetalleAlquilerFechaDespachoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_detalleAlquiler_fechaDespacho_ff");
        builder.Property(e => e.EquDetalleAlquilerFechaDevolucionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_detalleAlquiler_fechaDevolucion_ff");
        builder.Property(e => e.EquDetalleAlquilerFechaInicioFacturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_detalleAlquiler_fechaInicioFactura_fh");
        builder.Property(e => e.EquDetalleAlquilerFechaUltimaFacturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_detalleAlquiler_fechaUltimaFactura_fh");
        builder.Property(e => e.EquDetalleAlquilerIdCatalogo).HasColumnName("equ_detalleAlquiler_id_catalogo");
        builder.Property(e => e.EquDetalleAlquilerIdDocumentoAlquiler).HasColumnName("equ_detalleAlquiler_id_documento.alquiler");
        builder.Property(e => e.EquDetalleAlquilerIdEquipo).HasColumnName("equ_detalleAlquiler_id_equipo");
        builder.Property(e => e.EquDetalleAlquilerIdSucursal).HasColumnName("equ_detalleAlquiler_id_sucursal");
        builder.Property(e => e.EquDetalleAlquilerIdTercero).HasColumnName("equ_detalleAlquiler_id_tercero");
        builder.Property(e => e.EquDetalleAlquilerValorHora)
            .HasColumnType("money")
            .HasColumnName("equ_detalleAlquiler_valorHora");
        builder.Property(e => e.EquDetalleAlquilerValorHoraStandBy)
            .HasColumnType("money")
            .HasColumnName("equ_detalleAlquiler_ValorHoraStandBy");
        builder.Property(e => e.EquDetalleAlquilerValorMes).HasColumnName("equ_detalleAlquiler_valorMes");
        builder.Property(e => e.EquDetalleAlquilerValorMulta)
            .HasColumnType("money")
            .HasColumnName("equ_detalleAlquiler_valorMulta");
        builder.Property(e => e.EquDetalleAlquilerValorPeriodo)
            .HasColumnType("money")
            .HasColumnName("equ_detalleAlquiler_valorPeriodo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdDetallealquiler).HasColumnName("id_detallealquiler");
        builder.Property(e => e.IdItemdocumento).HasColumnName("id_itemdocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
