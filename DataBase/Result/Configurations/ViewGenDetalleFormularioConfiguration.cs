using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenDetalleFormularioConfiguration : IEntityTypeConfiguration<ViewGenDetalleFormulario>
{
    public void Configure(EntityTypeBuilder<ViewGenDetalleFormulario> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_detalleFormulario");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Defecto)
            .HasMaxLength(200)
            .HasColumnName("defecto");
        builder.Property(e => e.DetalleFormulario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleFormulario");
        builder.Property(e => e.DetalleFormularioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleFormulario_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsObligatorio).HasColumnName("esObligatorio");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenColumnaColumna)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_columna_columna");
        builder.Property(e => e.GenColumnaColumnaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_columna_columna_codigo");
        builder.Property(e => e.GenColumnaEsNuleable).HasColumnName("gen_columna_esNuleable");
        builder.Property(e => e.GenColumnaIdTabla).HasColumnName("gen_columna_id_tabla");
        builder.Property(e => e.GenColumnaTamano).HasColumnName("gen_columna_tamano");
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
        builder.Property(e => e.GenTipoDatoTipoDato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_tipoDato_tipoDato");
        builder.Property(e => e.GenTipoDatoTipoDatoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_tipoDato_tipoDato_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdColumna).HasColumnName("id_columna");
        builder.Property(e => e.IdFormulario).HasColumnName("id_formulario");
        builder.Property(e => e.IdTipoDato).HasColumnName("id_tipoDato");
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
