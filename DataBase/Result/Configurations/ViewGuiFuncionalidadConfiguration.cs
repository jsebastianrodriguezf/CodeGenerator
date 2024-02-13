using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGuiFuncionalidadConfiguration : IEntityTypeConfiguration<ViewGuiFuncionalidad>
{
    public void Configure(EntityTypeBuilder<ViewGuiFuncionalidad> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gui_funcionalidad");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsMenu).HasColumnName("esMenu");
        builder.Property(e => e.EsMvc).HasColumnName("esMvc");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Funcionalidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("funcionalidad");
        builder.Property(e => e.FuncionalidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("funcionalidad_codigo");
        builder.Property(e => e.GuiAplicacionAplicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_aplicacion_aplicacion");
        builder.Property(e => e.GuiAplicacionAplicacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_aplicacion_aplicacion_codigo");
        builder.Property(e => e.GuiFuncionalidadPadreEsMenu).HasColumnName("gui_funcionalidad_padre_esMenu");
        builder.Property(e => e.GuiFuncionalidadPadreEsMvc).HasColumnName("gui_funcionalidad_padre_esMvc");
        builder.Property(e => e.GuiFuncionalidadPadreFuncionalidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_padre_funcionalidad");
        builder.Property(e => e.GuiFuncionalidadPadreFuncionalidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_padre_funcionalidad_codigo");
        builder.Property(e => e.GuiFuncionalidadPadreIdAplicacion).HasColumnName("gui_funcionalidad_padre_id_aplicacion");
        builder.Property(e => e.GuiFuncionalidadPadreIdFuncionalidad).HasColumnName("gui_funcionalidad_padre_id_funcionalidad");
        builder.Property(e => e.GuiFuncionalidadPadreIdTipoFuncionalidad).HasColumnName("gui_funcionalidad_padre_id_tipoFuncionalidad");
        builder.Property(e => e.GuiFuncionalidadPadreNombreComando)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_padre_nombreComando");
        builder.Property(e => e.GuiFuncionalidadPadreNombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_padre_nombreControl");
        builder.Property(e => e.GuiFuncionalidadPadreOrden).HasColumnName("gui_funcionalidad_padre_orden");
        builder.Property(e => e.GuiFuncionalidadPadreTargetUrl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_padre_targetUrl");
        builder.Property(e => e.GuiFuncionalidadPadreToolTip)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_padre_toolTip");
        builder.Property(e => e.GuiFuncionalidadPadreUrl)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_padre_url");
        builder.Property(e => e.GuiFuncionalidadPadreUrlFormulario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_padre_urlFormulario");
        builder.Property(e => e.GuiFuncionalidadPadreUrlImagen)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_padre_urlImagen");
        builder.Property(e => e.GuiTipoFuncionalidadTipoFuncionalidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_tipoFuncionalidad_tipoFuncionalidad");
        builder.Property(e => e.GuiTipoFuncionalidadTipoFuncionalidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_tipoFuncionalidad_tipoFuncionalidad_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdAplicacion).HasColumnName("id_aplicacion");
        builder.Property(e => e.IdFuncionalidad).HasColumnName("id_funcionalidad");
        builder.Property(e => e.IdTipoFuncionalidad).HasColumnName("id_tipoFuncionalidad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.NombreComando)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("nombreComando");
        builder.Property(e => e.NombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("nombreControl");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.TargetUrl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("targetUrl");
        builder.Property(e => e.ToolTip)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("toolTip");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Url)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("url");
        builder.Property(e => e.UrlFormulario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("urlFormulario");
        builder.Property(e => e.UrlImagen)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("urlImagen");
    }
}
