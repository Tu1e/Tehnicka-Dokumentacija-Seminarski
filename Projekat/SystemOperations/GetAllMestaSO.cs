using Common.Domain;
using System.Collections.Generic;
using DBBroker;

namespace Server.SystemOperations
{
    public class GetAllMestaSO : SystemOperationBase
    {
        public TableDataBundle Result { get; private set; } = new TableDataBundle();

        public override void ExecuteOperation()
        {
            var lista = broker.GetAll(new Mesto());
            Result.Mesta = lista.Cast<Mesto>().ToList();
        }
    }
}
