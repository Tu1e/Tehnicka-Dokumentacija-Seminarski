using Common.Domain;

namespace Server.SystemOperations
{
    public class AddMestoSO : SystemOperationBase
    {
        private readonly Mesto mesto;

        public AddMestoSO(Mesto mesto)
        {
            this.mesto = mesto;
        }

        public override void ExecuteOperation()
        {
            broker.Insert(mesto);
        }
    }
}
