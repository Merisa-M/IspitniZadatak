using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2019_12_16.ViewModels
{
    public class PopravniIspitIndexVM
    {

        public int SkolaID { get; set; }
        public List<SelectListItem> Skole { get; set; }
        public int SkolskaGodinaID { get; set; }
        public List<SelectListItem> SkolskeGodine { get; set; }

        public int PredmetID { get; set; }
        public List<SelectListItem> Predmeti { get; set; }

    }
}
