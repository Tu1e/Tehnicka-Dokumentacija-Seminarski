using Common.Domain;
using System.Collections;
using System.Collections.Generic;

namespace Server.SystemOperations
{
    public class GetAllTipoviInzenjeraSO : SystemOperationBase
    {
        public TableDataBundle Result { get; private set; } = new TableDataBundle();

        public override void ExecuteOperation()
        {
            var list = broker.GetAll(new TipInzenjera());
            Result.TipoviI = list.Cast<TipInzenjera>().ToList();
        }
    }
}
