using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatPosicionConfiguration : IEntityTypeConfiguration<ViewCatPosicion>
{
    public void Configure(EntityTypeBuilder<ViewCatPosicion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_posicion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoEquipoComponenteBloquearCostear).HasColumnName("cat_catalogo_equipo_componente_bloquearCostear");
        builder.Property(e => e.CatCatalogoEquipoComponenteCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_componente_catalogo_codigo");
        builder.Property(e => e.CatCatalogoEquipoComponenteCatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.equipo_componente_catalogo.equipo");
        builder.Property(e => e.CatCatalogoEquipoComponenteCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_componente_codigoInventario");
        builder.Property(e => e.CatCatalogoEquipoComponenteDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_componente_descripcion");
        builder.Property(e => e.CatCatalogoEquipoComponenteEsNacional).HasColumnName("cat_catalogo_equipo_componente_esNacional");
        builder.Property(e => e.CatCatalogoEquipoComponenteGarantiaHoras).HasColumnName("cat_catalogo.equipo_componente_garantiaHoras");
        builder.Property(e => e.CatCatalogoEquipoComponenteGarantiaMeses).HasColumnName("cat_catalogo.equipo_componente_garantiaMeses");
        builder.Property(e => e.CatCatalogoEquipoComponenteIdFamilia).HasColumnName("cat_catalogo_equipo_componente_id_familia");
        builder.Property(e => e.CatCatalogoEquipoComponenteIdImpuesto).HasColumnName("cat_catalogo_equipo_componente_id_impuesto");
        builder.Property(e => e.CatCatalogoEquipoComponenteIdMarca).HasColumnName("cat_catalogo.equipo_componente_id_marca");
        builder.Property(e => e.CatCatalogoEquipoComponenteIdSubtipoCatalogo).HasColumnName("cat_catalogo_equipo_componente_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoEquipoComponenteIdUnidad).HasColumnName("cat_catalogo_equipo_componente_id_unidad");
        builder.Property(e => e.CatCatalogoEquipoComponenteManejaHorometro).HasColumnName("cat_catalogo.equipo_componente_manejaHorometro");
        builder.Property(e => e.CatCatalogoEquipoComponentePrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_equipo_componente_precioVenta");
        builder.Property(e => e.CatCatalogoEquipoComponenteTiempoConsecucion).HasColumnName("cat_catalogo_equipo_componente_tiempoConsecucion");
        builder.Property(e => e.CatCatalogoEquipoEquipoBloquearCostear).HasColumnName("cat_catalogo_equipo_equipo_bloquearCostear");
        builder.Property(e => e.CatCatalogoEquipoEquipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_equipo_catalogo_codigo");
        builder.Property(e => e.CatCatalogoEquipoEquipoCatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.equipo_equipo_catalogo.equipo");
        builder.Property(e => e.CatCatalogoEquipoEquipoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_equipo_codigoInventario");
        builder.Property(e => e.CatCatalogoEquipoEquipoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_equipo_descripcion");
        builder.Property(e => e.CatCatalogoEquipoEquipoEsNacional).HasColumnName("cat_catalogo_equipo_equipo_esNacional");
        builder.Property(e => e.CatCatalogoEquipoEquipoGarantiaHoras).HasColumnName("cat_catalogo.equipo_equipo_garantiaHoras");
        builder.Property(e => e.CatCatalogoEquipoEquipoGarantiaMeses).HasColumnName("cat_catalogo.equipo_equipo_garantiaMeses");
        builder.Property(e => e.CatCatalogoEquipoEquipoIdFamilia).HasColumnName("cat_catalogo_equipo_equipo_id_familia");
        builder.Property(e => e.CatCatalogoEquipoEquipoIdImpuesto).HasColumnName("cat_catalogo_equipo_equipo_id_impuesto");
        builder.Property(e => e.CatCatalogoEquipoEquipoIdMarca).HasColumnName("cat_catalogo.equipo_equipo_id_marca");
        builder.Property(e => e.CatCatalogoEquipoEquipoIdSubtipoCatalogo).HasColumnName("cat_catalogo_equipo_equipo_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoEquipoEquipoIdUnidad).HasColumnName("cat_catalogo_equipo_equipo_id_unidad");
        builder.Property(e => e.CatCatalogoEquipoEquipoManejaHorometro).HasColumnName("cat_catalogo.equipo_equipo_manejaHorometro");
        builder.Property(e => e.CatCatalogoEquipoEquipoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_equipo_equipo_precioVenta");
        builder.Property(e => e.CatCatalogoEquipoEquipoTiempoConsecucion).HasColumnName("cat_catalogo_equipo_equipo_tiempoConsecucion");
        builder.Property(e => e.CatDimensionXAplicaEnX).HasColumnName("cat_dimension_x_aplicaEnX");
        builder.Property(e => e.CatDimensionXAplicaEnY).HasColumnName("cat_dimension_x_aplicaEnY");
        builder.Property(e => e.CatDimensionXAplicaEnZ).HasColumnName("cat_dimension_x_aplicaEnZ");
        builder.Property(e => e.CatDimensionXDimension)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_dimension_x_dimension");
        builder.Property(e => e.CatDimensionXDimensionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_dimension_x_dimension_codigo");
        builder.Property(e => e.CatDimensionYAplicaEnX).HasColumnName("cat_dimension_y_aplicaEnX");
        builder.Property(e => e.CatDimensionYAplicaEnY).HasColumnName("cat_dimension_y_aplicaEnY");
        builder.Property(e => e.CatDimensionYAplicaEnZ).HasColumnName("cat_dimension_y_aplicaEnZ");
        builder.Property(e => e.CatDimensionYDimension)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_dimension_y_dimension");
        builder.Property(e => e.CatDimensionYDimensionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_dimension_y_dimension_codigo");
        builder.Property(e => e.CatDimensionZAplicaEnX).HasColumnName("cat_dimension_z_aplicaEnX");
        builder.Property(e => e.CatDimensionZAplicaEnY).HasColumnName("cat_dimension_z_aplicaEnY");
        builder.Property(e => e.CatDimensionZAplicaEnZ).HasColumnName("cat_dimension_z_aplicaEnZ");
        builder.Property(e => e.CatDimensionZDimension)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_dimension_z_dimension");
        builder.Property(e => e.CatDimensionZDimensionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_dimension_z_dimension_codigo");
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
        builder.Property(e => e.IdCatalogoEquipoComponente).HasColumnName("id_catalogo.equipo_componente");
        builder.Property(e => e.IdCatalogoEquipoEquipo).HasColumnName("id_catalogo.equipo_equipo");
        builder.Property(e => e.IdDimensionX).HasColumnName("id_dimension_x");
        builder.Property(e => e.IdDimensionY).HasColumnName("id_dimension_y");
        builder.Property(e => e.IdDimensionZ).HasColumnName("id_dimension_z");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Posicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("posicion");
        builder.Property(e => e.PosicionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("posicion_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
