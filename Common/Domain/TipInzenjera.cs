using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class TipInzenjera
    {
        [DisplayName("ID stručne spreme")]
        public int IdStrucnaSprema { get; set; }

        [DisplayName("Stručna sprema")]
        public string Naziv { get; set; } = null!;
    }
}
