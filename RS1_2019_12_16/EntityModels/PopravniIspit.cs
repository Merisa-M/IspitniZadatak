using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2019_12_16.EntityModels
{
    public class PopravniIspit
    {
        public int PopravniIspitID { get; set; }
        public int SkolaID { get; set; }
       
        public Skola Skola { get; set; }
        public int SkoslkaGodinaID { get; set; }
        public SkolskaGodina SkolskaGodina { get; set; }
        public int PredmetID { get; set; }
        public  Predmet Predmet { get; set; }
        public DateTime Datum { get; set; }
        public ICollection<Komisija> Komisija { get; set; }
    }
}

