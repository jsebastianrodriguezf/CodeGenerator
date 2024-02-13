using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class LicCatalogoParametroConfiguration : IEntityTypeConfiguration<LicCatalogoParametro>
{
    public void Configure(EntityTypeBuilder<LicCatalogoParametro> builder)
    {
        builder.ToTable("lic_catalogo_parametro");

        builder.HasIndex(e => e.Eid, "IX_lic_catalogo_parametro");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CatalogoParametro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo_parametro");
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
        builder.Property(e => e.IdParametro).HasColumnName("id_parametro");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorXdefecto)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("valorXdefecto");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.LicCatalogoParametros)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_lic_catalogo_parametro_id_catalogo");

        builder.HasOne(d => d.IdParametroNavigation).WithMany(p => p.LicCatalogoParametros)
            .HasForeignKey(d => d.IdParametro)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_lic_catalogo_parametro_id_parametro");
    }
}
