using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VRepuestosalquilableConfiguration : IEntityTypeConfiguration<VRepuestosalquilable>
{
    public void Configure(EntityTypeBuilder<VRepuestosalquilable> builder)
    {
        builder
            .HasNoKey()
            .ToView("v_repuestosalquilables");

        builder.Property(e => e.Id).HasColumnName("id");
    }
}
