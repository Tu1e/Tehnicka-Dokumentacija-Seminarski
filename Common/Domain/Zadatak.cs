using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Zadatak
    {
        public int IdZadatak { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; }
        public decimal Cena { get; set; }

    }
}
