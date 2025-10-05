using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class StavkaTehnickaDokumentacija
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
    }
}
