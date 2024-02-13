using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenConfiguracionAtributoConfiguration : IEntityTypeConfiguration<GenConfiguracionAtributo>
{
    public void Configure(EntityTypeBuilder<GenConfiguracionAtributo> builder)
    {
        builder.ToTable("gen_configuracionAtributos");

        builder.HasIndex(e => e.Eid, "IX_gen_configuracionAtributos");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ConfiguracionAtributos)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("configuracionAtributos");
        builder.Property(e => e.ConfiguracionAtributosCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("configuracionAtributos_codigo");
        builder.Property(e => e.Defecto)
            .HasMaxLength(200)
            .HasDefaultValue("")
            .HasColumnName("defecto");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsObligatorio).HasColumnName("esObligatorio");
        builder.Property(e => e.EsResaltado).HasColumnName("esResaltado");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdFormulario).HasColumnName("id_formulario");
        builder.Property(e => e.IdTablaRelacion).HasColumnName("id_tabla_relacion");
        builder.Property(e => e.IdTablaResultado).HasColumnName("id_tabla_resultado");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.GenConfiguracionAtributos)
            .HasForeignKey(d => d.IdAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_configuracionAtributos_id_atributo");

        builder.HasOne(d => d.IdFormularioNavigation).WithMany(p => p.GenConfiguracionAtributos)
            .HasForeignKey(d => d.IdFormulario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_configuracionAtributos_id_formulario");

        builder.HasOne(d => d.IdTablaRelacionNavigation).WithMany(p => p.GenConfiguracionAtributoIdTablaRelacionNavigations)
            .HasForeignKey(d => d.IdTablaRelacion)
            .HasConstraintName("FK_gen_configuracionAtributos_id_tabla_relacion");

        builder.HasOne(d => d.IdTablaResultadoNavigation).WithMany(p => p.GenConfiguracionAtributoIdTablaResultadoNavigations)
            .HasForeignKey(d => d.IdTablaResultado)
            .HasConstraintName("FK_gen_configuracionAtributos_id_tabla_resultado");
    }
}
