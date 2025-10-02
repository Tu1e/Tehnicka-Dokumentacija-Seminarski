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
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = @"
                SELECT IdInzenjer, Ime, Prezime, KorisnickoIme, Sifra, Licenca
                FROM Inzenjer
                WHERE KorisnickoIme = @u;";

                command.Parameters.Add("@u", SqlDbType.NVarChar, 30).Value = username;

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow))
                {
                    if (!reader.Read())
                        return null;

                    // poređenje lozinke (napomena: u praksi koristi hash + salt)
                    if ((string)reader["Sifra"] != password)
                        return null;

                    Inzenjer inzenjer = new Inzenjer
                    {
                        IdInzenjer = (int)reader["IdInzenjer"],
                        Ime = (string)reader["Ime"],
                        Prezime = (string)reader["Prezime"],
                        Username = (string)reader["KorisnickoIme"],
                        Password = (string)reader["Sifra"],
                        Licenca = reader["Licenca"] == DBNull.Value ? null : (string)reader["Licenca"]
                    };

                    return inzenjer;
                }
            }
        }
    }
}
