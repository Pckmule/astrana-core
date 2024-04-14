/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Results.Enums
{
    public enum ResultOutcome
    {
        /// <summary>
        /// Indicates an unknown outcome of an operation.
        /// </summary>
        Unknown,

        /// <summary>
        /// Indicates the associated operation completed successfully.
        /// </summary>
        Success,

        /// <summary>
        /// Indicates that only part of the associated operation completed successfully.
        /// </summary>
        PartialSuccess,

        /// <summary>
        /// Indicates the associated operation did not complete successfully.
        /// </summary>
        Failure,

        /// <summary>
        /// Indicates that part of the associated operation completed with failures.
        /// </summary>
        PartialFailure,

        /// <summary>
        /// Indicates the associated operation was was stopped during execution.
        /// </summary>
        Aborted,

        /// <summary>
        /// Indicates the associated operation was was stopped before execution began.
        /// </summary>
        Cancelled
    }
}
