using Common.Domain;
using System.Collections.Generic;

namespace Server.SystemOperations
{
    public class GetAllZadaciSO : SystemOperationBase
    {
        public List<Zadatak> Result { get; private set; }

        public override void ExecuteOperation()
        {
            var data = broker.GetTableData(Common.TableName.Zadatak);
            Result = data.Zadaci;
        }
    }
}
