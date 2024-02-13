using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class IdaeConfiguration : IEntityTypeConfiguration<Idae>
{
    public void Configure(EntityTypeBuilder<Idae> builder)
    {
        builder
            .HasNoKey()
            .ToTable("_idae");

        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.K)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("k");
        builder.Property(e => e.V)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("v");
    }
}
