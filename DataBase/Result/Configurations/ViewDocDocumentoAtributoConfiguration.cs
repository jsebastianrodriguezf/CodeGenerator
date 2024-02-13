using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoAtributoConfiguration : IEntityTypeConfiguration<ViewDocDocumentoAtributo>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoAtributo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documentoAtributo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatAtributoAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_atributo");
        builder.Property(e => e.CatAtributoAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_atributo_codigo");
        builder.Property(e => e.CatAtributoEsObligatorio).HasColumnName("cat_atributo_esObligatorio");
        builder.Property(e => e.CatAtributoEsVariable).HasColumnName("cat_atributo_esVariable");
        builder.Property(e => e.CatAtributoIdSeccionAtributo).HasColumnName("cat_atributo_id_seccionAtributo");
        builder.Property(e => e.CatAtributoIdTipoAtributo).HasColumnName("cat_atributo_id_tipoAtributo");
        builder.Property(e => e.CatAtributoIdUnidad).HasColumnName("cat_atributo_id_unidad");
        builder.Property(e => e.CatAtributoNombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_nombreControl");
        builder.Property(e => e.CatAtributoResaltado).HasColumnName("cat_atributo_resaltado");
        builder.Property(e => e.CatAtributoValorMaximo).HasColumnName("cat_atributo_ValorMaximo");
        builder.Property(e => e.CatAtributoValorMinimo).HasColumnName("cat_atributo_valorMinimo");
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
        builder.Property(e => e.DocumentoAtributo)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("documentoAtributo");
        builder.Property(e => e.DocumentoAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("documentoAtributo_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquOpcionAtributoIdAtributo).HasColumnName("equ_opcionAtributo_id_atributo");
        builder.Property(e => e.EquOpcionAtributoOpcionAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_opcionAtributo_opcionAtributo");
        builder.Property(e => e.EquOpcionAtributoOpcionAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_opcionAtributo_opcionAtributo_codigo");
        builder.Property(e => e.EquOpcionAtributoOrden).HasColumnName("equ_opcionAtributo_orden");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdOpcionAtributo).HasColumnName("id_opcionAtributo");
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
