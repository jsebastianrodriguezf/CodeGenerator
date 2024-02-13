using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VHorarioTrabajoConfiguration : IEntityTypeConfiguration<VHorarioTrabajo>
{
    public void Configure(EntityTypeBuilder<VHorarioTrabajo> builder)
    {
        builder
            .HasNoKey()
            .ToView("v_HorarioTrabajo");

        builder.Property(e => e.HorarioTrabajo)
            .HasMaxLength(2052)
            .IsUnicode(false)
            .HasColumnName("horarioTrabajo");
    }
}
