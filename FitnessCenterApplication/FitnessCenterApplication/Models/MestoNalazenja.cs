using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenterApplication.Models
{
    public class MestoNalazenja
    {
        public string UlicaIBroj { get; set; }

        public string Mesto { get; set; }

        public string PostanskiBroj { get; set; }

        public MestoNalazenja()
        {
            UlicaIBroj = "";
            Mesto = "";
            PostanskiBroj = "";
        }

        public MestoNalazenja(string ulica, string place, string postalNumber)
        {
            UlicaIBroj = ulica;
            Mesto = place;
            PostanskiBroj = postalNumber;
        }
    }
}