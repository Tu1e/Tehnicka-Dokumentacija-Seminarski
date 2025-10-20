using Common.Domain;

namespace Server.SystemOperations
{
    public class AlterMestoSO : SystemOperationBase
    {
        private readonly Mesto mesto;

        public AlterMestoSO(Mesto mesto)
        {
            this.mesto = mesto;
        }

        public override void ExecuteOperation()
        {
            broker.Update(mesto);
        }
    }
}
