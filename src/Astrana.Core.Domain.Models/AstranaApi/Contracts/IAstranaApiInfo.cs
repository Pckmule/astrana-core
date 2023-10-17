﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.System.Enums;

namespace Astrana.Core.Domain.Models.AstranaApi.Contracts
{
    public interface IAstranaApiInfo
    {
        List<Type> Controllers { get; set; }

        string AppBaseUrl { get; }
       
        string GetProxyEndpoint(AstranaContentType astranaContentType, string contentIdentifier);
    }
}
