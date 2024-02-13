using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ColumnaConfiguration : IEntityTypeConfiguration<Columna>
{
    public void Configure(EntityTypeBuilder<Columna> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_columnas");

        builder.ToTable("_columnas");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Columna1)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("columna");
        builder.Property(e => e.EsNuleable).HasColumnName("esNuleable");
        builder.Property(e => e.IdTabla).HasColumnName("id_tabla");
        builder.Property(e => e.Tamano).HasColumnName("tamano");
        builder.Property(e => e.Tipo)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("tipo");

        builder.HasOne(d => d.IdTablaNavigation).WithMany(p => p.Columnas)
            .HasForeignKey(d => d.IdTabla)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_columnas_id_tabla");
    }
}
