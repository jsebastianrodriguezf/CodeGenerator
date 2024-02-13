using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegCargoConfiguration : IEntityTypeConfiguration<SegCargo>
{
    public void Configure(EntityTypeBuilder<SegCargo> builder)
    {
        builder.ToTable("seg_cargo");

        builder.HasIndex(e => e.Eid, "IX_seg_cargo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cargo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cargo");
        builder.Property(e => e.CargoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cargo_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsAdministrativo).HasColumnName("esAdministrativo");
        builder.Property(e => e.EsComercial)
            .HasDefaultValue(false)
            .HasColumnName("esComercial");
        builder.Property(e => e.EsCoordinador)
            .HasDefaultValue(false)
            .HasColumnName("esCoordinador");
        builder.Property(e => e.EsTecnico)
            .HasDefaultValue(false)
            .HasColumnName("esTecnico");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorHora)
            .HasColumnType("money")
            .HasColumnName("valorHora");
    }
}
