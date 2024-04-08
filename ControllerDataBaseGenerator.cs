using CodeGenerator.Helper;
using CodeGenerator.Models;

namespace CodeGenerator
{
    public class ControllerDataBaseGenerator
    {
        private readonly string _rootPath;
        private readonly List<string> _files;
        private readonly List<FileModel> _filesModel;
        private readonly string _destinyPath;

        public ControllerDataBaseGenerator(
            string rootPath,
            string destityPath)
        {
            _rootPath = rootPath;
            _destinyPath = destityPath;
            _files = [.. Directory.GetFiles(_rootPath)];
            _filesModel = Utilities.GetFilesModel(_files);
            Utilities.RegenerateDirectory(_destinyPath);
        }

        public List<string> GenerateForAllEntities()
        {
            List<string> responses = [];
            string response;

            List<FileModel> files = _filesModel.Where(x => x.Name.Substring(3, 1) == x.Name.Substring(3, 1).ToUpper()).ToList();
            List<string> contentDI = [];
            List<string> contentMappers = [];

            foreach (FileModel file in files)
            {
                response = GenerateByEntity(file.Name.Replace("Object", string.Empty), file);
                if (!string.IsNullOrEmpty(response))
                    responses.Add(response);

                contentDI.Add(GenerateDI(file.Name));
                contentMappers.AddRange(GenerateMapByEntity(file.Name));
            }

            GenerateFile("Dependencies", "Dependency.cs", contentDI);
            GenerateFile("Profiles", "GeneralEntityProfile.cs", contentMappers);

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

            try
            {
                prefix = entity[..3];
                init = entity.Substring(3, 1);
                entityUpper = string.Concat(init.ToUpper(), entity.AsSpan(4));
                entityLower = string.Concat(init.ToLower(), entity.AsSpan(4));

                withCodigo = 
                    HasWord(file.Path, $"public string? {entityUpper}Codigo {{ get; set; }}") ||
                    HasWord(file.Path, $"public string {entityUpper}Codigo {{ get; set; }} = null!;");
                hasView = HasView(file);

                GenerateController(prefix, entityUpper, entityLower, withCodigo, hasView);
                GenerateService(prefix, entityUpper, entityLower, withCodigo, hasView);

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message + "|" + ex.StackTrace;
            }
        }

        public void GenerateController(string prefix, string entityUpper, string entityLower, bool WithCodigo, bool hasView)
        {
            List<string> content;
            string controllerRoute;

            controllerRoute = "$\"{BaseApi}/" + $"{entityLower}\"";

            content = [
                $"using SAMMAI.DataBase.Utility.ActionFilters;",
                $"using Microsoft.AspNetCore.Mvc;",
                $"using SAMMAI.DataBase.Services.Implementations;",
                $"using SAMMAI.Transverse.Constants;",
                $"using SAMMAI.Transverse.Helpers;",
                $"using SAMMAI.Transverse.Models.Response.BaseApi;",
                $"using static SAMMAI.DataBase.Utility.Constants.ApiRoutesConstants;",
                $"",
                $"namespace SAMMAI.DataBase.Controllers",
                "{",
                $"    [Route({controllerRoute})]",
                $"    [ApiController]",
                $"    public class {entityUpper}Controller : ControllerBase",
                "    {",
                $"        private readonly ILogger<{entityUpper}Controller> _logger;",
                $"        private readonly {entityUpper}Service _{entityLower}Service;",
                $"",
                $"        public {entityUpper}Controller(",
                $"            ILogger<{entityUpper}Controller> logger,",
                $"            {entityUpper}Service {entityLower}Service)",
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
                $"        [IdentifierFilter]",
                $"        [HttpGet]",
                $"        [Route(\"{{id}}\")]",
                $"        [Produces(GeneralConstants.ContentType.Json)]",
                $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<{prefix}{entityUpper}Object>), (int)StatusCodeEnum.OK)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                $"        public async Task<ActionResult<object>> GetById(int id)",
                "        {",
                $"            {prefix}{entityUpper}Object response = await _{entityLower}Service.GetById(id);",
                $"",
                $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                "        }",
                $""
            ];

            if (hasView)
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
                    $"        [IdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"{{id}}/full\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<View{prefix}{entityUpper}Object>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetFullById(int id)",
                    "        {",
                    $"            View{prefix}{entityUpper}Object response = await _{entityLower}Service.GetFullById (id);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
            ]);

            if (WithCodigo)
            {
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets a {entityUpper} by codigo",
                    $"        /// </summary>",
                    $"        /// <param name=\"codigo\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a {entityUpper} by codigo",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns the {entityUpper} object</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"codigo/{{codigo}}\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<{prefix}{entityUpper}Object>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetByCodigo(string codigo)",
                    "        {",
                    $"            {prefix}{entityUpper}Object response = await _{entityLower}Service.GetByCodigo(codigo);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
                    ]);

                if (hasView)
                    content.AddRange([
                        $"        /// <summary>",
                        $"        /// Gets a full {entityUpper} by codigo",
                        $"        /// </summary>",
                        $"        /// <param name=\"codigo\"></param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets a full {entityUpper} by codigo",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns the full {entityUpper} object</response>",
                        $"        [IdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"codigo/{{codigo}}/full\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<View{prefix}{entityUpper}Object>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetFullByCodigo(string codigo)",
                        "        {",
                        $"            View{prefix}{entityUpper}Object response = await _{entityLower}Service.GetFullByCodigo(codigo);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
            ]);
            }

            content.AddRange([
                $"        /// <summary>",
                $"        /// Gets all {entityUpper}",
                $"        /// </summary>",
                $"        /// <returns></returns>",
                $"        /// <remarks>",
                $"        /// Gets all {entityUpper}",
                $"        /// </remarks>",
                $"        /// <response code=\"200\">Success: Returns a list of {entityUpper} object</response>",
                $"        [IdentifierFilter]",
                $"        [HttpGet]",
                $"        [Route(\"all\")]",
                $"        [Produces(GeneralConstants.ContentType.Json)]",
                $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{prefix}{entityUpper}Object>>), (int)StatusCodeEnum.OK)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                $"        public async Task<ActionResult<object>> GetAll()",
                "        {",
                $"            List<{prefix}{entityUpper}Object> response = await _{entityLower}Service.GetAll();",
                $"",
                $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                "        }",
                $""
                    ]);

            if (hasView)
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets all full {entityUpper}",
                    $"        /// </summary>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets all full {entityUpper}",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns a full list of {entityUpper} object</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"all/full\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpper}Object>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetAllFull()",
                    "        {",
                    $"            List<View{prefix}{entityUpper}Object> response = await _{entityLower}Service.GetAllFull();",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
                ]);

            content.AddRange([
                $"        /// <summary>",
                $"        /// Insert a {entityUpper}",
                $"        /// </summary>",
                $"        /// <param name=\"{entityLower}\"></param>",
                $"        /// <returns></returns>",
                $"        /// <remarks>",
                $"        /// Inserts a new {entityUpper}",
                $"        /// </remarks>",
                $"        /// <response code=\"200\">Success: Returns the new {entityUpper} object</response>",
                $"        [IdentifierFilter]",
                $"        [HttpPost]",
                $"        [Route(\"insert\")]",
                $"        [Produces(GeneralConstants.ContentType.Json)]",
                $"        [ProducesResponseType(typeof(BaseApiResponseWithData<{prefix}{entityUpper}Object>), (int)StatusCodeEnum.CREATED)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                $"        public async Task<ActionResult<object>> Insert([FromBody] {prefix}{entityUpper}Object {entityLower})",
                "        {",
                $"            {prefix}{entityUpper}Object response = await _{entityLower}Service.Insert({entityLower});",
                $"",
                $"            return StatusCode((int)StatusCodeEnum.CREATED, ResponseHelper.SetResponseWithData(StatusCodeEnum.CREATED, response));",
                "        }",
                $"",
                $"        /// <summary>",
                $"        /// Update a {entityUpper}",
                $"        /// </summary>",
                $"        /// <param name=\"{entityLower}\"></param>",
                $"        /// <returns></returns>",
                $"        /// <remarks>",
                $"        /// Update a {entityUpper}",
                $"        /// </remarks>",
                $"        /// <response code=\"204\">No Content</response>",
                $"        [IdentifierFilter]",
                $"        [HttpPut]",
                $"        [Route(\"update\")]",
                $"        [Produces(GeneralConstants.ContentType.Json)]",
                $"        [ProducesResponseType((int)StatusCodeEnum.NO_CONTENT)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                $"        public async Task<ActionResult<object>> Update([FromBody] {prefix}{entityUpper}Object {entityLower})",
                "        {",
                $"            await _{entityLower}Service.Update({entityLower});",
                $"",
                $"            return NoContent();",
                "        }",
                $"",
                $"        /// <summary>",
                $"        /// Activate or inactivate a {entityUpper} by id",
                $"        /// </summary>",
                $"        /// <param name=\"id\"></param>",
                $"        /// <param name=\"isActive\"></param>",
                $"        /// <returns></returns>",
                $"        /// <remarks>",
                $"        /// Activate or inactivate a {entityUpper} by id",
                $"        /// </remarks>",
                $"        /// <response code=\"200\">Success</response>",
                $"        [IdentifierFilter]",
                $"        [HttpPatch]",
                $"        [Route(\"{{id}}/active/{{isActive}}\")]",
                $"        [Produces(GeneralConstants.ContentType.Json)]",
                $"        [ProducesResponseType((int)StatusCodeEnum.OK)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                $"        public async Task<ActionResult<object>> SetActiveById(int id, bool isActive)",
                "        {",
                $"            await _{entityLower}Service.SetActiveById(id, isActive);",
                $"",
                $"            return Ok();",
                "        }",
                $""
            ]);

            if (WithCodigo)
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Activate or inactivate a {entityUpper} by codigo",
                    $"        /// </summary>",
                    $"        /// <param name=\"codigo\"></param>",
                    $"        /// <param name=\"isActive\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Activate or inactivate a {entityUpper} by codigo",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpPatch]",
                    $"        [Route(\"codigo/{{codigo}}/active/{{isActive}}\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType((int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> SetActiveByCodigo(string codigo, bool isActive)",
                    "        {",
                    $"            await _{entityLower}Service.SetActiveByCodigo(codigo, isActive);",
                    $"",
                    $"            return Ok();",
                    "        }"
            ]);

            content.AddRange([
                $"        #endregion",
                $"",
                $"        #region Custom Endpoints",
                $"",
                $"        #endregion",
                "    }",
                "}",
                $""
            ]);

            GenerateFile("Controllers", $"{entityUpper}Controller.cs", content);
        }

        public void GenerateService(string prefix, string entityUpper, string entityLower, bool WithCodigo, bool hasView)
        {
            List<string> content;

            content = [
                $"using AutoMapper;",
                $"using SAMMAI.DataBase.Repository.Context;",
                $"using SAMMAI.DataBase.Repository.Entities;",
                $"using SAMMAI.DataBase.Repository.Manager;",
                $"using SAMMAI.Transverse.Helpers;",
                $"",
                $"namespace SAMMAI.DataBase.Services.Implementations",
                "{",
                $"    public class {entityUpper}Service : BaseRepository<{prefix}{entityUpper}, {(hasView ? "View" : "")}{prefix}{entityUpper}, SAMMAIContext>",
                "    {",
                $"        private readonly ILogger<{entityUpper}Service> _logger;",
                $"        private readonly SAMMAIContext _context;",
                $"        private readonly Global _global;",
                $"        private readonly IMapper _mapper;",
                $"",
                $"        public {entityUpper}Service(",
                $"            ILogger<{entityUpper}Service> logger,",
                $"            SAMMAIContext context,",
                $"            Global global,",
                $"            IMapper mapper)",
                $"            : base(context, global)",
                "        {",
                $"            _logger = logger ?? throw new ArgumentNullException(nameof(logger));",
                $"            _context = context ?? throw new ArgumentNullException(nameof(context));",
                $"            _global = global ?? throw new ArgumentNullException(nameof(global));",
                $"            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));",
                "        }",
                $"",
                $"        #region Base Services",
                $"        public async Task<{prefix}{entityUpper}Object> GetById(int id)",
                "        {",
                $"            IEnumerable<{prefix}{entityUpper}> {entityLower}s = await GetFilteredAsync(x => x.Id == id && x.Eid == _global.Eid && x.Active);",
                $"",
                $"            return {entityLower}s.ToList().FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                "        }",
                $""
            ];

            if (hasView)
                content.AddRange([
                $"        public async Task<View{prefix}{entityUpper}Object> GetFullById(int id)",
                    "        {",
                    $"            IEnumerable<View{prefix}{entityUpper}> {entityLower}s = await GetViewFilteredAsync(x => x.Id == id && x.Eid == _global.Eid && x.Active);",
                    $"",
                    $"            return {entityLower}s.ToList().FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                    "        }",
                    $""
            ]);

            if (WithCodigo)
            {
                content.AddRange([
                    $"        public async Task<{prefix}{entityUpper}Object> GetByCodigo(string codigo)",
                    "        {",
                    $"            IEnumerable<{prefix}{entityUpper}> {entityLower}s = await GetFilteredAsync(x => x.{entityUpper}Codigo == codigo && x.Eid == _global.Eid && x.Active);",
                    $"",
                    $"            return {entityLower}s.ToList().FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                    "        }",
                    $""
                ]);

                if (hasView)
                    content.AddRange([
                        $"        public async Task<View{prefix}{entityUpper}Object> GetFullByCodigo(string codigo)",
                        "        {",
                        $"            IEnumerable<View{prefix}{entityUpper}> {entityLower}s = await GetViewFilteredAsync(x => x.{entityUpper}Codigo == codigo && x.Eid == _global.Eid && x.Active);",
                        $"",
                        $"            return {entityLower}s.ToList().FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                        "        }",
                        $""
                    ]);
            }

            content.AddRange([
                $"        public async Task<List<{prefix}{entityUpper}Object>> GetAll()",
                "        {",
                $"            IEnumerable<{prefix}{entityUpper}Object> {entityLower}s = await GetFilteredAsync(x => x.Eid == _global.Eid && x.Active);",
                $"",
                $"            return {entityLower}s.ToList();",
                "        }",
                $""
            ]);

            if (hasView)
                content.AddRange([
                    $"        public async Task<List<View{prefix}{entityUpper}Object>> GetAllFull()",
                    "        {",
                    $"            IEnumerable<View{prefix}{entityUpper}Object> {entityLower}s = await GetViewFilteredAsync(x => x.Eid == _global.Eid && x.Active);",
                    $"",
                    $"            return {entityLower}s.ToList();",
                    "        }",
                    $""
                ]);

            content.AddRange([
                $"        public async Task<{prefix}{entityUpper}Object> Insert({prefix}{entityUpper}Object input)",
                "        {",
                $"            input.Eid = _global.Eid;",
                $"            input.Uid = _global.Uid;",
                $"            input.IdUsuarioCreo = _global.IdUsuario;",
                $"            input.IdUsuarioModifico = _global.IdUsuario;",
                $"            input.FechaCreacion = DateTime.Now;",
                $"            input.FechaModificacion = input.FechaCreacion;",
                $"            input.Active = true;",
                $"",
                $"            {prefix}{entityUpper}Object? {entityLower} = await AddAsync(_mapper.Map<{prefix}{entityUpper}>(input));",
                $"",
                $"            if ({entityLower} != null)",
                $"                return {entityLower};",
                $"",
                $"            throw new ApiException(StatusCodeEnum.BAD_REQUEST);",
                "        }",
                $"",
                $"        public async Task Update({prefix}{entityUpper}Object input)",
                "        {",
                $"            {prefix}{entityUpper}Object {entityLower}Object;",
                $"",
                $"            await GetById(input.Id);",
                $"",
                $"            input.Eid = _global.Eid;",
                $"            input.Uid = _global.Uid;",
                $"            input.IdUsuarioModifico = _global.IdUsuario;",
                $"            input.FechaModificacion = DateTime.Now;",
                $"            input.Active = true;",
                $"",
                $"            {entityLower}Object = await UpdateAsync(_mapper.Map<{prefix}{entityUpper}>(input));",
                $"",
                $"            if ({entityLower}Object is null)",
                $"                throw new ApiException(StatusCodeEnum.BAD_REQUEST);",
                "        }",
                $"",
                $"        public async Task SetActiveById(int id, bool active)",
                "        {",
                $"            {prefix}{entityUpper}Object {entityLower}Object;",
                $"",
                $"            {entityLower}Object = await GetById(id);",
                $"",
                $"            {entityLower}Object.Eid = _global.Eid;",
                $"            {entityLower}Object.Uid = _global.Uid;",
                $"            {entityLower}Object.IdUsuarioModifico = _global.IdUsuario;",
                $"            {entityLower}Object.FechaModificacion = DateTime.Now;",
                $"            {entityLower}Object.Active = active;",
                $"",
                $"            {entityLower}Object = await UpdateAsync(_mapper.Map<{prefix}{entityUpper}>({entityLower}Object));",
                $"",
                $"            if ({entityLower}Object is null)",
                $"                throw new ApiException(StatusCodeEnum.BAD_REQUEST);",
                "        }",
                $""
            ]);

            if (WithCodigo)
                content.AddRange([
                    $"        public async Task SetActiveByCodigo(string codigo, bool active)",
                    "        {",
                    $"            {prefix}{entityUpper}Object {entityLower}Object;",
                    $"",
                    $"            {entityLower}Object = await GetByCodigo(codigo);",
                    $"",
                    $"            {entityLower}Object.Eid = _global.Eid;",
                    $"            {entityLower}Object.Uid = _global.Uid;",
                    $"            {entityLower}Object.IdUsuarioModifico = _global.IdUsuario;",
                    $"            {entityLower}Object.FechaModificacion = DateTime.Now;",
                    $"            {entityLower}Object.Active = active;",
                    $"",
                    $"            {entityLower}Object = await UpdateAsync(_mapper.Map<{prefix}{entityUpper}>({entityLower}Object));",
                    $"",
                    $"            if ({entityLower}Object is null)",
                    $"                throw new ApiException(StatusCodeEnum.BAD_REQUEST);",
                    "        }",
                ]);

            content.AddRange([
                $"        #endregion",
                $"",
                $"        #region Custom Services",
                $"",
                $"        #endregion",
                "    }",
                "}",
                $""
            ]);

            GenerateFile("Services", $"{entityUpper}Service.cs", content);
        }

        public string GenerateDI(string entity)
        {
            return $"services.AddTransient<{entity.AsSpan(3).ToString().Replace("Object", string.Empty)}Service>();";
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
