using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class InzenjerTip
    {
        public int IdInzenjer { get; set; }
        public int IdStrucnaSprema { get; set; }
        public string? Opis { get; set; }
        public int GodineIskustva { get; set; }

        public Inzenjer Inzenjer { get; set; } = null!;
        public TipInzenjera TipInzenjera { get; set; } = null!;
    }
}
