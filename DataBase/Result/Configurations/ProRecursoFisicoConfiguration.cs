using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProRecursoFisicoConfiguration : IEntityTypeConfiguration<ProRecursoFisico>
{
    public void Configure(EntityTypeBuilder<ProRecursoFisico> builder)
    {
        builder.ToTable("pro_recursoFisico");

        builder.HasIndex(e => e.Eid, "IX_pro_recursoFisico");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Costo).HasColumnName("costo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsPropio).HasColumnName("esPropio");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.RecursoFisico)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("recursoFisico");
        builder.Property(e => e.RecursoFisicoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("recursoFisico_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UnidadTiempo)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("unidadTiempo");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.ProRecursoFisicos)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_pro_recursoFisico_id_catalogo");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.ProRecursoFisicos)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("fk_pro_recursoFisico_id_equipo");
    }
}
