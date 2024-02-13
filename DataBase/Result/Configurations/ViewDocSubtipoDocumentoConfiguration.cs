using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocSubtipoDocumentoConfiguration : IEntityTypeConfiguration<ViewDocSubtipoDocumento>
{
    public void Configure(EntityTypeBuilder<ViewDocSubtipoDocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_subtipoDocumento");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.ArchivosAdjuntosApp).HasColumnName("archivosAdjuntosApp");
        builder.Property(e => e.BloquearDespacho).HasColumnName("bloquearDespacho");
        builder.Property(e => e.CantidadAuxiliar).HasColumnName("cantidadAuxiliar");
        builder.Property(e => e.CargarSolicitante).HasColumnName("cargarSolicitante");
        builder.Property(e => e.CerrarSol).HasColumnName("cerrarSol");
        builder.Property(e => e.Consecutivo).HasColumnName("consecutivo");
        builder.Property(e => e.DocTipoDocumentoEsSalida).HasColumnName("doc_tipoDocumento_esSalida");
        builder.Property(e => e.DocTipoDocumentoEsUrgente).HasColumnName("doc_tipoDocumento_esUrgente");
        builder.Property(e => e.DocTipoDocumentoMostrarBodega).HasColumnName("doc_tipoDocumento_mostrarBodega");
        builder.Property(e => e.DocTipoDocumentoMostrarCentroCosto).HasColumnName("doc_tipoDocumento_mostrarCentroCosto");
        builder.Property(e => e.DocTipoDocumentoMostrarIncoterm).HasColumnName("doc_tipoDocumento_mostrarIncoterm");
        builder.Property(e => e.DocTipoDocumentoPuedeSerMayor).HasColumnName("doc_tipoDocumento_puedeSerMayor");
        builder.Property(e => e.DocTipoDocumentoPuedeSerMenor).HasColumnName("doc_tipoDocumento_puedeSerMenor");
        builder.Property(e => e.DocTipoDocumentoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_tipoDocumento_tipoDocumento");
        builder.Property(e => e.DocTipoDocumentoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_tipoDocumento_tipoDocumento_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EjecutaDevolucion).HasColumnName("ejecutaDevolucion");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MostrarPendienteDocumento).HasColumnName("mostrarPendienteDocumento");
        builder.Property(e => e.MostrarValoresEjecutados).HasColumnName("mostrarValoresEjecutados");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Prefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("prefijo");
        builder.Property(e => e.ProgramarPlaneadas).HasColumnName("programarPlaneadas");
        builder.Property(e => e.SubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("subtipoDocumento");
        builder.Property(e => e.SubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("subtipoDocumento_codigo");
        builder.Property(e => e.TipoCobro).HasColumnName("tipoCobro");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValUrgente).HasColumnName("valUrgente");
        builder.Property(e => e.VerCentroCosto).HasColumnName("verCentroCosto");
        builder.Property(e => e.VerIncoterm).HasColumnName("verIncoterm");
    }
}
