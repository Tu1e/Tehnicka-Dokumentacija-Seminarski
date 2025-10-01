using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Klijent
    {
        public int IdKlijent { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool Stranac { get; set; }
        public int IdMesto { get; set; }

    }
}
