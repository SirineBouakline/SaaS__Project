using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaaS__05.Models;

namespace SaaS__05.Controllers
{
    public class SaaS__UtilisateurController : Controller
    {
        DbModel db = new DbModel();
        // GET: SaaS__Utilisateur
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Utilisateur.ToList());
        }

        // GET: SaaS__Utilisateur/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__Utilisateur/Create
        public ActionResult Create()
        {
            List<SaaS__Entreprise> listeabo = db.SaaS__Entreprise.ToList();
            Console.WriteLine(listeabo);
            ViewData["Abos"] = listeabo;
            return View();
        }

        // POST: SaaS__Utilisateur/Create
        [HttpPost]
        public ActionResult Create(SaaS__Utilisateur utilisateur, string entreprise)
        {
            List<SaaS__Entreprise> listeabo = db.SaaS__Entreprise.ToList();
            SaaS__Entreprise abon = listeabo.Find(s => s.Title.Equals(entreprise));
            SaaS__Utilisateur u = new SaaS__Utilisateur
            {
                ID_ = Guid.NewGuid(),
                Nom = utilisateur.Nom,
                Prenom = utilisateur.Prenom,
                Email = utilisateur.Email,
                Num__Telephone = utilisateur.Num__Telephone,
                Password = utilisateur.Password,
                Delais__Grace = utilisateur.Delais__Grace,
                isAdmin = utilisateur.isAdmin,
                isSuperAdmin = utilisateur.isSuperAdmin,
                ID____SaaS__Entreprise= abon.ID_
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Utilisateur.Add(u);
                    DbModel.SaveChanges();

                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }
        }


        // GET: SaaS__Utilisateur/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__Utilisateur/Edit/5
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

        // GET: SaaS__Utilisateur/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaaS__Utilisateur/Delete/5
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
