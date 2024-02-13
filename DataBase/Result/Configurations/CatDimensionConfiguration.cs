using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatDimensionConfiguration : IEntityTypeConfiguration<CatDimension>
{
    public void Configure(EntityTypeBuilder<CatDimension> builder)
    {
        builder.ToTable("cat_dimension");

        builder.HasIndex(e => e.Eid, "IX_cat_dimension");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AplicaEnX).HasColumnName("aplicaEnX");
        builder.Property(e => e.AplicaEnY).HasColumnName("aplicaEnY");
        builder.Property(e => e.AplicaEnZ).HasColumnName("aplicaEnZ");
        builder.Property(e => e.Dimension)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("dimension");
        builder.Property(e => e.DimensionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dimension_codigo");
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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
