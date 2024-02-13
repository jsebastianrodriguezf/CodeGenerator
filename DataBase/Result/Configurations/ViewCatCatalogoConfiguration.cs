using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatCatalogoConfiguration : IEntityTypeConfiguration<ViewCatCatalogo>
{
    public void Configure(EntityTypeBuilder<ViewCatCatalogo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_catalogo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.BloquearCostear).HasColumnName("bloquearCostear");
        builder.Property(e => e.CatSubtipoCatalogoIdTipoCatalogo).HasColumnName("cat_subtipoCatalogo_id_tipoCatalogo");
        builder.Property(e => e.CatSubtipoCatalogoSubtipoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_subtipoCatalogo_subtipoCatalogo");
        builder.Property(e => e.CatSubtipoCatalogoSubtipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_subtipoCatalogo_subtipoCatalogo_codigo");
        builder.Property(e => e.Catalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo");
        builder.Property(e => e.CatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("catalogo_codigo");
        builder.Property(e => e.CodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("codigoInventario");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("descripcion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsNacional).HasColumnName("esNacional");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenFamiliaFamilia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_familia_familia");
        builder.Property(e => e.GenFamiliaFamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_familia_familia_codigo");
        builder.Property(e => e.GenFamiliaIdFamilia).HasColumnName("gen_familia_id_familia");
        builder.Property(e => e.GenImpuestoImpuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_impuesto_impuesto");
        builder.Property(e => e.GenImpuestoImpuestoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_impuesto_impuesto_codigo");
        builder.Property(e => e.GenImpuestoValor).HasColumnName("gen_impuesto_valor");
        builder.Property(e => e.GenUnidadUnidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_unidad_unidad");
        builder.Property(e => e.GenUnidadUnidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_unidad_unidad_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdFamilia).HasColumnName("id_familia");
        builder.Property(e => e.IdImpuesto).HasColumnName("id_impuesto");
        builder.Property(e => e.IdSubtipoCatalogo).HasColumnName("id_subtipoCatalogo");
        builder.Property(e => e.IdUnidad).HasColumnName("id_unidad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PrecioVenta)
            .HasColumnType("money")
            .HasColumnName("precioVenta");
        builder.Property(e => e.TiempoConsecucion).HasColumnName("tiempoConsecucion");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
