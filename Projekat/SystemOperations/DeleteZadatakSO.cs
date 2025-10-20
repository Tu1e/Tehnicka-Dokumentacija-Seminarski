using Common.Domain;

namespace Server.SystemOperations
{
    public class DeleteZadatakSO : SystemOperationBase
    {
        private readonly int idZadatak;

        public DeleteZadatakSO(int idZadatak)
        {
            this.idZadatak = idZadatak;
        }

        public override void ExecuteOperation()
        {
            broker.Delete(new Zadatak(), $"IdZadatak = {idZadatak}");
        }
    }
}
