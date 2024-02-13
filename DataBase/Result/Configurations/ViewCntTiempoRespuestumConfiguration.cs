using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCntTiempoRespuestumConfiguration : IEntityTypeConfiguration<ViewCntTiempoRespuestum>
{
    public void Configure(EntityTypeBuilder<ViewCntTiempoRespuestum> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cnt_tiempoRespuesta");

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
        builder.Property(e => e.DocEstrategiaPrioridadDomingoFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_domingoFin_hh");
        builder.Property(e => e.DocEstrategiaPrioridadDomingoIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_domingoIni_hh");
        builder.Property(e => e.DocEstrategiaPrioridadEstrategiaPrioridad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_estrategiaPrioridad_estrategiaPrioridad");
        builder.Property(e => e.DocEstrategiaPrioridadEstrategiaPrioridadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_estrategiaPrioridad_estrategiaPrioridad_codigo");
        builder.Property(e => e.DocEstrategiaPrioridadFestivoFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_festivoFin_hh");
        builder.Property(e => e.DocEstrategiaPrioridadFestivoIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_festivoIni_hh");
        builder.Property(e => e.DocEstrategiaPrioridadJuevesFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_juevesFin_hh");
        builder.Property(e => e.DocEstrategiaPrioridadJuevesIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_juevesIni_hh");
        builder.Property(e => e.DocEstrategiaPrioridadLunesFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_lunesFin_hh");
        builder.Property(e => e.DocEstrategiaPrioridadLunesIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_lunesIni_hh");
        builder.Property(e => e.DocEstrategiaPrioridadMartesFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_martesFin_hh");
        builder.Property(e => e.DocEstrategiaPrioridadMartesIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_martesIni_hh");
        builder.Property(e => e.DocEstrategiaPrioridadMiercolesFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_miercolesFin_hh");
        builder.Property(e => e.DocEstrategiaPrioridadMiercolesIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_miercolesIni_hh");
        builder.Property(e => e.DocEstrategiaPrioridadSabadoFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_sabadoFin_hh");
        builder.Property(e => e.DocEstrategiaPrioridadSabadoIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_sabadoIni_hh");
        builder.Property(e => e.DocEstrategiaPrioridadViernesFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_viernesFin_hh");
        builder.Property(e => e.DocEstrategiaPrioridadViernesIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_estrategiaPrioridad_viernesIni_hh");
        builder.Property(e => e.DocPrioridadDocumentoIdEstrategiaPrioridad).HasColumnName("doc_prioridadDocumento_id_estrategiaPrioridad");
        builder.Property(e => e.DocPrioridadDocumentoIdTipoDocumento).HasColumnName("doc_prioridadDocumento_id_tipoDocumento");
        builder.Property(e => e.DocPrioridadDocumentoPrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_prioridadDocumento_prioridadDocumento");
        builder.Property(e => e.DocPrioridadDocumentoPrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_prioridadDocumento_prioridadDocumento_codigo");
        builder.Property(e => e.DocPrioridadDocumentoTiempoRespuesta).HasColumnName("doc_prioridadDocumento_tiempoRespuesta");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdEstrategiaPrioridad).HasColumnName("id_estrategiaPrioridad");
        builder.Property(e => e.IdPrioridadDocumento).HasColumnName("id_prioridadDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.TiempoLimite).HasColumnName("tiempoLimite");
        builder.Property(e => e.TiempoRespuesta)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tiempoRespuesta");
        builder.Property(e => e.TiempoRespuestaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tiempoRespuesta_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
