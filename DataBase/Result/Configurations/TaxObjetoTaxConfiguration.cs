using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TaxObjetoTaxConfiguration : IEntityTypeConfiguration<TaxObjetoTax>
{
    public void Configure(EntityTypeBuilder<TaxObjetoTax> builder)
    {
        builder.ToTable("tax_objetoTax");

        builder.HasIndex(e => e.Eid, "IX_tax_objetoTax");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdNivelTax).HasColumnName("id_nivelTax");
        builder.Property(e => e.IdObjTax).HasColumnName("id_objTax");
        builder.Property(e => e.IdTablaTax).HasColumnName("id_tablaTax");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
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
            .HasDefaultValue("")
            .HasColumnName("tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdNivelTaxNavigation).WithMany(p => p.TaxObjetoTaxes)
            .HasForeignKey(d => d.IdNivelTax)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_tax_objetoTax_id_nivelTax");
    }
}
