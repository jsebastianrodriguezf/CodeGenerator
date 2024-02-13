using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatDetalleTemparioConfiguration : IEntityTypeConfiguration<ViewCatDetalleTempario>
{
    public void Configure(EntityTypeBuilder<ViewCatDetalleTempario> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_detalleTempario");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CantidadEstandar).HasColumnName("cantidadEstandar");
        builder.Property(e => e.CantidadTropicalizada).HasColumnName("cantidadTropicalizada");
        builder.Property(e => e.CatCatalogoBloquearCostear).HasColumnName("cat_catalogo_bloquearCostear");
        builder.Property(e => e.CatCatalogoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_catalogo");
        builder.Property(e => e.CatCatalogoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_catalogo_codigo");
        builder.Property(e => e.CatCatalogoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_codigoInventario");
        builder.Property(e => e.CatCatalogoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_descripcion");
        builder.Property(e => e.CatCatalogoEsNacional).HasColumnName("cat_catalogo_esNacional");
        builder.Property(e => e.CatCatalogoIdFamilia).HasColumnName("cat_catalogo_id_familia");
        builder.Property(e => e.CatCatalogoIdImpuesto).HasColumnName("cat_catalogo_id_impuesto");
        builder.Property(e => e.CatCatalogoIdSubtipoCatalogo).HasColumnName("cat_catalogo_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoIdUnidad).HasColumnName("cat_catalogo_id_unidad");
        builder.Property(e => e.CatCatalogoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_precioVenta");
        builder.Property(e => e.CatCatalogoTemparioBloquearCostear).HasColumnName("cat_catalogo_tempario_bloquearCostear");
        builder.Property(e => e.CatCatalogoTemparioCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_catalogo_codigo");
        builder.Property(e => e.CatCatalogoTemparioCatalogoTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.tempario_catalogo.tempario");
        builder.Property(e => e.CatCatalogoTemparioCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_codigoInventario");
        builder.Property(e => e.CatCatalogoTemparioDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_tempario_descripcion");
        builder.Property(e => e.CatCatalogoTemparioDetieneEquipos).HasColumnName("cat_catalogo.tempario_detieneEquipos");
        builder.Property(e => e.CatCatalogoTemparioDuracionEstimada).HasColumnName("cat_catalogo.tempario_duracionEstimada");
        builder.Property(e => e.CatCatalogoTemparioEnTaller).HasColumnName("cat_catalogo.tempario_enTaller");
        builder.Property(e => e.CatCatalogoTemparioEsCiclico).HasColumnName("cat_catalogo.tempario_esCiclico");
        builder.Property(e => e.CatCatalogoTemparioEsNacional).HasColumnName("cat_catalogo_tempario_esNacional");
        builder.Property(e => e.CatCatalogoTemparioFacturaTodo).HasColumnName("cat_catalogo.tempario_facturaTodo");
        builder.Property(e => e.CatCatalogoTemparioHorasDetencion).HasColumnName("cat_catalogo.tempario_horasDetencion");
        builder.Property(e => e.CatCatalogoTemparioIdFamilia).HasColumnName("cat_catalogo_tempario_id_familia");
        builder.Property(e => e.CatCatalogoTemparioIdImpuesto).HasColumnName("cat_catalogo_tempario_id_impuesto");
        builder.Property(e => e.CatCatalogoTemparioIdSubtipoCatalogo).HasColumnName("cat_catalogo_tempario_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoTemparioIdTipoServicio).HasColumnName("cat_catalogo.tempario_id_tipoServicio");
        builder.Property(e => e.CatCatalogoTemparioIdUnidad).HasColumnName("cat_catalogo_tempario_id_unidad");
        builder.Property(e => e.CatCatalogoTemparioIncluirMenores).HasColumnName("cat_catalogo.tempario_incluirMenores");
        builder.Property(e => e.CatCatalogoTemparioModoAjuste).HasColumnName("cat_catalogo.tempario_modoAjuste");
        builder.Property(e => e.CatCatalogoTemparioPeriodoDias).HasColumnName("cat_catalogo.tempario_periodoDias");
        builder.Property(e => e.CatCatalogoTemparioPeriodoHoras).HasColumnName("cat_catalogo.tempario_periodoHoras");
        builder.Property(e => e.CatCatalogoTemparioPorcGarantia).HasColumnName("cat_catalogo.tempario_porcGarantia");
        builder.Property(e => e.CatCatalogoTemparioPorcTropicalizacion).HasColumnName("cat_catalogo.tempario_porcTropicalizacion");
        builder.Property(e => e.CatCatalogoTemparioPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_tempario_precioVenta");
        builder.Property(e => e.CatCatalogoTemparioProyectar).HasColumnName("cat_catalogo.tempario_proyectar");
        builder.Property(e => e.CatCatalogoTemparioTiempoConsecucion).HasColumnName("cat_catalogo_tempario_tiempoConsecucion");
        builder.Property(e => e.CatCatalogoTiempoConsecucion).HasColumnName("cat_catalogo_tiempoConsecucion");
        builder.Property(e => e.CatDetalleTemparioPadreCantidadEstandar).HasColumnName("cat_detalleTempario_padre_cantidadEstandar");
        builder.Property(e => e.CatDetalleTemparioPadreCantidadTropicalizada).HasColumnName("cat_detalleTempario_padre_cantidadTropicalizada");
        builder.Property(e => e.CatDetalleTemparioPadreDetalleTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_detalleTempario_padre_detalleTempario");
        builder.Property(e => e.CatDetalleTemparioPadreDetalleTemparioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_detalleTempario_padre_detalleTempario_codigo");
        builder.Property(e => e.CatDetalleTemparioPadreIdCatalogo).HasColumnName("cat_detalleTempario_padre_id_catalogo");
        builder.Property(e => e.CatDetalleTemparioPadreIdCatalogoTempario).HasColumnName("cat_detalleTempario_padre_id_catalogo.tempario");
        builder.Property(e => e.CatDetalleTemparioPadreIdDetalleTemparioPadre).HasColumnName("cat_detalleTempario_padre_id_detalleTempario_padre");
        builder.Property(e => e.CatDetalleTemparioPadreIdPruebaCheckList).HasColumnName("cat_detalleTempario_padre_id_pruebaCheckList");
        builder.Property(e => e.CatDetalleTemparioPadreIdSistema).HasColumnName("cat_detalleTempario_padre_id_sistema");
        builder.Property(e => e.CatDetalleTemparioPadreOrden).HasColumnName("cat_detalleTempario_padre_orden");
        builder.Property(e => e.CatPruebaCheckListPruebaCheckList)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_pruebaCheckList_pruebaCheckList");
        builder.Property(e => e.CatPruebaCheckListPruebaCheckListCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_pruebaCheckList_pruebaCheckList_codigo");
        builder.Property(e => e.CatSistemaSistema)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_sistema");
        builder.Property(e => e.CatSistemaSistemaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_sistema_codigo");
        builder.Property(e => e.DetalleTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleTempario");
        builder.Property(e => e.DetalleTemparioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleTempario_codigo");
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
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdCatalogoTempario).HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdDetalleTemparioPadre).HasColumnName("id_detalleTempario_padre");
        builder.Property(e => e.IdPruebaCheckList).HasColumnName("id_pruebaCheckList");
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
