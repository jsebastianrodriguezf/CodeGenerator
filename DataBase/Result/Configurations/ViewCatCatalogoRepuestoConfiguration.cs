using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatCatalogoRepuestoConfiguration : IEntityTypeConfiguration<ViewCatCatalogoRepuesto>
{
    public void Configure(EntityTypeBuilder<ViewCatCatalogoRepuesto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_catalogo_repuesto");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoRepuestoBloquearCostear).HasColumnName("cat_catalogo_repuesto_bloquearCostear");
        builder.Property(e => e.CatCatalogoRepuestoCatSubtipoCatalogoIdTipoCatalogo).HasColumnName("cat_catalogo_repuesto_cat_subtipoCatalogo_id_tipoCatalogo");
        builder.Property(e => e.CatCatalogoRepuestoCatSubtipoCatalogoSubtipoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_cat_subtipoCatalogo_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoRepuestoCatSubtipoCatalogoSubtipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_cat_subtipoCatalogo_subtipoCatalogo_codigo");
        builder.Property(e => e.CatCatalogoRepuestoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_catalogo_codigo");
        builder.Property(e => e.CatCatalogoRepuestoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_codigoInventario");
        builder.Property(e => e.CatCatalogoRepuestoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_descripcion");
        builder.Property(e => e.CatCatalogoRepuestoEsNacional).HasColumnName("cat_catalogo_repuesto_esNacional");
        builder.Property(e => e.CatCatalogoRepuestoGenFamiliaFamilia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_gen_familia_familia");
        builder.Property(e => e.CatCatalogoRepuestoGenFamiliaFamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_gen_familia_familia_codigo");
        builder.Property(e => e.CatCatalogoRepuestoGenFamiliaIdFamilia).HasColumnName("cat_catalogo_repuesto_gen_familia_id_familia");
        builder.Property(e => e.CatCatalogoRepuestoGenImpuestoImpuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_gen_impuesto_impuesto");
        builder.Property(e => e.CatCatalogoRepuestoGenImpuestoImpuestoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_gen_impuesto_impuesto_codigo");
        builder.Property(e => e.CatCatalogoRepuestoGenImpuestoValor).HasColumnName("cat_catalogo_repuesto_gen_impuesto_valor");
        builder.Property(e => e.CatCatalogoRepuestoGenUnidadUnidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_gen_unidad_unidad");
        builder.Property(e => e.CatCatalogoRepuestoGenUnidadUnidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_repuesto_gen_unidad_unidad_codigo");
        builder.Property(e => e.CatCatalogoRepuestoIdFamilia).HasColumnName("cat_catalogo_repuesto_id_familia");
        builder.Property(e => e.CatCatalogoRepuestoIdImpuesto).HasColumnName("cat_catalogo_repuesto_id_impuesto");
        builder.Property(e => e.CatCatalogoRepuestoIdSubTipoCatalogo).HasColumnName("cat_catalogo_repuesto_id_subTipoCatalogo");
        builder.Property(e => e.CatCatalogoRepuestoIdUnidad).HasColumnName("cat_catalogo_repuesto_id_unidad");
        builder.Property(e => e.CatCatalogoRepuestoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_repuesto_precioVenta");
        builder.Property(e => e.CatCatalogoRepuestoTiempoConsecucion).HasColumnName("cat_catalogo_repuesto_tiempoConsecucion");
        builder.Property(e => e.CatMarcaIdTerceroFabricante).HasColumnName("cat_marca_id_tercero_fabricante");
        builder.Property(e => e.CatMarcaMarca)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_marca_marca");
        builder.Property(e => e.CatMarcaMarcaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_marca_marca_codigo");
        builder.Property(e => e.CatalogoRepuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.repuesto");
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
        builder.Property(e => e.GarantiaDias).HasColumnName("garantiaDias");
        builder.Property(e => e.GarantiaHoras).HasColumnName("garantiaHoras");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdMarca).HasColumnName("id_marca");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Peso).HasColumnName("peso");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Vigente).HasColumnName("vigente");
    }
}
