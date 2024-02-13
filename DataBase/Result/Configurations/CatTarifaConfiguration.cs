using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatTarifaConfiguration : IEntityTypeConfiguration<CatTarifa>
{
    public void Configure(EntityTypeBuilder<CatTarifa> builder)
    {
        builder.ToTable("cat_tarifa");

        builder.HasIndex(e => e.Eid, "IX_cat_tarifa");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Estrategia).HasColumnName("estrategia");
        builder.Property(e => e.Externo).HasColumnName("externo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdCargo).HasColumnName("id_cargo");
        builder.Property(e => e.IdCatalogoEquipo).HasColumnName("id_catalogo.equipo");
        builder.Property(e => e.IdFamilia).HasColumnName("id_familia");
        builder.Property(e => e.IdMarca).HasColumnName("id_marca");
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.IncluyeRepuestos).HasColumnName("incluyeRepuestos");
        builder.Property(e => e.Minimo).HasColumnName("minimo");
        builder.Property(e => e.Precio)
            .HasColumnType("money")
            .HasColumnName("precio");
        builder.Property(e => e.Prioridad).HasColumnName("prioridad");
        builder.Property(e => e.Taller).HasColumnName("taller");
        builder.Property(e => e.Tarifa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tarifa");
        builder.Property(e => e.TarifaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tarifa_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorPorUnidad).HasColumnName("valorPorUnidad");

        builder.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.CatTarifas)
            .HasForeignKey(d => d.IdAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_tarifa_id_atributo");

        builder.HasOne(d => d.IdCargoNavigation).WithMany(p => p.CatTarifas)
            .HasForeignKey(d => d.IdCargo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_tarifa_id_cargo");

        builder.HasOne(d => d.IdCatalogoEquipoNavigation).WithMany(p => p.CatTarifas)
            .HasForeignKey(d => d.IdCatalogoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_tarifa_id_catalogo_equipo");

        builder.HasOne(d => d.IdFamiliaNavigation).WithMany(p => p.CatTarifas)
            .HasForeignKey(d => d.IdFamilia)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_tarifa_id_familia");

        builder.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.CatTarifas)
            .HasForeignKey(d => d.IdMarca)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_tarifa_id_marca");

        builder.HasOne(d => d.IdTipoServicioNavigation).WithMany(p => p.CatTarifas)
            .HasForeignKey(d => d.IdTipoServicio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_tarifa_id_tipoServicio");

        builder.HasOne(d => d.IdZonaNavigation).WithMany(p => p.CatTarifas)
            .HasForeignKey(d => d.IdZona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_tarifa_id_zona");
    }
}
