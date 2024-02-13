using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoCotizacionConfiguration : IEntityTypeConfiguration<DocDocumentoCotizacion>
{
    public void Configure(EntityTypeBuilder<DocDocumentoCotizacion> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_cotizacion");

        builder.ToTable("doc_documento.cotizacion");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_cotizacion");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cargo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("cargo");
        builder.Property(e => e.Condiciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("condiciones");
        builder.Property(e => e.Contacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("contacto");
        builder.Property(e => e.DocumentoCotizacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.cotizacion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("email");
        builder.Property(e => e.Encabezado)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("encabezado");
        builder.Property(e => e.EsAiu).HasColumnName("esAIU");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioAsesor).HasColumnName("id_usuario_asesor");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Notas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("notas");
        builder.Property(e => e.ProcentajeA).HasColumnName("procentajeA");
        builder.Property(e => e.ProcentajeI).HasColumnName("procentajeI");
        builder.Property(e => e.ProcentajeU).HasColumnName("procentajeU");
        builder.Property(e => e.Telefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("telefono");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Validez)
            .HasDefaultValue(20)
            .HasColumnName("validez");
        builder.Property(e => e.ValorA).HasColumnName("valorA");
        builder.Property(e => e.ValorI).HasColumnName("valorI");
        builder.Property(e => e.ValorU).HasColumnName("valorU");
        builder.Property(e => e.Version)
            .HasDefaultValue(1)
            .HasColumnName("version");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.DocDocumentoCotizacions)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_cotizacion_id_equipo");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.DocDocumentoCotizacions)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_cotizacion_id_sucursal");

        builder.HasOne(d => d.IdUsuarioAsesorNavigation).WithMany(p => p.DocDocumentoCotizacions)
            .HasForeignKey(d => d.IdUsuarioAsesor)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_cotizacion_id_usuario_asesor");
    }
}
