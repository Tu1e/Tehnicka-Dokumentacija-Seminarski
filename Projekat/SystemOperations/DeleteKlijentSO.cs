using Common.Domain;

namespace Server.SystemOperations
{
    public class DeleteKlijentSO : SystemOperationBase
    {
        private readonly int idKlijent;

        public DeleteKlijentSO(int idKlijent)
        {
            this.idKlijent = idKlijent;
        }

        public override void ExecuteOperation()
        {
            broker.Delete(new Klijent(), $"IdKlijent = {idKlijent}");
        }
    }
}
