using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocDocumentoOtConfiguration : IEntityTypeConfiguration<DocDocumentoOt>
{
    public void Configure(EntityTypeBuilder<DocDocumentoOt> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_doc_documento_ot");

        builder.ToTable("doc_documento.ot");

        builder.HasIndex(e => e.Eid, "IX_doc_documento_ot");

        builder.HasIndex(e => e.FechaModificacion, "IX_fechaModificacion").IsDescending();

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cargo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cargo");
        builder.Property(e => e.Compromisos)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("compromisos");
        builder.Property(e => e.Contacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("contacto");
        builder.Property(e => e.DiagnosticoInicial)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("diagnosticoInicial");
        builder.Property(e => e.DireccionUbicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("direccionUbicacion");
        builder.Property(e => e.DistribuyeCentros).HasColumnName("distribuyeCentros");
        builder.Property(e => e.DocumentoOt)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documento.ot");
        builder.Property(e => e.DuracionEstimada).HasColumnName("duracionEstimada");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("email");
        builder.Property(e => e.EnTaller)
            .HasDefaultValue(true)
            .HasColumnName("enTaller");
        builder.Property(e => e.Fax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("fax");
        builder.Property(e => e.FechaCompromisoFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCompromiso_fh");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaGarantia_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdDepartamentoSolicitud).HasColumnName("id_departamentoSolicitud");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdMotivoCancelacion).HasColumnName("id_motivoCancelacion");
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuarioCoordinador).HasColumnName("id_usuario_coordinador");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.MotivoServicio)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("motivoServicio");
        builder.Property(e => e.PorcentajeCliente)
            .HasDefaultValue(100.0)
            .HasColumnName("porcentajeCliente");
        builder.Property(e => e.PorcentajeDistribuidor).HasColumnName("porcentajeDistribuidor");
        builder.Property(e => e.PorcentajeFabricante).HasColumnName("porcentajeFabricante");
        builder.Property(e => e.ReclamacionFabrica)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("reclamacionFabrica");
        builder.Property(e => e.Recomendaciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("recomendaciones");
        builder.Property(e => e.SegunTempario).HasColumnName("segunTempario");
        builder.Property(e => e.Telefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("telefono");
        builder.Property(e => e.Trabajos)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("trabajos");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdContratoNavigation).WithMany(p => p.DocDocumentoOts)
            .HasForeignKey(d => d.IdContrato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_id_contrato");

        builder.HasOne(d => d.IdDepartamentoSolicitudNavigation).WithMany(p => p.DocDocumentoOts)
            .HasForeignKey(d => d.IdDepartamentoSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_id_departamentoSolicitud");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.DocDocumentoOts)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_id_equipo");

        builder.HasOne(d => d.IdMotivoCancelacionNavigation).WithMany(p => p.DocDocumentoOts)
            .HasForeignKey(d => d.IdMotivoCancelacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_id_motivoCancelacion");

        builder.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.DocDocumentoOts)
            .HasForeignKey(d => d.IdSistema)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_id_sistema");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.DocDocumentoOts)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_id_sucursal");

        builder.HasOne(d => d.IdTipoServicioNavigation).WithMany(p => p.DocDocumentoOts)
            .HasForeignKey(d => d.IdTipoServicio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_id_tipoServicio");

        builder.HasOne(d => d.IdUsuarioCoordinadorNavigation).WithMany(p => p.DocDocumentoOts)
            .HasForeignKey(d => d.IdUsuarioCoordinador)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_id_usuario_coordinador");

        builder.HasOne(d => d.IdZonaNavigation).WithMany(p => p.DocDocumentoOts)
            .HasForeignKey(d => d.IdZona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_documento_ot_id_zona");
    }
}
