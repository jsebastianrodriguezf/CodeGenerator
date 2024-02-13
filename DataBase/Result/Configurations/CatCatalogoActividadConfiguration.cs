using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatCatalogoActividadConfiguration : IEntityTypeConfiguration<CatCatalogoActividad>
{
    public void Configure(EntityTypeBuilder<CatCatalogoActividad> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_cat_catalogo_actividad");

        builder.ToTable("cat_catalogo.actividad");

        builder.HasIndex(e => e.Eid, "IX_cat_catalogo_actividad");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CatalogoActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.actividad");
        builder.Property(e => e.DiasGarantia).HasColumnName("dias_garantia");
        builder.Property(e => e.DuracionEstimada).HasColumnName("duracionEstimada");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsProductiva).HasColumnName("esProductiva");
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
        builder.Property(e => e.Procedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("procedimiento");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
