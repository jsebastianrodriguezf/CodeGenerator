using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDisEventoCatalogoConfiguration : IEntityTypeConfiguration<ViewDisEventoCatalogo>
{
    public void Configure(EntityTypeBuilder<ViewDisEventoCatalogo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_dis_evento_catalogo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
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
        builder.Property(e => e.CatCatalogoIdSubTipoCatalogo).HasColumnName("cat_catalogo_id_subTipoCatalogo");
        builder.Property(e => e.CatCatalogoIdUnidad).HasColumnName("cat_catalogo_id_unidad");
        builder.Property(e => e.CatCatalogoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_precioVenta");
        builder.Property(e => e.CatCatalogoTiempoConsecucion).HasColumnName("cat_catalogo_tiempoConsecucion");
        builder.Property(e => e.DisEventoAfectaCliente).HasColumnName("dis_evento_afectaCliente");
        builder.Property(e => e.DisEventoAfectaProduccion).HasColumnName("dis_evento_afectaProduccion");
        builder.Property(e => e.DisEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_evento_codigo");
        builder.Property(e => e.DisEventoDuracionHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_duracion_hh");
        builder.Property(e => e.DisEventoEvento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("dis_evento_evento");
        builder.Property(e => e.DisEventoEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_evento_evento_codigo");
        builder.Property(e => e.DisEventoEventoTipo).HasColumnName("dis_evento_eventoTipo");
        builder.Property(e => e.DisEventoFechaHoraEstimadaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_fechaHoraEstimada_fh");
        builder.Property(e => e.DisEventoFechaHoraInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_fechaHoraInicio_ff");
        builder.Property(e => e.DisEventoIdEquipo).HasColumnName("dis_evento_id_equipo");
        builder.Property(e => e.DisEventoIdEstadoEquipo).HasColumnName("dis_evento_id_estadoEquipo");
        builder.Property(e => e.DisEventoIdEstadoEvento).HasColumnName("dis_evento_id_estadoEvento");
        builder.Property(e => e.DisEventoIdFalla).HasColumnName("dis_evento_id_falla");
        builder.Property(e => e.DisEventoIdFallaCausa).HasColumnName("dis_evento_id_falla_causa");
        builder.Property(e => e.DisEventoIdMetodoDeteccion).HasColumnName("dis_evento_id_metodoDeteccion");
        builder.Property(e => e.DisEventoIdMotivoEvento).HasColumnName("dis_evento_id_motivoEvento");
        builder.Property(e => e.DisEventoIdUsuario).HasColumnName("dis_evento_id_usuario");
        builder.Property(e => e.DisEventoNotas)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("dis_evento_notas");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquipoAuxiliar).HasColumnName("equipoAuxiliar");
        builder.Property(e => e.EventoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("evento_catalogo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdEvento).HasColumnName("id_evento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(400)
            .IsUnicode(false)
            .HasColumnName("observaciones");
        builder.Property(e => e.Total).HasColumnName("total");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorUnitario).HasColumnName("valorUnitario");
    }
}
