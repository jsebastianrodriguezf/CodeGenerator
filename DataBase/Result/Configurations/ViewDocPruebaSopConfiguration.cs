using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocPruebaSopConfiguration : IEntityTypeConfiguration<ViewDocPruebaSop>
{
    public void Configure(EntityTypeBuilder<ViewDocPruebaSop> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_prueba_sop");

        builder.Property(e => e.Cuerpo)
            .HasMaxLength(47)
            .IsUnicode(false)
            .HasColumnName("CUERPO");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");
    }
}
