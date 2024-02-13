using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ErroreConfiguration : IEntityTypeConfiguration<Errore>
{
    public void Configure(EntityTypeBuilder<Errore> builder)
    {
        builder
            .HasNoKey()
            .ToTable("_errores");

        builder.Property(e => e.Cliente)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("cliente");
        builder.Property(e => e.Error)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("error");
        builder.Property(e => e.ErrorCodigo)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("error_codigo");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioModifico)
            .HasDefaultValue(0)
            .HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Seguimiento)
            .HasMaxLength(2000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("seguimiento");
        builder.Property(e => e.Version)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("version");
    }
}
