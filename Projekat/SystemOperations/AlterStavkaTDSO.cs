using Common.Domain;

namespace Server.SystemOperations
{
    public class AlterStavkaTDSO : SystemOperationBase
    {
        private readonly StavkaTehnickaDokumentacija stavka;

        public AlterStavkaTDSO(StavkaTehnickaDokumentacija stavka)
        {
            this.stavka = stavka;
        }

        public override void ExecuteOperation()
        {
            broker.Update(stavka);
        }
    }
}
