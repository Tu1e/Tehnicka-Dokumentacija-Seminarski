using Common.Domain;

namespace Server.SystemOperations
{
    public class AlterTipInzenjeraSO : SystemOperationBase
    {
        private readonly TipInzenjera tip;

        public AlterTipInzenjeraSO(TipInzenjera tip)
        {
            this.tip = tip;
        }

        public override void ExecuteOperation()
        {
            broker.Update(tip);
        }
    }
}
