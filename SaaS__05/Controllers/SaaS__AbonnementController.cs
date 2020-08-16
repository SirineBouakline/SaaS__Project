using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaaS__05.Models;
using System.Web.Mvc;
using SaaS__05.Models;
using System.Data.SqlClient;
namespace SaaS__05.Controllers
{
    public class SaaS__AbonnementController : Controller
    {
        

        // GET: SaaS__Abonnement/Index
        public ActionResult Index()
        {
            //var model = db.SaaS__Abonnement.Select(x => new
            //{
            //    ID_ = x.ID,
            //    Title = x.Title,
            //    Description=x.Description
            //};
            //return View(model);
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Abonnement.ToList());
        }

        // GET: SaaS__Abonnement/Details/5
        public ActionResult Details(Guid id)
        {
            using (DbModel DbModel = new DbModel())
            {
                return View(DbModel.SaaS__Abonnement.Where(x=>x.ID_ ==id).FirstOrDefault());
            }
               
        }

        // GET: SaaS__Abonnement/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: SaaS__Abonnement/Create
        [HttpPost]
        public ActionResult Create(SaaS__Abonnement abonnement)
        {
            SaaS__Abonnement abo = new SaaS__Abonnement
            {
                ID_ = Guid.NewGuid(),
                Description = abonnement.Description,
                Title = abonnement.Title
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Abonnement.Add(abo);
                    DbModel.SaveChanges();

                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }
        }

           
        // GET: SaaS__Abonnement/Edit/5
        public ActionResult Edit(Guid id)
        {
            using (DbModel DbModel = new DbModel())
            {
                return View(DbModel.SaaS__Abonnement.Where(x => x.ID_ == id).FirstOrDefault());
            }
        }

        // POST: SaaS__Abonnement/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, SaaS__Abonnement abonnement)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModel DbModel = new DbModel())
                {
                    DbModel.Entry(abonnement).State = System.Data.Entity.EntityState.Modified;
                    DbModel.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SaaS__Abonnement/Delete/5
        public ActionResult Delete(Guid id)
        {
            using (DbModel DbModel = new DbModel())
            {
                SaaS__Abonnement abo = DbModel.SaaS__Abonnement.Find(id);
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
                    SaaS__Abonnement abo = DbModel.SaaS__Abonnement.Where(x => x.ID_ == id).FirstOrDefault();
                    DbModel.SaaS__Abonnement.Remove(abo);
                    DbModel.SaveChanges();
                }
                    return RedirectToAction("Index");            
        }
        
    }
}

