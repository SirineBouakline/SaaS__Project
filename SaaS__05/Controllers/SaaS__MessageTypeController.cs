﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SaaS__05.Models;
using System.Web.Mvc;

namespace SaaS__05.Controllers
{
    public class SaaS__MessageTypeController : Controller
    {
        DbModel db = new DbModel();
        // GET: SaaS__MessageType
        public ActionResult Index()
        {
            DbModel DbModel = new DbModel();
            return View(DbModel.SaaS__Message__Type.ToList());
        }

        // GET: SaaS__MessageType/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaaS__MessageType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaaS__MessageType/Create
        [HttpPost]
        public ActionResult Create(SaaS__Message__Type Messagetype)
        {
            SaaS__Message__Type Mt = new SaaS__Message__Type
            {
                ID_ = Guid.NewGuid(),
                Title = Messagetype.Title
            };
            using (DbModel DbModel = new DbModel())
            {
                try
                {
                    DbModel.SaaS__Message__Type.Add(Mt);
                    DbModel.SaveChanges();

                }
                catch (Exception e)
                {
                    return View(e.Message);
                }

                return RedirectToAction("Index");
            }
        }

        // GET: SaaS__MessageType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaaS__MessageType/Edit/5
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

        // GET: SaaS__MessageType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaaS__MessageType/Delete/5
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
