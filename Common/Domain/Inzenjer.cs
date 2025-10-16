using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Collections.Generic;

namespace Common.Domain
{
    public class Inzenjer : IEntity
    {
        [DisplayName("ID inženjera")]
        public int IdInzenjer { get; set; }

        [DisplayName("Ime")]
        public string Ime { get; set; }

        [DisplayName("Prezime")]
        public string Prezime { get; set; }

        [DisplayName("Korisničko ime")]
        public string Username { get; set; }

        [DisplayName("Šifra")]
        public string Password { get; set; }

        [DisplayName("Licenca")]
        public string Licenca { get; set; }

        public string ImePrezime => $"{Ime} {Prezime}";

        public string TableName => "Inzenjer";
        public string Values => $"'{Ime}', '{Prezime}', '{Username}', '{Password}', '{Licenca}'";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> list = new List<IEntity>();
            while (reader.Read())
            {
                Inzenjer i = new Inzenjer
                {
                    IdInzenjer = (int)reader["IdInzenjer"],
                    Ime = reader["Ime"].ToString(),
                    Prezime = reader["Prezime"].ToString(),
                    Username = reader["KorisnickoIme"].ToString(),
                    Password = reader["Sifra"].ToString(),
                    Licenca = reader["Licenca"].ToString()
                };
                list.Add(i);
            }
            return list;
        }
    }
}
