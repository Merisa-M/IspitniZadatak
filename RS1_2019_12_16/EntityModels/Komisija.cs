﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_2019_12_16.EntityModels
{
    public class Komisija
    {
        public int PopravniIspitID { get; set; }
        public PopravniIspit PopravniIspit { get; set; }
        public int NastavnikID { get; set; }
        public Nastavnik Nastavnik { get; set; }
    }
}
