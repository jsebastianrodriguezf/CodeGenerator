using CodeGenerator.BLL;
using CodeGenerator.Helper;

namespace CodeGenerator.Proccess
{
    public class MapDataBase
    {
        private readonly string _contextName;
        private readonly string _rootPathModels;
        private readonly string _rootPathSAMMAIDataBase;
        private readonly string _rootPathSAMMAICore;
        private readonly string _destinyPath;

        const string ModelsTranslatedFolder = "ModelsTranslated";
        const string DataBaseConfigFolder = "DataBaseConfig";

        public MapDataBase(
            string contextName,
            string rootPathModels,
            string rootPathSAMMAIDataBase,
            string rootPathSAMMAICore,
            string destityPath)
        {
            _contextName = contextName;
            _rootPathModels = rootPathModels;
            _rootPathSAMMAIDataBase = rootPathSAMMAIDataBase;
            _rootPathSAMMAICore = rootPathSAMMAICore;
            _destinyPath = destityPath;

            Utilities.RegenerateDirectory(_destinyPath);
        }

        public string Execute()
        {
            try
            {
                Exec_I18NDictionaryGenerator();
                Exec_TranslateEFModelGenerator();
                Exec_DatabaseGenerator();
                Exec_ControllerDataBaseGenerator();
                Exec_ControllerCoreDALGenerator();

                return "Success";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        private void Exec_I18NDictionaryGenerator()
        {
            I18NDictionaryGenerator i18NDictionaryGenerator;

            i18NDictionaryGenerator = new I18NDictionaryGenerator(
                    contextName: _contextName,
                    rootPath: _rootPathModels,
                    destinyPath: Path.Combine(_destinyPath, "I18N"));

            i18NDictionaryGenerator.FullFillDictionary();
        }

        private void Exec_TranslateEFModelGenerator()
        {
            TranslateEFModelGenerator translateEFModelGenerator;

            translateEFModelGenerator = new TranslateEFModelGenerator(
                    conextName: _contextName,
                    rootPath: _rootPathModels,
                    destityPath: Path.Combine(_destinyPath, ModelsTranslatedFolder));

            translateEFModelGenerator.Generate();
        }

        private void Exec_DatabaseGenerator()
        {
            DatabaseGenerator databaseGenerator;

            databaseGenerator = new DatabaseGenerator(
                    conextName: _contextName,
                    rootPath: Path.Combine(_destinyPath, ModelsTranslatedFolder),
                    destityPath: Path.Combine(_destinyPath, DataBaseConfigFolder));

            databaseGenerator.Generate();
        }

        private void Exec_ControllerDataBaseGenerator()
        {
            ControllerDataBaseGenerator controllerDataBaseGenerator;

            controllerDataBaseGenerator = new ControllerDataBaseGenerator(
                    rootPath: Path.Combine(_destinyPath, DataBaseConfigFolder, "Objects"),
                    destityPath: Path.Combine(_destinyPath, "SAMMAI.DataBase"),
                    controllerPath: Path.Combine(_rootPathSAMMAIDataBase, "Controllers"),
                    servicePath: Path.Combine(_rootPathSAMMAIDataBase, "Services", "Implementations"));

            controllerDataBaseGenerator.GenerateForAllEntities();
        }

        private void Exec_ControllerCoreDALGenerator()
        {
            ControllerCoreDALGenerator controllerCoreDALGenerator;

            controllerCoreDALGenerator = new ControllerCoreDALGenerator(
                rootPath: Path.Combine(_destinyPath, DataBaseConfigFolder, "Objects"),
                destityPath: Path.Combine(_destinyPath, "SAMMAI.Core.DAL"),
                controllerPath: Path.Combine(_rootPathSAMMAICore, "Controllers"),
                servicePath: Path.Combine(_rootPathSAMMAICore, "Services", "DAL", "Implementations"),
                iServicePath: Path.Combine(_rootPathSAMMAICore, "Services", "DAL", "Interfaces"));

            controllerCoreDALGenerator.GenerateForAllEntities();
        }
    }
}
