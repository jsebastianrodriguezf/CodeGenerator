using CodeGenerator.Helper;
using CodeGenerator.Models;

namespace CodeGenerator
{
    /// <summary>
    /// SELECT CONCAT('"', TABLE_NAME, '",')
    /// FROM INFORMATION_SCHEMA.TABLES
    /// WHERE
    ///     TABLE_TYPE = 'BASE TABLE' AND
    ///     SUBSTRING(TABLE_NAME, 1, 1) <> '_' AND
    ///     (LEN(TABLE_NAME) - LEN(REPLACE(TABLE_NAME, '_', '')) = 1)
    /// ORDER BY TABLE_NAME
    /// </summary>
    public class ControllerCoreDALGenerator
    {
        private readonly List<string> _tables;
        private readonly string _rootPath;
        private readonly string _destinyPath;
        private readonly List<FileModel> _controllerModel;
        private readonly List<FileModel> _serviceModel;
        private readonly List<FileModel> _iServiceModel;
        private readonly List<string> _files;
        private readonly List<FileModel> _filesModel;

        public ControllerCoreDALGenerator(
            string rootPath,
            string destityPath,
            string controllerPath,
            string servicePath,
            string iServicePath)
        {
            _tables = GetTables();
            _rootPath = rootPath;
            _destinyPath = destityPath;
            _files = [.. Directory.GetFiles(_rootPath)];
            _filesModel = Utilities.GetFilesModel(_files);

            _controllerModel = Utilities.GetFilesModel([.. Directory.GetFiles(controllerPath)]);
            _serviceModel = Utilities.GetFilesModel([.. Directory.GetFiles(servicePath)]);
            _iServiceModel = Utilities.GetFilesModel([.. Directory.GetFiles(iServicePath)]);

            Utilities.RegenerateDirectory(_destinyPath);
        }

        private static List<string> GetTables()
        {
            List<string> tables;
            tables = [
                "alq_detalleLiquidacion",
                "alq_historicoAlquiler",
                "alq_periodoAlquiler",
                "alq_tarifa",
                "alq_tipoTarifa",
                "cat_atributo",
                "cat_catalogo",
                "cat_catalogo.actividad",
                "cat_catalogo.equipo",
                "cat_catalogo.otro",
                "cat_catalogo.producto",
                "cat_catalogo.repuesto",
                "cat_catalogo.tempario",
                "cat_detalleRepuesto",
                "cat_detalleTempario",
                "cat_dimension",
                "cat_listaPrecio",
                "cat_marca",
                "cat_posicion",
                "cat_pruebaCheckList",
                "cat_reemplazo",
                "cat_sistema",
                "cat_soporteActividad",
                "cat_subtipoCatalogo",
                "cat_tarifa",
                "cat_tarifaCatalogo",
                "cat_tarifaRango",
                "cat_tipoCatalogo",
                "cat_tipoReemplazo",
                "cat_usoSeccionAtributo",
                "cat_versionEquipo",
                "cnt_configContrato",
                "cnt_configuracionProyeccion",
                "cnt_contrato",
                "cnt_corrimientoVisitaFija",
                "cnt_pagosContrato",
                "cnt_periodoContrato",
                "cnt_tiempoRespuesta",
                "cnt_tipoContrato",
                "cnt_visitaFija",
                "com_comision",
                "dis_estadoEvento",
                "dis_evento",
                "dis_metodoDeteccion",
                "dis_motivoEvento",
                "dis_obra",
                "doc_centroCosto",
                "doc_condicion",
                "doc_costeo",
                "doc_documento",
                "doc_documento.alquiler",
                "doc_documento.cotizacion",
                "doc_documento.entrada",
                "doc_documento.gasto",
                "doc_documento.ordenCompra",
                "doc_documento.ot",
                "doc_documento.proyecto",
                "doc_documento.requisicion",
                "doc_documento.salida",
                "doc_documento.solicitud",
                "doc_documento.traslado",
                "doc_documentoAtributo",
                "doc_documentoComentario",
                "doc_estadoTipoDocumento",
                "doc_estrategiaPrioridad",
                "doc_evaluacion",
                "doc_flujoDocumento",
                "doc_formaPago",
                "doc_incoterm",
                "doc_itemDocumento",
                "doc_medioSolicitud",
                "doc_motivoestado",
                "doc_opcionCondicion",
                "doc_opcionRespuesta",
                "doc_pendienteDocumento",
                "doc_pregunta",
                "doc_prioridadDocumento",
                "doc_prioridadSubtipoDocumento",
                "doc_soporteItemDocumento",
                "doc_subtipoDocumento",
                "doc_subtipoLectura",
                "doc_tarea",
                "doc_tipoDocumento",
                "doc_tipoPendiente",
                "equ_alquiler",
                "equ_analisisFalla",
                "equ_campana",
                "equ_cicloHorometro",
                "equ_detalleAlquiler",
                "equ_detallePagoAlquiler",
                "equ_equipo",
                "equ_equipoAtributo",
                "equ_estadoEquipo",
                "equ_estadoPrestamo",
                "equ_falla",
                "equ_opcionAtributo",
                "equ_opcionAtributoDependiente",
                "equ_overhall",
                "equ_pagoAlquiler",
                "equ_prestamo",
                "equ_tipoFalla",
                "equ_tipoTrazabilidad",
                "equ_trazabilidad",
                "gas_detalleGasto",
                "gas_gasto",
                "gas_tipoGasto",
                "gen_accesosSamm",
                "gen_accionNotificacion",
                "gen_archivo",
                "gen_bodega",
                "gen_config",
                "gen_configuracionAtributos",
                "gen_configuracionServicio",
                "gen_detalleFormulario",
                "gen_detalleRegistroEnvio",
                "gen_diaFestivo",
                "gen_empresa",
                "gen_envioCorreo",
                "gen_familia",
                "gen_firma",
                "gen_firmaContacto",
                "gen_formulario",
                "gen_impuesto",
                "gen_localizacion",
                "gen_moneda",
                "gen_notificacion",
                "gen_presupuestoEmpresa",
                "gen_recurso",
                "gen_registroEnvio",
                "gen_remitenteCorreo",
                "gen_seccionFormulario",
                "gen_tipoArchivo",
                "gen_tipoNotificacion",
                "gen_tipoServicio",
                "gen_unidad",
                "gen_zona",
                "geo_ubicacion",
                "gui_ayuda",
                "gui_bloqueHome",
                "gui_campoTexto",
                "gui_detalleBloqueHome",
                "gui_funcionalidad",
                "gui_textoDefecto",
                "gui_tipoFuncionalidad",
                "lic_licencia",
                "lic_parametro",
                "ort_canalAtencion",
                "ort_departamentoSolicitud",
                "ort_motivoCancelacion",
                "ort_programacion",
                "ort_reporteTecnico",
                "ort_tipoProgramacion",
                "ort_vale",
                "pro_actividad",
                "pro_actividadPredecesora",
                "pro_calidad",
                "pro_ejecutores",
                "pro_entregable",
                "pro_etapa",
                "pro_factorexito",
                "pro_GrupoSesion",
                "pro_hito",
                "pro_horarioEjecutores",
                "pro_horarioProyecto",
                "pro_horarioTrabajo",
                "pro_recursoFisico",
                "pro_reporteActividad",
                "pro_rol",
                "pro_SesionActividad",
                "rep_campoReporte",
                "rep_categoria",
                "rep_indicador",
                "rep_opcionReporte",
                "rep_origenDato",
                "rep_reporte",
                "rep_tipoCampoReporte",
                "seg_cargo",
                "seg_grupo",
                "seg_perfil",
                "seg_registroIntegracion",
                "seg_registroPeticion",
                "seg_sesion",
                "seg_sesionHistorico",
                "seg_usuario",
                "syn_campoIntegracion",
                "syn_puntoIntegracion",
                "syn_puntoIntegracionTabla",
                "syn_sistemaIntegrar",
                "syn_tipoAutenticacion",
                "tax_nivelTax",
                "tax_objetoTax",
                "ter_cargoContacto",
                "ter_contacto",
                "ter_estadoTercero",
                "ter_naturalezaTercero",
                "ter_sector",
                "ter_sucursal",
                "ter_tercero",
            ];

            tables = tables.
                Select(table => table.Replace(".", "").Replace("_", "") + "Object").
                ToList();

            return tables;
        }

        public List<string> GenerateForAllEntities()
        {
            List<string> responses = [];
            string response;

            List<FileModel> files = _filesModel.Where(x => x.Name.Substring(3, 1) == x.Name.Substring(3, 1).ToUpper()).ToList();
            List<string> contentDI = [];
            List<string> contentMappers = [];
            List<string> constants = [];

            foreach (FileModel file in files)
            {
                if (!_tables.Any(table => table.Equals(file.Name, StringComparison.CurrentCultureIgnoreCase)))
                    continue;

                response = GenerateByEntity(file.Name.Replace("Object", string.Empty), file);
                if (!string.IsNullOrEmpty(response))
                    responses.Add(response);

                contentDI.Add(GenerateDI(file.Name));
                contentMappers.AddRange(GenerateMapByEntity(file.Name));
                constants.Add(GenerateConstants(file.Name));
            }

            GenerateFile("Dependencies", "Dependency.cs", contentDI);
            GenerateFile("Profiles", "GeneralEntityProfile.cs", contentMappers);
            GenerateFile("Constants", "EntityConstants.cs", constants);

            return responses;
        }

        public string GenerateByEntity(string entity, FileModel file)
        {
            string prefix;
            string entityUpper;
            string entityLower;
            string init;
            bool withCodigo;
            bool hasView;
            bool hasCmm;
            bool hasPrincipalField;

            try
            {
                prefix = entity[..3];
                init = entity.Substring(3, 1);
                entityUpper = string.Concat(init.ToUpper(), entity.AsSpan(4));
                entityLower = string.Concat(init.ToLower(), entity.AsSpan(4));

                withCodigo =
                    HasWord(file.Path, $"public string? {entityUpper}Codigo {{ get; set; }}") ||
                    HasWord(file.Path, $"public string {entityUpper}Codigo {{ get; set; }} = null!;");

                hasPrincipalField =
                    HasWord(file.Path, $"public string? {entityUpper} {{ get; set; }}") ||
                    HasWord(file.Path, $"public string {entityUpper} {{ get; set; }} = null!;");

                hasCmm = HasWord(file.Path, $"public string? Cmm {{ get; set; }}");
                hasView = HasView(file);

                GenerateController(prefix, entityUpper, entityLower, withCodigo, hasView, hasCmm);
                GenerateIService(prefix, entityUpper, entityLower, withCodigo, hasView, hasCmm);
                GenerateService(prefix, entityUpper, entityLower, withCodigo, hasView, hasCmm);
                GenerateDTO(file, prefix, entityUpper, entityLower);

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message + "|" + ex.StackTrace;
            }
        }

        public void GenerateController(string prefix, string entityUpper, string entityLower, bool WithCodigo, bool hasView, bool hasCmm)
        {
            List<string> content;
            string entityUpperBase;

            entityUpperBase = entityUpper;

            if (_filesModel.Any(x => x.Name == $"View{prefix}{entityUpper}sBaseObject"))
                entityUpperBase += "s";

            content = [
                $"using Microsoft.AspNetCore.Mvc;",
                $"using SAMMAI.Core.Services.DAL.Interfaces;",
                $"using SAMMAI.Core.Utility.ActionFilters;",
                $"using SAMMAI.Transverse.Constants;",
                $"using SAMMAI.Transverse.Helpers;",
                $"using SAMMAI.Transverse.Models.DTOs;",
                $"using SAMMAI.Transverse.Models.Endpoints.Core.{entityUpper};",
                $"using SAMMAI.Transverse.Models.Response.BaseApi;",
                $"using static SAMMAI.Core.Utility.Constants.ApiRoutesConstants;",
                $"",
                $"namespace SAMMAI.Core.Controllers",
                "{",
                $"    [Route($\"{{BaseApi}}/{Utilities.ToKebabCase(entityUpper).ToLower()}\")]",
                $"    [ApiController]",
                $"    public class {entityUpper}Controller : ControllerBase",
                "    {",
                $"        private readonly ILogger<{entityUpper}Controller> _logger;",
                $"        private readonly I{entityUpper}Service _{entityLower}Service;",
                $"",
                $"        public {entityUpper}Controller(",
                $"            ILogger<{entityUpper}Controller> logger,",
                $"            I{entityUpper}Service {entityLower}Service)",
                "        {",
                $"            _logger = logger ?? throw new ArgumentNullException(nameof(logger));",
                $"            _{entityLower}Service = {entityLower}Service ?? throw new ArgumentNullException(nameof({entityLower}Service));",
                "        }",
                $"",
                $"        #region Base Endpoints",
                $"        /// <summary>",
                $"        /// Gets a {entityUpper} by id",
                $"        /// </summary>",
                $"        /// <param name=\"id\"></param>",
                $"        /// <returns></returns>",
                $"        /// <remarks>",
                $"        /// Gets a {entityUpper} by id",
                $"        /// </remarks>",
                $"        /// <response code=\"200\">Success: Returns the {entityUpper} object</response>",
                $"        [PrivateIdentifierFilter]",
                $"        [HttpGet]",
                $"        [Route(\"{{id}}\")]",
                $"        [Produces(GeneralConstants.ContentType.Json)]",
                $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<{prefix}{entityUpper}DTO>), (int)StatusCodeEnum.OK)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                $"        public async Task<ActionResult<object>> GetById(int id)",
                "        {",
                $"            {prefix}{entityUpper}DTO? response = await _{entityLower}Service.GetById(id);",
                $"",
                $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                "        }",
                $""
            ];

            if (hasView)
            {
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets a full {entityUpper} by id",
                    $"        /// </summary>",
                    $"        /// <param name=\"id\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a full {entityUpper} by id",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns the full {entityUpper} object</response>",
                    $"        [PrivateIdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"{{id}}/full\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<View{prefix}{entityUpper}DTO>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetFullById(int id)",
                    "        {",
                    $"            View{prefix}{entityUpper}DTO? response = await _{entityLower}Service.GetFullById(id);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $"",
                    $"        /// <summary>",
                    $"        /// Gets a base {entityUpper} by id",
                    $"        /// </summary>",
                    $"        /// <param name=\"id\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a base {entityUpper} by id",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns the base {entityUpper} object</response>",
                    $"        [PrivateIdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"{{id}}/base\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<View{prefix}{entityUpperBase}BaseDTO>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetBaseById(int id)",
                    "        {",
                    $"            View{prefix}{entityUpperBase}BaseDTO? response = await _{entityLower}Service.GetBaseById(id);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $"",
                ]);
            }

            content.AddRange([
                $"        /// <summary>",
                $"        /// Gets a set of {entityUpper} by ids",
                $"        /// </summary>",
                $"        /// <param name=\"ids\"></param>",
                $"        /// <returns></returns>",
                $"        /// <remarks>",
                $"        /// Gets a set of {entityUpper} by ids",
                $"        /// </remarks>",
                $"        /// <response code=\"200\">Success: Returns a list of {entityUpper} objects</response>",
                $"        [PrivateIdentifierFilter]",
                $"        [HttpPost]",
                $"        [Route(\"get-set/id\")]",
                $"        [Produces(GeneralConstants.ContentType.Json)]",
                $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{prefix}{entityUpper}DTO>>), (int)StatusCodeEnum.OK)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                $"        public async Task<ActionResult<object>> GetSetByIds([FromBody] List<int> ids)",
                "        {",
                $"            List<{prefix}{entityUpper}DTO> response = await _{entityLower}Service.GetSetByIds(ids);",
                $"",
                $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                "        }",
                $"",
            ]);

            if (hasView)
            {
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets a full set of {entityUpper} by ids",
                    $"        /// </summary>",
                    $"        /// <param name=\"ids\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a full set of {entityUpper} by ids",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns a list of full {entityUpper} objects</response>",
                    $"        [PrivateIdentifierFilter]",
                    $"        [HttpPost]",
                    $"        [Route(\"get-set/id/full\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpper}DTO>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetFullSetByIds([FromBody] List<int> ids)",
                    "        {",
                    $"            List<View{prefix}{entityUpper}DTO> response = await _{entityLower}Service.GetFullSetByIds(ids);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $"",
                    $"        /// <summary>",
                    $"        /// Gets a base set of {entityUpper} by ids",
                    $"        /// </summary>",
                    $"        /// <param name=\"ids\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a base set of {entityUpper} by ids",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns a list of base {entityUpper} objects</response>",
                    $"        [PrivateIdentifierFilter]",
                    $"        [HttpPost]",
                    $"        [Route(\"get-set/id/base\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpperBase}BaseDTO>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetBaseSetByIds([FromBody] List<int> ids)",
                    "        {",
                    $"            List<View{prefix}{entityUpperBase}BaseDTO> response = await _{entityLower}Service.GetBaseSetByIds(ids);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
                ]);
            }

            if (WithCodigo)
            {
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets a {entityUpper} by code",
                    $"        /// </summary>",
                    $"        /// <param name=\"code\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a {entityUpper} by code",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns the {entityUpper} object</response>",
                    $"        [PrivateIdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"code/{{code}}\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<{prefix}{entityUpper}DTO>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetByCode(string code)",
                    "        {",
                    $"            {prefix}{entityUpper}DTO? response = await _{entityLower}Service.GetByCode(code);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        /// <summary>",
                        $"        /// Gets a full {entityUpper} by code",
                        $"        /// </summary>",
                        $"        /// <param name=\"code\"></param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets a full {entityUpper} by code",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns the full {entityUpper} object</response>",
                        $"        [PrivateIdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"code/{{code}}/full\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<View{prefix}{entityUpper}DTO>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetFullByCode(string code)",
                        "        {",
                        $"            View{prefix}{entityUpper}DTO? response = await _{entityLower}Service.GetFullByCode(code);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $"",
                        $"        /// <summary>",
                        $"        /// Gets a base {entityUpper} by code",
                        $"        /// </summary>",
                        $"        /// <param name=\"code\"></param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets a base {entityUpper} by code",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns the base {entityUpper} object</response>",
                        $"        [PrivateIdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"code/{{code}}/base\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<View{prefix}{entityUpperBase}BaseDTO>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetBaseByCode(string code)",
                        "        {",
                        $"            View{prefix}{entityUpperBase}BaseDTO? response = await _{entityLower}Service.GetBaseByCode(code);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
                    ]);
                }

                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets a set of {entityUpper} by codes",
                    $"        /// </summary>",
                    $"        /// <param name=\"codes\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a set of {entityUpper} by codes",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns a list of {entityUpper} objects</response>",
                    $"        [PrivateIdentifierFilter]",
                    $"        [HttpPost]",
                    $"        [Route(\"get-set/code\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{prefix}{entityUpper}DTO>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetSetByCodes([FromBody] List<string> codes)",
                    "        {",
                    $"            List<{prefix}{entityUpper}DTO> response = await _{entityLower}Service.GetSetByCodes(codes);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        /// <summary>",
                        $"        /// Gets a full set of {entityUpper} by codes",
                        $"        /// </summary>",
                        $"        /// <param name=\"codes\"></param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets a full set of {entityUpper} by codes",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns a list of full {entityUpper} objects</response>",
                        $"        [PrivateIdentifierFilter]",
                        $"        [HttpPost]",
                        $"        [Route(\"get-set/code/full\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpper}DTO>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetFullSetByCodes([FromBody] List<string> codes)",
                        "        {",
                        $"            List<View{prefix}{entityUpper}DTO> response = await _{entityLower}Service.GetFullSetByCodes(codes);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $"",
                        $"        /// <summary>",
                        $"        /// Gets a base set of {entityUpper} by codes",
                        $"        /// </summary>",
                        $"        /// <param name=\"codes\"></param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets a base set of {entityUpper} by codes",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns a list of base {entityUpper} objects</response>",
                        $"        [PrivateIdentifierFilter]",
                        $"        [HttpPost]",
                        $"        [Route(\"get-set/code/base\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpperBase}BaseDTO>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetBaseSetByCodes([FromBody] List<string> codes)",
                        "        {",
                        $"            List<View{prefix}{entityUpperBase}BaseDTO> response = await _{entityLower}Service.GetBaseSetByCodes(codes);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
                    ]);
                }
            }

            if (hasCmm)
            {
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets all {entityUpper}",
                    $"        /// </summary>",
                    $"        /// <param name=\"cmmKeyword\">Search by cmm</param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets all {entityUpper}",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns a list of {entityUpper} object</response>",
                    $"        [PrivateIdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"all\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{prefix}{entityUpper}DTO>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetAll([FromQuery] string? cmmKeyword = null)",
                    "        {",
                    $"            List<{prefix}{entityUpper}DTO> response = await _{entityLower}Service.GetAll(cmmKeyword);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        /// <summary>",
                        $"        /// Gets all full {entityUpper}",
                        $"        /// </summary>",
                        $"        /// <param name=\"cmmKeyword\">Search by cmm</param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets all full {entityUpper}",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns a full list of {entityUpper} object</response>",
                        $"        [PrivateIdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"all/full\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpper}DTO>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllFull([FromQuery] string? cmmKeyword = null)",
                        "        {",
                        $"            List<View{prefix}{entityUpper}DTO> response = await _{entityLower}Service.GetAllFull(cmmKeyword);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $"",
                        $"        /// <summary>",
                        $"        /// Gets all base {entityUpper}",
                        $"        /// </summary>",
                        $"        /// <param name=\"cmmKeyword\">Search by cmm</param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets all base {entityUpper}",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns a base list of {entityUpper} object</response>",
                        $"        [PrivateIdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"all/base\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpperBase}BaseDTO>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllBase([FromQuery] string? cmmKeyword = null)",
                        "        {",
                        $"            List<View{prefix}{entityUpperBase}BaseDTO> response = await _{entityLower}Service.GetAllBase(cmmKeyword);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
                    ]);
                }
            }
            else
            {
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets all {entityUpper}",
                    $"        /// </summary>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets all {entityUpper}",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns a list of {entityUpper} object</response>",
                    $"        [PrivateIdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"all\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{prefix}{entityUpper}DTO>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetAll()",
                    "        {",
                    $"            List<{prefix}{entityUpper}DTO> response = await _{entityLower}Service.GetAll();",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        /// <summary>",
                        $"        /// Gets all full {entityUpper}",
                        $"        /// </summary>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets all full {entityUpper}",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns a full list of {entityUpper} object</response>",
                        $"        [PrivateIdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"all/full\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpper}DTO>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllFull()",
                        "        {",
                        $"            List<View{prefix}{entityUpper}DTO> response = await _{entityLower}Service.GetAllFull();",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $"",
                        $"        /// <summary>",
                        $"        /// Gets all base {entityUpper}",
                        $"        /// </summary>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets all base {entityUpper}",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns a base list of {entityUpper} object</response>",
                        $"        [PrivateIdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"all/base\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpperBase}BaseDTO>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllBase()",
                        "        {",
                        $"            List<View{prefix}{entityUpperBase}BaseDTO> response = await _{entityLower}Service.GetAllBase();",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
                    ]);
                }
            }

            content.AddRange([
                $"        #endregion",
                $"",
                $"        #region Custom Endpoints",
            ]);

            content.AddRange(Utilities.GetCustomCode(_controllerModel.FirstOrDefault(x => x.Name == $"{entityUpper}Controller"), "Endpoints"));

            content.AddRange([
                $"        #endregion",
                "    }",
                "}"
            ]);

            GenerateFile("Controllers", $"{entityUpper}Controller.cs", content);
        }

        public void GenerateIService(string prefix, string entityUpper, string entityLower, bool WithCodigo, bool hasView, bool hasCmm)
        {
            List<string> content;
            string entityUpperBase;

            entityUpperBase = entityUpper;

            if (_filesModel.Any(x => x.Name == $"View{prefix}{entityUpper}sBaseObject"))
                entityUpperBase += "s";

            content = [
                $"using SAMMAI.Transverse.Models.DTOs;",
                $"using SAMMAI.Transverse.Models.Endpoints.Core.{entityUpper};",
                $"",
                $"namespace SAMMAI.Core.Services.DAL.Interfaces",
                "{",
                $"    public interface I{entityUpper}Service",
                "    {",
                $"        #region Base IServices",
                $"        Task<{prefix}{entityUpper}DTO?> GetById(int id, bool nullable = false);"
            ];

            if (hasView)
            {
                content.AddRange([
                    $"        Task<View{prefix}{entityUpper}DTO?> GetFullById(int id, bool nullable = false);",
                    $"        Task<View{prefix}{entityUpperBase}BaseDTO?> GetBaseById(int id, bool nullable = false);"
                ]);
            }

            content.AddRange([
                $"        Task<List<{prefix}{entityUpper}DTO>> GetSetByIds(List<int> ids);"
            ]);

            if (hasView)
            {
                content.AddRange([
                    $"        Task<List<View{prefix}{entityUpper}DTO>> GetFullSetByIds(List<int> ids);",
                    $"        Task<List<View{prefix}{entityUpperBase}BaseDTO>> GetBaseSetByIds(List<int> ids);"
                ]);
            }


            if (WithCodigo)
            {
                content.AddRange([
                    $"        Task<{prefix}{entityUpper}DTO?> GetByCode(string code, bool nullable = false);"
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        Task<View{prefix}{entityUpper}DTO?> GetFullByCode(string code, bool nullable = false);",
                        $"        Task<View{prefix}{entityUpperBase}BaseDTO?> GetBaseByCode(string code, bool nullable = false);"
                    ]);
                }

                content.AddRange([
                    $"        Task<List<{prefix}{entityUpper}DTO>> GetSetByCodes(List<string> codes);"
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        Task<List<View{prefix}{entityUpper}DTO>> GetFullSetByCodes(List<string> codes);",
                        $"        Task<List<View{prefix}{entityUpperBase}BaseDTO>> GetBaseSetByCodes(List<string> codes);"
                    ]);
                }
            }

            if (hasCmm)
            {
                content.AddRange([
                    $"        Task<List<{prefix}{entityUpper}DTO>> GetAll(string? cmmKeyword = null);"
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        Task<List<View{prefix}{entityUpper}DTO>> GetAllFull(string? cmmKeyword = null);",
                        $"        Task<List<View{prefix}{entityUpperBase}BaseDTO>> GetAllBase(string? cmmKeyword = null);",
                    ]);
                }
            }
            else
            {
                content.AddRange([
                   $"        Task<List<{prefix}{entityUpper}DTO>> GetAll();"
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        Task<List<View{prefix}{entityUpper}DTO>> GetAllFull();",
                        $"        Task<List<View{prefix}{entityUpperBase}BaseDTO>> GetAllBase();",
                    ]);
                }
            }
            
            content.AddRange([
                $"",
                $"        #endregion",
                $"",
                $"        #region Custom IServices",
            ]);

            content.AddRange(Utilities.GetCustomCode(_iServiceModel.FirstOrDefault(x => x.Name == $"I{entityUpper}Service"), "IServices"));

            content.AddRange([
                $"        #endregion",
                "    }",
                "}"
            ]);

            GenerateFile("IServices", $"I{entityUpper}Service.cs", content);
        }

        public void GenerateService(string prefix, string entityUpper, string entityLower, bool WithCodigo, bool hasView, bool hasCmm)
        {
            List<string> content = [];
            string entityUpperBase;

            entityUpperBase = entityUpper;

            if (_filesModel.Any(x => x.Name == $"View{prefix}{entityUpper}sBaseObject"))
                entityUpperBase += "s";

            content.AddRange([
                $"using AutoMapper;",
                $"using Microsoft.Extensions.Options;",
                $"using SAMMAI.Core.Repository;",
                $"using SAMMAI.Core.Services.DAL.Interfaces;",
                $"using SAMMAI.Core.Utility.Constants;",
                $"using SAMMAI.Core.Utility.SettingsFiles;",
                $"using SAMMAI.Transverse.Models.DTOs;",
                $"using SAMMAI.Transverse.Models.Endpoints.Core.{entityUpper};",
                $"",
                $"namespace SAMMAI.Core.Services.DAL.Implementations",
                "{",
                $"    public class {entityUpper}Service : I{entityUpper}Service",
                "    {",
                $"        private readonly ILogger<{entityUpper}Service> _logger;",
                $"        private readonly IMapper _mapper;",
                $"        private readonly DataBaseRepository _dataBaseRepository;",
                $"        private readonly DataBase _sammaiDataBaseOptions;",
                $"",
                $"        public {entityUpper}Service(",
                $"            ILogger<{entityUpper}Service> logger,",
                $"            IMapper mapper,",
                $"            DataBaseRepository dataBaseRepository,",
                $"            IOptions<ProjectSettings> projectSettingsOptions)",
                "        {",
                $"            _logger = logger ?? throw new ArgumentNullException(nameof(logger));",
                $"            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));",
                $"            _dataBaseRepository = dataBaseRepository ?? throw new ArgumentNullException(nameof(dataBaseRepository));",
                $"            _sammaiDataBaseOptions = projectSettingsOptions?.Value.SAMMAIMicroservices.DataBase ?? throw new ArgumentNullException(nameof(projectSettingsOptions));",
                "        }",
                $"",
                $"        #region Base Services",
                $"        public async Task<{prefix}{entityUpper}DTO?> GetById(int id, bool nullable = false)",
                "        {",
                $"            {prefix}{entityUpper}DTO? {entityLower};",
                $"",
                $"            {entityLower} = await _dataBaseRepository.GetById<{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper}, id);",
                $"            if ({entityLower} is null && !nullable) throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                $"",
                $"            return {entityLower};",
                "        }",
                $""
            ]);

            if (hasView)
            {
                content.AddRange([
                    $"        public async Task<View{prefix}{entityUpper}DTO?> GetFullById(int id, bool nullable = false)",
                    "        {",
                    $"            View{prefix}{entityUpper}DTO? {entityLower};",
                    $"",
                    $"            {entityLower} = await _dataBaseRepository.GetFullById<View{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper}, id);",
                    $"            if ({entityLower} is null && !nullable) throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                    $"",
                    $"            return {entityLower};",
                    "        }",
                    $"",
                    $"        public async Task<View{prefix}{entityUpperBase}BaseDTO?> GetBaseById(int id, bool nullable = false)",
                    "        {",
                    $"            View{prefix}{entityUpperBase}BaseDTO? {entityLower};",
                    $"",
                    $"            {entityLower} = await _dataBaseRepository.GetBaseById<View{prefix}{entityUpperBase}BaseDTO>(EntityConstants.{entityUpper}, id);",
                    $"            if ({entityLower} is null && !nullable) throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                    $"",
                    $"            return {entityLower};",
                    "        }",
                    $""
                ]);
            }

            content.AddRange([
                $"        public async Task<List<{prefix}{entityUpper}DTO>> GetSetByIds(List<int> ids)",
                "        {",
                $"            List<{prefix}{entityUpper}DTO> {entityLower}s;",
                $"",
                $"            {entityLower}s = await _dataBaseRepository.GetSetByIds<{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper}, ids);",
                $"",
                $"            return {entityLower}s;",
                "        }",
                $""
            ]);

            if (hasView)
            {
                content.AddRange([
                    $"        public async Task<List<View{prefix}{entityUpper}DTO>> GetFullSetByIds(List<int> ids)",
                    "        {",
                    $"            List<View{prefix}{entityUpper}DTO> {entityLower}s;",
                    $"",
                    $"            {entityLower}s = await _dataBaseRepository.GetFullSetByIds<View{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper}, ids);",
                    $"",
                    $"            return {entityLower}s;",
                    "        }",
                    $"",
                    $"        public async Task<List<View{prefix}{entityUpperBase}BaseDTO>> GetBaseSetByIds(List<int> ids)",
                    "        {",
                    $"            List<View{prefix}{entityUpperBase}BaseDTO> {entityLower}s;",
                    $"",
                    $"            {entityLower}s = await _dataBaseRepository.GetBaseSetByIds<View{prefix}{entityUpperBase}BaseDTO>(EntityConstants.{entityUpper}, ids);",
                    $"",
                    $"            return {entityLower}s;",
                    "        }",
                    $""
                ]);
            }

            if (WithCodigo)
            {
                content.AddRange([
                    $"        public async Task<{prefix}{entityUpper}DTO?> GetByCode(string code, bool nullable = false)",
                    "        {",
                    $"            {prefix}{entityUpper}DTO? {entityLower};",
                    $"",
                    $"            {entityLower} = await _dataBaseRepository.GetByCode<{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper}, code);",
                    $"            if ({entityLower} is null && !nullable) throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                    $"",
                    $"            return {entityLower};",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        public async Task<View{prefix}{entityUpper}DTO?> GetFullByCode(string code, bool nullable = false)",
                        "        {",
                        $"            View{prefix}{entityUpper}DTO? {entityLower};",
                        $"",
                        $"            {entityLower} = await _dataBaseRepository.GetFullByCode<View{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper}, code);",
                        $"            if ({entityLower} is null && !nullable) throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                        $"",
                        $"            return {entityLower};",
                        "        }",
                        $"",
                        $"        public async Task<View{prefix}{entityUpperBase}BaseDTO?> GetBaseByCode(string code, bool nullable = false)",
                        "        {",
                        $"            View{prefix}{entityUpperBase}BaseDTO? {entityLower};",
                        $"",
                        $"            {entityLower} = await _dataBaseRepository.GetBaseByCode<View{prefix}{entityUpperBase}BaseDTO>(EntityConstants.{entityUpper}, code);",
                        $"            if ({entityLower} is null && !nullable) throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                        $"",
                        $"            return {entityLower};",
                        "        }",
                        $""
                    ]);
                }

                content.AddRange([
                    $"        public async Task<List<{prefix}{entityUpper}DTO>> GetSetByCodes(List<string> codes)",
                    "        {",
                    $"            List<{prefix}{entityUpper}DTO> {entityLower}s;",
                    $"",
                    $"            {entityLower}s = await _dataBaseRepository.GetSetByCodes<{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper}, codes);",
                    $"",
                    $"            return {entityLower}s;",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpper}DTO>> GetFullSetByCodes(List<string> codes)",
                        "        {",
                        $"            List<View{prefix}{entityUpper}DTO> {entityLower}s;",
                        $"",
                        $"            {entityLower}s = await _dataBaseRepository.GetFullSetByCodes<View{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper}, codes);",
                        $"",
                        $"            return {entityLower}s;",
                        "        }",
                        $"",
                        $"        public async Task<List<View{prefix}{entityUpperBase}BaseDTO>> GetBaseSetByCodes(List<string> codes)",
                        "        {",
                        $"            List<View{prefix}{entityUpperBase}BaseDTO> {entityLower}s;",
                        $"",
                        $"            {entityLower}s = await _dataBaseRepository.GetBaseSetByCodes<View{prefix}{entityUpperBase}BaseDTO>(EntityConstants.{entityUpper}, codes);",
                        $"",
                        $"            return {entityLower}s;",
                        "        }",
                        $""
                    ]);
                }
            }

            if (hasCmm)
            {
                content.AddRange([
                    $"        public async Task<List<{prefix}{entityUpper}DTO>> GetAll(string? cmmKeyword = null)",
                    "        {",
                    $"            List<{prefix}{entityUpper}DTO> {entityLower}s;",
                    $"",
                    $"            {entityLower}s = await _dataBaseRepository.GetAll<{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper}, cmmKeyword);",
                    $"",
                    $"            return {entityLower}s;",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpper}DTO>> GetAllFull(string? cmmKeyword = null)",
                        "        {",
                        $"            List<View{prefix}{entityUpper}DTO> {entityLower}s;",
                        $"",
                        $"            {entityLower}s = await _dataBaseRepository.GetAllFull<View{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper}, cmmKeyword);",
                        $"",
                        $"            return {entityLower}s;",
                        "        }",
                        $"",
                        $"        public async Task<List<View{prefix}{entityUpperBase}BaseDTO>> GetAllBase(string? cmmKeyword = null)",
                        "        {",
                        $"            List<View{prefix}{entityUpperBase}BaseDTO> {entityLower}s;",
                        $"",
                        $"            {entityLower}s = await _dataBaseRepository.GetAllBase<View{prefix}{entityUpperBase}BaseDTO>(EntityConstants.{entityUpper}, cmmKeyword);",
                        $"",
                        $"            return {entityLower}s;",
                        "        }"
                    ]);
                }
            }
            else
            {
                content.AddRange([
                   $"        public async Task<List<{prefix}{entityUpper}DTO>> GetAll()",
                    "        {",
                    $"            List<{prefix}{entityUpper}DTO> {entityLower}s;",
                    $"",
                    $"            {entityLower}s = await _dataBaseRepository.GetAll<{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper});",
                    $"",
                    $"            return {entityLower}s;",
                    "        }",
                    $""
               ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpper}DTO>> GetAllFull()",
                        "        {",
                        $"            List<View{prefix}{entityUpper}DTO> {entityLower}s;",
                        $"",
                        $"            {entityLower}s = await _dataBaseRepository.GetAllFull<View{prefix}{entityUpper}DTO>(EntityConstants.{entityUpper});",
                        $"",
                        $"            return {entityLower}s;",
                        "        }",
                        $"",
                        $"        public async Task<List<View{prefix}{entityUpperBase}BaseDTO>> GetAllBase()",
                        "        {",
                        $"            List<View{prefix}{entityUpperBase}BaseDTO> {entityLower}s;",
                        $"",
                        $"            {entityLower}s = await _dataBaseRepository.GetAllBase<View{prefix}{entityUpperBase}BaseDTO>(EntityConstants.{entityUpper});",
                        $"",
                        $"            return {entityLower}s;",
                        "        }"
                    ]);
                }
            }

            content.AddRange([
                $"",
                $"        #endregion",
                $"",
                $"        #region Custom Services",
            ]);

            content.AddRange(Utilities.GetCustomCode(_serviceModel.FirstOrDefault(x => x.Name == $"{entityUpper}Service"), "Services"));

            content.AddRange([
                $"        #endregion",
                "    }",
                "}"
             ]);

            GenerateFile("Services", $"{entityUpper}Service.cs", content);
        }

        public void GenerateDTO(FileModel file, string prefix, string entityUpper, string entityLower)
        {
            List<string> template;
            List<string> content;
            List<FileModel> thisFileModel;
            List<string> files = [file.Path];

            List<string> pathList = [.. file.Path.Split("\\")];
            string pathFolder = string.Join("\\", pathList.GetRange(0, pathList.Count - 1));

            if (File.Exists(Path.Combine(pathFolder, $"View{file.Name}.{file.Extension}")))
                files.Add(Path.Combine(pathFolder, $"View{file.Name}.{file.Extension}"));

            if (File.Exists(Path.Combine(pathFolder, $"View{file.Name}.{file.Extension}").Replace($"Object.{file.Extension}", $"BaseObject.{file.Extension}")))
                files.Add(Path.Combine(pathFolder, $"View{file.Name}.{file.Extension}").Replace($"Object.{file.Extension}", $"BaseObject.{file.Extension}"));

            thisFileModel = Utilities.GetFilesModel(files);

            foreach (FileModel fileModel in thisFileModel)
            {
                template = [.. File.ReadAllLines(fileModel.Path)];

                content = [
                    $"namespace SAMMAI.Transverse.Models.DTOs",
                    "{",
                    $"    public class {fileModel.Name.Replace("Object", "DTO", StringComparison.CurrentCulture)}",
                    "    {"
                ];

                for (int i = 0; i < template.Count; i++)
                {
                    string line = template[i];

                    if (IsNotBlackList(line))
                        content.Add("    " + line);
                    else
                        continue;
                }

                content.AddRange([
                    "    }",
                    "}"
                ]);

                GenerateFile("DTO", $"{fileModel.Name.Replace("Object", "DTO", StringComparison.CurrentCulture)}.cs", content);
            }
        }

        

        private bool IsNotBlackList(string line)
        {
            return line.Contains("public ") && line.Contains(" { get; set; }") &&
                        !line.Contains(" Uid { get; set; }") &&
                        !line.Contains(" Eid { get; set; }") &&
                        !line.Contains(" IdUsuarioModifico { get; set; }") &&
                        !line.Contains(" IdUsuarioCreo { get; set; }") &&
                        !line.Contains(" FechaModificacion { get; set; }") &&
                        !line.Contains(" FechaCreacion { get; set; }") &&
                        !line.Contains(" Active { get; set; }") &&
                        !line.Contains(" public byte[]") &&
                        !line.Contains(" public string? Clave { get; set; }") &&
                        !line.Contains(" Multiempresa { get; set; }");
        }

        public string GenerateDI(string entity)
        {
            string service = $"{entity.AsSpan(3).ToString().Replace("Object", string.Empty)}Service";
            return $"services.AddScoped<I{service}, {service}> ();";
        }

        public string GenerateConstants(string entity)
        {
            string constant = entity.AsSpan(3).ToString().Replace("Object", string.Empty);
            return $"public const string {constant} = \"{constant.Substring(0, 1).ToLower() + constant.Substring(1)}\";";
        }

        public List<string> GenerateMapByEntity(string entity)
        {
            List<string> content;

            content = [
                $"CreateMap<{entity}, {entity[..^"Object".Length]}>();",
                $"CreateMap<{entity[..^"Object".Length]}, {entity}>();",
                ""
            ];

            return content;
        }

        #region Utilities
        private bool HasView(FileModel fileModel)
        {
            string viewPath;

            viewPath = fileModel.Path.Replace(fileModel.Name, $"View{fileModel.Name}");

            return File.Exists(viewPath);
        }

        private bool HasWord(string path, string key)
        {
            List<string> template = [.. File.ReadAllLines(path)];

            foreach (string line in template)
                if (line.Contains(key))
                    return true;

            return false;
        }

        private void GenerateFile(string directory, string file, List<string> content)
            => Utilities.GenerateFile(_destinyPath, directory, file, content);
        #endregion
    }
}