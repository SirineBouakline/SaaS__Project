using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaaS__05.Models;

namespace SaaS__05.Controllers
{
    public class SaaS__AbonnementFonctionnaliteController : Controller
    {
        DbModel db = new DbModel();
        // GET: SaaS__AbonnementFonctionnalite
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Abonnement____88____SaaS__Fonctionnalite.ToList());
        }

        // GET: SaaS__AbonnementFonctionnalite/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__AbonnementFonctionnalite/Create
        public ActionResult Create()
        {
            List<SaaS__Abonnement> listeabos = db.SaaS__Abonnement.ToList();
            Console.WriteLine(listeabos);
            ViewData["Abos"] = listeabos;

            List<SaaS__Fonctionnalite> listfonct = db.SaaS__Fonctionnalite.ToList();
            Console.WriteLine(listfonct);
            ViewData["Foncts"] = listfonct;

            return View();
        }

        // POST: SaaS__AbonnementFonctionnalite/Create
        [HttpPost]
        public ActionResult Create(SaaS__Abonnement____88____SaaS__Fonctionnalite Abo_Fonc, string abonnement, string fonctionnalite )
        {
            List<SaaS__Abonnement> listabos = db.SaaS__Abonnement.ToList();
            SaaS__Abonnement abon = listabos.Find(s => s.Title.Equals(abonnement));

            List<SaaS__Fonctionnalite> listfonct = db.SaaS__Fonctionnalite.ToList();
            SaaS__Fonctionnalite fnct = listfonct.Find(s => s.Title.Equals(fonctionnalite));

            SaaS__Abonnement____88____SaaS__Fonctionnalite fo = new SaaS__Abonnement____88____SaaS__Fonctionnalite
            {
                ID_ = Guid.NewGuid(),
                ID____SaaS__Abonnement = abon.ID_,
                ID____SaaS__Fonctionnalite= fnct.ID_
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Abonnement____88____SaaS__Fonctionnalite.Add(fo);
                    DbModel.SaveChanges();
                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }

        }

        // GET: SaaS__AbonnementFonctionnalite/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__AbonnementFonctionnalite/Edit/5
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

        // GET: SaaS__AbonnementFonctionnalite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaaS__AbonnementFonctionnalite/Delete/5
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
