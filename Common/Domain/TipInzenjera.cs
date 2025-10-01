using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class TipInzenjera
    {
        public int IdStrucnaSprema { get; set; }
        public string Naziv { get; set; } = null!;
        public List<InzenjerTip> InzenjerTipovi { get; set; } = new List<InzenjerTip>();
    }
}
