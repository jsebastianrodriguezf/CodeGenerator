using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoOtProgramadumConfiguration : IEntityTypeConfiguration<ViewDocDocumentoOtProgramadum>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoOtProgramadum> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documentoOtProgramada");

        builder.Property(e => e.Id).HasColumnName("id");
    }
}
