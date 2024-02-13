using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGuiTextoDefectoConfiguration : IEntityTypeConfiguration<ViewGuiTextoDefecto>
{
    public void Configure(EntityTypeBuilder<ViewGuiTextoDefecto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gui_textoDefecto");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.GuiCampoTextoCampoTexto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_campoTexto_campoTexto");
        builder.Property(e => e.GuiCampoTextoCampoTextoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_campoTexto_campoTexto_codigo");
        builder.Property(e => e.GuiCampoTextoEsHtml).HasColumnName("gui_campoTexto_esHTML");
        builder.Property(e => e.GuiCampoTextoIdFuncionalidad).HasColumnName("gui_campoTexto_id_funcionalidad");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCampoTexto).HasColumnName("id_campoTexto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Texto)
            .HasMaxLength(8000)
            .IsUnicode(false);
        builder.Property(e => e.TextoDefecto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("textoDefecto");
        builder.Property(e => e.TextoDefectoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("textoDefecto_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
