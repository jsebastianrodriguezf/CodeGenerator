using CodeGenerator.Helper;
using CodeGenerator.Models;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace CodeGenerator.External
{
    public class TranstaleService
    {
        private readonly string _fromLanguage;
        private readonly string _toLanguage;
        private readonly I18NModel _localization;

        private const string _i18nPath = "C:\\Workspaces\\GIT\\CodeGenerator\\BaseScript\\I18N.json";

        public TranstaleService(
            string fromLanguage,
            string toLanguage)
        {
            _fromLanguage = fromLanguage;
            _toLanguage = toLanguage;
            _localization = Utilities.MapJsonFile<I18NModel>(_i18nPath);
        }

        public async Task<string> Translate(string text, bool local = true)
        {
            if (_fromLanguage == _toLanguage) return text;

            if (local)
                return await LocalTranslate(text);
            else
                return await GoogleTranslate(text, _fromLanguage, _toLanguage);
        }

        private async Task<string> LocalTranslate(string text)
        {
            List<string> textSplited;
            string translatedText;
            string translatedLetter;

            const string pattern = "(?=[A-Z])";
            const string plurals = "s";
            const string plurales = "e";
            const string question = "?";

            if (string.IsNullOrWhiteSpace(text)) return text;

            textSplited = Regex.Split(text, pattern).
                Where(x => !string.IsNullOrEmpty(x)).
                ToList();

            translatedText = string.Empty;

            foreach (string letter in textSplited)
            {
                try
                {
                    if (_fromLanguage == Constants.BaseConstants.Languages.Spanish)
                        translatedLetter = _localization.Dictionary.FirstOrDefault(x => x.Spanish.Equals(letter, StringComparison.CurrentCulture))?.English ??
                            throw new ArgumentNullException($"The letther '{letter}' does not exist into the dictionary.");
                    else if (_fromLanguage == Constants.BaseConstants.Languages.English)
                        translatedLetter = _localization.Dictionary.FirstOrDefault(x => x.English.Equals(letter, StringComparison.CurrentCulture))?.Spanish ??
                            throw new ArgumentNullException($"The letther '{letter}' does not exist into the dictionary.");
                    else
                        throw new ArgumentNullException($"The language '{_fromLanguage}' does not exists.");
                }
                catch
                {
                    if (letter.EndsWith(plurals))
                        translatedLetter = await LocalTranslate(letter[..(letter.Length - plurals.Length)]) + plurals;
                    else if (letter.EndsWith(plurales))
                        translatedLetter = await LocalTranslate(letter[..(letter.Length - plurales.Length)]) + plurales;
                    else if (letter.EndsWith(question))
                        translatedLetter = await LocalTranslate(letter[..(letter.Length - question.Length)]) + question;
                    else
                        throw;
                }

                translatedText += translatedLetter;
            }

            return translatedText;
        }

        private static async Task<string> GoogleTranslate(string text, string fromLanguage, string toLanguage)
        {
            HtmlDocument htmlDocument;
            HtmlNode? translatedNode;
            string response;
            string url;

            const string urlGoogleTranslate = "https://translate.google.com/m?hl={0}&sl={1}&tl={2}&q={3}";
            const string node = "//div[@class='result-container']";

            url = string.Format(urlGoogleTranslate, fromLanguage, fromLanguage, toLanguage, text);

            using HttpClient client = new();
            response = await client.GetStringAsync(url);

            htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(response);

            translatedNode = htmlDocument.DocumentNode.SelectSingleNode(node);
            return translatedNode?.InnerText?.Trim() ?? string.Empty;
        }
    }
}
