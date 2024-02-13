using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatTarifaRangoConfiguration : IEntityTypeConfiguration<CatTarifaRango>
{
    public void Configure(EntityTypeBuilder<CatTarifaRango> builder)
    {
        builder.ToTable("cat_tarifaRango");

        builder.HasIndex(e => e.Eid, "IX_cat_tarifaRango");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdTarifa).HasColumnName("id_tarifa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Precio).HasColumnName("precio");
        builder.Property(e => e.RangoFin).HasColumnName("rangoFin");
        builder.Property(e => e.RangoInicio).HasColumnName("rangoInicio");
        builder.Property(e => e.TarifaRango)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tarifaRango");
        builder.Property(e => e.TarifaRangoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tarifaRango_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdTarifaNavigation).WithMany(p => p.CatTarifaRangos)
            .HasForeignKey(d => d.IdTarifa)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_tarifaRango_id_tarifa");
    }
}
