using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewTaxObjetoTaxConfiguration : IEntityTypeConfiguration<ViewTaxObjetoTax>
{
    public void Configure(EntityTypeBuilder<ViewTaxObjetoTax> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_tax_objetoTax");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.IdNivelTax).HasColumnName("id_nivelTax");
        builder.Property(e => e.IdObjTax).HasColumnName("id_ObjTax");
        builder.Property(e => e.IdObjTax1).HasColumnName("idObjTax");
        builder.Property(e => e.IdTablaTax).HasColumnName("idTablaTax");
        builder.Property(e => e.IdTablaTax1).HasColumnName("id_TablaTax");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ObjetoTax)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("objetoTax");
        builder.Property(e => e.ObjetoTaxCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("objetoTax_codigo");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Tabla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tabla");
        builder.Property(e => e.TaxNivelTaxColumnaPrincipal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tax_nivelTax_columnaPrincipal");
        builder.Property(e => e.TaxNivelTaxEsEquipo).HasColumnName("tax_nivelTax_esEquipo");
        builder.Property(e => e.TaxNivelTaxFiltro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tax_nivelTax_filtro");
        builder.Property(e => e.TaxNivelTaxIdNivelTax).HasColumnName("tax_nivelTax_id_nivelTax");
        builder.Property(e => e.TaxNivelTaxNivelTax)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tax_nivelTax_nivelTax");
        builder.Property(e => e.TaxNivelTaxNivelTaxCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tax_nivelTax_nivelTax_codigo");
        builder.Property(e => e.TaxNivelTaxTabla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tax_nivelTax_tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
