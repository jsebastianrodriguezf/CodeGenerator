using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GuiDetalleBloqueHomeConfiguration : IEntityTypeConfiguration<GuiDetalleBloqueHome>
{
    public void Configure(EntityTypeBuilder<GuiDetalleBloqueHome> builder)
    {
        builder.ToTable("gui_detalleBloqueHome");

        builder.HasIndex(e => e.Eid, "IX_gui_detalleBloqueHome");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DetalleBloqueHome)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleBloqueHome");
        builder.Property(e => e.DetalleBloqueHomeCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleBloqueHome_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstrategiaFecha)
            .HasDefaultValue(0)
            .HasColumnName("estrategiaFecha");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdBloqueHome).HasColumnName("id_bloqueHome");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ItemsTab)
            .HasDefaultValue(0)
            .HasColumnName("itemsTab");
        builder.Property(e => e.Orden)
            .HasDefaultValue(0)
            .HasColumnName("orden");
        builder.Property(e => e.OrdenResultados).HasColumnName("ordenResultados");
        builder.Property(e => e.PosicionTab)
            .HasDefaultValue(0)
            .HasColumnName("posicionTab");
        builder.Property(e => e.TipoBloqueHome)
            .HasDefaultValue(0)
            .HasColumnName("tipoBloqueHome");
        builder.Property(e => e.TipoCampo)
            .HasDefaultValue(0)
            .HasColumnName("tipoCampo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdBloqueHomeNavigation).WithMany(p => p.GuiDetalleBloqueHomes)
            .HasForeignKey(d => d.IdBloqueHome)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gui_detalleBloqueHome_id_bloqueHome");
    }
}
