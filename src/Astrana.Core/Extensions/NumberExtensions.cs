/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Extensions
{
    public static class NumberExtensions
    {
        public static bool IsValidForUpdateOrDelete(this short number)
        {
            return number > 0;
        }

        public static bool IsValidForUpdateOrDelete(this int number)
        {
            return number > 0;
        }

        public static bool IsValidForUpdateOrDelete(this long number)
        {
            return number > 0;
        }
    }
}