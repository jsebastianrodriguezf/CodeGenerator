using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquTrazabilidadConfiguration : IEntityTypeConfiguration<ViewEquTrazabilidad>
{
    public void Configure(EntityTypeBuilder<ViewEquTrazabilidad> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_trazabilidad");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatPosicionIdCatalogoEquipoComponente).HasColumnName("cat_posicion_id_catalogo.equipo_componente");
        builder.Property(e => e.CatPosicionIdCatalogoEquipoEquipo).HasColumnName("cat_posicion_id_catalogo.equipo_equipo");
        builder.Property(e => e.CatPosicionIdDimensionX).HasColumnName("cat_posicion_id_dimension_x");
        builder.Property(e => e.CatPosicionIdDimensionY).HasColumnName("cat_posicion_id_dimension_y");
        builder.Property(e => e.CatPosicionIdDimensionZ).HasColumnName("cat_posicion_id_dimension_z");
        builder.Property(e => e.CatPosicionPosicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_posicion_posicion");
        builder.Property(e => e.CatPosicionPosicionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_posicion_posicion_codigo");
        builder.Property(e => e.DisEventoAfectaCliente).HasColumnName("dis_evento_afectaCliente");
        builder.Property(e => e.DisEventoAfectaProduccion).HasColumnName("dis_evento_afectaProduccion");
        builder.Property(e => e.DisEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_evento_codigo");
        builder.Property(e => e.DisEventoDuracionHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_duracion_hh");
        builder.Property(e => e.DisEventoEvento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("dis_evento_evento");
        builder.Property(e => e.DisEventoEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("dis_evento_evento_codigo");
        builder.Property(e => e.DisEventoEventoTipo).HasColumnName("dis_evento_eventoTipo");
        builder.Property(e => e.DisEventoFechaHoraEstimadaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_fechaHoraEstimada_fh");
        builder.Property(e => e.DisEventoFechaHoraInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("dis_evento_fechaHoraInicio_ff");
        builder.Property(e => e.DisEventoIdEquipo).HasColumnName("dis_evento_id_equipo");
        builder.Property(e => e.DisEventoIdEstadoEquipo).HasColumnName("dis_evento_id_estadoEquipo");
        builder.Property(e => e.DisEventoIdEstadoEvento).HasColumnName("dis_evento_id_estadoEvento");
        builder.Property(e => e.DisEventoIdFalla).HasColumnName("dis_evento_id_falla");
        builder.Property(e => e.DisEventoIdFallaCausa).HasColumnName("dis_evento_id_falla_causa");
        builder.Property(e => e.DisEventoIdMetodoDeteccion).HasColumnName("dis_evento_id_metodoDeteccion");
        builder.Property(e => e.DisEventoIdMotivoEvento).HasColumnName("dis_evento_id_motivoEvento");
        builder.Property(e => e.DisEventoIdUsuario).HasColumnName("dis_evento_id_usuario");
        builder.Property(e => e.DisEventoNotas)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("dis_evento_notas");
        builder.Property(e => e.DocDocumentoAlquilerCosto).HasColumnName("doc_documento_alquiler_costo");
        builder.Property(e => e.DocDocumentoAlquilerCostoPlaneado).HasColumnName("doc_documento_alquiler_costoPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDescuento).HasColumnName("doc_documento_alquiler_descuento");
        builder.Property(e => e.DocDocumentoAlquilerDescuentoPlaneado).HasColumnName("doc_documento_alquiler_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.alquiler_documento.alquiler");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_documento_codigo");
        builder.Property(e => e.DocDocumentoAlquilerDocumentoNumero).HasColumnName("doc_documento_alquiler_documento_numero");
        builder.Property(e => e.DocDocumentoAlquilerFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoAlquilerFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fecha_fh");
        builder.Property(e => e.DocDocumentoAlquilerFechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.alquiler_fechaFin_ff");
        builder.Property(e => e.DocDocumentoAlquilerFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoAlquilerFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_alquiler_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoAlquilerIdDocumento).HasColumnName("doc_documento_alquiler_id_documento");
        builder.Property(e => e.DocDocumentoAlquilerIdEstadoTipoDocumento).HasColumnName("doc_documento_alquiler_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerIdMoneda).HasColumnName("doc_documento_alquiler_id_moneda");
        builder.Property(e => e.DocDocumentoAlquilerIdMotivoestado).HasColumnName("doc_documento_alquiler_id_motivoestado");
        builder.Property(e => e.DocDocumentoAlquilerIdPrioridadDocumento).HasColumnName("doc_documento_alquiler_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoAlquilerIdSubtipoDocumento).HasColumnName("doc_documento_alquiler_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoAlquilerIdTerceroCliente).HasColumnName("doc_documento_alquiler_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoAlquilerIdTerceroProveedor).HasColumnName("doc_documento_alquiler_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoAlquilerIva).HasColumnName("doc_documento_alquiler_iva");
        builder.Property(e => e.DocDocumentoAlquilerIvaPlaneado).HasColumnName("doc_documento_alquiler_ivaPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerMesVencido).HasColumnName("doc_documento.alquiler_mesVencido");
        builder.Property(e => e.DocDocumentoAlquilerObservaciones)
            .HasMaxLength(3000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.alquiler_observaciones");
        builder.Property(e => e.DocDocumentoAlquilerPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_alquiler_prefijo");
        builder.Property(e => e.DocDocumentoAlquilerRentabilidad).HasColumnName("doc_documento_alquiler_rentabilidad");
        builder.Property(e => e.DocDocumentoAlquilerSubtotal).HasColumnName("doc_documento_alquiler_subtotal");
        builder.Property(e => e.DocDocumentoAlquilerSubtotalPlaneado).HasColumnName("doc_documento_alquiler_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerTotal).HasColumnName("doc_documento_alquiler_total");
        builder.Property(e => e.DocDocumentoAlquilerTotalPlaneado).HasColumnName("doc_documento_alquiler_totalPlaneado");
        builder.Property(e => e.DocDocumentoAlquilerTrm).HasColumnName("doc_documento_alquiler_trm");
        builder.Property(e => e.DocDocumentoCosto).HasColumnName("doc_documento_costo");
        builder.Property(e => e.DocDocumentoCostoPlaneado).HasColumnName("doc_documento_costoPlaneado");
        builder.Property(e => e.DocDocumentoDescuento).HasColumnName("doc_documento_descuento");
        builder.Property(e => e.DocDocumentoDescuentoPlaneado).HasColumnName("doc_documento_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_documento");
        builder.Property(e => e.DocDocumentoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_documento_codigo");
        builder.Property(e => e.DocDocumentoDocumentoNumero).HasColumnName("doc_documento_documento_numero");
        builder.Property(e => e.DocDocumentoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fecha_fh");
        builder.Property(e => e.DocDocumentoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoIdDocumento).HasColumnName("doc_documento_id_documento");
        builder.Property(e => e.DocDocumentoIdEstadoTipoDocumento).HasColumnName("doc_documento_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoIdMoneda).HasColumnName("doc_documento_id_moneda");
        builder.Property(e => e.DocDocumentoIdMotivoestado).HasColumnName("doc_documento_id_motivoestado");
        builder.Property(e => e.DocDocumentoIdPrioridadDocumento).HasColumnName("doc_documento_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoIdSubtipoDocumento).HasColumnName("doc_documento_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoIdTerceroCliente).HasColumnName("doc_documento_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoIdTerceroProveedor).HasColumnName("doc_documento_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoIva).HasColumnName("doc_documento_iva");
        builder.Property(e => e.DocDocumentoIvaPlaneado).HasColumnName("doc_documento_ivaPlaneado");
        builder.Property(e => e.DocDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_prefijo");
        builder.Property(e => e.DocDocumentoRentabilidad).HasColumnName("doc_documento_rentabilidad");
        builder.Property(e => e.DocDocumentoSubtotal).HasColumnName("doc_documento_subtotal");
        builder.Property(e => e.DocDocumentoSubtotalPlaneado).HasColumnName("doc_documento_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoTotal).HasColumnName("doc_documento_total");
        builder.Property(e => e.DocDocumentoTotalPlaneado).HasColumnName("doc_documento_totalPlaneado");
        builder.Property(e => e.DocDocumentoTrm).HasColumnName("doc_documento_trm");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquCicloHorometroAfectarProyeccion).HasColumnName("equ_cicloHorometro_afectarProyeccion");
        builder.Property(e => e.EquCicloHorometroCicloHorometro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_cicloHorometro_cicloHorometro");
        builder.Property(e => e.EquCicloHorometroCicloHorometroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_cicloHorometro_cicloHorometro_codigo");
        builder.Property(e => e.EquCicloHorometroHorometroFinal).HasColumnName("equ_cicloHorometro_horometroFinal");
        builder.Property(e => e.EquCicloHorometroHorometroInicial).HasColumnName("equ_cicloHorometro_horometroInicial");
        builder.Property(e => e.EquCicloHorometroIdEquipo).HasColumnName("equ_cicloHorometro_id_equipo");
        builder.Property(e => e.EquCicloHorometroNciclo).HasColumnName("equ_cicloHorometro_Nciclo");
        builder.Property(e => e.EquCicloHorometroReiniciarHorometro).HasColumnName("equ_cicloHorometro_reiniciarHorometro");
        builder.Property(e => e.EquCicloHorometroReparacionMayor).HasColumnName("equ_cicloHorometro_reparacionMayor");
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
        builder.Property(e => e.EquEquipoPadreCosto)
            .HasColumnType("money")
            .HasColumnName("equ_equipo_padre_costo");
        builder.Property(e => e.EquEquipoPadreEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_equipo");
        builder.Property(e => e.EquEquipoPadreEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_equipo_codigo");
        builder.Property(e => e.EquEquipoPadreEquipoSerial)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_equipo_serial");
        builder.Property(e => e.EquEquipoPadreFechaImportacionFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_padre_fechaImportacion_ff");
        builder.Property(e => e.EquEquipoPadreFechaPuestaMarchaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_padre_fechaPuestaMarcha_fh");
        builder.Property(e => e.EquEquipoPadreGarantiaCancelada)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_garantiaCancelada");
        builder.Property(e => e.EquEquipoPadreHorasGarantia).HasColumnName("equ_equipo_padre_horasGarantia");
        builder.Property(e => e.EquEquipoPadreHorometroActual).HasColumnName("equ_equipo_padre_horometroActual");
        builder.Property(e => e.EquEquipoPadreIdCatalogoEquipo).HasColumnName("equ_equipo_padre_id_catalogo.equipo");
        builder.Property(e => e.EquEquipoPadreIdEquipo).HasColumnName("equ_equipo_padre_id_equipo");
        builder.Property(e => e.EquEquipoPadreIdEstadoEquipo).HasColumnName("equ_equipo_padre_id_estadoEquipo");
        builder.Property(e => e.EquEquipoPadreIdSistema).HasColumnName("equ_equipo_padre_id_sistema");
        builder.Property(e => e.EquEquipoPadreIdSucursal).HasColumnName("equ_equipo_padre_id_sucursal");
        builder.Property(e => e.EquEquipoPadreIdTercero).HasColumnName("equ_equipo_padre_id_tercero");
        builder.Property(e => e.EquEquipoPadreIdTerceroComprador).HasColumnName("equ_equipo_padre_id_tercero_comprador");
        builder.Property(e => e.EquEquipoPadreIdTerceroServicio).HasColumnName("equ_equipo_padre_id_tercero_servicio");
        builder.Property(e => e.EquEquipoPadreIdVersionEquipo).HasColumnName("equ_equipo_padre_id_versionEquipo");
        builder.Property(e => e.EquEquipoPadreIdZona).HasColumnName("equ_equipo_padre_id_zona");
        builder.Property(e => e.EquEquipoPadreNombreContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_nombreContacto");
        builder.Property(e => e.EquEquipoPadreObservaciones)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_observaciones");
        builder.Property(e => e.EquEquipoPadrePromedioHoras).HasColumnName("equ_equipo_padre_promedioHoras");
        builder.Property(e => e.EquEquipoPadreTelefonoContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_telefonoContacto");
        builder.Property(e => e.EquEquipoPadreUbicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_padre_ubicacion");
        builder.Property(e => e.EquEquipoPadreUltimaLecturaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_padre_ultimaLectura_fh");
        builder.Property(e => e.EquEquipoPadreVencimientoGarantiaDistribuidorFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_padre_vencimientoGarantiaDistribuidor_ff");
        builder.Property(e => e.EquEquipoPadreVencimientoGarantiaFabricaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("equ_equipo_padre_vencimientoGarantiaFabrica_ff");
        builder.Property(e => e.EquEquipoPromedioHoras).HasColumnName("equ_equipo_promedioHoras");
        builder.Property(e => e.EquEquipoTelefonoContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_equipo_telefonoContacto");
        builder.Property(e => e.EquEquipoUbicacion)
            .HasMaxLength(300)
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
        builder.Property(e => e.EquEstadoEquipoActivo).HasColumnName("equ_estadoEquipo_activo");
        builder.Property(e => e.EquEstadoEquipoEstadoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_estadoEquipo_estadoEquipo");
        builder.Property(e => e.EquEstadoEquipoEstadoEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_estadoEquipo_estadoEquipo_codigo");
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
        builder.Property(e => e.EquTipoTrazabilidadTipoTrazabilidad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_tipoTrazabilidad_tipoTrazabilidad");
        builder.Property(e => e.EquTipoTrazabilidadTipoTrazabilidadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_tipoTrazabilidad_tipoTrazabilidad_codigo");
        builder.Property(e => e.EsSoporte).HasColumnName("esSoporte");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Horometro).HasColumnName("horometro");
        builder.Property(e => e.Id).HasColumnName("id");
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
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.OrtReporteTecnicoCompromisos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_compromisos");
        builder.Property(e => e.OrtReporteTecnicoIdGasto).HasColumnName("ort_reporteTecnico_id_gasto");
        builder.Property(e => e.OrtReporteTecnicoNumero)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_numero");
        builder.Property(e => e.OrtReporteTecnicoRecomendaciones)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_recomendaciones");
        builder.Property(e => e.OrtReporteTecnicoReporteTecnico)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_reporteTecnico");
        builder.Property(e => e.OrtReporteTecnicoReporteTecnicoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_reporteTecnico_codigo");
        builder.Property(e => e.OrtReporteTecnicoTrabajos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_trabajos");
        builder.Property(e => e.TerSucursalCodigorecursiva)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_codigorecursiva");
        builder.Property(e => e.TerSucursalContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_contacto");
        builder.Property(e => e.TerSucursalDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Direccion");
        builder.Property(e => e.TerSucursalEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Email");
        builder.Property(e => e.TerSucursalFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Fax");
        builder.Property(e => e.TerSucursalIdEstadoTercero).HasColumnName("ter_sucursal_id_estadoTercero");
        builder.Property(e => e.TerSucursalIdSucursal).HasColumnName("ter_sucursal_id_sucursal");
        builder.Property(e => e.TerSucursalIdTercero).HasColumnName("ter_sucursal_id_tercero");
        builder.Property(e => e.TerSucursalIdUsuarioAsesor).HasColumnName("ter_sucursal_id_usuario_asesor");
        builder.Property(e => e.TerSucursalIdUsuarioTecnico).HasColumnName("ter_sucursal_id_usuario_tecnico");
        builder.Property(e => e.TerSucursalIdZona).HasColumnName("ter_sucursal_id_zona");
        builder.Property(e => e.TerSucursalParaAlquiler).HasColumnName("ter_sucursal_paraAlquiler");
        builder.Property(e => e.TerSucursalParaSoporte).HasColumnName("ter_sucursal_paraSoporte");
        builder.Property(e => e.TerSucursalParaVenta).HasColumnName("ter_sucursal_paraVenta");
        builder.Property(e => e.TerSucursalSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal");
        builder.Property(e => e.TerSucursalSucursalCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal_codigo");
        builder.Property(e => e.TerSucursalTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_telefono");
        builder.Property(e => e.TerTerceroClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_clasificacion");
        builder.Property(e => e.TerTerceroContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_contacto");
        builder.Property(e => e.TerTerceroDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_direccion");
        builder.Property(e => e.TerTerceroEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_email");
        builder.Property(e => e.TerTerceroEsCliente).HasColumnName("ter_tercero_esCliente");
        builder.Property(e => e.TerTerceroEsEmpresaPropia).HasColumnName("ter_tercero_esEmpresaPropia");
        builder.Property(e => e.TerTerceroEsFabricante).HasColumnName("ter_tercero_esFabricante");
        builder.Property(e => e.TerTerceroEsProspecto).HasColumnName("ter_tercero_esProspecto");
        builder.Property(e => e.TerTerceroEsProveedor).HasColumnName("ter_tercero_esProveedor");
        builder.Property(e => e.TerTerceroEsTransportador).HasColumnName("ter_tercero_esTransportador");
        builder.Property(e => e.TerTerceroFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fax");
        builder.Property(e => e.TerTerceroIdEstadoTercero).HasColumnName("ter_tercero_id_estadoTercero");
        builder.Property(e => e.TerTerceroIdNaturalezaTercero).HasColumnName("ter_tercero_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroIdZona).HasColumnName("ter_tercero_id_zona");
        builder.Property(e => e.TerTerceroNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_notas");
        builder.Property(e => e.TerTerceroRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_representante");
        builder.Property(e => e.TerTerceroTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_telefono");
        builder.Property(e => e.TerTerceroTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero");
        builder.Property(e => e.TerTerceroTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_codigo");
        builder.Property(e => e.TerTerceroTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_nit");
        builder.Property(e => e.TerTerceroTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_website");
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
    }
}
