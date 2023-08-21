using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenterApplication.Models
{
    public class FitnesCentar
    {
        /*
            * Fitnes centar
            ● Naziv
            ● Adresa u formatu: ulica i broj, mesto/grad, poštanski broj
            ● Godina otvaranja fitnes centra
            ● Vlasnik (veza sa klasom Korisnik)
            ● Cena mesečne članarine
            ● Cena godišnje članarine
            ● Cena jednog treninga
            ● Cena jednog grupnog treninga
            ● Cena jednog treninga sa personalnim trenerom
         */

        public string Name { get; set; }
        public MestoNalazenja Adresa { get; set; }
        public int GodinaOtvaranjaFitnesCentra { get; set; }
        public Korisnik Vlasnik { get; set; }
        public int MesecnaClanarina { get; set; }
        public int GodisnjaClanarina { get; set; }
        public int CenaJednogTreninga { get; set; }
        public int CenaJednogGrupnogTreninga { get; set; }
        public int CenaJednogTreningaSaPersonalnimTrenerom { get; set; }

        public FitnesCentar()
        {
            Name = "";
            Adresa = new MestoNalazenja("", "", "");
            GodinaOtvaranjaFitnesCentra = 0;
            Vlasnik = new Korisnik();
            MesecnaClanarina = 0;
            GodisnjaClanarina = 0;
            CenaJednogTreninga = 0;
            CenaJednogGrupnogTreninga = 0;
            CenaJednogTreningaSaPersonalnimTrenerom = 0;
        }

        public FitnesCentar(string name, string adresa, int godinaOtvaranja, Korisnik owner, int mesecna, int godisnja, int jedan, int jedanGrupni, int jedanSaPersonalnim)
        {
            Name = name;
            Adresa = new MestoNalazenja(adresa.Split(',')[0], adresa.Split(',')[1], adresa.Split(',')[2]);
            GodinaOtvaranjaFitnesCentra = godinaOtvaranja;
            Vlasnik = owner;
            MesecnaClanarina = mesecna;
            GodisnjaClanarina = godisnja;
            CenaJednogTreninga = jedan;
            CenaJednogGrupnogTreninga = jedanGrupni;
            CenaJednogTreningaSaPersonalnimTrenerom = jedanSaPersonalnim;
        }

    }
}