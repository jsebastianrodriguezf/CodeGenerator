using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntVisitaFijaCatalogoConfiguration : IEntityTypeConfiguration<CntVisitaFijaCatalogo>
{
    public void Configure(EntityTypeBuilder<CntVisitaFijaCatalogo> builder)
    {
        builder.ToTable("cnt_visitaFija_catalogo");

        builder.HasIndex(e => e.Eid, "IX_cnt_visitaFija_catalogo");

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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdVisitaFija).HasColumnName("id_visitaFija");
        builder.Property(e => e.Precio).HasColumnName("precio");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.VisitaFijaCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("visitaFija_catalogo");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.CntVisitaFijaCatalogos)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_visitaFija_catalogo_id_catalogo");

        builder.HasOne(d => d.IdVisitaFijaNavigation).WithMany(p => p.CntVisitaFijaCatalogos)
            .HasForeignKey(d => d.IdVisitaFija)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_visitaFija_catalogo_id_visitaFija");
    }
}
