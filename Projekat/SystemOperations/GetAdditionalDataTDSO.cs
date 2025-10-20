using Common.Domain;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Server.SystemOperations
{
    public class GetAdditionalDataTDSO : SystemOperationBase
    {
        private readonly int idTD;

        public TableDataBundle Result { get; private set; }

        public GetAdditionalDataTDSO(int idTD)
        {
            this.idTD = idTD;
        }

        public override void ExecuteOperation()
        {
            Debug.WriteLine($">>> [SO] Učitavam stavke za IdTD = {idTD}");
            var lista = broker.GetByCondition(new StavkaTehnickaDokumentacija(), $"IdTD = {idTD}");
            Debug.WriteLine($">>> [SO] SQL vraća {lista.Count} redova");

            Result = new TableDataBundle();
            Result.STehnickeDokumentacije = lista.Cast<StavkaTehnickaDokumentacija>().ToList();
        }

    }
}
