using Common.Domain;

namespace Server.SystemOperations
{
    public class DeleteTipInzenjeraSO : SystemOperationBase
    {
        private readonly int idStrucnaSprema;

        public DeleteTipInzenjeraSO(int idStrucnaSprema)
        {
            this.idStrucnaSprema = idStrucnaSprema;
        }

        public override void ExecuteOperation()
        {
            broker.Delete(new TipInzenjera(), $"IdStrucnaSprema = {idStrucnaSprema}");
        }
    }
}
