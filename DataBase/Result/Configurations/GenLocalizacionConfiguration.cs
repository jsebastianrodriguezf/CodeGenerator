using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenLocalizacionConfiguration : IEntityTypeConfiguration<GenLocalizacion>
{
    public void Configure(EntityTypeBuilder<GenLocalizacion> builder)
    {
        builder.ToTable("gen_localizacion");

        builder.HasIndex(e => e.Eid, "IX_gen_localizacion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Existencia).HasColumnName("existencia");
        builder.Property(e => e.ExistenciaMaxima).HasColumnName("existenciaMaxima");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdCatalogoBodega).HasColumnName("id_catalogo_bodega");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Localizacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("localizacion");
        builder.Property(e => e.LocalizacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("localizacion_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
