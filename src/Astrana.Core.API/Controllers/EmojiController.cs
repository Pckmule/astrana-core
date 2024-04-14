/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Managers.SignIn;
using Astrana.Core.Domain.Models.Emoji;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Astrana.Core.API.Controllers
{
    [ApiController]
    public class EmojiController : BaseController<EmojiController>
    {
        private readonly ILogger<EmojiController> _logger;

        public EmojiController(ILogger<EmojiController> logger, ISignInManager signInManager) : base(logger, signInManager)
        {
            _logger = logger;
        }

        /// <summary>
        /// Returns a paged set of audiences according to the options provided.
        /// </summary>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="createdById"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        /// <response code="200">Audience(s) successfully retrieved.</response>
        /// <response code="400">Validation requirements are not met. Request has missing or invalid values.</response>
        /// <response code="500">Something went wrong.</response>
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var actioningUserId = GetActioningUserId();

            var emojis = await GetEmojis();

            return UnpagedGetResponse(emojis);
        }

        private static async Task<List<EmojiGroupDto>> GetEmojis()
        {
            var groupDefinitions = await ReadEmojiGroupConfigurationFile("D:\\repos\\Astrana\\Pckmule\\astrana-core\\src\\Astrana.Core\\Emoji\\emoji-groups.json");

            var definitions = await ReadEmojiConfigurationFile("D:\\repos\\Astrana\\Pckmule\\astrana-core\\src\\Astrana.Core\\Emoji\\emoji.json");

            foreach (var definition in definitions)
            {
                var group = groupDefinitions.FirstOrDefault(o => o.Id == definition.Id);

                if(group == null) 
                    continue;

                definition.NameTrxCode = group.NameTrxCode;
                definition.IconName = group.IconName;
            }

            return definitions;
        }

        private static async Task<List<EmojiGroupDto>> ReadEmojiConfigurationFile(string filePath)
        {
            await using var fileStream = System.IO.File.OpenRead(filePath);

            return await JsonSerializer.DeserializeAsync<List<EmojiGroupDto>>(fileStream, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            }) ?? new List<EmojiGroupDto>();
        }

        private static async Task<List<EmojiGroupDto>> ReadEmojiGroupConfigurationFile(string filePath)
        {
            await using var fileStream = System.IO.File.OpenRead(filePath);

            return await JsonSerializer.DeserializeAsync<List<EmojiGroupDto>>(fileStream, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            }) ?? new List<EmojiGroupDto>();
        }
    }
}