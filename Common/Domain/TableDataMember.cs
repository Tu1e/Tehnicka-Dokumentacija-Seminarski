using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class TableDataMember
    {
        public Inzenjer Inzenjer { get; set; }
        public Klijent Klijent { get; set; }
        public Mesto Mesto { get; set; }
        public TehnickaDokumentacija TehnickaDokumentacija { get; set; }
        public StavkaTehnickaDokumentacija STDokumentacija { get; set; }
        public Zadatak Zadatak { get; set; }
        public TipInzenjera TipInzenjera { get; set; }
        public InzenjerTip InzenjerTip { get; set; }
        public TableName TableName { get; set; }
    }
}
