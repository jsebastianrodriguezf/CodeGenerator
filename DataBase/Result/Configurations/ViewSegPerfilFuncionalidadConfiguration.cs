using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSegPerfilFuncionalidadConfiguration : IEntityTypeConfiguration<ViewSegPerfilFuncionalidad>
{
    public void Configure(EntityTypeBuilder<ViewSegPerfilFuncionalidad> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_seg_perfil_funcionalidad");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.ControlPadre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("controlPadre");
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
        builder.Property(e => e.GuiFuncionalidadEsMenu).HasColumnName("gui_funcionalidad_esMenu");
        builder.Property(e => e.GuiFuncionalidadEsMvc).HasColumnName("gui_funcionalidad_esMvc");
        builder.Property(e => e.GuiFuncionalidadFuncionalidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_funcionalidad");
        builder.Property(e => e.GuiFuncionalidadFuncionalidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_funcionalidad_funcionalidad_codigo");
        builder.Property(e => e.GuiFuncionalidadIdAplicacion).HasColumnName("gui_funcionalidad_id_aplicacion");
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
        builder.Property(e => e.IdPerfil).HasColumnName("id_perfil");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PerfilFuncionalidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("perfil_funcionalidad");
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
