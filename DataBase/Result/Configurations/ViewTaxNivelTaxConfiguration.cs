using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewTaxNivelTaxConfiguration : IEntityTypeConfiguration<ViewTaxNivelTax>
{
    public void Configure(EntityTypeBuilder<ViewTaxNivelTax> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_tax_nivelTax");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.ColumnaPrincipal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("columnaPrincipal");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsEquipo).HasColumnName("esEquipo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Filtro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("filtro");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdNivelTax).HasColumnName("id_nivelTax");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.NivelTax)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("nivelTax");
        builder.Property(e => e.NivelTaxCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("nivelTax_codigo");
        builder.Property(e => e.Tabla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tabla");
        builder.Property(e => e.TaxNivelTaxPadreColumnaPrincipal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tax_nivelTax_padre_columnaPrincipal");
        builder.Property(e => e.TaxNivelTaxPadreEsEquipo).HasColumnName("tax_nivelTax_padre_esEquipo");
        builder.Property(e => e.TaxNivelTaxPadreFiltro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tax_nivelTax_padre_filtro");
        builder.Property(e => e.TaxNivelTaxPadreIdNivelTax).HasColumnName("tax_nivelTax_padre_id_nivelTax");
        builder.Property(e => e.TaxNivelTaxPadreNivelTax)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tax_nivelTax_padre_nivelTax");
        builder.Property(e => e.TaxNivelTaxPadreNivelTaxCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tax_nivelTax_padre_nivelTax_codigo");
        builder.Property(e => e.TaxNivelTaxPadreTabla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tax_nivelTax_padre_tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
