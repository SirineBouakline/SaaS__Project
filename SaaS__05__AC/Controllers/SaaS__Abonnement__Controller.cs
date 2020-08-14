using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaaS__05__AC.Models;

namespace SaaS__05__AC.Controllers
{
    public class SaaS__Abonnement__Controller : Controller
    {
        // GET: SaaS__Abonnement__
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Abonnement.ToList());
        }

        // GET: SaaS__Abonnement__/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__Abonnement__/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaaS__Abonnement__/Create
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

        // GET: SaaS__Abonnement__/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__Abonnement__/Edit/5
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

        // GET: SaaS__Abonnement__/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaaS__Abonnement__/Delete/5
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
