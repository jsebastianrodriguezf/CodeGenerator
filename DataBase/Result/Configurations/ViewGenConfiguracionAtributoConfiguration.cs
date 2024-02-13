using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenConfiguracionAtributoConfiguration : IEntityTypeConfiguration<ViewGenConfiguracionAtributo>
{
    public void Configure(EntityTypeBuilder<ViewGenConfiguracionAtributo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_configuracionAtributos");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatAtributoAtributo)
            .HasMaxLength(900)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_atributo");
        builder.Property(e => e.CatAtributoAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_atributo_codigo");
        builder.Property(e => e.CatAtributoEsObligatorio).HasColumnName("cat_atributo_esObligatorio");
        builder.Property(e => e.CatAtributoEsVariable).HasColumnName("cat_atributo_esVariable");
        builder.Property(e => e.CatAtributoIdSeccionAtributo).HasColumnName("cat_atributo_id_seccionAtributo");
        builder.Property(e => e.CatAtributoIdTipoAtributo).HasColumnName("cat_atributo_id_tipoAtributo");
        builder.Property(e => e.CatAtributoIdUnidad).HasColumnName("cat_atributo_id_unidad");
        builder.Property(e => e.CatAtributoNombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_atributo_nombreControl");
        builder.Property(e => e.CatAtributoResaltado).HasColumnName("cat_atributo_resaltado");
        builder.Property(e => e.CatAtributoValorMaximo).HasColumnName("cat_atributo_ValorMaximo");
        builder.Property(e => e.CatAtributoValorMinimo).HasColumnName("cat_atributo_valorMinimo");
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
            .HasColumnName("defecto");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsObligatorio).HasColumnName("esObligatorio");
        builder.Property(e => e.EsResaltado).HasColumnName("esResaltado");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenFormularioDuplicar).HasColumnName("gen_formulario_duplicar");
        builder.Property(e => e.GenFormularioEliminarIntermedias).HasColumnName("gen_formulario_eliminarIntermedias");
        builder.Property(e => e.GenFormularioFormulario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_formulario_formulario");
        builder.Property(e => e.GenFormularioFormularioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_formulario_formulario_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdFormulario).HasColumnName("id_formulario");
        builder.Property(e => e.IdTablaRelacion).HasColumnName("id_tabla_relacion");
        builder.Property(e => e.IdTablaResultado).HasColumnName("id_tabla_resultado");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
