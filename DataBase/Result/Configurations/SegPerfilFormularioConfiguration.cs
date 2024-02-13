using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegPerfilFormularioConfiguration : IEntityTypeConfiguration<SegPerfilFormulario>
{
    public void Configure(EntityTypeBuilder<SegPerfilFormulario> builder)
    {
        builder.ToTable("seg_perfil_formulario");

        builder.HasIndex(e => e.Eid, "IX_seg_perfil_formulario");

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
        builder.Property(e => e.IdFormulario).HasColumnName("id_formulario");
        builder.Property(e => e.IdPerfil).HasColumnName("id_perfil");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PerfilFormulario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("perfil_formulario");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdFormularioNavigation).WithMany(p => p.SegPerfilFormularios)
            .HasForeignKey(d => d.IdFormulario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_perfil_formulario_id_formulario");

        builder.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.SegPerfilFormularios)
            .HasForeignKey(d => d.IdPerfil)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_perfil_formulario_id_perfil");
    }
}
