using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatTarifaRangoConfiguration : IEntityTypeConfiguration<ViewCatTarifaRango>
{
    public void Configure(EntityTypeBuilder<ViewCatTarifaRango> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_tarifaRango");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatTarifaEstrategia).HasColumnName("cat_tarifa_estrategia");
        builder.Property(e => e.CatTarifaExterno).HasColumnName("cat_tarifa_externo");
        builder.Property(e => e.CatTarifaIdAtributo).HasColumnName("cat_tarifa_id_atributo");
        builder.Property(e => e.CatTarifaIdCargo).HasColumnName("cat_tarifa_id_cargo");
        builder.Property(e => e.CatTarifaIdCatalogoEquipo).HasColumnName("cat_tarifa_id_catalogo.equipo");
        builder.Property(e => e.CatTarifaIdFamilia).HasColumnName("cat_tarifa_id_familia");
        builder.Property(e => e.CatTarifaIdMarca).HasColumnName("cat_tarifa_id_marca");
        builder.Property(e => e.CatTarifaIdTipoServicio).HasColumnName("cat_tarifa_id_tipoServicio");
        builder.Property(e => e.CatTarifaIdZona).HasColumnName("cat_tarifa_id_zona");
        builder.Property(e => e.CatTarifaIncluyeRepuestos).HasColumnName("cat_tarifa_incluyeRepuestos");
        builder.Property(e => e.CatTarifaMinimo).HasColumnName("cat_tarifa_minimo");
        builder.Property(e => e.CatTarifaPrecio)
            .HasColumnType("money")
            .HasColumnName("cat_tarifa_precio");
        builder.Property(e => e.CatTarifaPrioridad).HasColumnName("cat_tarifa_prioridad");
        builder.Property(e => e.CatTarifaTaller).HasColumnName("cat_tarifa_taller");
        builder.Property(e => e.CatTarifaTarifa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_tarifa_tarifa");
        builder.Property(e => e.CatTarifaTarifaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_tarifa_tarifa_codigo");
        builder.Property(e => e.CatTarifaValorPorUnidad).HasColumnName("cat_tarifa_valorPorUnidad");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdTarifa).HasColumnName("id_tarifa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
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
    }
}
