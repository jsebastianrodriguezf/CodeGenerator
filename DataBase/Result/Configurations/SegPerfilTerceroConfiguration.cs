using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegPerfilTerceroConfiguration : IEntityTypeConfiguration<SegPerfilTercero>
{
    public void Configure(EntityTypeBuilder<SegPerfilTercero> builder)
    {
        builder.ToTable("seg_perfil_tercero");

        builder.HasIndex(e => e.Eid, "IX_seg_perfil_tercero");

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
        builder.Property(e => e.IdPerfil).HasColumnName("id_perfil");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PerfilTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("perfil_tercero");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.SegPerfilTerceros)
            .HasForeignKey(d => d.IdPerfil)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_seg_perfil_tercero_id_perfil");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.SegPerfilTerceros)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_seg_perfil_tercero_id_tercero");
    }
}
