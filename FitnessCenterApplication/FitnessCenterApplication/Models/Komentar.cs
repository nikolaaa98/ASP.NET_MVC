using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenterApplication.Models
{
    public class Komentar
    {
        /*
            * Komentar
            ● Posetilac koji je ostavio komentar
            ● Fitnes centar na koji se komentar odnosi
            ● Tekst komentara
            ● Ocena (na skali od 1 do 5)
         */

        public Korisnik Posetilac { get; set; }
        public FitnesCentar FitnesCentar { get; set; }
        public string Tekst { get; set; }
        public int Ocena { get; set; }

        public Komentar() { Posetilac = new Korisnik(); FitnesCentar = new FitnesCentar(); Tekst = ""; Ocena = 0; }
        public Komentar(Korisnik posetioci, FitnesCentar fitnesCentri, string text, int mark)
        {
            Posetilac = posetioci;
            FitnesCentar = fitnesCentri;
            Tekst = text;
            Ocena = Ocena;
        }
    }
}