using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocSoporteItemDocumentoConfiguration : IEntityTypeConfiguration<DocSoporteItemDocumento>
{
    public void Configure(EntityTypeBuilder<DocSoporteItemDocumento> builder)
    {
        builder.ToTable("doc_soporteItemDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_soporteItemDocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Costo).HasColumnType("money");
        builder.Property(e => e.DuracionEjecutada).HasColumnName("duracionEjecutada");
        builder.Property(e => e.DuracionPlaneada).HasColumnName("duracionPlaneada");
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
        builder.Property(e => e.HorasFestivas).HasColumnName("horasFestivas");
        builder.Property(e => e.HorasNocturnas).HasColumnName("horasNocturnas");
        builder.Property(e => e.HorasOrdinales).HasColumnName("horasOrdinales");
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Periodo)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("periodo");
        builder.Property(e => e.SoporteItemDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("soporteItemDocumento");
        builder.Property(e => e.SoporteItemDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("soporteItemDocumento_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor).HasColumnType("money");

        builder.HasOne(d => d.IdItemDocumentoNavigation).WithMany(p => p.DocSoporteItemDocumentos)
            .HasForeignKey(d => d.IdItemDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_soporteItemDocumento_id_itemDocumento");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.DocSoporteItemDocumentos)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_soporteItemDocumento_id_usuario");
    }
}
