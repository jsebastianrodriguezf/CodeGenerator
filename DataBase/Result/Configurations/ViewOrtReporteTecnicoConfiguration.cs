using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewOrtReporteTecnicoConfiguration : IEntityTypeConfiguration<ViewOrtReporteTecnico>
{
    public void Configure(EntityTypeBuilder<ViewOrtReporteTecnico> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_ort_reporteTecnico");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Compromisos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("compromisos");
        builder.Property(e => e.Diagnostico)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("diagnostico");
        builder.Property(e => e.DocDocumentoGastoConcepto)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.gasto_concepto");
        builder.Property(e => e.DocDocumentoGastoConsignado).HasColumnName("doc_documento.gasto_consignado");
        builder.Property(e => e.DocDocumentoGastoCosto).HasColumnName("doc_documento_gasto_costo");
        builder.Property(e => e.DocDocumentoGastoCostoPlaneado).HasColumnName("doc_documento_gasto_costoPlaneado");
        builder.Property(e => e.DocDocumentoGastoDescuento).HasColumnName("doc_documento_gasto_descuento");
        builder.Property(e => e.DocDocumentoGastoDescuentoPlaneado).HasColumnName("doc_documento_gasto_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoGastoDias).HasColumnName("doc_documento.gasto_dias");
        builder.Property(e => e.DocDocumentoGastoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_documento_codigo");
        builder.Property(e => e.DocDocumentoGastoDocumentoGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.gasto_documento.gasto");
        builder.Property(e => e.DocDocumentoGastoDocumentoNumero).HasColumnName("doc_documento_gasto_documento_numero");
        builder.Property(e => e.DocDocumentoGastoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoGastoFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.gasto_fecha_ff");
        builder.Property(e => e.DocDocumentoGastoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fecha_fh");
        builder.Property(e => e.DocDocumentoGastoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoGastoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_gasto_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoGastoIdDocumento).HasColumnName("doc_documento_gasto_id_documento");
        builder.Property(e => e.DocDocumentoGastoIdEstadoTipoDocumento).HasColumnName("doc_documento_gasto_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoGastoIdMoneda).HasColumnName("doc_documento_gasto_id_moneda");
        builder.Property(e => e.DocDocumentoGastoIdMotivoestado).HasColumnName("doc_documento_gasto_id_motivoestado");
        builder.Property(e => e.DocDocumentoGastoIdPrioridadDocumento).HasColumnName("doc_documento_gasto_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoGastoIdSubtipoDocumento).HasColumnName("doc_documento_gasto_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoGastoIdTerceroCliente).HasColumnName("doc_documento_gasto_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoGastoIdTerceroProveedor).HasColumnName("doc_documento_gasto_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoGastoIdUsuarioAsignado).HasColumnName("doc_documento_gasto_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoGastoIdUsuarioEnUso).HasColumnName("doc_documento_gasto_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoGastoIdUsuarioSolicitante).HasColumnName("doc_documento.gasto_id_usuario_solicitante");
        builder.Property(e => e.DocDocumentoGastoIva).HasColumnName("doc_documento_gasto_iva");
        builder.Property(e => e.DocDocumentoGastoIvaPlaneado).HasColumnName("doc_documento_gasto_ivaPlaneado");
        builder.Property(e => e.DocDocumentoGastoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_gasto_prefijo");
        builder.Property(e => e.DocDocumentoGastoRentabilidad).HasColumnName("doc_documento_gasto_rentabilidad");
        builder.Property(e => e.DocDocumentoGastoSubtotal).HasColumnName("doc_documento_gasto_subtotal");
        builder.Property(e => e.DocDocumentoGastoSubtotalPlaneado).HasColumnName("doc_documento_gasto_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoGastoTotal).HasColumnName("doc_documento_gasto_total");
        builder.Property(e => e.DocDocumentoGastoTotalPlaneado).HasColumnName("doc_documento_gasto_totalPlaneado");
        builder.Property(e => e.DocDocumentoGastoTrm).HasColumnName("doc_documento_gasto_trm");
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
        builder.Property(e => e.GasGastoConcepto)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("gas_gasto_concepto");
        builder.Property(e => e.GasGastoConsignado).HasColumnName("gas_gasto_consignado");
        builder.Property(e => e.GasGastoDias).HasColumnName("gas_gasto_dias");
        builder.Property(e => e.GasGastoFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("gas_gasto_fecha_ff");
        builder.Property(e => e.GasGastoGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gas_gasto_gasto");
        builder.Property(e => e.GasGastoGastoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gas_gasto_gasto_codigo");
        builder.Property(e => e.GasGastoIdEstadoTipoDocumento).HasColumnName("gas_gasto_id_estadoTipoDocumento");
        builder.Property(e => e.GasGastoIdTipoGasto).HasColumnName("gas_gasto_id_tipoGasto");
        builder.Property(e => e.GasGastoIdUsuarioAprobo).HasColumnName("gas_gasto_id_usuario_aprobo");
        builder.Property(e => e.GasGastoIdUsuarioSolicitante).HasColumnName("gas_gasto_id_usuario_solicitante");
        builder.Property(e => e.GasGastoNumero).HasColumnName("gas_gasto_numero");
        builder.Property(e => e.GasGastoValor).HasColumnName("gas_gasto_valor");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCanalAtencion).HasColumnName("id_canalAtencion");
        builder.Property(e => e.IdDocumentoGasto).HasColumnName("id_documento.gasto");
        builder.Property(e => e.IdGasto).HasColumnName("id_gasto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Numero)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("numero");
        builder.Property(e => e.OrtCanalAtencionCanalAtencion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_canalAtencion_canalAtencion");
        builder.Property(e => e.OrtCanalAtencionCanalAtencionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_canalAtencion_canalAtencion_codigo");
        builder.Property(e => e.Recomendaciones)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("recomendaciones");
        builder.Property(e => e.ReporteTecnico)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("reporteTecnico");
        builder.Property(e => e.ReporteTecnicoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("reporteTecnico_codigo");
        builder.Property(e => e.Trabajos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("trabajos");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
