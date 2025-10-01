using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class TehnickaDokumentacija
    {
        public int IdTD { get; set; }
        public DateTime DatumPotpisivanja { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public decimal UkupanIznos { get; set; }
        public int IdInzenjer { get; set; }
        public int IdKlijent { get; set; }

    }
}
