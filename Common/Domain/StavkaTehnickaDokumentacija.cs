using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class StavkaTehnickaDokumentacija
    {
        public int IdTD { get; set; }
        public int Rb { get; set; }           // deo ključa
        public string Sadrzaj { get; set; } = null!;
        public DateTime DatumKreiranja { get; set; }
        public decimal CenaZadataka { get; set; }
        public int Kolicina { get; set; }
        public decimal UkupanIznosStavke { get; set; } // može COMPUTED
        public int IdZadatak { get; set; }

        public TehnickaDokumentacija TehnickaDokumentacija { get; set; } = null!;
        public Zadatak Zadatak { get; set; } = null!;
    }
}
