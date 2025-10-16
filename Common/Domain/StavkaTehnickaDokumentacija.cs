using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class StavkaTehnickaDokumentacija : IEntity
    {
        [DisplayName("ID tehničke dokumentacije")]
        public int IdTD { get; set; }

        [DisplayName("Redni broj")]
        public int Rb { get; set; }           // deo ključa

        [DisplayName("Sadržaj")]
        public string Sadrzaj { get; set; } = null!;

        [DisplayName("Datum kreiranja")]
        public DateTime DatumKreiranja { get; set; }

        [DisplayName("Cena zadatka")]
        public decimal CenaZadataka { get; set; }

        [DisplayName("Količina")]
        public int Kolicina { get; set; }

        [DisplayName("Ukupan iznos stavke")]
        public decimal UkupanIznosStavke { get; set; } // može COMPUTED

        public int IdZadatak { get; set; }//vrv da se izbaci i da se koristi Zadatak ceo

        public TehnickaDokumentacija TehnickaDokumentacija { get; set; } = null!;

        [DisplayName("Zadatak")]
        public Zadatak Zadatak { get; set; } = null!;

        public string TableName => "StavkaTehnickaDokumentacija";
        public string Values => $"{IdTD}, {Rb}, '{Sadrzaj}', '{DatumKreiranja:yyyy-MM-dd}', {CenaZadataka}, {Kolicina}, {UkupanIznosStavke}, {IdZadatak}";
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            var list = new List<IEntity>();
            while (reader.Read())
            {
                list.Add(new StavkaTehnickaDokumentacija
                {
                    IdTD = (int)reader["IdTD"],
                    Rb = (int)reader["Rb"],
                    Sadrzaj = reader["Sadrzaj"].ToString(),
                    DatumKreiranja = Convert.ToDateTime(reader["DatumKreiranja"]),
                    CenaZadataka = Convert.ToDecimal(reader["CenaZadataka"]),
                    Kolicina = Convert.ToInt32(reader["Kolicina"]),
                    UkupanIznosStavke = Convert.ToDecimal(reader["UkupanIznosStavke"]),
                    IdZadatak = (int)reader["IdZadatak"]
                });
            }
            return list;
        }

    }
}
