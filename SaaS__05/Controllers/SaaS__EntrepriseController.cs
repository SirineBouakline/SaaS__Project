using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SaaS__05.Models;
using System.Web.Mvc;

namespace SaaS__05.Controllers
{
    public class SaaS__EntrepriseController : Controller
    {
        // GET: SaaS__Entreprise
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Entreprise.ToList());
        }

        // GET: SaaS__Entreprise/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__Entreprise/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaaS__Entreprise/Create
        [HttpPost]
        public ActionResult Create(SaaS__Entreprise entreprise)
        {
            SaaS__Entreprise ent = new SaaS__Entreprise
            {
                ID_ = Guid.NewGuid(),
                Addresse = entreprise.Addresse,
                Title = entreprise.Title,
                Email= entreprise.Email,
                Code__TVA= entreprise.Code__TVA,
                Num__Telephone= entreprise.Num__Telephone,
                RNE=entreprise.RNE,
                
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Entreprise.Add(ent);
                    DbModel.SaveChanges();

                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }
        }
        // GET: SaaS__Entreprise/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__Entreprise/Edit/5
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

        // GET: SaaS__Entreprise/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaaS__Entreprise/Delete/5
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
