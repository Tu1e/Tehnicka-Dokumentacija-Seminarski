using Common.Domain;

namespace Server.SystemOperations
{
    public class AddStavkaTDSO : SystemOperationBase
    {
        private readonly StavkaTehnickaDokumentacija stavka;
        public TableDataBundle Result { get; set; } = new TableDataBundle();

        public AddStavkaTDSO(StavkaTehnickaDokumentacija stavka)
        {
            this.stavka = stavka;
        }

        public override void ExecuteOperation()
        {
            Result.OperationSucceeded = broker.Insert(stavka);
        }
    }
}
