using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatCatalogoOtroConfiguration : IEntityTypeConfiguration<ViewCatCatalogoOtro>
{
    public void Configure(EntityTypeBuilder<ViewCatCatalogoOtro> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_catalogo_otro");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoOtroBloquearCostear).HasColumnName("cat_catalogo_otro_bloquearCostear");
        builder.Property(e => e.CatCatalogoOtroCatSubtipoCatalogoIdTipoCatalogo).HasColumnName("cat_catalogo_otro_cat_subtipoCatalogo_id_tipoCatalogo");
        builder.Property(e => e.CatCatalogoOtroCatSubtipoCatalogoSubtipoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_cat_subtipoCatalogo_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoOtroCatSubtipoCatalogoSubtipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_cat_subtipoCatalogo_subtipoCatalogo_codigo");
        builder.Property(e => e.CatCatalogoOtroCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_catalogo_codigo");
        builder.Property(e => e.CatCatalogoOtroCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_codigoInventario");
        builder.Property(e => e.CatCatalogoOtroDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_descripcion");
        builder.Property(e => e.CatCatalogoOtroEsNacional).HasColumnName("cat_catalogo_otro_esNacional");
        builder.Property(e => e.CatCatalogoOtroGenFamiliaFamilia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_gen_familia_familia");
        builder.Property(e => e.CatCatalogoOtroGenFamiliaFamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_gen_familia_familia_codigo");
        builder.Property(e => e.CatCatalogoOtroGenFamiliaIdFamilia).HasColumnName("cat_catalogo_otro_gen_familia_id_familia");
        builder.Property(e => e.CatCatalogoOtroGenImpuestoImpuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_gen_impuesto_impuesto");
        builder.Property(e => e.CatCatalogoOtroGenImpuestoImpuestoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_gen_impuesto_impuesto_codigo");
        builder.Property(e => e.CatCatalogoOtroGenImpuestoValor).HasColumnName("cat_catalogo_otro_gen_impuesto_valor");
        builder.Property(e => e.CatCatalogoOtroGenUnidadUnidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_gen_unidad_unidad");
        builder.Property(e => e.CatCatalogoOtroGenUnidadUnidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_otro_gen_unidad_unidad_codigo");
        builder.Property(e => e.CatCatalogoOtroIdFamilia).HasColumnName("cat_catalogo_otro_id_familia");
        builder.Property(e => e.CatCatalogoOtroIdImpuesto).HasColumnName("cat_catalogo_otro_id_impuesto");
        builder.Property(e => e.CatCatalogoOtroIdSubTipoCatalogo).HasColumnName("cat_catalogo_otro_id_subTipoCatalogo");
        builder.Property(e => e.CatCatalogoOtroIdUnidad).HasColumnName("cat_catalogo_otro_id_unidad");
        builder.Property(e => e.CatCatalogoOtroPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_otro_precioVenta");
        builder.Property(e => e.CatCatalogoOtroTiempoConsecucion).HasColumnName("cat_catalogo_otro_tiempoConsecucion");
        builder.Property(e => e.CatalogoOtro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.otro");
        builder.Property(e => e.Costo)
            .HasColumnType("money")
            .HasColumnName("costo");
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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PeriodoAlquiler).HasColumnName("periodoAlquiler");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
