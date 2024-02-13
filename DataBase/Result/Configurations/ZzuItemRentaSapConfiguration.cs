using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ZzuItemRentaSapConfiguration : IEntityTypeConfiguration<ZzuItemRentaSap>
{
    public void Configure(EntityTypeBuilder<ZzuItemRentaSap> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_int_serialesAlquiler");

        builder.ToTable("zzu_itemRentaSap");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
        builder.Property(e => e.Codigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("codigo");
        builder.Property(e => e.Costo)
            .HasColumnType("money")
            .HasColumnName("costo");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("descripcion");
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
        builder.Property(e => e.IdAlquiler).HasColumnName("id_alquiler");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
