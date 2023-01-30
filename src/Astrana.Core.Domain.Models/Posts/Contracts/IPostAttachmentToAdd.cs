﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models.Posts.Contracts
{
    public interface IPostAttachmentToAdd
    {
        string Address { get; set; }

        string? Title { get; set; }

        string? Caption { get; set; }
    }
}
