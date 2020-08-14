using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SaaS__05.Models;


namespace SaaS__05.Controllers
{
    public class SaaS__APi__AbonnementController : ApiController
    {
        public Models.DbModel db = new Models.DbModel();

        // GET: api/SaaS__APi__Abonnement
        public IHttpActionResult GetSaaS__Abonnement()
        {
            return Json(db.SaaS__Abonnement.ToList());
        }

        //GET: api/SaaS__APi__Abonnement/5
        [ResponseType(typeof(SaaS__Abonnement))]
        public IHttpActionResult GetSaaS__Abonnement(Guid id)
        {
            SaaS__Abonnement saaS__Abonnement = db.SaaS__Abonnement.Find(id);
            SaaS__Abonnement abo = new SaaS__Abonnement
            {
                ID_ = saaS__Abonnement.ID_,
                Description = saaS__Abonnement.Description,
                Title = saaS__Abonnement.Title,
            };
            return Json(abo);
        }


        // PUT: api/SaaS__APi__Abonnement/5
        //[ResponseType(typeof(void))]
        [HttpPut]
        public IHttpActionResult Put(Guid id, SaaS__Abonnement em)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new Models.DbModel())
            {
                var existingAbo = ctx.SaaS__Abonnement.Where(e => e.ID_ == id)
                                                        .FirstOrDefault<SaaS__Abonnement>();

                if (existingAbo != null)
                {
                    existingAbo.Title = em.Title;
                    existingAbo.Description = em.Description;
                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }

        // POST: api/SaaS__APi__Abonnement
        //[ResponseType(typeof(SaaS__Abonnement))]
        [HttpPost]
        public IHttpActionResult PostSaaS__Abonnement(SaaS__Abonnement saaS__Abonnement)
        {

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            using (var db = new Models.DbModel())
            {
                 saaS__Abonnement = new SaaS__Abonnement()
                {
                    ID_ = Guid.NewGuid(),
                    Title=saaS__Abonnement.Title,
                    Description=saaS__Abonnement.Description
                };
                db.SaaS__Abonnement.Add(saaS__Abonnement);
                db.SaveChanges();

            }            
                       
            return CreatedAtRoute("DefaultApi", new { id = saaS__Abonnement.ID_ }, saaS__Abonnement);
           // return Ok();
                    


            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (DbUpdateException)
            //{
            //    if (SaaS__AbonnementExists(saaS__Abonnement.ID_))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return CreatedAtRoute("DefaultApi", new { id = saaS__Abonnement.ID_ }, saaS__Abonnement);
        }
       
        //DELETE: api/SaaS__APi__Abonnement/5
        [ResponseType(typeof(SaaS__Abonnement))]
        public IHttpActionResult DeleteSaaS__Abonnement(Guid id)
        {
                SaaS__Abonnement saaS__Abonnement = db.SaaS__Abonnement.Find(id);
                db.SaaS__Abonnement.Remove(saaS__Abonnement);
                db.SaveChanges();

                return Ok(saaS__Abonnement);
        }
    }




    //protected override void Dispose(bool disposing)
    //{
    //    if (disposing)
    //    {
    //        db.Dispose();
    //    }
    //    base.Dispose(disposing);
    //}

    //private bool SaaS__AbonnementExists(Guid id)
    //{
    //    return db.SaaS__Abonnement.Count(e => e.ID_ == id) > 0;
    //}
}

