using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquPagoAlquilerConfiguration : IEntityTypeConfiguration<ViewEquPagoAlquiler>
{
    public void Configure(EntityTypeBuilder<ViewEquPagoAlquiler> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_pagoAlquiler");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaEsperadaPagoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaEsperadaPago_ff");
        builder.Property(e => e.FechaFacturaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_factura_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdDocumentoAlquiler).HasColumnName("id_documento.alquiler");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.NumeroFactura)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("numeroFactura");
        builder.Property(e => e.PagoAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pagoAlquiler");
        builder.Property(e => e.PagoAlquilerCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pagoAlquiler_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorFacturado)
            .HasColumnType("money")
            .HasColumnName("valorFacturado");
        builder.Property(e => e.ValorPorCobrar)
            .HasColumnType("money")
            .HasColumnName("valorPorCobrar");
    }
}
