using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquPrestamoEquipoConfiguration : IEntityTypeConfiguration<ViewEquPrestamoEquipo>
{
    public void Configure(EntityTypeBuilder<ViewEquPrestamoEquipo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_prestamo_equipo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquEquipoCosto)
            .HasColumnType("money")
            .HasColumnName("equ_equipo_costo");
        builder.Property(e => e.EquEquipoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo");
        builder.Property(e => e.EquEquipoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo_codigo");
        builder.Property(e => e.EquEquipoEquipoSerial)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_equipo_serial");
        builder.Property(e => e.EquEquipoFechaImportacionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_fechaImportacion_ff");
        builder.Property(e => e.EquEquipoFechaPuestaMarchaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_fechaPuestaMarcha_fh");
        builder.Property(e => e.EquEquipoGarantiaCancelada)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_garantiaCancelada");
        builder.Property(e => e.EquEquipoHorasGarantia).HasColumnName("equ_equipo_horasGarantia");
        builder.Property(e => e.EquEquipoHorometroActual).HasColumnName("equ_equipo_horometroActual");
        builder.Property(e => e.EquEquipoIdCatalogoEquipo).HasColumnName("equ_equipo_id_catalogo.equipo");
        builder.Property(e => e.EquEquipoIdEquipo).HasColumnName("equ_equipo_id_equipo");
        builder.Property(e => e.EquEquipoIdEstadoEquipo).HasColumnName("equ_equipo_id_estadoEquipo");
        builder.Property(e => e.EquEquipoIdSistema).HasColumnName("equ_equipo_id_sistema");
        builder.Property(e => e.EquEquipoIdSucursal).HasColumnName("equ_equipo_id_sucursal");
        builder.Property(e => e.EquEquipoIdTercero).HasColumnName("equ_equipo_id_tercero");
        builder.Property(e => e.EquEquipoIdTerceroComprador).HasColumnName("equ_equipo_id_tercero_comprador");
        builder.Property(e => e.EquEquipoIdTerceroServicio).HasColumnName("equ_equipo_id_tercero_servicio");
        builder.Property(e => e.EquEquipoIdVersionEquipo).HasColumnName("equ_equipo_id_versionEquipo");
        builder.Property(e => e.EquEquipoIdZona).HasColumnName("equ_equipo_id_zona");
        builder.Property(e => e.EquEquipoNombreContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_nombreContacto");
        builder.Property(e => e.EquEquipoObservaciones)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_observaciones");
        builder.Property(e => e.EquEquipoPromedioHoras).HasColumnName("equ_equipo_promedioHoras");
        builder.Property(e => e.EquEquipoTelefonoContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_telefonoContacto");
        builder.Property(e => e.EquEquipoUbicacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_ubicacion");
        builder.Property(e => e.EquEquipoUltimaLecturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_ultimaLectura_fh");
        builder.Property(e => e.EquEquipoVencimientoGarantiaDistribuidorFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_vencimientoGarantiaDistribuidor_ff");
        builder.Property(e => e.EquEquipoVencimientoGarantiaFabricaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_vencimientoGarantiaFabrica_ff");
        builder.Property(e => e.EquPrestamoFechaCompromisoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_prestamo_fechaCompromiso_ff");
        builder.Property(e => e.EquPrestamoFechaPrestamoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_prestamo_fechaPrestamo_ff");
        builder.Property(e => e.EquPrestamoIdEstadoPrestamo).HasColumnName("equ_prestamo_id_estadoPrestamo");
        builder.Property(e => e.EquPrestamoIdUsuarioEntrego).HasColumnName("equ_prestamo_id_usuario_entrego");
        builder.Property(e => e.EquPrestamoNotas)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_prestamo_notas");
        builder.Property(e => e.EquPrestamoPrestamo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_prestamo_prestamo");
        builder.Property(e => e.EquPrestamoPrestamoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_prestamo_prestamo_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaDevolucionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaDevolucion_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdPrestamo).HasColumnName("id_prestamo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PrestamoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("prestamo_equipo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
