using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GuiCampoTextoConfiguration : IEntityTypeConfiguration<GuiCampoTexto>
{
    public void Configure(EntityTypeBuilder<GuiCampoTexto> builder)
    {
        builder.ToTable("gui_campoTexto");

        builder.HasIndex(e => e.Eid, "IX_gui_campoTexto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
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
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdFuncionalidad).HasColumnName("id_funcionalidad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdFuncionalidadNavigation).WithMany(p => p.GuiCampoTextos)
            .HasForeignKey(d => d.IdFuncionalidad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gui_campoTexto_id_funcionalidad");
    }
}
