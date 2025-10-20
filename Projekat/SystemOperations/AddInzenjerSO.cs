using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    internal class AddInzenjerSO : SystemOperationBase
    {
        private readonly Inzenjer inzenjer;
        public AddInzenjerSO(Inzenjer i)
        {
            inzenjer = i;
        }

        public override void ExecuteOperation()
        {
            broker.Insert(inzenjer);
        }
    }
}
