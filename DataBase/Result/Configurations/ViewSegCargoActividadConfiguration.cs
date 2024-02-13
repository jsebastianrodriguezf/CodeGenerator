using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSegCargoActividadConfiguration : IEntityTypeConfiguration<ViewSegCargoActividad>
{
    public void Configure(EntityTypeBuilder<ViewSegCargoActividad> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_seg_cargo_actividad");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CargoActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cargo_actividad");
        builder.Property(e => e.CatCatalogoActividadBloquearCostear).HasColumnName("cat_catalogo_actividad_bloquearCostear");
        builder.Property(e => e.CatCatalogoActividadCatalogoActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.actividad_catalogo.actividad");
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
        builder.Property(e => e.CatCatalogoActividadDuracionEstimada).HasColumnName("cat_catalogo.actividad_duracionEstimada");
        builder.Property(e => e.CatCatalogoActividadEsNacional).HasColumnName("cat_catalogo_actividad_esNacional");
        builder.Property(e => e.CatCatalogoActividadEsProductiva).HasColumnName("cat_catalogo.actividad_esProductiva");
        builder.Property(e => e.CatCatalogoActividadIdFamilia).HasColumnName("cat_catalogo_actividad_id_familia");
        builder.Property(e => e.CatCatalogoActividadIdImpuesto).HasColumnName("cat_catalogo_actividad_id_impuesto");
        builder.Property(e => e.CatCatalogoActividadIdSubTipoCatalogo).HasColumnName("cat_catalogo_actividad_id_subTipoCatalogo");
        builder.Property(e => e.CatCatalogoActividadIdUnidad).HasColumnName("cat_catalogo_actividad_id_unidad");
        builder.Property(e => e.CatCatalogoActividadPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_actividad_precioVenta");
        builder.Property(e => e.CatCatalogoActividadProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.actividad_procedimiento");
        builder.Property(e => e.CatCatalogoActividadTiempoConsecucion).HasColumnName("cat_catalogo_actividad_tiempoConsecucion");
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
        builder.Property(e => e.IdCargo).HasColumnName("id_cargo");
        builder.Property(e => e.IdCatalogoActividad).HasColumnName("id_catalogo.actividad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.SegCargoCargo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_cargo_cargo");
        builder.Property(e => e.SegCargoCargoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_cargo_cargo_codigo");
        builder.Property(e => e.SegCargoEsAdministrativo).HasColumnName("seg_cargo_esAdministrativo");
        builder.Property(e => e.SegCargoEsComercial).HasColumnName("seg_cargo_esComercial");
        builder.Property(e => e.SegCargoEsCoordinador).HasColumnName("seg_cargo_esCoordinador");
        builder.Property(e => e.SegCargoEsTecnico).HasColumnName("seg_cargo_esTecnico");
        builder.Property(e => e.SegCargoValorHora)
            .HasColumnType("money")
            .HasColumnName("seg_cargo_valorHora");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
