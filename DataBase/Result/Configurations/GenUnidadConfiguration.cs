using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenUnidadConfiguration : IEntityTypeConfiguration<GenUnidad>
{
    public void Configure(EntityTypeBuilder<GenUnidad> builder)
    {
        builder.ToTable("gen_unidad");

        builder.HasIndex(e => e.Eid, "IX_gen_unidad");

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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Unidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("unidad");
        builder.Property(e => e.UnidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("unidad_codigo");
    }
}
