using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Mesto
    {
        [DisplayName("ID mesta")]
        public int IdMesto { get; set; }

        [DisplayName("Naziv mesta")]
        public string NazivMesta { get; set; }

        [DisplayName("Naziv države")]
        public string NazivDrzave { get; set; }
    }
}
