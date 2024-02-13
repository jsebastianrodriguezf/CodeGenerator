using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCntConfigContratoConfiguration : IEntityTypeConfiguration<ViewCntConfigContrato>
{
    public void Configure(EntityTypeBuilder<ViewCntConfigContrato> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cnt_configContrato");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AproximarA).HasColumnName("aproximarA");
        builder.Property(e => e.CadaN).HasColumnName("cadaN");
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
        builder.Property(e => e.CntContratoEquipoContratoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_contratoEquipo_contratoEquipo");
        builder.Property(e => e.CntContratoEquipoContratoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cnt_contratoEquipo_contratoEquipo_codigo");
        builder.Property(e => e.CntContratoEquipoFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_contratoEquipo_fecha_ff");
        builder.Property(e => e.CntContratoEquipoIdContrato).HasColumnName("cnt_contratoEquipo_id_contrato");
        builder.Property(e => e.CntContratoEquipoIdContratoDetalleVisita).HasColumnName("cnt_contratoEquipo_id_contratoDetalleVisita");
        builder.Property(e => e.CntContratoEquipoIdEquipo).HasColumnName("cnt_contratoEquipo_id_equipo");
        builder.Property(e => e.CntContratoEquipoPrecioServicio)
            .HasColumnType("money")
            .HasColumnName("cnt_contratoEquipo_precioServicio");
        builder.Property(e => e.CntContratoEquipoPrecioVisita)
            .HasColumnType("money")
            .HasColumnName("cnt_contratoEquipo_precioVisita");
        builder.Property(e => e.CntContratoEquipoPromedio).HasColumnName("cnt_contratoEquipo_promedio");
        builder.Property(e => e.ConfigContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("configContrato");
        builder.Property(e => e.Dia).HasColumnName("dia");
        builder.Property(e => e.DiaHabil).HasColumnName("diaHabil");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Estrategia).HasColumnName("estrategia");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Frecuencia).HasColumnName("frecuencia");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCatalogoTempario).HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdContratoEquipo).HasColumnName("id_contratoEquipo");
        builder.Property(e => e.IdTerceroProveedor).HasColumnName("id_tercero_proveedor");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IncluirMenores).HasColumnName("incluirMenores");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PorTrabajo).HasColumnName("porTrabajo");
        builder.Property(e => e.TerTerceroProveedorClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_clasificacion");
        builder.Property(e => e.TerTerceroProveedorContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_contacto");
        builder.Property(e => e.TerTerceroProveedorDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_direccion");
        builder.Property(e => e.TerTerceroProveedorEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_email");
        builder.Property(e => e.TerTerceroProveedorEsCliente).HasColumnName("ter_tercero_proveedor_esCliente");
        builder.Property(e => e.TerTerceroProveedorEsEmpresaPropia).HasColumnName("ter_tercero_proveedor_esEmpresaPropia");
        builder.Property(e => e.TerTerceroProveedorEsFabricante).HasColumnName("ter_tercero_proveedor_esFabricante");
        builder.Property(e => e.TerTerceroProveedorEsProspecto).HasColumnName("ter_tercero_proveedor_esProspecto");
        builder.Property(e => e.TerTerceroProveedorEsProveedor).HasColumnName("ter_tercero_proveedor_esProveedor");
        builder.Property(e => e.TerTerceroProveedorEsTransportador).HasColumnName("ter_tercero_proveedor_esTransportador");
        builder.Property(e => e.TerTerceroProveedorFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_fax");
        builder.Property(e => e.TerTerceroProveedorIdEstadoTercero).HasColumnName("ter_tercero_proveedor_id_estadoTercero");
        builder.Property(e => e.TerTerceroProveedorIdNaturalezaTercero).HasColumnName("ter_tercero_proveedor_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroProveedorIdZona).HasColumnName("ter_tercero_proveedor_id_zona");
        builder.Property(e => e.TerTerceroProveedorNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_notas");
        builder.Property(e => e.TerTerceroProveedorRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_representante");
        builder.Property(e => e.TerTerceroProveedorTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_telefono");
        builder.Property(e => e.TerTerceroProveedorTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_tercero");
        builder.Property(e => e.TerTerceroProveedorTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_tercero_codigo");
        builder.Property(e => e.TerTerceroProveedorTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_tercero_nit");
        builder.Property(e => e.TerTerceroProveedorTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroProveedorWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_proveedor_website");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
