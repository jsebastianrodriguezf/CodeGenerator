using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TablaConfiguration : IEntityTypeConfiguration<Tabla>
{
    public void Configure(EntityTypeBuilder<Tabla> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_tablas");

        builder.ToTable("_tablas");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Tabla1)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("tabla");
    }
}
