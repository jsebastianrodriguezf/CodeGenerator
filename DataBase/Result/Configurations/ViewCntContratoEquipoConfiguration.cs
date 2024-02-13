using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCntContratoEquipoConfiguration : IEntityTypeConfiguration<ViewCntContratoEquipo>
{
    public void Configure(EntityTypeBuilder<ViewCntContratoEquipo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cnt_contratoEquipo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CntContratoCondiciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_condiciones");
        builder.Property(e => e.CntContratoContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_contrato");
        builder.Property(e => e.CntContratoContratoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_contrato_codigo");
        builder.Property(e => e.CntContratoDetalleVisitaAproximarA).HasColumnName("cnt_contratoDetalleVisita_aproximarA");
        builder.Property(e => e.CntContratoDetalleVisitaCadaN).HasColumnName("cnt_contratoDetalleVisita_cadaN");
        builder.Property(e => e.CntContratoDetalleVisitaContratoDetalleVisita)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_contratoDetalleVisita_contratoDetalleVisita");
        builder.Property(e => e.CntContratoDetalleVisitaContratoDetalleVisitaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cnt_contratoDetalleVisita_contratoDetalleVisita_codigo");
        builder.Property(e => e.CntContratoDetalleVisitaDia).HasColumnName("cnt_contratoDetalleVisita_dia");
        builder.Property(e => e.CntContratoDetalleVisitaEstrategia).HasColumnName("cnt_contratoDetalleVisita_estrategia");
        builder.Property(e => e.CntContratoDetalleVisitaFechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_contratoDetalleVisita_fecha_ff");
        builder.Property(e => e.CntContratoDetalleVisitaFrecuencia).HasColumnName("cnt_contratoDetalleVisita_frecuencia");
        builder.Property(e => e.CntContratoDetalleVisitaIdContrato).HasColumnName("cnt_contratoDetalleVisita_id_contrato");
        builder.Property(e => e.CntContratoDetalleVisitaIncluirMenores).HasColumnName("cnt_contratoDetalleVisita_incluirMenores");
        builder.Property(e => e.CntContratoDetalleVisitaPorTrabajo).HasColumnName("cnt_contratoDetalleVisita_porTrabajo");
        builder.Property(e => e.CntContratoDiasCumplimiento).HasColumnName("cnt_contrato_diasCumplimiento");
        builder.Property(e => e.CntContratoFechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_contrato_fechaFin_ff");
        builder.Property(e => e.CntContratoFechaInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_contrato_fechaInicio_ff");
        builder.Property(e => e.CntContratoIdDepartamentoSolicitud).HasColumnName("cnt_contrato_id_departamentoSolicitud");
        builder.Property(e => e.CntContratoIdPeriodoContrato).HasColumnName("cnt_contrato_id_periodoContrato");
        builder.Property(e => e.CntContratoIdSubtipoDocumento).HasColumnName("cnt_contrato_id_subtipoDocumento");
        builder.Property(e => e.CntContratoIdTercero).HasColumnName("cnt_contrato_id_tercero");
        builder.Property(e => e.CntContratoIdTerceroServicio).HasColumnName("cnt_contrato_id_tercero_servicio");
        builder.Property(e => e.CntContratoIdTipoContrato).HasColumnName("cnt_contrato_id_tipoContrato");
        builder.Property(e => e.CntContratoIdTipoServicio).HasColumnName("cnt_contrato_id_tipoServicio");
        builder.Property(e => e.CntContratoIdUsuarioCoordinador).HasColumnName("cnt_contrato_id_usuario_coordinador");
        builder.Property(e => e.CntContratoNumero)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_numero");
        builder.Property(e => e.CntContratoPresupuesto)
            .HasColumnType("money")
            .HasColumnName("cnt_contrato_presupuesto");
        builder.Property(e => e.CntContratoTotalContrato)
            .HasColumnType("money")
            .HasColumnName("cnt_contrato_totalContrato");
        builder.Property(e => e.ContratoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contratoEquipo");
        builder.Property(e => e.ContratoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contratoEquipo_codigo");
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
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdContratoDetalleVisita).HasColumnName("id_contratoDetalleVisita");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Manejahorometro).HasColumnName("manejahorometro");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PrecioServicio)
            .HasColumnType("money")
            .HasColumnName("precioServicio");
        builder.Property(e => e.PrecioVisita)
            .HasColumnType("money")
            .HasColumnName("precioVisita");
        builder.Property(e => e.Promedio).HasColumnName("promedio");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
