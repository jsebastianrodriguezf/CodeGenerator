using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoProyectoEjecutoreConfiguration : IEntityTypeConfiguration<ViewDocDocumentoProyectoEjecutore>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoProyectoEjecutore> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documento_proyecto_ejecutores");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocDocumentoProyectoCosto).HasColumnName("doc_documento_proyecto_costo");
        builder.Property(e => e.DocDocumentoProyectoCostoPlaneado).HasColumnName("doc_documento_proyecto_costoPlaneado");
        builder.Property(e => e.DocDocumentoProyectoDescripcion)
            .HasMaxLength(2000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.proyecto_descripcion");
        builder.Property(e => e.DocDocumentoProyectoDescuento).HasColumnName("doc_documento_proyecto_descuento");
        builder.Property(e => e.DocDocumentoProyectoDescuentoPlaneado).HasColumnName("doc_documento_proyecto_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoProyectoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_documento_codigo");
        builder.Property(e => e.DocDocumentoProyectoDocumentoNumero).HasColumnName("doc_documento_proyecto_documento_numero");
        builder.Property(e => e.DocDocumentoProyectoDocumentoProyecto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.proyecto_documento.proyecto");
        builder.Property(e => e.DocDocumentoProyectoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoProyectoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_fecha_fh");
        builder.Property(e => e.DocDocumentoProyectoFechaFinEstimada)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.proyecto_fechaFinEstimada");
        builder.Property(e => e.DocDocumentoProyectoFechaInicioEstimada)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.proyecto_fechaInicioEstimada");
        builder.Property(e => e.DocDocumentoProyectoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoProyectoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_proyecto_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoProyectoIdDocumento).HasColumnName("doc_documento_proyecto_id_documento");
        builder.Property(e => e.DocDocumentoProyectoIdEstadoTipoDocumento).HasColumnName("doc_documento_proyecto_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoIdMoneda).HasColumnName("doc_documento_proyecto_id_moneda");
        builder.Property(e => e.DocDocumentoProyectoIdMotivoestado).HasColumnName("doc_documento_proyecto_id_motivoestado");
        builder.Property(e => e.DocDocumentoProyectoIdPrioridadDocumento).HasColumnName("doc_documento_proyecto_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoProyectoIdSubtipoDocumento).HasColumnName("doc_documento_proyecto_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoProyectoIdTerceroCliente).HasColumnName("doc_documento_proyecto_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoProyectoIdTerceroProveedor).HasColumnName("doc_documento_proyecto_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoProyectoIdUsuarioAsignado).HasColumnName("doc_documento_proyecto_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoProyectoIdUsuarioEnUso).HasColumnName("doc_documento_proyecto_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoProyectoIva).HasColumnName("doc_documento_proyecto_iva");
        builder.Property(e => e.DocDocumentoProyectoIvaPlaneado).HasColumnName("doc_documento_proyecto_ivaPlaneado");
        builder.Property(e => e.DocDocumentoProyectoNombre)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_documento.proyecto_nombre");
        builder.Property(e => e.DocDocumentoProyectoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_proyecto_prefijo");
        builder.Property(e => e.DocDocumentoProyectoPresupuesto)
            .HasColumnType("money")
            .HasColumnName("doc_documento.proyecto_presupuesto");
        builder.Property(e => e.DocDocumentoProyectoRentabilidad).HasColumnName("doc_documento_proyecto_rentabilidad");
        builder.Property(e => e.DocDocumentoProyectoSubtotal).HasColumnName("doc_documento_proyecto_subtotal");
        builder.Property(e => e.DocDocumentoProyectoSubtotalPlaneado).HasColumnName("doc_documento_proyecto_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoProyectoTotal).HasColumnName("doc_documento_proyecto_total");
        builder.Property(e => e.DocDocumentoProyectoTotalPlaneado).HasColumnName("doc_documento_proyecto_totalPlaneado");
        builder.Property(e => e.DocDocumentoProyectoTrm).HasColumnName("doc_documento_proyecto_trm");
        builder.Property(e => e.DocumentoProyectoEjecutores)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.proyecto_ejecutores");
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
        builder.Property(e => e.IdDocumentoProyecto).HasColumnName("id_documento.proyecto");
        builder.Property(e => e.IdEjecutores).HasColumnName("id_ejecutores");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ProEjecutoresCosto).HasColumnName("pro_ejecutores_costo");
        builder.Property(e => e.ProEjecutoresEjecutores)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pro_ejecutores_ejecutores");
        builder.Property(e => e.ProEjecutoresEjecutoresCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_ejecutores_ejecutores_codigo");
        builder.Property(e => e.ProEjecutoresIdHorarioEjecutores).HasColumnName("pro_ejecutores_id_horarioEjecutores");
        builder.Property(e => e.ProEjecutoresIdHorarioTrabajo).HasColumnName("pro_ejecutores_id_horarioTrabajo");
        builder.Property(e => e.ProEjecutoresIdUsuario).HasColumnName("pro_ejecutores_id_usuario");
        builder.Property(e => e.ProEjecutoresUnidadTiempo)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasColumnName("pro_ejecutores_unidadTiempo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
