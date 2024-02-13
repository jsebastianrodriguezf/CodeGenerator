using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatReemplazoConfiguration : IEntityTypeConfiguration<CatReemplazo>
{
    public void Configure(EntityTypeBuilder<CatReemplazo> builder)
    {
        builder.ToTable("cat_reemplazo");

        builder.HasIndex(e => e.Eid, "IX_cat_reemplazo");

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
        builder.Property(e => e.IdCatalogoRepuesto).HasColumnName("id_catalogo.repuesto");
        builder.Property(e => e.IdCatalogoRepuesto1).HasColumnName("id_catalogo.repuesto_1");
        builder.Property(e => e.IdTipoReemplazo).HasColumnName("id_tipoReemplazo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Reemplazo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("reemplazo");
        builder.Property(e => e.ReemplazoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("reemplazo_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoRepuestoNavigation).WithMany(p => p.CatReemplazoIdCatalogoRepuestoNavigations)
            .HasForeignKey(d => d.IdCatalogoRepuesto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_reemplazo_id_catalogo_repuesto");

        builder.HasOne(d => d.IdCatalogoRepuesto1Navigation).WithMany(p => p.CatReemplazoIdCatalogoRepuesto1Navigations)
            .HasForeignKey(d => d.IdCatalogoRepuesto1)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_reemplazo_id_catalogo_repuesto_1");

        builder.HasOne(d => d.IdTipoReemplazoNavigation).WithMany(p => p.CatReemplazos)
            .HasForeignKey(d => d.IdTipoReemplazo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_reemplazo_id_tipoReemplazo");
    }
}
