using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VDocumentoSucursalConfiguration : IEntityTypeConfiguration<VDocumentoSucursal>
{
    public void Configure(EntityTypeBuilder<VDocumentoSucursal> builder)
    {
        builder
            .HasNoKey()
            .ToView("V_documentoSucursal");

        builder.Property(e => e.CodigoRecursiva)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("codigoRecursiva");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
    }
}
