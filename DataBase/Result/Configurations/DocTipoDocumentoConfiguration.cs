using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocTipoDocumentoConfiguration : IEntityTypeConfiguration<DocTipoDocumento>
{
    public void Configure(EntityTypeBuilder<DocTipoDocumento> builder)
    {
        builder.ToTable("doc_tipoDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_tipoDocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsSalida).HasColumnName("esSalida");
        builder.Property(e => e.EsUrgente)
            .HasDefaultValue(true)
            .HasColumnName("esUrgente");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MostrarBodega).HasColumnName("mostrarBodega");
        builder.Property(e => e.MostrarCentroCosto).HasColumnName("mostrarCentroCosto");
        builder.Property(e => e.MostrarIncoterm).HasColumnName("mostrarIncoterm");
        builder.Property(e => e.PuedeSerMayor)
            .HasDefaultValue(true)
            .HasColumnName("puedeSerMayor");
        builder.Property(e => e.PuedeSerMenor)
            .HasDefaultValue(true)
            .HasColumnName("puedeSerMenor");
        builder.Property(e => e.TipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tipoDocumento");
        builder.Property(e => e.TipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tipoDocumento_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
