using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class TehnickaDokumentacija : IEntity
    {
        [DisplayName("ID Dokumenta")]
        public int IdTehnickaDokumentacija { get; set; }

        [DisplayName("Datum potpisivanja")]
        public DateTime DatumPotpisivanja { get; set; }

        [DisplayName("Datum završetka")]
        public DateTime DatumZavrsetka { get; set; }

        [DisplayName("Ukupan iznos")]
        public decimal UkupanIznos { get; set; }

        [DisplayName("Inženjer")]
        public int IdInzenjer { get; set; }

        [DisplayName("Klijent")]
        public int IdKlijent { get; set; }

        public string TableName => "TehnickaDokumentacija";
        public string Values => $"{IdTehnickaDokumentacija}, '{DatumPotpisivanja:yyyy-MM-dd}', '{DatumZavrsetka:yyyy-MM-dd}', {UkupanIznos}, {IdInzenjer}, {IdKlijent}";
        public string UpdateValues =>
            $"DatumPotpisivanja = '{DatumPotpisivanja:yyyy-MM-dd}', " +
            $"DatumZavrsetka = '{DatumZavrsetka:yyyy-MM-dd}', " +
            $"UkupanIznos = {UkupanIznos}, " +
            $"IdInzenjer = {IdInzenjer}, " +
            $"IdKlijent = {IdKlijent}";

        public string PrimaryKeyCondition => $"IdTD = {IdTehnickaDokumentacija}";
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new TehnickaDokumentacija
                {
                    IdTehnickaDokumentacija = (int)reader["IdTD"],
                    DatumPotpisivanja = Convert.ToDateTime(reader["DatumPotpisivanja"]),
                    DatumZavrsetka = Convert.ToDateTime(reader["DatumZavrsetka"]),
                    UkupanIznos = Convert.ToDecimal(reader["UkupanIznos"]),
                    IdInzenjer = (int)reader["IdInzenjer"],
                    IdKlijent = (int)reader["IdKlijent"]
                });
            }
            return list;
        }

    }
}
