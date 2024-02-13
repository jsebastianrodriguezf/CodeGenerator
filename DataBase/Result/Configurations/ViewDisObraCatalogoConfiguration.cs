using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDisObraCatalogoConfiguration : IEntityTypeConfiguration<ViewDisObraCatalogo>
{
    public void Configure(EntityTypeBuilder<ViewDisObraCatalogo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_dis_obra_catalogo");

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
        builder.Property(e => e.CatCatalogoIdSubtipoCatalogo).HasColumnName("cat_catalogo_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoIdUnidad).HasColumnName("cat_catalogo_id_unidad");
        builder.Property(e => e.CatCatalogoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_precioVenta");
        builder.Property(e => e.CatCatalogoTiempoConsecucion).HasColumnName("cat_catalogo_tiempoConsecucion");
        builder.Property(e => e.DisObraFechaFinalFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_obra_fechaFinal_ff");
        builder.Property(e => e.DisObraFechaInicialFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_obra_fechaInicial_ff");
        builder.Property(e => e.DisObraIdSucursal).HasColumnName("dis_obra_id_sucursal");
        builder.Property(e => e.DisObraObra)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("dis_obra_obra");
        builder.Property(e => e.DisObraObraCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_obra_obra_codigo");
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
        builder.Property(e => e.IdObra).HasColumnName("id_obra");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ObraCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("obra_catalogo");
        builder.Property(e => e.PromedioDia).HasColumnName("promedioDia");
        builder.Property(e => e.Total).HasColumnName("total");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorMaximo).HasColumnName("valorMaximo");
        builder.Property(e => e.ValorMinimo).HasColumnName("valorMinimo");
        builder.Property(e => e.ValorUnitario).HasColumnName("valorUnitario");
    }
}
