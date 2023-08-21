using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenterApplication.Models
{
    public class GrupniTrening
    {
        /*
         Grupni Trening
            ● NazivT
            ● Tip treninga (yoga, les mills tone, body pump itd. )
            ● Fitnes centar gde se održava trening (veza sa klasom Fitnes centar)
            ● Trajanje treninga (izraženo u minutima)
            ● Datum i vreme treninga (čuvati u formatu dd/MM/yyyy HH:mm)
            ● Maksimalan broj posetilaca
            ● Spisak posetilaca (lista Korisnika sa ulogom Posetilac koji su se prijavili da pohađaju
            trening)      
        */
        public enum TypeOfTraining { YOGA, LES_MILLS_TONE, BODY_PUMP }
        public string Naziv { get; set; }
        public TypeOfTraining TipTreninga { get; set; }
        public FitnesCentar FitnesCentar { get; set; }
        public int TrajanjeTreninga { get; set; }
        public DateTime DatumIVremeTreninga { get; set; }
        public int MaksimalanBrojPosetilaca { get; set; }
        public List<Korisnik> SpisakPosetilaca { get; set; }

        public GrupniTrening()
        {
            Naziv = "";
            TipTreninga = TypeOfTraining.YOGA;
            FitnesCentar = new FitnesCentar();
            TrajanjeTreninga = 0;
            DatumIVremeTreninga = DateTime.Now;
            MaksimalanBrojPosetilaca = 0;
            SpisakPosetilaca = new List<Korisnik>();
        }

        public GrupniTrening(string naziv, TypeOfTraining tipTreninga, FitnesCentar fitnesCentar, int trajanje, DateTime datum, int maksimalanBroj, List<Korisnik> spisak)
        {
            Naziv = naziv;
            TipTreninga = tipTreninga;
            FitnesCentar = fitnesCentar;
            TrajanjeTreninga = trajanje;
            DatumIVremeTreninga = datum;
            MaksimalanBrojPosetilaca = maksimalanBroj;
            SpisakPosetilaca = spisak;
        }
        
    }
}