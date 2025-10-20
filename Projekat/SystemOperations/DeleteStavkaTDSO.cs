using Common.Domain;

namespace Server.SystemOperations
{
    public class DeleteStavkaTDSO : SystemOperationBase
    {
        private readonly int idTD;
        private readonly int rb;

        public DeleteStavkaTDSO(int idTD, int rb)
        {
            this.idTD = idTD;
            this.rb = rb;
        }

        public override void ExecuteOperation()
        {
            broker.Delete(new StavkaTehnickaDokumentacija(), $"IdTD = {idTD} AND Rb = {rb}");
        }
    }
}
