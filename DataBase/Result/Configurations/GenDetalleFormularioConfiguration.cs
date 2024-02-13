using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenDetalleFormularioConfiguration : IEntityTypeConfiguration<GenDetalleFormulario>
{
    public void Configure(EntityTypeBuilder<GenDetalleFormulario> builder)
    {
        builder.ToTable("gen_detalleFormulario");

        builder.HasIndex(e => e.Eid, "IX_gen_detalleFormulario");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Defecto)
            .HasMaxLength(200)
            .HasDefaultValue("")
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
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdColumna).HasColumnName("id_columna");
        builder.Property(e => e.IdFormulario).HasColumnName("id_formulario");
        builder.Property(e => e.IdTipoDato).HasColumnName("id_tipoDato");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdColumnaNavigation).WithMany(p => p.GenDetalleFormularios)
            .HasForeignKey(d => d.IdColumna)
            .HasConstraintName("FK_gen_detalleFormulario_id_columna");

        builder.HasOne(d => d.IdFormularioNavigation).WithMany(p => p.GenDetalleFormularios)
            .HasForeignKey(d => d.IdFormulario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_detalleFormulario_id_formulario");

        builder.HasOne(d => d.IdTipoDatoNavigation).WithMany(p => p.GenDetalleFormularios)
            .HasForeignKey(d => d.IdTipoDato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_detalleFormulario_id_tipoDato");
    }
}
