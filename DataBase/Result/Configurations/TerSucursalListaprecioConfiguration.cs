using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TerSucursalListaprecioConfiguration : IEntityTypeConfiguration<TerSucursalListaprecio>
{
    public void Configure(EntityTypeBuilder<TerSucursalListaprecio> builder)
    {
        builder.ToTable("ter_sucursal_listaprecio");

        builder.HasIndex(e => e.Eid, "IX_ter_sucursal_listaprecio");

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
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.SucursalListaprecio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sucursal_listaprecio");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdListaprecioNavigation).WithMany(p => p.TerSucursalListaprecios)
            .HasForeignKey(d => d.IdListaprecio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_sucursal_listaprecio_id_listaprecio");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TerSucursalListaprecios)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_sucursal_listaprecio_id_sucursal");
    }
}
