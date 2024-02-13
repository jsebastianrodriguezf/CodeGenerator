using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VDatCotConfiguration : IEntityTypeConfiguration<VDatCot>
{
    public void Configure(EntityTypeBuilder<VDatCot> builder)
    {
        builder
            .HasNoKey()
            .ToView("v_datCot");

        builder.Property(e => e.Doc)
            .IsUnicode(false)
            .HasColumnName("doc");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdNetsuite)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasColumnName("idNetsuite");
    }
}
