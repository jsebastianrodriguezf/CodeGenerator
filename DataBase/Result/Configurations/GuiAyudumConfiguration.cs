using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GuiAyudumConfiguration : IEntityTypeConfiguration<GuiAyudum>
{
    public void Configure(EntityTypeBuilder<GuiAyudum> builder)
    {
        builder.ToTable("gui_ayuda");

        builder.HasIndex(e => e.Eid, "IX_gui_ayuda");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
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
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdAyuda).HasColumnName("id_ayuda");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdAyudaNavigation).WithMany(p => p.InverseIdAyudaNavigation)
            .HasForeignKey(d => d.IdAyuda)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gui_ayuda_id_ayuda");
    }
}
