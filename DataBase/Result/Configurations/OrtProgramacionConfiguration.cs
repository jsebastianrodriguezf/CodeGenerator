using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class OrtProgramacionConfiguration : IEntityTypeConfiguration<OrtProgramacion>
{
    public void Configure(EntityTypeBuilder<OrtProgramacion> builder)
    {
        builder.ToTable("ort_programacion");

        builder.HasIndex(e => e.IdDocumentoOt, "IX_id_documento_ot");

        builder.HasIndex(e => e.IdReporteTecnico, "IX_id_reporteTecnico");

        builder.HasIndex(e => e.IdUsuario, "IX_id_usuario");

        builder.HasIndex(e => e.Eid, "IX_ort_programacion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Comentario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("comentario");
        builder.Property(e => e.Costo).HasColumnName("costo");
        builder.Property(e => e.DesdeFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("desde_fh");
        builder.Property(e => e.Duracion).HasColumnName("duracion");
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
        builder.Property(e => e.IdCatalogoActividad).HasColumnName("id_catalogo.actividad");
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
        builder.Property(e => e.IdMotivoCancelacion).HasColumnName("id_motivoCancelacion");
        builder.Property(e => e.IdProgramacion).HasColumnName("id_programacion");
        builder.Property(e => e.IdReporteTecnico).HasColumnName("id_reporteTecnico");
        builder.Property(e => e.IdSoporteItemDocumento).HasColumnName("id_soporteItemDocumento");
        builder.Property(e => e.IdTipoProgramacion).HasColumnName("id_tipoProgramacion");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Programacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("programacion");
        builder.Property(e => e.ProgramacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("programacion_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoActividadNavigation).WithMany(p => p.OrtProgramacions)
            .HasForeignKey(d => d.IdCatalogoActividad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_programacion_id_catalogo_actividad");

        builder.HasOne(d => d.IdDocumentoOtNavigation).WithMany(p => p.OrtProgramacions)
            .HasForeignKey(d => d.IdDocumentoOt)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_programacion_id_documento_ot");

        builder.HasOne(d => d.IdMotivoCancelacionNavigation).WithMany(p => p.OrtProgramacions)
            .HasForeignKey(d => d.IdMotivoCancelacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_programacion_id_motivoCancelacion");

        builder.HasOne(d => d.IdProgramacionNavigation).WithMany(p => p.InverseIdProgramacionNavigation)
            .HasForeignKey(d => d.IdProgramacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_programacion_id_programacion");

        builder.HasOne(d => d.IdReporteTecnicoNavigation).WithMany(p => p.OrtProgramacions)
            .HasForeignKey(d => d.IdReporteTecnico)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_programacion_id_reporteTecnico");

        builder.HasOne(d => d.IdSoporteItemDocumentoNavigation).WithMany(p => p.OrtProgramacions)
            .HasForeignKey(d => d.IdSoporteItemDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_programacion_id_soporteItemDocumento");

        builder.HasOne(d => d.IdTipoProgramacionNavigation).WithMany(p => p.OrtProgramacions)
            .HasForeignKey(d => d.IdTipoProgramacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_programacion_id_tipoProgramacion");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.OrtProgramacions)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ort_programacion_id_usuario");
    }
}
