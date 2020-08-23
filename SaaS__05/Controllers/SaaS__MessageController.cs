using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaaS__05.Models;

namespace SaaS__05.Controllers
{
    public class SaaS__MessageController : Controller
    {
        DbModel db = new DbModel();
        // GET: SaaS__Message
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Message.ToList());
        }

        // GET: SaaS__Message/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__Message/Create
        public ActionResult Create()
        {
            List<SaaS__Message__Modele> listeabo = db.SaaS__Message__Modele.ToList();
            ViewData["Abos"] = listeabo;
            return View();
        }

        // POST: SaaS__Message/Create
        [HttpPost]
        public ActionResult Create(SaaS__Message message, string messagemodele, string messagetype)
        {
            List<SaaS__Message__Modele> listeabo = db.SaaS__Message__Modele.ToList();
            SaaS__Message__Modele abon = listeabo.Find(s => s.Title.Equals(messagemodele));
            SaaS__Message abo = new SaaS__Message
            {
                ID_ = Guid.NewGuid(),
                Destinataire= message.Destinataire,
                Date_Envoi= message.Date_Envoi,
                Heure_Envoi= message.Heure_Envoi,
                Message= message.Message,
                ID____SaaS__Message__Modele=abon.ID_,
                Title=message.Title
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Message.Add(abo);
                    DbModel.SaveChanges();

                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }
        }

        // GET: SaaS__Message/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__Message/Edit/5
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

        // GET: SaaS__Message/Delete/5
        public ActionResult Delete(Guid id)
        {
            using (DbModel DbModel = new DbModel())
            {
                SaaS__Message abo = DbModel.SaaS__Message.Find(id);
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
                SaaS__Message abo = DbModel.SaaS__Message.Where(x => x.ID_ == id).FirstOrDefault();
                DbModel.SaaS__Message.Remove(abo);
                DbModel.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
