using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBBroker;

namespace Server.SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected Broker broker;

        public SystemOperationBase()
        {
            broker = new Broker();
        }

        public void ExecuteTemplate()
        {
            try
            {
                broker.OpenConnection();
                broker.BeginTransaction();

                ExecuteOperation();

                broker.Commit();

            }
            catch (Exception ex)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public abstract void ExecuteOperation();
    }
}
