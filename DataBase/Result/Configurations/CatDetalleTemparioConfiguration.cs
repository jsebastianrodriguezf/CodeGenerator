using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatDetalleTemparioConfiguration : IEntityTypeConfiguration<CatDetalleTempario>
{
    public void Configure(EntityTypeBuilder<CatDetalleTempario> builder)
    {
        builder.ToTable("cat_detalleTempario");

        builder.HasIndex(e => e.Eid, "IX_cat_detalleTempario");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CantidadEstandar)
            .HasDefaultValue(1.0)
            .HasColumnName("cantidadEstandar");
        builder.Property(e => e.CantidadTropicalizada)
            .HasDefaultValue(1.0)
            .HasColumnName("cantidadTropicalizada");
        builder.Property(e => e.DetalleTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleTempario");
        builder.Property(e => e.DetalleTemparioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleTempario_codigo");
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
        builder.Property(e => e.IdCatalogoTempario).HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdDetalleTemparioPadre).HasColumnName("id_detalleTempario_padre");
        builder.Property(e => e.IdPruebaCheckList).HasColumnName("id_pruebaCheckList");
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Orden)
            .HasDefaultValue(1)
            .HasColumnName("orden");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.CatDetalleTemparios)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_detalleTempario_id_catalogo");

        builder.HasOne(d => d.IdCatalogoTemparioNavigation).WithMany(p => p.CatDetalleTemparios)
            .HasForeignKey(d => d.IdCatalogoTempario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_detalleTempario_id_catalogo_tempario");

        builder.HasOne(d => d.IdDetalleTemparioPadreNavigation).WithMany(p => p.InverseIdDetalleTemparioPadreNavigation)
            .HasForeignKey(d => d.IdDetalleTemparioPadre)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_detalleTempario_id_detalleTempario_padre");

        builder.HasOne(d => d.IdPruebaCheckListNavigation).WithMany(p => p.CatDetalleTemparios)
            .HasForeignKey(d => d.IdPruebaCheckList)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_detalleTempario_id_pruebaCheckList");

        builder.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.CatDetalleTemparios)
            .HasForeignKey(d => d.IdSistema)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_detalleTempario_id_sistema");
    }
}
