using Common.Domain;
using System.Collections.Generic;

namespace Server.SystemOperations
{
    public class GetAllTehnickeDokumentacijeSO : SystemOperationBase
    {
        public List<TehnickaDokumentacija> Result { get; private set; }

        public override void ExecuteOperation()
        {
            var data = broker.GetTableData(Common.TableName.TehnickaDokumentacija);
            Result = data.TehnickeDokumentacije;
        }
    }
}
