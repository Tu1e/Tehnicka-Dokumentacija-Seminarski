using Common.Domain;
using Server.SystemOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Server.SystemOperations
{
    public class DeleteTehnickaDokumentacijaSO : SystemOperationBase
    {
        private readonly int idTD;
        public TableDataBundle Result { get; set; } = new TableDataBundle();
        public DeleteTehnickaDokumentacijaSO(int id)
        {
            idTD = id;
        }

        public override void ExecuteOperation()
        {
            Result.OperationSucceeded = broker.Delete(new TehnickaDokumentacija(), $"IdTD = {idTD}");
        }
    }
}
