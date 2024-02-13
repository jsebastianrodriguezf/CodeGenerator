using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DisObraEquipoConfiguration : IEntityTypeConfiguration<DisObraEquipo>
{
    public void Configure(EntityTypeBuilder<DisObraEquipo> builder)
    {
        builder.ToTable("dis_obra_equipo");

        builder.HasIndex(e => e.Eid, "IX_dis_obra_equipo");

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
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdObra).HasColumnName("id_obra");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ObraEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("obra_equipo");
        builder.Property(e => e.PromedioEsperado).HasColumnName("promedioEsperado");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.DisObraEquipos)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_obra_equipo_id_equipo");

        builder.HasOne(d => d.IdObraNavigation).WithMany(p => p.DisObraEquipos)
            .HasForeignKey(d => d.IdObra)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_obra_equipo_id_obra");
    }
}
