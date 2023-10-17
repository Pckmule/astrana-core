/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.System.Enums;

namespace Astrana.Core.Domain.Models.SystemSettings.Contracts
{
    public interface ISystemSetting
    {
        Guid SystemSettingId { get; set; }

        string Name { get; set; }

        string NameTrxCode { get; set; }

        SystemDataType DataType { get; set; }

        string DefaultValue { get; set; }

        string? Value { get; set; }

        string? ShortDescription { get; set; }

        string? ShortDescriptionTrxCode { get; set; }

        string? HelpText { get; set; }

        bool UserMaySet { get; set; }
    }
}