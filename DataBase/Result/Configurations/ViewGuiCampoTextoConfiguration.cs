using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGuiCampoTextoConfiguration : IEntityTypeConfiguration<ViewGuiCampoTexto>
{
    public void Configure(EntityTypeBuilder<ViewGuiCampoTexto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gui_campoTexto");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CampoTexto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("campoTexto");
        builder.Property(e => e.CampoTextoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("campoTexto_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsHtml).HasColumnName("esHTML");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GuiFuncionalidadEsMenu).HasColumnName("gui_funcionalidad_esMenu");
        builder.Property(e => e.GuiFuncionalidadFuncionalidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_funcionalidad");
        builder.Property(e => e.GuiFuncionalidadFuncionalidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_funcionalidad_codigo");
        builder.Property(e => e.GuiFuncionalidadIdFuncionalidad).HasColumnName("gui_funcionalidad_id_funcionalidad");
        builder.Property(e => e.GuiFuncionalidadIdTipoFuncionalidad).HasColumnName("gui_funcionalidad_id_tipoFuncionalidad");
        builder.Property(e => e.GuiFuncionalidadNombreComando)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_nombreComando");
        builder.Property(e => e.GuiFuncionalidadNombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_nombreControl");
        builder.Property(e => e.GuiFuncionalidadOrden).HasColumnName("gui_funcionalidad_orden");
        builder.Property(e => e.GuiFuncionalidadTargetUrl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_targetUrl");
        builder.Property(e => e.GuiFuncionalidadToolTip)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_toolTip");
        builder.Property(e => e.GuiFuncionalidadUrl)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_url");
        builder.Property(e => e.GuiFuncionalidadUrlFormulario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_urlFormulario");
        builder.Property(e => e.GuiFuncionalidadUrlImagen)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_urlImagen");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdFuncionalidad).HasColumnName("id_funcionalidad");
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
