using Common.Domain;

namespace Server.SystemOperations
{
    public class DeleteStavkaTDSO : SystemOperationBase
    {
        private readonly int idTD;
        private readonly int rb;
        public TableDataBundle Result { get; set; } = new TableDataBundle();
        public DeleteStavkaTDSO(int idTD, int rb)
        {
            this.idTD = idTD;
            this.rb = rb;
        }

        public override void ExecuteOperation()
        {
            Result.OperationSucceeded = broker.Delete(new StavkaTehnickaDokumentacija(), $"IdTD = {idTD} AND Rb = {rb}");
        }
    }
}
