using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatSeccionAtributoConfiguration : IEntityTypeConfiguration<CatSeccionAtributo>
{
    public void Configure(EntityTypeBuilder<CatSeccionAtributo> builder)
    {
        builder.ToTable("cat_seccionAtributo");

        builder.HasIndex(e => e.Eid, "IX_cat_seccionAtributo");

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
        builder.Property(e => e.IdUsoSeccionAtributo).HasColumnName("id_usoSeccionAtributo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.SeccionAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seccionAtributo");
        builder.Property(e => e.SeccionAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seccionAtributo_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdUsoSeccionAtributoNavigation).WithMany(p => p.CatSeccionAtributos)
            .HasForeignKey(d => d.IdUsoSeccionAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_seccionAtributo_id_usoSeccionAtributo");
    }
}
