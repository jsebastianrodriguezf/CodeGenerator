using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquTrazabilidadConfiguration : IEntityTypeConfiguration<EquTrazabilidad>
{
    public void Configure(EntityTypeBuilder<EquTrazabilidad> builder)
    {
        builder.ToTable("equ_trazabilidad");

        builder.HasIndex(e => e.Eid, "IX_equ_trazabilidad");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsSoporte).HasColumnName("esSoporte");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Horometro).HasColumnName("horometro");
        builder.Property(e => e.IdCicloHorometro).HasColumnName("id_cicloHorometro");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdDocumentoAlquiler).HasColumnName("id_documento.alquiler");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdEquipoPadre).HasColumnName("id_equipo_padre");
        builder.Property(e => e.IdEstadoEquipo).HasColumnName("id_estadoEquipo");
        builder.Property(e => e.IdEvento).HasColumnName("id_evento");
        builder.Property(e => e.IdPosicion).HasColumnName("id_posicion");
        builder.Property(e => e.IdPrestamo).HasColumnName("id_prestamo");
        builder.Property(e => e.IdReporteTecnico).HasColumnName("id_reporteTecnico");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdTipoTrazabilidad).HasColumnName("id_tipoTrazabilidad");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Trazabilidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("trazabilidad");
        builder.Property(e => e.TrazabilidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("trazabilidad_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCicloHorometroNavigation).WithMany(p => p.EquTrazabilidads)
            .HasForeignKey(d => d.IdCicloHorometro)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_cicloHorometro");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.EquTrazabilidads)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_documento");

        builder.HasOne(d => d.IdDocumentoAlquilerNavigation).WithMany(p => p.EquTrazabilidads)
            .HasForeignKey(d => d.IdDocumentoAlquiler)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_documento_alquiler");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.EquTrazabilidadIdEquipoNavigations)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_equipo");

        builder.HasOne(d => d.IdEquipoPadreNavigation).WithMany(p => p.EquTrazabilidadIdEquipoPadreNavigations)
            .HasForeignKey(d => d.IdEquipoPadre)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_equipo_padre");

        builder.HasOne(d => d.IdEventoNavigation).WithMany(p => p.EquTrazabilidads)
            .HasForeignKey(d => d.IdEvento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_evento");

        builder.HasOne(d => d.IdPosicionNavigation).WithMany(p => p.EquTrazabilidads)
            .HasForeignKey(d => d.IdPosicion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_posicion");

        builder.HasOne(d => d.IdPrestamoNavigation).WithMany(p => p.EquTrazabilidads)
            .HasForeignKey(d => d.IdPrestamo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_prestamo");

        builder.HasOne(d => d.IdReporteTecnicoNavigation).WithMany(p => p.EquTrazabilidads)
            .HasForeignKey(d => d.IdReporteTecnico)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_reporteTecnico");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.EquTrazabilidads)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_sucursal");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.EquTrazabilidads)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_tercero");

        builder.HasOne(d => d.IdTipoTrazabilidadNavigation).WithMany(p => p.EquTrazabilidads)
            .HasForeignKey(d => d.IdTipoTrazabilidad)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_trazabilidad_id_tipoTrazabilidad");
    }
}
