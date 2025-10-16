using Common.Domain;
using System.Collections.Generic;
using DBBroker;

namespace Server.SystemOperations
{
    public class GetAllMestaSO : SystemOperationBase
    {
        public List<Mesto> Result { get; private set; }

        public override void ExecuteOperation()
        {
            var data = broker.GetTableData(Common.TableName.Mesto);
            Result = data.Mesta;
        }
    }
}
