using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TerContactoSucursalConfiguration : IEntityTypeConfiguration<TerContactoSucursal>
{
    public void Configure(EntityTypeBuilder<TerContactoSucursal> builder)
    {
        builder.ToTable("ter_contacto_sucursal");

        builder.HasIndex(e => e.Eid, "IX_ter_contacto_sucursal");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ContactoSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contacto_sucursal");
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
        builder.Property(e => e.IdContacto).HasColumnName("id_contacto");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdContactoNavigation).WithMany(p => p.TerContactoSucursals)
            .HasForeignKey(d => d.IdContacto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_contacto_sucursal_id_contacto");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.TerContactoSucursals)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_contacto_sucursal_id_sucursal");
    }
}
