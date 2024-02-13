using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatCatalogoTemparioConfiguration : IEntityTypeConfiguration<ViewCatCatalogoTempario>
{
    public void Configure(EntityTypeBuilder<ViewCatCatalogoTempario> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_catalogo_tempario");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoTemparioBloquearCostear).HasColumnName("cat_catalogo_tempario_bloquearCostear");
        builder.Property(e => e.CatCatalogoTemparioCatSubtipoCatalogoIdTipoCatalogo).HasColumnName("cat_catalogo_tempario_cat_subtipoCatalogo_id_tipoCatalogo");
        builder.Property(e => e.CatCatalogoTemparioCatSubtipoCatalogoSubtipoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_cat_subtipoCatalogo_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoTemparioCatSubtipoCatalogoSubtipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_cat_subtipoCatalogo_subtipoCatalogo_codigo");
        builder.Property(e => e.CatCatalogoTemparioCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_catalogo_codigo");
        builder.Property(e => e.CatCatalogoTemparioCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_codigoInventario");
        builder.Property(e => e.CatCatalogoTemparioDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_descripcion");
        builder.Property(e => e.CatCatalogoTemparioEsNacional).HasColumnName("cat_catalogo_tempario_esNacional");
        builder.Property(e => e.CatCatalogoTemparioGenFamiliaFamilia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_gen_familia_familia");
        builder.Property(e => e.CatCatalogoTemparioGenFamiliaFamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_gen_familia_familia_codigo");
        builder.Property(e => e.CatCatalogoTemparioGenFamiliaIdFamilia).HasColumnName("cat_catalogo_tempario_gen_familia_id_familia");
        builder.Property(e => e.CatCatalogoTemparioGenImpuestoImpuesto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_gen_impuesto_impuesto");
        builder.Property(e => e.CatCatalogoTemparioGenImpuestoImpuestoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_gen_impuesto_impuesto_codigo");
        builder.Property(e => e.CatCatalogoTemparioGenImpuestoValor).HasColumnName("cat_catalogo_tempario_gen_impuesto_valor");
        builder.Property(e => e.CatCatalogoTemparioGenUnidadUnidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_gen_unidad_unidad");
        builder.Property(e => e.CatCatalogoTemparioGenUnidadUnidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_gen_unidad_unidad_codigo");
        builder.Property(e => e.CatCatalogoTemparioIdFamilia).HasColumnName("cat_catalogo_tempario_id_familia");
        builder.Property(e => e.CatCatalogoTemparioIdImpuesto).HasColumnName("cat_catalogo_tempario_id_impuesto");
        builder.Property(e => e.CatCatalogoTemparioIdSubtipoCatalogo).HasColumnName("cat_catalogo_tempario_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoTemparioIdUnidad).HasColumnName("cat_catalogo_tempario_id_unidad");
        builder.Property(e => e.CatCatalogoTemparioPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_tempario_precioVenta");
        builder.Property(e => e.CatCatalogoTemparioTiempoConsecucion).HasColumnName("cat_catalogo_tempario_tiempoConsecucion");
        builder.Property(e => e.CatalogoTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.tempario");
        builder.Property(e => e.DetieneEquipos).HasColumnName("detieneEquipos");
        builder.Property(e => e.DuracionEstimada).HasColumnName("duracionEstimada");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EnTaller).HasColumnName("enTaller");
        builder.Property(e => e.EsCiclico).HasColumnName("esCiclico");
        builder.Property(e => e.FacturaTodo).HasColumnName("facturaTodo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenTipoServicioDiasGarantia).HasColumnName("gen_tipoServicio_diasGarantia");
        builder.Property(e => e.GenTipoServicioTieneGarantia).HasColumnName("gen_tipoServicio_tieneGarantia");
        builder.Property(e => e.GenTipoServicioTipoServicio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_tipoServicio_tipoServicio");
        builder.Property(e => e.GenTipoServicioTipoServicioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_tipoServicio_tipoServicio_codigo");
        builder.Property(e => e.HorasDetencion).HasColumnName("horasDetencion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IncluirMenores).HasColumnName("incluirMenores");
        builder.Property(e => e.ModoAjuste).HasColumnName("modoAjuste");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PeriodoDias).HasColumnName("periodoDias");
        builder.Property(e => e.PeriodoHoras).HasColumnName("periodoHoras");
        builder.Property(e => e.PorcGarantia).HasColumnName("porcGarantia");
        builder.Property(e => e.PorcTropicalizacion).HasColumnName("porcTropicalizacion");
        builder.Property(e => e.Proyectar).HasColumnName("proyectar");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
