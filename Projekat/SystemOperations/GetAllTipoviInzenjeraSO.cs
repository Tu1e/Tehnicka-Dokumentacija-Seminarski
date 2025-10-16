using Common.Domain;
using System.Collections.Generic;

namespace Server.SystemOperations
{
    public class GetAllTipoviInzenjeraSO : SystemOperationBase
    {
        public List<TipInzenjera> Result { get; private set; }

        public override void ExecuteOperation()
        {
            var data = broker.GetTableData(Common.TableName.TipInzenjera);
            Result = data.TipoviI;
        }
    }
}
