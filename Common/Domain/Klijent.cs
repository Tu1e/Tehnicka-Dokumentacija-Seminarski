using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Klijent
    {
        [DisplayName("ID klijenta")]
        public int IdKlijent { get; set; }

        [DisplayName("Ime")]
        public string Ime { get; set; }

        [DisplayName("Prezime")]
        public string Prezime { get; set; }

        [DisplayName("Stranac")]
        public bool Stranac { get; set; }

        [DisplayName("ID Mesta")]//Mozda naziv mesta umesto ID
        public int IdMesto { get; set; }

        public string ImePrezime => $"{Ime} {Prezime}";
    }
}
