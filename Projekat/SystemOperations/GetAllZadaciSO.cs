using Common.Domain;
using System.Collections.Generic;

namespace Server.SystemOperations
{
    public class GetAllZadaciSO : SystemOperationBase
    {
        public TableDataBundle Result { get; private set; } = new TableDataBundle();

        public override void ExecuteOperation()
        {
            var list = broker.GetAll(new Zadatak());
            Result.Zadaci = list.Cast<Zadatak>().ToList();
        }
    }
}
