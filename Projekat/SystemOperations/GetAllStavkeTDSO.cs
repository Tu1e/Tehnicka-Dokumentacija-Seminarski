using Common.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Server.SystemOperations
{
    public class GetAllStavkeTDSO : SystemOperationBase
    {
        public TableDataBundle Result { get; private set; }

        public override void ExecuteOperation()
        {
            var lista = broker.GetAll(new StavkaTehnickaDokumentacija());
            Result = new TableDataBundle
            {
                STehnickeDokumentacije = lista.Cast<StavkaTehnickaDokumentacija>().ToList()
            };
        }
    }
}
