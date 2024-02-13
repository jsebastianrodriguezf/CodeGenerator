using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntContratoCatalogoConfiguration : IEntityTypeConfiguration<CntContratoCatalogo>
{
    public void Configure(EntityTypeBuilder<CntContratoCatalogo> builder)
    {
        builder.ToTable("cnt_contrato_catalogo");

        builder.HasIndex(e => e.Eid, "IX_cnt_contrato_catalogo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Consumida)
            .HasDefaultValue(0.0)
            .HasColumnName("consumida");
        builder.Property(e => e.ContratoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contrato_catalogo");
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
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Incluida)
            .HasDefaultValue(0.0)
            .HasColumnName("incluida");
        builder.Property(e => e.Notas)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("notas");
        builder.Property(e => e.PrecioVenta)
            .HasDefaultValue(0m)
            .HasColumnType("money")
            .HasColumnName("precioVenta");
        builder.Property(e => e.Saldo)
            .HasDefaultValue(0.0)
            .HasColumnName("saldo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.CntContratoCatalogos)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_catalogo_id_catalogo");

        builder.HasOne(d => d.IdContratoNavigation).WithMany(p => p.CntContratoCatalogos)
            .HasForeignKey(d => d.IdContrato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_catalogo_id_contrato");
    }
}
