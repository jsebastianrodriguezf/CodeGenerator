using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TaxNivelTaxConfiguration : IEntityTypeConfiguration<TaxNivelTax>
{
    public void Configure(EntityTypeBuilder<TaxNivelTax> builder)
    {
        builder.ToTable("tax_nivelTax");

        builder.HasIndex(e => e.Eid, "IX_tax_nivelTax");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ColumnaPrincipal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("columnaPrincipal");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsEquipo).HasColumnName("esEquipo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Filtro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("filtro");
        builder.Property(e => e.IdNivelTax).HasColumnName("id_nivelTax");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
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
            .HasDefaultValue("")
            .HasColumnName("tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdNivelTaxNavigation).WithMany(p => p.InverseIdNivelTaxNavigation)
            .HasForeignKey(d => d.IdNivelTax)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_tax_nivelTax_id_nivelTax");
    }
}
