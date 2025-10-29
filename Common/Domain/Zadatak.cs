using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Zadatak : IEntity
    {
        [DisplayName("ID zadatka")]
        public int IdZadatak { get; set; }

        [DisplayName("Naziv zadatka")]
        public string Naziv { get; set; }

        [DisplayName("Trajanje (h)")]
        public int Trajanje { get; set; }

        [DisplayName("Cena")]
        public decimal Cena { get; set; }

        public string TableName => "Zadatak";
        public string Values => $"{IdZadatak}, '{Naziv}', {Trajanje}, {Cena}";
        public string UpdateValues =>
            $"Naziv = '{Naziv}', " +
            $"Trajanje = '{Trajanje}', " +
            $"Cena = {Cena}, ";

        public string PrimaryKeyCondition => $"IdZadatak = {IdZadatak}";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new Zadatak
                {
                    IdZadatak = (int)reader["IdZadatak"],
                    Naziv = reader["Naziv"].ToString(),
                    Trajanje = Convert.ToInt32(reader["Trajanje"]),
                    Cena = Convert.ToDecimal(reader["Cena"])
                });
            }
            return list;
        }

    }
}
