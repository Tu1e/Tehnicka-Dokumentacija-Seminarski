using Common.Domain;

namespace Server.SystemOperations
{
    public class AddTipInzenjeraSO : SystemOperationBase
    {
        private readonly TipInzenjera tip;

        public AddTipInzenjeraSO(TipInzenjera tip)
        {
            this.tip = tip;
        }

        public override void ExecuteOperation()
        {
            broker.Insert(tip);
        }
    }
}
