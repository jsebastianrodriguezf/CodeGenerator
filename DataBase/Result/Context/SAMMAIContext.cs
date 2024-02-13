using Microsoft.EntityFrameworkCore;
using SAMMAI.DataBase.Repository.Configurations;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Context;

public class SAMMAIContext : DbContext
{
    public SAMMAIContext() { }

    public SAMMAIContext(DbContextOptions<SAMMAIContext> options)
        : base(options) { }

    #region DBSet
    public virtual DbSet<AlqDetallealquilerItemdocumento> AlqDetallealquilerItemdocumentos { get; set; }
    public virtual DbSet<AlqDetalleLiquidacion> AlqDetalleLiquidacions { get; set; }
    public virtual DbSet<AlqHistoricoAlquiler> AlqHistoricoAlquilers { get; set; }
    public virtual DbSet<AlqPeriodoAlquiler> AlqPeriodoAlquilers { get; set; }
    public virtual DbSet<AlqTarifa> AlqTarifas { get; set; }
    public virtual DbSet<AlqTipoTarifa> AlqTipoTarifas { get; set; }
    public virtual DbSet<CatAtributo> CatAtributos { get; set; }
    public virtual DbSet<CatAtributoOpcionAtributo> CatAtributoOpcionAtributos { get; set; }
    public virtual DbSet<CatCatalogo> CatCatalogos { get; set; }
    public virtual DbSet<CatCatalogoActividad> CatCatalogoActividads { get; set; }
    public virtual DbSet<CatCatalogoBodega> CatCatalogoBodegas { get; set; }
    public virtual DbSet<CatCatalogoEquipo> CatCatalogoEquipos { get; set; }
    public virtual DbSet<CatCatalogoEquipoCatalogoTempario> CatCatalogoEquipoCatalogoTemparios { get; set; }
    public virtual DbSet<CatCatalogoEquipoPruebaCheckList> CatCatalogoEquipoPruebaCheckLists { get; set; }
    public virtual DbSet<CatCatalogoListaPrecio> CatCatalogoListaPrecios { get; set; }
    public virtual DbSet<CatCatalogoOtro> CatCatalogoOtros { get; set; }
    public virtual DbSet<CatCatalogoProducto> CatCatalogoProductos { get; set; }
    public virtual DbSet<CatCatalogoRepuesto> CatCatalogoRepuestos { get; set; }
    public virtual DbSet<CatCatalogoTempario> CatCatalogoTemparios { get; set; }
    public virtual DbSet<CatDetalleRepuesto> CatDetalleRepuestos { get; set; }
    public virtual DbSet<CatDetalleTempario> CatDetalleTemparios { get; set; }
    public virtual DbSet<CatDimension> CatDimensions { get; set; }
    public virtual DbSet<CatListaPrecio> CatListaPrecios { get; set; }
    public virtual DbSet<CatMarca> CatMarcas { get; set; }
    public virtual DbSet<CatPosicion> CatPosicions { get; set; }
    public virtual DbSet<CatPruebaCheckList> CatPruebaCheckLists { get; set; }
    public virtual DbSet<CatPruebaCheckListAtributo> CatPruebaCheckListAtributos { get; set; }
    public virtual DbSet<CatReemplazo> CatReemplazos { get; set; }
    public virtual DbSet<CatReemplazoCatalogoEquipo> CatReemplazoCatalogoEquipos { get; set; }
    public virtual DbSet<CatSeccionAtributo> CatSeccionAtributos { get; set; }
    public virtual DbSet<CatSistema> CatSistemas { get; set; }
    public virtual DbSet<CatSistemaCatalogoEquipo> CatSistemaCatalogoEquipos { get; set; }
    public virtual DbSet<CatSoporteActividad> CatSoporteActividads { get; set; }
    public virtual DbSet<CatSubtipoCatalogo> CatSubtipoCatalogos { get; set; }
    public virtual DbSet<CatTarifa> CatTarifas { get; set; }
    public virtual DbSet<CatTarifaCatalogo> CatTarifaCatalogos { get; set; }
    public virtual DbSet<CatTarifaRango> CatTarifaRangos { get; set; }
    public virtual DbSet<CatTipoCatalogo> CatTipoCatalogos { get; set; }
    public virtual DbSet<CatTipoCatalogoListaPrecio> CatTipoCatalogoListaPrecios { get; set; }
    public virtual DbSet<CatTipoReemplazo> CatTipoReemplazos { get; set; }
    public virtual DbSet<CatUsoSeccionAtributo> CatUsoSeccionAtributos { get; set; }
    public virtual DbSet<CatVersionEquipo> CatVersionEquipos { get; set; }
    public virtual DbSet<CatVersionEquipoDetalleTempario> CatVersionEquipoDetalleTemparios { get; set; }
    public virtual DbSet<CntConfigContrato> CntConfigContratos { get; set; }
    public virtual DbSet<CntContrato> CntContratos { get; set; }
    public virtual DbSet<CntContratoCatalogo> CntContratoCatalogos { get; set; }
    public virtual DbSet<CntContratoDetalleVisitum> CntContratoDetalleVisitums { get; set; }
    public virtual DbSet<CntContratoEquipo> CntContratoEquipos { get; set; }
    public virtual DbSet<CntContratoSucursal> CntContratoSucursals { get; set; }
    public virtual DbSet<CntContratoTipoServicio> CntContratoTipoServicios { get; set; }
    public virtual DbSet<CntContratoZona> CntContratoZonas { get; set; }
    public virtual DbSet<CntCorrimientoVisitaFija> CntCorrimientoVisitaFijas { get; set; }
    public virtual DbSet<CntPagosContrato> CntPagosContratos { get; set; }
    public virtual DbSet<CntPeriodoContrato> CntPeriodoContratos { get; set; }
    public virtual DbSet<CntTiempoRespuestum> CntTiempoRespuestums { get; set; }
    public virtual DbSet<CntTipoContrato> CntTipoContratos { get; set; }
    public virtual DbSet<CntVisitaFija> CntVisitaFijas { get; set; }
    public virtual DbSet<CntVisitaFijaCatalogo> CntVisitaFijaCatalogos { get; set; }
    public virtual DbSet<Columna> Columnas { get; set; }
    public virtual DbSet<ComComision> ComComisions { get; set; }
    public virtual DbSet<DisEstadoEvento> DisEstadoEventos { get; set; }
    public virtual DbSet<DisEvento> DisEventos { get; set; }
    public virtual DbSet<DisEventoCatalogo> DisEventoCatalogos { get; set; }
    public virtual DbSet<DisEventoEstadoEvento> DisEventoEstadoEventos { get; set; }
    public virtual DbSet<DisMetodoDeteccion> DisMetodoDeteccions { get; set; }
    public virtual DbSet<DisMotivoEvento> DisMotivoEventos { get; set; }
    public virtual DbSet<DisObra> DisObras { get; set; }
    public virtual DbSet<DisObraCatalogo> DisObraCatalogos { get; set; }
    public virtual DbSet<DisObraEquipo> DisObraEquipos { get; set; }
    public virtual DbSet<DocCentroCosto> DocCentroCostos { get; set; }
    public virtual DbSet<DocCondicion> DocCondicions { get; set; }
    public virtual DbSet<DocCosteo> DocCosteos { get; set; }
    public virtual DbSet<DocDocumento> DocDocumentos { get; set; }
    public virtual DbSet<DocDocumentoAlquiler> DocDocumentoAlquilers { get; set; }
    public virtual DbSet<DocDocumentoAtributo> DocDocumentoAtributos { get; set; }
    public virtual DbSet<DocDocumentoCatalogoTempario> DocDocumentoCatalogoTemparios { get; set; }
    public virtual DbSet<DocDocumentoComentario> DocDocumentoComentarios { get; set; }
    public virtual DbSet<DocDocumentoContacto> DocDocumentoContactos { get; set; }
    public virtual DbSet<DocDocumentoCotizacion> DocDocumentoCotizacions { get; set; }
    public virtual DbSet<DocDocumentoCotizacionCondicion> DocDocumentoCotizacionCondicions { get; set; }
    public virtual DbSet<DocDocumentoEntradum> DocDocumentoEntradums { get; set; }
    public virtual DbSet<DocDocumentoEstadoTipoDocumento> DocDocumentoEstadoTipoDocumentos { get; set; }
    public virtual DbSet<DocDocumentoEvaluacion> DocDocumentoEvaluacions { get; set; }
    public virtual DbSet<DocDocumentoGasto> DocDocumentoGastos { get; set; }
    public virtual DbSet<DocDocumentoOpcionRespuestum> DocDocumentoOpcionRespuestums { get; set; }
    public virtual DbSet<DocDocumentoOrdenCompra> DocDocumentoOrdenCompras { get; set; }
    public virtual DbSet<DocDocumentoOt> DocDocumentoOts { get; set; }
    public virtual DbSet<DocDocumentoOtCentroCosto> DocDocumentoOtCentroCostos { get; set; }
    public virtual DbSet<DocDocumentoOtPruebaCheckList> DocDocumentoOtPruebaCheckLists { get; set; }
    public virtual DbSet<DocDocumentoProyecto> DocDocumentoProyectos { get; set; }
    public virtual DbSet<DocDocumentoProyectoCalidad> DocDocumentoProyectoCalidads { get; set; }
    public virtual DbSet<DocDocumentoProyectoEjecutore> DocDocumentoProyectoEjecutores { get; set; }
    public virtual DbSet<DocDocumentoProyectoEntregable> DocDocumentoProyectoEntregables { get; set; }
    public virtual DbSet<DocDocumentoProyectoEtapa> DocDocumentoProyectoEtapas { get; set; }
    public virtual DbSet<DocDocumentoProyectoSucursal> DocDocumentoProyectoSucursals { get; set; }
    public virtual DbSet<DocDocumentoRequisicion> DocDocumentoRequisicions { get; set; }
    public virtual DbSet<DocDocumentoSalidum> DocDocumentoSalidums { get; set; }
    public virtual DbSet<DocDocumentoSolicitud> DocDocumentoSolicituds { get; set; }
    public virtual DbSet<DocDocumentoTraslado> DocDocumentoTraslados { get; set; }
    public virtual DbSet<DocEstadoTipoDocumento> DocEstadoTipoDocumentos { get; set; }
    public virtual DbSet<DocEstadoTipoDocumentoPerfil> DocEstadoTipoDocumentoPerfils { get; set; }
    public virtual DbSet<DocEstadoTipoDocumentoSubtipoDocumento> DocEstadoTipoDocumentoSubtipoDocumentos { get; set; }
    public virtual DbSet<DocEstrategiaPrioridad> DocEstrategiaPrioridads { get; set; }
    public virtual DbSet<DocEvaluacion> DocEvaluacions { get; set; }
    public virtual DbSet<DocFlujoDocumento> DocFlujoDocumentos { get; set; }
    public virtual DbSet<DocFormaPago> DocFormaPagos { get; set; }
    public virtual DbSet<DocIncoterm> DocIncoterms { get; set; }
    public virtual DbSet<DocItemDocumento> DocItemDocumentos { get; set; }
    public virtual DbSet<DocMedioSolicitud> DocMedioSolicituds { get; set; }
    public virtual DbSet<DocMotivoestado> DocMotivoestados { get; set; }
    public virtual DbSet<DocOpcionCondicion> DocOpcionCondicions { get; set; }
    public virtual DbSet<DocOpcionRespuestum> DocOpcionRespuestums { get; set; }
    public virtual DbSet<DocPendienteDocumento> DocPendienteDocumentos { get; set; }
    public virtual DbSet<DocPendienteDocumentoDocItemDocumento> DocPendienteDocumentoDocItemDocumentos { get; set; }
    public virtual DbSet<DocPreguntum> DocPreguntums { get; set; }
    public virtual DbSet<DocPrioridadDocumento> DocPrioridadDocumentos { get; set; }
    public virtual DbSet<DocPrioridadSubtipoDocumento> DocPrioridadSubtipoDocumentos { get; set; }
    public virtual DbSet<DocSoporteItemDocumento> DocSoporteItemDocumentos { get; set; }
    public virtual DbSet<DocSubtipoDocumento> DocSubtipoDocumentos { get; set; }
    public virtual DbSet<DocSubtipoLectura> DocSubtipoLecturas { get; set; }
    public virtual DbSet<DocTarea> DocTareas { get; set; }
    public virtual DbSet<DocTipoDocumento> DocTipoDocumentos { get; set; }
    public virtual DbSet<DocTipoPendiente> DocTipoPendientes { get; set; }
    public virtual DbSet<EquAlquiler> EquAlquilers { get; set; }
    public virtual DbSet<EquAnalisisFalla> EquAnalisisFallas { get; set; }
    public virtual DbSet<EquCampana> EquCampanas { get; set; }
    public virtual DbSet<EquCampanaDocumentoOt> EquCampanaDocumentoOts { get; set; }
    public virtual DbSet<EquCicloHorometro> EquCicloHorometros { get; set; }
    public virtual DbSet<EquDetalleAlquiler> EquDetalleAlquilers { get; set; }
    public virtual DbSet<EquDetallePagoAlquiler> EquDetallePagoAlquilers { get; set; }
    public virtual DbSet<EquEquipo> EquEquipos { get; set; }
    public virtual DbSet<EquEquipoAtributo> EquEquipoAtributos { get; set; }
    public virtual DbSet<EquEquipoItemDocumento> EquEquipoItemDocumentos { get; set; }
    public virtual DbSet<EquEstadoEquipo> EquEstadoEquipos { get; set; }
    public virtual DbSet<EquEstadoPrestamo> EquEstadoPrestamos { get; set; }
    public virtual DbSet<EquFalla> EquFallas { get; set; }
    public virtual DbSet<EquFamiliaFalla> EquFamiliaFallas { get; set; }
    public virtual DbSet<EquOpcionAtributo> EquOpcionAtributos { get; set; }
    public virtual DbSet<EquOpcionAtributoDependiente> EquOpcionAtributoDependientes { get; set; }
    public virtual DbSet<EquOverhall> EquOverhalls { get; set; }
    public virtual DbSet<EquPagoAlquiler> EquPagoAlquilers { get; set; }
    public virtual DbSet<EquPrestamo> EquPrestamos { get; set; }
    public virtual DbSet<EquPrestamoEquipo> EquPrestamoEquipos { get; set; }
    public virtual DbSet<EquTipoAtributo> EquTipoAtributos { get; set; }
    public virtual DbSet<EquTipoFalla> EquTipoFallas { get; set; }
    public virtual DbSet<EquTipoTrazabilidad> EquTipoTrazabilidads { get; set; }
    public virtual DbSet<EquTrazabilidad> EquTrazabilidads { get; set; }
    public virtual DbSet<Errore> Errores { get; set; }
    public virtual DbSet<GasDetalleGasto> GasDetalleGastos { get; set; }
    public virtual DbSet<GasDocumentoOtDetalleGasto> GasDocumentoOtDetalleGastos { get; set; }
    public virtual DbSet<GasGasto> GasGastos { get; set; }
    public virtual DbSet<GasTipoGasto> GasTipoGastos { get; set; }
    public virtual DbSet<GenAccesosSamm> GenAccesosSamms { get; set; }
    public virtual DbSet<GenAccionNotificacion> GenAccionNotificacions { get; set; }
    public virtual DbSet<GenArchivo> GenArchivos { get; set; }
    public virtual DbSet<GenBodega> GenBodegas { get; set; }
    public virtual DbSet<GenBodegaUsuario> GenBodegaUsuarios { get; set; }
    public virtual DbSet<GenConfig> GenConfigs { get; set; }
    public virtual DbSet<GenConfiguracionAtributo> GenConfiguracionAtributos { get; set; }
    public virtual DbSet<GenConfiguracionServicio> GenConfiguracionServicios { get; set; }
    public virtual DbSet<GenDetalleFormulario> GenDetalleFormularios { get; set; }
    public virtual DbSet<GenDetalleRegistroEnvio> GenDetalleRegistroEnvios { get; set; }
    public virtual DbSet<GenDiaFestivo> GenDiaFestivos { get; set; }
    public virtual DbSet<GenEmpresa> GenEmpresas { get; set; }
    public virtual DbSet<GenEnvioCorreo> GenEnvioCorreos { get; set; }
    public virtual DbSet<GenFamilium> GenFamiliums { get; set; }
    public virtual DbSet<GenFirma> GenFirmas { get; set; }
    public virtual DbSet<GenFirmaContacto> GenFirmaContactos { get; set; }
    public virtual DbSet<GenFormulario> GenFormularios { get; set; }
    public virtual DbSet<GenImpuesto> GenImpuestos { get; set; }
    public virtual DbSet<GenLocalizacion> GenLocalizacions { get; set; }
    public virtual DbSet<GenLocalizacionItemDocumento> GenLocalizacionItemDocumentos { get; set; }
    public virtual DbSet<GenMonedum> GenMonedums { get; set; }
    public virtual DbSet<GenNotificacion> GenNotificacions { get; set; }
    public virtual DbSet<GenPresupuestoEmpresa> GenPresupuestoEmpresas { get; set; }
    public virtual DbSet<GenRegistroEnvio> GenRegistroEnvios { get; set; }
    public virtual DbSet<GenRemitenteCorreo> GenRemitenteCorreos { get; set; }
    public virtual DbSet<GenTipoArchivo> GenTipoArchivos { get; set; }
    public virtual DbSet<GenTipoDato> GenTipoDatos { get; set; }
    public virtual DbSet<GenTipoNotificacion> GenTipoNotificacions { get; set; }
    public virtual DbSet<GenTipoServicio> GenTipoServicios { get; set; }
    public virtual DbSet<GenUnidad> GenUnidads { get; set; }
    public virtual DbSet<GenZona> GenZonas { get; set; }
    public virtual DbSet<GeoUbicacion> GeoUbicacions { get; set; }
    public virtual DbSet<GuiAplicacion> GuiAplicacions { get; set; }
    public virtual DbSet<GuiAyudum> GuiAyudums { get; set; }
    public virtual DbSet<GuiBloqueHome> GuiBloqueHomes { get; set; }
    public virtual DbSet<GuiCampoTexto> GuiCampoTextos { get; set; }
    public virtual DbSet<GuiDetalleBloqueHome> GuiDetalleBloqueHomes { get; set; }
    public virtual DbSet<GuiFuncionalidad> GuiFuncionalidads { get; set; }
    public virtual DbSet<GuiTextoDefecto> GuiTextoDefectos { get; set; }
    public virtual DbSet<GuiTipoFuncionalidad> GuiTipoFuncionalidads { get; set; }
    public virtual DbSet<Idae> Idaes { get; set; }
    public virtual DbSet<LicCatalogoParametro> LicCatalogoParametros { get; set; }
    public virtual DbSet<LicLicenciaParametro> LicLicenciaParametros { get; set; }
    public virtual DbSet<LicLicencium> LicLicenciums { get; set; }
    public virtual DbSet<LicParametro> LicParametros { get; set; }
    public virtual DbSet<OrtCanalAtencion> OrtCanalAtencions { get; set; }
    public virtual DbSet<OrtDepartamentoSolicitud> OrtDepartamentoSolicituds { get; set; }
    public virtual DbSet<OrtMotivoCancelacion> OrtMotivoCancelacions { get; set; }
    public virtual DbSet<OrtProgramacion> OrtProgramacions { get; set; }
    public virtual DbSet<OrtReporteTecnico> OrtReporteTecnicos { get; set; }
    public virtual DbSet<OrtReporteTecnicoFalla> OrtReporteTecnicoFallas { get; set; }
    public virtual DbSet<OrtReporteTecnicoOt> OrtReporteTecnicoOts { get; set; }
    public virtual DbSet<OrtTipoProgramacion> OrtTipoProgramacions { get; set; }
    public virtual DbSet<OrtVale> OrtVales { get; set; }
    public virtual DbSet<ProActividad> ProActividads { get; set; }
    public virtual DbSet<ProActividadEjecutor> ProActividadEjecutors { get; set; }
    public virtual DbSet<ProActividadEtapa> ProActividadEtapas { get; set; }
    public virtual DbSet<ProActividadHito> ProActividadHitos { get; set; }
    public virtual DbSet<ProActividadPredecesora> ProActividadPredecesoras { get; set; }
    public virtual DbSet<ProActividadRecursoFisico> ProActividadRecursoFisicos { get; set; }
    public virtual DbSet<ProCalidad> ProCalidads { get; set; }
    public virtual DbSet<ProEjecutore> ProEjecutores { get; set; }
    public virtual DbSet<ProEjecutoresArchivo> ProEjecutoresArchivos { get; set; }
    public virtual DbSet<ProEntregable> ProEntregables { get; set; }
    public virtual DbSet<ProEtapa> ProEtapas { get; set; }
    public virtual DbSet<ProFactorexito> ProFactorexitos { get; set; }
    public virtual DbSet<ProGrupoSesion> ProGrupoSesions { get; set; }
    public virtual DbSet<ProHito> ProHitos { get; set; }
    public virtual DbSet<ProHorarioEjecutore> ProHorarioEjecutores { get; set; }
    public virtual DbSet<ProHorarioProyecto> ProHorarioProyectos { get; set; }
    public virtual DbSet<ProHorarioTrabajo> ProHorarioTrabajos { get; set; }
    public virtual DbSet<ProRecursoFisico> ProRecursoFisicos { get; set; }
    public virtual DbSet<ProReporteActividad> ProReporteActividads { get; set; }
    public virtual DbSet<ProRol> ProRols { get; set; }
    public virtual DbSet<ProRolContacto> ProRolContactos { get; set; }
    public virtual DbSet<ProSesionActividad> ProSesionActividads { get; set; }
    public virtual DbSet<RepCampoReporte> RepCampoReportes { get; set; }
    public virtual DbSet<RepCategorium> RepCategoriums { get; set; }
    public virtual DbSet<RepIndicador> RepIndicadors { get; set; }
    public virtual DbSet<RepOpcionReporte> RepOpcionReportes { get; set; }
    public virtual DbSet<RepOrigenDato> RepOrigenDatos { get; set; }
    public virtual DbSet<RepReporte> RepReportes { get; set; }
    public virtual DbSet<RepReporteCategorium> RepReporteCategoriums { get; set; }
    public virtual DbSet<RepTipoCampoReporte> RepTipoCampoReportes { get; set; }
    public virtual DbSet<SegCargo> SegCargos { get; set; }
    public virtual DbSet<SegCargoActividad> SegCargoActividads { get; set; }
    public virtual DbSet<SegCargoEnvioCorreo> SegCargoEnvioCorreos { get; set; }
    public virtual DbSet<SegGrupo> SegGrupos { get; set; }
    public virtual DbSet<SegPerfil> SegPerfils { get; set; }
    public virtual DbSet<SegPerfilBloqueHome> SegPerfilBloqueHomes { get; set; }
    public virtual DbSet<SegPerfilFormulario> SegPerfilFormularios { get; set; }
    public virtual DbSet<SegPerfilFuncionalidad> SegPerfilFuncionalidads { get; set; }
    public virtual DbSet<SegPerfilSubtipoDocumento> SegPerfilSubtipoDocumentos { get; set; }
    public virtual DbSet<SegPerfilTercero> SegPerfilTerceros { get; set; }
    public virtual DbSet<SegRegistroIntegracion> SegRegistroIntegracions { get; set; }
    public virtual DbSet<SegRegistroPeticion> SegRegistroPeticions { get; set; }
    public virtual DbSet<SegSesion> SegSesions { get; set; }
    public virtual DbSet<SegSesionHistorico> SegSesionHistoricos { get; set; }
    public virtual DbSet<SegUsuario> SegUsuarios { get; set; }
    public virtual DbSet<SegUsuarioCatalogoEquipo> SegUsuarioCatalogoEquipos { get; set; }
    public virtual DbSet<SynCampoIntegracion> SynCampoIntegracions { get; set; }
    public virtual DbSet<SynPuntoIntegracion> SynPuntoIntegracions { get; set; }
    public virtual DbSet<SynPuntoIntegracionEstadoTipoDocumento> SynPuntoIntegracionEstadoTipoDocumentos { get; set; }
    public virtual DbSet<SynPuntoIntegracionTabla> SynPuntoIntegracionTablas { get; set; }
    public virtual DbSet<SynSistemaIntegrar> SynSistemaIntegrars { get; set; }
    public virtual DbSet<SynTipoAutenticacion> SynTipoAutenticacions { get; set; }
    public virtual DbSet<Tabla> Tablas { get; set; }
    public virtual DbSet<TaxNivelTax> TaxNivelTaxs { get; set; }
    public virtual DbSet<TaxObjetoTax> TaxObjetoTaxs { get; set; }
    public virtual DbSet<TerCargoContacto> TerCargoContactos { get; set; }
    public virtual DbSet<TerContacto> TerContactos { get; set; }
    public virtual DbSet<TerContactoEquipo> TerContactoEquipos { get; set; }
    public virtual DbSet<TerContactoSucursal> TerContactoSucursals { get; set; }
    public virtual DbSet<TerEstadoTercero> TerEstadoTerceros { get; set; }
    public virtual DbSet<TerNaturalezaTercero> TerNaturalezaTerceros { get; set; }
    public virtual DbSet<TerSector> TerSectors { get; set; }
    public virtual DbSet<TerSucursal> TerSucursals { get; set; }
    public virtual DbSet<TerSucursalListaprecio> TerSucursalListaprecios { get; set; }
    public virtual DbSet<TerSucursalUsuario> TerSucursalUsuarios { get; set; }
    public virtual DbSet<TerTercero> TerTerceros { get; set; }
    public virtual DbSet<TerTerceroListaprecio> TerTerceroListaprecios { get; set; }
    public virtual DbSet<TerTerceroSector> TerTerceroSectors { get; set; }
    public virtual DbSet<TerTerceroUsuario> TerTerceroUsuarios { get; set; }
    public virtual DbSet<VAlquileresPreliquidar> VAlquileresPreliquidars { get; set; }
    public virtual DbSet<VChecklistToda> VChecklistTodas { get; set; }
    public virtual DbSet<VCorreosAenviar> VCorreosAenviars { get; set; }
    public virtual DbSet<VDatCot> VDatCots { get; set; }
    public virtual DbSet<VDocPruebaSop> VDocPruebaSops { get; set; }
    public virtual DbSet<VDocumentosPadreAsociar> VDocumentosPadreAsociars { get; set; }
    public virtual DbSet<VDocumentoSucursal> VDocumentoSucursals { get; set; }
    public virtual DbSet<VHorarioTrabajo> VHorarioTrabajos { get; set; }
    public virtual DbSet<ViewAlqDetallealquilerItemdocumento> ViewAlqDetallealquilerItemdocumentos { get; set; }
    public virtual DbSet<ViewAlqDetalleLiquidacion> ViewAlqDetalleLiquidacions { get; set; }
    public virtual DbSet<ViewAlqHistoricoAlquiler> ViewAlqHistoricoAlquilers { get; set; }
    public virtual DbSet<ViewAlqTarifa> ViewAlqTarifas { get; set; }
    public virtual DbSet<ViewAlqTipoTarifa> ViewAlqTipoTarifas { get; set; }
    public virtual DbSet<ViewCatAtributo> ViewCatAtributos { get; set; }
    public virtual DbSet<ViewCatAtributoOpcionAtributo> ViewCatAtributoOpcionAtributos { get; set; }
    public virtual DbSet<ViewCatCatalogo> ViewCatCatalogos { get; set; }
    public virtual DbSet<ViewCatCatalogoActividad> ViewCatCatalogoActividads { get; set; }
    public virtual DbSet<ViewCatCatalogoBodega> ViewCatCatalogoBodegas { get; set; }
    public virtual DbSet<ViewCatCatalogoEquipo> ViewCatCatalogoEquipos { get; set; }
    public virtual DbSet<ViewCatCatalogoEquipoAtributo> ViewCatCatalogoEquipoAtributos { get; set; }
    public virtual DbSet<ViewCatCatalogoEquipoCatalogoTempario> ViewCatCatalogoEquipoCatalogoTemparios { get; set; }
    public virtual DbSet<ViewCatCatalogoEquipoPruebaCheckList> ViewCatCatalogoEquipoPruebaCheckLists { get; set; }
    public virtual DbSet<ViewCatCatalogoListaPrecio> ViewCatCatalogoListaPrecios { get; set; }
    public virtual DbSet<ViewCatCatalogoOtro> ViewCatCatalogoOtros { get; set; }
    public virtual DbSet<ViewCatCatalogoProducto> ViewCatCatalogoProductos { get; set; }
    public virtual DbSet<ViewCatCatalogoRepuesto> ViewCatCatalogoRepuestos { get; set; }
    public virtual DbSet<ViewCatCatalogoTempario> ViewCatCatalogoTemparios { get; set; }
    public virtual DbSet<ViewCatDetalleRepuesto> ViewCatDetalleRepuestos { get; set; }
    public virtual DbSet<ViewCatDetalleTempario> ViewCatDetalleTemparios { get; set; }
    public virtual DbSet<ViewCatDimension> ViewCatDimensions { get; set; }
    public virtual DbSet<ViewCatListaPrecio> ViewCatListaPrecios { get; set; }
    public virtual DbSet<ViewCatMarca> ViewCatMarcas { get; set; }
    public virtual DbSet<ViewCatPosicion> ViewCatPosicions { get; set; }
    public virtual DbSet<ViewCatPruebaCheckList> ViewCatPruebaCheckLists { get; set; }
    public virtual DbSet<ViewCatPruebaCheckListAtributo> ViewCatPruebaCheckListAtributos { get; set; }
    public virtual DbSet<ViewCatReemplazo> ViewCatReemplazos { get; set; }
    public virtual DbSet<ViewCatReemplazoCatalogoEquipo> ViewCatReemplazoCatalogoEquipos { get; set; }
    public virtual DbSet<ViewCatSeccionAtributo> ViewCatSeccionAtributos { get; set; }
    public virtual DbSet<ViewCatSistema> ViewCatSistemas { get; set; }
    public virtual DbSet<ViewCatSistemaCatalogoEquipo> ViewCatSistemaCatalogoEquipos { get; set; }
    public virtual DbSet<ViewCatSoporteActividad> ViewCatSoporteActividads { get; set; }
    public virtual DbSet<ViewCatSubtipoCatalogo> ViewCatSubtipoCatalogos { get; set; }
    public virtual DbSet<ViewCatTarifa> ViewCatTarifas { get; set; }
    public virtual DbSet<ViewCatTarifaCatalogo> ViewCatTarifaCatalogos { get; set; }
    public virtual DbSet<ViewCatTarifaRango> ViewCatTarifaRangos { get; set; }
    public virtual DbSet<ViewCatTipoCatalogo> ViewCatTipoCatalogos { get; set; }
    public virtual DbSet<ViewCatTipoCatalogoListaPrecio> ViewCatTipoCatalogoListaPrecios { get; set; }
    public virtual DbSet<ViewCatTipoReemplazo> ViewCatTipoReemplazos { get; set; }
    public virtual DbSet<ViewCatUsoSeccionAtributo> ViewCatUsoSeccionAtributos { get; set; }
    public virtual DbSet<ViewCatVersionEquipo> ViewCatVersionEquipos { get; set; }
    public virtual DbSet<ViewCatVersionEquipoDetalleTempario> ViewCatVersionEquipoDetalleTemparios { get; set; }
    public virtual DbSet<ViewCntConfigContrato> ViewCntConfigContratos { get; set; }
    public virtual DbSet<ViewCntContrato> ViewCntContratos { get; set; }
    public virtual DbSet<ViewCntContratoCatalogo> ViewCntContratoCatalogos { get; set; }
    public virtual DbSet<ViewCntContratoDetalleVisitum> ViewCntContratoDetalleVisitums { get; set; }
    public virtual DbSet<ViewCntContratoEquipo> ViewCntContratoEquipos { get; set; }
    public virtual DbSet<ViewCntContratoSucursal> ViewCntContratoSucursals { get; set; }
    public virtual DbSet<ViewCntContratoTipoServicio> ViewCntContratoTipoServicios { get; set; }
    public virtual DbSet<ViewCntContratoZona> ViewCntContratoZonas { get; set; }
    public virtual DbSet<ViewCntCorrimientoVisitaFija> ViewCntCorrimientoVisitaFijas { get; set; }
    public virtual DbSet<ViewCntPagosContrato> ViewCntPagosContratos { get; set; }
    public virtual DbSet<ViewCntPeriodoContrato> ViewCntPeriodoContratos { get; set; }
    public virtual DbSet<ViewCntTiempoRespuestum> ViewCntTiempoRespuestums { get; set; }
    public virtual DbSet<ViewCntTipoContrato> ViewCntTipoContratos { get; set; }
    public virtual DbSet<ViewCntVisitaFija> ViewCntVisitaFijas { get; set; }
    public virtual DbSet<ViewCntVisitaFijaCatalogo> ViewCntVisitaFijaCatalogos { get; set; }
    public virtual DbSet<ViewComComision> ViewComComisions { get; set; }
    public virtual DbSet<ViewDisEstadoEvento> ViewDisEstadoEventos { get; set; }
    public virtual DbSet<ViewDisEvento> ViewDisEventos { get; set; }
    public virtual DbSet<ViewDisEventoCatalogo> ViewDisEventoCatalogos { get; set; }
    public virtual DbSet<ViewDisEventoEstadoEvento> ViewDisEventoEstadoEventos { get; set; }
    public virtual DbSet<ViewDisMetodoDeteccion> ViewDisMetodoDeteccions { get; set; }
    public virtual DbSet<ViewDisMotivoEvento> ViewDisMotivoEventos { get; set; }
    public virtual DbSet<ViewDisObra> ViewDisObras { get; set; }
    public virtual DbSet<ViewDisObraCatalogo> ViewDisObraCatalogos { get; set; }
    public virtual DbSet<ViewDisObraEquipo> ViewDisObraEquipos { get; set; }
    public virtual DbSet<ViewDocCentroCosto> ViewDocCentroCostos { get; set; }
    public virtual DbSet<ViewDocCondicion> ViewDocCondicions { get; set; }
    public virtual DbSet<ViewDocCosteo> ViewDocCosteos { get; set; }
    public virtual DbSet<ViewDocDocumento> ViewDocDocumentos { get; set; }
    public virtual DbSet<ViewDocDocumentoAlquiler> ViewDocDocumentoAlquilers { get; set; }
    public virtual DbSet<ViewDocDocumentoAtributo> ViewDocDocumentoAtributos { get; set; }
    public virtual DbSet<ViewDocDocumentoCatalogoTempario> ViewDocDocumentoCatalogoTemparios { get; set; }
    public virtual DbSet<ViewDocDocumentoComentario> ViewDocDocumentoComentarios { get; set; }
    public virtual DbSet<ViewDocDocumentoContacto> ViewDocDocumentoContactos { get; set; }
    public virtual DbSet<ViewDocDocumentoCotizacion> ViewDocDocumentoCotizacions { get; set; }
    public virtual DbSet<ViewDocDocumentoCotizacionCondicion> ViewDocDocumentoCotizacionCondicions { get; set; }
    public virtual DbSet<ViewDocDocumentoEntradum> ViewDocDocumentoEntradums { get; set; }
    public virtual DbSet<ViewDocDocumentoEstadoTipoDocumento> ViewDocDocumentoEstadoTipoDocumentos { get; set; }
    public virtual DbSet<ViewDocDocumentoEvaluacion> ViewDocDocumentoEvaluacions { get; set; }
    public virtual DbSet<ViewDocDocumentoGasto> ViewDocDocumentoGastos { get; set; }
    public virtual DbSet<ViewDocDocumentoOpcionRespuestum> ViewDocDocumentoOpcionRespuestums { get; set; }
    public virtual DbSet<ViewDocDocumentoOrdenCompra> ViewDocDocumentoOrdenCompras { get; set; }
    public virtual DbSet<ViewDocDocumentoOt> ViewDocDocumentoOts { get; set; }
    public virtual DbSet<ViewDocDocumentoOtCentroCosto> ViewDocDocumentoOtCentroCostos { get; set; }
    public virtual DbSet<ViewDocDocumentoOtProgramadum> ViewDocDocumentoOtProgramadums { get; set; }
    public virtual DbSet<ViewDocDocumentoOtPruebaCheckList> ViewDocDocumentoOtPruebaCheckLists { get; set; }
    public virtual DbSet<ViewDocDocumentoOtSinProgramar> ViewDocDocumentoOtSinProgramars { get; set; }
    public virtual DbSet<ViewDocDocumentoProyecto> ViewDocDocumentoProyectos { get; set; }
    public virtual DbSet<ViewDocDocumentoProyectoCalidad> ViewDocDocumentoProyectoCalidads { get; set; }
    public virtual DbSet<ViewDocDocumentoProyectoEjecutore> ViewDocDocumentoProyectoEjecutores { get; set; }
    public virtual DbSet<ViewDocDocumentoProyectoEntregable> ViewDocDocumentoProyectoEntregables { get; set; }
    public virtual DbSet<ViewDocDocumentoProyectoEtapa> ViewDocDocumentoProyectoEtapas { get; set; }
    public virtual DbSet<ViewDocDocumentoProyectoSucursal> ViewDocDocumentoProyectoSucursals { get; set; }
    public virtual DbSet<ViewDocDocumentoRequisicion> ViewDocDocumentoRequisicions { get; set; }
    public virtual DbSet<ViewDocDocumentoSalidum> ViewDocDocumentoSalidums { get; set; }
    public virtual DbSet<ViewDocDocumentoSolicitud> ViewDocDocumentoSolicituds { get; set; }
    public virtual DbSet<ViewDocDocumentoTraslado> ViewDocDocumentoTraslados { get; set; }
    public virtual DbSet<ViewDocEstadoTipoDocumento> ViewDocEstadoTipoDocumentos { get; set; }
    public virtual DbSet<ViewDocEstadoTipoDocumentoPerfil> ViewDocEstadoTipoDocumentoPerfils { get; set; }
    public virtual DbSet<ViewDocEstadoTipoDocumentoSubtipoDocumento> ViewDocEstadoTipoDocumentoSubtipoDocumentos { get; set; }
    public virtual DbSet<ViewDocEstrategiaPrioridad> ViewDocEstrategiaPrioridads { get; set; }
    public virtual DbSet<ViewDocEvaluacion> ViewDocEvaluacions { get; set; }
    public virtual DbSet<ViewDocFlujoDocumento> ViewDocFlujoDocumentos { get; set; }
    public virtual DbSet<ViewDocFormaPago> ViewDocFormaPagos { get; set; }
    public virtual DbSet<ViewDocIncoterm> ViewDocIncoterms { get; set; }
    public virtual DbSet<ViewDocItemDocumento> ViewDocItemDocumentos { get; set; }
    public virtual DbSet<ViewDocMedioSolicitud> ViewDocMedioSolicituds { get; set; }
    public virtual DbSet<ViewDocMotivoestado> ViewDocMotivoestados { get; set; }
    public virtual DbSet<ViewDocOpcionCondicion> ViewDocOpcionCondicions { get; set; }
    public virtual DbSet<ViewDocOpcionRespuestum> ViewDocOpcionRespuestums { get; set; }
    public virtual DbSet<ViewDocPendienteDocumento> ViewDocPendienteDocumentos { get; set; }
    public virtual DbSet<ViewDocPendienteDocumentoDocItemDocumento> ViewDocPendienteDocumentoDocItemDocumentos { get; set; }
    public virtual DbSet<ViewDocPreguntum> ViewDocPreguntums { get; set; }
    public virtual DbSet<ViewDocPrioridadDocumento> ViewDocPrioridadDocumentos { get; set; }
    public virtual DbSet<ViewDocPrioridadSubtipoDocumento> ViewDocPrioridadSubtipoDocumentos { get; set; }
    public virtual DbSet<ViewDocPruebaSop> ViewDocPruebaSops { get; set; }
    public virtual DbSet<ViewDocSoporteItemDocumento> ViewDocSoporteItemDocumentos { get; set; }
    public virtual DbSet<ViewDocSubtipoDocumento> ViewDocSubtipoDocumentos { get; set; }
    public virtual DbSet<ViewDocSubtipoLectura> ViewDocSubtipoLecturas { get; set; }
    public virtual DbSet<ViewDocTarea> ViewDocTareas { get; set; }
    public virtual DbSet<ViewDocTipoDocumento> ViewDocTipoDocumentos { get; set; }
    public virtual DbSet<ViewDocTipoPendiente> ViewDocTipoPendientes { get; set; }
    public virtual DbSet<ViewEquAlquiler> ViewEquAlquilers { get; set; }
    public virtual DbSet<ViewEquAnalisisFalla> ViewEquAnalisisFallas { get; set; }
    public virtual DbSet<ViewEquCampana> ViewEquCampanas { get; set; }
    public virtual DbSet<ViewEquCampanaDocumentoOt> ViewEquCampanaDocumentoOts { get; set; }
    public virtual DbSet<ViewEquCicloHorometro> ViewEquCicloHorometros { get; set; }
    public virtual DbSet<ViewEquDetalleAlquiler> ViewEquDetalleAlquilers { get; set; }
    public virtual DbSet<ViewEquDetallePagoAlquiler> ViewEquDetallePagoAlquilers { get; set; }
    public virtual DbSet<ViewEquEquipo> ViewEquEquipos { get; set; }
    public virtual DbSet<ViewEquEquipoAtributo> ViewEquEquipoAtributos { get; set; }
    public virtual DbSet<ViewEquEquipoItemDocumento> ViewEquEquipoItemDocumentos { get; set; }
    public virtual DbSet<ViewEquEstadoEquipo> ViewEquEstadoEquipos { get; set; }
    public virtual DbSet<ViewEquEstadoPrestamo> ViewEquEstadoPrestamos { get; set; }
    public virtual DbSet<ViewEquFalla> ViewEquFallas { get; set; }
    public virtual DbSet<ViewEquFamiliaFalla> ViewEquFamiliaFallas { get; set; }
    public virtual DbSet<ViewEquOpcionAtributo> ViewEquOpcionAtributos { get; set; }
    public virtual DbSet<ViewEquOpcionAtributoDependiente> ViewEquOpcionAtributoDependientes { get; set; }
    public virtual DbSet<ViewEquOverhall> ViewEquOverhalls { get; set; }
    public virtual DbSet<ViewEquPagoAlquiler> ViewEquPagoAlquilers { get; set; }
    public virtual DbSet<ViewEquPrestamo> ViewEquPrestamos { get; set; }
    public virtual DbSet<ViewEquPrestamoEquipo> ViewEquPrestamoEquipos { get; set; }
    public virtual DbSet<ViewEquTipoAtributo> ViewEquTipoAtributos { get; set; }
    public virtual DbSet<ViewEquTipoFalla> ViewEquTipoFallas { get; set; }
    public virtual DbSet<ViewEquTipoTrazabilidad> ViewEquTipoTrazabilidads { get; set; }
    public virtual DbSet<ViewEquTrazabilidad> ViewEquTrazabilidads { get; set; }
    public virtual DbSet<ViewGasDetalleGasto> ViewGasDetalleGastos { get; set; }
    public virtual DbSet<ViewGasDocumentoOtDetalleGasto> ViewGasDocumentoOtDetalleGastos { get; set; }
    public virtual DbSet<ViewGasGasto> ViewGasGastos { get; set; }
    public virtual DbSet<ViewGasTipoGasto> ViewGasTipoGastos { get; set; }
    public virtual DbSet<ViewGenAccesosSamm> ViewGenAccesosSamms { get; set; }
    public virtual DbSet<ViewGenAccionNotificacion> ViewGenAccionNotificacions { get; set; }
    public virtual DbSet<ViewGenArchivo> ViewGenArchivos { get; set; }
    public virtual DbSet<ViewGenBodega> ViewGenBodegas { get; set; }
    public virtual DbSet<ViewGenBodegaUsuario> ViewGenBodegaUsuarios { get; set; }
    public virtual DbSet<ViewGenConfig> ViewGenConfigs { get; set; }
    public virtual DbSet<ViewGenConfiguracionAtributo> ViewGenConfiguracionAtributos { get; set; }
    public virtual DbSet<ViewGenConfiguracionServicio> ViewGenConfiguracionServicios { get; set; }
    public virtual DbSet<ViewGenDetalleFormulario> ViewGenDetalleFormularios { get; set; }
    public virtual DbSet<ViewGenDetalleRegistroEnvio> ViewGenDetalleRegistroEnvios { get; set; }
    public virtual DbSet<ViewGenDiaFestivo> ViewGenDiaFestivos { get; set; }
    public virtual DbSet<ViewGenEmpresa> ViewGenEmpresas { get; set; }
    public virtual DbSet<ViewGenEnvioCorreo> ViewGenEnvioCorreos { get; set; }
    public virtual DbSet<ViewGenFamilium> ViewGenFamiliums { get; set; }
    public virtual DbSet<ViewGenFirma> ViewGenFirmas { get; set; }
    public virtual DbSet<ViewGenFirmaContacto> ViewGenFirmaContactos { get; set; }
    public virtual DbSet<ViewGenFormulario> ViewGenFormularios { get; set; }
    public virtual DbSet<ViewGenImpuesto> ViewGenImpuestos { get; set; }
    public virtual DbSet<ViewGenLocalizacion> ViewGenLocalizacions { get; set; }
    public virtual DbSet<ViewGenLocalizacionItemDocumento> ViewGenLocalizacionItemDocumentos { get; set; }
    public virtual DbSet<ViewGenMonedum> ViewGenMonedums { get; set; }
    public virtual DbSet<ViewGenNotificacion> ViewGenNotificacions { get; set; }
    public virtual DbSet<ViewGenPresupuestoEmpresa> ViewGenPresupuestoEmpresas { get; set; }
    public virtual DbSet<ViewGenRegistroEnvio> ViewGenRegistroEnvios { get; set; }
    public virtual DbSet<ViewGenRemitenteCorreo> ViewGenRemitenteCorreos { get; set; }
    public virtual DbSet<ViewGenTipoArchivo> ViewGenTipoArchivos { get; set; }
    public virtual DbSet<ViewGenTipoDato> ViewGenTipoDatos { get; set; }
    public virtual DbSet<ViewGenTipoNotificacion> ViewGenTipoNotificacions { get; set; }
    public virtual DbSet<ViewGenTipoServicio> ViewGenTipoServicios { get; set; }
    public virtual DbSet<ViewGenUnidad> ViewGenUnidads { get; set; }
    public virtual DbSet<ViewGenZona> ViewGenZonas { get; set; }
    public virtual DbSet<ViewGeoUbicacion> ViewGeoUbicacions { get; set; }
    public virtual DbSet<ViewGuiAplicacion> ViewGuiAplicacions { get; set; }
    public virtual DbSet<ViewGuiAyudum> ViewGuiAyudums { get; set; }
    public virtual DbSet<ViewGuiBloqueHome> ViewGuiBloqueHomes { get; set; }
    public virtual DbSet<ViewGuiCampoTexto> ViewGuiCampoTextos { get; set; }
    public virtual DbSet<ViewGuiDetalleBloqueHome> ViewGuiDetalleBloqueHomes { get; set; }
    public virtual DbSet<ViewGuiFuncionalidad> ViewGuiFuncionalidads { get; set; }
    public virtual DbSet<ViewGuiTextoDefecto> ViewGuiTextoDefectos { get; set; }
    public virtual DbSet<ViewGuiTipoFuncionalidad> ViewGuiTipoFuncionalidads { get; set; }
    public virtual DbSet<ViewLicCatalogoParametro> ViewLicCatalogoParametros { get; set; }
    public virtual DbSet<ViewLicLicenciaParametro> ViewLicLicenciaParametros { get; set; }
    public virtual DbSet<ViewLicLicencium> ViewLicLicenciums { get; set; }
    public virtual DbSet<ViewLicParametro> ViewLicParametros { get; set; }
    public virtual DbSet<ViewOrtCanalAtencion> ViewOrtCanalAtencions { get; set; }
    public virtual DbSet<ViewOrtDepartamentoSolicitud> ViewOrtDepartamentoSolicituds { get; set; }
    public virtual DbSet<ViewOrtMotivoCancelacion> ViewOrtMotivoCancelacions { get; set; }
    public virtual DbSet<ViewOrtProgramacion> ViewOrtProgramacions { get; set; }
    public virtual DbSet<ViewOrtReporteTecnico> ViewOrtReporteTecnicos { get; set; }
    public virtual DbSet<ViewOrtReporteTecnicoFalla> ViewOrtReporteTecnicoFallas { get; set; }
    public virtual DbSet<ViewOrtReporteTecnicoOt> ViewOrtReporteTecnicoOts { get; set; }
    public virtual DbSet<ViewOrtTipoProgramacion> ViewOrtTipoProgramacions { get; set; }
    public virtual DbSet<ViewOrtVale> ViewOrtVales { get; set; }
    public virtual DbSet<ViewProActividad> ViewProActividads { get; set; }
    public virtual DbSet<ViewProActividadEjecutor> ViewProActividadEjecutors { get; set; }
    public virtual DbSet<ViewProActividadEtapa> ViewProActividadEtapas { get; set; }
    public virtual DbSet<ViewProActividadHito> ViewProActividadHitos { get; set; }
    public virtual DbSet<ViewProActividadPredecesora> ViewProActividadPredecesoras { get; set; }
    public virtual DbSet<ViewProActividadRecursoFisico> ViewProActividadRecursoFisicos { get; set; }
    public virtual DbSet<ViewProCalidad> ViewProCalidads { get; set; }
    public virtual DbSet<ViewProEjecutore> ViewProEjecutores { get; set; }
    public virtual DbSet<ViewProEjecutoresArchivo> ViewProEjecutoresArchivos { get; set; }
    public virtual DbSet<ViewProEntregable> ViewProEntregables { get; set; }
    public virtual DbSet<ViewProEtapa> ViewProEtapas { get; set; }
    public virtual DbSet<ViewProFactorexito> ViewProFactorexitos { get; set; }
    public virtual DbSet<ViewProHito> ViewProHitos { get; set; }
    public virtual DbSet<ViewProHorarioProyecto> ViewProHorarioProyectos { get; set; }
    public virtual DbSet<ViewProRecursoFisico> ViewProRecursoFisicos { get; set; }
    public virtual DbSet<ViewProReporteActividad> ViewProReporteActividads { get; set; }
    public virtual DbSet<ViewProRol> ViewProRols { get; set; }
    public virtual DbSet<ViewProRolContacto> ViewProRolContactos { get; set; }
    public virtual DbSet<ViewProSesionActividad> ViewProSesionActividads { get; set; }
    public virtual DbSet<ViewRepCampoReporte> ViewRepCampoReportes { get; set; }
    public virtual DbSet<ViewRepCategorium> ViewRepCategoriums { get; set; }
    public virtual DbSet<ViewRepIndicador> ViewRepIndicadors { get; set; }
    public virtual DbSet<ViewRepOpcionReporte> ViewRepOpcionReportes { get; set; }
    public virtual DbSet<ViewRepOrigenDato> ViewRepOrigenDatos { get; set; }
    public virtual DbSet<ViewRepReporte> ViewRepReportes { get; set; }
    public virtual DbSet<ViewRepReporteCategorium> ViewRepReporteCategoriums { get; set; }
    public virtual DbSet<ViewRepTipoCampoReporte> ViewRepTipoCampoReportes { get; set; }
    public virtual DbSet<ViewSegCargo> ViewSegCargos { get; set; }
    public virtual DbSet<ViewSegCargoActividad> ViewSegCargoActividads { get; set; }
    public virtual DbSet<ViewSegCargoEnvioCorreo> ViewSegCargoEnvioCorreos { get; set; }
    public virtual DbSet<ViewSegGrupo> ViewSegGrupos { get; set; }
    public virtual DbSet<ViewSegPerfil> ViewSegPerfils { get; set; }
    public virtual DbSet<ViewSegPerfilBloqueHome> ViewSegPerfilBloqueHomes { get; set; }
    public virtual DbSet<ViewSegPerfilFormulario> ViewSegPerfilFormularios { get; set; }
    public virtual DbSet<ViewSegPerfilFuncionalidad> ViewSegPerfilFuncionalidads { get; set; }
    public virtual DbSet<ViewSegPerfilSubtipoDocumento> ViewSegPerfilSubtipoDocumentos { get; set; }
    public virtual DbSet<ViewSegPerfilTercero> ViewSegPerfilTerceros { get; set; }
    public virtual DbSet<ViewSegRegistroIntegracion> ViewSegRegistroIntegracions { get; set; }
    public virtual DbSet<ViewSegRegistroPeticion> ViewSegRegistroPeticions { get; set; }
    public virtual DbSet<ViewSegSesion> ViewSegSesions { get; set; }
    public virtual DbSet<ViewSegUsuario> ViewSegUsuarios { get; set; }
    public virtual DbSet<ViewSegUsuarioCatalogoEquipo> ViewSegUsuarioCatalogoEquipos { get; set; }
    public virtual DbSet<ViewSynCampoIntegracion> ViewSynCampoIntegracions { get; set; }
    public virtual DbSet<ViewSynPuntoIntegracion> ViewSynPuntoIntegracions { get; set; }
    public virtual DbSet<ViewSynPuntoIntegracionEstadoTipoDocumento> ViewSynPuntoIntegracionEstadoTipoDocumentos { get; set; }
    public virtual DbSet<ViewSynPuntoIntegracionTabla> ViewSynPuntoIntegracionTablas { get; set; }
    public virtual DbSet<ViewSynSistemaIntegrar> ViewSynSistemaIntegrars { get; set; }
    public virtual DbSet<ViewSynTipoAutenticacion> ViewSynTipoAutenticacions { get; set; }
    public virtual DbSet<ViewTaxNivelTax> ViewTaxNivelTaxs { get; set; }
    public virtual DbSet<ViewTaxObjetoTax> ViewTaxObjetoTaxs { get; set; }
    public virtual DbSet<ViewTerCargoContacto> ViewTerCargoContactos { get; set; }
    public virtual DbSet<ViewTerContacto> ViewTerContactos { get; set; }
    public virtual DbSet<ViewTerContactoEquipo> ViewTerContactoEquipos { get; set; }
    public virtual DbSet<ViewTerContactoSucursal> ViewTerContactoSucursals { get; set; }
    public virtual DbSet<ViewTerEstadoTercero> ViewTerEstadoTerceros { get; set; }
    public virtual DbSet<ViewTerNaturalezaTercero> ViewTerNaturalezaTerceros { get; set; }
    public virtual DbSet<ViewTerSector> ViewTerSectors { get; set; }
    public virtual DbSet<ViewTerSucursal> ViewTerSucursals { get; set; }
    public virtual DbSet<ViewTerSucursalListaprecio> ViewTerSucursalListaprecios { get; set; }
    public virtual DbSet<ViewTerSucursalUsuario> ViewTerSucursalUsuarios { get; set; }
    public virtual DbSet<ViewTerTercero> ViewTerTerceros { get; set; }
    public virtual DbSet<ViewTerTerceroListaprecio> ViewTerTerceroListaprecios { get; set; }
    public virtual DbSet<ViewTerTerceroSector> ViewTerTerceroSectors { get; set; }
    public virtual DbSet<ViewTerTerceroUsuario> ViewTerTerceroUsuarios { get; set; }
    public virtual DbSet<VInformeIngreso> VInformeIngresos { get; set; }
    public virtual DbSet<VReglaEnvioCorreo> VReglaEnvioCorreos { get; set; }
    public virtual DbSet<VRepuestosalquilable> VRepuestosalquilables { get; set; }
    public virtual DbSet<ZzuItemRentaSap> ZzuItemRentaSaps { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AlqDetallealquilerItemdocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new AlqDetalleLiquidacionConfiguration());
        modelBuilder.ApplyConfiguration(new AlqHistoricoAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new AlqPeriodoAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new AlqTarifaConfiguration());
        modelBuilder.ApplyConfiguration(new AlqTipoTarifaConfiguration());
        modelBuilder.ApplyConfiguration(new CatAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new CatAtributoOpcionAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoActividadConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoBodegaConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoEquipoCatalogoTemparioConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoEquipoPruebaCheckListConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoListaPrecioConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoOtroConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoProductoConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoRepuestoConfiguration());
        modelBuilder.ApplyConfiguration(new CatCatalogoTemparioConfiguration());
        modelBuilder.ApplyConfiguration(new CatDetalleRepuestoConfiguration());
        modelBuilder.ApplyConfiguration(new CatDetalleTemparioConfiguration());
        modelBuilder.ApplyConfiguration(new CatDimensionConfiguration());
        modelBuilder.ApplyConfiguration(new CatListaPrecioConfiguration());
        modelBuilder.ApplyConfiguration(new CatMarcaConfiguration());
        modelBuilder.ApplyConfiguration(new CatPosicionConfiguration());
        modelBuilder.ApplyConfiguration(new CatPruebaCheckListConfiguration());
        modelBuilder.ApplyConfiguration(new CatPruebaCheckListAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new CatReemplazoConfiguration());
        modelBuilder.ApplyConfiguration(new CatReemplazoCatalogoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new CatSeccionAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new CatSistemaConfiguration());
        modelBuilder.ApplyConfiguration(new CatSistemaCatalogoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new CatSoporteActividadConfiguration());
        modelBuilder.ApplyConfiguration(new CatSubtipoCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new CatTarifaConfiguration());
        modelBuilder.ApplyConfiguration(new CatTarifaCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new CatTarifaRangoConfiguration());
        modelBuilder.ApplyConfiguration(new CatTipoCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new CatTipoCatalogoListaPrecioConfiguration());
        modelBuilder.ApplyConfiguration(new CatTipoReemplazoConfiguration());
        modelBuilder.ApplyConfiguration(new CatUsoSeccionAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new CatVersionEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new CatVersionEquipoDetalleTemparioConfiguration());
        modelBuilder.ApplyConfiguration(new CntConfigContratoConfiguration());
        modelBuilder.ApplyConfiguration(new CntContratoConfiguration());
        modelBuilder.ApplyConfiguration(new CntContratoCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new CntContratoDetalleVisitumConfiguration());
        modelBuilder.ApplyConfiguration(new CntContratoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new CntContratoSucursalConfiguration());
        modelBuilder.ApplyConfiguration(new CntContratoTipoServicioConfiguration());
        modelBuilder.ApplyConfiguration(new CntContratoZonaConfiguration());
        modelBuilder.ApplyConfiguration(new CntCorrimientoVisitaFijaConfiguration());
        modelBuilder.ApplyConfiguration(new CntPagosContratoConfiguration());
        modelBuilder.ApplyConfiguration(new CntPeriodoContratoConfiguration());
        modelBuilder.ApplyConfiguration(new CntTiempoRespuestumConfiguration());
        modelBuilder.ApplyConfiguration(new CntTipoContratoConfiguration());
        modelBuilder.ApplyConfiguration(new CntVisitaFijaConfiguration());
        modelBuilder.ApplyConfiguration(new CntVisitaFijaCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new ColumnaConfiguration());
        modelBuilder.ApplyConfiguration(new ComComisionConfiguration());
        modelBuilder.ApplyConfiguration(new DisEstadoEventoConfiguration());
        modelBuilder.ApplyConfiguration(new DisEventoConfiguration());
        modelBuilder.ApplyConfiguration(new DisEventoCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new DisEventoEstadoEventoConfiguration());
        modelBuilder.ApplyConfiguration(new DisMetodoDeteccionConfiguration());
        modelBuilder.ApplyConfiguration(new DisMotivoEventoConfiguration());
        modelBuilder.ApplyConfiguration(new DisObraConfiguration());
        modelBuilder.ApplyConfiguration(new DisObraCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new DisObraEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new DocCentroCostoConfiguration());
        modelBuilder.ApplyConfiguration(new DocCondicionConfiguration());
        modelBuilder.ApplyConfiguration(new DocCosteoConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoCatalogoTemparioConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoComentarioConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoContactoConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoCotizacionConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoCotizacionCondicionConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoEntradumConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoEstadoTipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoEvaluacionConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoGastoConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoOpcionRespuestumConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoOrdenCompraConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoOtConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoOtCentroCostoConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoOtPruebaCheckListConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoProyectoConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoProyectoCalidadConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoProyectoEjecutoreConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoProyectoEntregableConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoProyectoEtapaConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoProyectoSucursalConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoRequisicionConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoSalidumConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoSolicitudConfiguration());
        modelBuilder.ApplyConfiguration(new DocDocumentoTrasladoConfiguration());
        modelBuilder.ApplyConfiguration(new DocEstadoTipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocEstadoTipoDocumentoPerfilConfiguration());
        modelBuilder.ApplyConfiguration(new DocEstadoTipoDocumentoSubtipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocEstrategiaPrioridadConfiguration());
        modelBuilder.ApplyConfiguration(new DocEvaluacionConfiguration());
        modelBuilder.ApplyConfiguration(new DocFlujoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocFormaPagoConfiguration());
        modelBuilder.ApplyConfiguration(new DocIncotermConfiguration());
        modelBuilder.ApplyConfiguration(new DocItemDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocMedioSolicitudConfiguration());
        modelBuilder.ApplyConfiguration(new DocMotivoestadoConfiguration());
        modelBuilder.ApplyConfiguration(new DocOpcionCondicionConfiguration());
        modelBuilder.ApplyConfiguration(new DocOpcionRespuestumConfiguration());
        modelBuilder.ApplyConfiguration(new DocPendienteDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocPendienteDocumentoDocItemDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocPreguntumConfiguration());
        modelBuilder.ApplyConfiguration(new DocPrioridadDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocPrioridadSubtipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocSoporteItemDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocSubtipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocSubtipoLecturaConfiguration());
        modelBuilder.ApplyConfiguration(new DocTareaConfiguration());
        modelBuilder.ApplyConfiguration(new DocTipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new DocTipoPendienteConfiguration());
        modelBuilder.ApplyConfiguration(new EquAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new EquAnalisisFallaConfiguration());
        modelBuilder.ApplyConfiguration(new EquCampanaConfiguration());
        modelBuilder.ApplyConfiguration(new EquCampanaDocumentoOtConfiguration());
        modelBuilder.ApplyConfiguration(new EquCicloHorometroConfiguration());
        modelBuilder.ApplyConfiguration(new EquDetalleAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new EquDetallePagoAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new EquEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new EquEquipoAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new EquEquipoItemDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new EquEstadoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new EquEstadoPrestamoConfiguration());
        modelBuilder.ApplyConfiguration(new EquFallaConfiguration());
        modelBuilder.ApplyConfiguration(new EquFamiliaFallaConfiguration());
        modelBuilder.ApplyConfiguration(new EquOpcionAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new EquOpcionAtributoDependienteConfiguration());
        modelBuilder.ApplyConfiguration(new EquOverhallConfiguration());
        modelBuilder.ApplyConfiguration(new EquPagoAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new EquPrestamoConfiguration());
        modelBuilder.ApplyConfiguration(new EquPrestamoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new EquTipoAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new EquTipoFallaConfiguration());
        modelBuilder.ApplyConfiguration(new EquTipoTrazabilidadConfiguration());
        modelBuilder.ApplyConfiguration(new EquTrazabilidadConfiguration());
        modelBuilder.ApplyConfiguration(new ErroreConfiguration());
        modelBuilder.ApplyConfiguration(new GasDetalleGastoConfiguration());
        modelBuilder.ApplyConfiguration(new GasDocumentoOtDetalleGastoConfiguration());
        modelBuilder.ApplyConfiguration(new GasGastoConfiguration());
        modelBuilder.ApplyConfiguration(new GasTipoGastoConfiguration());
        modelBuilder.ApplyConfiguration(new GenAccesosSammConfiguration());
        modelBuilder.ApplyConfiguration(new GenAccionNotificacionConfiguration());
        modelBuilder.ApplyConfiguration(new GenArchivoConfiguration());
        modelBuilder.ApplyConfiguration(new GenBodegaConfiguration());
        modelBuilder.ApplyConfiguration(new GenBodegaUsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new GenConfigConfiguration());
        modelBuilder.ApplyConfiguration(new GenConfiguracionAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new GenConfiguracionServicioConfiguration());
        modelBuilder.ApplyConfiguration(new GenDetalleFormularioConfiguration());
        modelBuilder.ApplyConfiguration(new GenDetalleRegistroEnvioConfiguration());
        modelBuilder.ApplyConfiguration(new GenDiaFestivoConfiguration());
        modelBuilder.ApplyConfiguration(new GenEmpresaConfiguration());
        modelBuilder.ApplyConfiguration(new GenEnvioCorreoConfiguration());
        modelBuilder.ApplyConfiguration(new GenFamiliumConfiguration());
        modelBuilder.ApplyConfiguration(new GenFirmaConfiguration());
        modelBuilder.ApplyConfiguration(new GenFirmaContactoConfiguration());
        modelBuilder.ApplyConfiguration(new GenFormularioConfiguration());
        modelBuilder.ApplyConfiguration(new GenImpuestoConfiguration());
        modelBuilder.ApplyConfiguration(new GenLocalizacionConfiguration());
        modelBuilder.ApplyConfiguration(new GenLocalizacionItemDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new GenMonedumConfiguration());
        modelBuilder.ApplyConfiguration(new GenNotificacionConfiguration());
        modelBuilder.ApplyConfiguration(new GenPresupuestoEmpresaConfiguration());
        modelBuilder.ApplyConfiguration(new GenRegistroEnvioConfiguration());
        modelBuilder.ApplyConfiguration(new GenRemitenteCorreoConfiguration());
        modelBuilder.ApplyConfiguration(new GenTipoArchivoConfiguration());
        modelBuilder.ApplyConfiguration(new GenTipoDatoConfiguration());
        modelBuilder.ApplyConfiguration(new GenTipoNotificacionConfiguration());
        modelBuilder.ApplyConfiguration(new GenTipoServicioConfiguration());
        modelBuilder.ApplyConfiguration(new GenUnidadConfiguration());
        modelBuilder.ApplyConfiguration(new GenZonaConfiguration());
        modelBuilder.ApplyConfiguration(new GeoUbicacionConfiguration());
        modelBuilder.ApplyConfiguration(new GuiAplicacionConfiguration());
        modelBuilder.ApplyConfiguration(new GuiAyudumConfiguration());
        modelBuilder.ApplyConfiguration(new GuiBloqueHomeConfiguration());
        modelBuilder.ApplyConfiguration(new GuiCampoTextoConfiguration());
        modelBuilder.ApplyConfiguration(new GuiDetalleBloqueHomeConfiguration());
        modelBuilder.ApplyConfiguration(new GuiFuncionalidadConfiguration());
        modelBuilder.ApplyConfiguration(new GuiTextoDefectoConfiguration());
        modelBuilder.ApplyConfiguration(new GuiTipoFuncionalidadConfiguration());
        modelBuilder.ApplyConfiguration(new IdaeConfiguration());
        modelBuilder.ApplyConfiguration(new LicCatalogoParametroConfiguration());
        modelBuilder.ApplyConfiguration(new LicLicenciaParametroConfiguration());
        modelBuilder.ApplyConfiguration(new LicLicenciumConfiguration());
        modelBuilder.ApplyConfiguration(new LicParametroConfiguration());
        modelBuilder.ApplyConfiguration(new OrtCanalAtencionConfiguration());
        modelBuilder.ApplyConfiguration(new OrtDepartamentoSolicitudConfiguration());
        modelBuilder.ApplyConfiguration(new OrtMotivoCancelacionConfiguration());
        modelBuilder.ApplyConfiguration(new OrtProgramacionConfiguration());
        modelBuilder.ApplyConfiguration(new OrtReporteTecnicoConfiguration());
        modelBuilder.ApplyConfiguration(new OrtReporteTecnicoFallaConfiguration());
        modelBuilder.ApplyConfiguration(new OrtReporteTecnicoOtConfiguration());
        modelBuilder.ApplyConfiguration(new OrtTipoProgramacionConfiguration());
        modelBuilder.ApplyConfiguration(new OrtValeConfiguration());
        modelBuilder.ApplyConfiguration(new ProActividadConfiguration());
        modelBuilder.ApplyConfiguration(new ProActividadEjecutorConfiguration());
        modelBuilder.ApplyConfiguration(new ProActividadEtapaConfiguration());
        modelBuilder.ApplyConfiguration(new ProActividadHitoConfiguration());
        modelBuilder.ApplyConfiguration(new ProActividadPredecesoraConfiguration());
        modelBuilder.ApplyConfiguration(new ProActividadRecursoFisicoConfiguration());
        modelBuilder.ApplyConfiguration(new ProCalidadConfiguration());
        modelBuilder.ApplyConfiguration(new ProEjecutoreConfiguration());
        modelBuilder.ApplyConfiguration(new ProEjecutoresArchivoConfiguration());
        modelBuilder.ApplyConfiguration(new ProEntregableConfiguration());
        modelBuilder.ApplyConfiguration(new ProEtapaConfiguration());
        modelBuilder.ApplyConfiguration(new ProFactorexitoConfiguration());
        modelBuilder.ApplyConfiguration(new ProGrupoSesionConfiguration());
        modelBuilder.ApplyConfiguration(new ProHitoConfiguration());
        modelBuilder.ApplyConfiguration(new ProHorarioEjecutoreConfiguration());
        modelBuilder.ApplyConfiguration(new ProHorarioProyectoConfiguration());
        modelBuilder.ApplyConfiguration(new ProHorarioTrabajoConfiguration());
        modelBuilder.ApplyConfiguration(new ProRecursoFisicoConfiguration());
        modelBuilder.ApplyConfiguration(new ProReporteActividadConfiguration());
        modelBuilder.ApplyConfiguration(new ProRolConfiguration());
        modelBuilder.ApplyConfiguration(new ProRolContactoConfiguration());
        modelBuilder.ApplyConfiguration(new ProSesionActividadConfiguration());
        modelBuilder.ApplyConfiguration(new RepCampoReporteConfiguration());
        modelBuilder.ApplyConfiguration(new RepCategoriumConfiguration());
        modelBuilder.ApplyConfiguration(new RepIndicadorConfiguration());
        modelBuilder.ApplyConfiguration(new RepOpcionReporteConfiguration());
        modelBuilder.ApplyConfiguration(new RepOrigenDatoConfiguration());
        modelBuilder.ApplyConfiguration(new RepReporteConfiguration());
        modelBuilder.ApplyConfiguration(new RepReporteCategoriumConfiguration());
        modelBuilder.ApplyConfiguration(new RepTipoCampoReporteConfiguration());
        modelBuilder.ApplyConfiguration(new SegCargoConfiguration());
        modelBuilder.ApplyConfiguration(new SegCargoActividadConfiguration());
        modelBuilder.ApplyConfiguration(new SegCargoEnvioCorreoConfiguration());
        modelBuilder.ApplyConfiguration(new SegGrupoConfiguration());
        modelBuilder.ApplyConfiguration(new SegPerfilConfiguration());
        modelBuilder.ApplyConfiguration(new SegPerfilBloqueHomeConfiguration());
        modelBuilder.ApplyConfiguration(new SegPerfilFormularioConfiguration());
        modelBuilder.ApplyConfiguration(new SegPerfilFuncionalidadConfiguration());
        modelBuilder.ApplyConfiguration(new SegPerfilSubtipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new SegPerfilTerceroConfiguration());
        modelBuilder.ApplyConfiguration(new SegRegistroIntegracionConfiguration());
        modelBuilder.ApplyConfiguration(new SegRegistroPeticionConfiguration());
        modelBuilder.ApplyConfiguration(new SegSesionConfiguration());
        modelBuilder.ApplyConfiguration(new SegSesionHistoricoConfiguration());
        modelBuilder.ApplyConfiguration(new SegUsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new SegUsuarioCatalogoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new SynCampoIntegracionConfiguration());
        modelBuilder.ApplyConfiguration(new SynPuntoIntegracionConfiguration());
        modelBuilder.ApplyConfiguration(new SynPuntoIntegracionEstadoTipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new SynPuntoIntegracionTablaConfiguration());
        modelBuilder.ApplyConfiguration(new SynSistemaIntegrarConfiguration());
        modelBuilder.ApplyConfiguration(new SynTipoAutenticacionConfiguration());
        modelBuilder.ApplyConfiguration(new TablaConfiguration());
        modelBuilder.ApplyConfiguration(new TaxNivelTaxConfiguration());
        modelBuilder.ApplyConfiguration(new TaxObjetoTaxConfiguration());
        modelBuilder.ApplyConfiguration(new TerCargoContactoConfiguration());
        modelBuilder.ApplyConfiguration(new TerContactoConfiguration());
        modelBuilder.ApplyConfiguration(new TerContactoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new TerContactoSucursalConfiguration());
        modelBuilder.ApplyConfiguration(new TerEstadoTerceroConfiguration());
        modelBuilder.ApplyConfiguration(new TerNaturalezaTerceroConfiguration());
        modelBuilder.ApplyConfiguration(new TerSectorConfiguration());
        modelBuilder.ApplyConfiguration(new TerSucursalConfiguration());
        modelBuilder.ApplyConfiguration(new TerSucursalListaprecioConfiguration());
        modelBuilder.ApplyConfiguration(new TerSucursalUsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new TerTerceroConfiguration());
        modelBuilder.ApplyConfiguration(new TerTerceroListaprecioConfiguration());
        modelBuilder.ApplyConfiguration(new TerTerceroSectorConfiguration());
        modelBuilder.ApplyConfiguration(new TerTerceroUsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new VAlquileresPreliquidarConfiguration());
        modelBuilder.ApplyConfiguration(new VChecklistTodaConfiguration());
        modelBuilder.ApplyConfiguration(new VCorreosAenviarConfiguration());
        modelBuilder.ApplyConfiguration(new VDatCotConfiguration());
        modelBuilder.ApplyConfiguration(new VDocPruebaSopConfiguration());
        modelBuilder.ApplyConfiguration(new VDocumentosPadreAsociarConfiguration());
        modelBuilder.ApplyConfiguration(new VDocumentoSucursalConfiguration());
        modelBuilder.ApplyConfiguration(new VHorarioTrabajoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewAlqDetallealquilerItemdocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewAlqDetalleLiquidacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewAlqHistoricoAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new ViewAlqTarifaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewAlqTipoTarifaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatAtributoOpcionAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoActividadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoBodegaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoEquipoAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoEquipoCatalogoTemparioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoEquipoPruebaCheckListConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoListaPrecioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoOtroConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoProductoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoRepuestoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatCatalogoTemparioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatDetalleRepuestoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatDetalleTemparioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatDimensionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatListaPrecioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatMarcaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatPosicionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatPruebaCheckListConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatPruebaCheckListAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatReemplazoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatReemplazoCatalogoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatSeccionAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatSistemaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatSistemaCatalogoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatSoporteActividadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatSubtipoCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatTarifaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatTarifaCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatTarifaRangoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatTipoCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatTipoCatalogoListaPrecioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatTipoReemplazoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatUsoSeccionAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatVersionEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCatVersionEquipoDetalleTemparioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntConfigContratoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntContratoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntContratoCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntContratoDetalleVisitumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntContratoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntContratoSucursalConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntContratoTipoServicioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntContratoZonaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntCorrimientoVisitaFijaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntPagosContratoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntPeriodoContratoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntTiempoRespuestumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntTipoContratoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntVisitaFijaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewCntVisitaFijaCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewComComisionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDisEstadoEventoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDisEventoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDisEventoCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDisEventoEstadoEventoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDisMetodoDeteccionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDisMotivoEventoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDisObraConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDisObraCatalogoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDisObraEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocCentroCostoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocCondicionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocCosteoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoCatalogoTemparioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoComentarioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoContactoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoCotizacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoCotizacionCondicionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoEntradumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoEstadoTipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoEvaluacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoGastoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoOpcionRespuestumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoOrdenCompraConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoOtConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoOtCentroCostoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoOtProgramadumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoOtPruebaCheckListConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoOtSinProgramarConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoProyectoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoProyectoCalidadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoProyectoEjecutoreConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoProyectoEntregableConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoProyectoEtapaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoProyectoSucursalConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoRequisicionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoSalidumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoSolicitudConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocDocumentoTrasladoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocEstadoTipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocEstadoTipoDocumentoPerfilConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocEstadoTipoDocumentoSubtipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocEstrategiaPrioridadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocEvaluacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocFlujoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocFormaPagoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocIncotermConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocItemDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocMedioSolicitudConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocMotivoestadoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocOpcionCondicionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocOpcionRespuestumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocPendienteDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocPendienteDocumentoDocItemDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocPreguntumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocPrioridadDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocPrioridadSubtipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocPruebaSopConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocSoporteItemDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocSubtipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocSubtipoLecturaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocTareaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocTipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewDocTipoPendienteConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquAnalisisFallaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquCampanaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquCampanaDocumentoOtConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquCicloHorometroConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquDetalleAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquDetallePagoAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquEquipoAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquEquipoItemDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquEstadoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquEstadoPrestamoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquFallaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquFamiliaFallaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquOpcionAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquOpcionAtributoDependienteConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquOverhallConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquPagoAlquilerConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquPrestamoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquPrestamoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquTipoAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquTipoFallaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquTipoTrazabilidadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewEquTrazabilidadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGasDetalleGastoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGasDocumentoOtDetalleGastoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGasGastoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGasTipoGastoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenAccesosSammConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenAccionNotificacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenArchivoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenBodegaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenBodegaUsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenConfigConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenConfiguracionAtributoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenConfiguracionServicioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenDetalleFormularioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenDetalleRegistroEnvioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenDiaFestivoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenEmpresaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenEnvioCorreoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenFamiliumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenFirmaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenFirmaContactoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenFormularioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenImpuestoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenLocalizacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenLocalizacionItemDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenMonedumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenNotificacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenPresupuestoEmpresaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenRegistroEnvioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenRemitenteCorreoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenTipoArchivoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenTipoDatoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenTipoNotificacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenTipoServicioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenUnidadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGenZonaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGeoUbicacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGuiAplicacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGuiAyudumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGuiBloqueHomeConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGuiCampoTextoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGuiDetalleBloqueHomeConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGuiFuncionalidadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGuiTextoDefectoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewGuiTipoFuncionalidadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewLicCatalogoParametroConfiguration());
        modelBuilder.ApplyConfiguration(new ViewLicLicenciaParametroConfiguration());
        modelBuilder.ApplyConfiguration(new ViewLicLicenciumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewLicParametroConfiguration());
        modelBuilder.ApplyConfiguration(new ViewOrtCanalAtencionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewOrtDepartamentoSolicitudConfiguration());
        modelBuilder.ApplyConfiguration(new ViewOrtMotivoCancelacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewOrtProgramacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewOrtReporteTecnicoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewOrtReporteTecnicoFallaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewOrtReporteTecnicoOtConfiguration());
        modelBuilder.ApplyConfiguration(new ViewOrtTipoProgramacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewOrtValeConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProActividadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProActividadEjecutorConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProActividadEtapaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProActividadHitoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProActividadPredecesoraConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProActividadRecursoFisicoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProCalidadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProEjecutoreConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProEjecutoresArchivoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProEntregableConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProEtapaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProFactorexitoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProHitoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProHorarioProyectoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProRecursoFisicoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProReporteActividadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProRolConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProRolContactoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewProSesionActividadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewRepCampoReporteConfiguration());
        modelBuilder.ApplyConfiguration(new ViewRepCategoriumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewRepIndicadorConfiguration());
        modelBuilder.ApplyConfiguration(new ViewRepOpcionReporteConfiguration());
        modelBuilder.ApplyConfiguration(new ViewRepOrigenDatoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewRepReporteConfiguration());
        modelBuilder.ApplyConfiguration(new ViewRepReporteCategoriumConfiguration());
        modelBuilder.ApplyConfiguration(new ViewRepTipoCampoReporteConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegCargoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegCargoActividadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegCargoEnvioCorreoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegGrupoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegPerfilConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegPerfilBloqueHomeConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegPerfilFormularioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegPerfilFuncionalidadConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegPerfilSubtipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegPerfilTerceroConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegRegistroIntegracionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegRegistroPeticionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegSesionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegUsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSegUsuarioCatalogoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSynCampoIntegracionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSynPuntoIntegracionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSynPuntoIntegracionEstadoTipoDocumentoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSynPuntoIntegracionTablaConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSynSistemaIntegrarConfiguration());
        modelBuilder.ApplyConfiguration(new ViewSynTipoAutenticacionConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTaxNivelTaxConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTaxObjetoTaxConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerCargoContactoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerContactoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerContactoEquipoConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerContactoSucursalConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerEstadoTerceroConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerNaturalezaTerceroConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerSectorConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerSucursalConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerSucursalListaprecioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerSucursalUsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerTerceroConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerTerceroListaprecioConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerTerceroSectorConfiguration());
        modelBuilder.ApplyConfiguration(new ViewTerTerceroUsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new VInformeIngresoConfiguration());
        modelBuilder.ApplyConfiguration(new VReglaEnvioCorreoConfiguration());
        modelBuilder.ApplyConfiguration(new VRepuestosalquilableConfiguration());
        modelBuilder.ApplyConfiguration(new ZzuItemRentaSapConfiguration());
    }
}
