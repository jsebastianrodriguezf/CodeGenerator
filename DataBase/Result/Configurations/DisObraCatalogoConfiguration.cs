using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DisObraCatalogoConfiguration : IEntityTypeConfiguration<DisObraCatalogo>
{
    public void Configure(EntityTypeBuilder<DisObraCatalogo> builder)
    {
        builder.ToTable("dis_obra_catalogo");

        builder.HasIndex(e => e.Eid, "IX_dis_obra_catalogo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
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
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdObra).HasColumnName("id_obra");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ObraCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("obra_catalogo");
        builder.Property(e => e.PromedioDia).HasColumnName("promedioDia");
        builder.Property(e => e.Total).HasColumnName("total");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorMaximo)
            .HasDefaultValue(0.0)
            .HasColumnName("valorMaximo");
        builder.Property(e => e.ValorMinimo)
            .HasDefaultValue(0.0)
            .HasColumnName("valorMinimo");
        builder.Property(e => e.ValorUnitario).HasColumnName("valorUnitario");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.DisObraCatalogos)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_obra_catalogo_id_catalogo");

        builder.HasOne(d => d.IdObraNavigation).WithMany(p => p.DisObraCatalogos)
            .HasForeignKey(d => d.IdObra)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_obra_catalogo_id_obra");
    }
}
