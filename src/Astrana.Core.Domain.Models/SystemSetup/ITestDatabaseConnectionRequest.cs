/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Enums;

namespace Astrana.Core.Domain.Models.SystemSetup
{
    public interface ITestDatabaseConnectionRequest
    {
        DatabaseProvider DatabaseProvider { get; set; }

        string DatabaseUsername { get; set; }

        string DatabasePassword { get; set; }

        string DatabaseHost { get; set; }

        int? DatabaseHostPort { get; set; }

        string DatabaseName { get; set; }
    }
}
