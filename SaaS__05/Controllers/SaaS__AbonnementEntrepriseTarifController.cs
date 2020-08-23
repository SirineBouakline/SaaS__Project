using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaaS__05.Models;

namespace SaaS__05.Controllers
{

    public class SaaS__AbonnementEntrepriseTarifController : Controller
    {
        DbModel db = new DbModel();
        // GET: SaaS__AbonnementEntrepriseTarif
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif.ToList());
        }

        // GET: SaaS__AbonnementEntrepriseTarif/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__AbonnementEntrepriseTarif/Create
        public ActionResult Create()
        {
            List<SaaS__Abonnement> listeabo = db.SaaS__Abonnement.ToList();
            Console.WriteLine(listeabo);
            ViewData["Abos"] = listeabo;
            List<SaaS__Entreprise> listeent = db.SaaS__Entreprise.ToList();
            Console.WriteLine(listeent);
            ViewData["Entreprises"] = listeent;
            List<SaaS__Tarif> listtarif = db.SaaS__Tarif.ToList();
            Console.WriteLine(listtarif);
            ViewData["Tarifs"] = listtarif;
            return View();
        }

        // POST: SaaS__AbonnementEntrepriseTarif/Create
        [HttpPost]
        public ActionResult Create(SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif aboEntrTarif, string entreprise, string abonnement, string tarif)
        {
            List<SaaS__Abonnement> listeabo = db.SaaS__Abonnement.ToList();
            SaaS__Abonnement abon = listeabo.Find(s => s.Title.Equals(abonnement));
            List<SaaS__Entreprise> listeent = db.SaaS__Entreprise.ToList();
            SaaS__Entreprise ent = listeent.Find(s => s.Title.Equals(entreprise));
            List<SaaS__Tarif> listtarif = db.SaaS__Tarif.ToList();
            SaaS__Tarif t = listtarif.Find(s => s.Title.Equals(tarif));
            SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif AET = new SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif
            {
                ID_ = Guid.NewGuid(),
                Date_Debut= aboEntrTarif.Date_Debut,
                Date_Fin= aboEntrTarif.Date_Fin,
                
                ID____SaaS__Abonnement= abon.ID_,
                ID____SaaS__Entreprise= ent.ID_,
                ID____SaaS__Tarif= t.ID_
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Abonnement____88____SaaS__Entreprise____88____SaaS__Tarif.Add(AET);
                    DbModel.SaveChanges();

                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }
        }

        // GET: SaaS__AbonnementEntrepriseTarif/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__AbonnementEntrepriseTarif/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SaaS__AbonnementEntrepriseTarif/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaaS__AbonnementEntrepriseTarif/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
