using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class TableDataBundle
    {
        public List<Inzenjer> Inzenjeri { get; set; } = new();
        public List<Klijent> Klijenti { get; set; } = new();
        public List<Mesto> Mesta { get; set; } = new();
        public List<Zadatak> Zadaci { get; set; } = new();
        public List<TipInzenjera> TipoviI { get; set; } = new();
        public List<TehnickaDokumentacija> TehnickeDokumentacije { get; set; } = new();
        public List<InzenjerTip> ITipovi { get; set; } = new();

    }
}
