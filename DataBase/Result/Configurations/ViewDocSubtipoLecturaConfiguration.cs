using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocSubtipoLecturaConfiguration : IEntityTypeConfiguration<ViewDocSubtipoLectura>
{
    public void Configure(EntityTypeBuilder<ViewDocSubtipoLectura> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_subtipoLectura");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocSubtipoDocumentoCerrarSol).HasColumnName("doc_subtipoDocumento_cerrarSol");
        builder.Property(e => e.DocSubtipoDocumentoConsecutivo).HasColumnName("doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocSubtipoDocumentoEjecutaDevolucion).HasColumnName("doc_subtipoDocumento_ejecutaDevolucion");
        builder.Property(e => e.DocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_subtipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoOrigenBloquearDespacho).HasColumnName("doc_subtipoDocumento_origen_bloquearDespacho");
        builder.Property(e => e.DocSubtipoDocumentoOrigenCargarSolicitante).HasColumnName("doc_subtipoDocumento_origen_cargarSolicitante");
        builder.Property(e => e.DocSubtipoDocumentoOrigenCerrarSol).HasColumnName("doc_subtipoDocumento_origen_cerrarSol");
        builder.Property(e => e.DocSubtipoDocumentoOrigenConsecutivo).HasColumnName("doc_subtipoDocumento_origen_consecutivo");
        builder.Property(e => e.DocSubtipoDocumentoOrigenEjecutaDevolucion).HasColumnName("doc_subtipoDocumento_origen_ejecutaDevolucion");
        builder.Property(e => e.DocSubtipoDocumentoOrigenIdTipoDocumento).HasColumnName("doc_subtipoDocumento_origen_id_tipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoOrigenPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_origen_prefijo");
        builder.Property(e => e.DocSubtipoDocumentoOrigenProgramarPlaneadas).HasColumnName("doc_subtipoDocumento_origen_programarPlaneadas");
        builder.Property(e => e.DocSubtipoDocumentoOrigenSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_origen_subtipoDocumento");
        builder.Property(e => e.DocSubtipoDocumentoOrigenSubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_subtipoDocumento_origen_subtipoDocumento_codigo");
        builder.Property(e => e.DocSubtipoDocumentoOrigenValUrgente).HasColumnName("doc_subtipoDocumento_origen_valUrgente");
        builder.Property(e => e.DocSubtipoDocumentoOrigenVerCentroCosto).HasColumnName("doc_subtipoDocumento_origen_verCentroCosto");
        builder.Property(e => e.DocSubtipoDocumentoOrigenVerIncoterm).HasColumnName("doc_subtipoDocumento_origen_verIncoterm");
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
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdSubtipoDocumentoOrigen).HasColumnName("id_subtipoDocumento_origen");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.SubtipoLectura)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("subtipoLectura");
        builder.Property(e => e.SubtipoLecturaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("subtipoLectura_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
