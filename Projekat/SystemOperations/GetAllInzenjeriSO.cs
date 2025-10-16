using Common.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Server.SystemOperations
{
    public class GetAllInzenjeriSO : SystemOperationBase
    {
        public List<Inzenjer> Result { get; private set; }

        public override void ExecuteOperation()
        {
            var lista = broker.GetAll(new Inzenjer());
            Result = lista.Cast<Inzenjer>().ToList();
        }
    }
}
