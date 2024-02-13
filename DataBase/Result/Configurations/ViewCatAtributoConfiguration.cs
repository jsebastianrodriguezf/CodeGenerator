using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatAtributoConfiguration : IEntityTypeConfiguration<ViewCatAtributo>
{
    public void Configure(EntityTypeBuilder<ViewCatAtributo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_atributo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Atributo)
            .HasMaxLength(900)
            .IsUnicode(false)
            .HasColumnName("atributo");
        builder.Property(e => e.AtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("atributo_codigo");
        builder.Property(e => e.CatSeccionAtributoIdUsoSeccionAtributo).HasColumnName("cat_seccionAtributo_id_usoSeccionAtributo");
        builder.Property(e => e.CatSeccionAtributoOrden).HasColumnName("cat_seccionAtributo_orden");
        builder.Property(e => e.CatSeccionAtributoSeccionAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_seccionAtributo_seccionAtributo");
        builder.Property(e => e.CatSeccionAtributoSeccionAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_seccionAtributo_seccionAtributo_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquTipoAtributoPrefijoControl)
            .HasMaxLength(3)
            .IsUnicode(false)
            .HasColumnName("equ_tipoAtributo_prefijoControl");
        builder.Property(e => e.EquTipoAtributoTipoAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_tipoAtributo_tipoAtributo");
        builder.Property(e => e.EquTipoAtributoTipoAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_tipoAtributo_tipoAtributo_codigo");
        builder.Property(e => e.EsObligatorio).HasColumnName("esObligatorio");
        builder.Property(e => e.EsVariable).HasColumnName("esVariable");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenUnidadUnidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_unidad_unidad");
        builder.Property(e => e.GenUnidadUnidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_unidad_unidad_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdSeccionAtributo).HasColumnName("id_seccionAtributo");
        builder.Property(e => e.IdTipoAtributo).HasColumnName("id_tipoAtributo");
        builder.Property(e => e.IdUnidad).HasColumnName("id_unidad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.NombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("nombreControl");
        builder.Property(e => e.Resaltado).HasColumnName("resaltado");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorMinimo).HasColumnName("valorMinimo");
    }
}
