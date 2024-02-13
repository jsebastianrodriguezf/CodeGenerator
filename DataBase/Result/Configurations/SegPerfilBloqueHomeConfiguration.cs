using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegPerfilBloqueHomeConfiguration : IEntityTypeConfiguration<SegPerfilBloqueHome>
{
    public void Configure(EntityTypeBuilder<SegPerfilBloqueHome> builder)
    {
        builder.ToTable("seg_perfil_bloqueHome");

        builder.HasIndex(e => e.Eid, "IX_seg_perfil_bloqueHome");

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
        builder.Property(e => e.IdBloqueHome).HasColumnName("id_bloqueHome");
        builder.Property(e => e.IdPerfil).HasColumnName("id_perfil");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PerfilBloqueHome)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("perfil_bloqueHome");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdBloqueHomeNavigation).WithMany(p => p.SegPerfilBloqueHomes)
            .HasForeignKey(d => d.IdBloqueHome)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_perfil_bloqueHome_id_bloqueHome");

        builder.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.SegPerfilBloqueHomes)
            .HasForeignKey(d => d.IdPerfil)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_perfil_bloqueHome_id_perfil");
    }
}
