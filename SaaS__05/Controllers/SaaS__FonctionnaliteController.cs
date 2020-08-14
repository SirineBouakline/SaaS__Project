using SaaS__05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaaS__05.Controllers
{
    public class SaaS__FonctionnaliteController : Controller
    {
        DbModel db = new DbModel();
        // GET: SaaS__Fonctionnalite
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Fonctionnalite.ToList());
        }

        // GET: SaaS__Fonctionnalite/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        
        // GET: SaaS__Fonctionnalite/Create
        public ActionResult Create()
        {
            List<SaaS__Abonnement> listeabo = db.SaaS__Abonnement.ToList();
            Console.WriteLine(listeabo);
            ViewData["Abos"] = listeabo;
            return View();
        }
        // POST: SaaS__Fonctionnalite/Create
        [HttpPost]
        public ActionResult Create(SaaS__Fonctionnalite fonctionnalite ,string abonnement)
        {
            

            List<SaaS__Abonnement> listeabo = db.SaaS__Abonnement.ToList();
            SaaS__Abonnement abon= listeabo.Find(s=>s.Title.Equals(abonnement));
            SaaS__Fonctionnalite fo = new SaaS__Fonctionnalite
            {
                ID_ = Guid.NewGuid(),
                Description = fonctionnalite.Description,
                Title = fonctionnalite.Title,
                ID____SaaS__Abonnement = abon.ID_
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Fonctionnalite.Add(fo);
                    DbModel.SaveChanges();
                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }

        }

        // GET: SaaS__Fonctionnalite/Edit/5
        public ActionResult Edit(Guid id)
        {
            List<SaaS__Abonnement> listeabo = db.SaaS__Abonnement.ToList();
            Console.WriteLine(listeabo);
            ViewData["Abos"] = listeabo;
            //return View();
            return View(db.SaaS__Fonctionnalite.Where(x => x.ID_ == id).FirstOrDefault());
            
        }

        // POST: SaaS__Fonctionnalite/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, SaaS__Fonctionnalite fonctionnalite)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModel DbModel = new DbModel())
                {
                    DbModel.Entry(fonctionnalite).State = System.Data.Entity.EntityState.Modified;
                   
                    DbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SaaS__Fonctionnalite/Delete/5
        public ActionResult Delete(Guid id)
        {
            using (DbModel DbModel = new DbModel())
            {
                SaaS__Fonctionnalite abo = DbModel.SaaS__Fonctionnalite.Find(id);
                return View(abo);
            }
        }

        // POST: SaaS__Abonnement/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            // TODO: Add delete logic here
            using (DbModel DbModel = new DbModel())
            {
                SaaS__Fonctionnalite abo = DbModel.SaaS__Fonctionnalite.Where(x => x.ID_ == id).FirstOrDefault();
                DbModel.SaaS__Fonctionnalite.Remove(abo);
                DbModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
