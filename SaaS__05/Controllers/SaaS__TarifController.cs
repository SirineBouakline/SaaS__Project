﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SaaS__05.Models;

namespace SaaS__05.Controllers
{
    public class SaaS__TarifController : Controller
    {
        DbModel db = new DbModel();
        // GET: SaaS__Tarif
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Tarif.ToList());
        }

        // GET: SaaS__Tarif/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__Tarif/Create
        public ActionResult Create()
        {
            List<SaaS__Abonnement> listeabo = db.SaaS__Abonnement.ToList();
            Console.WriteLine(listeabo);
            ViewData["Abos"] = listeabo;
            return View();
            
        }

        // POST: SaaS__Tarif/Create
        [HttpPost]
        public ActionResult Create(SaaS__Tarif tarif, string abonnement)
        {
            List<SaaS__Abonnement> listeabo = db.SaaS__Abonnement.ToList();
            SaaS__Abonnement abon = listeabo.Find(s => s.Title.Equals(abonnement));
            SaaS__Tarif tariff = new SaaS__Tarif
            {
                ID_ = Guid.NewGuid(),
                Description = tarif.Description,
                Tarif__Forfaitaire__Annuel = tarif.Tarif__Forfaitaire__Annuel,
                Date__Debut = DateTime.Now,
                Date__Fin= tarif.Date__Fin,
                Tarif__Forfaitaire__Mensuel = tarif.Tarif__Forfaitaire__Mensuel,
                Tarif__Par__Utilisateur__Annuel = tarif.Tarif__Par__Utilisateur__Annuel,
                Tarif__Par__Utilisateur__Mensuel = tarif.Tarif__Par__Utilisateur__Mensuel
                //ID____SaaS__Abonnement= abon.ID_          
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Tarif.Add(tariff);
                    DbModel.SaveChanges();

                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }
        }

        // GET: SaaS__Tarif/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__Tarif/Edit/5
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

        // GET: SaaS__Tarif/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaaS__Tarif/Delete/5
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
