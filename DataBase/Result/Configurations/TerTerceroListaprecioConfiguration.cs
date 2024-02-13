using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TerTerceroListaprecioConfiguration : IEntityTypeConfiguration<TerTerceroListaprecio>
{
    public void Configure(EntityTypeBuilder<TerTerceroListaprecio> builder)
    {
        builder.ToTable("ter_tercero_listaprecio");

        builder.HasIndex(e => e.Eid, "IX_ter_tercero_listaprecio");

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
        builder.Property(e => e.IdListaprecio).HasColumnName("id_listaprecio");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.TerceroListaprecio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tercero_listaprecio");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdListaprecioNavigation).WithMany(p => p.TerTerceroListaprecios)
            .HasForeignKey(d => d.IdListaprecio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_tercero_listaprecio_id_listaprecio");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.TerTerceroListaprecios)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_tercero_listaprecio_id_tercero");
    }
}
