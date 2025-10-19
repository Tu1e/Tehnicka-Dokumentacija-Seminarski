using Common.Domain;
using System.Collections.Generic;

namespace Server.SystemOperations
{
    public class GetAllKlijentiSO : SystemOperationBase
    {
        public TableDataBundle Result { get; private set; } = new TableDataBundle();

        public override void ExecuteOperation()
        {
            var lista = broker.GetAll(new Klijent());
            Result.Klijenti = lista.Cast<Klijent>().ToList();
        }
    }
}
