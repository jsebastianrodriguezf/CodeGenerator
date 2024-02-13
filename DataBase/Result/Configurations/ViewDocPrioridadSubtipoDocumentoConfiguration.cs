using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocPrioridadSubtipoDocumentoConfiguration : IEntityTypeConfiguration<ViewDocPrioridadSubtipoDocumento>
{
    public void Configure(EntityTypeBuilder<ViewDocPrioridadSubtipoDocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_prioridadSubtipoDocumento");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocPrioridadDocumentoOrden).HasColumnName("doc_prioridadDocumento_orden");
        builder.Property(e => e.DocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.DocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocSubtipoDocumentoCantidadAuxiliar).HasColumnName("doc_subtipoDocumento_cantidadAuxiliar");
        builder.Property(e => e.DocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocSubtipoDocumentoCerrarSol).HasColumnName("doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocSubtipoDocumentoConsecutivo).HasColumnName("doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocSubtipoDocumentoEjecutaDevolucion).HasColumnName("doc_subtipoDocumento_ejecutaDevolucion");
        builder.Property(e => e.DocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoMostrarPendienteDocumento).HasColumnName("doc_subtipoDocumento_mostrarPendienteDocumento");
        builder.Property(e => e.DocSubtipoDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_prefijo");
        builder.Property(e => e.DocSubtipoDocumentoProgramarPlaneadas).HasColumnName("doc_subtipoDocumento_programarPlaneadas");
        builder.Property(e => e.DocSubtipoDocumentoSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_subtipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_subtipoDocumento_codigo");
        builder.Property(e => e.DocSubtipoDocumentoTipoCobro).HasColumnName("doc_subtipoDocumento_tipoCobro");
        builder.Property(e => e.DocSubtipoDocumentoValUrgente).HasColumnName("doc_subtipoDocumento_valUrgente");
        builder.Property(e => e.DocSubtipoDocumentoVerCentroCosto).HasColumnName("doc_subtipoDocumento_verCentroCosto");
        builder.Property(e => e.DocSubtipoDocumentoVerIncoterm).HasColumnName("doc_subtipoDocumento_verIncoterm");
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
        builder.Property(e => e.IdPrioridadDocumento).HasColumnName("id_prioridadDocumento");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PrioridadSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("prioridadSubtipoDocumento");
        builder.Property(e => e.PrioridadSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("prioridadSubtipoDocumento_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
