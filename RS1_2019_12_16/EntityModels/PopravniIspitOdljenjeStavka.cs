using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2019_12_16.EntityModels
{
    public class PopravniIspitOdljenjeStavka
    {
        public int id { get; set; }
        public int PopravniIspitID { get; set; }
        public PopravniIspit PopravniIspit { get; set; }
        public int OdjeljenjeStavkaID { get; set; }
        public OdjeljenjeStavka OdjeljenjeStavka { get; set; }
        public bool? isPristupio { get; set; }
        public int bodovi { get; set; }

    }
}
