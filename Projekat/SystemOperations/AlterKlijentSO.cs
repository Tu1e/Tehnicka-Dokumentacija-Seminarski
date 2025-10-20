using Common.Domain;

namespace Server.SystemOperations
{
    public class AlterKlijentSO : SystemOperationBase
    {
        private readonly Klijent klijent;

        public AlterKlijentSO(Klijent klijent)
        {
            this.klijent = klijent;
        }

        public override void ExecuteOperation()
        {
            broker.Update(klijent);
        }
    }
}
