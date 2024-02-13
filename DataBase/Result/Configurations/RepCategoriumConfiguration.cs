using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class RepCategoriumConfiguration : IEntityTypeConfiguration<RepCategorium>
{
    public void Configure(EntityTypeBuilder<RepCategorium> builder)
    {
        builder.ToTable("rep_categoria");

        builder.HasIndex(e => e.Eid, "IX_rep_categoria");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Categoria)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("categoria");
        builder.Property(e => e.CategoriaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("categoria_codigo");
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
        builder.Property(e => e.IdCategoria).HasColumnName("id_categoria");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.InverseIdCategoriaNavigation)
            .HasForeignKey(d => d.IdCategoria)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_rep_categoria_id_categoria");
    }
}
