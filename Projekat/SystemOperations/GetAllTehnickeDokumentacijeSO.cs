using Common.Domain;
using System.Collections.Generic;

namespace Server.SystemOperations
{
    public class GetAllTehnickeDokumentacijeSO : SystemOperationBase
    {
        public TableDataBundle Result { get; private set; } = new TableDataBundle();

        public override void ExecuteOperation()
        {
            var lista = broker.GetAll(new TehnickaDokumentacija());
            Result.TehnickeDokumentacije = lista.Cast<TehnickaDokumentacija>().ToList();
        }
    }
}
