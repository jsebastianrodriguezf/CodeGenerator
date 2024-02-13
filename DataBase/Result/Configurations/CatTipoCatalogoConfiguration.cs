using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatTipoCatalogoConfiguration : IEntityTypeConfiguration<CatTipoCatalogo>
{
    public void Configure(EntityTypeBuilder<CatTipoCatalogo> builder)
    {
        builder.ToTable("cat_tipoCatalogo");

        builder.HasIndex(e => e.Eid, "IX_cat_tipoCatalogo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AfectaInventario)
            .HasDefaultValue(true)
            .HasColumnName("afectaInventario");
        builder.Property(e => e.AfectaProduccion)
            .HasDefaultValue(true)
            .HasColumnName("afectaProduccion");
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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.TipoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tipoCatalogo");
        builder.Property(e => e.TipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tipoCatalogo_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
