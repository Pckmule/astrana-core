/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Astrana.Core.Data.Utilities
{
    public class DatabaseChecker: IDatabaseChecker
    {
        private readonly ApplicationDbContext _context;

        public DatabaseChecker(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Exists()
        {
            return ((RelationalDatabaseCreator)_context.Database.GetService<IDatabaseCreator>()).Exists();
        }

        public bool HasRunMigrations()
        {
            return true;
        }
    }
}
