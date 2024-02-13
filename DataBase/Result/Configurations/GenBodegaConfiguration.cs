using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenBodegaConfiguration : IEntityTypeConfiguration<GenBodega>
{
    public void Configure(EntityTypeBuilder<GenBodega> builder)
    {
        builder.ToTable("gen_bodega");

        builder.HasIndex(e => e.Eid, "IX_gen_bodega");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Bodega)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("bodega");
        builder.Property(e => e.BodegaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("bodega_codigo");
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
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.SalidasEnRojo)
            .HasDefaultValue(true)
            .HasColumnName("salidasEnRojo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UsaLocalizacion).HasColumnName("usaLocalizacion");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.GenBodegas)
            .HasForeignKey(d => d.IdSucursal)
            .HasConstraintName("FK_gen_bodega_id_sucursal");
    }
}
