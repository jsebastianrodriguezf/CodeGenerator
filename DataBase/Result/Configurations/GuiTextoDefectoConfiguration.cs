using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GuiTextoDefectoConfiguration : IEntityTypeConfiguration<GuiTextoDefecto>
{
    public void Configure(EntityTypeBuilder<GuiTextoDefecto> builder)
    {
        builder.ToTable("gui_textoDefecto");

        builder.HasIndex(e => e.Eid, "IX_gui_textoDefecto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdCampoTexto).HasColumnName("id_campoTexto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Texto)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("");
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

        builder.HasOne(d => d.IdCampoTextoNavigation).WithMany(p => p.GuiTextoDefectos)
            .HasForeignKey(d => d.IdCampoTexto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gui_textoDefecto_id_campoTexto");
    }
}
