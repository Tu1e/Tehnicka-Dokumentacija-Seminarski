using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public class LoginSO : SystemOperationBase
    {
        private readonly Inzenjer inzenjer;

        public LoginSO(Inzenjer i)
        {
            inzenjer = i;
        }

        public override void ExecuteOperation()
        {
            throw new NotImplementedException();
        }
    }
}
