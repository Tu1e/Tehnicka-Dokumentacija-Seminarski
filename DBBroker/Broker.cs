using Common;
using Common.Domain;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
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
            connection = new DbConnection();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void CloseConnection()
        {
           connection.CloseConnection();
        }

        public void OpenConnection()
        {
           connection.OpenConnection();
        }

        public Inzenjer? GetInzenjerByKorisnickoIme(string username, string password)
        {
            using var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT IdInzenjer, Ime, Prezime, KorisnickoIme, Sifra, Licenca
                FROM Inzenjer
                WHERE KorisnickoIme = @u;";

            cmd.Parameters.Add("@u", SqlDbType.NVarChar, 30).Value = username;

            using var rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (!rdr.Read()) return null;

            if(rdr.GetString(4) == password) 
            {
                return new Inzenjer
                {
                    IdInzenjer = rdr.GetInt32(0),
                    Ime = rdr.GetString(1),
                    Prezime = rdr.GetString(2),
                    Username = rdr.GetString(3),
                    Password = rdr.GetString(4),
                    Licenca = rdr.IsDBNull(5) ? null : rdr.GetString(5)
                };
            }
            return null;
        }
    }
}
