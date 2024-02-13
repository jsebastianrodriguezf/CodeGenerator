using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatListaPrecioConfiguration : IEntityTypeConfiguration<ViewCatListaPrecio>
{
    public void Configure(EntityTypeBuilder<ViewCatListaPrecio> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_listaPrecio");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsPrivado).HasColumnName("esPrivado");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenMonedaAbreviatura)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("gen_moneda_abreviatura");
        builder.Property(e => e.GenMonedaCambio).HasColumnName("gen_moneda_cambio");
        builder.Property(e => e.GenMonedaMoneda)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_moneda_moneda");
        builder.Property(e => e.GenMonedaMonedaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_moneda_moneda_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdMoneda).HasColumnName("id_moneda");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ListaPrecio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("listaPrecio");
        builder.Property(e => e.ListaPrecioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("listaPrecio_codigo");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ParaCompra).HasColumnName("paraCompra");
        builder.Property(e => e.PorcentajeDescuento).HasColumnName("porcentajeDescuento");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
