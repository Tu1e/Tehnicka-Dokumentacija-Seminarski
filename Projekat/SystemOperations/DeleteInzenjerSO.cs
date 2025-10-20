using Common.Domain;

namespace Server.SystemOperations
{
    public class DeleteInzenjerSO : SystemOperationBase
    {
        private readonly int idInzenjer;

        public DeleteInzenjerSO(int idInzenjer)
        {
            this.idInzenjer = idInzenjer;
        }

        public override void ExecuteOperation()
        {
            broker.Delete(new Inzenjer(), $"IdInzenjer = {idInzenjer}");
        }
    }
}
