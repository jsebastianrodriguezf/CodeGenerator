using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewOrtReporteTecnicoOtConfiguration : IEntityTypeConfiguration<ViewOrtReporteTecnicoOt>
{
    public void Configure(EntityTypeBuilder<ViewOrtReporteTecnicoOt> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_ort_reporteTecnico_ot");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocDocumentoOtCargo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_cargo");
        builder.Property(e => e.DocDocumentoOtCompromisos)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_compromisos");
        builder.Property(e => e.DocDocumentoOtContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_contacto");
        builder.Property(e => e.DocDocumentoOtCosto).HasColumnName("doc_documento_ot_costo");
        builder.Property(e => e.DocDocumentoOtCostoPlaneado).HasColumnName("doc_documento_ot_costoPlaneado");
        builder.Property(e => e.DocDocumentoOtDescuento).HasColumnName("doc_documento_ot_descuento");
        builder.Property(e => e.DocDocumentoOtDescuentoPlaneado).HasColumnName("doc_documento_ot_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoOtDiagnosticoInicial)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_diagnosticoInicial");
        builder.Property(e => e.DocDocumentoOtDireccionUbicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_direccionUbicacion");
        builder.Property(e => e.DocDocumentoOtDistribuyeCentros).HasColumnName("doc_documento.ot_distribuyeCentros");
        builder.Property(e => e.DocDocumentoOtDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_documento_codigo");
        builder.Property(e => e.DocDocumentoOtDocumentoNumero).HasColumnName("doc_documento_ot_documento_numero");
        builder.Property(e => e.DocDocumentoOtDocumentoOt)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_documento.ot");
        builder.Property(e => e.DocDocumentoOtDuracionEstimada).HasColumnName("doc_documento.ot_duracionEstimada");
        builder.Property(e => e.DocDocumentoOtEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_email");
        builder.Property(e => e.DocDocumentoOtEnTaller).HasColumnName("doc_documento.ot_enTaller");
        builder.Property(e => e.DocDocumentoOtFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_fax");
        builder.Property(e => e.DocDocumentoOtFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoOtFechaCompromisoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.ot_fechaCompromiso_fh");
        builder.Property(e => e.DocDocumentoOtFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fecha_fh");
        builder.Property(e => e.DocDocumentoOtFechaGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.ot_fechaGarantia_ff");
        builder.Property(e => e.DocDocumentoOtFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoOtFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoOtIdContrato).HasColumnName("doc_documento.ot_id_contrato");
        builder.Property(e => e.DocDocumentoOtIdDepartamentoSolicitud).HasColumnName("doc_documento.ot_id_departamentoSolicitud");
        builder.Property(e => e.DocDocumentoOtIdDocumento).HasColumnName("doc_documento_ot_id_documento");
        builder.Property(e => e.DocDocumentoOtIdEquipo).HasColumnName("doc_documento.ot_id_equipo");
        builder.Property(e => e.DocDocumentoOtIdEstadoTipoDocumento).HasColumnName("doc_documento_ot_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOtIdMoneda).HasColumnName("doc_documento_ot_id_moneda");
        builder.Property(e => e.DocDocumentoOtIdMotivoCancelacion).HasColumnName("doc_documento.ot_id_motivoCancelacion");
        builder.Property(e => e.DocDocumentoOtIdMotivoestado).HasColumnName("doc_documento_ot_id_motivoestado");
        builder.Property(e => e.DocDocumentoOtIdPrioridadDocumento).HasColumnName("doc_documento_ot_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoOtIdSistema).HasColumnName("doc_documento.ot_id_sistema");
        builder.Property(e => e.DocDocumentoOtIdSubtipoDocumento).HasColumnName("doc_documento_ot_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoOtIdSucursal).HasColumnName("doc_documento.ot_id_sucursal");
        builder.Property(e => e.DocDocumentoOtIdTerceroCliente).HasColumnName("doc_documento_ot_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoOtIdTerceroProveedor).HasColumnName("doc_documento_ot_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoOtIdTipoServicio).HasColumnName("doc_documento.ot_id_tipoServicio");
        builder.Property(e => e.DocDocumentoOtIdUsuarioCoordinador).HasColumnName("doc_documento.ot_id_usuario_coordinador");
        builder.Property(e => e.DocDocumentoOtIdZona).HasColumnName("doc_documento.ot_id_zona");
        builder.Property(e => e.DocDocumentoOtIva).HasColumnName("doc_documento_ot_iva");
        builder.Property(e => e.DocDocumentoOtIvaPlaneado).HasColumnName("doc_documento_ot_ivaPlaneado");
        builder.Property(e => e.DocDocumentoOtMotivoServicio)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_motivoServicio");
        builder.Property(e => e.DocDocumentoOtPorcentajeCliente).HasColumnName("doc_documento.ot_porcentajeCliente");
        builder.Property(e => e.DocDocumentoOtPorcentajeDistribuidor).HasColumnName("doc_documento.ot_porcentajeDistribuidor");
        builder.Property(e => e.DocDocumentoOtPorcentajeFabricante).HasColumnName("doc_documento.ot_porcentajeFabricante");
        builder.Property(e => e.DocDocumentoOtPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_prefijo");
        builder.Property(e => e.DocDocumentoOtReclamacionFabrica)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_reclamacionFabrica");
        builder.Property(e => e.DocDocumentoOtRecomendaciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_recomendaciones");
        builder.Property(e => e.DocDocumentoOtRentabilidad).HasColumnName("doc_documento_ot_rentabilidad");
        builder.Property(e => e.DocDocumentoOtSegunTempario).HasColumnName("doc_documento.ot_segunTempario");
        builder.Property(e => e.DocDocumentoOtSubtotal).HasColumnName("doc_documento_ot_subtotal");
        builder.Property(e => e.DocDocumentoOtSubtotalPlaneado).HasColumnName("doc_documento_ot_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoOtTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_telefono");
        builder.Property(e => e.DocDocumentoOtTotal).HasColumnName("doc_documento_ot_total");
        builder.Property(e => e.DocDocumentoOtTotalPlaneado).HasColumnName("doc_documento_ot_totalPlaneado");
        builder.Property(e => e.DocDocumentoOtTrabajos)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_trabajos");
        builder.Property(e => e.DocDocumentoOtTrm).HasColumnName("doc_documento_ot_trm");
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
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
        builder.Property(e => e.IdReporteTecnico).HasColumnName("id_reporteTecnico");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(2000)
            .IsUnicode(false)
            .HasColumnName("observaciones");
        builder.Property(e => e.OrtReporteTecnicoCompromisos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_compromisos");
        builder.Property(e => e.OrtReporteTecnicoIdGasto).HasColumnName("ort_reporteTecnico_id_gasto");
        builder.Property(e => e.OrtReporteTecnicoNumero)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_numero");
        builder.Property(e => e.OrtReporteTecnicoRecomendaciones)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_recomendaciones");
        builder.Property(e => e.OrtReporteTecnicoReporteTecnico)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_reporteTecnico");
        builder.Property(e => e.OrtReporteTecnicoReporteTecnicoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_reporteTecnico_codigo");
        builder.Property(e => e.OrtReporteTecnicoTrabajos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_trabajos");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
