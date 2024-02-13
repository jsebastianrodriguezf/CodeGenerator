using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoSolicitudConfiguration : IEntityTypeConfiguration<DocDocumentoSolicitud>
{
    public void Configure(EntityTypeBuilder<DocDocumentoSolicitud> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_solicitud");

        builder.ToTable("doc_documento.solicitud");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_solicitud");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cargo)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cargo");
        builder.Property(e => e.Direccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("direccion");
        builder.Property(e => e.DocumentoSolicitud)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.solicitud");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("email");
        builder.Property(e => e.Fax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("fax");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdDepartamentoSolicitud).HasColumnName("id_departamentoSolicitud");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdMedioSolicitud).HasColumnName("id_medioSolicitud");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.MotivoServicio)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("motivoServicio");
        builder.Property(e => e.Solicitante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("solicitante");
        builder.Property(e => e.SolucionTelefonica).HasColumnName("solucionTelefonica");
        builder.Property(e => e.Telefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("telefono");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDepartamentoSolicitudNavigation).WithMany(p => p.DocDocumentoSolicituds)
            .HasForeignKey(d => d.IdDepartamentoSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_solicitud_id_departamentoSolicitud");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.DocDocumentoSolicituds)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_solicitud_id_equipo");

        builder.HasOne(d => d.IdMedioSolicitudNavigation).WithMany(p => p.DocDocumentoSolicituds)
            .HasForeignKey(d => d.IdMedioSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_solicitud_id_medioSolicitud");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.DocDocumentoSolicituds)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_solicitud_id_sucursal");

        builder.HasOne(d => d.IdZonaNavigation).WithMany(p => p.DocDocumentoSolicituds)
            .HasForeignKey(d => d.IdZona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_solicitud_id_zona");
    }
}
