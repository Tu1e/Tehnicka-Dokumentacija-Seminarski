using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;

namespace DBBroker
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        private string dbName = "TehDocDB_Dev";
        public DbConnection()
        {
            connection = new SqlConnection($@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog={dbName};Integrated Security=True;");
        }

        public void OpenConnection()
        {
            connection?.Open();
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection?.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }
        public void Commit()
        {
            transaction?.Commit();
        }
        public void Rollback()
        {
            transaction?.Rollback();
        }
        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", connection, transaction);
        }
    }
}
