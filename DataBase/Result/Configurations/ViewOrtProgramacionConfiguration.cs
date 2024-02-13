using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewOrtProgramacionConfiguration : IEntityTypeConfiguration<ViewOrtProgramacion>
{
    public void Configure(EntityTypeBuilder<ViewOrtProgramacion> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_ort_programacion");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoActividadBloquearCostear).HasColumnName("cat_catalogo_actividad_bloquearCostear");
        builder.Property(e => e.CatCatalogoActividadCatalogoActividad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.actividad_catalogo.actividad");
        builder.Property(e => e.CatCatalogoActividadCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_catalogo_codigo");
        builder.Property(e => e.CatCatalogoActividadCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_codigoInventario");
        builder.Property(e => e.CatCatalogoActividadDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_actividad_descripcion");
        builder.Property(e => e.CatCatalogoActividadDuracionEstimada).HasColumnName("cat_catalogo.actividad_duracionEstimada");
        builder.Property(e => e.CatCatalogoActividadEsNacional).HasColumnName("cat_catalogo_actividad_esNacional");
        builder.Property(e => e.CatCatalogoActividadEsProductiva).HasColumnName("cat_catalogo.actividad_esProductiva");
        builder.Property(e => e.CatCatalogoActividadIdFamilia).HasColumnName("cat_catalogo_actividad_id_familia");
        builder.Property(e => e.CatCatalogoActividadIdImpuesto).HasColumnName("cat_catalogo_actividad_id_impuesto");
        builder.Property(e => e.CatCatalogoActividadIdSubTipoCatalogo).HasColumnName("cat_catalogo_actividad_id_subTipoCatalogo");
        builder.Property(e => e.CatCatalogoActividadIdUnidad).HasColumnName("cat_catalogo_actividad_id_unidad");
        builder.Property(e => e.CatCatalogoActividadPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_actividad_precioVenta");
        builder.Property(e => e.CatCatalogoActividadProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.actividad_procedimiento");
        builder.Property(e => e.CatCatalogoActividadTiempoConsecucion).HasColumnName("cat_catalogo_actividad_tiempoConsecucion");
        builder.Property(e => e.Comentario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("comentario");
        builder.Property(e => e.Costo).HasColumnName("costo");
        builder.Property(e => e.DesdeFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("desde_fh");
        builder.Property(e => e.DocDocumentoOtCargo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_cargo");
        builder.Property(e => e.DocDocumentoOtCompromisos)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_compromisos");
        builder.Property(e => e.DocDocumentoOtContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_contacto");
        builder.Property(e => e.DocDocumentoOtCosto).HasColumnName("doc_documento_ot_costo");
        builder.Property(e => e.DocDocumentoOtCostoPlaneado).HasColumnName("doc_documento_ot_costoPlaneado");
        builder.Property(e => e.DocDocumentoOtDescuento).HasColumnName("doc_documento_ot_descuento");
        builder.Property(e => e.DocDocumentoOtDescuentoPlaneado).HasColumnName("doc_documento_ot_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoOtDiagnosticoInicial)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_diagnosticoInicial");
        builder.Property(e => e.DocDocumentoOtDireccionUbicacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_direccionUbicacion");
        builder.Property(e => e.DocDocumentoOtDistribuyeCentros).HasColumnName("doc_documento.ot_distribuyeCentros");
        builder.Property(e => e.DocDocumentoOtDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_documento_codigo");
        builder.Property(e => e.DocDocumentoOtDocumentoNumero).HasColumnName("doc_documento_ot_documento_numero");
        builder.Property(e => e.DocDocumentoOtDocumentoOt)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_documento.ot");
        builder.Property(e => e.DocDocumentoOtDuracionEstimada).HasColumnName("doc_documento.ot_duracionEstimada");
        builder.Property(e => e.DocDocumentoOtEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_email");
        builder.Property(e => e.DocDocumentoOtEnTaller).HasColumnName("doc_documento.ot_enTaller");
        builder.Property(e => e.DocDocumentoOtFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_fax");
        builder.Property(e => e.DocDocumentoOtFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoOtFechaCompromisoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.ot_fechaCompromiso_fh");
        builder.Property(e => e.DocDocumentoOtFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fecha_fh");
        builder.Property(e => e.DocDocumentoOtFechaGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento.ot_fechaGarantia_ff");
        builder.Property(e => e.DocDocumentoOtFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoOtFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_ot_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoOtIdContrato).HasColumnName("doc_documento.ot_id_contrato");
        builder.Property(e => e.DocDocumentoOtIdDepartamentoSolicitud).HasColumnName("doc_documento.ot_id_departamentoSolicitud");
        builder.Property(e => e.DocDocumentoOtIdDocumento).HasColumnName("doc_documento_ot_id_documento");
        builder.Property(e => e.DocDocumentoOtIdEquipo).HasColumnName("doc_documento.ot_id_equipo");
        builder.Property(e => e.DocDocumentoOtIdEstadoTipoDocumento).HasColumnName("doc_documento_ot_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoOtIdMoneda).HasColumnName("doc_documento_ot_id_moneda");
        builder.Property(e => e.DocDocumentoOtIdMotivoCancelacion).HasColumnName("doc_documento.ot_id_motivoCancelacion");
        builder.Property(e => e.DocDocumentoOtIdMotivoestado).HasColumnName("doc_documento_ot_id_motivoestado");
        builder.Property(e => e.DocDocumentoOtIdPrioridadDocumento).HasColumnName("doc_documento_ot_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoOtIdSistema).HasColumnName("doc_documento.ot_id_sistema");
        builder.Property(e => e.DocDocumentoOtIdSubtipoDocumento).HasColumnName("doc_documento_ot_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoOtIdSucursal).HasColumnName("doc_documento.ot_id_sucursal");
        builder.Property(e => e.DocDocumentoOtIdTerceroCliente).HasColumnName("doc_documento_ot_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoOtIdTerceroProveedor).HasColumnName("doc_documento_ot_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoOtIdTipoServicio).HasColumnName("doc_documento.ot_id_tipoServicio");
        builder.Property(e => e.DocDocumentoOtIdUsuarioCoordinador).HasColumnName("doc_documento.ot_id_usuario_coordinador");
        builder.Property(e => e.DocDocumentoOtIdZona).HasColumnName("doc_documento.ot_id_zona");
        builder.Property(e => e.DocDocumentoOtIva).HasColumnName("doc_documento_ot_iva");
        builder.Property(e => e.DocDocumentoOtIvaPlaneado).HasColumnName("doc_documento_ot_ivaPlaneado");
        builder.Property(e => e.DocDocumentoOtMotivoServicio)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_motivoServicio");
        builder.Property(e => e.DocDocumentoOtPorcentajeCliente).HasColumnName("doc_documento.ot_porcentajeCliente");
        builder.Property(e => e.DocDocumentoOtPorcentajeDistribuidor).HasColumnName("doc_documento.ot_porcentajeDistribuidor");
        builder.Property(e => e.DocDocumentoOtPorcentajeFabricante).HasColumnName("doc_documento.ot_porcentajeFabricante");
        builder.Property(e => e.DocDocumentoOtPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_ot_prefijo");
        builder.Property(e => e.DocDocumentoOtReclamacionFabrica)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_reclamacionFabrica");
        builder.Property(e => e.DocDocumentoOtRecomendaciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_recomendaciones");
        builder.Property(e => e.DocDocumentoOtRentabilidad).HasColumnName("doc_documento_ot_rentabilidad");
        builder.Property(e => e.DocDocumentoOtSegunTempario).HasColumnName("doc_documento.ot_segunTempario");
        builder.Property(e => e.DocDocumentoOtSubtotal).HasColumnName("doc_documento_ot_subtotal");
        builder.Property(e => e.DocDocumentoOtSubtotalPlaneado).HasColumnName("doc_documento_ot_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoOtTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_telefono");
        builder.Property(e => e.DocDocumentoOtTotal).HasColumnName("doc_documento_ot_total");
        builder.Property(e => e.DocDocumentoOtTotalPlaneado).HasColumnName("doc_documento_ot_totalPlaneado");
        builder.Property(e => e.DocDocumentoOtTrabajos)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documento.ot_trabajos");
        builder.Property(e => e.DocDocumentoOtTrm).HasColumnName("doc_documento_ot_trm");
        builder.Property(e => e.DocSoporteItemDocumentoCosto)
            .HasColumnType("money")
            .HasColumnName("doc_soporteItemDocumento_Costo");
        builder.Property(e => e.DocSoporteItemDocumentoDuracionEjecutada).HasColumnName("doc_soporteItemDocumento_duracionEjecutada");
        builder.Property(e => e.DocSoporteItemDocumentoDuracionPlaneada).HasColumnName("doc_soporteItemDocumento_duracionPlaneada");
        builder.Property(e => e.DocSoporteItemDocumentoIdItemDocumento).HasColumnName("doc_soporteItemDocumento_id_itemDocumento");
        builder.Property(e => e.DocSoporteItemDocumentoIdUsuario).HasColumnName("doc_soporteItemDocumento_id_usuario");
        builder.Property(e => e.DocSoporteItemDocumentoSoporteItemDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_soporteItemDocumento_soporteItemDocumento");
        builder.Property(e => e.DocSoporteItemDocumentoSoporteItemDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_soporteItemDocumento_soporteItemDocumento_codigo");
        builder.Property(e => e.DocSoporteItemDocumentoValor)
            .HasColumnType("money")
            .HasColumnName("doc_soporteItemDocumento_Valor");
        builder.Property(e => e.Duracion).HasColumnName("duracion");
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
        builder.Property(e => e.HastaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("hasta_fh");
        builder.Property(e => e.Id).HasColumnName("id");
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
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.OrtMotivoCancelacionMotivoCancelacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_motivoCancelacion_motivoCancelacion");
        builder.Property(e => e.OrtMotivoCancelacionMotivoCancelacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_motivoCancelacion_motivoCancelacion_codigo");
        builder.Property(e => e.OrtMotivoCancelacionResponsableServicio).HasColumnName("ort_motivoCancelacion_responsableServicio");
        builder.Property(e => e.OrtProgramacionPadreComentario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_programacion_padre_comentario");
        builder.Property(e => e.OrtProgramacionPadreCosto).HasColumnName("ort_programacion_padre_costo");
        builder.Property(e => e.OrtProgramacionPadreDesdeFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("ort_programacion_padre_desde_fh");
        builder.Property(e => e.OrtProgramacionPadreDuracion).HasColumnName("ort_programacion_padre_duracion");
        builder.Property(e => e.OrtProgramacionPadreIdCatalogoActividad).HasColumnName("ort_programacion_padre_id_catalogo.actividad");
        builder.Property(e => e.OrtProgramacionPadreIdDocumentoOt).HasColumnName("ort_programacion_padre_id_documento.ot");
        builder.Property(e => e.OrtProgramacionPadreIdMotivoCancelacion).HasColumnName("ort_programacion_padre_id_motivoCancelacion");
        builder.Property(e => e.OrtProgramacionPadreIdProgramacion).HasColumnName("ort_programacion_padre_id_programacion");
        builder.Property(e => e.OrtProgramacionPadreIdReporteTecnico).HasColumnName("ort_programacion_padre_id_reporteTecnico");
        builder.Property(e => e.OrtProgramacionPadreIdSoporteItemDocumento).HasColumnName("ort_programacion_padre_id_soporteItemDocumento");
        builder.Property(e => e.OrtProgramacionPadreIdTipoProgramacion).HasColumnName("ort_programacion_padre_id_tipoProgramacion");
        builder.Property(e => e.OrtProgramacionPadreIdUsuario).HasColumnName("ort_programacion_padre_id_usuario");
        builder.Property(e => e.OrtProgramacionPadreProgramacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_programacion_padre_programacion");
        builder.Property(e => e.OrtProgramacionPadreProgramacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_programacion_padre_programacion_codigo");
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
        builder.Property(e => e.OrtTipoProgramacionTipoProgramacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_tipoProgramacion_tipoProgramacion");
        builder.Property(e => e.OrtTipoProgramacionTipoProgramacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_tipoProgramacion_tipoProgramacion_codigo");
        builder.Property(e => e.Programacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("programacion");
        builder.Property(e => e.ProgramacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("programacion_codigo");
        builder.Property(e => e.SegUsuarioAccesoActivo).HasColumnName("seg_usuario_accesoActivo");
        builder.Property(e => e.SegUsuarioAplicaRecargo).HasColumnName("seg_usuario_aplicaRecargo");
        builder.Property(e => e.SegUsuarioCambiarClave).HasColumnName("seg_usuario_cambiarClave");
        builder.Property(e => e.SegUsuarioCargo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_cargo");
        builder.Property(e => e.SegUsuarioClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_clave");
        builder.Property(e => e.SegUsuarioCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_costoHora");
        builder.Property(e => e.SegUsuarioDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_direccion");
        builder.Property(e => e.SegUsuarioEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_email");
        builder.Property(e => e.SegUsuarioFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioHabilitado).HasColumnName("seg_usuario_habilitado");
        builder.Property(e => e.SegUsuarioIdCargo).HasColumnName("seg_usuario_id_cargo");
        builder.Property(e => e.SegUsuarioIdGrupo).HasColumnName("seg_usuario_id_grupo");
        builder.Property(e => e.SegUsuarioIdPerfil).HasColumnName("seg_usuario_id_perfil");
        builder.Property(e => e.SegUsuarioIdUsuario).HasColumnName("seg_usuario_id_usuario");
        builder.Property(e => e.SegUsuarioIdZona).HasColumnName("seg_usuario_id_zona");
        builder.Property(e => e.SegUsuarioIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_identificacion");
        builder.Property(e => e.SegUsuarioIntentosFallidos).HasColumnName("seg_usuario_intentosFallidos");
        builder.Property(e => e.SegUsuarioNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_nombre");
        builder.Property(e => e.SegUsuarioNumeroIngresos).HasColumnName("seg_usuario_numeroIngresos");
        builder.Property(e => e.SegUsuarioPorcentajeComision).HasColumnName("seg_usuario_porcentajeComision");
        builder.Property(e => e.SegUsuarioPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_preferencias");
        builder.Property(e => e.SegUsuarioProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_profesion");
        builder.Property(e => e.SegUsuarioSexo).HasColumnName("seg_usuario_sexo");
        builder.Property(e => e.SegUsuarioTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_telefono");
        builder.Property(e => e.SegUsuarioUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_usuario");
        builder.Property(e => e.SegUsuarioUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_usuario_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
