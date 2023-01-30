/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Constants
{
    public static class AnonymousUser
    {
        public const string Id = "00000000-0000-0000-0000-000000000000"; // TODO: This is a temporary value.
        public static readonly Guid IdGuid = Guid.Parse(Id);
    }
}
