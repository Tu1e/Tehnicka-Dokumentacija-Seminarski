using Common.Domain;

namespace Server.SystemOperations
{
    public class AddStavkaTDSO : SystemOperationBase
    {
        private readonly StavkaTehnickaDokumentacija stavka;

        public AddStavkaTDSO(StavkaTehnickaDokumentacija stavka)
        {
            this.stavka = stavka;
        }

        public override void ExecuteOperation()
        {
            broker.Insert(stavka);
        }
    }
}
