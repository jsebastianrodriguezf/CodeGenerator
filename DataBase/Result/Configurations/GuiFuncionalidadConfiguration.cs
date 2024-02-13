using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GuiFuncionalidadConfiguration : IEntityTypeConfiguration<GuiFuncionalidad>
{
    public void Configure(EntityTypeBuilder<GuiFuncionalidad> builder)
    {
        builder.ToTable("gui_funcionalidad");

        builder.HasIndex(e => e.Eid, "IX_gui_funcionalidad");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsMenu).HasColumnName("esMenu");
        builder.Property(e => e.EsMvc)
            .HasDefaultValue(false)
            .HasColumnName("esMvc");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
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
        builder.Property(e => e.IdAplicacion).HasColumnName("id_aplicacion");
        builder.Property(e => e.IdFuncionalidad).HasColumnName("id_funcionalidad");
        builder.Property(e => e.IdTipoFuncionalidad).HasColumnName("id_tipoFuncionalidad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
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
            .HasDefaultValue("")
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
            .HasDefaultValue("")
            .HasColumnName("urlFormulario");
        builder.Property(e => e.UrlImagen)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("urlImagen");

        builder.HasOne(d => d.IdAplicacionNavigation).WithMany(p => p.GuiFuncionalidads)
            .HasForeignKey(d => d.IdAplicacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__gui_funci__id_ap__56639BD0");

        builder.HasOne(d => d.IdFuncionalidadNavigation).WithMany(p => p.InverseIdFuncionalidadNavigation)
            .HasForeignKey(d => d.IdFuncionalidad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gui_funcionalidad_id_funcionalidad");

        builder.HasOne(d => d.IdTipoFuncionalidadNavigation).WithMany(p => p.GuiFuncionalidads)
            .HasForeignKey(d => d.IdTipoFuncionalidad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gui_funcionalidad_id_tipoFuncionalidad");
    }
}
