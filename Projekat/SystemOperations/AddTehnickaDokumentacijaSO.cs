using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class AddTehnickaDokumentacijaSO : SystemOperationBase
    {
        private readonly TehnickaDokumentacija tD;
        public AddTehnickaDokumentacijaSO(TehnickaDokumentacija tD)
        {
            this.tD = tD;
        }

        public override void ExecuteOperation()
        {
            broker.Insert(tD);
        }
    }
}
