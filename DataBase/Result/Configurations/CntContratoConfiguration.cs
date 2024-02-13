using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntContratoConfiguration : IEntityTypeConfiguration<CntContrato>
{
    public void Configure(EntityTypeBuilder<CntContrato> builder)
    {
        builder.ToTable("cnt_contrato");

        builder.HasIndex(e => e.Eid, "IX_cnt_contrato");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Condiciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("condiciones");
        builder.Property(e => e.Contrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contrato");
        builder.Property(e => e.ContratoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contrato_codigo");
        builder.Property(e => e.DiasCumplimiento)
            .HasDefaultValue(30)
            .HasColumnName("diasCumplimiento");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFin_ff");
        builder.Property(e => e.FechaInicioFf)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicio_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdDepartamentoSolicitud).HasColumnName("id_departamentoSolicitud");
        builder.Property(e => e.IdDocumentoAlquiler).HasColumnName("id_documento.alquiler");
        builder.Property(e => e.IdEstadoTipoDocumentoInicial).HasColumnName("id_estadoTipoDocumento_inicial");
        builder.Property(e => e.IdPeriodoContrato).HasColumnName("id_periodoContrato");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdSubtipoDocumentoSolicitud).HasColumnName("id_subtipoDocumento_solicitud");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdTerceroServicio).HasColumnName("id_tercero_servicio");
        builder.Property(e => e.IdTipoContrato).HasColumnName("id_tipoContrato");
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuarioCoordinador).HasColumnName("id_usuario_coordinador");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Numero)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("numero");
        builder.Property(e => e.Presupuesto)
            .HasColumnType("money")
            .HasColumnName("presupuesto");
        builder.Property(e => e.TotalContrato)
            .HasColumnType("money")
            .HasColumnName("totalContrato");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDepartamentoSolicitudNavigation).WithMany(p => p.CntContratos)
            .HasForeignKey(d => d.IdDepartamentoSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_id_departamentoSolicitud");

        builder.HasOne(d => d.IdDocumentoAlquilerNavigation).WithMany(p => p.CntContratos)
            .HasForeignKey(d => d.IdDocumentoAlquiler)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_id_documento_alquiler");

        builder.HasOne(d => d.IdEstadoTipoDocumentoInicialNavigation).WithMany(p => p.CntContratos)
            .HasForeignKey(d => d.IdEstadoTipoDocumentoInicial)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__cnt_contr__id_es__483ECE54");

        builder.HasOne(d => d.IdPeriodoContratoNavigation).WithMany(p => p.CntContratos)
            .HasForeignKey(d => d.IdPeriodoContrato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_id_periodoContrato");

        builder.HasOne(d => d.IdSubtipoDocumentoNavigation).WithMany(p => p.CntContratoIdSubtipoDocumentoNavigations)
            .HasForeignKey(d => d.IdSubtipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_id_subtipoDocumento");

        builder.HasOne(d => d.IdSubtipoDocumentoSolicitudNavigation).WithMany(p => p.CntContratoIdSubtipoDocumentoSolicitudNavigations)
            .HasForeignKey(d => d.IdSubtipoDocumentoSolicitud)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__cnt_contr__id_su__36DF3828");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.CntContratoIdTerceroNavigations)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_id_tercero");

        builder.HasOne(d => d.IdTerceroServicioNavigation).WithMany(p => p.CntContratoIdTerceroServicioNavigations)
            .HasForeignKey(d => d.IdTerceroServicio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_id_tercero_servicio");

        builder.HasOne(d => d.IdTipoContratoNavigation).WithMany(p => p.CntContratos)
            .HasForeignKey(d => d.IdTipoContrato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_id_tipoContrato");

        builder.HasOne(d => d.IdTipoServicioNavigation).WithMany(p => p.CntContratos)
            .HasForeignKey(d => d.IdTipoServicio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_id_tipoServicio");

        builder.HasOne(d => d.IdUsuarioCoordinadorNavigation).WithMany(p => p.CntContratos)
            .HasForeignKey(d => d.IdUsuarioCoordinador)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_id_usuario_coordinador");
    }
}
