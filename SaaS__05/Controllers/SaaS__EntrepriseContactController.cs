using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaaS__05.Models;

namespace SaaS__05.Controllers
{
    public class SaaS__EntrepriseContactController : Controller
    {
        DbModel db = new DbModel();
        // GET: SaaS__EntrepriseContact
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Entreprise__Contact.ToList());
        }

        // GET: SaaS__EntrepriseContact/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__EntrepriseContact/Create
        public ActionResult Create()
        {
            List<SaaS__Entreprise> listeabo = db.SaaS__Entreprise.ToList();
            Console.WriteLine(listeabo);
            ViewData["Abos"] = listeabo;
            return View();
        }

        // POST: SaaS__EntrepriseContact/Create
        [HttpPost]
        public ActionResult Create(SaaS__Entreprise__Contact entreprisecontact, string entreprise)
        {
            List<SaaS__Entreprise> listeabo = db.SaaS__Entreprise.ToList();
            SaaS__Entreprise abon = listeabo.Find(s => s.Title.Equals(entreprise));
            SaaS__Entreprise__Contact ent = new SaaS__Entreprise__Contact
            {
                ID_ = Guid.NewGuid(),
                Nom= entreprisecontact.Nom,
                Prenom= entreprisecontact.Prenom,
                Tel1= entreprisecontact.Tel1,
                Tel2= entreprisecontact.Tel2,
                ID____SaaS__Entreprise=abon.ID_
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Entreprise__Contact.Add(ent);
                    DbModel.SaveChanges();

                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }
        }

        // GET: SaaS__EntrepriseContact/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__EntrepriseContact/Edit/5
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

        // GET: SaaS__EntrepriseContact/Delete/5
        public ActionResult Delete(Guid id)
        {
            using (DbModel DbModel = new DbModel())
            {
                SaaS__Entreprise__Contact abo = DbModel.SaaS__Entreprise__Contact.Find(id);
                return View(abo);
            }
        }

        // POST: SaaS__EntrepriseContact/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            // TODO: Add delete logic here
            using (DbModel DbModel = new DbModel())
            {
                SaaS__Entreprise__Contact abo = DbModel.SaaS__Entreprise__Contact.Where(x => x.ID_ == id).FirstOrDefault();
                DbModel.SaaS__Entreprise__Contact.Remove(abo);
                DbModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
