using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaaS__05.Models;

namespace SaaS__05.Controllers
{
    public class SaaS__AbonnementModuleController : Controller
    {
        // GET: SaaS__AbonnementModule
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Abonnement__Module.ToList());
        }

        // GET: SaaS__AbonnementModule/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__AbonnementModule/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaaS__AbonnementModule/Create
        [HttpPost]
        public ActionResult Create(SaaS__Abonnement__Module module)
        {
            SaaS__Abonnement__Module abo = new SaaS__Abonnement__Module
            {
                ID_ = Guid.NewGuid(),
                Title = module.Title
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Abonnement__Module.Add(abo);
                    DbModel.SaveChanges();

                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }
        }

        // GET: SaaS__AbonnementModule/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__AbonnementModule/Edit/5
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

        // GET: SaaS__AbonnementModule/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaaS__AbonnementModule/Delete/5
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
