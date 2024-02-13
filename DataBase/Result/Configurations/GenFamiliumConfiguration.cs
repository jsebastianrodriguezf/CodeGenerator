using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenFamiliumConfiguration : IEntityTypeConfiguration<GenFamilium>
{
    public void Configure(EntityTypeBuilder<GenFamilium> builder)
    {
        builder.ToTable("gen_familia");

        builder.HasIndex(e => e.Eid, "IX_gen_familia");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Familia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("familia");
        builder.Property(e => e.FamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("familia_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdFamilia).HasColumnName("id_familia");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdFamiliaNavigation).WithMany(p => p.InverseIdFamiliaNavigation)
            .HasForeignKey(d => d.IdFamilia)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_familia_id_familia");
    }
}
