using Common;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Security.Principal;
using System.Transactions;


namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker()
        {
            //connection = new DbConnection();
        }

        public void Rollback()
        {
           // connection.Rollback();
        }

        public void Commit()
        {
            //connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void CloseConnection()
        {
           // connection.CloseConnection();
        }

        public void OpenConnection()
        {
           // connection.OpenConnection();
        }


    }
}
