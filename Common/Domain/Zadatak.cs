using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Zadatak
    {
        [DisplayName("ID zadatka")]
        public int IdZadatak { get; set; }

        [DisplayName("Naziv zadatka")]
        public string Naziv { get; set; }

        [DisplayName("Trajanje (h)")]
        public int Trajanje { get; set; }

        [DisplayName("Cena")]
        public decimal Cena { get; set; }

    }
}
