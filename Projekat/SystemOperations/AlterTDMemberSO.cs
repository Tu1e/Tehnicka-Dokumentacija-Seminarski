using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class AlterTDMemberSO : SystemOperationBase
    {
        private readonly TehnickaDokumentacija tehnickaDokumentacija;
        public AlterTDMemberSO(TehnickaDokumentacija tD)
        {
            tehnickaDokumentacija = tD;
        }

        public override void ExecuteOperation()
        {
            broker.Update(tehnickaDokumentacija);
        }
    }
}
