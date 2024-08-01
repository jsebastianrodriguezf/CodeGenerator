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

            List<FileModel> files = _filesModel.Where(x =>
                x.Name.Substring(3, 1) == x.Name.Substring(3, 1).ToUpper() || (!x.Name.StartsWith("View") &&
                x.Name.Substring(0, 2) != x.Name.Substring(0, 2).ToUpper() &&
                !(x.Name == "IdaeObject" || x.Name == "ErrorsObject"))).ToList();
            List<string> contentDI = [];
            List<string> contentEntityMappers = [];
            List<string> contentDTOMappers = [];
            List<string> constants = [];

            foreach (FileModel file in files)
            {
                response = GenerateByEntity(file.Name[..^"Object".Length], file);
                if (!string.IsNullOrEmpty(response))
                    responses.Add(response);

                contentDI.Add(GenerateDI(file.Name));
                contentEntityMappers.AddRange(GenerateMapByEntity(file));
                contentDTOMappers.AddRange(GenerateMapDTOByEntity(file));
                constants.Add(GenerateConstants(file.Name));
            }

            GenerateFile("Dependencies", "Dependency.cs", contentDI);
            GenerateFile("Profiles", "GeneralEntityProfile.cs", contentEntityMappers);
            GenerateFile("Profiles", "GeneralDTOObjectProfile.cs", contentDTOMappers);
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
            bool hasViewFull;
            bool hasCmm;
            bool hasPrincipalField;
            bool isStandardTable;

            try
            {
                prefix = entity[..3];
                init = entity.Substring(3, 1);

                isStandardTable = init.Equals(init.ToUpper(), StringComparison.CurrentCulture);

                if (isStandardTable)
                {
                    entityUpper = string.Concat(init.ToUpper(), entity.AsSpan(4));
                    entityLower = string.Concat(init.ToLower(), entity.AsSpan(4));
                }
                else
                {
                    prefix = string.Empty;
                    init = entity[..1];
                    entityUpper = string.Concat(init.ToUpper(), entity.AsSpan(1));
                    entityLower = string.Concat(init.ToLower(), entity.AsSpan(1));
                }

                withCode =
                    HasWord(file.Path, $"public string? {entityUpper}Code {{ get; set; }}") ||
                    HasWord(file.Path, $"public string {entityUpper}Code {{ get; set; }} = null!;");

                hasPrincipalField =
                    HasWord(file.Path, $"public string? {entityUpper} {{ get; set; }}") ||
                    HasWord(file.Path, $"public string {entityUpper} {{ get; set; }} = null!;");

                hasCmm = HasWord(file.Path, $"public string? Cmm {{ get; set; }}");
                hasView = HasView(file);
                hasViewFull = HasViewFull(file);

                if (entityLower == "event" || entityLower == "group")
                    entityLower += "Obj";

                GenerateController(prefix, entityUpper, entityLower, withCode, hasView, hasCmm, isStandardTable, hasViewFull);
                GenerateService(prefix, entityUpper, entityLower, withCode, hasView, hasCmm, hasPrincipalField, isStandardTable, hasViewFull);

                return string.Empty;
            }
            catch
            {
                throw;
            }
        }

        private string GetClassName(string prefix, string entity, bool hasViewFull)
        {
            return hasViewFull ? $"View{prefix}{entity}Full" : $"{prefix}{entity}";

        }

        public void GenerateController(string prefix, string entityUpper, string entityLower, bool WithCode, bool hasView, bool hasCmm, bool isStandardTable, bool hasViewFull)
        {
            List<string> content;
            string controllerRoute;
            string entityUpperBase;
            bool withSp = true;

            string className = GetClassName(prefix, entityUpper, hasViewFull);

            entityUpperBase = entityUpper;

            if (_filesModel.Any(x => x.Name == $"View{prefix}{entityUpper}sBaseObject"))
                entityUpperBase += "s";

            controllerRoute = "$\"{BaseApi}/" + $"{Utilities.ToKebabCase(entityUpper).ToLower()}\"";

            content = GetNamespacesController(entityUpper);

            content.AddRange([
                $"",
                $"namespace SAMMAI.DataBase.Controllers",
                "{",
                $"    [Route($\"{{BaseApi}}/{{BaseController.{entityUpper}}}\")]",
                $"    [ApiController]",
                $"    public class {entityUpper}Controller : ControllerBase",
                "    {",
            ]);

            content.AddRange(GetConstructorController(entityUpper, entityLower));

            content.AddRange([
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
                $"        [Route(ApiRoute.GetById)]",
                $"        [Produces(GeneralConstants.ContentType.Json)]",
                $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<{className}Object>), (int)StatusCodeEnum.OK)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                $"        public async Task<ActionResult<object>> GetById(int id)",
                "        {",
                $"            {className}Object response = await _{entityLower}Service.GetById(id);",
                $"",
                $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                "        }",
                $""
            ]);

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
                    $"        [Route(ApiRoute.GetFullById)]",
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
                    $"        [Route(ApiRoute.GetBaseById)]",
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
                $"        [Route(ApiRoute.GetSetByIds)]",
                $"        [Produces(GeneralConstants.ContentType.Json)]",
                $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{className}Object>>), (int)StatusCodeEnum.OK)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                $"        public async Task<ActionResult<object>> GetSetByIds([FromBody] List<int> ids)",
                "        {",
                $"            List<{className}Object> response = await _{entityLower}Service.GetSetByIds(ids);",
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
                    $"        [Route(ApiRoute.GetFullSetByIds)]",
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
                    $"        [Route(ApiRoute.GetBaseSetByIds)]",
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
                    $"        [Route(ApiRoute.GetByCode)]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<{className}Object>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetByCode(string code)",
                    "        {",
                    $"            {className}Object response = await _{entityLower}Service.GetByCode(code);",
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
                        $"        [Route(ApiRoute.GetFullByCode)]",
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
                        $"        [Route(ApiRoute.GetBaseByCode)]",
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
                    $"        /// <param name=\"spName\">Get data from this store procedure</param>",
                    $"        /// <param name=\"foreignValue\">Filter the store procedure with this value</param>",
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
                    $"        [Route(ApiRoute.GetAll)]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{className}Object>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetAll([FromQuery] string? cmmKeyword = null, [FromQuery] string? spName = null, [FromQuery] int? foreignValue = null)",
                    "        {",
                    $"            List<{className}Object> response = await _{entityLower}Service.GetAll(cmmKeyword, spName, foreignValue);",
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
                        $"        /// <param name=\"spName\">Get data from this store procedure</param>",
                        $"        /// <param name=\"foreignValue\">Filter the store procedure with this value</param>",
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
                        $"        [Route(ApiRoute.GetAllFull)]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpper}Object>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllFull([FromQuery] string? cmmKeyword = null, [FromQuery] string? spName = null, [FromQuery] int? foreignValue = null)",
                        "        {",
                        $"            List<View{prefix}{entityUpper}Object> response = await _{entityLower}Service.GetAllFull(cmmKeyword, spName, foreignValue);",
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
                        $"        /// <param name=\"spName\">Get data from this store procedure</param>",
                        $"        /// <param name=\"foreignValue\">Filter the store procedure with this value</param>",
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
                        $"        [Route(ApiRoute.GetAllBase)]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpperBase}BaseObject>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllBase([FromQuery] string? cmmKeyword = null, [FromQuery] string? spName = null, [FromQuery] int? foreignValue = null)",
                        "        {",
                        $"            List<View{prefix}{entityUpperBase}BaseObject> response = await _{entityLower}Service.GetAllBase(cmmKeyword, spName, foreignValue);",
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
                    ]);

                if (isStandardTable)
                    content.AddRange([
                        $"        /// <param name=\"spName\">Get data from this store procedure</param>",
                        $"        /// <param name=\"foreignValue\">Filter the store procedure with this value</param>",
                    ]);

                content.AddRange([
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
                    $"        [Route(ApiRoute.GetAll)]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<{className}Object>>), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> GetAll({(isStandardTable ? "[FromQuery] string? spName = null, [FromQuery] int? foreignValue = null" : "")})",
                    "        {",
                    $"            List<{className}Object> response = await _{entityLower}Service.GetAll({(isStandardTable ? "spName, foreignValue" : "")});",
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
                        $"        /// <param name=\"spName\">Get data from this store procedure</param>",
                        $"        /// <param name=\"foreignValue\">Filter the store procedure with this value</param>",
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
                        $"        [Route(ApiRoute.GetAllFull)]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpper}Object>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllFull([FromQuery] string? spName = null, [FromQuery] int? foreignValue = null)",
                        "        {",
                        $"            List<View{prefix}{entityUpper}Object> response = await _{entityLower}Service.GetAllFull(spName, foreignValue);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
                    ]);

                    content.AddRange([
                        $"        /// <summary>",
                        $"        /// Gets all base {entityUpper}",
                        $"        /// </summary>",
                        $"        /// <param name=\"spName\">Get data from this store procedure</param>",
                        $"        /// <param name=\"foreignValue\">Filter the store procedure with this value</param>",
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
                        $"        [Route(ApiRoute.GetAllBase)]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponseWithData<List<View{prefix}{entityUpperBase}BaseObject>>), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> GetAllBase([FromQuery] string? spName = null, [FromQuery] int? foreignValue = null)",
                        "        {",
                        $"            List<View{prefix}{entityUpperBase}BaseObject> response = await _{entityLower}Service.GetAllBase(spName, foreignValue);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponseWithData(response));",
                        "        }",
                        $""
                    ]);
                }
            }

            if (withSp && isStandardTable)
            {
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
                    $"        [Route(ApiRoute.Insert)]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseApiResponseWithData<{className}Object>), (int)StatusCodeEnum.CREATED)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> Insert([FromBody] {className}Object {entityLower})",
                    "        {",
                    $"            {className}Object response = await _{entityLower}Service.Insert({entityLower});",
                    $"",
                    $"            return StatusCode((int)StatusCodeEnum.CREATED, ResponseHelper.SetResponseWithData(StatusCodeEnum.CREATED, response));",
                    "        }",
                    $"",
                    $"        /// <summary>",
                    $"        /// Insert a list of {entityUpper}s",
                    $"        /// </summary>",
                    $"        /// <param name=\"{entityLower}s\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Insert a list of {entityUpper}s",
                    $"        /// ",
                    $"        /// Authorization: Private",
                    $"        /// ",
                    $"        ///     Headers:",
                    $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                    $"        /// </remarks>",
                    $"        /// <response code=\"200\">Success: Returns the news {entityUpper}s object</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpPost]",
                    $"        [Route(ApiRoute.BulkInsert)]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseApiResponseWithData<List<{className}Object>>), (int)StatusCodeEnum.CREATED)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> BulkInsert([FromBody] List<{className}Object> {entityLower}s)",
                    "        {",
                    $"            List<{className}Object> response = await _{entityLower}Service.BulkInsert({entityLower}s);",
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
                    $"        [Route(ApiRoute.Update)]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType((int)StatusCodeEnum.NO_CONTENT)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> Update([FromBody] {className}Object {entityLower})",
                    "        {",
                    $"            await _{entityLower}Service.Update({entityLower});",
                    $"",
                    $"            return NoContent();",
                    "        }",
                    $"",
                    $"        /// <summary>",
                    $"        /// Update a list of {entityUpper}s",
                    $"        /// </summary>",
                    $"        /// <param name=\"{entityLower}s\"></param>",
                    $"        /// <returns></returns>",
                    $"        /// <remarks>",
                    $"        /// Update a list of {entityUpper}s",
                    $"        /// ",
                    $"        /// Authorization: Private",
                    $"        /// ",
                    $"        ///     Headers:",
                    $"        ///         Authorization: <c>Bearer {{Token}}</c>",
                    $"        /// </remarks>",
                    $"        /// <response code=\"204\">No Content</response>",
                    $"        [IdentifierFilter]",
                    $"        [HttpPut]",
                    $"        [Route(ApiRoute.BulkUpdate)]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType((int)StatusCodeEnum.NO_CONTENT)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> BulkUpdate([FromBody] List<{className}Object> {entityLower}s)",
                    "        {",
                    $"            await _{entityLower}Service.BulkUpdate({entityLower}s);",
                    $"",
                    $"            return NoContent();",
                    "        }",
                ]);
            }
            else
            {
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
                    $"        [Route(ApiRoute.Insert)]",
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
                    $"        [Route(ApiRoute.Update)]",
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
                ]);
            }


            if (isStandardTable)
            {
                content.AddRange([
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
                    $"        [Route(ApiRoute.SetActiveById)]",
                    $"        [Produces(GeneralConstants.ContentType.Json)]",
                    $"        [ProducesResponseType(typeof(BaseSuccessApiResponse), (int)StatusCodeEnum.OK)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                    $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                    $"        public async Task<ActionResult<object>> SetActiveById(int id, bool isActive)",
                    "        {",
                    $"            await _{entityLower}Service.SetActiveById(id, isActive);",
                    $"",
                    $"            return Ok(ResponseHelper.SetSuccessResponse());",
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
                        $"        [Route(ApiRoute.SetActiveByCode)]",
                        $"        [Produces(GeneralConstants.ContentType.Json)]",
                        $"        [ProducesResponseType(typeof(BaseSuccessApiResponse), (int)StatusCodeEnum.OK)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.NOT_FOUND)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.BAD_REQUEST)]",
                        $"        [ProducesResponseType(typeof(BaseBadRequestApiResponse), (int)StatusCodeEnum.INTERNAL_SERVER_ERROR)]",
                        $"        public async Task<ActionResult<object>> SetActiveByCode(string code, bool isActive)",
                        "        {",
                        $"            await _{entityLower}Service.SetActiveByCode(code, isActive);",
                        $"",
                        $"            return Ok(ResponseHelper.SetSuccessResponse());",
                        "        }"
                    ]);
            }

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

        public void GenerateService(string prefix, string entityUpper, string entityLower, bool WithCode, bool hasView, bool hasCmm, bool hasPrincipalField, bool isStandardTable, bool hasViewFull)
        {
            List<string> content;
            string viewGenerics;
            string entityUpperBase;
            bool withSP = true;

            string className = GetClassName(prefix, entityUpper, hasViewFull);

            entityUpperBase = entityUpper;

            if (_filesModel.Any(x => x.Name == $"View{prefix}{entityUpper}sBaseObject"))
                entityUpperBase += "s";

            viewGenerics = hasView ?
                $"View{prefix}{entityUpper}, View{prefix}{entityUpperBase}Base" :
                $"{prefix}{entityUpper}, {prefix}{entityUpper}";

            content = GetNamespacesService(entityUpper);

            content.AddRange([
                $"",
                $"namespace SAMMAI.DataBase.Services.Implementations",
                "{",
                $"    public class {entityUpper}Service : BaseRepository<{className}, {viewGenerics}, SAMMAIContext>",
                "    {",
            ]);

            content.AddRange(GetConstructorService(entityUpper, entityLower));

            content.AddRange([
                $"",
                $"        #region Base Services",
                $"        public async Task<{className}Object> GetById(int id)",
                "        {",
                $"            IEnumerable<{className}> {entityLower}s = await GetFilteredAsync(x => x.Id == id{(isStandardTable ? " && x.Eid == _global.Eid && x.Active" : "")});",
                $"",
                $"            return {entityLower}s.FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.NOT_FOUND);",
                "        }",
                $""
            ]);

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
                $"        public Task<List<{className}Object>> GetSetByIds(List<int> ids)",
                "        {",
                $"            IEnumerable<{className}> {entityLower}s;",
                $"",
                $"            {entityLower}s = (",
                $"                from {entityLower} in _context.Set<{className}>()",
                $"                join idsObject in ids on {entityLower}.Id equals idsObject",
            ]);

            if (isStandardTable)
                content.AddRange([
                    $"                where {entityLower}.Eid == _global.Eid && {entityLower}.Active",
                ]);

            content.AddRange([
                $"                select {entityLower});",
                $"",
                $"            return Task.FromResult(_mapper.Map<List<{className}Object>>({entityLower}s));",
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
                    $"        public async Task<{className}Object> GetByCode(string code)",
                    "        {",
                    $"            IEnumerable<{className}> {entityLower}s = await GetFilteredAsync(x => x.{entityUpper}Code == code{(isStandardTable ? " && x.Eid == _global.Eid && x.Active" : "")});",
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
                    $"        public async Task<List<{className}Object>> GetAll(string? cmmKeyword, string? spName = null, int? foreignValue = null)",
                    "        {",
                    $"            return _mapper.Map<List<{className}Object>>(await GetAllData<{className}>(spName, foreignValue, cmmKeyword));",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpper}Object>> GetAllFull(string? cmmKeyword, string? spName = null, int? foreignValue = null)",
                        "        {",
                        $"            return _mapper.Map<List<View{prefix}{entityUpper}Object>>(await GetAllData<View{prefix}{entityUpper}>(spName, foreignValue, cmmKeyword));",
                        "        }",
                        $""
                    ]);

                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpperBase}BaseObject>> GetAllBase(string? cmmKeyword, string? spName = null, int? foreignValue = null)",
                        "        {",
                        $"            return _mapper.Map<List<View{prefix}{entityUpperBase}BaseObject>>(await GetAllData<View{prefix}{entityUpperBase}Base>(spName, foreignValue, cmmKeyword));",
                        "        }",
                        $""
                    ]);
                }
            }
            else
            {
                content.AddRange([
                    $"        public async Task<List<{className}Object>> GetAll({(isStandardTable ? "string? spName = null, int? foreignValue = null" : "")})",
                    "        {",
                    $"            return {(isStandardTable ?
                                        $"_mapper.Map<List<{className}Object>>(await GetAllData<{className}>(spName, foreignValue))" :
                                        $"await GetAll()")};",
                    "        }",
                    $""
                ]);

                if (hasView)
                {
                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpper}Object>> GetAllFull(string? spName = null, int? foreignValue = null)",
                        "        {",
                        $"            return _mapper.Map<List<View{prefix}{entityUpper}Object>>(await GetAllData<View{prefix}{entityUpper}>(spName, foreignValue));",
                        "        }",
                        $""
                    ]);

                    content.AddRange([
                        $"        public async Task<List<View{prefix}{entityUpperBase}BaseObject>> GetAllBase(string? spName = null, int? foreignValue = null)",
                        "        {",
                        $"            return _mapper.Map<List<View{prefix}{entityUpperBase}BaseObject>>(await GetAllData<View{prefix}{entityUpperBase}Base>(spName, foreignValue));",
                        "        }",
                        $""
                    ]);
                }
            }

            if (withSP && isStandardTable)
            {
                content.AddRange([
                    $"        public async Task<{className}Object> Insert({className}Object input)",
                    "        {",
                    $"            List<{className}Object> {entityLower} = await BulkInsert([input]);",
                    $"",
                    $"            return {entityLower}.FirstOrDefault() ?? throw new ApiException(StatusCodeEnum.BAD_REQUEST);",
                    "        }",
                    $"",
                    $"        public async Task<List<{className}Object>> BulkInsert(List<{className}Object> input)",
                    "        {",
                    $"            List<{className}Object> {entityLower} = _mapper.Map<List<{className}Object>>(await BulkInsert<{className}Object>(input));",
                    $"            return {entityLower};",
                    "        }",
                    $"",
                    $"        public async Task Update({className}Object input)",
                    "        {",
                    $"            await GetById(input.Id);",
                    "",
                    $"            await BulkUpdate([input]);",
                    "        }",
                    $"",
                    $"        public async Task BulkUpdate(List<{className}Object> input)",
                    "        {",
                    $"            await BulkUpdate<{className}Object>(input);",
                    "        }",
                ]);
            }
            else
            {
                content.AddRange([
                    $"        public async Task<{prefix}{entityUpper}Object> Insert({prefix}{entityUpper}Object input)",
                    "        {",
                ]);

                if (isStandardTable)
                    content.AddRange([
                        $"            input.Eid = _global.Eid;",
                        $"            input.Uid = _global.Uid;",
                        $"            input.IdUserCreator = _global.IdUser;",
                        $"            input.IdUserModifier = _global.IdUser;",
                        $"            input.DateCreation = DateTime.Now;",
                        $"            input.DateModification = input.DateCreation;",
                        $"            input.Active = true;",
                        $"",
                    ]);

                content.AddRange([
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
                ]);

                if (isStandardTable)
                    content.AddRange([
                        $"            input.Eid = _global.Eid;",
                        $"            input.Uid = _global.Uid;",
                        $"            input.IdUserModifier = _global.IdUser;",
                        $"            input.DateModification = DateTime.Now;",
                        $"            input.Active = true;",
                        $"",
                    ]);

                content.AddRange([
                    $"            {entityLower}Object = await UpdateAsync(_mapper.Map<{prefix}{entityUpper}>(input));",
                    $"",
                    $"            if ({entityLower}Object is null)",
                    $"                throw new ApiException(StatusCodeEnum.BAD_REQUEST);",
                    "        }",
                ]);
            }

            if (isStandardTable)
            {
                content.AddRange([
                    $"",
                    $"        public async Task SetActiveById(int id, bool active)",
                    "        {",
                    $"            {className}Object {entityLower}Object = await GetById(id);",
                    $"",
                    $"            await Active({entityLower}Object.Id, active);",
                    "        }",
                    $""
                ]);

                if (WithCode)
                    content.AddRange([
                        $"        public async Task SetActiveByCode(string code, bool active)",
                        "        {",
                        $"            {className}Object {entityLower}Object = await GetByCode(code);",
                        $"",
                        $"            await Active({entityLower}Object.Id, active);",
                        "        }",
                    ]);
            }

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
            string init;
            string entityUpper;

            entity = entity[..^"Object".Length];
            init = entity.Substring(3, 1);

            if (init.Equals(init.ToUpper(), StringComparison.CurrentCulture))
            {
                entityUpper = string.Concat(init.ToUpper(), entity.AsSpan(4));
            }
            else
            {
                init = entity[..1];
                entityUpper = string.Concat(init.ToUpper(), entity.AsSpan(1));
            }

            return $"services.AddTransient<{entityUpper}Service>();";
        }

        public List<string> GenerateMapByEntity(FileModel file)
        {
            List<string> content;

            content = [
                $"CreateMap<{file.Name}, {file.Name[..^"Object".Length]}>();",
                $"CreateMap<{file.Name[..^"Object".Length]}, {file.Name}>();",
                ""
            ];

            if (HasViewFull(file))
            {
                content.AddRange([
                    $"CreateMap<View{file.Name[..^"Object".Length]}FullObject, View{file.Name[..^"Object".Length]}Full>();",
                    $"CreateMap<View{file.Name[..^"Object".Length]}Full, View{file.Name[..^"Object".Length]}FullObject>();",
                    ""
                ]);
            }

            return content;
        }

        private List<string> GenerateMapDTOByEntity(FileModel file)
        {
            List<string> content;

            content = [
                $"CreateMap<{file.Name}, {file.Name[..^"Object".Length]}DTO>();",
                $"CreateMap<{file.Name[..^"Object".Length]}DTO, {file.Name}>();",
                "",
            ];

            if (_filesModel.Any(x => x.Name == $"View{file.Name}"))
                content.AddRange([
                    $"CreateMap<View{file.Name}, View{file.Name[..^"Object".Length]}DTO>();",
                    $"CreateMap<View{file.Name[..^"Object".Length]}DTO, View{file.Name}>();",
                    "",
                ]);

            if (_filesModel.Any(x => x.Name == $"View{file.Name[..^"Object".Length]}BaseObject"))
                content.AddRange([
                    $"CreateMap<View{file.Name[..^"Object".Length]}BaseObject, View{file.Name[..^"Object".Length]}BaseDTO>();",
                    $"CreateMap<View{file.Name[..^"Object".Length]}BaseDTO, View{file.Name[..^"Object".Length]}BaseObject>();",
                    "",
                ]);

            if (HasViewFull(file))
            {
                content.AddRange([
                    $"CreateMap<View{file.Name[..^"Object".Length]}FullObject, View{file.Name[..^"Object".Length]}FullDTO>();",
                    $"CreateMap<View{file.Name[..^"Object".Length]}FullDTO, View{file.Name[..^"Object".Length]}FullObject>();",
                    ""
                ]);
            }

            content.Add("");

            return content;
        }

        public string GenerateConstants(string entity)
        {
            string init;
            string entityUpper;

            entity = entity[..^"Object".Length];
            init = entity.Substring(3, 1);

            if (init.Equals(init.ToUpper(), StringComparison.CurrentCulture))
            {
                entityUpper = string.Concat(init.ToUpper(), entity.AsSpan(4));
            }
            else
            {
                init = entity[..1];
                entityUpper = string.Concat(init.ToUpper(), entity.AsSpan(1));
            }

            string constant = entityUpper;
            return $"public const string {constant} = \"{Utilities.ToKebabCase(constant)}\";";
        }

        #region Utilities

        private bool HasView(FileModel fileModel)
        {
            string viewPath;

            viewPath = fileModel.Path.Replace(fileModel.Name, $"View{fileModel.Name}");

            return File.Exists(viewPath);
        }

        private bool HasViewFull(FileModel fileModel)
        {
            string viewPath;

            viewPath = fileModel.Path.Replace(fileModel.Name, $"View{fileModel.Name[..^"Object".Length]}FullObject");

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

        private List<string> GetNamespacesController(string entityUpper)
        {
            List<string> content;
            List<string> defaultNamespaces;

            defaultNamespaces = [
                $"using Microsoft.AspNetCore.Mvc;",
                $"using SAMMAI.DataBase.Services.Implementations;",
                $"using SAMMAI.DataBase.Utility.ActionFilters;",
                $"using SAMMAI.Transverse.Constants;",
                $"using SAMMAI.Transverse.Helpers;",
                $"using SAMMAI.Transverse.Models.Response.BaseApi;",
                $"using static SAMMAI.DataBase.Utility.Constants.ApiRoutesConstants;",
                $"using static SAMMAI.Transverse.Constants.ApiRoutes.DataBaseAPI;",
            ];

            content = Utilities.GetNamespaces(_controllerModel.FirstOrDefault(x => x.Name == $"{entityUpper}Controller"), defaultNamespaces);

            return content;
        }

        private List<string> GetNamespacesService(string entityUpper)
        {
            List<string> content;
            List<string> defaultNamespaces;

            defaultNamespaces = [
                $"using AutoMapper;",
                $"using SAMMAI.DataBase.Repository.Context;",
                $"using SAMMAI.DataBase.Repository.Entities;",
                $"using SAMMAI.DataBase.Repository.Manager;",
                $"using System.Data;",
            ];

            content = Utilities.GetNamespaces(_serviceModel.FirstOrDefault(x => x.Name == $"{entityUpper}Service"), defaultNamespaces);

            return content;
        }

        private List<string> GetConstructorController(string entityUpper, string entityLower)
        {
            List<string> content;
            List<string> defaultProperties;
            List<string> defaultParameters;
            List<string> defaultContent;

            string constructorMethod = $"        public {entityUpper}Controller(";

            defaultProperties = [
                $"        private readonly ILogger<{entityUpper}Controller> _logger;",
                $"        private readonly {entityUpper}Service _{entityLower}Service;",
            ];

            defaultParameters = [
                $"            ILogger<{entityUpper}Controller> logger,",
                $"            {entityUpper}Service {entityLower}Service,",
            ];

            defaultContent = [
                $"            _logger = logger ?? throw new ArgumentNullException(nameof(logger));",
                $"            _{entityLower}Service = {entityLower}Service ?? throw new ArgumentNullException(nameof({entityLower}Service));",
            ];

            content = Utilities.GetConstructor(
                _controllerModel.FirstOrDefault(x => x.Name == $"{entityUpper}Controller"),
                constructorMethod, defaultProperties, defaultParameters, defaultContent);


            return content;
        }

        private List<string> GetConstructorService(string entityUpper, string entityLower)
        {
            List<string> content;
            List<string> defaultProperties;
            List<string> defaultParameters;
            List<string> defaultContent;

            string constructorMethod = $"        public {entityUpper}Service(";

            defaultProperties = [
                $"        private readonly ILogger<{entityUpper}Service> _logger;",
                $"        private readonly SAMMAIContext _context;",
                $"        private readonly Global _global;",
                $"        private readonly IMapper _mapper;",
            ];

            defaultParameters = [
                $"            ILogger<{entityUpper}Service> logger,",
                $"            SAMMAIContext context,",
                $"            Global global,",
                $"            IMapper mapper)",
                $"            : base(context, global)",
            ];

            defaultContent = [
                $"            _logger = logger ?? throw new ArgumentNullException(nameof(logger));",
                $"            _context = context ?? throw new ArgumentNullException(nameof(context));",
                $"            _global = global ?? throw new ArgumentNullException(nameof(global));",
                $"            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));",
            ];

            content = Utilities.GetConstructor(
                _serviceModel.FirstOrDefault(x => x.Name == $"{entityUpper}Service"),
                constructorMethod, defaultProperties, defaultParameters, defaultContent);

            return content;
        }
        #endregion
    }
}
