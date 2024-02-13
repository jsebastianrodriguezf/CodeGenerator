using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquAnalisisFallaConfiguration : IEntityTypeConfiguration<EquAnalisisFalla>
{
    public void Configure(EntityTypeBuilder<EquAnalisisFalla> builder)
    {
        builder.ToTable("equ_analisisFalla");

        builder.HasIndex(e => e.Eid, "IX_equ_analisisFalla");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AnalisisFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("analisisFalla");
        builder.Property(e => e.AnalisisFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("analisisFalla_codigo");
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
        builder.Property(e => e.IdCatalogoEquipo).HasColumnName("id_catalogo.equipo");
        builder.Property(e => e.IdFalla).HasColumnName("id_falla");
        builder.Property(e => e.IdFallaCausa).HasColumnName("id_falla_causa");
        builder.Property(e => e.IdFallaEfecto).HasColumnName("id_falla_efecto");
        builder.Property(e => e.IdFallaSolucion).HasColumnName("id_falla_solucion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoEquipoNavigation).WithMany(p => p.EquAnalisisFallas)
            .HasForeignKey(d => d.IdCatalogoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__equ_anali__id_ca__5A73587F");

        builder.HasOne(d => d.IdFallaNavigation).WithMany(p => p.EquAnalisisFallaIdFallaNavigations)
            .HasForeignKey(d => d.IdFalla)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__equ_anali__id_fa__5C5BA0F1");

        builder.HasOne(d => d.IdFallaCausaNavigation).WithMany(p => p.EquAnalisisFallaIdFallaCausaNavigations)
            .HasForeignKey(d => d.IdFallaCausa)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__equ_anali__id_fa__5E43E963");

        builder.HasOne(d => d.IdFallaEfectoNavigation).WithMany(p => p.EquAnalisisFallaIdFallaEfectoNavigations)
            .HasForeignKey(d => d.IdFallaEfecto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__equ_anali__id_fa__602C31D5");

        builder.HasOne(d => d.IdFallaSolucionNavigation).WithMany(p => p.EquAnalisisFallaIdFallaSolucionNavigations)
            .HasForeignKey(d => d.IdFallaSolucion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__equ_anali__id_fa__33248134");
    }
}
