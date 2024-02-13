using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquEquipoConfiguration : IEntityTypeConfiguration<EquEquipo>
{
    public void Configure(EntityTypeBuilder<EquEquipo> builder)
    {
        builder.ToTable("equ_equipo");

        builder.HasIndex(e => e.Eid, "IX_equ_equipo");

        builder.HasIndex(e => e.EquipoSerial, "IX_equ_equipo_equipo_serial");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Costo)
            .HasDefaultValue(0m)
            .HasColumnType("money")
            .HasColumnName("costo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Equipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equipo");
        builder.Property(e => e.EquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equipo_codigo");
        builder.Property(e => e.EquipoSerial)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("equipo_serial");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaImportacionFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaImportacion_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaPuestaMarchaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaPuestaMarcha_fh");
        builder.Property(e => e.GarantiaCancelada)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("garantiaCancelada");
        builder.Property(e => e.HorasGarantia).HasColumnName("horasGarantia");
        builder.Property(e => e.HorometroActual).HasColumnName("horometroActual");
        builder.Property(e => e.IdCatalogoEquipo).HasColumnName("id_catalogo.equipo");
        builder.Property(e => e.IdCentroCosto).HasColumnName("id_centroCosto");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdEstadoEquipo).HasColumnName("id_estadoEquipo");
        builder.Property(e => e.IdSistema).HasColumnName("id_sistema");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdTerceroComprador).HasColumnName("id_tercero_comprador");
        builder.Property(e => e.IdTerceroServicio).HasColumnName("id_tercero_servicio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdVersionEquipo).HasColumnName("id_versionEquipo");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.NombreContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("nombreContacto");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("observaciones");
        builder.Property(e => e.PromedioHoras).HasColumnName("promedioHoras");
        builder.Property(e => e.TelefonoContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("telefonoContacto");
        builder.Property(e => e.Ubicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ubicacion");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UltimaLecturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("ultimaLectura_fh");
        builder.Property(e => e.VencimientoGarantiaDistribuidorFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("vencimientoGarantiaDistribuidor_ff");
        builder.Property(e => e.VencimientoGarantiaFabricaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("vencimientoGarantiaFabrica_ff");

        builder.HasOne(d => d.IdCatalogoEquipoNavigation).WithMany(p => p.EquEquipos)
            .HasForeignKey(d => d.IdCatalogoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipo_id_catalogo_equipo");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.InverseIdEquipoNavigation)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipo_id_equipo");

        builder.HasOne(d => d.IdEstadoEquipoNavigation).WithMany(p => p.EquEquipos)
            .HasForeignKey(d => d.IdEstadoEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipo_id_estadoEquipo");

        builder.HasOne(d => d.IdSistemaNavigation).WithMany(p => p.EquEquipos)
            .HasForeignKey(d => d.IdSistema)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipo_id_sistema");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.EquEquipos)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipo_id_sucursal");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.EquEquipoIdTerceroNavigations)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipo_id_tercero");

        builder.HasOne(d => d.IdTerceroCompradorNavigation).WithMany(p => p.EquEquipoIdTerceroCompradorNavigations)
            .HasForeignKey(d => d.IdTerceroComprador)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipo_id_tercero_comprador");

        builder.HasOne(d => d.IdTerceroServicioNavigation).WithMany(p => p.EquEquipoIdTerceroServicioNavigations)
            .HasForeignKey(d => d.IdTerceroServicio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipo_id_tercero_servicio");

        builder.HasOne(d => d.IdVersionEquipoNavigation).WithMany(p => p.EquEquipos)
            .HasForeignKey(d => d.IdVersionEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipo_id_versionEquipo");

        builder.HasOne(d => d.IdZonaNavigation).WithMany(p => p.EquEquipos)
            .HasForeignKey(d => d.IdZona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipo_id_zona");
    }
}
