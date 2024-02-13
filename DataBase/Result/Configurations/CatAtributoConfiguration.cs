using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatAtributoConfiguration : IEntityTypeConfiguration<CatAtributo>
{
    public void Configure(EntityTypeBuilder<CatAtributo> builder)
    {
        builder.ToTable("cat_atributo");

        builder.HasIndex(e => e.Eid, "IX_cat_atributo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Atributo)
            .HasMaxLength(900)
            .IsUnicode(false)
            .HasColumnName("atributo");
        builder.Property(e => e.AtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("atributo_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsObligatorio).HasColumnName("esObligatorio");
        builder.Property(e => e.EsVariable)
            .HasDefaultValue(true)
            .HasColumnName("esVariable");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdSeccionAtributo).HasColumnName("id_seccionAtributo");
        builder.Property(e => e.IdTipoAtributo).HasColumnName("id_tipoAtributo");
        builder.Property(e => e.IdUnidad).HasColumnName("id_unidad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.NombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("nombreControl");
        builder.Property(e => e.Resaltado)
            .HasDefaultValue(true)
            .HasColumnName("resaltado");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorMaximo).HasDefaultValue(0.0);
        builder.Property(e => e.ValorMinimo)
            .HasDefaultValue(0.0)
            .HasColumnName("valorMinimo");

        builder.HasOne(d => d.IdSeccionAtributoNavigation).WithMany(p => p.CatAtributos)
            .HasForeignKey(d => d.IdSeccionAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_atributo_id_seccionAtributo");

        builder.HasOne(d => d.IdTipoAtributoNavigation).WithMany(p => p.CatAtributos)
            .HasForeignKey(d => d.IdTipoAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_atributo_id_tipoAtributo");

        builder.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.CatAtributos)
            .HasForeignKey(d => d.IdUnidad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_atributo_id_unidad");
    }
}
