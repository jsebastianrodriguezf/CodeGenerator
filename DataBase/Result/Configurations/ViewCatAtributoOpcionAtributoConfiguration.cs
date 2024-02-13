using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatAtributoOpcionAtributoConfiguration : IEntityTypeConfiguration<ViewCatAtributoOpcionAtributo>
{
    public void Configure(EntityTypeBuilder<ViewCatAtributoOpcionAtributo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_atributo_opcionAtributo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.AtributoOpcionAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("atributo_opcionAtributo");
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
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquOpcionAtributoIdAtributo).HasColumnName("equ_opcionAtributo_id_atributo");
        builder.Property(e => e.EquOpcionAtributoOpcionAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_opcionAtributo_opcionAtributo");
        builder.Property(e => e.EquOpcionAtributoOpcionAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_opcionAtributo_opcionAtributo_codigo");
        builder.Property(e => e.EquOpcionAtributoOrden).HasColumnName("equ_opcionAtributo_orden");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdOpcionAtributo).HasColumnName("id_opcionAtributo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
