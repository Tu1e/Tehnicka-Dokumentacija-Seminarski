using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Klijent : IEntity
    {
        [DisplayName("ID klijenta")]
        public int IdKlijent { get; set; }

        [DisplayName("Ime")]
        public string Ime { get; set; }

        [DisplayName("Prezime")]
        public string Prezime { get; set; }

        [DisplayName("Stranac")]
        public bool Stranac { get; set; }

        [DisplayName("ID Mesta")]
        public int IdMesto { get; set; }

        public string ImePrezime => $"{Ime} {Prezime}";

        public string TableName => "Klijent";
        public string Values => $"{IdKlijent}, '{Ime}', '{Prezime}', '{(Stranac ? 1 : 0)}', {IdMesto}";
        public string UpdateValues =>
            $"Ime = '{Ime}', " +
            $"Prezime = '{Prezime}', " +
            $"Stranac = {(Stranac ? 1 : 0)}, " +
            $"IdMesto = {IdMesto}";

        public string PrimaryKeyCondition => $"IdKlijent = {IdKlijent}";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new Klijent
                {
                    IdKlijent = (int)reader["IdKlijent"],
                    Ime = reader["Ime"].ToString(),
                    Prezime = reader["Prezime"].ToString(),
                    Stranac = (bool)reader["Stranac"],
                    IdMesto = (int)reader["IdMesto"]
                });
            }
            return list;
        }

    }
}
