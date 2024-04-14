/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using HtmlAgilityPack;

// ReSharper disable once CheckNamespace
namespace Astrana.Core.Domain.ExternalDomain.HtmlAgilityPack.Extensions
{
    public static class HtmlNodeExtensions
    {
        public static string? GetAttributeValue(HtmlNode htmlNode, string xPathStatement, string attributeName, string defaultValue = "", bool trim = true)
        {
            var value = htmlNode.SelectSingleNode(xPathStatement)?.GetAttributeValue(attributeName, defaultValue);

            return trim ? value?.Trim() : value;
        }
    }
}