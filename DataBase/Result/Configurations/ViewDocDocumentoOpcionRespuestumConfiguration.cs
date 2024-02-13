using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoOpcionRespuestumConfiguration : IEntityTypeConfiguration<ViewDocDocumentoOpcionRespuestum>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoOpcionRespuestum> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_opcionRespuesta");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.DocOpcionRespuestaActiva).HasColumnName("doc_opcionRespuesta_activa");
        builder.Property(e => e.DocOpcionRespuestaIdPregunta).HasColumnName("doc_opcionRespuesta_id_pregunta");
        builder.Property(e => e.DocOpcionRespuestaOpcionRespuesta)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_opcionRespuesta_opcionRespuesta");
        builder.Property(e => e.DocOpcionRespuestaOpcionRespuestaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_opcionRespuesta_opcionRespuesta_codigo");
        builder.Property(e => e.DocOpcionRespuestaOrden).HasColumnName("doc_opcionRespuesta_orden");
        builder.Property(e => e.DocOpcionRespuestaValor).HasColumnName("doc_opcionRespuesta_valor");
        builder.Property(e => e.DocPreguntaActiva).HasColumnName("doc_pregunta_activa");
        builder.Property(e => e.DocPreguntaIdEvaluacion).HasColumnName("doc_pregunta_id_evaluacion");
        builder.Property(e => e.DocPreguntaOrden).HasColumnName("doc_pregunta_orden");
        builder.Property(e => e.DocPreguntaPregunta)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_pregunta_pregunta");
        builder.Property(e => e.DocPreguntaPreguntaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_pregunta_pregunta_codigo");
        builder.Property(e => e.DocPreguntaValor).HasColumnName("doc_pregunta_valor");
        builder.Property(e => e.DocumentoOpcionRespuesta)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento_opcionRespuesta");
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
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdOpcionRespuesta).HasColumnName("id_opcionRespuesta");
        builder.Property(e => e.IdPregunta).HasColumnName("id_pregunta");
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
