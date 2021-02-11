using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RS1_2019_12_16.EF;
using RS1_2019_12_16.EntityModels;
using RS1_2019_12_16.ViewModels;

namespace RS1_2019_12_16.Controllers
{
    public class PopravniIspitController : Controller
    {

        private readonly MojContext db;
        public PopravniIspitController(MojContext _db){

            db = _db;
        }

        public IActionResult Index()
        {
            PopravniIspitIndexVM model = new PopravniIspitIndexVM
            {
                Skole = db.Skola.Select(i => new SelectListItem {
                    Text = i.Naziv,
                    Value = i.Id.ToString()
                }).ToList(),
                SkolskeGodine = db.SkolskaGodina.Select(i => new SelectListItem
                {
                    Text = i.Naziv,
                    Value = i.Id.ToString()
                }).ToList(),
                Predmeti = db.Predmet.Select(i => new SelectListItem
                {
                    Text = i.Naziv,
                    Value = i.Id.ToString()
                }).ToList()


            };
            return View(model);
        }
        public IActionResult Odaberi(PopravniIspitIndexVM vm) {

            var model = new PopravniIspitOdaberiVM { 
            SkolaID= vm.SkolaID,
            Skola= db.Skola.Find(vm.SkolaID).Naziv,
            SkolskaGodinaID= vm.SkolskaGodinaID,
            SkolskaGodina= db.SkolskaGodina.Find(vm.SkolskaGodinaID).Naziv,
            PredmetID=vm.PredmetID,
            Predmet= db.Predmet.Find(vm.PredmetID).Naziv,

            redovi= db.PopravniIspit.Where(i=>i.SkolaID == vm.SkolaID && i.SkoslkaGodinaID== vm.SkolskaGodinaID
            && i.PredmetID == vm.PredmetID).Select(p=>new PopravniIspitOdaberiVM.Red{
            PopravniIspitID=p.PopravniIspitID,
            DatumPopravnogIsita= p.Datum.ToString("dd/MM/yyyy"),
            BrojUcenikaNaPopravnom= db.PopravniIspitOdljenjeStavka.Where(j=>j.PopravniIspitID == p.PopravniIspitID).Count(),
            BrojUcenikaKojiSuPoloziliNaPopravnom= db.PopravniIspitOdljenjeStavka.Where(j=>j.PopravniIspitID == p.PopravniIspitID &&
             j.bodovi >50).Count()
            }).ToList()
     
            };
            foreach (var n in model.redovi)
                n.Nastavnik = getClanKomisije(n.PopravniIspitID);

            return View(model);
        }

        string getClanKomisije(int id)
        {
            var Komisija = db.Komisija
                .Include(i => i.Nastavnik)
                .Where(i => i.PopravniIspitID == id)
                .FirstOrDefault();

            return Komisija != null ? Komisija.Nastavnik.Ime + " " + Komisija.Nastavnik.Prezime : "N/A";
        }
        public IActionResult Dodaj(int skolaid, int sgid, int pid)
        {

            var model = new PopravniIspitDodajVM
            {
                SkolaID = skolaid,
                Skola = db.Skola.Find(skolaid).Naziv,

                SkolskaGodinaID = sgid,
                SkolskaGodina = db.SkolskaGodina.Find(sgid).Naziv,

                PredmetID = pid,
                Predmet = db.Predmet.Find(pid).Naziv,
                Nastavnici = db.Nastavnik.Select(i => new SelectListItem
                {
                    Value = i.Id.ToString(),
                    Text = i.Ime + " " + i.Prezime


                }).ToList()

            };

            return View(model);

        }
        public IActionResult Snimi(PopravniIspitDodajVM vm) {
            var ispit = new PopravniIspit { 
            SkolaID=vm.SkolaID,
            SkoslkaGodinaID=vm.SkolskaGodinaID,
            PredmetID= vm.PredmetID,
            Datum= vm.Datum
            };
            db.Add(ispit);
            db.SaveChanges();



            return Redirect("/PopravniIspit/Index");
        }
        //public IActionResult Uredi(int id){
        //    var ispit = db.PopravniIspit.Include(i => i.Skola).Include(i => i.SkolskaGodina).Include(i => i.Predmet).Where(
        //        i => i.PopravniIspitID == id).SingleOrDefault();

        //    var Komsija = db.Komisija.Include(i => i.Nastavnik).Where(i => i.PopravniIspitID == id).ToList();

        //    var model = new PopravniIspitUrediVM { 

        //    PopravniIspitID=id,

        //    SkolaID= ispit.SkolaID,
        //    Skola= ispit.Skola.Naziv,
        //    SkolskaGodinaID= ispit.SkoslkaGodinaID,
        //    SkolskaGodina= ispit.SkolskaGodina.Naziv,
        //    PredmetID= ispit.PredmetID,
        //    Predmet= ispit.Predmet.Naziv,
        //    Datum= ispit.Datum.ToString("dd/MM/yyyy")
        //    };
        //    foreach (var x in Komsija)
        //        model.Komisija.Add(x.Nastavnik.Ime + " "+x.Nastavnik.Prezime);

        //    return View(model);
        //}
        public IActionResult Uredi(int id)
        {
            var Ispit = db.PopravniIspit
                .Include(i => i.Skola)
                .Include(i => i.SkolskaGodina)
                .Include(i => i.Predmet)
                .Where(i => i.PopravniIspitID == id)
                .SingleOrDefault();

            var Komisija = db.Komisija
                .Include(i => i.Nastavnik)
                .Where(i => i.PopravniIspitID == id)
                .ToList();

            var model = new PopravniIspitUrediVM
            {
                PopravniIspitID = id,
                SkolaID = Ispit.SkolaID,
                Skola = Ispit.Skola.Naziv,
                SkolskaGodinaID = Ispit.SkoslkaGodinaID,
                SkolskaGodina = Ispit.SkolskaGodina.Naziv,
                PredmetID = Ispit.PredmetID,
                Predmet = Ispit.Predmet.Naziv,
                Datum = Ispit.Datum.ToString("dd/MM/yyyy")
            };


            foreach (var Clan in Komisija)
                model.Komisija.Add(Clan.Nastavnik.Ime + " " + Clan.Nastavnik.Prezime);

            return View(model);
        }
        public IActionResult DodajUcesnika(int id)
        {
            var naIspitu = db.PopravniIspitOdljenjeStavka.Include(i => i.OdjeljenjeStavka).Where(
                i => i.PopravniIspitID == id).ToList();

            var model = new PopravniIspitDodajUcesnikaVM { 
            PopravniIspitID= id,
            Ucesnici= db.OdjeljenjeStavka.Include(i=>i.Ucenik).Where(i=> !naIspitu.Any(j=>j.OdjeljenjeStavkaID==i.Id)).Select(
                i=>new SelectListItem
                { 
                Value=i.Id.ToString(),
                Text=i.Ucenik.ImePrezime
                }
                ).ToList()
            
            };
            return View(model);
        }
    
}
}