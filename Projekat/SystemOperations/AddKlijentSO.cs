using Common.Domain;

namespace Server.SystemOperations
{
    public class AddKlijentSO : SystemOperationBase
    {
        private readonly Klijent klijent;
        public AddKlijentSO(Klijent k)
        {
            klijent = k;
        }

        public override void ExecuteOperation()
        {
            broker.Insert(klijent);
        }
    }
}
