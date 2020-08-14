using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaaS__05.Controllers
{
    public class SaaS__Message__ModeleController : Controller
    {
        // GET: SaaS__Message__Modele
        public ActionResult Index()
        {
            return View();
        }

        // GET: SaaS__Message__Modele/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__Message__Modele/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaaS__Message__Modele/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SaaS__Message__Modele/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__Message__Modele/Edit/5
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

        // GET: SaaS__Message__Modele/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaaS__Message__Modele/Delete/5
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
