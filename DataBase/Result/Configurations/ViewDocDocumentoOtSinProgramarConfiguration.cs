using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoOtSinProgramarConfiguration : IEntityTypeConfiguration<ViewDocDocumentoOtSinProgramar>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoOtSinProgramar> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documentoOtSinProgramar");

        builder.Property(e => e.Id).HasColumnName("id");
    }
}
