using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocPrioridadDocumentoConfiguration : IEntityTypeConfiguration<ViewDocPrioridadDocumento>
{
    public void Configure(EntityTypeBuilder<ViewDocPrioridadDocumento> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_prioridadDocumento");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.DocTipoDocumentoEsSalida).HasColumnName("doc_tipoDocumento_esSalida");
        builder.Property(e => e.DocTipoDocumentoMostrarBodega).HasColumnName("doc_tipoDocumento_mostrarBodega");
        builder.Property(e => e.DocTipoDocumentoMostrarCentroCosto).HasColumnName("doc_tipoDocumento_mostrarCentroCosto");
        builder.Property(e => e.DocTipoDocumentoMostrarIncoterm).HasColumnName("doc_tipoDocumento_mostrarIncoterm");
        builder.Property(e => e.DocTipoDocumentoPuedeSerMayor).HasColumnName("doc_tipoDocumento_puedeSerMayor");
        builder.Property(e => e.DocTipoDocumentoPuedeSerMenor).HasColumnName("doc_tipoDocumento_puedeSerMenor");
        builder.Property(e => e.DocTipoDocumentoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_tipoDocumento_tipoDocumento");
        builder.Property(e => e.DocTipoDocumentoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_tipoDocumento_tipoDocumento_codigo");
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
        builder.Property(e => e.IdEstrategiaPrioridad).HasColumnName("id_estrategiaPrioridad");
        builder.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.PrioridadDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("prioridadDocumento");
        builder.Property(e => e.PrioridadDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("prioridadDocumento_codigo");
        builder.Property(e => e.TiempoRespuesta).HasColumnName("tiempoRespuesta");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
