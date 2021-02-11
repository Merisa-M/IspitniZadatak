using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2019_12_16.ViewModels
{
    public class PopravniIspitOdaberiVM
    {
        public int SkolaID { get; set; }
        public string Skola { get; set; }
        public int SkolskaGodinaID { get; set; }

        public string SkolskaGodina { get; set; }
        public int PredmetID { get; set; }

        public string Predmet { get; set; }

        public List<Red> redovi { get; set; }
        public class Red { 
            public int PopravniIspitID { get; set; }
        public string DatumPopravnogIsita { get; set; }
        public string Nastavnik { get; set; }
            public int BrojUcenikaNaPopravnom { get; set; }
            public int BrojUcenikaKojiSuPoloziliNaPopravnom { get; set; }
        }
    }
}
