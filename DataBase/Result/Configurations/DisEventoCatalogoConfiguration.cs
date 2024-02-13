using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DisEventoCatalogoConfiguration : IEntityTypeConfiguration<DisEventoCatalogo>
{
    public void Configure(EntityTypeBuilder<DisEventoCatalogo> builder)
    {
        builder.ToTable("dis_evento_catalogo");

        builder.HasIndex(e => e.Eid, "IX_dis_evento_catalogo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquipoAuxiliar)
            .HasDefaultValue(true)
            .HasColumnName("equipoAuxiliar");
        builder.Property(e => e.EventoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("evento_catalogo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdEvento).HasColumnName("id_evento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(400)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("observaciones");
        builder.Property(e => e.Total).HasColumnName("total");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorUnitario).HasColumnName("valorUnitario");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.DisEventoCatalogos)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_catalogo_id_catalogo");

        builder.HasOne(d => d.IdEventoNavigation).WithMany(p => p.DisEventoCatalogos)
            .HasForeignKey(d => d.IdEvento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_evento_catalogo_id_evento");
    }
}
