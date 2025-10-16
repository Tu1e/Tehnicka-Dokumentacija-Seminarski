using Common.Domain;

namespace Server.SystemOperations
{
    public class DeleteMestoSO : SystemOperationBase
    {
        private readonly int idMesto;
        public DeleteMestoSO(int id)
        {
            idMesto = id;
        }

        public override void ExecuteOperation()
        {
            var mesto = new Mesto();
            broker.Delete(mesto, $"IdMesto = {idMesto}");
        }
    }
}
