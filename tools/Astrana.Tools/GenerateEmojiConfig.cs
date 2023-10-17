using Astrana.Core.Domain.Models.Emoji;
using Astrana.Core.Domain.Models.Openmoji;
using Astrana.Core.Extensions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Astrana.Tools
{
    public class GenerateEmojiConfig
    {
        private readonly string _configFilePath;
        private readonly string _sourceFilePath;
        private readonly string _outputDirectoryPath;

        public GenerateEmojiConfig(string configFilePath, string sourceFilePath, string outputDirectoryPath)
        {
            _configFilePath = configFilePath;
            _sourceFilePath = sourceFilePath;
            _outputDirectoryPath = outputDirectoryPath;
        }

        private readonly JsonSerializerOptions _jsonSerializerOptions = new()
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        public async Task Execute()
        {
            var configuration = await GetGeneratorConfiguration(_configFilePath);

            var definitions = await ReadSourceEmojiDataFile(_sourceFilePath);

            var allEmojis = definitions.Where(emoji => configuration.IncludeEmojis.Contains(emoji.HexCode) || configuration.IncludeEmojiGroups.Contains(emoji.GroupName)).Select(o => new Emoji
            {
                Character = o.Character,
                HexCode = o.HexCode,

                GroupName = o.GroupName,
                SubGroupNames = o.SubGroupNames.Length > 0 ? o.SubGroupNames.ToTrimmedList() : null,

                Annotation = o.Annotation,
                Tags = CombineTags(o.Tags.ToTrimmedList(), o.OpenmojiTags.ToTrimmedList()),

                SkinTone = string.IsNullOrEmpty(o.SkinTone) ? null : o.SkinTone,
                SkinToneCombination = string.IsNullOrEmpty(o.SkinToneCombination) ? null : o.SkinToneCombination,
                SkinToneBaseCharacter = string.IsNullOrEmpty(o.SkinToneBaseCharacter) || o.SkinToneBaseCharacter == o.Character ? null : o.SkinToneBaseCharacter,
                SkinToneBaseHexCode = string.IsNullOrEmpty(o.SkinToneBaseHexCode) || o.SkinToneBaseHexCode == o.HexCode ? null : o.SkinToneBaseHexCode,

                Order = o.Order
            }).ToList();


            var emojis = allEmojis.Where(o => o.HexCode == o.SkinToneBaseHexCode || o.SkinToneBaseHexCode == null).Select(emoji =>
            {
                emoji.Variants = allEmojis.Where(a => a.SkinToneBaseHexCode == emoji.HexCode && a.HexCode != emoji.HexCode).Select(variantEmoji =>
                {
                    variantEmoji.SubGroupNames = null;
                    variantEmoji.SkinToneBaseHexCode = null;
                    variantEmoji.SkinToneBaseCharacter = null;

                    return variantEmoji;
                }).ToList();

                // emoji.HexCode = null;
                emoji.SkinToneBaseHexCode = null;
                emoji.SkinToneBaseCharacter = null;

                return emoji;

            }).ToList();


            var groupNames = emojis.Where(o => !string.IsNullOrWhiteSpace(o.GroupName)).Select(o => o.GroupName).Distinct();

            var groupedEmojis = groupNames.Select(groupName => new EmojiGroup
            {
                Id = groupName,
                NameTrxCode = BuildGroupNameTrxCode(groupName),
                Emojis = emojis.Where(emoji => emoji.GroupName == groupName).Select(emoji =>
                {
                    emoji.GroupName = null;
                    emoji.Order = null;

                    if (emoji.Variants == null)
                        return emoji;

                    emoji.Variants = emoji.Variants.Select(variantEmoji =>
                    {
                        variantEmoji.GroupName = null;
                        variantEmoji.Order = null;

                        if (variantEmoji.Variants is { Count: < 1 })
                            variantEmoji.Variants = null;

                        return variantEmoji;
                    }).ToList();

                    if (emoji.Variants is { Count: < 1 })
                        emoji.Variants = null;

                    return emoji;

                }).ToList()

            }).ToList();

            var groups = groupedEmojis.Where(group => configuration.IncludeEmojiGroups.Contains(group.Id)).Select(group => new EmojiGroup
            {
                Id = group.Id,
                NameTrxCode = BuildGroupNameTrxCode(group.Id),
                IconName = "",
                Emojis = null
            }).ToList();

            await WriteJsonFile("emoji-groups.json", groups);
            await WriteJsonFile("emoji.json", groupedEmojis);
        }

        private static List<string>? CombineTags(IEnumerable<string> list1, IEnumerable<string> list2)
        {
            var list = new List<string>();

            list.AddRange(list1);
            list.AddRange(list2);

            list = list.Distinct().ToList();

            return list.Count > 0 ? list : null;
        }

        private async Task WriteJsonFile<T>(string fileName, T data)
        {
            try
            {
                await File.WriteAllTextAsync(Path.Join(_outputDirectoryPath, fileName), JsonSerializer.Serialize(data, _jsonSerializerOptions));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private string BuildGroupNameTrxCode(string groupName)
        {
            var name = "emoji_group_" + groupName.ToLower().Replace("-", "_").Replace(" ", "_");

            return name;
        }

        private static async Task<List<Openmoji>> ReadSourceEmojiDataFile(string filePath)
        {
            await using var fileStream = File.OpenRead(filePath);

            return await JsonSerializer.DeserializeAsync<List<Openmoji>>(fileStream, new JsonSerializerOptions()) ?? new List<Openmoji>();
        }

        private async Task<EmojiConfig> GetGeneratorConfiguration(string filePath)
        {
            await using var fileStream = File.OpenRead(filePath);

            return await JsonSerializer.DeserializeAsync<EmojiConfig>(fileStream, _jsonSerializerOptions) ?? new EmojiConfig();
        }

        protected class EmojiConfig
        {
            public List<string> IncludeEmojiGroups { get; set; } = new();

            public List<string> IncludeEmojis { get; set; } = new();
        }
    }
}
