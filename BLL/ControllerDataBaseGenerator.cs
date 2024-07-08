using CodeGenerator.External;
using CodeGenerator.Helper;
using CodeGenerator.Models;

namespace CodeGenerator.BLL
{
    public class ControllerDataBaseGenerator
    {
        private readonly string _rootPath;
        private readonly string _destinyPath;
        private readonly List<FileModel> _controllerModel;
        private readonly List<FileModel> _serviceModel;
        private readonly List<string> _files;
        private readonly List<FileModel> _filesModel;
        private readonly TranstaleService _transtaleService;

        public ControllerDataBaseGenerator(
            string rootPath,
            string destityPath,
            string controllerPath,
            string servicePath)
        {
            _rootPath = rootPath;
            _destinyPath = destityPath;
            _files = [.. Directory.GetFiles(_rootPath)];
            _filesModel = Utilities.GetFilesModel(_files);

            _controllerModel = Utilities.GetFilesModel([.. Directory.GetFiles(controllerPath)]);
            _serviceModel = Utilities.GetFilesModel([.. Directory.GetFiles(servicePath)]);

            _transtaleService = new TranstaleService(Constants.BaseConstants.Languages.English, Constants.BaseConstants.Languages.Spanish);

            Utilities.RegenerateDirectory(_destinyPath);
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
                response = GenerateByEntity(file.Name[..^"Object".Length], file);
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
            bool withCode;
            bool hasView;
            bool hasCmm;
            bool hasPrincipalField;

            try
            {
                prefix = entity[..3];
                init = entity.Substring(3, 1);
                entityUpper = string.Concat(init.ToUpper(), entity.AsSpan(4));
                entityLower = string.Concat(init.ToLower(), entity.AsSpan(4));

                withCode =
                    HasWord(file.Path, $"public string? {entityUpper}Code {{ get; set; }}") ||
                    HasWord(file.Path, $"public string {entityUpper}Code {{ get; set; }} = null!;");

                hasPrincipalField =
                    HasWord(file.Path, $"public string? {entityUpper} {{ get; set; }}") ||
                    HasWord(file.Path, $"public string {entityUpper} {{ get; set; }} = null!;");

                hasCmm = HasWord(file.Path, $"public string? Cmm {{ get; set; }}");
                hasView = HasView(file);

                if (entityLower == "event" || entityLower == "group")
                    entityLower += "Obj";

                GenerateController(prefix, entityUpper, entityLower, withCode, hasView, hasCmm);
                GenerateService(prefix, entityUpper, entityLower, withCode, hasView, hasCmm, hasPrincipalField);

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message + "|" + ex.StackTrace;
            }
        }

        public void GenerateController(string prefix, string entityUpper, string entityLower, bool WithCode, bool hasView, bool hasCmm)
        {
            List<string> content;
            string controllerRoute;
            string entityUpperBase;

            entityUpperBase = entityUpper;

            if (_filesModel.Any(x => x.Name == $"View{prefix}{entityUpper}sBaseObject"))
                entityUpperBase += "s";

            controllerRoute = "$\"{BaseApi}/" + $"{Utilities.ToKebabCase(entityUpper).ToLower()}\"";

            content = [
                $"using Microsoft.AspNetCore.Mvc;",
                $"using SAMMAI.DataBase.Services.Implementations;",
                $"using SAMMAI.DataBase.Utility.ActionFilters;",
                $"using SAMMAI.Transverse.Constants;",
                $"using SAMMAI.Transverse.Helpers;",
                $"using SAMMAI.Transverse.Models.Endpoints.DataBase.{entityUpper};",
                $"using SAMMAI.Transverse.Models.Response.BaseApi;",
                $"using static SAMMAI.DataBase.Utility.Constants.ApiRoutesConstants;",
                $"using static SAMMAI.Transverse.Constants.ApiRoutes.DataBaseAPI;",
                $"",
                $"namespace SAMMAI.DataBase.Controllers",
                "{",
                $"    [Route($\"{{BaseApi}}/{{{entityUpper}BaseController}}\")]",
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
                $"        /// ",
                $"        /// Authorization: Private",
                $"        /// ",
                $"        ///     Headers:",
                $"        ///         Authorization: <c>Bearer {{Token}}</c>",
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
            {
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets a full {entityUpper} by id",
                    $"        /// </summary>",
                    $"        /// <param name=\"id\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a full {entityUpper} by id",
                    $"        /// ",
                    $"        /// Authorization: Private",
                    $"        /// ",
                    $"        ///     Headers:",
                    $"        ///         Authorization: <c>Bearer {{Token}}</c>",
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
                    $"            View{prefix}{entityUpper}Object response = await _{entityLower}Service.GetFullById(id);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
               ]);

                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets a base {entityUpper} by id",
                    $"        /// </summary>",
                    $"        /// <param name=\"id\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a base {entityUpper} by id",
                    $"        /// ",
                    $"        /// Authorization: Private",
                    $"        /// ",
                    $"        ///     Headers:",
                    $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns the base {entityUpper} object</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"{{id}}/base\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<View{prefix}{entityUpperBase}BaseObject>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetBaseById(int id)",
                    "        {",
                    $"            View{prefix}{entityUpperBase}BaseObject response = await _{entityLower}Service.GetBaseById(id);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
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
                $"        /// ",
                $"        /// Authorization: Private",
                $"        /// ",
                $"        ///     Headers:",
                $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                $"        /// </remarks>",
                $"        /// <response code=\"200\">Success: Returns a list of {entityUpper} objects</response>",
                $"        [IdentifierFilter]",
                $"        [HttpPost]",
                $"        [Route(\"get-set\")]",
                $"        [Produces(GeneralConstants.ContentType.Json)]",
                $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{prefix}{entityUpper}Object>>), (int)StatusCodeEnum.OK)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                $"        public async Task<ActionResult<object>> GetSetByIds([FromBody] List<int> ids)",
                "        {",
                $"            List<{prefix}{entityUpper}Object> response = await _{entityLower}Service.GetSetByIds(ids);",
                $"",
                $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                "        }",
                $""
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
                    $"        /// ",
                    $"        /// Authorization: Private",
                    $"        /// ",
                    $"        ///     Headers:",
                    $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns a list of full {entityUpper} objects</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpPost]",
                    $"        [Route(\"get-set/full\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpper}Object>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetFullSetByIds([FromBody] List<int> ids)",
                    "        {",
                    $"            List<View{prefix}{entityUpper}Object> response = await _{entityLower}Service.GetFullSetByIds(ids);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
                ]);

                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets a base set of {entityUpper} by ids",
                    $"        /// </summary>",
                    $"        /// <param name=\"ids\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a base set of {entityUpper} by ids",
                    $"        /// ",
                    $"        /// Authorization: Private",
                    $"        /// ",
                    $"        ///     Headers:",
                    $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns a list of base {entityUpper} objects</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpPost]",
                    $"        [Route(\"get-set/base\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpperBase}BaseObject>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetBaseSetByIds([FromBody] List<int> ids)",
                    "        {",
                    $"            List<View{prefix}{entityUpperBase}BaseObject> response = await _{entityLower}Service.GetBaseSetByIds(ids);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                    "        }",
                    $""
                ]);
            }

            if (WithCode)
            {
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Gets a {entityUpper} by code",
                    $"        /// </summary>",
                    $"        /// <param name=\"code\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets a {entityUpper} by code",
                    $"        /// ",
                    $"        /// Authorization: Private",
                    $"        /// ",
                    $"        ///     Headers:",
                    $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns the {entityUpper} object</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"code/{{code}}\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<{prefix}{entityUpper}Object>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetByCode(string code)",
                    "        {",
                    $"            {prefix}{entityUpper}Object response = await _{entityLower}Service.GetByCode(code);",
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
                        $"        /// ",
                        $"        /// Authorization: Private",
                        $"        /// ",
                        $"        ///     Headers:",
                        $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns the full {entityUpper} object</response>",
                        $"        [IdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"code/{{code}}/full\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<View{prefix}{entityUpper}Object>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetFullByCode(string code)",
                        "        {",
                        $"            View{prefix}{entityUpper}Object response = await _{entityLower}Service.GetFullByCode(code);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
                    ]);

                    content.AddRange([
                       $"        /// <summary>",
                        $"        /// Gets a base {entityUpper} by code",
                        $"        /// </summary>",
                        $"        /// <param name=\"code\"></param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets a base {entityUpper} by code",
                        $"        /// ",
                        $"        /// Authorization: Private",
                        $"        /// ",
                        $"        ///     Headers:",
                        $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns the base {entityUpper} object</response>",
                        $"        [IdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"code/{{code}}/base\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<View{prefix}{entityUpperBase}BaseObject>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetBaseByCode(string code)",
                        "        {",
                        $"            View{prefix}{entityUpperBase}BaseObject response = await _{entityLower}Service.GetBaseByCode(code);",
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
                    $"        /// <param name=\"foreignKey\">Search by foreign column</param>",
                    $"        /// <param name=\"foreignValue\">Search the foreign column with this value</param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets all {entityUpper}",
                    $"        /// ",
                    $"        /// Authorization: Private",
                    $"        /// ",
                    $"        ///     Headers:",
                    $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns a list of {entityUpper} object</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"all\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{prefix}{entityUpper}Object>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetAll([FromQuery] string? cmmKeyword = null, [FromQuery] string? foreignKey = null, [FromQuery] int foreignValue = 0)",
                    "        {",
                    $"            List<{prefix}{entityUpper}Object> response = await _{entityLower}Service.GetAll(cmmKeyword, foreignKey, foreignValue);",
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
                        $"        /// <param name=\"foreignKey\">Search by foreign column</param>",
                        $"        /// <param name=\"foreignValue\">Search the foreign column with this value</param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets all full {entityUpper}",
                        $"        /// ",
                        $"        /// Authorization: Private",
                        $"        /// ",
                        $"        ///     Headers:",
                        $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns a full list of {entityUpper} object</response>",
                        $"        [IdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"all/full\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpper}Object>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllFull([FromQuery] string? cmmKeyword = null, [FromQuery] string? foreignKey = null, [FromQuery] int foreignValue = 0)",
                        "        {",
                        $"            List<View{prefix}{entityUpper}Object> response = await _{entityLower}Service.GetAllFull(cmmKeyword, foreignKey, foreignValue);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
                    ]);

                    content.AddRange([
                        $"        /// <summary>",
                        $"        /// Gets all base {entityUpper}",
                        $"        /// </summary>",
                        $"        /// <param name=\"cmmKeyword\">Search by cmm</param>",
                        $"        /// <param name=\"foreignKey\">Search by foreign column</param>",
                        $"        /// <param name=\"foreignValue\">Search the foreign column with this value</param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets all base {entityUpper}",
                        $"        /// ",
                        $"        /// Authorization: Private",
                        $"        /// ",
                        $"        ///     Headers:",
                        $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns a base list of {entityUpper} object</response>",
                        $"        [IdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"all/base\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpperBase}BaseObject>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllBase([FromQuery] string? cmmKeyword = null, [FromQuery] string? foreignKey = null, [FromQuery] int foreignValue = 0)",
                        "        {",
                        $"            List<View{prefix}{entityUpperBase}BaseObject> response = await _{entityLower}Service.GetAllBase(cmmKeyword, foreignKey, foreignValue);",
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
                    $"        /// <param name=\"foreignKey\">Search by foreign column</param>",
                    $"        /// <param name=\"foreignValue\">Search the foreign column with this value</param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Gets all {entityUpper}",
                    $"        /// ",
                    $"        /// Authorization: Private",
                    $"        /// ",
                    $"        ///     Headers:",
                    $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns a list of {entityUpper} object</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpGet]",
                    $"        [Route(\"all\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{prefix}{entityUpper}Object>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetAll([FromQuery] string? foreignKey = null, [FromQuery] int foreignValue = 0)",
                    "        {",
                    $"            List<{prefix}{entityUpper}Object> response = await _{entityLower}Service.GetAll(foreignKey, foreignValue);",
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
                        $"        /// <param name=\"foreignKey\">Search by foreign column</param>",
                        $"        /// <param name=\"foreignValue\">Search the foreign column with this value</param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets all full {entityUpper}",
                        $"        /// ",
                        $"        /// Authorization: Private",
                        $"        /// ",
                        $"        ///     Headers:",
                        $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns a full list of {entityUpper} object</response>",
                        $"        [IdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"all/full\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpper}Object>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllFull([FromQuery] string? foreignKey = null, [FromQuery] int foreignValue = 0)",
                        "        {",
                        $"            List<View{prefix}{entityUpper}Object> response = await _{entityLower}Service.GetAllFull(foreignKey, foreignValue);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
                    ]);

                    content.AddRange([
                        $"        /// <summary>",
                        $"        /// Gets all base {entityUpper}",
                        $"        /// </summary>",
                        $"        /// <param name=\"foreignKey\">Search by foreign column</param>",
                        $"        /// <param name=\"foreignValue\">Search the foreign column with this value</param>",
                        $"        /// <returns></returns>",
                        $"        /// <remarks>",
                        $"        /// Gets all base {entityUpper}",
                        $"        /// ",
                        $"        /// Authorization: Private",
                        $"        /// ",
                        $"        ///     Headers:",
                        $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                        $"        /// </remarks>",
                        $"        /// <response code=\"200\">Success: Returns a base list of {entityUpper} object</response>",
                        $"        [IdentifierFilter]",
                        $"        [HttpGet]",
                        $"        [Route(\"all/base\")]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpperBase}BaseObject>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllBase([FromQuery] string? foreignKey = null, [FromQuery] int foreignValue = 0)",
                        "        {",
                        $"            List<View{prefix}{entityUpperBase}BaseObject> response = await _{entityLower}Service.GetAllBase(foreignKey, foreignValue);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
                    ]);
                }
            }

            content.AddRange([
                $"        /// <summary>",
                $"        /// Insert a {entityUpper}",
                $"        /// </summary>",
                $"        /// <param name=\"{entityLower}\"></param>",
                $"        /// <returns></returns>",
                $"        /// <remarks>",
                $"        /// Inserts a new {entityUpper}",
                $"        /// ",
                $"        /// Authorization: Private",
                $"        /// ",
                $"        ///     Headers:",
                $"        ///         Authorization: <c>Bearer {{Token}}</c>",
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
                $"        /// ",
                $"        /// Authorization: Private",
                $"        /// ",
                $"        ///     Headers:",
                $"        ///         Authorization: <c>Bearer {{Token}}</c>",
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
                $"        /// ",
                $"        /// Authorization: Private",
                $"        /// ",
                $"        ///     Headers:",
                $"        ///         Authorization: <c>Bearer {{Token}}</c>",
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

            if (WithCode)
                content.AddRange([
                    $"        /// <summary>",
                    $"        /// Activate or inactivate a {entityUpper} by code",
                    $"        /// </summary>",
                    $"        /// <param name=\"code\"></param>",
                    $"        /// <param name=\"isActive\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Activate or inactivate a {entityUpper} by code",
                    $"        /// ",
                    $"        /// Authorization: Private",
                    $"        /// ",
                    $"        ///     Headers:",
                    $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpPatch]",
                    $"        [Route(\"code/{{code}}/active/{{isActive}}\")]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType((int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> SetActiveByCode(string code, bool isActive)",
                    "        {",
                    $"            await _{entityLower}Service.SetActiveByCode(code, isActive);",
                    $"",
                    $"            return Ok();",
                    "        }"
            ]);

            content.AddRange([
                $"        #endregion",
                $"",
                $"        #region Custom Endpoints"
            ]);

            content.AddRange(Utilities.GetCustomCode(_controllerModel.FirstOrDefault(x => x.Name == $"{entityUpper}Controller"), "Endpoints"));
            //content.AddRange(Utilities.GetCustomCode(_controllerModel.FirstOrDefault(x => x.Name == $"{_transtaleService.Translate(entityUpper).Result}Controller"), "Endpoints"));

            content.AddRange([
                $"        #endregion",
                "    }",
                "}"
            ]);

            GenerateFile("Controllers", $"{entityUpper}Controller.cs", content);
        }

        public void GenerateService(string prefix, string entityUpper, string entityLower, bool WithCode, bool hasView, bool hasCmm, bool hasPrincipalField)
        {
            List<string> content;
            string viewGenerics;
            string entityUpperBase;

            entityUpperBase = entityUpper;

            if (_filesModel.Any(x => x.Name == $"View{prefix}{entityUpper}sBaseObject"))
                entityUpperBase += "s";

            viewGenerics = hasView ?
                $"View{prefix}{entityUpper}, View{prefix}{entityUpperBase}Base" :
                $"{prefix}{entityUpper}, {prefix}{entityUpper}";

            content = [
                $"using AutoMapper;",
                $"using Microsoft.Data.SqlClient;",
                $"using SAMMAI.DataBase.Repository.Context;",
                $"using SAMMAI.DataBase.Repository.Entities;",
                $"using SAMMAI.DataBase.Repository.Manager;",
                $"using SAMMAI.DataBase.Repository.StorePrecedure.Entities;",
                $"using SAMMAI.Transverse.Helpers;",
                $"using SAMMAI.Transverse.Models.Endpoints.DataBase.{entityUpper};",
                $"using System.Data;",
                $"using static SAMMAI.Transverse.Constants.GeneralConstants;",
                $"",
                $"namespace SAMMAI.DataBase.Services.Implementations",
                "{",
                $"    public class {entityUpper}Service : BaseRepository<{prefix}{entityUpper}, {viewGenerics}, SAMMAIContext>",
                "    {",
                $"        private readonly ILogger<{entityUpper}Service> _logger;",
                $"        private readonly SAMMAIContext _context;",
                $"        private readonly Global _global;",
                $"        private readonly IMapper _mapper;",
                $"        private readonly GeneralService _generalService;",
                $"",
                $"        public {entityUpper}Service(",
                $"            ILogger<{entityUpper}Service> logger,",
                $"            SAMMAIContext context,",
                $"            Global global,",
                $"            IMapper mapper,",
                $"            GeneralService generalService)",
                $"            : base(context, global)",
                "        {",
                $"            _logger = logger ?? throw new ArgumentNullException(nameof(logger));",
                $"            _context = context ?? throw new ArgumentNullException(nameof(context));",
                $"            _global = global ?? throw new ArgumentNullException(nameof(global));",
                $"            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));",
                $"            _generalService = generalService ?? throw new ArgumentNullException(nameof(generalService));",
                "        }",
                $"",
                $"        #region Base Services",
                $"        public async Task<{prefix}{entityUpper}Object> GetById(int id)",
                "        {",
                $"            IEnumerable<{prefix}{entityUpper}> {entityLower}s = await GetFilteredAsync(x => x.Id == id && x.Eid == _global.Eid && x.Active);",
                $"",
                $"            return {entityLower}s.FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                "        }",
                $""
            ];

            if (hasView)
            {
                content.AddRange([
                    $"        public async Task<View{prefix}{entityUpper}Object> GetFullById(int id)",
                    "        {",
                    $"            IEnumerable<View{prefix}{entityUpper}> {entityLower}s = await GetViewFilteredAsync(x => x.Id == id && x.Eid == _global.Eid && x.Active);",
                    $"",
                    $"            return {entityLower}s.FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                    "        }",
                    $""
                ]);

                content.AddRange([
                    $"        public async Task<View{prefix}{entityUpperBase}BaseObject> GetBaseById(int id)",
                    "        {",
                    $"            IEnumerable<View{prefix}{entityUpperBase}Base> {entityLower}s = await GetViewBaseFilteredAsync(x => x.Id == id && x.Eid == _global.Eid && x.Active);",
                    $"",
                    $"            return {entityLower}s.FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                    "        }",
                    $""
                ]);
            }

            content.AddRange([
                $"        public Task<List<{prefix}{entityUpper}Object>> GetSetByIds(List<int> ids)",
                "        {",
                $"            IEnumerable<{prefix}{entityUpper}> {entityLower}s;",
                $"",
                $"            {entityLower}s = (",
                $"                from {entityLower} in _context.Set<{prefix}{entityUpper}>()",
                $"                join idsObject in ids on {entityLower}.Id equals idsObject",
                $"                where {entityLower}.Eid == _global.Eid && {entityLower}.Active",
                $"                select {entityLower});",
                $"",
                $"            return Task.FromResult(_mapper.Map<List<{prefix}{entityUpper}Object>>({entityLower}s));",
                "        }",
                $""
            ]);

            if (hasView)
            {
                content.AddRange([
                   $"        public Task<List<View{prefix}{entityUpper}Object>> GetFullSetByIds(List<int> ids)",
                    "        {",
                    $"            IEnumerable<View{prefix}{entityUpper}> {entityLower}s;",
                    $"",
                    $"            {entityLower}s = (",
                    $"                from {entityLower} in _context.Set<View{prefix}{entityUpper}>()",
                    $"                join idsObject in ids on {entityLower}.Id equals idsObject",
                    $"                where {entityLower}.Eid == _global.Eid && {entityLower}.Active",
                    $"                select {entityLower});",
                    $"",
                    $"            return Task.FromResult(_mapper.Map<List<View{prefix}{entityUpper}Object>>({entityLower}s));",
                    "        }",
                    $""
               ]);

                content.AddRange([
                   $"        public Task<List<View{prefix}{entityUpperBase}BaseObject>> GetBaseSetByIds(List<int> ids)",
                    "        {",
                    $"            IEnumerable<View{prefix}{entityUpperBase}Base> {entityLower}s;",
                    $"",
                    $"            {entityLower}s = (",
                    $"                from {entityLower} in _context.Set<View{prefix}{entityUpperBase}Base>()",
                    $"                join idsObject in ids on {entityLower}.Id equals idsObject",
                    $"                where {entityLower}.Eid == _global.Eid && {entityLower}.Active",
                    $"                select {entityLower});",
                    $"",
                    $"            return Task.FromResult(_mapper.Map<List<View{prefix}{entityUpperBase}BaseObject>>({entityLower}s));",
                    "        }",
                    $""
               ]);
            }

            if (WithCode)
            {
                content.AddRange([
                    $"        public async Task<{prefix}{entityUpper}Object> GetByCode(string code)",
                    "        {",
                    $"            IEnumerable<{prefix}{entityUpper}> {entityLower}s = await GetFilteredAsync(x => x.{entityUpper}Code == code && x.Eid == _global.Eid && x.Active);",
                    $"",
                    $"            return {entityLower}s.FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        public async Task<View{prefix}{entityUpper}Object> GetFullByCode(string code)",
                        "        {",
                        $"            IEnumerable<View{prefix}{entityUpper}> {entityLower}s = await GetViewFilteredAsync(x => x.{entityUpper}Code == code && x.Eid == _global.Eid && x.Active);",
                        $"",
                        $"            return {entityLower}s.FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                        "        }",
                        $""
                    ]);

                    content.AddRange([
                        $"        public async Task<View{prefix}{entityUpperBase}BaseObject> GetBaseByCode(string code)",
                        "        {",
                        $"            IEnumerable<View{prefix}{entityUpperBase}Base> {entityLower}s = await GetViewBaseFilteredAsync(x => x.{entityUpper}Code == code && x.Eid == _global.Eid && x.Active);",
                        $"",
                        $"            return {entityLower}s.FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                        "        }",
                        $""
                    ]);
                }
            }

            if (hasCmm)
            {
                content.AddRange([
                    $"        public async Task<List<{prefix}{entityUpper}Object>> GetAll(string? cmmKeyword, string? foreignKey = null, int foreignValue = 0)",
                    "        {",
                    $"            IEnumerable<{prefix}{entityUpper}Object> {entityLower}s;",
                    $"",
                    $"            if (string.IsNullOrWhiteSpace(foreignKey))",
                    $"                {entityLower}s = string.IsNullOrWhiteSpace(cmmKeyword) ?",
                    $"                    await GetFilteredAsync(x => x.Eid == _global.Eid && x.Active) :",
                    $"                    await GetFilteredAsync(x => {
                                           (hasPrincipalField ?
                                               $"(x.Cmm == null ? x.{entityUpper}.Contains(cmmKeyword) : x.Cmm.Contains(cmmKeyword))" :
                                               $"x.Cmm != null && x.Cmm.Contains(cmmKeyword)"
                                           )
                                         } &&  x.Eid == _global.Eid && x.Active);",
                    "            else",
                    $"                {entityLower}s = await _generalService.GetData<{prefix}{entityUpper}, {prefix}{entityUpper}>(foreignKey, foreignValue, cmmKeyword);",
                    $"",
                    $"           return {entityLower}s.ToList();",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpper}Object>> GetAllFull(string? cmmKeyword, string? foreignKey = null, int foreignValue = 0)",
                        "        {",
                        $"            IEnumerable<View{prefix}{entityUpper}Object> {entityLower}s;",
                        $"",
                        $"            if (string.IsNullOrWhiteSpace(foreignKey))",
                        $"                {entityLower}s = string.IsNullOrWhiteSpace(cmmKeyword) ?",
                        $"                    await GetViewFilteredAsync(x => x.Eid == _global.Eid && x.Active) :",
                        $"                    await GetViewFilteredAsync(x => {
                                                (hasPrincipalField ?
                                                    $"(x.Cmm == null ? x.{entityUpper}.Contains(cmmKeyword) : x.Cmm.Contains(cmmKeyword))" :
                                                    $"x.Cmm != null && x.Cmm.Contains(cmmKeyword)"
                                                )
                                              } &&  x.Eid == _global.Eid && x.Active);",
                        "            else",
                        $"                {entityLower}s = await _generalService.GetData<{prefix}{entityUpper}, View{prefix}{entityUpper}>(foreignKey, foreignValue, cmmKeyword);",
                        $"",
                        $"           return {entityLower}s.ToList();",
                        "        }",
                        $""
                    ]);

                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpperBase}BaseObject>> GetAllBase(string? cmmKeyword, string? foreignKey = null, int foreignValue = 0)",
                        "        {",
                        $"            IEnumerable<View{prefix}{entityUpperBase}BaseObject> {entityLower}s;",
                        $"",
                        $"            if (string.IsNullOrWhiteSpace(foreignKey))",
                        $"                {entityLower}s = string.IsNullOrWhiteSpace(cmmKeyword) ?",
                        $"                    await GetViewBaseFilteredAsync(x => x.Eid == _global.Eid && x.Active) :",
                        $"                    await GetViewBaseFilteredAsync(x => {
                                                (hasPrincipalField ?
                                                    $"(x.Cmm == null ? x.{entityUpper}.Contains(cmmKeyword) : x.Cmm.Contains(cmmKeyword))" :
                                                    $"x.Cmm != null && x.Cmm.Contains(cmmKeyword)"
                                                )
                                              } &&  x.Eid == _global.Eid && x.Active);",
                        "            else",
                        $"                {entityLower}s = await _generalService.GetData<{prefix}{entityUpper}, View{prefix}{entityUpperBase}Base>(foreignKey, foreignValue, cmmKeyword);",
                        $"",
                        $"           return {entityLower}s.ToList();",
                        "        }",
                        $""
                    ]);
                }
            }
            else
            {
                content.AddRange([
                    $"        public async Task<List<{prefix}{entityUpper}Object>> GetAll(string? foreignKey = null, int foreignValue = 0)",
                    "        {",
                    $"            IEnumerable<{prefix}{entityUpper}Object> {entityLower}s;",
                    $"",
                    $"            if (string.IsNullOrWhiteSpace(foreignKey))",
                    $"                {entityLower}s = await GetFilteredAsync(x => x.Eid == _global.Eid && x.Active);",
                    "            else",
                    $"                {entityLower}s = await _generalService.GetData<{prefix}{entityUpper}, {prefix}{entityUpper}>(foreignKey, foreignValue, cmmKeyword);",
                    $"",
                    $"           return {entityLower}s.ToList();",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpper}Object>> GetAllFull(string? foreignKey = null, int foreignValue = 0)",
                        "        {",
                        $"            IEnumerable<View{prefix}{entityUpper}Object> {entityLower}s;",
                        $"",
                        $"            if (string.IsNullOrWhiteSpace(foreignKey))",
                        $"                {entityLower}s = await GetViewFilteredAsync(x => x.Eid == _global.Eid && x.Active);",
                        "            else",
                        $"                {entityLower}s = await _generalService.GetData<{prefix}{entityUpper}, View{prefix}{entityUpper}>(foreignKey, foreignValue, cmmKeyword);",
                        $"",
                        $"           return {entityLower}s.ToList();",
                        "        }",
                        $""
                    ]);

                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpperBase}BaseObject>> GetAllBase(string? foreignKey = null, int foreignValue = 0)",
                        "        {",
                        $"            IEnumerable<View{prefix}{entityUpperBase}BaseObject> {entityLower}s;",
                        $"",
                        $"            if (string.IsNullOrWhiteSpace(foreignKey))",
                        "                 {entityLower}s = await GetViewBaseFilteredAsync(x => x.Eid == _global.Eid && x.Active);",
                        "            else",
                        $"                 {entityLower}s = await _generalService.GetData<{prefix}{entityUpper}, View{prefix}{entityUpperBase}Base>(foreignKey, foreignValue, cmmKeyword);",
                        $"",
                        $"            return {entityLower}s.ToList();",
                        "        }",
                        $""
                    ]);
                }
            }

            content.AddRange([
                $"        public async Task<{prefix}{entityUpper}Object> Insert({prefix}{entityUpper}Object input)",
                "        {",
                $"            input.Eid = _global.Eid;",
                $"            input.Uid = _global.Uid;",
                $"            input.IdUserCreator = _global.IdUser;",
                $"            input.IdUserModifier = _global.IdUser;",
                $"            input.DateCreation = DateTime.Now;",
                $"            input.DateModification = input.DateCreation;",
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
                $"            input.IdUserModifier = _global.IdUser;",
                $"            input.DateModification = DateTime.Now;",
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
                $"            {entityLower}Object.IdUserModifier = _global.IdUser;",
                $"            {entityLower}Object.DateModification = DateTime.Now;",
                $"            {entityLower}Object.Active = active;",
                $"",
                $"            {entityLower}Object = await UpdateAsync(_mapper.Map<{prefix}{entityUpper}>({entityLower}Object));",
                $"",
                $"            if ({entityLower}Object is null)",
                $"                throw new ApiException(StatusCodeEnum.BAD_REQUEST);",
                "        }",
                $""
            ]);

            if (WithCode)
                content.AddRange([
                    $"        public async Task SetActiveByCode(string code, bool active)",
                    "        {",
                    $"            {prefix}{entityUpper}Object {entityLower}Object;",
                    $"",
                    $"            {entityLower}Object = await GetByCode(code);",
                    $"",
                    $"            {entityLower}Object.Eid = _global.Eid;",
                    $"            {entityLower}Object.Uid = _global.Uid;",
                    $"            {entityLower}Object.IdUserModifier = _global.IdUser;",
                    $"            {entityLower}Object.DateModification = DateTime.Now;",
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
                $"        #region Custom Services"
            ]);

            content.AddRange(Utilities.GetCustomCode(_serviceModel.FirstOrDefault(x => x.Name == $"{entityUpper}Service"), "Services"));
            //content.AddRange(Utilities.GetCustomCode(_serviceModel.FirstOrDefault(x => x.Name == $"{_transtaleService.Translate(entityUpper).Result}Service"), "Services"));

            content.AddRange([
                $"        #endregion",
                "    }",
                "}"
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

        public string GenerateConstants(string entity)
        {
            string constant = entity.AsSpan(3).ToString()[..^"Object".Length];
            return $"public const string {constant}BaseController = \"{Utilities.ToKebabCase(constant)}\";";
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
