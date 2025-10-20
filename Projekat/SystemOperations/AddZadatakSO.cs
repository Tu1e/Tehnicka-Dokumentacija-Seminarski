using Common.Domain;

namespace Server.SystemOperations
{
    public class AddZadatakSO : SystemOperationBase
    {
        private readonly Zadatak zadatak;

        public AddZadatakSO(Zadatak zadatak)
        {
            this.zadatak = zadatak;
        }

        public override void ExecuteOperation()
        {
            broker.Insert(zadatak);
        }
    }
}
