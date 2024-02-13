using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquAnalisisFallaConfiguration : IEntityTypeConfiguration<ViewEquAnalisisFalla>
{
    public void Configure(EntityTypeBuilder<ViewEquAnalisisFalla> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_analisisFalla");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AnalisisFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("analisisFalla");
        builder.Property(e => e.AnalisisFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("analisisFalla_codigo");
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
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquFallaCausaFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_causa_falla");
        builder.Property(e => e.EquFallaCausaFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_causa_falla_codigo");
        builder.Property(e => e.EquFallaCausaIdFalla).HasColumnName("equ_falla_causa_id_falla");
        builder.Property(e => e.EquFallaCausaIdTipoFalla).HasColumnName("equ_falla_causa_id_tipoFalla");
        builder.Property(e => e.EquFallaCausaProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_causa_procedimiento");
        builder.Property(e => e.EquFallaEfectoFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_efecto_falla");
        builder.Property(e => e.EquFallaEfectoFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_efecto_falla_codigo");
        builder.Property(e => e.EquFallaEfectoIdFalla).HasColumnName("equ_falla_efecto_id_falla");
        builder.Property(e => e.EquFallaEfectoIdTipoFalla).HasColumnName("equ_falla_efecto_id_tipoFalla");
        builder.Property(e => e.EquFallaEfectoProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_efecto_procedimiento");
        builder.Property(e => e.EquFallaFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_falla");
        builder.Property(e => e.EquFallaFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_falla_codigo");
        builder.Property(e => e.EquFallaIdFalla).HasColumnName("equ_falla_id_falla");
        builder.Property(e => e.EquFallaIdTipoFalla).HasColumnName("equ_falla_id_tipoFalla");
        builder.Property(e => e.EquFallaProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_procedimiento");
        builder.Property(e => e.EquFallaSolucionFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_solucion_falla");
        builder.Property(e => e.EquFallaSolucionFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_solucion_falla_codigo");
        builder.Property(e => e.EquFallaSolucionIdFalla).HasColumnName("equ_falla_solucion_id_falla");
        builder.Property(e => e.EquFallaSolucionIdTipoFalla).HasColumnName("equ_falla_solucion_id_tipoFalla");
        builder.Property(e => e.EquFallaSolucionProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_solucion_procedimiento");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCatalogoEquipo).HasColumnName("id_catalogo.equipo");
        builder.Property(e => e.IdFalla).HasColumnName("id_falla");
        builder.Property(e => e.IdFallaCausa).HasColumnName("id_falla_causa");
        builder.Property(e => e.IdFallaEfecto).HasColumnName("id_falla_efecto");
        builder.Property(e => e.IdFallaSolucion).HasColumnName("id_falla_solucion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
