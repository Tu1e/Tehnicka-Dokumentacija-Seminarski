using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class TehnickaDokumentacija
    {
        [DisplayName("ID Dokumenta")]
        public int IdTehnickaDokumentacija { get; set; }

        [DisplayName("Datum potpisivanja")]
        public DateTime DatumPotpisivanja { get; set; }

        [DisplayName("Datum završetka")]
        public DateTime DatumZavrsetka { get; set; }

        [DisplayName("Ukupan iznos")]
        public double UkupanIznos { get; set; }

        [DisplayName("Inženjer")]
        public int IdInzenjer { get; set; }

        [DisplayName("Klijent")]
        public int IdKlijent { get; set; }

    }
}
