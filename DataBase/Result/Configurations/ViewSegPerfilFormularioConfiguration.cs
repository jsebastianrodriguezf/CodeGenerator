using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSegPerfilFormularioConfiguration : IEntityTypeConfiguration<ViewSegPerfilFormulario>
{
    public void Configure(EntityTypeBuilder<ViewSegPerfilFormulario> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_seg_perfil_formulario");

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
        builder.Property(e => e.GenFormularioDuplicar).HasColumnName("gen_formulario_duplicar");
        builder.Property(e => e.GenFormularioEliminarIntermedias).HasColumnName("gen_formulario_eliminarIntermedias");
        builder.Property(e => e.GenFormularioFormulario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_formulario_formulario");
        builder.Property(e => e.GenFormularioFormularioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_formulario_formulario_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdFormulario).HasColumnName("id_formulario");
        builder.Property(e => e.IdPerfil).HasColumnName("id_perfil");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PerfilFormulario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("perfil_formulario");
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
