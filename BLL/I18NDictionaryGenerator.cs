using CodeGenerator.External;
using CodeGenerator.Helper;
using CodeGenerator.Models;
using System.Text.Json;
using System.Text.RegularExpressions;
using static CodeGenerator.Constants.BaseConstants;

namespace CodeGenerator.BLL
{
    public class I18NDictionaryGenerator
    {
        private readonly string _contextName;
        private readonly string _rootPath;
        private readonly string _destinyPath;
        private readonly List<string> _files;
        private readonly List<FileModel> _filesModel;
        private readonly TranstaleService _transtaleService;
        private readonly I18NModel _localization;
        private readonly string _i18nPath;

        public I18NDictionaryGenerator(
            string contextName,
            string rootPath,
            string destinyPath)
        {
            _contextName = contextName;
            _rootPath = rootPath;
            _destinyPath = destinyPath;
            _files = [.. Directory.GetFiles(_rootPath)];
            _filesModel = Utilities.GetFilesModel(_files);
            _transtaleService = new TranstaleService(Languages.Spanish, Languages.English);
            _i18nPath = Path.Combine(Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName ?? "", "BaseScript\\I18N.json");
            _localization = Utilities.MapJsonFile<I18NModel>(_i18nPath);
        }

        public void FullFillDictionary()
        {
            List<string> template;

            foreach (FileModel fileModel in _filesModel.Where(x => x.Name != _contextName))
            {
                template = [.. File.ReadAllLines(fileModel.Path)];

                foreach (string line in template)
                {
                    TranslateClassName(line);
                    TranslateBasicProperties(line);
                }
            }

            UpdateDictionaryJsonFile();
        }

        private void TranslateClassName(string line)
        {
            int startIndex;
            int endIndex;
            string className;

            const string startLine = "public partial class ";

            if (line.StartsWith(startLine))
            {
                startIndex = startLine.Length;
                endIndex = line.Length;

                className = line[startIndex..endIndex];
                AddLocalizacion(className);
            }
        }

        private void TranslateBasicProperties(string line)
        {
            string property;

            const string startLine = "    public ";
            const string virtualProperty = "virtual";

            if (line.StartsWith(startLine) && !line.Contains(virtualProperty))
            {
                property = line.Split(" ")[6];

                AddLocalizacion(property);
            }
        }

        private void AddLocalizacion(string text)
        {
            bool exists;
            string letterTranslated;
            List<string> textSplited;

            const string pattern = "(?=[A-Z])";

            if (string.IsNullOrWhiteSpace(text)) return;

            textSplited = Regex.Split(text, pattern).
                Where(x => !string.IsNullOrEmpty(x)).
                ToList();

            foreach (string letter in textSplited)
            {
                exists = _localization.Dictionary.Any(x => x.Spanish.Equals(letter, StringComparison.CurrentCulture));

                if (!exists)
                {
                    letterTranslated = _transtaleService.Translate(letter, false).Result;
                    _localization.Dictionary.Add(new Resource()
                    {
                        Spanish = letter,
                        English = letterTranslated
                    });
                }
            }
        }

        private void UpdateDictionaryJsonFile()
        {
            string jsonString;

            jsonString = JsonSerializer.Serialize(_localization, new JsonSerializerOptions { WriteIndented = true });

            if (File.Exists(_i18nPath))
                File.Delete(_i18nPath);

            File.WriteAllText(_i18nPath, jsonString);
            GenerateDictiorary();
        }

        private void GenerateDictiorary()
        {
            List<string> content = [];

            content.AddRange([
                "namespace SAMMAI.Transverse.Dictionaries",
                "{",
                "    public class DataBaseDictionary",
                "    {",
                "        /// <summary>",
                "        /// This dictionary allows to know how the tables and columns are translated",
                "        /// Dictionary<spanish, english>",
                "        /// </summary>",
                "        public static readonly Dictionary<string, string> Dictionary = new(StringComparer.OrdinalIgnoreCase)",
                "        {",
            ]);

            foreach (Resource resource in _localization.Dictionary.OrderBy(x => x.Spanish))
            {
                content.AddRange([
                    $"            {{ \"{resource.Spanish}\", \"{resource.English}\" }},"
                ]);
            }

            content.AddRange([
                "        };",
                "    }",
                "}",
            ]);

            GenerateFile("Dictionaries", "DataBaseDictionary.cs", content);
        }

        private void GenerateFile(string directory, string file, List<string> content)
            => Utilities.GenerateFile(_destinyPath, directory, file, content);
    }
}
