using Common.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Server.SystemOperations
{
    public class GetAllInzenjeriSO : SystemOperationBase
    {
        public TableDataBundle Result { get; private set; } = new TableDataBundle();

        public override void ExecuteOperation()
        {
            var lista = broker.GetAll(new Inzenjer());
            Result.Inzenjeri = lista.Cast<Inzenjer>().ToList();
        }
    }
}
