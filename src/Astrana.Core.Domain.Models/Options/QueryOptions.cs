/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Options.Contracts;
using Astrana.Core.Domain.Models.Options.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Utilities;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Options
{
    public class QueryOptions<TRecordId, TOwnerUserId> : IQueryOptions<TRecordId, TOwnerUserId>
        where TRecordId : struct
        where TOwnerUserId : struct
    {
        [JsonIgnore]
        protected const string QueryStringSeparator = "&";

        [JsonIgnore]
        protected const string StringSeparator = "; ";

        [JsonConstructor]
        public QueryOptions()
        {
            Ids = new List<TRecordId>();
            ExcludeIds = new List<TRecordId>();
            OwnerUserIds = new List<TOwnerUserId>();
        }

        public QueryOptions(List<TRecordId> ids): this()
        {
            Ids = ids;
        }

        public void SetIds(List<TRecordId>? ids)
        {
            if (ids == null)
                return;

            Ids.AddRange(ids);
        }

        public void SetExcludeIds(List<TRecordId>? excludeIds)
        {
            if (excludeIds == null)
                return;

            ExcludeIds.AddRange(excludeIds);
        }

        public void SetOwnerUserIds(List<TOwnerUserId>? ownerUserIds)
        {
            if (ownerUserIds == null)
                return;

            OwnerUserIds.AddRange(ownerUserIds);
        }

        public QueryOptionsMatchMode IdsMatchMode { get; set; }

        public List<TRecordId> Ids { get; }

        public List<TRecordId> ExcludeIds { get; }

        public List<TOwnerUserId> OwnerUserIds { get; }

        public DateTimeOffset? CreatedBefore { get; set; }

        public DateTimeOffset? CreatedAfter { get; set; }

        public bool PagingDisabled { get; set; }

        public int? PageSize { get; set; }

        public int? CurrentPage { get; set; }

        public string? SortBy { get; set; } = null;

        public OrderByDirection OrderByDirection { get; set; }

        public string? OrderBy { get; set; }

        public bool IncludeDeactivated { get; set; }

        public virtual List<string> ToQueryStringList()
        {
            var propertyValues = new List<string>
            {
                $"{nameof(IdsMatchMode).ToCamelCase()}={IdsMatchMode}",
                $"{nameof(CreatedBefore).ToCamelCase()}={CreatedBefore}",
                $"{nameof(CreatedAfter).ToCamelCase()}={CreatedAfter}",
                $"{nameof(PagingDisabled).ToCamelCase()}={PagingDisabled}",
                $"{nameof(PageSize).ToCamelCase()}={PageSize}",
                $"{nameof(CurrentPage).ToCamelCase()}={CurrentPage}",
                $"{nameof(SortBy).ToCamelCase()}={SortBy}",
                $"{nameof(OrderByDirection).ToCamelCase()}={OrderByDirection}",
                $"{nameof(IncludeDeactivated).ToCamelCase()}={IncludeDeactivated}"
            };

            propertyValues.AddRange(Ids.Select(id => $"{nameof(Ids).ToCamelCase()}={id}"));
            propertyValues.AddRange(ExcludeIds.Select(uid => $"{nameof(ExcludeIds).ToCamelCase()}={uid}"));
            propertyValues.AddRange(OwnerUserIds.Select(uid => $"{nameof(OwnerUserIds).ToCamelCase()}={uid}"));

            return propertyValues;
        }

        public virtual string ToQueryString()
        {
            return string.Join(QueryStringSeparator, ToQueryStringList());
        }

        public new virtual string ToString()
        {
            var propertyValues = new List<string>
            {
                $"{nameof(IdsMatchMode).ToCamelCase()}={IdsMatchMode}",
                $"{nameof(CreatedBefore).ToCamelCase()}={CreatedBefore}",
                $"{nameof(CreatedAfter).ToCamelCase()}={CreatedAfter}",
                $"{nameof(PagingDisabled).ToCamelCase()}={PagingDisabled}",
                $"{nameof(PageSize).ToCamelCase()}={PageSize}",
                $"{nameof(CurrentPage).ToCamelCase()}={CurrentPage}",
                $"{nameof(SortBy).ToCamelCase()}={SortBy}",
                $"{nameof(OrderByDirection).ToCamelCase()}={OrderByDirection}",
                $"{nameof(IncludeDeactivated).ToCamelCase()}={IncludeDeactivated}",
                $"{nameof(Ids).ToCamelCase()}={string.Join(',', Ids == null ? "" : Ids.Select(id => id.ToString()))}",
                $"{nameof(ExcludeIds).ToCamelCase()}={string.Join(',', ExcludeIds == null ? "" : ExcludeIds.Select(excludeId => excludeId.ToString()))}",
                $"{nameof(OwnerUserIds).ToCamelCase()}={string.Join(',', OwnerUserIds == null ? "" : OwnerUserIds.Select(uid => uid.ToString()))}"
            };

            return string.Join(StringSeparator, propertyValues);
        }
    }
}
