using Common.Domain;

namespace Server.SystemOperations
{
    public class AddZadatakSO : SystemOperationBase
    {
        private readonly Zadatak zadatak;
        public TableDataBundle Result { get; set; }
        public AddZadatakSO(Zadatak zadatak)
        {
            this.zadatak = zadatak;
        }

        public override void ExecuteOperation()
        {
            Result.OperationSucceeded = broker.Insert(zadatak);
        }
    }
}
