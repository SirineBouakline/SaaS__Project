using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SaaS__05.Models;
using System.Web.Mvc;

namespace SaaS__05.Controllers
{
    public class SaaS__MessageModeleController : Controller
    {
        DbModel db = new DbModel();
        // GET: SaaS__MessageModele
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Message__Modele.ToList());
        }

        // GET: SaaS__MessageModele/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__MessageModele/Create
        public ActionResult Create()
        {
            List<SaaS__Message__Type> listeabo = db.SaaS__Message__Type.ToList();
            Console.WriteLine(listeabo);
            ViewData["Abos"] = listeabo;
            return View();
        }

        // POST: SaaS__MessageModele/Create
        [HttpPost]
        public ActionResult Create(SaaS__Message__Modele fonctionnalite, string abonnement)
        {
            List<SaaS__Message__Type> listeabo = db.SaaS__Message__Type.ToList();
            SaaS__Message__Type abon = listeabo.Find(s => s.Title.Equals(abonnement));
            SaaS__Message__Modele fo = new SaaS__Message__Modele
            {
                ID_ = Guid.NewGuid(),
                Description = fonctionnalite.Description,
                Title = fonctionnalite.Title,
                ID____SaaS__Message__Type = abon.ID_
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Message__Modele.Add(fo);
                    DbModel.SaveChanges();
                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }

        }

        // GET: SaaS__MessageModele/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__MessageModele/Edit/5
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

        // GET: SaaS__MessageModele/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaaS__MessageModele/Delete/5
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
