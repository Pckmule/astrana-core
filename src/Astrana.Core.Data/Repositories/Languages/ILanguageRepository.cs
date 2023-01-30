/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Languages;
using Astrana.Core.Domain.Models.Languages.Contracts;
using Astrana.Core.Domain.Models.Languages.Options;
using Astrana.Core.Domain.Models.Results.Contracts;

namespace Astrana.Core.Data.Repositories.Languages
{
    public interface ILanguageRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetLanguagesCountAsync(LanguageQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<Language>> GetLanguagesAsync(LanguageQueryOptions<Guid, TUserId> queryOptions = null);

        Task<Language?> GetLanguageByIdAsync(Guid id);

        Task<Language?> GetLanguageByCodeAsync(string code);

        Task<IAddResult<List<Language>>> CreateAsync(IEnumerable<ILanguageToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<Language>>> UpdateAsync(IEnumerable<Language> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);

        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedLanguagesToRemoveIds, Guid actioningUserId);
    }
}
