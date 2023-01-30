/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

namespace Astrana.Core.Domain.Models
{
    public interface IDataRepository<TDataModel, TId> where TDataModel : class
    {
        void Insert(TDataModel insert);

        void Insert(IEnumerable<TDataModel> inserts);

        void Update(TDataModel update);

        void Update(IEnumerable<TDataModel> updates);

        void Delete(TId id, bool softDelete = true);

        void Delete(IEnumerable<TId> ids, bool softDelete = true);
    }
}