using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegCargoEnvioCorreoConfiguration : IEntityTypeConfiguration<SegCargoEnvioCorreo>
{
    public void Configure(EntityTypeBuilder<SegCargoEnvioCorreo> builder)
    {
        builder.ToTable("seg_cargo_envioCorreo");

        builder.HasIndex(e => e.Eid, "IX_seg_cargo_envioCorreo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CargoEnvioCorreo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cargo_envioCorreo");
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
        builder.Property(e => e.IdCargo).HasColumnName("id_cargo");
        builder.Property(e => e.IdEnvioCorreo).HasColumnName("id_envioCorreo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCargoNavigation).WithMany(p => p.SegCargoEnvioCorreos)
            .HasForeignKey(d => d.IdCargo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_cargo_envioCorreo_id_cargo");

        builder.HasOne(d => d.IdEnvioCorreoNavigation).WithMany(p => p.SegCargoEnvioCorreos)
            .HasForeignKey(d => d.IdEnvioCorreo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_cargo_envioCorreo_id_envioCorreo");
    }
}
