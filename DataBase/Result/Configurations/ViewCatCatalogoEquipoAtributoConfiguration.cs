using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatCatalogoEquipoAtributoConfiguration : IEntityTypeConfiguration<ViewCatCatalogoEquipoAtributo>
{
    public void Configure(EntityTypeBuilder<ViewCatCatalogoEquipoAtributo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_catalogo_equipo_atributo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.BloquearCierreOt).HasColumnName("bloquearCierreOT");
        builder.Property(e => e.CatAtributoAtributo)
            .HasMaxLength(900)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_atributo");
        builder.Property(e => e.CatAtributoAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_atributo_codigo");
        builder.Property(e => e.CatAtributoEsObligatorio).HasColumnName("cat_atributo_esObligatorio");
        builder.Property(e => e.CatAtributoEsVariable).HasColumnName("cat_atributo_esVariable");
        builder.Property(e => e.CatAtributoIdSeccionAtributo).HasColumnName("cat_atributo_id_seccionAtributo");
        builder.Property(e => e.CatAtributoIdTipoAtributo).HasColumnName("cat_atributo_id_tipoAtributo");
        builder.Property(e => e.CatAtributoIdUnidad).HasColumnName("cat_atributo_id_unidad");
        builder.Property(e => e.CatAtributoNombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_nombreControl");
        builder.Property(e => e.CatAtributoResaltado).HasColumnName("cat_atributo_resaltado");
        builder.Property(e => e.CatAtributoValorMaximo).HasColumnName("cat_atributo_ValorMaximo");
        builder.Property(e => e.CatAtributoValorMinimo).HasColumnName("cat_atributo_valorMinimo");
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
        builder.Property(e => e.CatCatalogoEquipoIdSubTipoCatalogo).HasColumnName("cat_catalogo_equipo_id_subTipoCatalogo");
        builder.Property(e => e.CatCatalogoEquipoIdUnidad).HasColumnName("cat_catalogo_equipo_id_unidad");
        builder.Property(e => e.CatCatalogoEquipoManejaHorometro).HasColumnName("cat_catalogo.equipo_manejaHorometro");
        builder.Property(e => e.CatCatalogoEquipoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_equipo_precioVenta");
        builder.Property(e => e.CatCatalogoEquipoTiempoConsecucion).HasColumnName("cat_catalogo_equipo_tiempoConsecucion");
        builder.Property(e => e.CatalogoEquipoAtributo)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("catalogo.equipo_atributo");
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
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdCatalogoEquipo).HasColumnName("id_catalogo.equipo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MostrarApi).HasColumnName("mostrarAPI");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Unidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("unidad");
        builder.Property(e => e.ValorMinimo).HasColumnName("valorMinimo");
    }
}
