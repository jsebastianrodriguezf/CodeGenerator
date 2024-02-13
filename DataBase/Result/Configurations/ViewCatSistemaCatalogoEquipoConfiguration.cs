using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatSistemaCatalogoEquipoConfiguration : IEntityTypeConfiguration<ViewCatSistemaCatalogoEquipo>
{
    public void Configure(EntityTypeBuilder<ViewCatSistemaCatalogoEquipo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_sistema_catalogo_equipo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoEquipoBloquearCostear).HasColumnName("cat_catalogo_equipo_bloquearCostear");
        builder.Property(e => e.CatCatalogoEquipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_catalogo_codigo");
        builder.Property(e => e.CatCatalogoEquipoCatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.equipo_catalogo.equipo");
        builder.Property(e => e.CatCatalogoEquipoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_codigoInventario");
        builder.Property(e => e.CatCatalogoEquipoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_descripcion");
        builder.Property(e => e.CatCatalogoEquipoEsNacional).HasColumnName("cat_catalogo_equipo_esNacional");
        builder.Property(e => e.CatCatalogoEquipoGarantiaHoras).HasColumnName("cat_catalogo.equipo_garantiaHoras");
        builder.Property(e => e.CatCatalogoEquipoGarantiaMeses).HasColumnName("cat_catalogo.equipo_garantiaMeses");
        builder.Property(e => e.CatCatalogoEquipoIdFamilia).HasColumnName("cat_catalogo_equipo_id_familia");
        builder.Property(e => e.CatCatalogoEquipoIdImpuesto).HasColumnName("cat_catalogo_equipo_id_impuesto");
        builder.Property(e => e.CatCatalogoEquipoIdMarca).HasColumnName("cat_catalogo.equipo_id_marca");
        builder.Property(e => e.CatCatalogoEquipoIdSubtipoCatalogo).HasColumnName("cat_catalogo_equipo_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoEquipoIdUnidad).HasColumnName("cat_catalogo_equipo_id_unidad");
        builder.Property(e => e.CatCatalogoEquipoManejaHorometro).HasColumnName("cat_catalogo.equipo_manejaHorometro");
        builder.Property(e => e.CatCatalogoEquipoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_equipo_precioVenta");
        builder.Property(e => e.CatCatalogoEquipoTiempoConsecucion).HasColumnName("cat_catalogo_equipo_tiempoConsecucion");
        builder.Property(e => e.CatSistemaSistema)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_sistema");
        builder.Property(e => e.CatSistemaSistemaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_sistema_sistema_codigo");
        builder.Property(e => e.CatVersionEquipoIdCatalogoEquipo).HasColumnName("cat_versionEquipo_id_catalogo.equipo");
        builder.Property(e => e.CatVersionEquipoVersionEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_versionEquipo_versionEquipo");
        builder.Property(e => e.CatVersionEquipoVersionEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_versionEquipo_versionEquipo_codigo");
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
        builder.Property(e => e.IdCatalogoEquipo).HasColumnName("id_catalogo.equipo");
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdVersionEquipo).HasColumnName("id_versionEquipo");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.SistemaCatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sistema_catalogo.equipo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
