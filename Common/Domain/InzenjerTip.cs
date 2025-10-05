using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class InzenjerTip
    {
        [DisplayName("ID Inženjera")]
        public int IdInzenjer { get; set; }

        [DisplayName("ID stručne spreme")]
        public int IdStrucnaSprema { get; set; }

        [DisplayName("Opis")]
        public string? Opis { get; set; }

        [DisplayName("Godine iskustva")]
        public int GodineIskustva { get; set; }

        public Inzenjer Inzenjer { get; set; } = null!;
        public TipInzenjera TipInzenjera { get; set; } = null!;
    }
}
