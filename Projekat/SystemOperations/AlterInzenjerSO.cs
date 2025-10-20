using Common.Domain;

namespace Server.SystemOperations
{
    public class AlterInzenjerSO : SystemOperationBase
    {
        private readonly Inzenjer inzenjer;

        public AlterInzenjerSO(Inzenjer inzenjer)
        {
            this.inzenjer = inzenjer;
        }

        public override void ExecuteOperation()
        {
            broker.Update(inzenjer);
        }
    }
}
