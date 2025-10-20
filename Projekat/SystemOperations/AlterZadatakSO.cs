using Common.Domain;

namespace Server.SystemOperations
{
    public class AlterZadatakSO : SystemOperationBase
    {
        private readonly Zadatak zadatak;

        public AlterZadatakSO(Zadatak zadatak)
        {
            this.zadatak = zadatak;
        }

        public override void ExecuteOperation()
        {
            broker.Update(zadatak);
        }
    }
}
