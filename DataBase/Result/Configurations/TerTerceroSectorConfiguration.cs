using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TerTerceroSectorConfiguration : IEntityTypeConfiguration<TerTerceroSector>
{
    public void Configure(EntityTypeBuilder<TerTerceroSector> builder)
    {
        builder.ToTable("ter_tercero_sector");

        builder.HasIndex(e => e.Eid, "IX_ter_tercero_sector");

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
        builder.Property(e => e.IdSector).HasColumnName("id_sector");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.TerceroSector)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tercero_sector");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdSectorNavigation).WithMany(p => p.TerTerceroSectors)
            .HasForeignKey(d => d.IdSector)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_tercero_sector_id_sector");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.TerTerceroSectors)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_tercero_sector_id_tercero");
    }
}
