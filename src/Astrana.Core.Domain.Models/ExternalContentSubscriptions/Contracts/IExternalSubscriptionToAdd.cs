/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images;

namespace Astrana.Core.Domain.Models.ExternalContentSubscriptions.Contracts
{
    public interface IExternalSubscriptionToAdd
    {
        Uri Url { get; set; }
        
        string? Title { get; set; }

        string? Description { get; set; }

        string? Locale { get; set; }

        string? CharSet { get; set; }

        string? AccessToken { get; set; }

        ImageToAdd? PreviewImage { get; set; }

        Guid? PreviewImageId { get; set; }
    }
}
