using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatSistemaConfiguration : IEntityTypeConfiguration<CatSistema>
{
    public void Configure(EntityTypeBuilder<CatSistema> builder)
    {
        builder.ToTable("cat_sistema");

        builder.HasIndex(e => e.Eid, "IX_cat_sistema");

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
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Sistema)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sistema");
        builder.Property(e => e.SistemaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("sistema_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.InverseIdSistemaNavigation)
            .HasForeignKey(d => d.IdSistema)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_sistema_id_sistema");
    }
}
