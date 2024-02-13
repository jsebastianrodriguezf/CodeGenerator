using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VInformeIngresoConfiguration : IEntityTypeConfiguration<VInformeIngreso>
{
    public void Configure(EntityTypeBuilder<VInformeIngreso> builder)
    {
        builder
            .HasNoKey()
            .ToView("v_informe_ingreso");

        builder.Property(e => e.Cuerpo)
            .HasMaxLength(538)
            .IsUnicode(false)
            .HasColumnName("CUERPO");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("email");
        builder.Property(e => e.Encabezado)
            .IsUnicode(false)
            .HasColumnName("ENCABEZADO");
        builder.Property(e => e.Id).HasColumnName("id");
    }
}
