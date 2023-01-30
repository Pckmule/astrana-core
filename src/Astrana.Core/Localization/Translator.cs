/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Exceptions;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Astrana.Core.Localization
{
    public class Translator: ITranslator
    {
        private Dictionary<string, string> _translations = new();

        public Translator(string cultureCode = Constants.Internationalization.DefaultCultureCode)
        {
            LoadTranslations(cultureCode.ToLower());
        }

        private void LoadTranslations(string languageCode = Constants.Internationalization.DefaultCultureCode)
        {
            _translations = new Dictionary<string, string>();

            var translationFileName = GetTranslationFileName(languageCode);

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(translationFileName))
            {
                if (stream == null)
                    throw new TranslationsFileNotFoundException(translationFileName);

                using (var reader = new StreamReader(stream))
                {
                    _translations = DeserializeTranslationsFileContent(reader);
                }
            }
        }

        private static string GetTranslationFileName(string languageCode)
        {
            var codeParts = languageCode.Split("-");

            const string translationFileNameTemplate = "Astrana.Core.Localization.Translations.{0}.json";
            var translationFileName = string.Format(translationFileNameTemplate, languageCode);

            if (Assembly.GetExecutingAssembly().GetManifestResourceNames().All(r => r != translationFileName))
                translationFileName = string.Format(translationFileNameTemplate, codeParts[0]);

            return translationFileName;
        }

        private static Dictionary<string, string> DeserializeTranslationsFileContent(TextReader reader)
        {
            return JsonSerializer.Deserialize<Dictionary<string, string>>(reader.ReadToEnd(), new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull

            }) ?? new Dictionary<string, string>();
        }

        public Dictionary<string, string> GetAllTranslations()
        {
            return _translations;
        }

        public List<string> GetTranslations(List<string> translationKeys)
        {
            var translations = new List<string>();

            foreach (var translationKey in translationKeys)
            {
                if (string.IsNullOrEmpty(translationKey))
                    continue;

                translations.Add(_translations.ContainsKey(translationKey) ? _translations[translationKey] : translationKey);
            }

            return translations;
        }

        public string GetTranslation(string translationKey)
        {
            if (string.IsNullOrEmpty(translationKey))
                throw new ArgumentNullException(nameof(translationKey));

            return GetTranslations(new List<string> { translationKey }).FirstOrDefault() ?? "";
        }

        public List<string> Trx(List<string> translationKeys)
        {
            return GetTranslations(translationKeys);
        }

        public string Trx(string translationKey)
        {
            return GetTranslation(translationKey);
        }
    }
}
