using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VChecklistTodaConfiguration : IEntityTypeConfiguration<VChecklistToda>
{
    public void Configure(EntityTypeBuilder<VChecklistToda> builder)
    {
        builder
            .HasNoKey()
            .ToView("v_checklistTodas");

        builder.Property(e => e.EsVariable).HasColumnName("esVariable");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdLista).HasColumnName("id_lista");
        builder.Property(e => e.IdsOpciones)
            .HasMaxLength(500)
            .HasColumnName("IDsOpciones");
        builder.Property(e => e.Item)
            .HasMaxLength(900)
            .IsUnicode(false)
            .HasColumnName("item");
        builder.Property(e => e.Obligatorio).HasColumnName("obligatorio");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Rango)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasColumnName("rango");
        builder.Property(e => e.Seccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seccion");
        builder.Property(e => e.TextosOpciones)
            .HasMaxLength(500)
            .HasColumnName("textosOpciones");
        builder.Property(e => e.Tipo).HasColumnName("tipo");
    }
}
