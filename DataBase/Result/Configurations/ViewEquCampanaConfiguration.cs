using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquCampanaConfiguration : IEntityTypeConfiguration<ViewEquCampana>
{
    public void Configure(EntityTypeBuilder<ViewEquCampana> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_campana");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Activo).HasColumnName("activo");
        builder.Property(e => e.Campana)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("campana");
        builder.Property(e => e.CampanaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("campana_codigo");
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
        builder.Property(e => e.CatCatalogoTemparioIdSubTipoCatalogo).HasColumnName("cat_catalogo_tempario_id_subTipoCatalogo");
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
        builder.Property(e => e.DetalleCampana)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("detalleCampana");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicio_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechafinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechafin_ff");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCatalogoTempario).HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.TerTerceroClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_clasificacion");
        builder.Property(e => e.TerTerceroContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_contacto");
        builder.Property(e => e.TerTerceroDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_direccion");
        builder.Property(e => e.TerTerceroEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_email");
        builder.Property(e => e.TerTerceroEsCliente).HasColumnName("ter_tercero_esCliente");
        builder.Property(e => e.TerTerceroEsEmpresaPropia).HasColumnName("ter_tercero_esEmpresaPropia");
        builder.Property(e => e.TerTerceroEsFabricante).HasColumnName("ter_tercero_esFabricante");
        builder.Property(e => e.TerTerceroEsProspecto).HasColumnName("ter_tercero_esProspecto");
        builder.Property(e => e.TerTerceroEsProveedor).HasColumnName("ter_tercero_esProveedor");
        builder.Property(e => e.TerTerceroEsTransportador).HasColumnName("ter_tercero_esTransportador");
        builder.Property(e => e.TerTerceroFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fax");
        builder.Property(e => e.TerTerceroIdEstadoTercero).HasColumnName("ter_tercero_id_estadoTercero");
        builder.Property(e => e.TerTerceroIdNaturalezaTercero).HasColumnName("ter_tercero_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroIdZona).HasColumnName("ter_tercero_id_zona");
        builder.Property(e => e.TerTerceroNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_notas");
        builder.Property(e => e.TerTerceroRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_representante");
        builder.Property(e => e.TerTerceroTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_telefono");
        builder.Property(e => e.TerTerceroTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero");
        builder.Property(e => e.TerTerceroTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_codigo");
        builder.Property(e => e.TerTerceroTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_nit");
        builder.Property(e => e.TerTerceroTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_website");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
