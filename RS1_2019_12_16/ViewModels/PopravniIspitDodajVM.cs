using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2019_12_16.ViewModels
{
    public class PopravniIspitDodajVM
    {
        public int ClanKomisije1 { get; set; }
        public int ClanKomisije2 { get; set; }
        public int ClanKomisije3 { get; set; }
        public List<SelectListItem> Nastavnici { get; set; }
        public int SkolaID { get; set; }
        public string Skola { get; set; }

        public int SkolskaGodinaID { get; set; }
        public string SkolskaGodina { get; set; }

        public int PredmetID { get; set; }
        public string Predmet { get; set; }
        public DateTime Datum { get; set; }

    }
}
