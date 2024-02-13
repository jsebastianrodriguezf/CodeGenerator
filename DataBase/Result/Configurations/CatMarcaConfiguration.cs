using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatMarcaConfiguration : IEntityTypeConfiguration<CatMarca>
{
    public void Configure(EntityTypeBuilder<CatMarca> builder)
    {
        builder.ToTable("cat_marca");

        builder.HasIndex(e => e.Eid, "IX_cat_marca");

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
        builder.Property(e => e.IdTerceroFabricante).HasColumnName("id_tercero_fabricante");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Marca)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("marca");
        builder.Property(e => e.MarcaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("marca_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdTerceroFabricanteNavigation).WithMany(p => p.CatMarcas)
            .HasForeignKey(d => d.IdTerceroFabricante)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_marca_id_tercero_fabricante");
    }
}
