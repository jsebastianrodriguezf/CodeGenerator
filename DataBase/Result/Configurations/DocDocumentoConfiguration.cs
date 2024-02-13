using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoConfiguration : IEntityTypeConfiguration<DocDocumento>
{
    public void Configure(EntityTypeBuilder<DocDocumento> builder)
    {
        builder.ToTable("doc_documento");

        builder.HasIndex(e => e.Eid, "IX_doc_documento");

        builder.HasIndex(e => e.IdDocumento, "IX_id_documento");

        builder.HasIndex(e => e.IdTerceroCliente, "IX_id_tercero_cliente");

        builder.HasIndex(e => e.IdTerceroProveedor, "IX_id_tercero_proveedor");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Costo).HasColumnName("costo");
        builder.Property(e => e.CostoPlaneado).HasColumnName("costoPlaneado");
        builder.Property(e => e.Descuento).HasColumnName("descuento");
        builder.Property(e => e.DescuentoPlaneado).HasColumnName("descuentoPlaneado");
        builder.Property(e => e.Documento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento");
        builder.Property(e => e.DocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("documento_codigo");
        builder.Property(e => e.DocumentoNumero).HasColumnName("documento_numero");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCierreFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCierre_ff");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_fh");
        builder.Property(e => e.FechaLimiteFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaLimite_fh");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaSugeridaFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaSugerida_fh");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdMoneda).HasColumnName("id_moneda");
        builder.Property(e => e.IdMotivoestado).HasColumnName("id_motivoestado");
        builder.Property(e => e.IdPrioridadDocumento).HasColumnName("id_prioridadDocumento");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdTerceroCliente).HasColumnName("id_tercero_cliente");
        builder.Property(e => e.IdTerceroProveedor).HasColumnName("id_tercero_proveedor");
        builder.Property(e => e.IdUsuarioAsignado).HasColumnName("id_usuario_asignado");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioEnUso).HasColumnName("id_usuario_enUso");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Iva).HasColumnName("iva");
        builder.Property(e => e.IvaPlaneado).HasColumnName("ivaPlaneado");
        builder.Property(e => e.Prefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("((50))")
            .HasColumnName("prefijo");
        builder.Property(e => e.Rentabilidad).HasColumnName("rentabilidad");
        builder.Property(e => e.Subtotal).HasColumnName("subtotal");
        builder.Property(e => e.SubtotalPlaneado).HasColumnName("subtotalPlaneado");
        builder.Property(e => e.Total).HasColumnName("total");
        builder.Property(e => e.TotalPlaneado).HasColumnName("totalPlaneado");
        builder.Property(e => e.Trm).HasColumnName("trm");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.InverseIdDocumentoNavigation)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_id_documento");

        builder.HasOne(d => d.IdEstadoTipoDocumentoNavigation).WithMany(p => p.DocDocumentos)
            .HasForeignKey(d => d.IdEstadoTipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_id_estadoTipoDocumento");

        builder.HasOne(d => d.IdMonedaNavigation).WithMany(p => p.DocDocumentos)
            .HasForeignKey(d => d.IdMoneda)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_id_moneda");

        builder.HasOne(d => d.IdMotivoestadoNavigation).WithMany(p => p.DocDocumentos)
            .HasForeignKey(d => d.IdMotivoestado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_id_motivoestado");

        builder.HasOne(d => d.IdPrioridadDocumentoNavigation).WithMany(p => p.DocDocumentos)
            .HasForeignKey(d => d.IdPrioridadDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_id_prioridadDocumento");

        builder.HasOne(d => d.IdSubtipoDocumentoNavigation).WithMany(p => p.DocDocumentos)
            .HasForeignKey(d => d.IdSubtipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_id_subtipoDocumento");

        builder.HasOne(d => d.IdTerceroClienteNavigation).WithMany(p => p.DocDocumentoIdTerceroClienteNavigations)
            .HasForeignKey(d => d.IdTerceroCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_id_tercero_cliente");

        builder.HasOne(d => d.IdTerceroProveedorNavigation).WithMany(p => p.DocDocumentoIdTerceroProveedorNavigations)
            .HasForeignKey(d => d.IdTerceroProveedor)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_id_tercero_proveedor");

        builder.HasOne(d => d.IdUsuarioAsignadoNavigation).WithMany(p => p.DocDocumentoIdUsuarioAsignadoNavigations)
            .HasForeignKey(d => d.IdUsuarioAsignado)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__doc_docum__id_us__3D614D2E");

        builder.HasOne(d => d.IdUsuarioEnUsoNavigation).WithMany(p => p.DocDocumentoIdUsuarioEnUsoNavigations)
            .HasForeignKey(d => d.IdUsuarioEnUso)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__doc_docum__id_us__2A396A21");
    }
}
