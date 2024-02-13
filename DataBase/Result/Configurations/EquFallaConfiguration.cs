using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquFallaConfiguration : IEntityTypeConfiguration<EquFalla>
{
    public void Configure(EntityTypeBuilder<EquFalla> builder)
    {
        builder.ToTable("equ_falla");

        builder.HasIndex(e => e.Eid, "IX_equ_falla");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Falla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("falla");
        builder.Property(e => e.FallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("falla_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdFalla).HasColumnName("id_falla");
        builder.Property(e => e.IdTipoFalla).HasColumnName("id_tipoFalla");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Procedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("procedimiento");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdFallaNavigation).WithMany(p => p.InverseIdFallaNavigation)
            .HasForeignKey(d => d.IdFalla)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_falla_id_falla");

        builder.HasOne(d => d.IdTipoFallaNavigation).WithMany(p => p.EquFallas)
            .HasForeignKey(d => d.IdTipoFalla)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_falla_id_tipoFalla");
    }
}
