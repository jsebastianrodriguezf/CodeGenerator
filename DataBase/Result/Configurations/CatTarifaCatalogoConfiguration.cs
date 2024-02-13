using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatTarifaCatalogoConfiguration : IEntityTypeConfiguration<CatTarifaCatalogo>
{
    public void Configure(EntityTypeBuilder<CatTarifaCatalogo> builder)
    {
        builder.ToTable("cat_tarifaCatalogo");

        builder.HasIndex(e => e.Eid, "IX_cat_tarifaCatalogo");

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
        builder.Property(e => e.IdCatalogoElemento).HasColumnName("id_catalogo_elemento");
        builder.Property(e => e.IdCatalogoTarifa).HasColumnName("id_catalogo_tarifa");
        builder.Property(e => e.IdTipotarifa).HasColumnName("id_tipotarifa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.TarifaCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tarifaCatalogo");
        builder.Property(e => e.TarifaCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tarifaCatalogo_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
