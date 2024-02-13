using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatCatalogoEquipoConfiguration : IEntityTypeConfiguration<ViewCatCatalogoEquipo>
{
    public void Configure(EntityTypeBuilder<ViewCatCatalogoEquipo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_catalogo_equipo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoEquipoBloquearCostear).HasColumnName("cat_catalogo_equipo_bloquearCostear");
        builder.Property(e => e.CatCatalogoEquipoCatSubtipoCatalogoIdTipoCatalogo).HasColumnName("cat_catalogo_equipo_cat_subtipoCatalogo_id_tipoCatalogo");
        builder.Property(e => e.CatCatalogoEquipoCatSubtipoCatalogoSubtipoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_cat_subtipoCatalogo_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoEquipoCatSubtipoCatalogoSubtipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_cat_subtipoCatalogo_subtipoCatalogo_codigo");
        builder.Property(e => e.CatCatalogoEquipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_catalogo_codigo");
        builder.Property(e => e.CatCatalogoEquipoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_codigoInventario");
        builder.Property(e => e.CatCatalogoEquipoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_descripcion");
        builder.Property(e => e.CatCatalogoEquipoEsNacional).HasColumnName("cat_catalogo_equipo_esNacional");
        builder.Property(e => e.CatCatalogoEquipoGenFamiliaFamilia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_gen_familia_familia");
        builder.Property(e => e.CatCatalogoEquipoGenFamiliaFamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_gen_familia_familia_codigo");
        builder.Property(e => e.CatCatalogoEquipoGenFamiliaIdFamilia).HasColumnName("cat_catalogo_equipo_gen_familia_id_familia");
        builder.Property(e => e.CatCatalogoEquipoGenImpuestoImpuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_gen_impuesto_impuesto");
        builder.Property(e => e.CatCatalogoEquipoGenImpuestoImpuestoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_gen_impuesto_impuesto_codigo");
        builder.Property(e => e.CatCatalogoEquipoGenImpuestoValor).HasColumnName("cat_catalogo_equipo_gen_impuesto_valor");
        builder.Property(e => e.CatCatalogoEquipoGenUnidadUnidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_gen_unidad_unidad");
        builder.Property(e => e.CatCatalogoEquipoGenUnidadUnidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_gen_unidad_unidad_codigo");
        builder.Property(e => e.CatCatalogoEquipoIdFamilia).HasColumnName("cat_catalogo_equipo_id_familia");
        builder.Property(e => e.CatCatalogoEquipoIdImpuesto).HasColumnName("cat_catalogo_equipo_id_impuesto");
        builder.Property(e => e.CatCatalogoEquipoIdSubtipoCatalogo).HasColumnName("cat_catalogo_equipo_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoEquipoIdUnidad).HasColumnName("cat_catalogo_equipo_id_unidad");
        builder.Property(e => e.CatCatalogoEquipoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_equipo_precioVenta");
        builder.Property(e => e.CatCatalogoEquipoTiempoConsecucion).HasColumnName("cat_catalogo_equipo_tiempoConsecucion");
        builder.Property(e => e.CatMarcaIdTerceroFabricante).HasColumnName("cat_marca_id_tercero_fabricante");
        builder.Property(e => e.CatMarcaMarca)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_marca_marca");
        builder.Property(e => e.CatMarcaMarcaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_marca_marca_codigo");
        builder.Property(e => e.CatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.equipo");
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
        builder.Property(e => e.GarantiaHoras).HasColumnName("garantiaHoras");
        builder.Property(e => e.GarantiaMeses).HasColumnName("garantiaMeses");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdMarca).HasColumnName("id_marca");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ManejaHorometro).HasColumnName("manejaHorometro");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
