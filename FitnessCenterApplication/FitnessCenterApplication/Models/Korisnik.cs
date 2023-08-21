using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenterApplication.Models
{
    public class Korisnik
    {
        /*
         *  Korisničko ime (jedinstveno)
            ● Lozinka
            ● Ime
            ● Prezime
            ● Pol
            ● Email
            ● Datum rođenja (čuvati u formatu dd/MM/yyyy)
            ● Uloga (Posetilac, Trener ili Vlasnik)
            ● Lista grupnih treninga na koje je korisnik prijavljen (ako korisnik ima ulogu Posetioca)
            ● Lista grupnih treninga na kojima je korisnik angažovan kao trener (ako korisnik ima
            ulogu Trenera)
            ● Fitnes centar gde je korisnik angažovan (ako korisnik ima ulogu Trenera)
            ● Fitnes centri čiji je korisnik vlasnik (ako korisnik ima ulogu Vlasnika)
        */

        public enum PolType { M, F }
        public enum UserType { POSETILAC, TRENER, VLASNIK }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public PolType Pol { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
        public UserType Uloga { get; set; }
        public List<GrupniTrening> GrupniTreninziPosetilac { get; set; } // ako je korisnik Posetioc
        public List<GrupniTrening> GrupniTreninziTrener { get; set; } // ako je korisnik trener
        public FitnesCentar FitnesCentriTrener { get; set; } // ako je korisnik Trener
        public FitnesCentar FitnesCentriVlasnik { get; set; } // ako je korisnik Vlasnik

        public Korisnik()
        {
            KorisnickoIme = "";
            Lozinka = "";
            Ime = "";
            Prezime = "";
            Pol = PolType.M;
            Email = "";
            DateofBirth = DateTime.Now;
            Uloga = UserType.POSETILAC;
            GrupniTreninziPosetilac = new List<GrupniTrening>();
            GrupniTreninziTrener = new List<GrupniTrening>();
            FitnesCentriTrener = new FitnesCentar();
            FitnesCentriVlasnik = new FitnesCentar();
        }

        public Korisnik(string ime, string password, string name, string lastname, PolType gender, string email, DateTime datumRodjenja, UserType role, List<GrupniTrening> groupTraining1, List<GrupniTrening> groupTraining2, FitnesCentar fitnesCenter1, FitnesCentar fitnesCenter2)
        {
            KorisnickoIme = ime;
            Lozinka = password;
            Ime = name;
            Prezime = lastname;
            Pol = gender;
            Email = email;
            DateofBirth = datumRodjenja;
            Uloga = role;
            GrupniTreninziPosetilac = groupTraining1;
            GrupniTreninziTrener = groupTraining2;
            FitnesCentriTrener = fitnesCenter1;
            FitnesCentriVlasnik = fitnesCenter2;
        }
    }
}