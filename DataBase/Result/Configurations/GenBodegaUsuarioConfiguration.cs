using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenBodegaUsuarioConfiguration : IEntityTypeConfiguration<GenBodegaUsuario>
{
    public void Configure(EntityTypeBuilder<GenBodegaUsuario> builder)
    {
        builder.ToTable("gen_bodega_usuario");

        builder.HasIndex(e => e.Eid, "IX_gen_bodega_usuario");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.BodegaUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("bodega_usuario");
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
        builder.Property(e => e.IdBodega).HasColumnName("id_bodega");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Sugerir).HasColumnName("sugerir");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdBodegaNavigation).WithMany(p => p.GenBodegaUsuarios)
            .HasForeignKey(d => d.IdBodega)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_bodega_usuario_id_bodega");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.GenBodegaUsuarios)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_bodega_usuario_id_usuario");
    }
}
