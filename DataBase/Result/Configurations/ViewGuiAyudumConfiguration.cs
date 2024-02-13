using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGuiAyudumConfiguration : IEntityTypeConfiguration<ViewGuiAyudum>
{
    public void Configure(EntityTypeBuilder<ViewGuiAyudum> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gui_ayuda");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Ayuda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ayuda");
        builder.Property(e => e.AyudaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ayuda_codigo");
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
        builder.Property(e => e.GuiAyudaPadreAyuda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_ayuda_padre_ayuda");
        builder.Property(e => e.GuiAyudaPadreAyudaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_ayuda_padre_ayuda_codigo");
        builder.Property(e => e.GuiAyudaPadreIdAyuda).HasColumnName("gui_ayuda_padre_id_ayuda");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdAyuda).HasColumnName("id_ayuda");
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
