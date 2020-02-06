using EnveronementNaws.Data;
using EnveronementNaws.Models;
using EnveronementNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace EnveronementNews.Controllers
{
    public class GestionnerController : ApiController
    {


        

        
        public IQueryable<Gestionner> GetGestionner()
        {
            return db.Gestionner;
        }
        [ResponseType(typeof(Gestionner))]
        public IHttpActionResult GetGestionner(int id)
        {
            Gestionner Gestionner = db.Gestionner.Find(id);
            if (Gestionner == null)
            {
                return NotFound();
            }

            return Ok(Gestionner);
        }
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGestionner(int id, Gestionner Gestionner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Gestionner.ID)
            {
                return BadRequest();
            }

            db.Entry(Gestionner).State = EntityState.Modified;
            db.SaveChanges();
           

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Gestionners
        [ResponseType(typeof(Gestionner))]
        public IHttpActionResult PostGestionner(Gestionner Gestionner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Gestionner.Add(Gestionner);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = Gestionner.ID }, Gestionner);
        }

        // DELETE: api/Gestionner/5
        [ResponseType(typeof(Gestionner))]
        public IHttpActionResult DeleteGestionner(int id)
        {
            Gestionner Gestionner = db.Gestionner.Find(id);
            if (Gestionner == null)
            {
                return NotFound();
            }

            db.Gestionner.Remove(Gestionner);
            db.SaveChanges();

            return Ok(Gestionner);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        
        private NEWSEntities db = new NEWSEntities();
        




       
    }
    }

