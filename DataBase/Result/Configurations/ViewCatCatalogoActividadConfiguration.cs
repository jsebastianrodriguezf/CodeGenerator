using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatCatalogoActividadConfiguration : IEntityTypeConfiguration<ViewCatCatalogoActividad>
{
    public void Configure(EntityTypeBuilder<ViewCatCatalogoActividad> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_catalogo_actividad");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoActividadBloquearCostear).HasColumnName("cat_catalogo_actividad_bloquearCostear");
        builder.Property(e => e.CatCatalogoActividadCatSubtipoCatalogoIdTipoCatalogo).HasColumnName("cat_catalogo_actividad_cat_subtipoCatalogo_id_tipoCatalogo");
        builder.Property(e => e.CatCatalogoActividadCatSubtipoCatalogoSubtipoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_cat_subtipoCatalogo_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoActividadCatSubtipoCatalogoSubtipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_cat_subtipoCatalogo_subtipoCatalogo_codigo");
        builder.Property(e => e.CatCatalogoActividadCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_catalogo_codigo");
        builder.Property(e => e.CatCatalogoActividadCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_codigoInventario");
        builder.Property(e => e.CatCatalogoActividadDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_descripcion");
        builder.Property(e => e.CatCatalogoActividadEsNacional).HasColumnName("cat_catalogo_actividad_esNacional");
        builder.Property(e => e.CatCatalogoActividadGenFamiliaFamilia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_gen_familia_familia");
        builder.Property(e => e.CatCatalogoActividadGenFamiliaFamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_gen_familia_familia_codigo");
        builder.Property(e => e.CatCatalogoActividadGenFamiliaIdFamilia).HasColumnName("cat_catalogo_actividad_gen_familia_id_familia");
        builder.Property(e => e.CatCatalogoActividadGenImpuestoImpuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_gen_impuesto_impuesto");
        builder.Property(e => e.CatCatalogoActividadGenImpuestoImpuestoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_gen_impuesto_impuesto_codigo");
        builder.Property(e => e.CatCatalogoActividadGenImpuestoValor).HasColumnName("cat_catalogo_actividad_gen_impuesto_valor");
        builder.Property(e => e.CatCatalogoActividadGenUnidadUnidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_gen_unidad_unidad");
        builder.Property(e => e.CatCatalogoActividadGenUnidadUnidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_gen_unidad_unidad_codigo");
        builder.Property(e => e.CatCatalogoActividadIdFamilia).HasColumnName("cat_catalogo_actividad_id_familia");
        builder.Property(e => e.CatCatalogoActividadIdImpuesto).HasColumnName("cat_catalogo_actividad_id_impuesto");
        builder.Property(e => e.CatCatalogoActividadIdSubtipoCatalogo).HasColumnName("cat_catalogo_actividad_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoActividadIdUnidad).HasColumnName("cat_catalogo_actividad_id_unidad");
        builder.Property(e => e.CatCatalogoActividadPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_actividad_precioVenta");
        builder.Property(e => e.CatCatalogoActividadTiempoConsecucion).HasColumnName("cat_catalogo_actividad_tiempoConsecucion");
        builder.Property(e => e.CatalogoActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.actividad");
        builder.Property(e => e.DiasGarantia).HasColumnName("dias_garantia");
        builder.Property(e => e.DuracionEstimada).HasColumnName("duracionEstimada");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsProductiva).HasColumnName("esProductiva");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Procedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("procedimiento");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
