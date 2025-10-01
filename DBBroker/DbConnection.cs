using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;

//Zahvaljujem se kolegi Dusanu B. na pomoći :)
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
            connection?.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        } 
        public void Commit()
        {
            if(connection != null)
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
