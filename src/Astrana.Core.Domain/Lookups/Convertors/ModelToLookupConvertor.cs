/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Lookups;
using Astrana.Core.Domain.Models.Lookups.Attributes;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text.RegularExpressions;

namespace Astrana.Core.Domain.Lookups.Convertors
{
    public static class ModelToLookupOptionConvertor
    {
        public static LookupDto ConvertToLookup(string lookupLabel, string lookupTrxCode, string lookupIconName, string lookupIconAddress, IEnumerable<object> models, string labelTemplate = null)
        {
            var lookup = new LookupDto(lookupLabel, lookupTrxCode, lookupIconName, lookupIconAddress);

            foreach (var model in models)
            {
                var option = ConvertToLookupOption(model, labelTemplate);
                
                if (option == null)
                    continue;

                lookup.Options.Add(option);
            }

            return lookup;
        }

        public static LookupOption? ConvertToLookupOption(object? model, string labelTemplate = null)
        {
            if (model == null)
                return null;
            
            var type = model.GetType();

            string value = null;
            var valueProperty = type.GetProperties().FirstOrDefault(prop => prop.GetCustomAttributes(false).OfType<LookupOptionValueAttribute>().Any());
            if (valueProperty != null)
            {
                value = valueProperty.GetValue(model)?.ToString();
            }

            var label = value;
            var labelProperty = type.GetProperties().FirstOrDefault(prop => prop.GetCustomAttributes(false).OfType<LookupOptionLabelAttribute>().Any());
            if (labelProperty != null)
            {
                label = labelProperty.GetValue(model)?.ToString();

                if (!string.IsNullOrEmpty(labelTemplate))
                {
                    label = labelTemplate.Replace("{{label}}", label);

                    const string tokenPattern = @"{{(.*?)}}";
                    var placeholders = Regex.Matches(label, tokenPattern).ToDictionary( match => match.Groups[1].Value, _ => "" );

                    foreach (var modelProperty in type.GetProperties().Where(p => placeholders.ContainsKey(p.Name)))
                    {
                        placeholders[modelProperty.Name] = modelProperty.GetValue(model)?.ToString() ?? "";
                    }

                    foreach (var placeholder in placeholders)
                    {
                        label = label.Replace("{{" + placeholder.Key + "}}", placeholder.Value);
                    }
                }
            }

            string trxCode = null;
            var trxCodeProperty = type.GetProperties().FirstOrDefault(prop => prop.GetCustomAttributes(false).OfType<LookupOptionTranslationCodeAttribute>().Any());
            if (trxCodeProperty != null)
            {
                trxCode = trxCodeProperty.GetValue(model)?.ToString();
            }

            string iconAddress = null;
            var iconAddressProperty = type.GetProperties().FirstOrDefault(prop => prop.GetCustomAttributes(false).OfType<LookupOptionIconAddressAttribute>().Any());
            if (iconAddressProperty != null)
            {
                iconAddress = iconAddressProperty.GetValue(model)?.ToString();
            }

            string iconName = null;
            var iconNameProperty = type.GetProperties().FirstOrDefault(prop => prop.GetCustomAttributes(false).OfType<LookupOptionIconNameAttribute>().Any());
            if (iconNameProperty != null)
            {
                iconName = iconNameProperty.GetValue(model)?.ToString();
            }

            if (value == null)
                return null;

            return new LookupOption(value, label, trxCode, iconName, iconAddress);
        }
    }
}
