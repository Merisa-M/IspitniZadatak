using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2019_12_16.ViewModels
{
    public class PopravniIspitDodajUcesnikaVM
    {
        public int PopravniIspitID { get; set; }
        public int OdjeljenjeStavkaID { get; set; }
        public List<SelectListItem> Ucesnici{get;set;}
    }
}
