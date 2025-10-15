using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System;

namespace DBBroker
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        public DbConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TehDocDB_Dev"].ConnectionString);
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
