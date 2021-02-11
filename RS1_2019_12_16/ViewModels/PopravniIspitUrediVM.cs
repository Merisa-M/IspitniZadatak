using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2019_12_16.ViewModels
{
    public class PopravniIspitUrediVM
    {
        public int PopravniIspitID { get; set; }
        public int SkolaID { get; set; }
        public string Skola { get; set; }
        public int SkolskaGodinaID { get; set; }
        public string SkolskaGodina { get; set; }
        public List<string> Komisija { get; set; } = new List<string>();

        public int PredmetID { get; set; }
        public string Predmet { get; set; }
        public string Datum { get; set; }

    }
}
