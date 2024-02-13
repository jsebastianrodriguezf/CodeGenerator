using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSegPerfilSubtipoDocumentoConfiguration : IEntityTypeConfiguration<ViewSegPerfilSubtipoDocumento>
{
    public void Configure(EntityTypeBuilder<ViewSegPerfilSubtipoDocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_seg_perfil_subtipoDocumento");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DocSubtipoDocumentoBloquearDespacho).HasColumnName("doc_subtipoDocumento_bloquearDespacho");
        builder.Property(e => e.DocSubtipoDocumentoCargarSolicitante).HasColumnName("doc_subtipoDocumento_cargarSolicitante");
        builder.Property(e => e.DocSubtipoDocumentoConsecutivo).HasColumnName("doc_subtipoDocumento_consecutivo");
        builder.Property(e => e.DocSubtipoDocumentoIdTipoDocumento).HasColumnName("doc_subtipoDocumento_id_tipoDocumento");
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
        builder.Property(e => e.IdPerfil).HasColumnName("id_perfil");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PerfilSubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("perfil_subtipoDocumento");
        builder.Property(e => e.SegPerfilDescripcion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_perfil_descripcion");
        builder.Property(e => e.SegPerfilMostrarBotones).HasColumnName("seg_perfil_mostrarBotones");
        builder.Property(e => e.SegPerfilParaCliente).HasColumnName("seg_perfil_paraCliente");
        builder.Property(e => e.SegPerfilParaProveedor).HasColumnName("seg_perfil_paraProveedor");
        builder.Property(e => e.SegPerfilPerfil)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_perfil_perfil");
        builder.Property(e => e.SegPerfilPerfilCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_perfil_perfil_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
