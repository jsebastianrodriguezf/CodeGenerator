using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoCotizacionCondicionConfiguration : IEntityTypeConfiguration<ViewDocDocumentoCotizacionCondicion>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoCotizacionCondicion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_cotizacion_condicion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocCondicionCondicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_condicion_condicion");
        builder.Property(e => e.DocCondicionCondicionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_condicion_condicion_codigo");
        builder.Property(e => e.DocCondicionTextoLibre).HasColumnName("doc_condicion_textoLibre");
        builder.Property(e => e.DocDocumentoCotizacionCargo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.cotizacion_cargo");
        builder.Property(e => e.DocDocumentoCotizacionCondiciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.cotizacion_condiciones");
        builder.Property(e => e.DocDocumentoCotizacionContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.cotizacion_contacto");
        builder.Property(e => e.DocDocumentoCotizacionCosto).HasColumnName("doc_documento_cotizacion_costo");
        builder.Property(e => e.DocDocumentoCotizacionCostoPlaneado).HasColumnName("doc_documento_cotizacion_costoPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionDescuento).HasColumnName("doc_documento_cotizacion_descuento");
        builder.Property(e => e.DocDocumentoCotizacionDescuentoPlaneado).HasColumnName("doc_documento_cotizacion_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_documento_codigo");
        builder.Property(e => e.DocDocumentoCotizacionDocumentoCotizacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.cotizacion_documento.cotizacion");
        builder.Property(e => e.DocDocumentoCotizacionDocumentoNumero).HasColumnName("doc_documento_cotizacion_documento_numero");
        builder.Property(e => e.DocDocumentoCotizacionEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.cotizacion_email");
        builder.Property(e => e.DocDocumentoCotizacionEncabezado)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.cotizacion_encabezado");
        builder.Property(e => e.DocDocumentoCotizacionEsAiu).HasColumnName("doc_documento.cotizacion_esAIU");
        builder.Property(e => e.DocDocumentoCotizacionFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoCotizacionFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_fecha_fh");
        builder.Property(e => e.DocDocumentoCotizacionFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoCotizacionFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_cotizacion_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoCotizacionIdDocumento).HasColumnName("doc_documento_cotizacion_id_documento");
        builder.Property(e => e.DocDocumentoCotizacionIdEquipo).HasColumnName("doc_documento.cotizacion_id_equipo");
        builder.Property(e => e.DocDocumentoCotizacionIdEstadoTipoDocumento).HasColumnName("doc_documento_cotizacion_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionIdMoneda).HasColumnName("doc_documento_cotizacion_id_moneda");
        builder.Property(e => e.DocDocumentoCotizacionIdMotivoestado).HasColumnName("doc_documento_cotizacion_id_motivoestado");
        builder.Property(e => e.DocDocumentoCotizacionIdPrioridadDocumento).HasColumnName("doc_documento_cotizacion_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoCotizacionIdSubtipoDocumento).HasColumnName("doc_documento_cotizacion_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoCotizacionIdSucursal).HasColumnName("doc_documento.cotizacion_id_sucursal");
        builder.Property(e => e.DocDocumentoCotizacionIdTerceroCliente).HasColumnName("doc_documento_cotizacion_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoCotizacionIdTerceroProveedor).HasColumnName("doc_documento_cotizacion_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoCotizacionIdUsuarioAsesor).HasColumnName("doc_documento.cotizacion_id_usuario_asesor");
        builder.Property(e => e.DocDocumentoCotizacionIdUsuarioAsignado).HasColumnName("doc_documento_cotizacion_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoCotizacionIdUsuarioEnUso).HasColumnName("doc_documento_cotizacion_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoCotizacionIva).HasColumnName("doc_documento_cotizacion_iva");
        builder.Property(e => e.DocDocumentoCotizacionIvaPlaneado).HasColumnName("doc_documento_cotizacion_ivaPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.cotizacion_notas");
        builder.Property(e => e.DocDocumentoCotizacionPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_cotizacion_prefijo");
        builder.Property(e => e.DocDocumentoCotizacionProcentajeA).HasColumnName("doc_documento.cotizacion_procentajeA");
        builder.Property(e => e.DocDocumentoCotizacionProcentajeI).HasColumnName("doc_documento.cotizacion_procentajeI");
        builder.Property(e => e.DocDocumentoCotizacionProcentajeU).HasColumnName("doc_documento.cotizacion_procentajeU");
        builder.Property(e => e.DocDocumentoCotizacionRentabilidad).HasColumnName("doc_documento_cotizacion_rentabilidad");
        builder.Property(e => e.DocDocumentoCotizacionSubtotal).HasColumnName("doc_documento_cotizacion_subtotal");
        builder.Property(e => e.DocDocumentoCotizacionSubtotalPlaneado).HasColumnName("doc_documento_cotizacion_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionTotal).HasColumnName("doc_documento_cotizacion_total");
        builder.Property(e => e.DocDocumentoCotizacionTotalPlaneado).HasColumnName("doc_documento_cotizacion_totalPlaneado");
        builder.Property(e => e.DocDocumentoCotizacionTrm).HasColumnName("doc_documento_cotizacion_trm");
        builder.Property(e => e.DocDocumentoCotizacionValidez).HasColumnName("doc_documento.cotizacion_validez");
        builder.Property(e => e.DocDocumentoCotizacionValorA).HasColumnName("doc_documento.cotizacion_valorA");
        builder.Property(e => e.DocDocumentoCotizacionValorI).HasColumnName("doc_documento.cotizacion_valorI");
        builder.Property(e => e.DocDocumentoCotizacionValorU).HasColumnName("doc_documento.cotizacion_valorU");
        builder.Property(e => e.DocDocumentoCotizacionVersion).HasColumnName("doc_documento.cotizacion_version");
        builder.Property(e => e.DocOpcionCondicionIdCondicion).HasColumnName("doc_opcionCondicion_id_condicion");
        builder.Property(e => e.DocOpcionCondicionOpcionCondicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_opcionCondicion_opcionCondicion");
        builder.Property(e => e.DocOpcionCondicionOpcionCondicionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_opcionCondicion_opcionCondicion_codigo");
        builder.Property(e => e.DocumentoCotizacionCondicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.cotizacion_condicion");
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
        builder.Property(e => e.IdCondicion).HasColumnName("id_condicion");
        builder.Property(e => e.IdDocumentoCotizacion).HasColumnName("id_documento.cotizacion");
        builder.Property(e => e.IdOpcionCondicion).HasColumnName("id_opcionCondicion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Imprimir).HasColumnName("imprimir");
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
